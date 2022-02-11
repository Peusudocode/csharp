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
        private int HP;

        public User(string Username, string Password) // create Constructor
        {
            this.Username = Username;
            this.Password = Password;
            this.HP = 20;
           
        }
        public bool comparePassword(string targetPassword)
        {
                if (this.Password == targetPassword)
                    return true;
                else
                    return false;
        }
        public void hurt(int decreaseHP)
        {
            if (HP >= decreaseHP)
                HP -= decreaseHP;
            else
                HP = 0;

        }
        public int getHP()// Because HP is set to private
        {
            return HP;
        }

    }
}
