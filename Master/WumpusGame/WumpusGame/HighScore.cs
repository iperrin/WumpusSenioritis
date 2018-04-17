using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HighScore
{

    public struct PlayerInfo
    {
        public string name;
        public int turns;
        public int gold;
        public int arrows;
        public int cave;
    }

    private static String FileLocation = "tempLocation";

    public ArrayList GetHighScore()
    {
        return Record;
    }
    public void ReplaceScore()
    {
        //checks if score is good enough;
    }
    public void WriteNewScores(String StoredFiles)
    {
        //write to file eventually
    }
}