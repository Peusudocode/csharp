using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Monster : Creature
    {


        //2   public int Attack()
        //2   {
        //2       return 10;
        //2  }
        public void Attack(Villager vi)
        {
            vi.Injured(10);
        }


    }
}
