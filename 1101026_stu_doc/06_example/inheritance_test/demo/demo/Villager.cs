using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Villager
    {
        private int hp;
        public int GetHP()
        {
            return hp;
        }
        public void Injured(int injuredPoing)
        {
            hp -= injuredPoing;
            // add new code...
        }
        public String Talk()
        {
            return "HI!";
        }
    }
}
