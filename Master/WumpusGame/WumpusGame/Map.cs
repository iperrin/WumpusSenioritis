using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class Map
    {
        Random random = new Random();
        public int currentRoom;
        public int bat1;
        public int bat2;
        public int Wumpus;

        Cave currentCave = new Cave();

        public Map()
        {
            //currentCave = GameControl.getCaveInfo(); 
            //Calls Cave to find information on the current cave
            bat1 = random.Next(0, 30);
            bat2 = random.Next(0, 30);
            Wumpus = random.Next(0, 30);
        }

        public void PlayerLocation()
        {
            //currentCave.findPlayer();
            //Finds player object in the current cave
        }

        public void MoveBat()
        {
            bat1 = random.Next(0, 30);
            bat2 = random.Next(0, 30);
        }

        public void MoveWumpus()
        {
            Wumpus = random.Next(0, 30);
        }
       
    }
}
