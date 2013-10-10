using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Bus.Abilities;
using Magic.Bus.Mana;
using Magic.Bus.Misc;

namespace Magic.Bus.Cards
{
    public class Card
    {
        public string Name { get; set; }

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

        public int BasePower { get; set; }

        public int BaseToughness { get; set; }

        public List<PowerToughnessAdjustment> PowerToughnessAdjustments { get; set; }

        public int Power
        {
            get
            {
                return BasePower + PowerToughnessAdjustments.Select(pwa => pwa.PowerAdjustment).Sum();
            }
        }

        public int Toughness
        {
            get
            {
                return BaseToughness + PowerToughnessAdjustments.Select(pwa => pwa.ToughnessAdjustment).Sum();
            }
        }

        public bool IsTapped { get; set; }

        public Card()
        {
            CastingCost = new List<ICost>();
            CardTypes = new List<CardType>();
            CreatureTypes = new List<CreatureType>();
            PlaneswalkerTypes = new List<PlaneswalkerType>();
            PassiveAbilities = new List<Ability>();
            ActivatedAbilities = new List<Ability>();
            PowerToughnessAdjustments = new List<PowerToughnessAdjustment>();
        }
    }
}
