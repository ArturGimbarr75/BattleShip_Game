using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public enum OccupationType
    {
        Empty = 'O',        // An empty pannel

        BattleShip = 'B',   // The ship with a lenght of 4 'pannels'

        Cruiser = 'C',     // The ship with a lenght of 3 'pannels'

        Destroyer = 'D',   // The ship with a lenght of 2 'pannels'

        Submarine = 'S',  // The ship with a lenght of 1 'pannel'

        Hit = 'X',

        Miss = 'M'
    }
}
