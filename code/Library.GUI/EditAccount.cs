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
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                txtBoxAccSur.Text = row.Cells["AccountSurname"].Value.ToString();
                txtBoxAccName.Text = row.Cells["name"].Value.ToString();
                txtBoxAccEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btnAccUpdate_Click(object sender, EventArgs e)
        {
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
        }

        private void btnAccDel_Click(object sender, EventArgs e)
        {
            int idAccount = ((AccountInfo)dataGridAccs.CurrentRow.DataBoundItem).IdAccount;

            string accountDeleted = _dbAccount.DeleteAccount(idAccount);

            _accountList = _dbAccount.GetAllAccountsInfo();
            dataGridAccs.DataSource = _accountList;
        }

        private void btnAccCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
