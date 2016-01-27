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
    public partial class AddUser : Form
    {
        private DBUser _dbUser = new DBUser();
        private DBUserRoles _dbUserRole = new DBUserRoles();
        public AddUser()
        {
            InitializeComponent();

            comboBoxUserRole.DataSource = _dbUserRole.GetAllUserRoles();
            comboBoxUserRole.ValueMember = "IdUserRole";
            comboBoxUserRole.DisplayMember = "UserRole";
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            string result = _dbUser.AddUser(txtBoxName.Text, textBoxSurname.Text, textBoxEmail.Text, Convert.ToInt32(comboBoxUserRole.SelectedValue), textBoxPass.Text);
            lblMsg.Text = result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
