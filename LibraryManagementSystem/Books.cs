using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.ConnString"].ConnectionString;
              
                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);
                string nwSQLString = "INSERT INTO BookTbl (Book_Name,Author_Name,Publisher_Name,Genre,No_of_copies) VALUES (@Book_Name,@Author_Name,@Publisher_Name,@Genre,@No_of_copies);";

                myNwConnection.Open();

                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(nwSQLString, myNwConnection);
                
                cmd.Parameters.AddWithValue("@Book_Name", bookNameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Author_Name", authorNameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Publisher_Name", publisherNameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@Genre", genreComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@No_of_copies", noOfCopiesTextbox.Text.Trim());

                messageLabel.Text = "Book Add Successful!";
               cmd.ExecuteNonQuery();
                //step7: close connection
                myNwConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.ConnString"].ConnectionString;

               

                string nwSQLString = "Select * from BookTbl;";

                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);

                myNwConnection.Open();


                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(nwSQLString, myNwConnection);    
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    messageLabel.Text = dt.Rows[0]["Book_Name"].ToString();
                }
                else
                {
                    messageLabel.Text = "Nothing to show";
                }
      
                //step7: close connection
                myNwConnection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logindbDataSet.BookTbl' table. You can move, or remove it, as needed.
            this.bookTblTableAdapter.Fill(this.logindbDataSet.BookTbl);

        }
    }
}
