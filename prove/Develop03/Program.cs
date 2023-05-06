using System;
namespace CSE210_Projects;


class Program
{
    static void Main(string[] args)
    {
        Reference scriptureReference = new Reference("Psalm", "72", "6");
        Scripture scripture = new Scripture(scriptureReference, "He shall come down like rain upon the mown grass, as showers that water the earth.");

        string userInput = "";

        while (userInput != "quit" && scripture.HasWordsLeft() == true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine();
            
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            userInput = Console.ReadLine();
            scripture.RemoveWords();
        }
        

        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("I hope you got it memorized");
        }
        
    }

