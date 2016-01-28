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
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBoxAccName.Text = row.Cells["name"].Value.ToString();
                textBoxAccSur.Text = row.Cells["surname"].Value.ToString();
                textBoxAccEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btnAccUpdate_Click(object sender, EventArgs e)
        {
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
        }

        private void btnAccDel_Click(object sender, EventArgs e)
        {
            int idAccount = ((AccountInfo)dataGridAccount.CurrentRow.DataBoundItem).IdAccount;

            string accountDeleted = _dbAccount.DeleteAccount(idAccount);

            _accountList = _dbAccount.GetAllAccountsInfo();
            dataGridAccount.DataSource = _accountList;
            lblMsg.Text = accountDeleted;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
