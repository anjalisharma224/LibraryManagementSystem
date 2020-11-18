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
    public partial class AdminLogIn : Form
    {
        public AdminLogIn()
        {
            InitializeComponent();
        }

        private void showBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fill the gridview with the data from database if selected books
            //adminDataGridview.DataSource = adminDataSet.Tables["books"];
        }

        private void showUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //fill the gridview with the data from database if selected users
            //adminDataGridview.DataSource = adminDataSet.Tables["users"];
        }

        private void addUpdateDeleteBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books bookForm = new Books();
            bookForm.Show();
        }

        private void addUpdateDeleteUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users usersForm = new Users();
            usersForm.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm logInForm = new LogInForm();
            logInForm.Show();
        }
    }
}
