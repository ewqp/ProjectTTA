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
    public partial class AddAccount : Form
    {
        private DBAccount _dbAccount = new DBAccount();

        public AddAccount()
        {
            InitializeComponent();
        }

        private void buttonAccAdd_Click(object sender, EventArgs e)
        {
            string result = _dbAccount.AddAccount(textBoxName.Text, textBoxSurname.Text, textBoxEmail.Text);
            lblMsg.Text = result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
