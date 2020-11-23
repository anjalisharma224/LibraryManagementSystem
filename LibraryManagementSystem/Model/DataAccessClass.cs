using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Model
{
    class DataAccessClass
    {
        //variable for sql connection
        private SqlConnection NWConnection; // it is null by default

        //DB errors - as a property so that others class can access this and display to the user
        public string ErrorReturned { get; set; }

        //variable for connection string
        private String nwConnString = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.ConnString"].ConnectionString;
        //This class will have the followingt methods:
        //1. GetConnection(); 2. Open Connection(); 3. GetData(); 4. CloseConnection();

        //1 
        public SqlConnection GetConnection()
        {
            //Create connection if it does not exist already
            if (NWConnection == null)
            {
                NWConnection = new SqlConnection(nwConnString);
            }//end if
            return NWConnection;

        } // getConnection()

        //2
        public void OpenConnection()
        {
            //if not already open, open the connection.
            if (NWConnection.State == System.Data.ConnectionState.Closed)
            {
                NWConnection.Open();
            }//end if

        }//OpenConnection()

        //3
        public void CloseConnection()
        {
            //close the connection
            NWConnection.Close();
        }

        //4 
        //whichever object asks for data, send them to data
        public DataSet GetNWData(string sqlQuery)
        {
            //variable for storing data 
            DataSet nwDataSet = new DataSet(); //disconnected layer(store the data and forget about it)
            try
            {
                //setup data adapter with query and connection
                SqlDataAdapter nwDataAdapter = new SqlDataAdapter(sqlQuery, GetConnection());
                this.OpenConnection();
                nwDataAdapter.Fill(nwDataSet);
                return nwDataSet;
            }
            catch (Exception ex)
            {
                //store the data in the property
                this.ErrorReturned = ex.Message;
                return null;
            }
            finally
            {
                //close connection
                this.CloseConnection();
            }

        }

        public SqlDataReader GetData(string query)
        {
            try
            {
                //step1: connection string
                string myNwConnectionstring = ConfigurationManager.ConnectionStrings["LibraryManagementSystem.Properties.Settings.ConnString"].ConnectionString;


                SqlConnection myNwConnection = new System.Data.SqlClient.SqlConnection(myNwConnectionstring);

                myNwConnection.Open();


                //step 5: Adapter
                SqlCommand cmd = new SqlCommand(query, myNwConnection);
                SqlDataReader reader = cmd.ExecuteReader();


                return reader;
            }
            catch (Exception e) { return null; }
        }
    }
       
}
