using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Match
    {
        private Person User1 { get; set; }
        private Person User2 { get; set; }
        //1 - Pool
        //2 - Coffee
        //3 - Tenis
        //4 - Walk
        private int activity { get; set; }
        private long timestamp { get; set; }

        public Match(Person UserID1, Person UserID2, int Activity)
        {
            this.User1 = UserID1;
            this.User2 = UserID2;
            this.activity = Activity;
        }

        public Person getUser1Details()
        {
            return User1;
        }

        public Person getUser2Details()
        {
            return User2;
        }
    }
}
