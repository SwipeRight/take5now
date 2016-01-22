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

        public void addUserToQueue(Person localuser, string activityID)
        {
            MyDatabase.AddUserToQueue(localuser, activityID);

        }

        public bool checkIfCanMatch(Person localUser, string activityID)
        {
            return MyDatabase.CheckForMatch(localUser, activityID);

        }

        public Person getUserDetailsFromMatchingQueue(int index)
        {
            return MyDatabase.Matches.ElementAt(index).getUser2Details();
        }

    }
}
