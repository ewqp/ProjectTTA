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

        private DBGenre _dbGenre = new DBGenre();
        private List<EntityModel.BookGenre> _genreList;

        public EditGenre()
        {
            InitializeComponent();
            _genreList = _dbGenre.GetAllBookGenres();
            SetDataGrid();
        }

        /// <summary>
        /// Generate table
        /// </summary>
        private void SetDataGrid()
        {
            dataGridGenres.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridGenres.DataSource = _genreList; //ustawienie datasource
            dataGridGenres.Columns["genre"].DataPropertyName = "Genre";
        }

        private void textBoxSearchGenre_TextChanged(object sender, EventArgs e)
        {
            List<EntityModel.BookGenre> list = _genreList.Where(b => b.Genre.Contains(textBoxSearchGenre.Text)).ToList();

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
            dataGridGenres.DataSource = _genreList;

            dataGridGenres.CurrentCell = dataGridGenres.Rows[bookmarkRowIndex].Cells[bookmarkColumnIndex];
        }

        private void buttonCancelGenre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
