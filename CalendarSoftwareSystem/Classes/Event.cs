using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSoftwareSystem
{
    public class Event
    {
        private string title;
        private string description;
        private string location;
        private static readonly string[] RESULTS = { "VALID_EVENT", "DATA_NOT_FOUND", "UNABLE_TO_CONNECT" };

        private List<string> attendants;

        private DateTime startDate;
        private DateTime endDate;
        
        
        public Event(string t, string d, string l, List<string> a, DateTime sDate, DateTime eDate)
        {
            title = t;
            description = d;
            location = l;

            attendants = a;

            startDate = sDate;
            endDate = eDate;

        }

        public Event()
        {
        }

        public void editEvent()
        {

        }

        public string deleteEvent(FormCalendar thisCalendar, string d, string t)
        {
            string dateTime = d;
            string title;
            if (t.Length >= 15)
                title = t.Substring(0, 14);
            else
                title = t;
            dateTime = dateTime.Trim('\t');
            List<Event> tempEvents = new List<Event>();
            bool matched = false;
            string result = RESULTS[0];

            if (dateTime.IndexOf('/') == 1)
            {
                dateTime = "0" + dateTime;
            }
            if (dateTime.ElementAt(dateTime.Length - 11) == ' ')
            {
                dateTime = dateTime.Substring(0, dateTime.Length - 11) + " 0" + dateTime.Substring(dateTime.Length - 10);
            }

            foreach (Event eve in thisCalendar.ThisCalendar.EventList)
            {
                
                string tle = eve.Title;
                if (eve.Title.Length >= 15)
                    tle = tle.Substring(0, 14);
                Debug.WriteLine(tle);
                Debug.WriteLine(title);
                if (tle == title)
                {
                    Debug.WriteLine(eve.StartDate.ToString("MM/dd/yyyy hh:mm:ss tt"));
                    Debug.WriteLine(dateTime);
                    Debug.WriteLine(eve.StartDate.ToString("MM/dd/yyyy hh:mm:ss tt").Equals(dateTime));
                    if (eve.StartDate.ToString("MM/dd/yyyy hh:mm:ss tt").Equals(dateTime))
                    {
                        matched = true;
                        string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                        try
                        {
                            conn.Open();
                            string sql = "DELETE FROM csop_event WHERE startDate=@dateTime";
                            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@dateTime", dateTime);
                            cmd.ExecuteNonQuery();
                        }
                        catch (TimeoutException ex)
                        {
                            result = RESULTS[2];
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }

                        conn.Close();
                    }
                }
                if (!matched)
                {
                    result = RESULTS[1];
                    tempEvents.Add(eve);
                }
            }

            thisCalendar.ThisCalendar.EventList = tempEvents;
            return result;
        }


        public void editGroupEvents(FormCalendar cal)
        {
            /* similar to the formevent editing but for the events that have group aspects?*/
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = value; }
        }

        public List<string> Attendants
        {
            get { return attendants; }
            set { attendants = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
    }
}
