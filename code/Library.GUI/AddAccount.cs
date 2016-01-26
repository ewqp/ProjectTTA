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
using Library.EntityModel;

namespace Library.GUI
{
    public partial class AddAccount : Form
    {
        private DBAccount _dbAccount = new DBAccount();        
        public AddAccount()
        {
            InitializeComponent();
        }

        private void btnSaveAcc_Click(object sender, EventArgs e)
        {
            string result = _dbAccount.AddAccount(txtBoxAccName.Text, txtBoxAccSur.Text, txtBoxAccEmail.Text);
        }

        private void btnCancelAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
