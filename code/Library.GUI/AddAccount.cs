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
<<<<<<< HEAD
using Library.Models;
=======
using Library.EntityModel;
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440

namespace Library.GUI
{
    public partial class AddAccount : Form
    {
<<<<<<< HEAD
        private DBAccount _dbAccount = new DBAccount();

=======
        private DBAccount _dbAccount = new DBAccount();        
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
        public AddAccount()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void buttonAccAdd_Click(object sender, EventArgs e)
        {
            string result = _dbAccount.AddAccount(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text);
            lblMsg.Text = result;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
=======
        private void btnSaveAcc_Click(object sender, EventArgs e)
        {
            string result = _dbAccount.AddAccount(txtBoxAccName.Text, txtBoxAccSur.Text, txtBoxAccEmail.Text);
        }

        private void btnCancelAcc_Click(object sender, EventArgs e)
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
        {
            this.Close();
        }
    }
}
