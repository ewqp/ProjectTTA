using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.GUI
{
    public partial class LibraryMenu : Form
    {
        public LibraryMenu()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            new AddBook().ShowDialog();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            new EditBook().ShowDialog();
        }
    }
}
