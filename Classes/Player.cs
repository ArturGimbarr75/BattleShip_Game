using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Player
    {
        public string Name { get; set; }
        public GameBoard GameBoard { get; set; }
        //public FiringBoard FiringBoard { get; set; }
        public List<Ship> Ships { get; set; }
        //public bool HasLost

        public Player (string name)
        {
            Name = name;
            Ships = new List<Ship>()
            {
                new BattleShip(),
                new Cruiser(),
                new Destroyer(),
                new Submarine()
        
            };

            GameBoard = new GameBoard();
        }
    }
}
