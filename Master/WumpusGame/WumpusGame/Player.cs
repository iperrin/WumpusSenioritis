using System;

class Player{
    int arrows = 3;
    int goldCoins;
    int playerTurns;
    int endingScore;
    int currentRoom;

    public void PlayerMove(int position){
        //Moves the player to a certain position.
        //Method is called by the Game Control Object (?) when there is a command for you to move the player.
    }

    //increase arrow count by 2
    public void PurchaseArrow()
    {
        arrows += 2;
    }

    public void ShootArrow(int targetRoom){
        /*
        arrows--;
        if (GameControl.checkHit(targetRoom)){
            GameControl.killWumpus();
            GameControl.endScreen();
        }
        else{
            if (arrows <= 0){
                GameControl.endScreen();
            }
            GameControl.moveWumpus();
        }
        //Haven't joined code yet so i just assumed some names for class and method names from cave.
        */
    }

    public int PlayerGold(){
        //Tracks the amount of gold that the player currently has.
        return 0;
    }

    public String PlayerInventory(){
        //Prints out the Player's inventory.
        //Calls the Graphical Interface.
        //return PlayerArrows() + " " + PlayerGold() + " ";
        return "";
    }

    public int NumberOfTurns(){
        //Tracks the number of turns that the player currently has gone through.
        return 0;
    }

    public int FinalScore(){
        //Tracks the gold, turns, and arrows and figures out the final score.
        return 0;
    }
}
