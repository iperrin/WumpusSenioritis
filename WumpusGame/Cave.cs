using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cave
{
    private int[,] doors;
    int cave;

    public Cave()
    {

    }

    public void load(int cave)
    {
        //loads cave number from file into current cave
        this.cave = cave;
        string text = System.IO.File.ReadAllText(Environment.CurrentDirectory + "\\Caves\\map"+cave+".txt");

        doors = new int[30,6];

        while (text.IndexOf("\r\n") != -1)
        {
            text = text.Substring(0, text.IndexOf("\r\n")) + " " + text.Substring(text.IndexOf("\r\n") + 2);
        }

        while (text.IndexOf("  ")!=-1)
        {
            text = text.Substring(0, text.IndexOf("  ")) + text.Substring(text.IndexOf("  ") + 1);
        }

        text += "    ";

        for(int r = 0; r<30; r++)
        {
            for (int c = 0; c < 6; c++)
            {
                doors[r, c] = Int32.Parse(text.Substring(0, text.IndexOf(" ")));
                text = text.Substring(text.IndexOf(" ")+1);
            }
        }

    }

    //returns room doors
    public int[] GetDoors(int room)
    {
        int[] output = new int[6];

        output[0] = doors[room - 1, 5];

        for (int i = 1; i < 6; i++)
            output[i] = doors[room - 1, i-1];
        return output;
    }
    
    public Boolean checkForDoor(int door, int roomNum){
        if (doors[roomNum, door] > 0){
            return true;
        } 
        return false;
    }
    
    // gets a random door from the open ones
    public int getRandomDoor(int roomNum){
        Boolean checker = false;
        Random r = new Random();
        int door = 0;
        while (checker != true){
            door = r.Next(1,7);
            checker = checkForDoor(roomNum, door);
        }
        return door;
    }
    
    // use this method to input number of steps and the current room you're in and output is a new room you can be in w/ number of steps
    public int goToNewRoom(int numSteps, int roomNum){
        int currentRoom = roomNum;
        for (int i = 0; i < numSteps; i++){
            currentRoom = getRandomDoor(currentRoom);
        }
        return currentRoom;
    }

    
}
    
