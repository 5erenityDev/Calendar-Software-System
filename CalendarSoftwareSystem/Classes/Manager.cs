using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CalendarSoftwareSystem
{
    public class Manager : Employee
    {

        public Manager(int empID, string n, string user, string pass) : base(empID, n)
        {
            employeeID = empID;
            name = n;
        }

        public static List<Tuple<DateTime, DateTime>> retrieveAllEventTimes(string[] attarr, DateTime date, int curEve)
        {
            List<Tuple<DateTime, DateTime>> allTimes = new List<Tuple<DateTime, DateTime>>();
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            try
            {
                string sql = "SELECT startDate, endDate FROM csop_event WHERE (evntID != @uEveID)";
                bool firstLoop = true;
                foreach (string att in attarr)
                {
                    if (firstLoop)
                    {
                        sql += " AND (attendants LIKE \'%" + att + "%\'";
                        firstLoop = false;
                    }
                    else
                        sql += " OR attendants LIKE \'%" + att + "%\'";
                }
                sql += ");";

                conn.Open();
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@uEveID", curEve);

                MySqlDataReader myReader = cmd.ExecuteReader();
                while (myReader.Read())
                {
                    DateTime startDate = Convert.ToDateTime(myReader["startDate"].ToString());
                    DateTime endDate = Convert.ToDateTime(myReader["endDate"].ToString());
                    if (startDate.Date == date.Date)
                        allTimes.Add(new Tuple<DateTime, DateTime>(startDate, endDate));
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return allTimes;
        }

        // Used to create a manager object from the database
        public static Manager retrieveManager(int empID)
        {
            string connStr = "server=157.89.28.29;user=student;database=csc340_db;port=3306;password=Maroon@21?;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
            Manager thisManager = null;

            try
            {
                conn.Open();
                string sql = "SELECT * FROM csop_employee WHERE empID=@empID";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@empID", empID);

                MySqlDataReader myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    string name = myReader["name"].ToString();
                    string username = myReader["username"].ToString();
                    string password = myReader["password"].ToString();

                    thisManager = new Manager(empID, name, username, password);
                }
                myReader.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();

            return thisManager;
        }
    }
}
