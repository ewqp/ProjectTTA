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
    public partial class EditAccount : Form
    {
        private DBAccount _dbAccount = new DBAccount();
        private List<AccountInfo> _accountList;
        public EditAccount()
        {
            InitializeComponent();
            _accountList = _dbAccount.GetAllAccountsInfo();
            SetDataGrid();
        }

<<<<<<< HEAD
        private void SetDataGrid()
        {
            dataGridAccount.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridAccount.DataSource = _accountList; //ustawienie datasource
            dataGridAccount.Columns["name"].DataPropertyName = "AccountName";
            dataGridAccount.Columns["surname"].DataPropertyName = "AccountSurname";
            dataGridAccount.Columns["email"].DataPropertyName = "AccountEmail";
        }

        private void textBoxAccSearch_TextChanged(object sender, EventArgs e)
        {
            List<AccountInfo> list = _accountList.Where(b => b.FullAccountName.Contains(textBoxAccSearch.Text)).ToList();

            dataGridAccount.DataSource = list;
        }

        private void dataGridAccount_Click(object sender, EventArgs e)
        {
            dataGridAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridAccount.SelectedCells)
=======
        /// <summary>
        /// Generate table
        /// </summary>
        private void SetDataGrid()
        {
            dataGridAccs.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridAccs.DataSource = _accountList; //ustawienie datasource
            dataGridAccs.Columns["surname"].DataPropertyName = "AccountSurname";
            dataGridAccs.Columns["name"].DataPropertyName = "AccountName";            
            dataGridAccs.Columns["email"].DataPropertyName = "AccountEmail";
        }

        private void txtBoxSearchAcc_TextChanged(object sender, EventArgs e)
        {
            List<AccountInfo> list = _accountList.Where(a => a.AccountEmail.Contains(txtBoxAccEmail.Text)).ToList();

            dataGridAccs.DataSource = list;
        }

        private void dataGridAccs_Click(object sender, EventArgs e)
        {
            dataGridAccs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridAccs.SelectedCells)
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
<<<<<<< HEAD
                textBoxAccName.Text = row.Cells["name"].Value.ToString();
                textBoxAccSur.Text = row.Cells["surname"].Value.ToString();
                textBoxAccEmail.Text = row.Cells["email"].Value.ToString();
=======
                txtBoxAccSur.Text = row.Cells["AccountSurname"].Value.ToString();
                txtBoxAccName.Text = row.Cells["name"].Value.ToString();
                txtBoxAccEmail.Text = row.Cells["email"].Value.ToString();
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
            }
        }

        private void btnAccUpdate_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int idAccount = ((AccountInfo)dataGridAccount.CurrentRow.DataBoundItem).IdAccount;
            string name = textBoxAccName.Text;
            string surname = textBoxAccSur.Text;
            string email = textBoxAccEmail.Text;

            int bookmarkRowIndex = dataGridAccount.CurrentCell.RowIndex;
            int bookmarkColumnIndex = dataGridAccount.CurrentCell.ColumnIndex;

            string accountUpdated = _dbAccount.UpdateAccount(idAccount, name, surname, email);

            _accountList = _dbAccount.GetAllAccountsInfo();
            dataGridAccount.DataSource = _accountList;

            dataGridAccount.CurrentCell = dataGridAccount.Rows[bookmarkRowIndex].Cells[bookmarkColumnIndex];
            lblMsg.Text = accountUpdated;
=======
            int idAccount = ((AccountInfo)dataGridAccs.CurrentRow.DataBoundItem).IdAccount;
            string accountName = txtBoxAccName.Text;
            string accountSurname = txtBoxAccSur.Text;            
            string accountEmail = txtBoxAccEmail.Text;

            int bookmarkRowIndex = dataGridAccs.CurrentCell.RowIndex;
            int bookmarkColumnIndex = dataGridAccs.CurrentCell.ColumnIndex;

            string accountUpdated = _dbAccount.UpdateAccount(idAccount, accountName, accountSurname, accountEmail);

            _accountList = _dbAccount.GetAllAccountsInfo();
            dataGridAccs.DataSource = _accountList;

            dataGridAccs.CurrentCell = dataGridAccs.Rows[bookmarkRowIndex].Cells[bookmarkColumnIndex];
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
        }

        private void btnAccDel_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            int idAccount = ((AccountInfo)dataGridAccount.CurrentRow.DataBoundItem).IdAccount;
=======
            int idAccount = ((AccountInfo)dataGridAccs.CurrentRow.DataBoundItem).IdAccount;
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440

            string accountDeleted = _dbAccount.DeleteAccount(idAccount);

            _accountList = _dbAccount.GetAllAccountsInfo();
<<<<<<< HEAD
            dataGridAccount.DataSource = _accountList;
            lblMsg.Text = accountDeleted;
        }

        private void btnCancel_Click(object sender, EventArgs e)
=======
            dataGridAccs.DataSource = _accountList;
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
>>>>>>> 247047363bb99edbf97eb8e64a40332c87e64440
        {
            this.Close();
        }
    }
}
