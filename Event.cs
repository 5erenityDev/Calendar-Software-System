using System;
using System.Collections.Generic;
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

        private void editEvent()
        {

        }

        public void deleteEvent(FormCalendar thisCalendar, string l, string s, string t)
        {
            string shortDate = s+"";
            string longDate = l + "";
            string title = t;
            shortDate = shortDate.Trim('\t');
            longDate = longDate.Trim('\t');
            List<Event> tempEvents = new List<Event>();
            bool matched;
            if (longDate.ElementAt(longDate.Length-11)==' ')
            {
                longDate = longDate.Substring(0, longDate.Length - 11) + " 0" + longDate.Substring(longDate.Length - 10);
            }
            if (longDate.IndexOf('/') == 1)
            {
                longDate = "0" + longDate.Substring(0);
            }
            Console.WriteLine("The next short date is " + shortDate);
            Console.WriteLine("The next long date is " + longDate);
            Console.WriteLine("The next title is " + title);
            foreach (Event eve in thisCalendar.ThisCalendar.EventList)
            {
                matched = false;
                if (eve.Title == title)
                {
                    Console.WriteLine("Title was found");
                    Console.WriteLine(eve.StartDate.Date.ToString("M/d/yyyy"));
                    Console.WriteLine(shortDate);
                    if (eve.StartDate.Date.ToString("M/d/yyyy").Equals(shortDate))
                    {
                        Console.WriteLine(longDate);
                        matched = true;
                        Console.WriteLine("DateTime was Found");
                        string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
                        MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                        try
                        {
                            conn.Open();
                            string sql = "DELETE FROM csop_event WHERE title=@title AND startDate=@longDate";
                            MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                            cmd.Parameters.AddWithValue("@title", title);
                            cmd.Parameters.AddWithValue("@longDate", longDate);
                            cmd.ExecuteNonQuery();
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
                    tempEvents.Add(eve);
                }
            }
            thisCalendar.ThisCalendar.EventList = tempEvents;
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
