using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealOrNoDeal
{
    class Player
    {

        private string firstName;
        private string lastName;
        private int age;
        private bool dealStatus;

        public Player(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get 
            {
                return firstName;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
        }

        public bool DealStatus
        {
            get
            {
                return dealStatus;
            }
            set
            {
                this.dealStatus = value;
            }
        }
    }
}
