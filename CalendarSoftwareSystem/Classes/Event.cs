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

        private string[] attendants;

        private DateTime startDate;
        private DateTime endDate;
        
        
        public Event(string t, string d, string l, string[] a, DateTime sDate, DateTime eDate)
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
    }
}
