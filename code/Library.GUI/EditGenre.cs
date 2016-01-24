﻿using System;
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

        private Library.Logics.DBGenre _dbGenre = new DBGenre();
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
            dataGridSearchGenre.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridSearchGenre.DataSource = _genreList; //ustawienie datasource
            dataGridSearchGenre.Columns["Genre"].DataPropertyName = "Genre";
        }

        private void textBoxSearchGenre_TextChanged(object sender, EventArgs e)
        {
            List<EntityModel.BookGenre> list = _genreList.Where(b => b.Genre.Contains(textBoxSearchGenre.Text)).ToList();

            dataGridSearchGenre.DataSource = list;
        }

        private void dataGridSearchGenre_SelectionChanged(object sender, EventArgs e)
        {
            dataGridSearchGenre.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridSearchGenre.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBoxGenreName.Text = row.Cells["Genre"].Value.ToString();

            }
        }

        private void buttonUpdateGenre_Click(object sender, EventArgs e)
        {
            int idGenre = ((EntityModel.BookGenre)dataGridSearchGenre.CurrentRow.DataBoundItem).IdGenre;
            string genre = textBoxGenreName.Text;

            string genreUpdated = _dbGenre.UpdateBookGenre(idGenre, genre);

            _genreList = _dbGenre.GetAllBookGenres();
            dataGridSearchGenre.DataSource = _genreList;
        }

        private void buttonCancelGenre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}