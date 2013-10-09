using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Bus.Card;

namespace Magic.Bus.Misc
{
    public static class Utils
    {
        public static readonly List<CardType> PermenantCardTypes = new List<CardType>()
        {
            CardType.Artifact,
            CardType.Creature,
            CardType.Enchantment,
            CardType.Land,
            CardType.Planeswalker
        };
    }
}
