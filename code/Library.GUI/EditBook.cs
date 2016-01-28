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
    public partial class EditBook : Form
    {
        private DBBook _dbBook = new DBBook();
        private DBBookGenre _dbGenre = new DBBookGenre();
        private DBAuthor _dbAuthor = new DBAuthor();
        private List<BookInfo> _booksList;
        private List<AuthorInfo> _authorList;
<<<<<<< HEAD
        private List<BookGenreInfo> _genreList;
=======
        private List<EntityModel.BookGenre> _genreList;
>>>>>>> f9715373b5f16790bf1b0ea97406fb760cf51e0c

        public EditBook()
        {
            InitializeComponent();
            _booksList = _dbBook.GetReallyAllBooksInfo();
            _authorList = _dbAuthor.GetAllAuthors();
            _genreList = _dbGenre.GetAllBookGenres();
            SetDataGrid();            

            comboBoxAuthor.DataSource = _dbAuthor.GetAllAuthors();
            comboBoxAuthor.ValueMember = "IdAuthor";
            comboBoxAuthor.DisplayMember = "FullAuthorName";

            comboBoxBookGenre.DataSource = _dbGenre.GetAllBookGenres();
            comboBoxBookGenre.ValueMember = "IdGenre";
            comboBoxBookGenre.DisplayMember = "Genre";
        }

        /// <summary>
        /// Generate table
        /// </summary>
        private void SetDataGrid()
        {           
            dataGridSearchBook.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridSearchBook.DataSource = _booksList; //ustawienie datasource
            dataGridSearchBook.Columns["Title"].DataPropertyName = "Title";
            dataGridSearchBook.Columns["Author"].DataPropertyName = "FullAuthorName";
            dataGridSearchBook.Columns["Genre"].DataPropertyName = "Genre";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<BookInfo> list = _booksList.Where(b => b.Title.Contains(textBoxSearch.Text) || b.FullAuthorName.Contains(textBoxSearch.Text)).ToList();

            dataGridSearchBook.DataSource = list;
        }

        private void dataGridSearchBook_Click(object sender, EventArgs e)
        {
            dataGridSearchBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridSearchBook.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBoxTitle.Text = row.Cells["Title"].Value.ToString();
                comboBoxAuthor.Text = row.Cells["Author"].Value.ToString();
                comboBoxBookGenre.Text = row.Cells["Genre"].Value.ToString();
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            int idBook = ((BookInfo)dataGridSearchBook.CurrentRow.DataBoundItem).IdBook;
            string title = textBoxTitle.Text;
            int idAuthor = Convert.ToInt32(comboBoxAuthor.SelectedValue);
            int idGenre = Convert.ToInt32(comboBoxBookGenre.SelectedValue);

            int bookmarkRowIndex = dataGridSearchBook.CurrentCell.RowIndex;
            int bookmarkColumnIndex = dataGridSearchBook.CurrentCell.ColumnIndex;            

            string bookUpdated = _dbBook.UpdateBook(idBook, title, idAuthor, idGenre);

            _booksList = _dbBook.GetReallyAllBooksInfo();
            dataGridSearchBook.DataSource = _booksList;

            dataGridSearchBook.CurrentCell = dataGridSearchBook.Rows[bookmarkRowIndex].Cells[bookmarkColumnIndex];
            lblMsg.Text = bookUpdated;
        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            int idBook = ((BookInfo)dataGridSearchBook.CurrentRow.DataBoundItem).IdBook;

            string bookDeleted = _dbBook.DeleteBook(idBook);

            _booksList = _dbBook.GetReallyAllBooksInfo();
            dataGridSearchBook.DataSource = _booksList;
            lblMsg.Text = bookDeleted;
        }

        private void buttonCancelSaveBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }       
    }
}
