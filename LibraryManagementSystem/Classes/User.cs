using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagementSystem.Model;
using LibraryManagementSystem.Controller;

namespace LibraryManagementSystem.Classes
{
   public class User : IUser
    {
        private string userName;

        public string Username
        {
            get { return userName; }
            set { userName = value; }
        }

        private string passWord;

        public string Password
        {
            get { return passWord; }
            set { passWord = value; }
        }
        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }
        private string userType;

        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }

        public User(string uName, string uPass, string uType)
        {
            userName = uName;
            passWord = uPass;
            userType = uType;

        }

        public void Login()
        {
            IntermediaryClass intermediaryClass = new IntermediaryClass();
            intermediaryClass.LoginValidation(userName, passWord, userType);
               
        }
    }
}
