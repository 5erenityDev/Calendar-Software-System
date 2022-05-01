using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSoftwareSystem
{
    public class Employee
    {
        protected int employeeID;
        protected string name;
        protected string username;
        protected string password;

        public Employee(int empID, string n, string user, string pass)
        {
            employeeID = empID;
            name = n;
            username = user;
            password = pass;
        }

        public void logOut()
        {

        }

        public void createEvent()
        {

        }

        // Used to create an employee object from the database
        public static Employee retrieveEmployee(int empID)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            Employee thisEmployee = null;

            try
            {
                conn.Open();
                string sql = "SELECT * FROM csop_employee WHERE empID=@empID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@empID", empID);

                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    string name = myReader["name"].ToString();
                    string username = myReader["username"].ToString();
                    string password = myReader["password"].ToString();

                    thisEmployee = new Employee(empID, name, username, password);
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return thisEmployee;
        }
    }
}
