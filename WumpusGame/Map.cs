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

        public int WumpusRoom;
        Random random = new Random();
        public int currentRoom;


        public Map()
        {
            currentRoom = 1;
            WumpusRoom = GenerateWumpusRoomNumber();
        }

        public void Reset()
        {
            currentRoom = 1;
            WumpusRoom = GenerateWumpusRoomNumber();
        }

        public void PlayerLocation(int newRoom)
        {
            currentRoom = currentRoom + GameControl.move(newRoom); 
        }
        
        public void setRoom(int newRoom)
        {
            currentRoom = newRoom; 
        }
        
        public Boolean Overlap(int currentRoom)
        {
            if (batRooms.Contains(currentRoom) && pitRooms.Contains(currentRoom)) return true;
            return false;
        }

        private void GenerateBatRoomNumbers()
        {
            batRooms.Clear();
            int numOfRooms = 3;

            while (batRooms.Count < numOfRooms)
            {
                int randomRoom = random.Next(1, 30);
                if (pitRooms.Contains(randomRoom))
                    continue; //(another one) random room number
                else
                    batRooms.Add(randomRoom);
            }
        }

        public void EncounteredBat()
        {
            batRooms.Remove(currentRoom);
            int randomNumber = random.Next(1, 30);

            while (batRooms.Contains(randomNumber) || pitRooms.Contains(randomNumber))
            {
                randomNumber = random.Next(1, 30);
            }

            currentRoom = randomNumber;

            randomNumber = random.Next(1, 30);

            while (batRooms.Contains(randomNumber) || pitRooms.Contains(randomNumber))
            {
                randomNumber = random.Next(1, 30);
            }

            batRooms.Add(randomNumber);
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

        public int getWumpusLocation()
        {
            return WumpusRoom;
        }

        public void setWumpusLocation(int newRoom)
        {
            WumpusRoom = newRoom;
        }

    }
}
