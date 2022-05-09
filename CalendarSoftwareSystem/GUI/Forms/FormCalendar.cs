using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CalendarSoftwareSystem
{
    public partial class FormCalendar : Form
    {
        // Create variables
        private static bool curUserIsManager;

        // Create objects
        private static User unidentifiedUser;
        public static Manager thisManager;
        public static Employee thisEmployee;
        public static Calendar thisCalendar;
        private static List<Event> eventList = new List<Event>();

        public FormCalendar()
        {
            InitializeComponent();

            // Set initial panel visibility
            panelLogin.Visible = true;
            panelCalendar.Visible = false;
        }

        //Attatched to: FormCalendar
        //Purpose:      This function is ran once when the program is initially opened
        private void FormCalendar_Load(object sender, EventArgs e)
        {
            // Initialize variables
            DateTime now = DateTime.Now;
            thisCalendar = new Calendar(now.Day, now.Month, now.Year, eventList);
            thisCalendar.Month = now.Day;
            thisCalendar.Month = now.Month;
            thisCalendar.Month = now.Year;
        }


        //Attatched to: btnCalLogIn (Panel: panelLogin)
        //Purpose:      This function analyzes the information placed into the two provided textboxes.
        //              If the provided information is valid, the user will be logged into the system.
        private void btnLogLogin_Click(object sender, EventArgs e)
        {
            // Initialize variables
            unidentifiedUser = new User(tBoxLogUser.Text, tBoxLogPass.Text);
            DateTime now = DateTime.Now;

            switch (unidentifiedUser.logIn())
            {
                case "VALID_EMPLOYEE":
                    // Empty the text boxes
                    tBoxLogUser.Text = "";
                    tBoxLogPass.Text = "";



                    // Create Employee Object
                    thisEmployee = Employee.retrieveEmployee(unidentifiedUser.EmpID);

                    thisCalendar = new Calendar(now.Day, now.Month, now.Year, Calendar.retrieveEventList(thisEmployee.Name));

                    curUserIsManager = false;

                    // Remove User Object
                    unidentifiedUser = null;

                    displayDays();

                    // Switch menus
                    panelLogin.Visible = false;
                    panelCalendar.Visible = true;
                    break;
                case "VALID_MANAGER":
                    // Empty the text boxes
                    tBoxLogUser.Text = "";
                    tBoxLogPass.Text = "";

                    // Create Manager Object
                    thisManager = Manager.retrieveManager(unidentifiedUser.EmpID);

                    thisCalendar = new Calendar(now.Day, now.Month, now.Year, Calendar.retrieveEventList(thisManager.Name));

                    curUserIsManager = true;


                    // Remove User Object
                    unidentifiedUser = null;

                    displayDays();

                    // Switch menus
                    panelLogin.Visible = false;
                    panelCalendar.Visible = true;
                    break;
                case "INVALID_USER":
                    MessageBox.Show("Invalid Username. Please Try Again.", "Calendar System");
                    break;
                case "INVALID_PASS":
                    MessageBox.Show("Invalid Password. Please Try Again.", "Calendar System");
                    break;
                case "TEXT_EMPTY":
                    MessageBox.Show("Please type into the text boxes provided.", "Calendar System");
                    break;
                case "UNABLE_TO_CONNECT":
                    MessageBox.Show("Unable to connect to EKU database. Please test your connection and try again.", "Calendar System");
                    break;
            }
        }


        //Attatched to: btnCalLogOut (Panel: panelCalendar)
        //Purpose:      This function prompts the user,
        //              asking them if they wish to log out of the system.
        private void btnCalLogOut_Click(object sender, EventArgs e)
        {
            // Prompt the user asking them if they wish to log off
            string message = "Are you sure you wish to log out?";
            string title = "Log Off";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);

            // If they say yes, log them out.
            // If they say no, do nothing and simply return to calendar menu.
            if (result == DialogResult.Yes)
            {
                panelLogin.Visible = true;
                panelCalendar.Visible = false;
            }
            
            thisEmployee = null;
            thisCalendar = null;
        }

        //Attatched to: btnCalNext (Panel: panelCalendar)
        //Purpose: This function increments the number of months by one, accounting for year changes
        private void btnCalNext_Click(object sender, EventArgs e)
        {
            try 
            {
                // Increment to the next month
                thisCalendar.Month++;

                // If 13 is reached, move over to the next year
                if (thisCalendar.Month > 12)
                {
                    thisCalendar.Month = 1;
                    thisCalendar.Year++;
                }

                // Display this change to the user
                displayDays();
            }
            catch
            {
                DateTime now = DateTime.Now;
                thisCalendar.Month = now.Day;
                thisCalendar.Month = now.Month;
                thisCalendar.Month = now.Year;
            }
        }

        //Attatched to: btnCalPrevious (Panel: panelCalendar)
        //Purpose: This function decrements the number of months by one, accounting for year changes
        private void btnCalPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                // Decrement to the next month
                thisCalendar.Month--;

                // If 0 is reached, move back to the previous year
                if (thisCalendar.Month < 1)
                {
                    thisCalendar.Month = 12;
                    thisCalendar.Year--;
                }

                // Display this change to the user
                displayDays();
            }
            catch
            {
                DateTime now = DateTime.Now;
                thisCalendar.Month = now.Day;
                thisCalendar.Month = now.Month;
                thisCalendar.Month = now.Year;
            }
}

        //Used in:  formCalendar_Load, btnCalNext_Click, btnCalPrevious_Click
        //Purpose:  This function displays the days of the month to the user
        public void displayDays()
        {
            ///CREATE VARIABLES///
            // Find out how many days are in a given month
            int monthDays = DateTime.DaysInMonth(thisCalendar.Year, thisCalendar.Month);

            // Find the first day of the month
            DateTime monthStart = new DateTime(thisCalendar.Year, thisCalendar.Month, 1);
            int firstDay = Convert.ToInt32(monthStart.DayOfWeek.ToString("d")) + 1;


            ///GENERATING THE USERCONTROL OBJECTS FOR THE BLANK DAYS///
            // Clear previously created usercontrols
            flPanelMonth.Controls.Clear();

            // Create the usercontrol objects for the blank days
            // (days of the week before month begins)
            for (int i = 1; i < firstDay; i++)
            {
                BlankDay ucBlank = new BlankDay();
                flPanelMonth.Controls.Add(ucBlank);
            }

            // Create usercontrol objects for the actual days of the month
            for (int i = 1; i <= monthDays; i++)
            {
                MonthDay ucDays;
                if (thisEmployee!=null)
                    ucDays = new MonthDay(thisEmployee, this);
                else
                    ucDays = new MonthDay(thisManager, this);
                ucDays.days(i);
                flPanelMonth.Controls.Add(ucDays);
            }


            ///UPDATING MONTH/YEAR LABEL///
            // Update calendar label for month/year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(thisCalendar.Month);
            lblMonth.Text = monthName; 
            lblYear.Text = thisCalendar.Year.ToString();
        }

        public Calendar ThisCalendar
        {
            get { return thisCalendar; }
            set { thisCalendar = value; }

        }

        public static bool CurUserIsManager
        {
            get { return curUserIsManager; }
            set { curUserIsManager = value; }
        }
    }
}
