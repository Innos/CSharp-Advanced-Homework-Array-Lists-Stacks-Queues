using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Healer : Character,IHeal
    {
        private const int HealerHp = 75;
        private const int HealerDefense = 50;
        private const int HealerHealPoints = 60;
        private const int HealerRange = 6;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, HealerHp, HealerDefense, team, HealerRange)
        {
            this.HealingPoints = HealerHealPoints;
        }

        public int HealingPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            //First or Default returns null for custom classes
            Character targetCharacter = targetsList
                .Where(target => target.IsAlive && target.Team == this.Team && target != this)
                .OrderBy(target => target.HealthPoints)
                .FirstOrDefault();

            return targetCharacter;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.Append(string.Format(", Healing: {0}", this.HealingPoints));
            return output.ToString();
        }
    }
}
