using System;
using System.IO;
class Program
{
    // Store all the goals
    public static List<Goal> GoalList = new List<Goal>();

    // Keep track of the score
    public static int score = 0;

    // File name variable 
    public static string filename;


    static void Main(string[] args)
    {

        static void DisplayMenu()
        {

            Console.WriteLine();
            Console.WriteLine($"You have {score} points ");
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goal");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
        }

        bool runProgram = true;
        while (runProgram != false)
        {

            DisplayMenu();
            // Main menu Option Sector 
            Console.Write("Select a choice from the menu: ");
            string userSelection = Console.ReadLine();
            int activity = Int16.Parse(userSelection);
            Console.WriteLine(" ");

            switch (activity)
            {

                case 1:
                    // Display goal option menu
                    int slection = GoalFactory.GoalMenu();
                    switch (slection)
                    {

                        case 1:
                            GoalList.Add(GoalFactory.CreateSimple());
                            break;

                        case 2:
                            GoalList.Add(GoalFactory.CreateEternal());
                            break;

                        case 3:
                            GoalList.Add(GoalFactory.CreateCheckList());
                            break;
                    }

                    break;

                case 2:
                    int number = 1;
                    foreach (Goal goal in GoalList)
                    {
                        Console.Write($"{number}. ");
                        goal.DisplayGoal();
                        number += 1;
                    }

                    break;

                case 3:
                    Console.Write("What is the name of the file?: ");
                    filename = Console.ReadLine();
                    fileManager.SaveGoals(filename, GoalList, score);
                    break;

                case 4:
                    Console.Write("What is the name of the file?: ");
                    filename = Console.ReadLine();
                    score = fileManager.LoadGoals(filename, GoalList, score);
                    break;

                case 5:

                    Console.WriteLine("The Goals are: ");
                    number = 1;
                    // Numerate the goal 
                    foreach (Goal goal in GoalList)
                    {
                        Console.Write($"{number}. ");
                        goal.DisplayGoal();
                        number += 1;
                    }
                    Console.Write("Which Goal did you accomplish? ");
                    int selectedGoal = int.Parse(Console.ReadLine());

                    number = 1;
                    foreach (Goal goal in GoalList)
                    {
                        // Compare the number of the goal with the user selection    
                        if (selectedGoal == number)
                        {
                            int earnedPorints = goal.completeGoal();
                            score += earnedPorints;
                            Console.WriteLine($"*****************************************");
                            Console.WriteLine($"Congratulations you earned {earnedPorints}");
                        }
                        number += 1;
                    }

                    break;

                case 6:
                    runProgram = false;
                    break;
            }

        }

    }

}