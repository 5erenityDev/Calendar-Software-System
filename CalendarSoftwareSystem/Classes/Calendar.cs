using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CalendarSoftwareSystem
{
    public class Calendar
    {
        private int day;
        private int month;
        private int year;
        private List<Event> eventList;

        public Calendar(int d, int m, int y, List<Event> eList)
        {
            day = d;
            month = m;
            year = y;
            eventList = eList;
        }

        public static List<Event> retrieveEventList(string name)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            name = '%'+name+'%';

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            List<Event> thisEventList = new List<Event>();

            try
            {
                conn.Open();
                string sql = "SELECT * FROM csop_event WHERE attendants LIKE @attendant";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@attendant", name);

                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    int eventID = Int32.Parse(myReader["evntID"].ToString());
                    string title = myReader["title"].ToString();
                    string description = myReader["description"].ToString();
                    string location = myReader["location"].ToString();
                    
                    DateTime startDate = Convert.ToDateTime(myReader["startDate"].ToString());
                    DateTime endDate = Convert.ToDateTime(myReader["endDate"].ToString());


                    string[] attendants = myReader["attendants"].ToString().Split('/');

                    int empID = Int32.Parse(myReader["empID"].ToString());
                    bool isGroupEvent = Convert.ToBoolean(myReader["isGroupEvent"]);

                    thisEventList.Add(new Event(eventID, title, description, location, attendants, startDate, endDate, empID, isGroupEvent));
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return thisEventList;
        }

        public static List<string> retrieveAttendants(List<string> possibleAttendants, string empName)
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
                    if (myReader.GetString(0) != empName)
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

        public static Event retrieveEventDetails(int eventID)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            Event thisEvent = null;

            try
            {
                conn.Open();
                string sql = "SELECT * FROM csop_event WHERE evntID=@eveID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@eveID", eventID);

                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    string title = myReader["title"].ToString();
                    string description = myReader["description"].ToString();
                    string location = myReader["location"].ToString();

                    DateTime startDate = Convert.ToDateTime(myReader["startDate"].ToString());
                    DateTime endDate = Convert.ToDateTime(myReader["endDate"].ToString());

                    string[] attendants = myReader["attendants"].ToString().Split('/');

                    int empID = Int32.Parse(myReader["empID"].ToString());
                    bool isGroupEvent = Convert.ToBoolean(myReader["isGroupEvent"]);

                    thisEvent = new Event(eventID, title, description, location, attendants, startDate, endDate, empID, isGroupEvent);
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return thisEvent;
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public List<Event> EventList
        {
            get { return eventList; }
            set { eventList = value; }
        }
    }
}
