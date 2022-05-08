using MySql.Data.MySqlClient;
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
    public partial class EventForm : Form
    {
        int curDay;
        List<string> possibleAttendants = new List<string>();
        Employee thisEmployee;
        FormCalendar thisCalendar;

        public EventForm(int day, Employee employee, FormCalendar calendar)
        {
            curDay = day;
            thisEmployee = employee;
            thisCalendar = calendar;
            InitializeComponent();

            // Set initial panel visibility
            panelEveView.Visible = true;
            panelEveAdd.Visible = false;
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

            // Set year combo boxes to be able to go forward 100 years
            for (int i = 0; i <= 100; i++)
            {
                cBoxEveStaYear.Items.Add((FormCalendar.thisCalendar.Year + i).ToString());
                cBoxEveEndYear.Items.Add((FormCalendar.thisCalendar.Year + i).ToString());
            }

            // Set date
            FormCalendar.thisCalendar.Day = curDay;
            lblEveViewDate.Text = FormCalendar.thisCalendar.Month.ToString() + "/" + FormCalendar.thisCalendar.Day.ToString() + "/" + FormCalendar.thisCalendar.Year.ToString();

            cBoxEveStaMon.Text = FormCalendar.thisCalendar.Month.ToString();
            cBoxEveStaDay.Text = FormCalendar.thisCalendar.Day.ToString();
            cBoxEveStaYear.Text = FormCalendar.thisCalendar.Year.ToString();

            cBoxEveEndMon.Text = FormCalendar.thisCalendar.Month.ToString();
            cBoxEveEndDay.Text = FormCalendar.thisCalendar.Day.ToString();
            cBoxEveEndYear.Text = FormCalendar.thisCalendar.Year.ToString();

            // Populate event box
            foreach (Event eve in FormCalendar.thisCalendar.EventList)
            {
                if (eve.StartDate.Date.ToString("M/d/yyyy").Equals(FormCalendar.thisCalendar.Month + "/" + FormCalendar.thisCalendar.Day + "/" + FormCalendar.thisCalendar.Year))
                {
                    //debug oversized event title name display
                    if (eve.Title.Length >= 23)
                        lBoxEveView.Items.Add(eve.Title.Substring(0,20)+"..." + "\t\t" + eve.StartDate.ToString() + "\t-\t" + eve.EndDate.ToString());
                    else
                        lBoxEveView.Items.Add(eve.Title + "\t\t\t" + eve.StartDate.ToString() + "\t-\t" + eve.EndDate.ToString());
                }
            }

            // Populate attendants checkList
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {
                conn.Open();
                string sql = "SELECT name FROM csop_employee";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                    possibleAttendants.Add(myReader.GetString(0));
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            foreach(string attendant in possibleAttendants)
                chklstAttendants.Items.Add(attendant);


        }

        private void btnEveSave_Click(object sender, EventArgs e)
        {
            // Initialize variables
            string title = "", description = "", location = "";
            List<string> attendants = new List<string>();
            DateTime startDate = DateTime.Now, endDate = DateTime.Now;
            string eventState = "VALID";
            int staHour = 0, endHour = 0;

            // Add title
            if (tBoxEveName.Text.Length > 0)
                title = tBoxEveName.Text;
            else
                eventState = "NO_TITLE";

            // Add description and location
            description = tBoxEveDesc.Text;
            location = tBoxEveLoc.Text;

            // Add selected attendants
            for (int i = 0; i <= chklstAttendants.Items.Count - 1; i++)
            {
                if (chklstAttendants.GetItemChecked(i))
                    attendants.Add(chklstAttendants.Items[i].ToString());
            }

            // Add start date
            try
            {
                if (radButEveStaAM.Checked)
                {
                    staHour = Int32.Parse(cBoxEveStaHour.Text);
                    startDate = Convert.ToDateTime(cBoxEveStaMon.Text + "/" + cBoxEveStaDay.Text + "/" + cBoxEveStaYear.Text + " " + cBoxEveStaHour.Text + ":" + cBoxEveStaMin.Text + " " + "AM");
                }
                else
                {
                    staHour = Int32.Parse(cBoxEveStaHour.Text) + 12;
                    startDate = Convert.ToDateTime(cBoxEveStaMon.Text + "/" + cBoxEveStaDay.Text + "/" + cBoxEveStaYear.Text + " " + cBoxEveStaHour.Text + ":" + cBoxEveStaMin.Text + " " + "PM");
                }
                    
            }
            catch (Exception ex)
            {
                eventState = "INVALID_START";
            }

            // Add end date
            try
            {
                if (radButEveEndAM.Checked)
                {
                    endHour = Int32.Parse(cBoxEveStaHour.Text);
                    endDate = Convert.ToDateTime(cBoxEveEndMon.Text + "/" + cBoxEveEndDay.Text + "/" + cBoxEveEndYear.Text + " " + cBoxEveEndHour.Text + ":" + cBoxEveEndMin.Text + " " + "AM");
                }
                else
                {
                    endHour = Int32.Parse(cBoxEveStaHour.Text) + 12;
                    endDate = Convert.ToDateTime(cBoxEveEndMon.Text + "/" + cBoxEveEndDay.Text + "/" + cBoxEveEndYear.Text + " " + cBoxEveEndHour.Text + ":" + cBoxEveEndMin.Text + " " + "PM");
                }
                if(endHour < staHour)
                    eventState = "END_BEFORE_START";
                else if(endHour == staHour)
                    if (Int32.Parse(cBoxEveEndMin.Text) < Int32.Parse(cBoxEveStaMin.Text))
                        eventState = "END_BEFORE_START";
            }
            catch (Exception ex)
            {

                eventState = "INVALID_END";
            }

            // Check and make sure all necessary features have been added
            switch (eventState)
            {
                case "VALID":
                    //update calendar events and create event
                    List<Event> tempEvents = thisCalendar.ThisCalendar.EventList;
                    tempEvents.Add(thisEmployee.createEvent(title, description, location, attendants, startDate, endDate));
                    thisCalendar.ThisCalendar.EventList = tempEvents;
                    thisCalendar.displayDays();



                    MessageBox.Show("Event created.");
                    this.Close();
                    break;
                case "NO_TITLE":
                    MessageBox.Show("Please add an event title.", "Calendar System");
                    break;
                case "INVALID_START":
                    MessageBox.Show("The start time for the event is invalid.", "Calendar System");
                    break;
                case "INVALID_END":
                    MessageBox.Show("The end time for the event is invalid.", "Calendar System");
                    break;
                case "END_BEFORE_START":
                    MessageBox.Show("The end time for the event is invalid as it happens before the start.", "Calendar System");
                    break;
            }

        }

        private void BtnEveViewCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEveViewCreate_Click(object sender, EventArgs e)
        {
            // Update screen
            lblEveTitle.Text = "New Event";
            if(FormCalendar.curUserIsManager)
            {
                lblEventAttendents.Visible = true;
                chklstAttendants.Visible = true;
                btnEveCoord.Visible = true;
            }
            else
            {
                lblEventAttendents.Visible = false;
                chklstAttendants.Visible = false;
                btnEveCoord.Visible = false;
            }

            // Set initial panel visibility
            panelEveView.Visible = false;
            panelEveAdd.Visible = true;
        }

        private void btnEveViewEdit_Click(object sender, EventArgs e)
        {
            // Update screen
            if(lBoxEveView.SelectedIndex >= 0)
            {
                lblEveTitle.Text = "Edit/View Event: " + lBoxEveView.SelectedItem.ToString().Substring(0, lBoxEveView.SelectedItem.ToString().IndexOf("\t"));
                if (FormCalendar.curUserIsManager)
                {
                    lblEventAttendents.Visible = true;
                    chklstAttendants.Visible = true;
                    btnEveCoord.Visible = true;
                }
                else
                {
                    lblEventAttendents.Visible = false;
                    chklstAttendants.Visible = false;
                    btnEveCoord.Visible = false;
                }

                // Set initial panel visibility
                panelEveView.Visible = false;
                panelEveAdd.Visible = true;
            }    
            else
            {
                MessageBox.Show("Please select an event to edit.", "Calendar System");
            }
        }

        private void btnEveViewDelete_Click(object sender, EventArgs e)
        {
            ///Delete Event Code Here///
        }

        private void btnEveCoord_Click(object sender, EventArgs e)
        {
            ///Coordinate Event with Employees code here///
        }

        private void btnEveBack_Click(object sender, EventArgs e)
        {
            // Set initial panel visibility
            panelEveView.Visible = true;
            panelEveAdd.Visible = false;
        }
    }
}
