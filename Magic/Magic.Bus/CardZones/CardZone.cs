using Magic.Bus.Cards;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Bus.CardZones
{
    public class CardZone
    {
        public List<Card> Cards { get; set; }

        public CardZone()
        {
            Cards = new List<Card>();
        }
    }
}
