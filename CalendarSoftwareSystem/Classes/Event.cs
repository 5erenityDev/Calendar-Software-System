using System;

namespace CalendarSoftwareSystem
{
    public class Event
    {
        private int eventID, empID;
        private string title;
        private string description;
        private string location;
        private static readonly string[] RESULTS = { "VALID_EVENT", "DATA_NOT_FOUND", "UNABLE_TO_CONNECT" };
        private bool isGroupEvent;

        private string[] attendants;

        private DateTime startDate;
        private DateTime endDate;
        
        
        public Event(int eID, string t, string d, string l, string[] a, DateTime sDate, DateTime eDate, int emID, bool isGE)
        {
            eventID = eID;
            title = t;
            description = d;
            location = l;

            attendants = a;

            startDate = sDate;
            endDate = eDate;

            empID = emID;
            isGroupEvent = isGE;
        }

        public Event()
        {
        }
        

        public string deleteEvent(FormCalendar thisCalendar, int eveID, int empID)
        {
            bool deleted = false;
            string result = RESULTS[0];

            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";
            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                conn.Open();
                string sql = "DELETE FROM csop_event WHERE evntID=@eveID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@eveID", eveID);
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    deleted = true;
                }
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

            if(!deleted)
                result = RESULTS[1];

            if(FormCalendar.thisEmployee != null)
                thisCalendar.ThisCalendar.EventList = Calendar.retrieveEventList(FormCalendar.thisEmployee.Name);
            else
                thisCalendar.ThisCalendar.EventList = Calendar.retrieveEventList(FormCalendar.thisManager.Name);

            return result;
        }


        public void editGroupEvents(FormCalendar cal)
        {
            /* similar to the formevent editing but for the events that have group aspects?*/
        }

        public int EventID
        {
            get { return eventID; }
            set { eventID = value; }
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

        public string[] Attendants
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

        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        public bool IsGroupEvent
        {
            get { return isGroupEvent; }
            set { isGroupEvent = value; }
        }
    }
}
