using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.GameEngine
{
    using TheSlum.Characters;
    using TheSlum.Interfaces;
    using TheSlum.GameEngine.Factories;
    using TheSlum.Objects;

    class ExtendedEngine : Engine
    {
        private CharacterFactory characterFactory = new CharacterFactory();
        private ItemFactory itemFactory = new ItemFactory();

        protected override void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "create":
                    this.CreateCharacter(inputParams);
                    break;
                case "add":
                    this.AddItem(inputParams);
                    break;
                default:
                    base.ExecuteCommand(inputParams);
                    break;
            }
        }

        protected override void CreateCharacter(string[] inputParams)
        {
            string characterClass = inputParams[1];
            string name = inputParams[2];
            int x = int.Parse(inputParams[3]);
            int y = int.Parse(inputParams[4]);

            var team = (Team)Enum.Parse(typeof(Team), inputParams[5],true);
            CharacterType type = (CharacterType)Enum.Parse(typeof(CharacterType), characterClass,true);

            Character character = this.characterFactory.CreateCharacter(type, name, x, y, team);

            characterList.Add(character);
        }

        protected new void AddItem(string[] inputParams)
        {
            string characterID = inputParams[1];
            string itemType = inputParams[2];
            string itemID = inputParams[3];

            ItemType type = (ItemType)Enum.Parse(typeof(ItemType), itemType,true);
            Item item = this.itemFactory.CreateItem(type, itemID);

            Character character = GetCharacterById(characterID);
            character.AddToInventory(item);
        }
    }
}
