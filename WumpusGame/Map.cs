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
        private int bat1Room; //room for bat 1
        private int bat2Room;//room for bat 2
        private int pit1Room;//room for pit 1
        private int pit2Room;//room for pit 2

        public int WumpusRoom;
        Random random = new Random();
        public int currentRoom;
        
        //sets room numbers for wumpus, pits, bats, and player.
        public Map()
        {
            currentRoom = 1;
            bat1Room = GenerateBatRoomNumber();
            bat2Room = GenerateBatRoomNumber();
            pit1Room = GeneratePitRoomNumber();
            pit2Room = GeneratePitRoomNumber();
            WumpusRoom = GenerateWumpusRoomNumber();
        }
        
        //resets rooms for new game
        public void Reset()
        {
            currentRoom = 1;
            bat1Room = GenerateBatRoomNumber();
            bat2Room = GenerateBatRoomNumber();
            pit1Room = GeneratePitRoomNumber();
            pit2Room = GeneratePitRoomNumber();
            WumpusRoom = GenerateWumpusRoomNumber();
        }
        
        //getter and setter for player rooms
        public int GetPlayerRoom()
        {
            return currentRoom;
        }

        public void SetPlayerRoom(int newRoom)
        {
            currentRoom = newRoom; 
        }
        
        //checks for overlap of pits and bats in the rooms. Only returns true of there is no overlap of hazards in the room
        public Boolean NoOverlap(int room)
        {
            if (batRooms.Contains(room) && pitRooms.Contains(room)) return false; 
            return true;
        }
        
        //sets bats room to a random room, but first checks for overlap between other rooms
        private int GenerateBatRoomNumber()
        {
            int randomRoom = random.Next(1, 30);
            if (!NoOverlap(randomRoom)) randomRoom = random.Next(1,30); //checks overlap, and if there is then it randomizes again
            batRooms.Add(randomRoom);
            return randomRoom;
        }
        
        //next 4 methods gets/sets the bats location
        private int MoveBat1Location(int bat)
        {
            int randomRoom = random.Next(1, 30);
            if (!NoOverlap(randomRoom) || batRooms.Contains(randomRoom)) randomRoom = random.Next(1, 30); //checks overlap, and if there is then it randomizes again
            batRooms.Add(randomRoom);
            return randomRoom;
        }
        
        public int getBat1Location(){
            return bat1Room;
        }

        private int MoveBat2Location()
        {
            int randomRoom = random.Next(1, 30);
            if (!NoOverlap(randomRoom) || batRooms.Contains(randomRoom)) randomRoom = random.Next(1, 30); //checks overlap, and if there is then it randomizes again
            batRooms.Add(randomRoom);
            return randomRoom;
        }
        
        public int getBat2Location(){
            return bat2Room;
        }
        
        //sets pits room to a random room, but first checks for overlap between other rooms
        private int GeneratePitRoomNumber()
        {
            int randomRoom = random.Next(1, 30);
            if (!NoOverlap(randomRoom)) randomRoom = random.Next(1, 30); //checks overlap, and if there is then it randomizes again
            pitRooms.Add(randomRoom);
            return randomRoom;
        }
        
        //next 2 methods sets the bats location
        public int getPit1Location(){
            return pit1Room;
        }
        
         public int getPit2Location(){
            return pit2Room;
        }
        
        //generates a random room where the wumpus starts, but checks if there is overlap of hazards in the room.
        private int GenerateWumpusRoomNumber()
        {
            int randomRoom = random.Next(1, 30);

            while (!NoOverlap(randomRoom)) //checks overlap, and if there is then it randomizes again
            {
                randomRoom = random.Next(1, 30);
            }

            return randomRoom;
        }
        
        //getter and setter for the wumpus location
        public int GetWumpusLocation()
        {
            return WumpusRoom;
        }

        public void SetWumpusLocation(int newRoom)
        {
            WumpusRoom = newRoom;
        }
        
        //setters for bat locations
        public void setBat1Location(int newRoom)
        {
            bat1Room = newRoom;
        }

        public void setBat2Location(int newRoom)
        {
            bat2Room = newRoom;
        }

    }
}
