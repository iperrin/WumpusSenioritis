using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  class TriviaManagement
  {
    private String[] questions;
    private String[] answers;
    private String[] triviaFacts;
    private String[] potentialSecrets;
    private int nextFact;
    private int nextQuestion;
    private int correctAnswers;

    // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file

    public TriviaManagement(String[] questions, String[] answers, String[] triviaFacts) 
    {
      // creates new TriviaManagement class
      // eventually, feed in a file location as a parameter, read in the file, and parse out questions, answers, triviaFacts
      this.questions = questions;
      this.answers = answers;
      this.triviaFacts = triviaFacts;
      this.nextFact = -1;
      this.nextQuestion = -1;
    }

    public String GetTriviaFact()
    {
      if (nextFact < triviaFacts.Length - 1)
      {
        this.nextFact++;
        return triviaFacts[nextFact];
      }
      return "No more trivia available!";
    }

    

    public Boolean TriviaTask(int numberOfQuestions, String userInput) 
    {
      // Called by GameControl whenever a TriviaTask is needed. This method will orchestrate and execute the whole Q&A process
      this.correctAnswers = 0; // resets correctAnswers for a new task to 0
      for (int i = 0; i < numberOfQuestions; i++) {
        AskQuestion();
        if (CorrectAnswer(userInput)) {
          this.correctAnswers++;
        }
      }
      // Returns boolean indicating whether the user passed the Trivia Task by tracking correctAnswers

      if (numberOfQuestions == 5 && this.correctAnswers >= 3) return true;
      if (numberOfQuestions == 3 && this.correctAnswers >= 2) return true;
      return false;

    }

    public String AskQuestion() {
      if (this.nextQuestion < this.questions.Length - 1)
      {
        this.nextQuestion++;
        return this.questions[this.nextQuestion];
      }
      return "No more trivia questions available!";
    }

    public boolean CorrectAnswer(String userInput) {
      return userInput.equals(this.answers[this.nextQuestion]);
    }

    public String QuestionAndAnswer(String userInput)
    {
      // asks question from question bank
      // compares userInput to answer
      // if incorrect, saves the answer to String[] potentialSecrets
      // removes the question/answer set from the question & answer arrays once asked
      correctAnswers++; // if correct
      return "correct"; // returns correct or wrong
      
    }


  }
  