using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.Models;
using Library.Logics;

namespace Library.GUI
{
    public partial class RentBooks : Form
    {
        private DBBook _dbBook = new DBBook();
        private DBAuthor _dbAuthor = new DBAuthor();
        private DBBookGenre _dbGenre = new DBBookGenre();
        private DBRented _dbRented = new DBRented();
        private DBHistory _dbHistory = new DBHistory();
        private DBAccount _dbAccount = new DBAccount();
        private List<BookInfo> _booksList;
        private List<RentInfo> _entriesList;
        private List<HistoryInfo> _logsList;
        private List<AccountInfo> _accountsList;

        public RentBooks()
        {
            InitializeComponent();
            _booksList = _dbBook.GetAllBooksInfo();
            _entriesList = _dbRented.GetAllEntriesInfo();
            //if (_entriesList.Any(e => e.Error != null))
              //  labelPrzyklad.text = _entriesList.FirstOrDefault(e => e.Error != null));
            _logsList = _dbHistory.GetAllHistoryLogsInfo();
            _accountsList = _dbAccount.GetAllAccountsInfo();
            SetDataGrid();
        }
        /// <summary>
        /// Generate tables
        /// </summary>
        private void SetDataGrid()
        {
            dataGridAccounts.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridAccounts.DataSource = _accountsList; //ustawienie datasource
            dataGridAccounts.Columns["accountName"].DataPropertyName = "FullAccountName";
            dataGridAccounts.Columns["accountEmail"].DataPropertyName = "AccountEmail";

            dataGridRent.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridRent.DataSource = _booksList; //ustawienie datasource
            dataGridRent.Columns["Title"].DataPropertyName = "Title";
            dataGridRent.Columns["Author"].DataPropertyName = "FullAuthorName";
            dataGridRent.Columns["Genre"].DataPropertyName = "Genre";
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            List<AccountInfo> listA = _accountsList.Where(a => a.FullAccountName.Contains(textBoxAccount.Text)).ToList();
                
            dataGridAccounts.DataSource = listA;
        }

        private void txtBoxBook_TextChanged(object sender, EventArgs e)
        {
            List<BookInfo> listB = _booksList.Where(b => b.Title.Contains(txtBoxBook.Text) || b.AuthorSurname.Contains(txtBoxBook.Text)).ToList();

            dataGridRent.DataSource = listB;
        }

        private void dataGridAccounts_Click(object sender, EventArgs e)
        {
            dataGridAccounts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridAccounts.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
            }
        }

        private void dataGridRent_Click(object sender, EventArgs e)
        {
            dataGridRent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridRent.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int idAccount = ((AccountInfo)dataGridAccounts.CurrentRow.DataBoundItem).IdAccount;            
            int idBook = ((BookInfo)dataGridRent.CurrentRow.DataBoundItem).IdBook;
            int idAuthor = ((BookInfo)dataGridRent.CurrentRow.DataBoundItem).IdAuthor;
            DateTime rentDate = DateTime.Now;

            int bookmarkRowIndexA = dataGridAccounts.CurrentCell.RowIndex;
            int bookmarkColumnIndexA = dataGridAccounts.CurrentCell.ColumnIndex;
            int bookmarkRowIndexB = dataGridRent.CurrentCell.RowIndex;
            int bookmarkColumnIndexB = dataGridRent.CurrentCell.ColumnIndex;

            string entryAdded = _dbRented.AddRentEntry(idAccount, idBook, idAuthor, rentDate);
            string logAdded = _dbHistory.AddHistoryEntry(idAccount, idBook, idAuthor, rentDate, 0);

            dataGridAccounts.DataSource = _dbAccount.GetAllAccountsInfo();
            _booksList = _dbBook.GetAllBooksInfo();
            dataGridRent.DataSource = _booksList;
            
            dataGridAccounts.CurrentCell = dataGridAccounts.Rows[bookmarkRowIndexA].Cells[bookmarkColumnIndexA];
            dataGridRent.CurrentCell = dataGridRent.Rows[bookmarkRowIndexB].Cells[bookmarkColumnIndexB];
            lblMsg.Text = entryAdded;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
