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

        public EventForm(int day)
        {
            curDay = day;
            InitializeComponent();
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
            cBoxEveStaMon.Text = FormCalendar.thisCalendar.Month.ToString();
            cBoxEveStaDay.Text = FormCalendar.thisCalendar.Day.ToString();
            cBoxEveStaYear.Text = FormCalendar.thisCalendar.Year.ToString();

            cBoxEveEndMon.Text = FormCalendar.thisCalendar.Month.ToString();
            cBoxEveEndDay.Text = FormCalendar.thisCalendar.Day.ToString();
            cBoxEveEndYear.Text = FormCalendar.thisCalendar.Year.ToString();

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
            string title, description, location;
            List<string> attendants = new List<string>();
            DateTime startDate, endDate;
            string eventState = "VALID";

            // Add title
            if (tBoxEveName.Text.Length > 0)
                title = tBoxEveName.Text;
            else
                eventState = "NO TITLE";

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
                startDate = Convert.ToDateTime(cBoxEveStaMon.Text + "/" + cBoxEveStaDay.Text + "/" + cBoxEveStaYear.Text + " " + cBoxEveStaHour.Text + ":" + cBoxEveStaMin.Text + " " + "AM");
            }
            catch (Exception ex)
            {
                eventState = "INVALID START";
            }

            // Add end date
            try
            {
                endDate = Convert.ToDateTime(cBoxEveEndMon.Text + "/" + cBoxEveEndDay.Text + "/" + cBoxEveEndYear.Text + " " + cBoxEveEndHour.Text + ":" + cBoxEveEndMin.Text + " " + "AM");
            }
            catch (Exception ex)
            {
                eventState = "INVALID END";
            }

            // Check and make sure all necessary features have been added
            switch (eventState)
            {
                case "VALID":
                    ///
                    /// Create Event code here
                    ///
                    MessageBox.Show("Event created.");
                    this.Close();
                    break;
                case "NO TITLE":
                    MessageBox.Show("Please add an event title.", "Calendar System");
                    break;
                case "INVALID START":
                    MessageBox.Show("The start date for the event is invalid. Please provide it in MM/DD/YYYY format", "Calendar System");
                    break;
                case "INVALID END":
                    MessageBox.Show("The end date for the event is invalid. Please provide it in MM/DD/YYYY format", "Calendar System");
                    break;
            }

        }
    }
}
