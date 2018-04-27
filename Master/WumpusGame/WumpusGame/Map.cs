using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusTest
{
    class Map
    {
        public int currentRoom;
        public int creature;

        Cave currentCave = new Cave();

        public Map()
        {
            currentCave = ProgramManager.info.cave;
        }

        public void PlayerLocation()
        {
            GameControl.getPlayerData();
        }
       
    }
}
