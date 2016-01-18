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
        private DBGenre _dbGenre = new DBGenre();
        private DBUser _dbUser = new DBUser();
        private List<BookInfo> _booksList;
        private List<UserInfo> _usersList;
        public RentBooks()
        {
            InitializeComponent();
            _booksList = _dbBook.GetAllBooksInfo();
            _usersList = _dbUser.GetAllUsersInfo();
            SetDataGrid();
        }
        /// <summary>
        /// Generate tables
        /// </summary>
        private void SetDataGrid()
        {
            dataGridUsers.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridUsers.DataSource = _usersList; //ustawienie datasource
            dataGridUsers.Columns["userFullName"].DataPropertyName = "FullUserName";
            dataGridUsers.Columns["userEmail"].DataPropertyName = "Email";

            dataGridRent.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridRent.DataSource = _booksList; //ustawienie datasource
            dataGridRent.Columns["Title"].DataPropertyName = "Title";
            dataGridRent.Columns["Author"].DataPropertyName = "FullName";
            dataGridRent.Columns["Genre"].DataPropertyName = "Genre";
        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {
            List<UserInfo> listU = _usersList.Where(u => u.Surname.Contains(textBoxUser.Text)).ToList();

            dataGridUsers.DataSource = listU;
        }

        private void txtBoxBook_TextChanged(object sender, EventArgs e)
        {
            List<BookInfo> listB = _booksList.Where(b => b.Title.Contains(txtBoxBook.Text)).ToList();

            dataGridRent.DataSource = listB;
        }
    }
}
