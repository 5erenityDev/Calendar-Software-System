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
        int curDay, curEve;
        bool isEditing;
        List<string> possibleAttendants = new List<string>();
        public Employee thisEmployee;
        FormCalendar thisCalendar;

        public EventForm(int day, Employee employee, FormCalendar calendar)
        {
            curDay = day;
            thisEmployee = employee;
            thisCalendar = calendar;
            isEditing = false;
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

            // Set Time to default on AM
            radButEveStaAM.Checked = true;
            radButEveEndAM.Checked = true;

            populateEventList();

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

            if (eventState == "VALID")
            {
                // Add start date
                try
                {
                    if (radButEveStaAM.Checked)
                    {
                        if (Int32.Parse(cBoxEveStaHour.Text) == 12)
                            staHour = 0;
                        else
                            staHour = Int32.Parse(cBoxEveStaHour.Text);
                        startDate = Convert.ToDateTime(cBoxEveStaMon.Text + "/" + cBoxEveStaDay.Text + "/" + cBoxEveStaYear.Text + " " + cBoxEveStaHour.Text + ":" + cBoxEveStaMin.Text + " " + "AM");
                    }
                    else
                    {
                        if (Int32.Parse(cBoxEveStaHour.Text) == 12)
                            staHour = 12;
                        else
                            staHour = Int32.Parse(cBoxEveStaHour.Text) + 12;
                        startDate = Convert.ToDateTime(cBoxEveStaMon.Text + "/" + cBoxEveStaDay.Text + "/" + cBoxEveStaYear.Text + " " + cBoxEveStaHour.Text + ":" + cBoxEveStaMin.Text + " " + "PM");
                    }
                }
                catch (Exception ex)
                {
                    eventState = "INVALID_START";
                }
            }

            

            if (eventState == "VALID")
            {
                // Add end date
                try
                {
                    if (radButEveEndAM.Checked)
                    {
                        if (Int32.Parse(cBoxEveEndHour.Text) == 12)
                            endHour = 0;
                        else
                            endHour = Int32.Parse(cBoxEveEndHour.Text);
                        endDate = Convert.ToDateTime(cBoxEveEndMon.Text + "/" + cBoxEveEndDay.Text + "/" + cBoxEveEndYear.Text + " " + cBoxEveEndHour.Text + ":" + cBoxEveEndMin.Text + " " + "AM");
                    }
                    else
                    {
                        if (Int32.Parse(cBoxEveEndHour.Text) == 12)
                            endHour = 12;
                        else
                            endHour = Int32.Parse(cBoxEveEndHour.Text) + 12;
                        endDate = Convert.ToDateTime(cBoxEveEndMon.Text + "/" + cBoxEveEndDay.Text + "/" + cBoxEveEndYear.Text + " " + cBoxEveEndHour.Text + ":" + cBoxEveEndMin.Text + " " + "PM");
                    }

                    if (endHour < staHour)
                    {
                        eventState = "END_BEFORE_START";
                    }
                    else if (endHour == staHour)
                    {
                        if (Int32.Parse(cBoxEveEndMin.Text) < Int32.Parse(cBoxEveStaMin.Text))
                        {
                            eventState = "END_BEFORE_START";
                        }
                    }
                    else
                    {
                        foreach (Event eve in thisCalendar.ThisCalendar.EventList)
                        {
                            if ((startDate.CompareTo(eve.StartDate) == -1 && endDate.CompareTo(eve.StartDate) == 1)
                                || (startDate.CompareTo(eve.EndDate) == -1 && endDate.CompareTo(eve.EndDate) == 1)
                                || (startDate.CompareTo(eve.StartDate) == 1 && endDate.CompareTo(eve.EndDate) == -1)
                                || (startDate.CompareTo(eve.StartDate) == -1 && endDate.CompareTo(eve.EndDate) == 1)
                                || (startDate.CompareTo(eve.StartDate) == 0)
                                || (startDate.CompareTo(eve.EndDate) == 0)
                                || (endDate.CompareTo(eve.StartDate) == 0)
                                || (endDate.CompareTo(eve.EndDate) == 0))
                            {
                                eventState = "CONFLICTING_TIMES";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                    eventState = "INVALID_END";
                }
            }


            // Check and make sure all necessary features have been added
            List<Event> tempEvents = new List<Event>();
            switch (eventState)
            {
                case "CONFLICTING_TIMES":
                    DialogResult result = MessageBox.Show("The time provided conflicts with another event. Are you sure you wish to create this event?", "Calendar System", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        //update calendar events and create event
                        
                        if (isEditing)
                        {
                            thisCalendar.ThisCalendar.EventList = thisEmployee.editEvent(curEve, title, description, location, attendants, startDate, endDate);
                            MessageBox.Show("Event edited.", "Calendar System");
                        }
                        else
                        {
                            thisCalendar.ThisCalendar.EventList = thisEmployee.createEvent(title, description, location, attendants, startDate, endDate);
                            MessageBox.Show("Event created.", "Calendar System");
                        }
                        thisCalendar.displayDays();

                        
                        this.Close();
                    }

                    break;
                case "VALID":
                    //update calendar events and create event
                    if (isEditing)
                    {
                        thisCalendar.ThisCalendar.EventList = thisEmployee.editEvent(curEve, title, description, location, attendants, startDate, endDate);
                        MessageBox.Show("Event edited.", "Calendar System");
                    }
                    else
                    {
                        thisCalendar.ThisCalendar.EventList = thisEmployee.createEvent(title, description, location, attendants, startDate, endDate);
                        MessageBox.Show("Event created.", "Calendar System");
                    }
                    thisCalendar.displayDays();

                    
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
            if(FormCalendar.CurUserIsManager)
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

            isEditing = false;
        }

        private void btnEveViewEdit_Click(object sender, EventArgs e)
        {
            // Update screen
            if (lViewEveView.SelectedItems.Count > 0)
            {
                lblEveTitle.Text = "Edit/View Event: " + lViewEveView.SelectedItems[0].SubItems[1].Text;
                if (FormCalendar.CurUserIsManager)
                {
                    lblEventAttendents.Visible = true;
                    chklstAttendants.Visible = true;
                }
                else
                {
                    lblEventAttendents.Visible = false;
                    chklstAttendants.Visible = false;
                }
                tBoxEveName.Text = lViewEveView.SelectedItems[0].SubItems[1].Text;

                
                // Set initial panel visibility
                panelEveView.Visible = false;
                panelEveAdd.Visible = true;

                isEditing = true;
                curEve = Int32.Parse(lViewEveView.SelectedItems[0].SubItems[0].Text);
            }    
            else
            {
                MessageBox.Show("Please select an event to edit.", "Calendar System");
            }
        }

        private void btnEveViewDelete_Click(object sender, EventArgs e)
        {
            Event deletedEvent = new Event();
            ///Delete Event Code Here///
            if (lViewEveView.SelectedItems.Count > 0)
            {
                string eveID = lViewEveView.SelectedItems[0].SubItems[0].Text;

                switch (deletedEvent.deleteEvent(thisCalendar, Int32.Parse(eveID), thisEmployee.EmployeeID))
                {
                    case "VALID_EVENT":
                        MessageBox.Show("Event deleted.", "Calendar System");
                        populateEventList();
                        thisCalendar.displayDays();
                        break;
                    case "DATA_NOT_FOUND":
                        MessageBox.Show("This event was not located in the database.", "Calendar System");
                        break;
                    case "UNABLE_TO_CONNECT":
                        MessageBox.Show("Unable to communicate with EKU server, please test connection and try again.", "Calendar System");
                        break;
                }
                
            }
        }

        private void btnEveCoord_Click(object sender, EventArgs e)
        {
            ///createGroupEvent code here///
            FormCalendar.thisManager.coordinateEvent();
        }

        private void btnEveBack_Click(object sender, EventArgs e)
        {
            // Set initial panel visibility
            panelEveView.Visible = true;
            panelEveAdd.Visible = false;
        }

        private void populateEventList()
        {
            lViewEveView.Items.Clear();
            var header1 = lViewEveView.Columns.Add("Event ID", -2, HorizontalAlignment.Left);
            var header2 = lViewEveView.Columns.Add("Title", -2, HorizontalAlignment.Left);
            var header3 = lViewEveView.Columns.Add("Start Date", -2, HorizontalAlignment.Left);
            var header4 = lViewEveView.Columns.Add("End Date", -2, HorizontalAlignment.Left);

            foreach (Event eve in thisCalendar.ThisCalendar.EventList)
            {
                if (eve.StartDate.Date.ToString("M/d/yyyy").Equals(FormCalendar.thisCalendar.Month + "/" + FormCalendar.thisCalendar.Day + "/" + FormCalendar.thisCalendar.Year))
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                    eve.EventID.ToString(),
                    eve.Title,
                    eve.StartDate.ToString("MM/dd/yyyy hh:mm:ss tt"),
                    eve.EndDate.ToString("MM/dd/yyyy hh:mm:ss tt")
                    });
                    lViewEveView.Items.Add(lvi);
                }
            }
            lViewEveView.Columns[0].Width = -2;
            lViewEveView.Columns[1].Width = -2;
            lViewEveView.Columns[2].Width = -2;
            lViewEveView.Columns[3].Width = -2;
        }

        
    }
}
