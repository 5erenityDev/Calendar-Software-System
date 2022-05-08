﻿using MySql.Data.MySqlClient;
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
        Manager thisManager;
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
        public EventForm(int day, Manager manager, FormCalendar calendar)
        {
            curDay = day;
            thisManager = manager;
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

            // Set Time to default on AM
            radButEveStaAM.Checked = true;
            radButEveEndAM.Checked = true;

            populateEventBox();

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
                        Debug.WriteLine("End Before Start in Hour");
                        eventState = "END_BEFORE_START";
                    }
                    else if (endHour == staHour)
                    {
                        Debug.WriteLine("End Hour Matches Start Hour");
                        if (Int32.Parse(cBoxEveEndMin.Text) < Int32.Parse(cBoxEveStaMin.Text))
                        {
                            Debug.WriteLine("End min before Start min");
                            eventState = "END_BEFORE_START";
                        }
                    }
                    else
                    {
                        foreach (Event eve in thisCalendar.ThisCalendar.EventList)
                        {
                            Debug.WriteLine("Start Date: " + endDate);
                            Debug.WriteLine("Event Date: " + eve.EndDate);
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
                        tempEvents = thisCalendar.ThisCalendar.EventList;
                        if (thisEmployee != null)
                            tempEvents.Add(thisEmployee.createEvent(title, description, location, attendants, startDate, endDate));
                        else
                            tempEvents.Add(thisManager.createGroupEvent(title, description, location, attendants, startDate, endDate));
                        thisCalendar.ThisCalendar.EventList = tempEvents;
                        thisCalendar.displayDays();



                        MessageBox.Show("Event created.", "Calendar System");
                        this.Close();
                    }

                    break;
                case "VALID":
                    //update calendar events and create event
                    tempEvents = thisCalendar.ThisCalendar.EventList;
                    if (thisEmployee != null)
                        tempEvents.Add(thisEmployee.createEvent(title, description, location, attendants, startDate, endDate));
                    else
                        tempEvents.Add(thisManager.createGroupEvent(title, description, location, attendants, startDate, endDate));
                    thisCalendar.ThisCalendar.EventList = tempEvents;
                    thisCalendar.displayDays();

                    MessageBox.Show("Event created.", "Calendar System");
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
            }
            else
            {
                lblEventAttendents.Visible = false;
                chklstAttendants.Visible = false;
            }

            if (thisManager != null)
            {
                for (int i = 0; i <= chklstAttendants.Items.Count - 1; i++)
                {
                    Debug.WriteLine("is a manager");
                    if (chklstAttendants.Items[i].ToString().Equals(thisManager.name))
                        chklstAttendants.SetItemChecked(i, true);
                }
            }

            // Set initial panel visibility
            panelEveView.Visible = false;
            panelEveAdd.Visible = true;
        }

        private void btnEveViewEdit_Click(object sender, EventArgs e)
        {
            // Update screen
            Event editedEvent = new Event();
            if (lBoxEveView.SelectedIndex >= 0)
            {
                
                lblEveTitle.Text = "Edit/View Event: " + lBoxEveView.SelectedItem.ToString().Substring(0, lBoxEveView.SelectedItem.ToString().IndexOf("\t"));
                if (FormCalendar.curUserIsManager)
                {
                    lblEventAttendents.Visible = true;
                    chklstAttendants.Visible = true;
                }
                else
                {
                    lblEventAttendents.Visible = false;
                    chklstAttendants.Visible = false;
                }
                string name = lBoxEveView.SelectedItem.ToString().Substring(0, lBoxEveView.SelectedItem.ToString().IndexOf("\t"));
                int dateBegin = lBoxEveView.SelectedItem.ToString().IndexOf("\t", lBoxEveView.SelectedItem.ToString().IndexOf("\t"));
                int dateEnd = lBoxEveView.SelectedItem.ToString().IndexOf("\t", dateBegin);
                string dateTime = lBoxEveView.SelectedItem.ToString().Substring(dateBegin, (lBoxEveView.SelectedItem.ToString().IndexOf("	-")-dateBegin));

                editedEvent.editEvent();
                editedEvent.deleteEvent(thisCalendar, dateTime, name);

                
                // Set initial panel visibility
                panelEveView.Visible = false;
                panelEveAdd.Visible = true;

                
                MessageBox.Show("Event edited.", "Calendar System");
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
            if (lBoxEveView.SelectedIndex >= 0)
            {
                string name = lBoxEveView.SelectedItem.ToString().Substring(0, lBoxEveView.SelectedItem.ToString().IndexOf("\t"));
                int dateBegin = lBoxEveView.SelectedItem.ToString().IndexOf("\t", lBoxEveView.SelectedItem.ToString().IndexOf("\t"));
                string dateTime = lBoxEveView.SelectedItem.ToString().Substring(dateBegin, (lBoxEveView.SelectedItem.ToString().IndexOf("\t-") - dateBegin));
                
                switch(deletedEvent.deleteEvent(thisCalendar, dateTime, name))
                {
                    case "VALID_EVENT":
                        MessageBox.Show("Event deleted.", "Calendar System");
                        populateEventBox();
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

        }

        private void btnEveBack_Click(object sender, EventArgs e)
        {
            // Set initial panel visibility
            panelEveView.Visible = true;
            panelEveAdd.Visible = false;
        }

        private void populateEventBox()
        {
            lBoxEveView.Items.Clear();
            foreach (Event eve in FormCalendar.thisCalendar.EventList)
            {
                if (eve.StartDate.Date.ToString("M/d/yyyy").Equals(FormCalendar.thisCalendar.Month + "/" + FormCalendar.thisCalendar.Day + "/" + FormCalendar.thisCalendar.Year))
                {
                    lBoxEveView.Items.Add(eve.Title + "\t\t\t" + eve.StartDate.ToString() + "\t-\t" + eve.EndDate.ToString());
                }
            }
        }
    }
}
