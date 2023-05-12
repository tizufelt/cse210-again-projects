using System;
using System.Threading;


class Program
{ 
    static void Main(string[] args)
    {   
        static void DisplayMenu(){
        Console.Clear();    
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select from the menu above to start your mindfulness journey: ");
        }
    
    //Start
    Console.Clear();
    Console.WriteLine("Welcome to the mindfulness program. This program has 3 activities to help you ponder and reflect:");
    
        int runProgram = 0;
        while(runProgram != 4){
            DisplayMenu();
            // Read user input 
            string userSelection = Console.ReadLine();
            //parse input to int
            int activity = Int16.Parse(userSelection);


            switch(activity)
            {
            //Breathing activity
            case 1:
                Console.Clear();
                Breathing breathing = new Breathing(0,"Breathing");
                breathing.WelcomMesage();
                breathing.displayDescription();
                // store the duration in seconds of the activty 
                int getDuration = breathing.getDuration();
                breathing.pauseProgram(3);
                breathing.Breath(getDuration);
                
            break;

            //Reflecting activity
            case 2:
                Console.Clear();
                Reflecting reflecting = new Reflecting(0,"Reflecting");
                reflecting.WelcomMesage();
                reflecting.displayDescription();
                // store the duration in seconds of the activty 
                getDuration = reflecting.getDuration();
                reflecting.pauseProgram(3);
                reflecting.reflect(getDuration);
            break;
            
            //Reflecting Listing
            case 3:
                Console.Clear();
                Listing Listing = new Listing(0,"Listing");
                Listing.WelcomMesage();
                Listing.displayDescription();
                // store the duration in seconds of the activty 
                getDuration = Listing.getDuration();
                Listing.pauseProgram(3);
                Listing.listing(getDuration);
            break;

            //Stop the  program
            case 4:
                runProgram = 4;
            break;
            } 
        }

    }
}