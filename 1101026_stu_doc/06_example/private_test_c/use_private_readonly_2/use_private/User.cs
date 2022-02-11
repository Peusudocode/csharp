using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace use_private
{
    class User
    {
        private string Username; //It can be seen but can't be modified
        private string Password;

        public User(string Username, string Password) // create Constructor
        {
            this.Username = Username;
            this.Password = Password;
        }
        public bool comparePassword(string targetPassword)
        {
                if (this.Password == targetPassword)
                    return true;
                else
                    return false;
        }
         public string getUsername()
            {
                return Username;
            }
            private void reset()
            {
            Password = "";
            }

    }
}
