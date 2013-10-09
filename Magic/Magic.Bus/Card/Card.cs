using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Bus.Abilities;
using Magic.Bus.Mana;
using Magic.Bus.Misc;

namespace Magic.Bus.Card
{
    public class Card
    {
        public ManaValue ManaCost { get; set; }

        public List<ICost> CastingCost { get; set; } 

        public List<CardType> CardTypes { get; set; }

        public bool IsPermenant
        {
            get
            {
                return CardTypes.Intersect(Utils.PermenantCardTypes).Any();
            }
        }

        public List<CreatureType> CreatureTypes { get; set; }
        
        public List<PlaneswalkerType> PlaneswalkerTypes { get; set; }

        public List<Ability> PassiveAbilities { get; set; }

        public List<Ability> ActivatedAbilities { get; set; }

 
    }
}
