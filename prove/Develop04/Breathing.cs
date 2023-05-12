public class Breathing : Activity
{
    
    public Breathing(int activityTime, string activityName) : base(activityTime, activityName)
    {

    }   

    public void displayDescription()
    {
        Console.WriteLine("This activity will help you to relax by instructing you to breath in and out solowly. Clear your mind  and focus on your breathing\n");
    }

    public void Breath(int seconds)
    {  
    // NEW LINE TO START APP  
    Console.WriteLine();
    int secondsTracker = 0;
        while (secondsTracker < seconds){

            for(int i = 0; i < 4; i++)
            {
            Console.Write($"Breath in...{i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b");
            secondsTracker += 1;
        }
            // BREATH IN PROMPT 
            Console.WriteLine($"Breath in...4");

            for(int i = 0; i < 6; i++){
            Console.Write($"Breath out...{i}");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            secondsTracker += 1; 
        }   
            // BREATH OUT PROMPT
            Console.WriteLine($"Breath out...6");
            Console.WriteLine();
        }
       
       Console.WriteLine("\n");
       // SPINNING CURSER 
       DisplayByeMessage();
       Animations.DisplaySpiner(10);
       Console.Clear(); 
       
    }

}
