using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WumpusGame
{
    class Map
    {
        private HashSet<int> batRooms = new HashSet<int>(); // set of rooms bats can be in
        private HashSet<int> pitRooms = new HashSet<int>(); // set of rooms pits can be in

        public int InitialWumpusRoom { get; private set; }
        Random random = new Random();
        public int currentRoom;
        public int Wumpus;


        public Map()
        {
            currentRoom = 1;
            Wumpus = random.Next(0, 30);
        }

        public void Reset()
        {
            currentRoom = 1;
            Wumpus = random.Next(1, 30);
        }

    /*    public void PlayerLocation(int newRoom)
        {
            currentRoom = currentRoom + GameControl.move(newRoom); 
        } */

        private void GenerateBatRoomNumbers()
        {
            batRooms.Clear();
            int numOfRooms = 3;

            while (batRooms.Count < numOfRooms)
            {
                batRooms.Add(random.Next(1, 30));
            }
        }

        private void GeneratePitRoomNumbers()
        {
            pitRooms.Clear();
            int numOfRooms = 2;

            while (pitRooms.Count < numOfRooms)
            {
                int randomRoom = random.Next(1, 30);
                if (batRooms.Contains(randomRoom))
                    continue; //(another one) random room number
                else
                    pitRooms.Add(randomRoom);
            }
        }

        private int GenerateWumpusRoomNumber()
        {
            int randomNumber = random.Next(1, 30);

            while (batRooms.Contains(randomNumber) && pitRooms.Contains(randomNumber))
            {
                randomNumber = random.Next(1, 30);
            }

            return randomNumber;
        }

        public void MoveWumpus()
        {
            Wumpus = random.Next(1, 30);
        }

    }
}