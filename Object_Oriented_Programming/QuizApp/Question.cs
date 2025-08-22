using System;

public class Question {
        
    public string QuestionText { get; set; }
    public string[] Options { get; set; }
    public int CorrectIndex { get; set; }
    
    public Question(string questionText, string[] options, int correctIndex){
        QuestionText = questionText;
        Options = options;
        CorrectIndex = correctIndex;
    }
    
    public bool IsCorrect(int choice){
        return choice == CorrectIndex;
    }
    
}