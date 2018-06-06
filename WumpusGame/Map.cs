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
        private int bat1Room;
        private int bat2Room;
        private int pit1Room;
        private int pit2Room;

        public int WumpusRoom;
        Random random = new Random();
        public int currentRoom;

        public Map()
        {
            currentRoom = 1;
            bat1Room = GenerateBatRoomNumber();
            bat2Room = GenerateBatRoomNumber();
            pit1Room = GeneratePitRoomNumber();
            pit2Room = GeneratePitRoomNumber();
            WumpusRoom = GenerateWumpusRoomNumber();
        }

        public void Reset()
        {
            currentRoom = 1;
            WumpusRoom = GenerateWumpusRoomNumber();
        }

        public int GetPlayerRoom()
        {
            return currentRoom;
        }

        public void SetPlayerRoom(int newRoom)
        {
            currentRoom = newRoom; 
        }
        
        //checks for overlap of pits and bats in the rooms
        public Boolean NoOverlap(int room)
        {
            if (batRooms.Contains(room) && pitRooms.Contains(room)) return false;
            else if (pitRooms.Contains(room) && GetWumpusLocation() == room) return false;
            else if (batRooms.Contains(room) && GetWumpusLocation() == room) return false;
            //DELETE THE ABOVE 2 LINES IF THE WUMPUS CAN BE IN THE SAME ROOM AS THE PITS/BATS BECAUSE IM NOT SURE ABOUT THIS
            return true;
        }
        
        //sets bats room to a random room, but first checks for overlap between other rooms
        private int GenerateBatRoomNumber()
        {
            int randomRoom = random.Next(1, 30);
            if (!NoOverlap(randomRoom)) randomRoom = random.Next(1,30); //(another one) random room number
            batRooms.Add(randomRoom);
            return randomRoom;
        }
        
        //next 2 methods changes the bats location
        private int MoveBat1Location(int bat)
        {
            int randomRoom = random.Next(1, 30);
            if (!NoOverlap(randomRoom) || batRooms.Contains(randomRoom)) randomRoom = random.Next(1, 30); //(another one) random room number
            batRooms.Add(randomRoom);
            return randomRoom;
        }

        private int MoveBat2Location()
        {
            int randomRoom = random.Next(1, 30);
            if (!NoOverlap(randomRoom) || batRooms.Contains(randomRoom)) randomRoom = random.Next(1, 30); //(another one) random room number
            batRooms.Add(randomRoom);
            return randomRoom;
        }
        
        //sets pits room to a random room, but first checks for overlap between other rooms
        private int GeneratePitRoomNumber()
        {
            int randomRoom = random.Next(1, 30);
            if (!NoOverlap(randomRoom)) randomRoom = random.Next(1, 30); //(another one) random room number
            pitRooms.Add(randomRoom);
            return randomRoom;
        }

        private int GenerateWumpusRoomNumber()
        {
            int randomRoom = random.Next(1, 30);

            while (!NoOverlap(randomRoom))
            {
                randomRoom = random.Next(1, 30);
            }

            return randomRoom;
        }

        public int GetWumpusLocation()
        {
            return WumpusRoom;
        }

        public void SetWumpusLocation(int newRoom)
        {
            WumpusRoom = newRoom;
        }

    }
}
