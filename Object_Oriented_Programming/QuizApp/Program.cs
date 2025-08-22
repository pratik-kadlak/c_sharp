using System;

public class Program {
    public static void Main(string[] args){
        Question[] questions = new Question[]{
            new Question(
                "What is the capital of Germany?", 
                new string[] {"Paris", "Berlin", "Frankfurt", "Lisbon"},
                1
            ),
            new Question(
                "What is 2 + 2?", 
                new string[] {"3", "4", "5", "6"},
                1
            ),
            new Question(
                "Which is the fastest animal?", 
                new string[] {"Cheetah", "Ostrich", "Swordfist", "Peregrine Falcon"},
                3
            )
        };
        
        Quiz myQuiz = new Quiz(questions);
        myQuiz.StartQuiz();
        Console.ReadKey();
    }
}