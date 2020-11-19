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
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
            userTypeComboBox.SelectedIndex = 0;
        }

        private void userLogInButton_Click(object sender, EventArgs e)
        {
            UserLogIn afterUserLogIn = new UserLogIn();
            //if role is student then open student page or open librarian page
            //afterUserLogIn.MdiParent =MainForm;
            afterUserLogIn.Show();
        }

        private void adminLogInButton_Click(object sender, EventArgs e)
        {
            AdminLogIn afterAdminLogIn = new AdminLogIn();
            afterAdminLogIn.Show();
        }

        private void userLogInButton_Click_1(object sender, EventArgs e)
        {
           
}

        private void userComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearFieldsButton_Click(object sender, EventArgs e)
        {

            usernameTextBox.Clear();
            passwordTextBox.Clear();
            userTypeComboBox.Items.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LogInForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //Login Button clicked
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.ConnString"].ConnectionString;

                String usertype = userTypeComboBox.Text;
                String username = usernameTextBox.Text;
                String password = passwordTextBox.Text;

                string nwSQLString = "Select * from Login where usertype='" + usertype + "' and username ='" + username + "' and password ='" + password + "';";

                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);

                myNwConnection.Open();


                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(nwSQLString, myNwConnection);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Login Successful");
                }
                else
                {
                    MessageBox.Show("Login Failure\nPlease try Again");
                }


                //step7: close connection
                myNwConnection.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            LibraryManagementSystem.Properties.Settings.Default.Username = usernameTextBox.Text;
            LibraryManagementSystem.Properties.Settings.Default.Usertype = userTypeComboBox.Text;
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            userTypeComboBox.SelectedIndex = 0;
            rememberCheckBox.Checked = false;
        }

        private void LogInForm_Load_1(object sender, EventArgs e)
        {
            if (LibraryManagementSystem.Properties.Settings.Default.Username != "")
            {
                usernameTextBox.Text = LibraryManagementSystem.Properties.Settings.Default.Username;
                userTypeComboBox.Text = LibraryManagementSystem.Properties.Settings.Default.Usertype;
                rememberCheckBox.Checked = true;
            }
        }

        private void forgotbutton_Click(object sender, EventArgs e)
        {
            LogInForm_Load_1(sender, e);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

