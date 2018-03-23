using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HighScore
{

    private struct HighScoreInfo
    {
        public string name;
        public int score;
        public int turns;
        public int gold;
        public int arrows;
        public int cave;
    };
    private ArrayList Record;
    private String FileLocation;

    public HighScore(String StoredFiles)
    {
        Record = new ArrayList();
        FileLocation = StoredFiles;
    }

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