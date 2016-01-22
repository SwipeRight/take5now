using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Automation.Peers;

namespace Database
{
    public static class MyDatabase
    {
        private static List<Activity> Activities = new List<Activity>();
        private static List<Person> Users = new List<Person>();
        private static List<Match> Matches = new List<Match>();
        private static List<Match> History = new List<Match>();
        private static List<Queue> Queues = new List<Queue>();
         

        public static void InitialiseDataBase()
        {
            InitialiseActivities();
            InitialiseUsers();
            InitialiseMatches();
            InitiliseQueues();
        }

        private static void InitiliseQueues()
        {
            Queues.Add(new Queue(getQueueIndex(), Users.ElementAt(0), Activities.ElementAt(0).index));
            Queues.Add(new Queue(getQueueIndex(), Users.ElementAt(1), Activities.ElementAt(0).index));
            Queues.Add(new Queue(getQueueIndex(), Users.ElementAt(0), Activities.ElementAt(1).index));
            Queues.Add(new Queue(getQueueIndex(), Users.ElementAt(1), Activities.ElementAt(1).index));
            Queues.Add(new Queue(getQueueIndex(), Users.ElementAt(0), Activities.ElementAt(2).index));
            Queues.Add(new Queue(getQueueIndex(), Users.ElementAt(1), Activities.ElementAt(2).index));
            Queues.Add(new Queue(getQueueIndex(), Users.ElementAt(0), Activities.ElementAt(3).index));
            Queues.Add(new Queue(getQueueIndex(), Users.ElementAt(1), Activities.ElementAt(3).index));
        }

        private static void InitialiseMatches()
        {
            
        }


        private static void InitialiseActivities()
        {
            Activities = new List<Activity>();
            
            Activities.Add(new Activity(getActivitiesIndex(), "Pool"));
            Activities.Add(new Activity(getActivitiesIndex(), "Coffee"));
            Activities.Add(new Activity(getActivitiesIndex(), "Tenis"));
            Activities.Add(new Activity(getActivitiesIndex(), "Walk"));
            
        }

        private static void InitialiseUsers()
        {
            Users = new List<Person>();
            Users.Add(new Person(getUsersIndex(), "martin_nikolaev@dell.com"));
            Users.Add(new Person(getUsersIndex(), "delltest@dell.com"));
        }

        public static void addUserToDatabase(Person thisPerson)
        {
            thisPerson.userID = getUsersIndex();
            Users.Add(thisPerson);
        }

        public static void newMatch(int index, int UserID1, int UserID2, int Activity, long timeStamp)
        {
            Matches.Add(new Match(index, UserID1, UserID2, Activity, timeStamp));

        }

        public static void CheckForMatch(int activityId)
        {
            int match = Queues.FindIndex(queue => queue.getUserActivity() == activityId);
            if (match > 0)
            {
                
            }
        }

        private static void RemoveMatch(int index)
        {
            Matches.RemoveAt(index);
        }

        private static void AddToHistory(int index)
        {
            History.Add(Matches.ElementAt(index));
        }

        public static void AddUserToQueue(Person localUser, int activityID)
        {
            Queues.Add(new Queue(getQueueIndex(), localUser, activityID));
        }

        public static void moveToHistory(int index)
        {
            AddToHistory(index);
            RemoveMatch(index);
        }

        private static int getUsersIndex()
        {
            return Users.Count + 1;
        }

        private static int getQueueIndex()
        {
            return Queues.Count + 1;
        }

        private static int getActivitiesIndex()
        {
            return Activities.Count + 1;
        }
    }
}
