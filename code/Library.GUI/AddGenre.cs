using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using Library.Logics;
using Library.EntityModel;

namespace Library.GUI
{
    public partial class AddGenre : Form
    {
        private DBBookGenre _dbGenre = new DBBookGenre();

        public AddGenre()
        {            
            InitializeComponent();
        }

        private void buttonSaveGenre_Click(object sender, EventArgs e)
        {
            string result = _dbGenre.AddBookGenre(textBoxGenre.Text);
            lblMsg.Text = result;
        }

        private void buttonCancelGenre_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
