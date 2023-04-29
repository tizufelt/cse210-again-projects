using System;

class Program
{
    static public void Main(String[] args)
    {
        
        Journal journal1 = new Journal();
        ReadandLoad FLR = new ReadandLoad();
        
        string userInput = "";

        while (userInput !="5")
        {
            Console.WriteLine("Welcome to the journal program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1.Write");
            Console.WriteLine("2.Display");
            Console.WriteLine("3.Load");
            Console.WriteLine("4.Save");
            Console.WriteLine("5.Quit");
            Console.Write("What would you like to do? ");

            userInput = Console.ReadLine() ?? String.Empty;

            if (userInput == "1")
            {
                Entry1 write = new Entry1();
                write.Writeprompt();
                journal1._entrylist.Add(write);
            }
            else if (userInput == "2")
            {
                journal1.Display();
            }
            else if (userInput == "3")
            {
                List<Entry1>entrylist = FLR.readFile();
                journal1.Loadentry(entrylist);
                //Console.WriteLine(journal1._entrylist);
                journal1.Display();
            }
            else if (userInput == "4")
            {
                FLR.writefile(journal1.getwrite());
                Console.WriteLine("Saved!");
            }

        }
    } 
        
}

      


    