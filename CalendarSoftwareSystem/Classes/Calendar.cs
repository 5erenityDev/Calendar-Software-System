using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    string title = myReader["title"].ToString();
                    string description = myReader["description"].ToString();
                    string location = myReader["location"].ToString();
                    
                    DateTime startDate = Convert.ToDateTime(myReader["startDate"].ToString());
                    DateTime endDate = Convert.ToDateTime(myReader["endDate"].ToString());

                    List<string> attendants = new List<string>() { myReader["attendants"].ToString() };

                    thisEventList.Add(new Event(title, description, location, attendants, startDate, endDate));
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
