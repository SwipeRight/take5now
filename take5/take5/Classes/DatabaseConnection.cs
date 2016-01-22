using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;


namespace take5.Classes
{
    class DatabaseConnection
    {
        
        public void initialiseDatabase()
        {
            MyDatabase.InitialiseDataBase();
        }

        public void registerUserInDatabase(Person localUser)
        {
            //test.addUserToDatabase(localUser);
        }

        public void addUserToQueue(Person localuser, int activityID)
        {
            checkForMatch(activityID);
            MyDatabase.AddUserToQueue(localuser, activityID);
        }

        public void checkForMatch(int activityID)
        {
        
        }
    }
}
