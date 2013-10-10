using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Bus.Board
{
    public class Board
    {
        //Two zones for now.  Could potentially have More for different game types, collections of allied and enemy card zones.
        public BoardZone PlayerZone { get; set; }
        public BoardZone EnemyZone { get; set; }

        public Board()
        {
            PlayerZone = new BoardZone();
            EnemyZone = new BoardZone();
        }
    }
}
