using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Queue
    {

        private int Index { get; set; }
        private Person User { get; set; }
        private int Activity { get; set; }

        public Queue(int index, Person user, int activity)
        {
            this.Index = index;
            this.User = user;
            this.Activity = activity;
        }

        public int getUserActivity()
        {
            return Activity;
        }

        public Person GetPerson()
        {
            return User;
        }

    }
}
