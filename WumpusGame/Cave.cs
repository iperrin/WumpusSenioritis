using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cave
{
    // array which has all the rooms and the doors they connect to
    private int[,] doors;
    // which cave it is (1-5)
    int cave;

    public Cave()
    {

    }
    
    // method reads file
    public void load(int cave)
    {
        //loads cave number from file into current cave
        this.cave = cave;
        // accesses file's text
        string text = System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\Caves\\map"+cave+".txt");
        // creates array for all 30 rooms and 6 doors each
        doors = new int[30,6];
        // whie the line continues
        while (text.IndexOf("\r\n") != -1)
        {
            // from 
            text = text.Substring(0, text.IndexOf("\r\n")) + " " + text.Substring(text.IndexOf("\r\n") + 2);
        }
        // 
        while (text.IndexOf("  ")!=-1)
        {
             // 
            text = text.Substring(0, text.IndexOf("  ")) + text.Substring(text.IndexOf("  ") + 1);
        }
        
        text += "    ";
        // for each room
        for(int r = 0; r < 30; r++)
        {
            // for each door
            for (int c = 0; c < 6; c++)
            {
                // get each door value for each room by finding values separated by spaces
                doors[r, c] = Int32.Parse(text.Substring(0, text.IndexOf(" ")));
                text = text.Substring(text.IndexOf(" ")+1);
            }
        }

    }

    //returns room doors for the given room (parameter)
    public int[] GetDoors(int room)
    {
        // if room given is not within bounds, it is just the first one
        if (room > 30 || room < 1)
            room = 1;
        // creates array for just the single room
        int[] output = new int[6];
        // accesses doors array to fill the room
        output[0] = doors[room - 1, 5];
        for (int i = 1; i < 6; i++)
            output[i] = doors[room - 1, i-1];
        return output;
    }
    
    // checks if the door is open or not
    public Boolean checkForDoor(int door, int roomNum){
        // if it is greater than 0 (not 0 or -1), then there is a door!
        if (doors[roomNum, door] > 0){
            return true;
        } 
        return false;
    }
    
    // gets a random door from the open ones from the room given as parameter
    public int getRandomDoor(int roomNum){
        Random r = new Random();
        int door = 0;
        // when door is empty, finds another door
        while (door == 0){
            door = doors[roomNum-1,r.Next(0,6)];
        }
        // when door != 0, returns the number
        return door;
    }
    
    // use this method to input number of steps and the current room you're in and output is a new room you can be in w/ number of steps
    public int goToNewRoom(int numSteps, int roomNum){
        int currentRoom = roomNum;
        // for every step, goes to new door until all steps are used
        for (int i = 0; i < numSteps; i++){
            currentRoom = getRandomDoor(currentRoom);
        }
        return currentRoom;
    }

    
}
    
