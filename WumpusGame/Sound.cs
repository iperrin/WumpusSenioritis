using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

class Sound 
{
    private String[] soundFiles;

    public Sound()
    {
        Random temp = new Random();
        int num = temp.Next(1, 3);
        soundFiles = new string[8];
        // array of sound files

        soundFiles[0] = "playOnMove";
        soundFiles[1] = "playOnShoot";
        soundFiles[2] = "playOnWumpusMove";
        soundFiles[3] = "playOnTriviaQuestion";
        soundFiles[4] = "playOnBatNearby";
        soundFiles[5] = "playOnPitNearby";
        soundFiles[6] = "playOnWin";
        soundFiles[7] = "playOnLose";

        for (int i = 0; i<soundFiles.Length; i++)
            soundFiles[i]+=(num+".wav");
    }

    // plays sound using SoundPlayer class as part of Media library 
    public void playSound(String filename){ 
        SoundPlayer sound = new SoundPlayer(Environment.CurrentDirectory + "\\Sound1\\" + filename);  
        sound.Play();  
    }

    // each of these methods calls on playSound method to play the particular sound 
    
    public void playOnMove()
    {
       playSound(soundFiles[0]);
    }

    public void playOnShoot()
    {
        playSound(soundFiles[1]);
    }

    public void playOnWumpusMove()
    {
        playSound(soundFiles[2]);
    }

    public void playOnTriviaQuestion()
    {
        playSound(soundFiles[3]);
    }

    public void playOnBatNearby()
    {
        playSound(soundFiles[4]);
    }

    public void playOnPitNearby()
    {
        playSound(soundFiles[5]);
    }

    public void playOnWin()
    {
        playSound(soundFiles[6]);
    }

    public void playOnLose()
    {
        playSound(soundFiles[7]);
    }
}
