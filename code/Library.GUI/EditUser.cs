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
    public partial class EditUser : Form
    {
        private Library.Logics.DBUser _dbUser = new DBUser();
        private Library.Logics.DBRole _dbRole = new DBRole();
        private List<UserAllInfo> _usersList;
        public EditUser()
        {
            InitializeComponent();
            _usersList = _dbUser.GetAllUsersInfo();

            SetDataGrid();

            comboBoxRole.DataSource = _dbRole.GetAllUserRoles();
            comboBoxRole.ValueMember = "IdUserRole";
            comboBoxRole.DisplayMember = "UserRole1";
        }
        private void SetDataGrid()
        {
            dataGridSearchBook.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridSearchBook.DataSource = _usersList; //ustawienie datasource
            dataGridSearchBook.Columns["Name1"].DataPropertyName = "Name";
            dataGridSearchBook.Columns["Surname"].DataPropertyName = "Surname";
            dataGridSearchBook.Columns["Email"].DataPropertyName = "Email";
            dataGridSearchBook.Columns["Role"].DataPropertyName = "UserRole";
            dataGridSearchBook.Columns["Password"].DataPropertyName = "UserPassword";

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<UserAllInfo> list = _usersList.Where(b => b.Name.Contains(textBoxSearch.Text)).ToList();

            dataGridSearchBook.DataSource = list;
        }

        private void buttonCancelSaveUser_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            int idUser = ((Models.UserAllInfo)dataGridSearchBook.CurrentRow.DataBoundItem).IdUser;

            string userDeleted = _dbUser.DeleteUser(idUser);

            _usersList = _dbUser.GetAllUsersInfo();
            dataGridSearchBook.DataSource = _usersList;
        }

        private void dataGridSearchBook_SelectionChanged(object sender, EventArgs e)
        {
            dataGridSearchBook.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridSearchBook.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBoxName.Text = row.Cells["Name"].Value.ToString();
                textBoxSurname.Text = row.Cells["Surname"].Value.ToString();
                textBoxEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxPassword.Text = row.Cells["Password"].Value.ToString();
                comboBoxRole.Text = row.Cells["Role"].Value.ToString();

            }
        }
    }

}
