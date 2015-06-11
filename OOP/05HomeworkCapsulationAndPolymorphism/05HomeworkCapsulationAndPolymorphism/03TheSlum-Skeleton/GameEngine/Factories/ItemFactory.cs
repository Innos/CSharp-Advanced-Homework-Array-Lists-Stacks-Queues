using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSlum.GameEngine.Factories
{
    using TheSlum.Objects;

    class ItemFactory
    {
        public Item CreateItem(ItemType type, string id)
        {
            switch (type)
            {
                case ItemType.Axe:
                    return new Axe(id);
                case ItemType.Shield:
                    return new Shield(id);
                case ItemType.Pill:
                    return new Pill(id);
                case ItemType.Injection:
                    return new Injection(id);
                default:
                    throw new NotSupportedException("Item class does not exist.");
            }
        }
    }
}
