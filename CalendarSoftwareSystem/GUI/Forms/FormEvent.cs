using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            panelEveCoord.Visible = false;
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
            possibleAttendants = Calendar.retrieveAttendants(possibleAttendants, thisEmployee.Name);
            

            foreach(string attendant in possibleAttendants)
                chklstAttendants.Items.Add(attendant);


        }

        // Used to make it so that only the user who created an event can edit or delete it.
        private void lViewEveView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (lViewEveView.SelectedItems.Count == 0)
                return;
            else
            {
                foreach (Event eve in thisCalendar.ThisCalendar.EventList)
                {
                    if (Int32.Parse(lViewEveView.SelectedItems[0].SubItems[0].Text) == eve.EventID)
                    {
                        if (eve.EmpID != thisEmployee.EmployeeID)
                        {
                            btnEveViewDelete.Visible = false;
                            btnEveViewEdit.Visible = false;
                        }
                        else
                        {
                            btnEveViewDelete.Visible = true;
                            btnEveViewEdit.Visible = true;
                        }
                    }
                }
            }    
        }

        // Used to make column widths non adjustable
        private void lViewEveView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = lViewEveView.Columns[e.ColumnIndex].Width;
        }

        private void btnEveSave_Click(object sender, EventArgs e)
        {
            // Initialize variables
            string title = "", description = "", location = "";
            List<string> attendantsList = new List<string>();
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
                    attendantsList.Add(chklstAttendants.Items[i].ToString());
            }
            string[] attendants = attendantsList.ToArray();

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
                    else
                    {
                        if (endHour == staHour && Int32.Parse(cBoxEveEndMin.Text) < Int32.Parse(cBoxEveStaMin.Text))
                        {
                            eventState = "END_BEFORE_START";
                        }
                        else
                        {
                            foreach (Event eve in thisCalendar.ThisCalendar.EventList)
                            {
                                if (eve.EventID.Equals(curEve))
                                {

                                }
                                else if ((startDate.CompareTo(eve.StartDate) == -1 && endDate.CompareTo(eve.StartDate) == 1)
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
            curEve = -1;

            // Update screen
            lblEveTitle.Text = "New Event";
            tBoxEveName.Text = "";
            tBoxEveDesc.Text = "";
            tBoxEveLoc.Text = "";
            chklstAttendants.ClearSelected();

            if (FormCalendar.CurUserIsManager)
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
                curEve = Int32.Parse(lViewEveView.SelectedItems[0].SubItems[0].Text);
                Event tempEvent = Calendar.retrieveEventDetails(curEve);
                
                lblEveTitle.Text = "Edit/View Event: " + tempEvent.Title;

                tBoxEveName.Text = tempEvent.Title;
                tBoxEveDesc.Text = tempEvent.Description;
                tBoxEveLoc.Text = tempEvent.Location;

                cBoxEveStaHour.Text = tempEvent.StartDate.ToString("hh");
                cBoxEveStaMin.Text = tempEvent.StartDate.ToString("mm");
                if (tempEvent.StartDate.ToString("tt").Equals("AM"))
                    radButEveStaAM.Checked = true;
                else
                    radButEveStaPM.Checked = true;
                cBoxEveEndHour.Text = tempEvent.EndDate.ToString("hh");
                cBoxEveEndMin.Text = tempEvent.EndDate.ToString("mm");
                if (tempEvent.EndDate.ToString("tt").Equals("AM"))
                    radButEveEndAM.Checked = true;
                else
                    radButEveEndPM.Checked = true;

                for (int i = 0; i < chklstAttendants.Items.Count; i++)
                {
                    foreach(string att in tempEvent.Attendants)
                    {
                        if (att.Equals(chklstAttendants.Items[i]))
                        {
                            chklstAttendants.SetItemChecked(i, true);
                            break;
                        }
                        else
                        {
                            chklstAttendants.SetItemChecked(i, false);
                        }
                    }
                }

                if (FormCalendar.CurUserIsManager)
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
                tBoxEveName.Text = lViewEveView.SelectedItems[0].SubItems[1].Text;

                
                // Set initial panel visibility
                panelEveView.Visible = false;
                panelEveAdd.Visible = true;

                isEditing = true;
                
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
                // Prompt the user asking them if they wish to log off
                string message = "Are you sure you wish to Delete this event?";
                string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                // If they say yes, delete the event.
                // If they say no, do nothing and simply return to event menu.
                if (result == DialogResult.Yes)
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
        }

        private void btnEveBack_Click(object sender, EventArgs e)
        {
            // Set initial panel visibility
            panelEveView.Visible = true;
            panelEveAdd.Visible = false;
        }

        private void btnEveCoord_Click(object sender, EventArgs e)
        {
            List<string> attendants = new List<string>();
            attendants.Add(thisEmployee.Name);
            // Find selected attendants
            for (int i = 0; i <= chklstAttendants.Items.Count - 1; i++)
            {
                if (chklstAttendants.GetItemChecked(i))
                    attendants.Add(chklstAttendants.Items[i].ToString());
            }
            string[] attArr = attendants.ToArray();

            if (attendants.Count > 1)
            {
                // Initialize Variables
                List<Tuple<DateTime, DateTime>> tempDates = Manager.retrieveAllEventTimes(attArr, Convert.ToDateTime(FormCalendar.thisCalendar.Month + "/" + FormCalendar.thisCalendar.Day + "/" + FormCalendar.thisCalendar.Year), curEve);
                List<DateTime> goodTimes = new List<DateTime>();
                if (tempDates.Count > 0)
                {
                    DateTime dt = tempDates[0].Item1.Date;
                    DateTime dt2 = dt.AddDays(1);

                    // Get every minute of a day
                    while (dt.Date < dt2.Date)
                    {
                        goodTimes.Add(dt);
                        dt = dt.AddMinutes(1);
                    }

                    // Remove every minute that an employee is busy
                    foreach (Tuple<DateTime, DateTime> date in tempDates)
                    {
                        for (dt = date.Item1; dt <= date.Item2; dt = dt.AddMinutes(1))
                        {
                            goodTimes.Remove(dt);
                        }
                    }

                    // Set Intial Variables
                    tempDates = new List<Tuple<DateTime, DateTime>>();
                    DateTime prevDate = new DateTime(goodTimes[0].Year, goodTimes[0].Month, goodTimes[0].AddDays(-1).Day, 23, 59, 0);
                    DateTime firstDate = goodTimes[0];

                    // Calculate the avaliable timeframes
                    foreach (DateTime date in goodTimes)
                    {
                        if (prevDate.AddMinutes(1) != date)
                        {
                            tempDates.Add(new Tuple<DateTime, DateTime>(firstDate, prevDate));
                            firstDate = date;
                        }
                        prevDate = date;
                    }
                    tempDates.Add(new Tuple<DateTime, DateTime>(firstDate, prevDate));
                    lViewEveCoord.Items.Clear();

                    var header1 = lViewEveCoord.Columns.Add("Start Date", -2, HorizontalAlignment.Left);
                    var header2 = lViewEveCoord.Columns.Add("End Date", -2, HorizontalAlignment.Left);

                    // Display the avaliable timeframes to the user in a list view
                    foreach (Tuple<DateTime, DateTime> range in tempDates)
                    {
                        ListViewItem lvi = new ListViewItem(new string[]
                        {
                        range.Item1.ToString("hh:mm:ss tt"),
                        range.Item2.ToString("hh:mm:ss tt")
                        });
                        lViewEveCoord.Items.Add(lvi);
                    }

                    lViewEveCoord.Columns[0].Width = -2;
                    lViewEveCoord.Columns[1].Width = -2;

                    // Set panel visibility
                    panelEveAdd.Visible = false;
                    panelEveCoord.Visible = true;
                }
                else
                {
                    MessageBox.Show("There are no conflicts with the other attendant's schedules. Use any time you wish!", "Calendar System");
                }
                
            }
            else
            {
                MessageBox.Show("Please add attendants to the meeting first.", "Calendar System");
            }
        }

        private void btnEveCoordCancel_Click(object sender, EventArgs e)
        {
            // Set panel visibility
            panelEveAdd.Visible = true;
            panelEveCoord.Visible = false;
        }

        private void btnEveCoordSelect_Click(object sender, EventArgs e)
        {
            // Create DateTime variables
            DateTime start = Convert.ToDateTime(lViewEveCoord.SelectedItems[0].SubItems[0].Text.ToString());
            DateTime end = Convert.ToDateTime(lViewEveCoord.SelectedItems[0].SubItems[1].Text.ToString());

            // Change Start Hour
            cBoxEveStaHour.Text = start.ToString("hh");
            cBoxEveStaMin.Text = start.ToString("mm");
            if (start.ToString("tt").Equals("AM"))
                radButEveStaAM.Checked = true;
            else
                radButEveStaPM.Checked = true;

            // Change End Hour
            cBoxEveEndHour.Text = end.ToString("hh");
            cBoxEveEndMin.Text = end.ToString("mm");
            if (end.ToString("tt").Equals("AM"))
                radButEveEndAM.Checked = true;
            else
                radButEveEndPM.Checked = true;

            // Set panel visibility
            panelEveAdd.Visible = true;
            panelEveCoord.Visible = false;
        }



        private void populateEventList()
        {
            lViewEveView.Items.Clear();
            var header1 = lViewEveView.Columns.Add("Event ID", -2, HorizontalAlignment.Left);
            var header2 = lViewEveView.Columns.Add("Title", -2, HorizontalAlignment.Left);
            var header3 = lViewEveView.Columns.Add("Start Time", -2, HorizontalAlignment.Left);
            var header4 = lViewEveView.Columns.Add("End Time", -2, HorizontalAlignment.Left);

            foreach (Event eve in thisCalendar.ThisCalendar.EventList)
            {
                if (eve.StartDate.Date.ToString("M/d/yyyy").Equals(FormCalendar.thisCalendar.Month + "/" + FormCalendar.thisCalendar.Day + "/" + FormCalendar.thisCalendar.Year))
                {
                    ListViewItem lvi = new ListViewItem(new string[]
                    {
                    eve.EventID.ToString(),
                    eve.Title,
                    eve.StartDate.ToString("hh:mm:ss tt"),
                    eve.EndDate.ToString("hh:mm:ss tt")
                    });
                    lViewEveView.Items.Add(lvi);
                }
            }
            lViewEveView.Columns[0].Width = 0;
            lViewEveView.Columns[1].Width = -2;
            lViewEveView.Columns[2].Width = -2;
            lViewEveView.Columns[3].Width = -2;
            lViewEveView.Sort();
        }

        
    }
}
