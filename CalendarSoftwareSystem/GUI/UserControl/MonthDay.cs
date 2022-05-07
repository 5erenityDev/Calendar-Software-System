using System;
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
        Employee thisEmployee;
        FormCalendar thisCalendar;

        public MonthDay(Employee employee, FormCalendar calendar)
        {
            InitializeComponent();
            thisEmployee = employee;
            thisCalendar = calendar;
        }

        public void days(int numDay)
        {
            lblDays.Text = numDay.ToString();
            lblEvents.Text = "";
            int eventCount = 0;

            foreach (Event e in FormCalendar.thisCalendar.EventList)
            {
                if (e.StartDate.Date.ToString("M/d/yyyy").Equals(FormCalendar.thisCalendar.Month + "/" + numDay + "/" + FormCalendar.thisCalendar.Year))
                {
                    Debug.WriteLine("Event Count: " + eventCount);
                    if (eventCount < 4)
                    {
                        eventCount++;
                        if (e.Title.Length > 10)
                        {
                            lblEvents.Text += e.Title.Substring(0, 9) + "...";
                        }
                        else
                        {
                            lblEvents.Text += e.Title;
                        }
                        lblEvents.Text += '\n';
                    }
                    else
                    {
                        int count = 0;
                        for (int i = 0; i < lblEvents.Text.Length; i++)
                        {
                            if (lblEvents.Text[i] == '\n')
                            {
                                
                                count++;
                                if (count == 3)
                                {
                                    lblEvents.Text = lblEvents.Text.Substring(0, i) + "\n+" + (eventCount - 2) + " more events";
                                    break;
                                }
                            }
                        }
                        
                    }
                }
            }
            
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            curDay = Convert.ToInt32(lblDays.Text);
            EventForm eventform = new EventForm(curDay, thisEmployee, thisCalendar);
            eventform.Show();
        }

        private void MonthDay_Load(object sender, EventArgs e)
        {

        }
    }
}
