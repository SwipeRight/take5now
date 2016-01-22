﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Database
{
    public class Person
    {
        public int userID { get; set; }
        public string userEmail { get; set; }

        public Person()
        {
            this.userID = 0;
            this.userEmail = "";
        }
        public Person(int userID, string userEmail)
        {
            this.userID = userID;
            this.userEmail = userEmail;
            //testajsdasdsd
        }

        public Person(Person myPerson)
        {
            this.userEmail = myPerson.userEmail;
            this.userID = myPerson.userID;
        }
    }
}