using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Panel  // Square field of a game
    {
        public OccupationType OccupationType;
        public Coordinates Coordinates;

        public Panel(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            OccupationType = OccupationType.Empty;
        }


    }
}
