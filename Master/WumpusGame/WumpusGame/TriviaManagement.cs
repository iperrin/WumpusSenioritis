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
private String[] facts;
private int[] wrongAnswers; // keeps track of the indexes of incorrectly answered questions to access appropriate elements of secrets array
private int nextFact;
private int nextQuestion;
private int nextSecret;

// creates new trivia management object using file addresses in arguments
// ensure arguments are verbatim string literals, with @ before the quotes begin
// example: @"C:\Users\vaish\Documents\VVP\12th Grade (2017-2018)\AP Computer Science\HuntTheWumpus\TriviaQuestions.txt"
public TriviaManagement(String questionsFileAddress, String answersFileAddress, String factsFileAddress) 
{
    this.questions = System.IO.File.ReadAllLines(questionsFileAddress);
    this.answers = System.IO.File.ReadAllLines(answersFileAddress);
    this.facts = System.IO.File.ReadAllLines(factsFileAddress);
    this.wrongAnswers = new int[this.questions.Length];
    this.nextFact = -1;
    this.nextQuestion = -1;
    this.nextSecret = 0;
}

// On every turn that the user moves through a tunnel the user gets a trivia fact
public String GetNextFact()
{
    if (this.nextFact < this.facts.Length - 1)
    {
    this.nextFact++;
    return this.facts[this.nextFact];
    }
    return "No more trivia available!";
}

// Returns a single question (w/ answer choices) when required for a conflict
// Game control will call this in a for loop depending on how many questions are required for that challenge
// Purchase 2 more arrows, purchase a secret, or escape a hazard: need to get 2/3 correct
// Wumpus encounter: need to get 3/5 correct
public String GetNextQuestion()
{
    if (this.nextQuestion < this.questions.Length - 1)
    {
    this.nextQuestion++;
    return this.questions[this.nextQuestion];
    }
    return "No more trivia questions available!";
}

// Compares user input (from Game Control) to correct answer and returns a boolean: true = correct, false = wrong
public Boolean CorrectAnswer(String userInput)
{
    if (!userInput.Equals(this.answers[this.nextQuestion]))
    {
    this.wrongAnswers[this.nextQuestion] = 1; 
    }
    return userInput.Equals(this.answers[this.nextQuestion]);
}

// Returns a String with a trivia answer that the user previously got wrong - can use as secrets
public String GetSecret()
{
    for (int i = this.nextSecret; i < this.wrongAnswers.Length; i++)
    {
    if (this.wrongAnswers[i] == 1)
    {
        this.nextSecret = i + 1;
        return this.facts[i];
    }
    }
    return "No secrets currently available!";
}

}