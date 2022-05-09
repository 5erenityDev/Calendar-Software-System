using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CalendarSoftwareSystem
{
    public class Employee
    {
        protected int employeeID;
        protected string name;

        public Employee(int empID, string n)
        {
            employeeID = empID;
            name = n;
        }

        public void logOut()
        {
            employeeID = -1;
            name = null;
        }

        public List<Event> createEvent(string title, string desc, string loc, string[] attarr, DateTime start, DateTime end)
        {
            string attending = name;
            bool isGroupEvent = false;
            //create comma seperated string of attendants
            foreach (string att in attarr)
            {
                attending += '/' + att;
            }
            //default add creator to attending list if it is empty
            if (attarr.Length > 0)
                isGroupEvent = true;

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {

                string sql = "INSERT INTO csop_event (title, description, location, startDate, endDate, attendants, empID, isGroupEvent) VALUES (@uTitle, @uDesc, @uLoc, @uSDate, @uEDate, @uAtt, @uEmpID, @uIsGroup);";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uTitle", title);
                cmd.Parameters.AddWithValue("@uDesc", desc);
                cmd.Parameters.AddWithValue("@uLoc", loc);
                cmd.Parameters.AddWithValue("@uSDate", start.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uEDate", end.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uAtt", attending);
                cmd.Parameters.AddWithValue("@uEmpID", employeeID);
                cmd.Parameters.AddWithValue("@uIsGroup", isGroupEvent);
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

        public List<Event> editEvent(int eventID, string title, string desc, string loc, string[] attarr, DateTime start, DateTime end)
        {
            string attending = name;
            bool isGroupEvent = false;
            // Create comma seperated string of attendants
            foreach (string att in attarr)
            {
                attending += '/' + att;
            }

            // Check if this is a group event
            if (attarr.Length > 0)
                isGroupEvent = true;

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                string sql = "UPDATE csop_event SET title = @uTitle, description = @uDesc, location = @uLoc, startDate = @uSDate, endDate = @uEDate, attendants = @uAtt, isGroupEvent = @uIsGroup WHERE evntID = @uEveID AND empID = @uEmpID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uTitle", title);
                cmd.Parameters.AddWithValue("@uDesc", desc);
                cmd.Parameters.AddWithValue("@uLoc", loc);
                cmd.Parameters.AddWithValue("@uSDate", start.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uEDate", end.ToString("MM/dd/yyyy hh:mm:ss tt"));
                cmd.Parameters.AddWithValue("@uAtt", attending);
                cmd.Parameters.AddWithValue("@uEveID", eventID);
                cmd.Parameters.AddWithValue("@uEmpID", employeeID);
                cmd.Parameters.AddWithValue("@uIsGroup", isGroupEvent);
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

                    thisEmployee = new Employee(empID, name);
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