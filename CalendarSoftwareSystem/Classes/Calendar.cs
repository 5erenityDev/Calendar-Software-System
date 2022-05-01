using System;
using System.Collections.Generic;
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
        private Event[] eventList;

        public Calendar(int d, int m, int y, Event[] eList)
        {
            day = d;
            month = m;
            year = y;
            eventList = eList;
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

        public Event[] EventList
        {
            get { return eventList; }
            set { eventList = value; }
        }
    }
}
