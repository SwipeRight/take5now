using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class MyDatabase
    {
        List<string> Activities;
        List<Person> Users;
        

        public MyDatabase()
        {
            InitialiseActivities();
            InitialiseUsers();
        }

        public IEnumerable<string> GetActivities()
        {
            return Activities;
        }

        protected void InitialiseActivities()
        {
            Activities = new List<string>();
            for (int x = 0; x < 5; x++)
            {
                Activities.Add(string.Format("Pool"));
                Activities.Add(string.Format("Coffee"));
                Activities.Add(string.Format("Tenis"));
                Activities.Add(string.Format("Walk"));
            }
        }

        protected void InitialiseUsers()
        {
            Users = new List<Person>();
            Users.Add(new Person(1, "martin_nikolaev@dell.com"));
            Users.Add(new Person(2, "delltest@dell.com"));
        }
    }
}
