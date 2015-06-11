using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Characters;

namespace TheSlum.GameEngine.Factories
{
    class CharacterFactory
    {
        public Character CreateCharacter(CharacterType type, string id, int x, int y, Team team)
        {
            switch (type)
            {
                case CharacterType.Warrior:
                    return new Warrior(id, x, y, team);
                    
                case CharacterType.Mage:
                    return new Mage(id, x, y, team);
                
                case CharacterType.Healer:
                    return new Healer(id, x, y, team);

                default:
                    throw new NotSupportedException("Character class does not exist.");

            }
        }
    }
}
