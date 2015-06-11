using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Objects
{
    class Axe : Item
    {
        private const int axeHealthBonus = 0;
        private const int axeDefenseBonus = 0;
        private const int axeAttackBonus = 75;

        public Axe(string id)
            : base(id, axeHealthBonus,axeDefenseBonus,axeAttackBonus)
        {

        }
    }
}
