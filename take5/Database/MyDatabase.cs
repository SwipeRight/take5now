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
        public static List<Match> Matches = new List<Match>();
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
            //Queues.Add(new Queue(Users.ElementAt(0), Activities.FindIndex(x => x.name.Equals("Coffee"))));
            //Queues.Add(new Queue(Users.ElementAt(1), Activities.FindIndex(x => x.name.Equals("Pool"))));



        }

        private static void InitialiseMatches()
        {

        }


        private static void InitialiseActivities()
        {
            Activities = new List<Activity>();

            Activities.Add(new Activity("Pool"));
            Activities.Add(new Activity("Coffee"));
            Activities.Add(new Activity("Tenis"));
            Activities.Add(new Activity("Walk"));

        }

        private static void InitialiseUsers()
        {
            Users = new List<Person>();
            Users.Add(new Person("martin_nikolaev@dell.com"));
            Users.Add(new Person("delltest@dell.com"));
        }

        public static void addUserToDatabase(Person thisPerson)
        {
            Users.Add(thisPerson);
        }



        public static bool CheckForMatch(Person localUser, string activityId)
        {
            int match;
            match = Queues.FindIndex(queue => queue.getUserActivity().Equals(Activities.FindIndex(x => x.name.Equals(activityId))));

            if (match >= 0)
            {
                Matches.Add(new Match(localUser, Queues.ElementAt(match).GetPerson(), Activities.FindIndex(x => x.name.Equals(activityId))));
                Queues.RemoveAt(match);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Person getUserDetails(int index)
        {
            return Users.ElementAt(index);
        }

        public static int getUserDetailsFromQueue(int index)
        {
            if (index >= 0)
            {
                return Queues.ElementAt(index).GetPerson().userID;
            }
            else
            {
                return -1;
            }
        }

        public static void RemoveMatch(Person userToBeRemovedFromQueue)
        {
            Matches.RemoveAt(Matches.FindIndex(x => x.getUser2Details().userEmail.Equals(userToBeRemovedFromQueue.userEmail)));
        }


        public static void RemoveUserFromQueue(Person userToBeRemovedFromQueue)
        {
            Queues.RemoveAt(Queues.FindIndex(x => x.GetPerson().userEmail.Equals(userToBeRemovedFromQueue.userEmail)));
        }

        public static void AddUserToQueue(Person localUser, string activityId)
        {
            Queues.Add(new Queue(localUser, Activities.FindIndex(x => x.name.Equals(activityId))));
        }
    }
}