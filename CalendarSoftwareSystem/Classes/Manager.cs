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


        public Event createGroupEvent(string title, string desc, string loc, List<string> attendList, DateTime start, DateTime end)
        {
            //creates event object
            Event newEvent = new Event(title, desc, loc, attendList, start, end);

            string attending = "";
            //create comma seperated string of attendants
            foreach (string att in attendList)
            {
                if (attendList.LastIndexOf(att) == 0)
                {
                    attending += att;
                }
                else
                {
                    attending += ", " + att;
                }
            }

            //write new event to the Database(wasn't clear on whether we wanted this in the event class or here)
            //feel free to move this elsewere or delete it if it is made redundant

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "INSERT INTO csop_event (title, description, location, startDate, endDate, attendants, empID) VALUES (@uTitle, @uDesc, @uLoc, @uSDate, @uEDate, @uAtt, @uEmpID)";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uTitle", title);
                cmd.Parameters.AddWithValue("@uDesc", desc);
                cmd.Parameters.AddWithValue("@uLoc", loc);
                cmd.Parameters.AddWithValue("@uSDate", start.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uEDate", end.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uAtt", attending);
                cmd.Parameters.AddWithValue("@uEmpID", employeeID);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return newEvent;
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
