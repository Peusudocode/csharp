using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Creature
    {

        private int hp = 100;
        public int GetHP()
        {
            return hp;
        }
        public void Injured(int injuredPoing)
        {
            hp -= injuredPoing;

        }
    }
}
