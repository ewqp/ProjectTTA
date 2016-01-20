using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library.EntityModel;
using Library.Logics;
using Library.Models;

namespace Library.GUI
{
    public partial class LogIn : Form
    {
        private Library.Logics.DBUser _dbUser = new DBUser();
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxUserName.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                string communicate = _dbUser.TakeUserData(textBoxUserName.Text, textBoxPassword.Text);
                if (communicate != "Success")
                {
                    labelMsg.Text = communicate;
                    return;
                }
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserInfoStatic.UserName))
                if (DialogResult.Cancel == MessageBox.Show("You have to enter email and password! Otherwise application shuts down.", "Warning", MessageBoxButtons.OKCancel))
                    Application.Exit();            
        }
    }
}
