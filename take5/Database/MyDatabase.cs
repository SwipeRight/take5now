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
        List<Match> Matches;
        List<Match> History;
        

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
            
            Activities.Add(string.Format("Pool"));
            Activities.Add(string.Format("Coffee"));
            Activities.Add(string.Format("Tenis"));
            Activities.Add(string.Format("Walk"));
            
        }

        protected void InitialiseUsers()
        {
            Users = new List<Person>();
            Users.Count();
            Users.Add(new Person(getIndex(), "martin_nikolaev@dell.com"));
            Users.Add(new Person(getIndex(), "delltest@dell.com"));
        }

        public void newMatch(int index, int UserID1, int UserID2, int Activity, long timeStamp)
        {
            Matches.Add(new Match(index, UserID1, UserID2, Activity, timeStamp));

        }

        protected void removeMatch(int index)
        {
            Matches.RemoveAt(index);
        }

        protected void addToHistory(int index)
        {
            History.Add(Matches.ElementAt(index));
        }

        public void moveToHistory(int index)
        {
            addToHistory(index);
            removeMatch(index);
        }

        protected int getIndex(){
            return Users.Count + 1;
        }
    }
}
