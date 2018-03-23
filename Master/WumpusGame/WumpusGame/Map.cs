using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Map{
    public void CurrentCave(){
        //Calls the Cave object
    }

    public void NumberOfCaves(){
        //Tracks the number of caves passed.
        //Calls the Graphical Interface.
    }

    public Boolean CheckBat(Cave currentRoom){
        foreach (int creature in currentRoom.getCreatureNumbers()){
            if (Cave.caveSystem[creature].getRoomStatus() == 1){
                return true;
            }
        }
        return false;
        //Haven't joined code yet so i just assumed some names for class and method names from cave.
    }

    public Boolean CheckWumpus(Cave currentRoom)
    {
        foreach (int creature in currentRoom.getCreatureNumbers())
        {
            if (Cave.caveSystem[creature].hasWumpus() == true)
            {
                return true;
            }
        }
        return false;
        //Haven't joined code yet so i just assumed some names for class and method names from cave.
    }

    public void HazardLocation(){
        //Tracks the location of the Hazards.
    }

    public void HazardInteraction(){
        //Calls the Trivia object.
    }

    public void WumpusStuff(){
        //Calls the Wumpus object probably for the Wumpus's behavior.
        //Tracks the location of the Wumpus.
    }

    public void PlayerLocation(){
        //Calls the Player object.
        //Tracks the location of the Player.
    }

    public void MovePlayer(){
        //Moves the player.
        //Calls the Game Object and Cave to find the location to send the player.
    }

    public void ShootArrows(int location){
        //Shoots arrows at a certain location.
    }

    public String Warnings(int location){
        //Gives a warning based on the location of the player in relation to hazards or the wumpus.
        //Calls the Wumpus Object and Hazard methods.
        return null;
    }

    public String ObtainSecret(int location){
        //Gets secrets to give to the player depending on the location.
        return null;
    }
}