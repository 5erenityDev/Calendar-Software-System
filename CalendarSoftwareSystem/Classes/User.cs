using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSoftwareSystem
{
    class User
    {
        ///////////////
        ///VARIABLES///
        ///////////////
        private string usernameAttempt;
        private string passwordAttempt;


        /////////////////
        ///CONSTRUCTOR///
        /////////////////
        public User(string userAtt, string passAtt)
        {
            usernameAttempt = userAtt;
            passwordAttempt = passAtt;
        }


        ///////////////
        ///FUNCTIONS///
        ///////////////
        public bool logIn()
        {
            // Verify user login
            if (!String.IsNullOrEmpty(Username) && !String.IsNullOrEmpty(Password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool isManager()
        {
            // Verify user login
            if (Username.Equals("admin") && Password.Equals("admin"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        ////////////////////
        ///GETTER/SETTERS///
        ////////////////////
        public String Username
        {
            get { return usernameAttempt; }
            set { usernameAttempt = value; }
        }

        public String Password
        {
            get { return passwordAttempt; }
            set { passwordAttempt = value; }
        }
    }
}
