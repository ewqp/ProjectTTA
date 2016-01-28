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
        private DBUser _dbUser = new DBUser();
        private DBUserRoles _dbRole = new DBUserRoles();
        private List<UserInfo> _usersList;
        private List<EntityModel.UserRoles> _rolesList;
     
        public EditUser()
        {
            InitializeComponent();
            _usersList = _dbUser.GetAllUsersInfo();
            _rolesList = _dbRole.GetAllUserRoles();
            SetDataGrid();

            comboBoxRole.DataSource = _dbRole.GetAllUserRoles();
            comboBoxRole.ValueMember = "IdUserRole";
            comboBoxRole.DisplayMember = "UserRole";
        }

        private void SetDataGrid()
        {
            dataGridViewUser.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridViewUser.DataSource = _usersList; //ustawienie datasource
            dataGridViewUser.Columns["UserName"].DataPropertyName = "UserName";
            dataGridViewUser.Columns["UserSurname"].DataPropertyName = "UserSurname";
            dataGridViewUser.Columns["UserEmail"].DataPropertyName = "UserEmail";
            dataGridViewUser.Columns["UserRoles"].DataPropertyName = "UserRole";
            dataGridViewUser.Columns["UserPass"].DataPropertyName = "UserPassword";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            List<UserInfo> list = _usersList.Where(b => b.FullUserName.Contains(textBoxSearch.Text)).ToList();

            dataGridViewUser.DataSource = list;
        }

        private void dataGridViewUser_Click(object sender, EventArgs e)
        {
            dataGridViewUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dataGridViewUser.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                textBoxName.Text = row.Cells["UserName"].Value.ToString();
                textBoxSurname.Text = row.Cells["UserSurname"].Value.ToString();
                textBoxEmail.Text = row.Cells["UserEmail"].Value.ToString();
                comboBoxRole.Text = row.Cells["UserRoles"].Value.ToString();
                textBoxPass.Text = row.Cells["UserPass"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int idUser = ((UserInfo)dataGridViewUser.CurrentRow.DataBoundItem).IdUser;
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string email = textBoxEmail.Text;
            int idUserRole = Convert.ToInt32(comboBoxRole.SelectedValue);
            string password = textBoxPass.Text;

            int bookmarkRowIndex = dataGridViewUser.CurrentCell.RowIndex;
            int bookmarkColumnIndex = dataGridViewUser.CurrentCell.ColumnIndex;

            string userUpdated = _dbUser.UpdateUser(idUser, name, surname, email, idUserRole, password);

            _usersList = _dbUser.GetAllUsersInfo();
            dataGridViewUser.DataSource = _usersList;

            dataGridViewUser.CurrentCell = dataGridViewUser.Rows[bookmarkRowIndex].Cells[bookmarkColumnIndex];
            lblMsg.Text = userUpdated;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idUser = ((Models.UserInfo)dataGridViewUser.CurrentRow.DataBoundItem).IdUser;

            string userDeleted = _dbUser.DeleteUser(idUser);

            _usersList = _dbUser.GetAllUsersInfo();
            dataGridViewUser.DataSource = _usersList;
            lblMsg.Text = userDeleted;
        }        
    }
}
