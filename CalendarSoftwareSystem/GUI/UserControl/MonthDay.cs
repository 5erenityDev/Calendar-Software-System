﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarSoftwareSystem
{
    public partial class MonthDay : UserControl
    {
        int curDay;
        public MonthDay()
        {
            InitializeComponent();
        }

        public void days(int numDay)
        {
            lblDays.Text = numDay.ToString();
            lblEvents.Text = "";
            foreach (Event e in FormCalendar.thisCalendar.EventList)
            {
                if (e.StartDate.Date.ToString("M/d/yyyy").Equals(FormCalendar.thisCalendar.Month + "/" + numDay + "/" + FormCalendar.thisCalendar.Year))
                {
                    lblEvents.Text += e.Title;
                    lblEvents.Text += "\n";
                }
            }
            
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            curDay = Convert.ToInt32(lblDays.Text);
            EventForm eventform = new EventForm(curDay);
            eventform.Show();
        }
    }
}