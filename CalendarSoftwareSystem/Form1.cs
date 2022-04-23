using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarSoftwareSystem
{
    public partial class FormCalendar : Form
    {
        //initialize variables
        private int month, year;
        private string user, curEvent, selectedDate;
        private string[] testEvents = {"Birthday", "Meeting", "Post-Meeting Birthday", "Post-Post-Meeting Birthday Meeting" };

        public FormCalendar()
        {
            InitializeComponent();

            // Set initial panel visibility
            panelLogin.Visible = true;
            panelCalendar.Visible = false;
        }
        private void FormCalendar_Load(object sender, EventArgs e)
        {
            //initialize variables
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            

            displayDays();
        }
        /// <summary>
        /// 
        /// </summary>

        private void btnLogLogin_Click(object sender, EventArgs e)
        {
            //verify user login
            if (!String.IsNullOrEmpty(tBoxLogUser.Text) && !String.IsNullOrEmpty(tBoxLogPass.Text))
            {
                user = tBoxLogUser.Text;
                tBoxLogUser.Text = "";
                tBoxLogPass.Text = "";

                panelLogin.Visible = false;
                panelCalendar.Visible = true;
            }
            else
            {
                string boxMsg = "Invalid Login.";
                string boxTitle = "Calendar System";
                MessageBox.Show(boxMsg, boxTitle);
            }

        }

        private void btnCalLogOut_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you wish to log out?";
            string title = "Log Off";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                panelLogin.Visible = true;
                panelCalendar.Visible = false;
            }
        }

        //This method displays the days of the month to the user
        private void displayDays()
        {
            //clear previously created usercontrols
            flPanelMonth.Controls.Clear();

            //update calander month/year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthName + " " + year;

            //get the first day of the month
            DateTime monthStart = new DateTime(year, month, 1);

            //find out how many days are in a given month
            int monthDays = DateTime.DaysInMonth(year, month);

            //convert monthStart to integer
            int dayOfTheWeek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d")) + 1;

            //create the usercontrol objects for the blank days (days of the week before month begins)
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                flPanelMonth.Controls.Add(ucblank);
            }
            //create usercontrol for the days
            for (int i = 1; i <= monthDays; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                flPanelMonth.Controls.Add(ucdays);
            }
        }

        //Attatched to: btnCalNext (Panel: panelCalendar)
        //Purpose: This method increments the number of months by one, accounting for year changes
        private void btnCalNext_Click(object sender, EventArgs e)
        {
            //increment to the next month
            month++;

            //if 13 is reached, move over to the next year
            if (month > 12)
            {
                month = 1;
                year++;
            }

            //display this change to the user
            displayDays();
        }

        //Attatched to: btnCalPrevious (Panel: panelCalendar)
        //Purpose: This method decrements the number of months by one, accounting for year changes
        private void btnCalPrevious_Click(object sender, EventArgs e)
        {
            //decrement to the next month
            month--;

            //if 0 is reached, move back to the previous year
            if (month < 1)
            {
                month = 12;
                year--;
            }

            //display this change to the user
            displayDays();
        }
    }
}
