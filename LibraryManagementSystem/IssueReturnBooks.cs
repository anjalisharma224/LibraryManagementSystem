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
    public partial class IssueReturnBooks : Form
    {
        public IssueReturnBooks()
        {
            InitializeComponent();
        }

        private void issueBookButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            /*int userIDNumber;
            //check if the user has entered a number and that number starts with 700
            if (int.TryParse(userIDTextBox.Text, out userIDNumber) && userIDTextBox.Text.StartsWith("700"))
            {
                //instantiate the intermediary class
                DataClassLibrary.IntermediaryClass nWIntermediaryClass = new DataClassLibrary.IntermediaryClass();
                //call the fetch method, and assign the table returned as a data source for grid view
                loanHistoryGridView.DataSource = nWIntermediaryClass.FetchIssueReturnBook();
            }
            else
            {
                errorProvider1.SetError(userIDTextBox, "Please enter 700 number");
            }*/
        }

        private void returnBookButton_Click(object sender, EventArgs e)
        {

        }

    }
}
