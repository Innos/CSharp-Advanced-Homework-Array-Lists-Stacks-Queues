using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Objects
{

    class Injection : Bonus
    {
        private const int injectionHealthBonus = 200;
        private const int injectionDefenseBonus = 0;
        private const int injectionAttackBonus = 0;
        private const int injectionCountdown = 3;

        public Injection(string id)
            : base(id, injectionHealthBonus,injectionDefenseBonus,injectionAttackBonus,injectionCountdown)
        {

        }
    }
}
