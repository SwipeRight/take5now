using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Matches
    {
        private int index { get; set; }
        private int userID1 { get; set; }
        private int userID2 { get; set; }
        //1 - Pool
        //2 - Coffee
        //3 - Tenis
        //4 - Walk
        private int activity { get; set; }
        private long timestamp { get; set; }

        public void newMatch(int index, int UserID1, int UserID2, int Activity, long timeStamp)
        {
            this.index = index;
            this.userID1 = UserID1;
            this.userID2 = UserID2;
            this.activity = Activity;
            this.timestamp = timeStamp;
        }

    }
}
