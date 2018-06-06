using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

class Sound 
{
    private String[,] soundFiles;
    int soundNum;

    // constructor takes the theme of the sound (1 or 2) as a parameter; theme is decided in GameControl
    public Sound(int num)
    {
        // theme num
        soundNum = num;
        // array of sound files
        soundFiles = 
        {
            { "playOnMove1.wav", "playOnShoot1.wav", "playOnWumpusMove1.wav", "playOnTriviaQuestion1.wav", "playOnBatNearby1.wav", "playOnPitNearby1.wav", "playOnWin1.wav", "playOnLose1.wav" }
            { "playOnMove2.wav", "playOnShoot2.wav", "playOnWumpusMove2.wav", "playOnTriviaQuestion2.wav", "playOnBatNearby2.wav", "playOnPitNearby2.wav", "playOnWin2.wav", "playOnLose2.wav" }
        };
    }

    // plays sound using SoundPlayer class as part of Media library 
    public String playSound(String filename){ 
        SoundPlayer sound = new SoundPlayer(Environment.CurrentDirectory + "\\Sound1\\" + filename);  
        sound.Play();  
    }

    // each of these methods calls on playSound method to play the particular sound 
    
    public String playOnMove()
    {
       playSound(soundFiles[num-1, 0]);
    }

    public String playOnShoot()
    {
        playSound(soundFiles[num-1, 1]);
    }

    public String playOnWumpusMove()
    {
        playSound(soundFiles[num-1, 2]);
    }

    public String playOnTriviaQuestion()
    {
        playSound(soundFiles[num-1, 3]);
    }

    public String playOnBatNearby()
    {
        playSound(soundFiles[num-1, 4]);
    }

    public String playOnPitNearby()
    {
        playSound(soundFiles[num-1, 5]);
    }

    public String playOnWin()
    {
        playSound(soundFiles[num-1, 6]);
    }

    public String playOnLose()
    {
        playSound(soundFiles[num-1, 7]);
    }
}
