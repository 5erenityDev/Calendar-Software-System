using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarSoftwareSystem
{
    class Manager : Employee
    {

        public Manager(string n, string user, string pass) : base(n, user, pass)
        {
            name = n;
            username = user;
            password = pass;
        }

        private void createGroupEvent()
        {

        }
    }
}
