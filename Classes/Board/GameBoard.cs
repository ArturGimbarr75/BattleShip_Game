using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class GameBoard
    {
        const int _NUM_OF_ROWS_ = 10;
        const int _NUM_OF_COLUMS_ = 10;

        public List<Panel> Panels { get; set; }

        public GameBoard()
        {
            Panels = new List<Panel>();

            for (int i = 0; i < _NUM_OF_ROWS_; i++)
            {
                for (int j = 0; j < _NUM_OF_COLUMS_; j++)
                {
                    Panels.Add(new Panel(i, j));
                }

            }
        }
    }
}
