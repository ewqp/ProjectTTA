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
    public partial class ShowHistory : Form
    {   
        private DBHistory _dbHistory = new DBHistory();
        private List<HistoryInfo> _logsList;
        public ShowHistory()
        {
            InitializeComponent();
            _logsList = _dbHistory.GetAllHistoryLogsInfo(); 
            SetDataGrid();
        }
<<<<<<< HEAD
        /// <summary>
        /// Generate table
        /// </summary>
=======
>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
        private void SetDataGrid()
        {
            dataGridHistory.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridHistory.DataSource = _logsList; //ustawienie datasource 
            dataGridHistory.Columns["accountSurname"].DataPropertyName = "FullAccountName";
            dataGridHistory.Columns["bookTitle"].DataPropertyName = "Title";
            dataGridHistory.Columns["bookAuthor"].DataPropertyName = "FullAuthorName";
            dataGridHistory.Columns["histDate"].DataPropertyName = "ActionDate";
<<<<<<< HEAD
            dataGridHistory.Columns["status"].DataPropertyName = "Avaliable";
        }

        /// <summary>
        /// Find in table
        /// </summary>
=======
            dataGridHistory.Columns["status"].DataPropertyName = "Returned";
            //dataGridHistory.Columns["userSurname"].DataPropertyName = "UserSurname"; 
            //Do dodania Rent by
        }

>>>>>>> 00be6419b2a0a1d0d5fbe433ffa85092e6ae6d87
        private void textBoxSearchLog_TextChanged(object sender, EventArgs e)
        {
            List<HistoryInfo> list = _logsList.Where(l => l.UserSurname.Contains(textBoxSearchLog.Text) || l.AuthorSurname.Contains(textBoxSearchLog.Text) || l.Title.Contains(textBoxSearchLog.Text)).ToList();

            dataGridHistory.DataSource = list;
        }
    }
}
