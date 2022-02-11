using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class User
    {
        private string Username; ///It can be seen but can't be modified
        private string Password;
        private int count1, count5, count10;
        private int hp;

        public User(string Username, string Password) // create Constructor
        {
            this.Username = Username;
            this.Password = Password;
            hp = 20;
            count1 = 1;
            count5 = 1;
            count10 = 1;

        }


        public int HP  
            {
            get { return hp; }//Automatically call when reading HP 
            set
            {               //Automatically call when you save the value 
                if (value < 0) //value = -10
                    hp = 0;
                else
                    hp = value; //value = 10
            }
            }

        public int Money
        {
            get { return count1 + count5 * 5 + count10 * 10; }
        }



 

    }
}
