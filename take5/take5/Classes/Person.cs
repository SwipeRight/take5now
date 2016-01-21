

using System;

namespace take5.Classes
{
    class Person
    {
        private int userID { get; set; }
        private string userEmail { get; set; }

        public Person()
        {
            this.userID = 0;
            this.userEmail = "";

            getUserDetails();
        }

        private async void getUserDetails()
        {
            
        }

    }
}
