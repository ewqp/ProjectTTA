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
<<<<<<< HEAD
        private DBAuthor _dbAuthor = new DBAuthor();
        private DBBook _dbBook = new DBBook();
        private List<AuthorInfo> _authorList;
        private List<BookInfo> _bookList;
=======
        private Library.Logics.DBBook _dbBook = new DBBook();
        private Library.Logics.DBGenre _dbGenre = new DBGenre();
        DBAuthor _dbAuthor = new DBAuthor();
        private List<BookInfo> _booksList;
        private List<AuthorInfo> _authorList;
        private List<EntityModel.BookGenre> _genreList;
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440

        public EditAuthor()
        {
            InitializeComponent();

            _authorList = _dbAuthor.GetAllAuthors();
            _bookList = _dbBook.GetReallyAllBooksInfo();
            SetDataGrid();

        }

        private void SetDataGrid()
        {
            dataGridSearchAuthor.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridSearchAuthor.DataSource = _authorList; //ustawienie datasource
<<<<<<< HEAD
            dataGridSearchAuthor.Columns["name"].DataPropertyName = "AuthorName";
            dataGridSearchAuthor.Columns["surname"].DataPropertyName = "AuthorSurname";
        }

=======
            dataGridSearchAuthor.Columns["surname"].DataPropertyName = "AuthorSurname";
            dataGridSearchAuthor.Columns["name"].DataPropertyName = "AuthorName";           
        }
 
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
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
<<<<<<< HEAD
                textBoxName.Text = row.Cells["name"].Value.ToString();
                textBoxSurname.Text = row.Cells["surname"].Value.ToString();
=======
                textBoxName.Text = row.Cells["surname"].Value.ToString();
                textBoxSurname.Text = row.Cells["name"].Value.ToString();
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            }
        }

        private void buttonUpdateAuthor_Click(object sender, EventArgs e)
        {
            int idAuthor = ((AuthorInfo)dataGridSearchAuthor.CurrentRow.DataBoundItem).IdAuthor;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;

<<<<<<< HEAD
=======
            int bookmarkRowIndex = dataGridSearchAuthor.CurrentCell.RowIndex;
            int bookmarkColumnIndex = dataGridSearchAuthor.CurrentCell.ColumnIndex;

>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            string authorUpdated = _dbAuthor.UpdateAuthor(idAuthor, name, surname);

            _authorList = _dbAuthor.GetAllAuthors();
            dataGridSearchAuthor.DataSource = _authorList;

<<<<<<< HEAD
            lblMsg.Text = authorUpdated;
=======
            dataGridSearchAuthor.CurrentCell = dataGridSearchAuthor.Rows[bookmarkRowIndex].Cells[bookmarkColumnIndex];
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
        }

        private void buttonDeleteAuthor_Click(object sender, EventArgs e)
        {
            int idAuthor = ((AuthorInfo)dataGridSearchAuthor.CurrentRow.DataBoundItem).IdAuthor;

            List<BookInfo> list = _bookList.Where(b => b.IdAuthor == idAuthor).ToList();
            if (list.Count == 0)
            {
                string authorDeleted = _dbAuthor.DeleteAuthor(idAuthor);

                _authorList = _dbAuthor.GetAllAuthors();
                dataGridSearchAuthor.DataSource = _authorList;
                lblMsg.Text = authorDeleted;
            }
            else
            {
                MessageBox.Show("You cannot delete author, that is connecet to any book.", "Warning");
                //jakis break 
                this.Close();
            }
        }

        private void buttonCancelAuthor_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
