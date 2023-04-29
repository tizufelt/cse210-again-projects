using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal(new PromptGenerator());
        int menuUserinput = 0;

        List<string> menu = new List<string>
        {
        "Please select one of the following choices:",
        "1. Write",
        "2. Display",
        "3. Load",
        "4. Save",
        "5. Quit",
        "What would you like to do?"
    };

     while (menuUserinput != 5)
        {
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }

            try
            {
                menuUserinput = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            switch (menuUserinput)
            {
                case 1:
                    journal.CreateJournalEntry();
                    break;

                case 2:
                    journal.DisplayJournalEntries();
                    break;

                case 3:
                    journal.LoadFromCsv();
                    break;

                case 4:
                    journal.SaveToCsv();
                    break;

                case 5:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
    

   
