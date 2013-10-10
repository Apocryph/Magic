using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Magic.Bus.CardZones;

namespace Magic.Bus.Board
{
    public class BoardZone
    {
        public CardZone Library { get; set; }
        public CardZone Hand { get; set; }
        public CardZone Field { get; set; }
        public CardZone Graveyard { get; set; }
        public CardZone Exiled { get; set; }

        public BoardZone()
        {
            Library = new CardZone();
            Hand = new CardZone();
            Field = new CardZone();
            Graveyard = new CardZone();
            Exiled = new CardZone();
        }
    }
}
