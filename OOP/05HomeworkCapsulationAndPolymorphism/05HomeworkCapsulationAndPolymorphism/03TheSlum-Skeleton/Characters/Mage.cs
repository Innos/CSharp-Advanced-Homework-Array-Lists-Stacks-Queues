using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Characters
{
    class Mage : Character,IAttack
    {
        private const int MageHp = 150;
        private const int MageDefense = 50;
        private const int MageAttackPoints = 300;
        private const int MageRange = 5;

        public Mage(string id, int x, int y, Team team) : base(id,x,y,MageHp,MageDefense,team,MageRange)
        {
            this.AttackPoints = MageAttackPoints;
        }

        public int AttackPoints { get; set; }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            Character targetCharacter = targetsList
                .Where(target => target.IsAlive && target.Team != this.Team)
                .LastOrDefault();

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
        protected override void ApplyItemEffects(Item item)
        {
            this.AttackPoints += item.AttackEffect;
            base.ApplyItemEffects(item);
        }
        protected override void RemoveItemEffects(Item item)
        {
            this.AttackPoints -= item.AttackEffect;
            base.RemoveItemEffects(item);
        }
        public override string ToString()
        {
            StringBuilder output = new StringBuilder(base.ToString());
            output.Append(string.Format(", Attack: {0}", this.AttackPoints));
            return output.ToString();
        }
    }
}
