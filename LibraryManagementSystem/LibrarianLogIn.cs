using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class LibrarianLogIn : Form
    {
        public LibrarianLogIn()
        {
            InitializeComponent();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void issueBookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IssueReturnBooks issueReturnBooks = new IssueReturnBooks();
            issueReturnBooks.Show();
        }
    }
}
