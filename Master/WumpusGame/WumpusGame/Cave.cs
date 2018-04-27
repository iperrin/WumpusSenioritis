using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cave
{
    private int numRooms;
    private int roomEdges;
    int cave;

    public Cave(int startCave)//(int size, int numEdges)
    {
        cave = startCave;
        //numRooms = size;
        //roomEdges = numEdges;
        readFromFile("filename.txt");
    }

    public void load(int cave)
    {
        //loads cave number from file into current cave
        this.cave = cave;
    }

    public void readFromFile(String filename)
    {
        try
        {
            //String line = sr.ReadLine();
            //String[] lineData = line.Split(' ');
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR: File cannot be read.");
            Console.WriteLine(e.Message);
        }

    }

    // retrieving map information from map
    public int mapInfo()
    {
        // retrieve information from map
        return 0;
    }

    // storing connectivity info in an array
    public int[] connectivityInfo(int rooms)
    {
        int[] numRoomsConnected = new int[rooms];
        return numRoomsConnected;
    }

    // accesses methods/attributes in Player 
    public void accessPlayer()
    {

    }

    // accesses methods/attributes in Map Object
    public void accessMap()
    {

    }

    // accesses methods/attributes in Graphic Userinterface Object
    public void accessUserInterface()
    {

    }

    // accesses methods/attributes in Game Control Object
    public void accessGameControl()
    {

    }

    // gets information about number of connected rooms
    public int numConnected()
    {
        return 0;
    }

    //returns room doors
    public int[] GetDoors(int room)
    {
        //example: {6,27,0,0,3,2}
        //top door goes to room 6
        //top right door goes to room 27
        //there is no bottom right or bottom door
        //bottom left door goes to room 3
        //top left door goes to room 2

        //example return
        int[] output = { 6, 27, 0, 0, 3, 2 };
        return output;

    }
}
    