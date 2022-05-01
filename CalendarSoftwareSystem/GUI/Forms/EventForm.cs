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
            // Set Date
            FormCalendar.thisCalendar.Day = curDay;
            tBoxEveStartDate.Text = FormCalendar.thisCalendar.Month.ToString() + "/" 
                + FormCalendar.thisCalendar.Day.ToString() +  "/" 
                + FormCalendar.thisCalendar.Year.ToString();

            // Populate Attendants CheckList
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
            string title, description, location;
            List<string> attendants = new List<string>();
            DateTime startDate, endDate;
            string eventState = "VALID";

            if (tBoxEveName.Text.Length > 0)
                title = tBoxEveName.Text;
            else
                eventState = "NO TITLE";
            description = tBoxEveDesc.Text;
            location = tBoxEveLoc.Text;


            for (int i = 0; i <= chklstAttendants.Items.Count - 1; i++)
            {
                if (chklstAttendants.GetItemChecked(i))
                    attendants.Add(chklstAttendants.Items[i].ToString());
            }

            if (attendants.Count <= 0)
                if (eventState.Equals("NO TITLE"))
                    eventState = "NO TITLE OR ATTENDANTS";
                else
                    eventState = "NO ATTENDANTS";
            try
            {
                startDate = Convert.ToDateTime(tBoxEveStartDate.Text + " " + tBoxEveStartTime.Text);
            }
            catch (Exception ex)
            {
                eventState = "INVALID START";
            }

            try
            {
                endDate = Convert.ToDateTime(tBoxEveEndDate.Text + " " + tBoxEveEndTime.Text);
            }
            catch (Exception ex)
            {
                eventState = "INVALID END";
            }

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
                case "NO ATTENDANTS":
                    MessageBox.Show("Please add attendants to the event.", "Calendar System");
                    break;
                case "NO TITLE OR ATTENDANTS":
                    MessageBox.Show("Please add attendants and a title to the event.", "Calendar System");
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
