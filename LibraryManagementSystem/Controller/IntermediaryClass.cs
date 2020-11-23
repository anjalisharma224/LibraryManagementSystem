using LibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Controller
{
  public class IntermediaryClass
    {
        //property for any error that may occur
        public string DBError { get; set; }
        //instantiate the DataAccess Class
        DataAccessClass dataAccessClass = new DataAccessClass();

        //get the data from data access class and pass it onto form
        public DataTable FetchData()
        {
            
            try
            {
                //forming the sql query
                string nwSqlQuery = "SELECT CustomerID, CompanyName, ContactName, City, Country FROM customers;";
                //call the getData method
                DataSet customerData = dataAccessClass.GetNWData(nwSqlQuery); //store the data
                //return the data to the form class
                return customerData.Tables[0]; //dataset contains the collection of table, here return only one table

            }
            catch (Exception ex)
            {
                this.DBError = dataAccessClass.ErrorReturned + ex.Message;
                return null;

            }

        }

        public bool LoginValidation(string username, string password, string usertype)
        {
                string nwSQLString = "Select * from Registeruser where Role ='" + usertype + "' and Username ='" + username + "' and Password ='" + password + "';";

                SqlDataReader reader = dataAccessClass.GetData(nwSQLString);


                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }

        }
    }


