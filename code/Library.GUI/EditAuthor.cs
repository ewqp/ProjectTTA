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
    public partial class EditAuthor : Form
    {
        private Library.Logics.DBBook _dbBook = new DBBook();
        private Library.Logics.DBGenre _dbGenre = new DBGenre();
        DBAuthor _dbAuthor = new DBAuthor();
        private List<BookInfo> _booksList;
        private List<AuthorInfo> _authorList;
        private List<EntityModel.BookGenre> _genreList;

        public EditAuthor()
        {
            InitializeComponent();

            _authorList = _dbAuthor.GetAllAuthors();
            SetDataGrid();

        }

        private void SetDataGrid()
        {
            dataGridSearchAuthor.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridSearchAuthor.DataSource = _authorList; //ustawienie datasource
            dataGridSearchAuthor.Columns["surname"].DataPropertyName = "AuthorSurname";
            dataGridSearchAuthor.Columns["name"].DataPropertyName = "AuthorName";           
        }
 
        private void textBoxSearchAuthor_TextChanged(object sender, EventArgs e)
        {
            List<AuthorInfo> list = _authorList.Where(b => b.FullAuthorName.Contains(textBoxSearchAuthor.Text)).ToList();

            dataGridSearchAuthor.DataSource = list;
        }

        private void dataGridSearchAuthor_Click(object sender, EventArgs e)
        {
            dataGridSearchAuthor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridSearchAuthor.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBoxName.Text = row.Cells["surname"].Value.ToString();
                textBoxSurname.Text = row.Cells["name"].Value.ToString();
            }
        }

        private void buttonUpdateAuthor_Click(object sender, EventArgs e)
        {
            int idAuthor = ((AuthorInfo)dataGridSearchAuthor.CurrentRow.DataBoundItem).IdAuthor;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;

            int bookmarkRowIndex = dataGridSearchAuthor.CurrentCell.RowIndex;
            int bookmarkColumnIndex = dataGridSearchAuthor.CurrentCell.ColumnIndex;

            string authorUpdated = _dbAuthor.UpdateAuthor(idAuthor, name, surname);

            _authorList = _dbAuthor.GetAllAuthors();
            dataGridSearchAuthor.DataSource = _authorList;

            dataGridSearchAuthor.CurrentCell = dataGridSearchAuthor.Rows[bookmarkRowIndex].Cells[bookmarkColumnIndex];
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            int idAuthor = ((AuthorInfo)dataGridSearchAuthor.CurrentRow.DataBoundItem).IdAuthor;

            string authorDeleted = _dbAuthor.DeleteAuthor(idAuthor);

            _authorList = _dbAuthor.GetAllAuthors();
            dataGridSearchAuthor.DataSource = _authorList;
        }

        private void buttonCancelAuthor_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
