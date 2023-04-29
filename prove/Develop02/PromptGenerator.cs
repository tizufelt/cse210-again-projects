using System;
public class PromptGenerator{
    public List<string> _questions;

    public PromptGenerator() 
    { 
        _questions = new List<string>() 
        {
            "Who was the most interesting person you interacted with today?", 
            "What was the best part of your day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?" 
        };
        
    }
    public string ChoosePrompt() 
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }
    
}