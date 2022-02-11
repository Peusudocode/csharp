using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Monster : Creature
    {


//  To write a different version of attack(overloaded), the code is highly reproducible  //要寫不同版本的 attack(overloaded) ,程式碼重複性很高
        //    public void Attack(Villager vi)
        //   {
        //        vi.Injured(10);
        //    }

        //    public void Attack(Villager mon)
        //   {
        //        mom.Injured(10);
        //    }
// Only one version of the attack //只要一個版本的 attack
        public void Attack(Creature c)
        {
            c.Injured(10);
        }


    }
}
