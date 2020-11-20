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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'logindbDataSet1.UserTbl' table. You can move, or remove it, as needed.
            this.userTblTableAdapter.Fill(this.logindbDataSet1.UserTbl);

        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.ConnString"].ConnectionString;

                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);
                string nwSQLString = "INSERT INTO UserTbl (user_name,contact_number, program,level,role,password) VALUES (@user_name,@contact_number, @program,@level,@role,@password);";

                myNwConnection.Open();

                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(nwSQLString, myNwConnection);

                cmd.Parameters.AddWithValue("@user_name", usernameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_number", contactTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@program", programTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@level", levelTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@role", roleComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@password", passwordLabel.Text.Trim());

                messageLabel.Text = "User Add Successful!";
                cmd.ExecuteNonQuery();
                //step7: close connection
                myNwConnection.Close();
                ClearControls();

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

                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);
                string nwSQLString = "UPDATE userTbl SET user_name=@user_name,contact_number=@contact_number, program=@program,level=@level,role=@role,password=@password WHERE user_Id = "+ idTextbox.Text+ ";";

                myNwConnection.Open();

                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(nwSQLString, myNwConnection);

                cmd.Parameters.AddWithValue("@user_name", usernameTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@contact_number", contactTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@program", programTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@level", levelTextbox.Text.Trim());
                cmd.Parameters.AddWithValue("@role", roleComboBox.SelectedItem);
                cmd.Parameters.AddWithValue("@password", passwordLabel.Text.Trim());

                messageLabel.Text = "User Update Successful!";
                cmd.ExecuteNonQuery();
                //step7: close connection
                myNwConnection.Close();
                ClearControls();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }         
        }

        private void deleteBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.ConnString"].ConnectionString;

                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);

                string nwSQLString = "DELETE FROM userTbl WHERE user_Id =" + idTextbox.Text + ";";

                myNwConnection.Open();

                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(nwSQLString, myNwConnection);

                messageLabel.Text = "User Delete Successful!";
                cmd.ExecuteNonQuery();
                //step7: close connection
                myNwConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }



        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //connection to sql server
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.ConnString"].ConnectionString;

                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);

                string nwSQLString = "SELECT * from userTbl WHERE user_Id =" + idTextbox.Text + ";";

                myNwConnection.Open();

                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(nwSQLString, myNwConnection);

                //alternative way of database connectivity
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    usernameTextbox.Text = dt.Rows[0]["user_name"].ToString();
                    contactTextbox.Text = dt.Rows[0]["contact_number"].ToString();
                    programTextbox.Text = dt.Rows[0]["program"].ToString();
                    levelTextbox.Text = dt.Rows[0]["level"].ToString().Trim();
                    roleComboBox.SelectedItem = dt.Rows[0]["role"].ToString();
                    passwordLabel.Text = dt.Rows[0]["password"].ToString().Trim();
                }
                else
                {
                    messageLabel.Text = "No data to show";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearControls();

        }

        public void ClearControls()
        {
            userIDTextbox.Text = "";
            usernameTextbox.Text = "";
            contactTextbox.Text = "";
            programTextbox.Text = "";
            levelTextbox.Text = "";
            roleComboBox.SelectedItem = "";
            passwordLabel.Text = "";
        }
    }
}
