using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace use_private
{
    class User
    {
        public string Username; // Username is public
        private string Password;

        public User(string Username, string Password) // create Constructor
        {
            this.Username = Username;
            this.Password = Password;
        }
        public bool comparePassword(string targetPassword) // create method
        {
                if (this.Password == targetPassword)
                    return true;
                else
                    return false;
        }

            private void reset()
            {
            Password = "";
            }

    }
}
