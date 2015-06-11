using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Objects
{
    class Pill : Bonus
    {
        private const int pillHealthBonus = 0;
        private const int pillDefenseBonus = 0;
        private const int pillAttackBonus = 100;
        private const int pillCountdown = 1;

        public Pill(string id)
            : base(id, pillHealthBonus,pillDefenseBonus,pillAttackBonus,pillCountdown)
        {

        }

    }
}
