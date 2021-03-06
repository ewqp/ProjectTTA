﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Library.Logics;
using Library.EntityModel;

namespace Library.GUI
{
    public partial class AddBook : Form
    {
<<<<<<< HEAD
        private Library.Logics.DBBook _dbBook = new DBBook();
        private Library.Logics.DBBookGenre _dbGenre = new DBBookGenre();
        private Library.Logics.DBAuthor _dbAuthor = new DBAuthor();
=======
        private DBBook _dbBook = new DBBook();
        private DBGenre _dbGenre = new DBGenre();
        private DBAuthor _dbAuthor = new DBAuthor();
>>>>>>> f9715373b5f16790bf1b0ea97406fb760cf51e0c
        private List<Models.AuthorInfo> _authorList;
        private List<Models.BookGenreInfo> _genreList;
        public AddBook()
        {
            InitializeComponent();

            _authorList = _dbAuthor.GetAllAuthors();
            _genreList = _dbGenre.GetAllBookGenres();

            comboBoxAuthor.DataSource = _dbAuthor.GetAllAuthors();
            comboBoxAuthor.ValueMember = "IdAuthor";
            comboBoxAuthor.DisplayMember = "FullAuthorName";

            comboBoxBookGenre.DataSource = _dbGenre.GetAllBookGenres();
            comboBoxBookGenre.ValueMember = "IdGenre";
            comboBoxBookGenre.DisplayMember = "Genre";
        }

        private void buttonSaveBook_Click(object sender, EventArgs e)
        {
            string result = _dbBook.AddBook(textBoxTitle.Text, Convert.ToInt32(comboBoxAuthor.SelectedValue), Convert.ToInt32(comboBoxBookGenre.SelectedValue));
            lblMsg.Text = result;
            
        }

        private void comboBoxAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var list = _authorList.Where(b => b.FullAuthorName.Contains(comboBoxAuthor.Text)).ToList();
                comboBoxAuthor.DataSource = list.Count > 0 && !string.IsNullOrEmpty(comboBoxAuthor.Text)
                                        ? list : _authorList;
            }
        }
        
        private void comboBoxBookGenre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                var list = _genreList.Where(g => g.Genre.Contains(comboBoxAuthor.Text)).ToList();
                comboBoxBookGenre.DataSource = list.Count > 0 && !string.IsNullOrEmpty(comboBoxBookGenre.Text)
                                        ? list : _genreList;
            }
        }

        private void buttonCancelSaveBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
