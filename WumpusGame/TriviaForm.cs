using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WumpusTest
{
  public partial class TriviaForm : Form
  {
    private TriviaManagement _TriviaManagement;
  
    public TriviaForm()
    {
      InitializeComponent();
    }


    private void constructor(object sender, EventArgs e)
    {
      String questions = Environment.CurrentDirectory+@"\TriviaQuestions.txt";
      String answers = Environment.CurrentDirectory+@"\TriviaAnswers.txt";
      String facts = Environment.CurrentDirectory+@"\TriviaFacts.txt";
      _TriviaManagement = new TriviaManagement();
      string word = " ";
      string[] a = { word };
      //System.IO.File.WriteAllLines(@"C:\Users\vaish\Documents\VVP\12th Grade (2017-2018)\AP Computer Science\HuntTheWumpus\TriviaUnitTests.txt", a);
    }

    private void button1_Click_1(object sender, EventArgs e)
    {

      /*
      using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\vaish\Documents\VVP\12th Grade (2017-2018)\AP Computer Science\HuntTheWumpus\TriviaUnitTests.txt", true))
      {
        file.WriteLine(_TriviaManagement.GetNextFact());
      }
      */

      label3.Text = _TriviaManagement.GetNextFact();



    }

    private void button2_Click(object sender, EventArgs e)
    {
      /*
      using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\vaish\Documents\VVP\12th Grade (2017-2018)\AP Computer Science\HuntTheWumpus\TriviaUnitTests.txt", true))
      {
        file.WriteLine(_TriviaManagement.GetNextQuestion());
      }
      */
      label4.Text = _TriviaManagement.GetNextQuestion();

    }

    private void button3_Click(object sender, EventArgs e)
    {
      /*
      using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\vaish\Documents\VVP\12th Grade (2017-2018)\AP Computer Science\HuntTheWumpus\TriviaUnitTests.txt", true))
      {
        file.WriteLine(_TriviaManagement.CorrectAnswer(textBox1.Text));
      }
      */
      label1.Text = _TriviaManagement.CorrectAnswer(textBox1.Text).ToString();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button4_Click(object sender, EventArgs e)
    {
      /*using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\vaish\Documents\VVP\12th Grade (2017-2018)\AP Computer Science\HuntTheWumpus\TriviaUnitTests.txt", true))
      {
        file.WriteLine(_TriviaManagement.GetSecret());
        file.WriteLine(_TriviaManagement.debugWrongAnswers());
      }
      */
      label5.Text = _TriviaManagement.GetSecret();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      _TriviaManagement.Reset();
    }

    private void button2_Click_1(object sender, EventArgs e)
    {
      label7.Text = _TriviaManagement.IsWrongAnswersEmpty().ToString();
    }
  }
}
