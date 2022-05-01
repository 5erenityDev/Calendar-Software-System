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

        // Create objects
        private static User unidentifiedUser;
        private static Employee thisEmployee;
        private static Manager thisManager;
        public static Calendar thisCalendar;
        private static Event[] eventList;

        //
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

            // Create calendar
            thisCalendar = new Calendar(now.Day, now.Month, now.Year, eventList);
            

            displayDays();
        }


        //Attatched to: btnCalLogIn (Panel: panelLogin)
        //Purpose:      This function analyzes the information placed into the two provided textboxes.
        //              If the provided information is valid, the user will be logged into the system.
        private void btnLogLogin_Click(object sender, EventArgs e)
        {
            unidentifiedUser = new User(tBoxLogUser.Text, tBoxLogPass.Text);

            switch (unidentifiedUser.logIn())
            {
                case "VALID_EMPLOYEE":
                    // Empty the text boxes
                    tBoxLogUser.Text = "";
                    tBoxLogPass.Text = "";

                    // Switch menus
                    panelLogin.Visible = false;
                    panelCalendar.Visible = true;

                    // Create Employee Object
                    thisEmployee = Employee.retrieveEmployee(unidentifiedUser.EmpID);

                    // Remove User Object
                    unidentifiedUser = null;
                    break;
                case "VALID_MANAGER":
                    // Empty the text boxes
                    tBoxLogUser.Text = "";
                    tBoxLogPass.Text = "";

                    // Switch menus
                    panelLogin.Visible = false;
                    panelCalendar.Visible = true;

                    // Create Manager Object
                    thisManager = Manager.retrieveManager(unidentifiedUser.EmpID);

                    // Remove User Object
                    unidentifiedUser = null;
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
            thisManager = null;
        }

        //Attatched to: btnCalNext (Panel: panelCalendar)
        //Purpose: This function increments the number of months by one, accounting for year changes
        private void btnCalNext_Click(object sender, EventArgs e)
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

        //Attatched to: btnCalPrevious (Panel: panelCalendar)
        //Purpose: This function decrements the number of months by one, accounting for year changes
        private void btnCalPrevious_Click(object sender, EventArgs e)
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

        //Used in:  formCalendar_Load, btnCalNext_Click, btnCalPrevious_Click
        //Purpose:  This function displays the days of the month to the user
        private void displayDays()
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
                MonthDay ucDays = new MonthDay();
                ucDays.days(i);
                flPanelMonth.Controls.Add(ucDays);
            }


            ///UPDATING MONTH/YEAR LABEL///
            // Update calendar label for month/year
            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(thisCalendar.Month);
            lblMonth.Text = monthName; 
            lblYear.Text = thisCalendar.Year.ToString();
        }
    }
}
