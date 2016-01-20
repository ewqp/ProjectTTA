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
        /// <summary>
        /// Generate table
        /// </summary>
        private void SetDataGrid()
        {
            dataGridHistory.AutoGenerateColumns = false; //wylaczenie auto generowania
            dataGridHistory.DataSource = _logsList; //ustawienie datasource 
            dataGridHistory.Columns["accountSurname"].DataPropertyName = "FullAccountName";
            dataGridHistory.Columns["bookTitle"].DataPropertyName = "Title";
            dataGridHistory.Columns["bookAuthor"].DataPropertyName = "FullAuthorName";
            dataGridHistory.Columns["histDate"].DataPropertyName = "ActionDate";
            dataGridHistory.Columns["status"].DataPropertyName = "Avaliable";
        }

        /// <summary>
        /// Find in table
        /// </summary>
        private void textBoxSearchLog_TextChanged(object sender, EventArgs e)
        {
            List<HistoryInfo> list = _logsList.Where(l => l.UserSurname.Contains(textBoxSearchLog.Text) || l.AuthorSurname.Contains(textBoxSearchLog.Text) || l.Title.Contains(textBoxSearchLog.Text)).ToList();

            dataGridHistory.DataSource = list;
        }
    }
}
