using Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
    }
}
