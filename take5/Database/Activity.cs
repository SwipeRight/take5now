using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    class Activity
    {
        public int index { get; set; }
        public string name { get; set; }

        public Activity(int index, string name)
        {
            this.index = index;
            this.name = name;
        }
    }
}
