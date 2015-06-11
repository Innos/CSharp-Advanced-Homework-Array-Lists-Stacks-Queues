using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.Objects
{
    class Shield : Item
    {
        private const int shieldHealthBonus = 0;
        private const int shieldDefenseBonus = 50;
        private const int shieldAttackBonus = 0;

        public Shield(string id)
            : base(id, shieldHealthBonus, shieldDefenseBonus,shieldAttackBonus)
        {

        }
    }
}
