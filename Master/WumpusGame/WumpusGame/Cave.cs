using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cave
{
    private int numRooms;
    private int roomEdges;

    public Cave(int size, int numEdges)
    {
        numRooms = size;
        roomEdges = numEdges;
        readFromFile("filename.txt");
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
}
    