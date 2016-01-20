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

namespace Library.GUI
{
    public partial class LibraryMenu : Form
    {
        public LibraryMenu()
        {
            new LogIn().ShowDialog();
            InitializeComponent();

            if (UserInfoStatic.UserRole == "Administrator")
                groupBoxDBOperation.Visible = true;
            
            lblHello.Text = string.Format("Hello {0} {1}", UserInfoStatic.UserName, UserInfoStatic.UserSurname);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            new AddBook().ShowDialog();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            new EditBook().ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {            
            UserInfoStatic.UserName = "";
            UserInfoStatic.UserSurname = "";
            UserInfoStatic.UserRole = "";
            new LogIn().ShowDialog();

            if (UserInfoStatic.UserRole == "Administrator")
                groupBoxDBOperation.Visible = true;
            else
                groupBoxDBOperation.Visible = false;

            lblHello.Text = string.Format("Hello {0} {1}", UserInfoStatic.UserName, UserInfoStatic.UserSurname);
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            new AddUser().ShowDialog();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            new EditUser().ShowDialog();
        }

        private void btnBookRent_Click(object sender, EventArgs e)
        {
            new RentBooks().ShowDialog();
        }

        private void btnShowHist_Click(object sender, EventArgs e)
        {
            new ShowHistory().ShowDialog();
        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            new ReturnBook().ShowDialog();
        }
    }
}
