public class Reflecting : Activity{

    private List<string> _prompts = new List<string> 
    {
            "Who was the most interesting person you interacted with today?", 
            "What was the best part of your day?", 
            "How did I see the hand of the Lord in my life today?", 
            "What was the strongest emotion you felt today?",
            "If you had one thing you could do over today, what would it be?"
    };

   
    public Reflecting(int activityTime, string activityName) : base( activityTime, activityName){
        
    }

     public void displayDescription(){
        Console.WriteLine("This activity will help you focus on the good in your life and heklp you draw closer to and invite the spirit.");
    }

    public string SelectPrompt(){
         Random randomGenerator = new Random();
         int promptIndex = randomGenerator.Next(1,_prompts.Count); 
         string selectedPrompt = _prompts[promptIndex];
         return selectedPrompt;
    }

    public void reflect(int seconds){
        Console.WriteLine("Consider the following Prompt: \n");
        Console.WriteLine(SelectPrompt());
        Console.WriteLine("When you have soemthing in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now reflect on each of the following questions as they related to this experience.");
        
        for(int i = 0; i <= 4; i++){
            Console.Write($"You may begin in: {i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }

        Console.Clear();
        int questionDuration = seconds/2;
        Console.Write("Was their a scripture or spritual thought you had?");
        Animations.DisplaySpiner(questionDuration);
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("How did this experience invite the Holy Ghost?");
        Animations.DisplaySpiner(questionDuration);
        Console.WriteLine();
        Console.WriteLine();
        DisplayByeMessage();
        Animations.DisplaySpiner(10);
    }

  

}