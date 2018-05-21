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

        for (int i = 0; i < 6; i++)
            output[i] = doors[room - 1, i];

        return output;
    }
}
    