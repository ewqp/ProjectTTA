using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Logics;
using Library.Models;

namespace Library.GUI
{
    public partial class ReturnBook : Form
    {
        private DBRented _dbRented = new DBRented();
        private DBHistory _dbHistory = new DBHistory();
        private List<RentInfo> _rentList;
        public ReturnBook()
        {
            InitializeComponent();
            _rentList = _dbRented.GetAllEntriesInfo();
            SetDataGrid();
        }
        private void SetDataGrid()
        {
            dataGridRentedBooks.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridRentedBooks.DataSource = _rentList; //ustawienie datasource 
            dataGridRentedBooks.Columns["account"].DataPropertyName = "FullAccountName";
            dataGridRentedBooks.Columns["title"].DataPropertyName = "Title";
            dataGridRentedBooks.Columns["author"].DataPropertyName = "FullAuthorName";
            dataGridRentedBooks.Columns["rentDate"].DataPropertyName = "RentDate";
        }

        private void textBoxSearchRent_TextChanged(object sender, EventArgs e)
        {
            List<RentInfo> list = _rentList.Where(l => l.AccountSurname.Contains(textBoxSearchRent.Text) || l.AuthorSurname.Contains(textBoxSearchRent.Text) || l.Title.Contains(textBoxSearchRent.Text)).ToList();

            dataGridRentedBooks.DataSource = list;
        }

        private void dataGridRentedBooks_Click(object sender, EventArgs e)
        {
            dataGridRentedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridRentedBooks.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            int idRented = ((RentInfo)dataGridRentedBooks.CurrentRow.DataBoundItem).IdRented;
            int idAccount = ((RentInfo)dataGridRentedBooks.CurrentRow.DataBoundItem).IdAccount;
            int idBook = ((RentInfo)dataGridRentedBooks.CurrentRow.DataBoundItem).IdBook;
            int idAuthor = ((RentInfo)dataGridRentedBooks.CurrentRow.DataBoundItem).IdAuthor;
            DateTime rentDate = DateTime.Now;

            int bookmarkRowIndex = dataGridRentedBooks.CurrentCell.RowIndex;
            int bookmarkColumnIndex = dataGridRentedBooks.CurrentCell.ColumnIndex;

            string entryRemoved = _dbRented.DeleteRentEntry(idRented);
            string logAdded = _dbHistory.AddHistoryEntry(idAccount, idBook, idAuthor, rentDate, 1);

            _rentList = _dbRented.GetAllEntriesInfo();
            dataGridRentedBooks.DataSource = _rentList;

            dataGridRentedBooks.CurrentCell = dataGridRentedBooks.Rows[bookmarkRowIndex].Cells[bookmarkColumnIndex];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
