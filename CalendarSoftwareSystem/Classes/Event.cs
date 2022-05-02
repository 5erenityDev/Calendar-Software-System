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

        private void editEvent()
        {

        }

        private void deleteEvent()
        {

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
