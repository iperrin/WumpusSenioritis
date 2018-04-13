using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Map
{
    public int currentRoom;
    public int wumpusPosition;
    public int bat1Position;
    public int bat2Position;
    public int pit1Position;
    public int pit2Position;

    public Map(){
        currentRoom = random(1,30);
        wumpusPosition = emptyRoom();
        bat1Position = emptyRoom();
        bat2Position = emptyRoom();
        pit1Position = emptyRoom();
        pit2Position = emptyRoom();
    }

    public void move(int direction)
    {
        /*
         * updates player location based on direction
         * moves wumpus and bats to spec
         */
    }

    public int checkHazards()
    {
        /*
         * return 0 for no hazard
         * return 1 for overlap with bat
         * return 2 for overlap with pit
         */
        return -1;
    }

    private int emptyRoom()
    {
        //returns int of empty room to assign location
        return -1;
    }

    private int random(int min, int max)
    {
        Random random = new Random();
        return random.Next(min, max);
    }
}
