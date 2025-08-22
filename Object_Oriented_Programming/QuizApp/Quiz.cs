using System;

public class Quiz {
    
    public Question[] questions;
    public int Score{ get; set; }
    
    public Quiz(Question[] questions){
        this.questions = questions;
        Score = 0;
    }
    
    private void DisplayQuestion(Question question){
        Console.WriteLine(" ================================================================= ");
        Console.WriteLine("|                        Question                                 |");
        Console.WriteLine(" ================================================================= ");
        Console.WriteLine(question.QuestionText);
        
        for(int i = 0; i < question.Options.Length; i++){
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(i+1 + ". ");
            Console.ResetColor();
            Console.WriteLine(question.Options[i]);
        }
    }
    
    private int GetUserInput(){
        Console.Write("Your Option Number: ");
        string input = Console.ReadLine();
        int choice = 0;
        while(!int.TryParse(input, out choice) || choice < 1 || choice > 4){
            Console.WriteLine("Invalid Choice! Please Enter a number between 1 and 4.");
            input = Console.ReadLine();
        }
        return choice-1; // 0-based indexing
    }
    
    private void DisplayResult(){
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine(" ================================================================= ");
        Console.WriteLine("|                         Results                                 |");
        Console.WriteLine(" ================================================================= ");
        Console.ResetColor();
        
        double percentage = Score*1.0 / questions.Length; 
        
        if(percentage > 0.8) {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Excellent!!!");
        } else if (percentage > 0.6) {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Good!!");
        } else {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Keep Practicing!");
        }
        Console.WriteLine($"Your Score Was {Score}/{questions.Length}");
    }
    
    public void StartQuiz(){
        Console.WriteLine("Welcome to the Quiz!");
        int questionNo = 1;
        
        foreach(Question question in questions){
            Console.WriteLine($"Question {questionNo++}: ");
            DisplayQuestion(question);
            int userChoice = GetUserInput();
            if(question.IsCorrect(userChoice)){
                Console.WriteLine("Hurray! Correct");
                Score++;
            } else {
                Console.WriteLine("Oh no! Incorrect");
                Console.WriteLine($"The correct answer was: {question.Options[question.CorrectIndex]}");
            } 
        }
        Console.WriteLine("The Quiz is Over.");
        DisplayResult();
    }  
}