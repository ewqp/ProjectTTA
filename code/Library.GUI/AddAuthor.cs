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
    public partial class AddAuthor : Form
    {
        private DBAuthor _dbAuthor = new DBAuthor();

        public AddAuthor()
        {
            InitializeComponent();
        }

        private void buttonSaveAuthor_Click(object sender, EventArgs e)
        {
            string result = _dbAuthor.AddAuthor(textBoxAuthorName.Text, textBoxAuthorSurname.Text);
            lblMsg.Text = result;
        }

        private void buttonCancelAuthor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
