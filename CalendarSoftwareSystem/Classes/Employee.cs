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
            employeeID = -1;
            name = null;
            username = null;
            password = null;
        }

        public List<Event> createEvent(string title, string desc, string loc, List<string> attendList, DateTime start, DateTime end)
        {
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
            //default add creator to attending list if it is empty
            if (attendList.Count == 0)
                attending = name;

            //write new event to the Database(wasn't clear on whether we wanted this in the event class or here)
            //feel free to move this elsewere or delete it if it is made redundant

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {

                string sql = "INSERT INTO csop_event (title, description, location, startDate, endDate, attendants, empID) VALUES (@uTitle, @uDesc, @uLoc, @uSDate, @uEDate, @uAtt, @uEmpID);" + "SELECT SCOPE_IDENTITY();";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uTitle", title);
                cmd.Parameters.AddWithValue("@uDesc", desc);
                cmd.Parameters.AddWithValue("@uLoc", loc);
                cmd.Parameters.AddWithValue("@uSDate", start.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uEDate", end.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uAtt", attending);
                cmd.Parameters.AddWithValue("@uEmpID", employeeID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            // Returns event list
            return Calendar.retrieveEventList(name);
        }

        public List<Event> editEvent(int eventID, string title, string desc, string loc, List<string> attendList, DateTime start, DateTime end)
        {
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
            //default add creator to attending list if it is empty
            if (attendList.Count == 0)
                attending = name;

            //write new event to the Database(wasn't clear on whether we wanted this in the event class or here)
            //feel free to move this elsewere or delete it if it is made redundant

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                string sql = "UPDATE csop_event SET title = @uTitle, description = @uDesc, location = @uLoc, startDate = @uSDate, endDate = @uEDate, attendants = @uAtt WHERE evntID = @uEveID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uTitle", title);
                cmd.Parameters.AddWithValue("@uDesc", desc);
                cmd.Parameters.AddWithValue("@uLoc", loc);
                cmd.Parameters.AddWithValue("@uSDate", start.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uEDate", end.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uAtt", attending);
                cmd.Parameters.AddWithValue("@uEveID", eventID);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            // Returns event list
            return Calendar.retrieveEventList(name);
        }

        public static List<string> findAttendants(List<string> possibleAttendants)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT name FROM csop_employee";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                    possibleAttendants.Add(myReader.GetString(0));
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return possibleAttendants;
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

        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}