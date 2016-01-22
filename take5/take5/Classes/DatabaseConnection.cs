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
            int matchedAlready = checkForMatch(activityID);
            if (matchedAlready >= 0)
            {
                MyDatabase.getUserDetailsFromQueue(matchedAlready);
            }
            else
            {
                MyDatabase.AddUserToQueue(localuser, activityID);
            }

        }

        public int checkForMatch(int activityID)
        {
            int matchedAlready = MyDatabase.CheckForMatch(activityID);

            return MyDatabase.getUserDetailsFromQueue(matchedAlready);

        }

    }
}
