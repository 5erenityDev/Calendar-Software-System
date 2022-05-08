using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CalendarSoftwareSystem
{
    public class User
    {
        ///////////////
        ///VARIABLES///
        ///////////////
        private string usernameAttempt;
        private string passwordAttempt;
        private static readonly string[] RESULTS = {"VALID_EMPLOYEE", "VALID_MANAGER", "INVALID_USER", 
                                                    "INVALID_PASS", "TEXT_EMPTY", "UNABLE_TO_CONNECT"};
        int empID = 0;


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
        public string logIn()
        {
            // Verify user login
            if (String.IsNullOrEmpty(Username) && String.IsNullOrEmpty(Password))
            {
                return RESULTS[4];
            }
            else
            {
                string result = RESULTS[4];
                string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

                try
                {
                    conn.Open();
                    string sql = "SELECT 1 FROM csop_employee WHERE username=@user";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@user", Username);

                    MySqlDataReader myReader = cmd.ExecuteReader();
                    if (!myReader.Read())
                    {
                        result = RESULTS[2];
                    }
                    else
                    {
                        myReader.Close();
                        sql = "SELECT * FROM csop_employee WHERE username=@user AND password=@pass";
                        cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@user", Username);
                        cmd.Parameters.AddWithValue("@pass", Password);
                        myReader = cmd.ExecuteReader();
                        if (myReader.Read())
                        {
                            empID = Int32.Parse(myReader["empID"].ToString());
                            if (Int32.Parse(myReader["isManager"].ToString()) == 1)
                            {
                                Debug.WriteLine("is a manager");
                                result = RESULTS[1];
                            }
                            else
                            {
                                result = RESULTS[0];
                            }
                        }
                        else
                        {
                            result = RESULTS[3];
                        }
                    }
                    myReader.Close();
                }
                catch (TimeoutException ex)
                {
                    result = RESULTS[5];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                conn.Close();

                return result;
            }
            
        }

        ////////////////////
        ///GETTER/SETTERS///
        ////////////////////
        public string Username
        {
            get { return usernameAttempt; }
            set { usernameAttempt = value; }
        }

        public string Password
        {
            get { return passwordAttempt; }
            set { passwordAttempt = value; }
        }

        public int EmpID
        {
            get { return empID; }
        }
    }
}
