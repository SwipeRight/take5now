using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Queue
    {

        private int index;
        private Person User;
        private int activity;

        public Queue(int index, Person user, int activity)
        {
            this.index = index;
            this.User = user;
            this.activity = activity;
        }


    }
}
