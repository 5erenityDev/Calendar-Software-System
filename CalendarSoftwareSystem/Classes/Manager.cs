using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSoftwareSystem
{
    public class Manager : Employee
    {

        public Manager(int empID, string n, string user, string pass) : base(empID, n, user, pass)
        {
            employeeID = empID;
            name = n;
            username = user;
            password = pass;
        }


        private void createGroupEvent()
        {

        }

        public void editGroupEvents(FormCalendar cal)
        {
            /* similar to the formevent editing but for the events that have group aspects?*/
        }

        // Used to create a manager object from the database
        public static Manager retrieveManager(int empID)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            Manager thisManager = null;

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

                    thisManager = new Manager(empID, name, username, password);
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return thisManager;
        }
    }
}
