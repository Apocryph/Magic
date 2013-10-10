using Magic.Bus.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Bus.Misc
{
    public class Deck
    {
        public string Name { get; set; }

        public List<Card> Cards { get; set; }

        public bool IsLegal
        {
            get
            {
                return Cards.Count() >= 60 && 
                    !Cards.Select(card => card.Name).Distinct()
                    .Except(new List<string>(){"Forest", "Plains", "Island", "Swamp", "Mountain"})
                    .Any(name => Cards.Where(card => card.Name == name).Count() > 4);
            }
        }

        public Deck()
        {
            Cards = new List<Card>();
        }
    }
}
