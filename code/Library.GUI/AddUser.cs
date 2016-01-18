using System;
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
    public partial class AddUser : Form
    {
        private Library.Logics.DBUser _dbUser = new DBUser();
        private Library.Logics.DBRole _dbRole = new DBRole();
        public AddUser()
        {
            InitializeComponent();
            
            comboBoxRole.DataSource = _dbRole.GetAllUserRoles();
            comboBoxRole.ValueMember = "IdUserRole";
            comboBoxRole.DisplayMember = "UserRole1";
        }

        private void buttonCancelSaveUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveUser_Click(object sender, EventArgs e)
        {
            string result = _dbUser.AddUser(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text,  Convert.ToInt32(comboBoxRole.SelectedValue), textBoxPassword.Text);
        }

    }
}
