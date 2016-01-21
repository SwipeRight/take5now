using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.NetworkOperators;
using Database;

namespace take5.Classes
{
    class Middleware
    {
        private Person localUser;
        private DatabaseConnection dbConn;

        public void login()
        {
            dbConn = new DatabaseConnection();
            this.localUser = new Person();
            

        }

        public Person userDetails(Person localUser)
        {
            localUser.userEmail = "dummy@dell.com";

            return localUser;
        }

        public void addPersonToQueue(Person localUser, int Activity)
        {
             
        }

        public void removePersonFromQueue()
        {
            
        }

        public void matchPeopleFromQueue()
        {
            
        }
        

    }
}
