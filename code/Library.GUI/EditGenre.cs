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
    public partial class EditGenre : Form
    {

<<<<<<< HEAD
        private Library.Logics.DBBookGenre _dbGenre = new DBBookGenre();
        private DBBook _dbBook = new DBBook();
        private List<BookGenreInfo> _genreList;
=======
<<<<<<< HEAD
        private Library.Logics.DBGenre _dbGenre = new DBGenre();
        private DBBook _dbBook = new DBBook();
=======
        private DBGenre _dbGenre = new DBGenre();
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
        private List<EntityModel.BookGenre> _genreList;
>>>>>>> f9715373b5f16790bf1b0ea97406fb760cf51e0c
        private List<BookInfo> _bookList;

        public EditGenre()
        {
            InitializeComponent();
            _genreList = _dbGenre.GetAllBookGenres();
            _bookList = _dbBook.GetReallyAllBooksInfo();
            SetDataGrid();
        }

        /// <summary>
        /// Generate table
        /// </summary>
        private void SetDataGrid()
        {
<<<<<<< HEAD
            dataGridSearchGenre.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridSearchGenre.DataSource = _genreList; //ustawienie datasource
            dataGridSearchGenre.Columns["genre"].DataPropertyName = "Genre";
<<<<<<< HEAD
=======
=======
            dataGridGenres.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridGenres.DataSource = _genreList; //ustawienie datasource
            dataGridGenres.Columns["genre"].DataPropertyName = "Genre";
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
>>>>>>> f9715373b5f16790bf1b0ea97406fb760cf51e0c
        }

        private void textBoxSearchGenre_TextChanged(object sender, EventArgs e)
        {
            List<BookGenreInfo> list = _genreList.Where(b => b.Genre.Contains(textBoxSearchGenre.Text)).ToList();

            dataGridGenres.DataSource = list;
        }

        private void dataGridGenres_Click(object sender, EventArgs e)
        {
            dataGridGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridGenres.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBoxGenreName.Text = row.Cells["genre"].Value.ToString();

            }
        }

        private void buttonUpdateGenre_Click(object sender, EventArgs e)
        {
            int idGenre = ((EntityModel.BookGenre)dataGridGenres.CurrentRow.DataBoundItem).IdGenre;
            string genre = textBoxGenreName.Text;

            int bookmarkRowIndex = dataGridGenres.CurrentCell.RowIndex;
            int bookmarkColumnIndex = dataGridGenres.CurrentCell.ColumnIndex;

            string genreUpdated = _dbGenre.UpdateBookGenre(idGenre, genre);

            _genreList = _dbGenre.GetAllBookGenres();
<<<<<<< HEAD
            dataGridSearchGenre.DataSource = _genreList;
            lblMsg.Text = genreUpdated;
<<<<<<< HEAD
=======
=======
            dataGridGenres.DataSource = _genreList;

            dataGridGenres.CurrentCell = dataGridGenres.Rows[bookmarkRowIndex].Cells[bookmarkColumnIndex];
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
>>>>>>> f9715373b5f16790bf1b0ea97406fb760cf51e0c
        }

        private void buttonCancelGenre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDeleteGenre_Click(object sender, EventArgs e)
        {
            int idGenre = ((EntityModel.BookGenre)dataGridSearchGenre.CurrentRow.DataBoundItem).IdGenre;

            List<BookInfo> list = _bookList.Where(g => g.IdGenre == idGenre).ToList();
            if (list.Count == 0)
            {
                string genreDeleted = _dbGenre.DeleteBookGenre(idGenre);

                _genreList = _dbGenre.GetAllBookGenres();
                dataGridSearchGenre.DataSource = _genreList;
                lblMsg.Text = genreDeleted;
            }
            else
            {
                MessageBox.Show("You cannot delete genre, that is connecet to any book.", "Warning");
                //jakis break 
                this.Close();
            }
        }
    }
}
