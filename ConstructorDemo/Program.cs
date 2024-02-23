using System;
class Question
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public char correctAnswerLetter;
    private static char defaultCorrectAnswerLetter = 'X';
    public Question()
    {
        questionText = null;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = Question.defaultCorrectAnswerLetter;
    }
    public Question(string questionText)
    {
        this.questionText = questionText;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = Question.defaultCorrectAnswerLetter;
    }


    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {
        this.questionText = questionText;
        this.optionA = optionA;
        this.optionB = optionB;
        this.optionC = optionC;
        this.optionD = optionD;
        if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D')
        { //validating correctAnswerLetter parameter
            this.correctAnswerLetter = correctAnswerLetter;
        }
        else
        {
            this.correctAnswerLetter = Question.defaultCorrectAnswerLetter;
            //defaultCorrectAnswerLetter is a static field
        }
    }


    public bool AreOptionsValid()
    {
        if (optionA != null && optionB != null || optionC != null && optionD != null ||
            optionA != null && optionC != null || optionA != null && optionD != null || optionC != null && optionB != null
            || optionD != null && optionB != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
class Program
{
    static void Main()
    {
        Question question1 = new Question();
        Question question2 = new Question("Question: What is the capital of the USA?");
        Question question4 = new Question
        {
            questionText = "Question: What is the capital of the USA?",
            optionA = "Option A: London",
            optionB = "Option B: New York",
            optionC = "Option C: Washington, D.C.",
            optionD = "Option D: San Diego"
        };
        Question question3 = new Question("Question: What is the capital of the USA?", "Option A: London",
            "Option B: New York", "Option C: Washington, D.C.", "Option D: San Diego", 'C');

    }
}