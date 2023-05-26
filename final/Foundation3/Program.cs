using System;
using System.Collections.Generic;
using EventPlanning;

namespace EventPlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of activities
            List<Event> events = new List<Event>();

            // Add some activities to the list
            DateTime schedule = new DateTime(2023, 07, 06, 12, 00, 00);
            Address location = new Address("1600 Pennsylvania Avenue,", "Washington, D.C.", "USA", "37188");
            events.Add(new Lecture("My Favorite Spy Glass", "Lecture Description", schedule, schedule, location, "Sherlock Holmes", 500));

            events.Add(new Outdoor("The Great Outdoors", "Fun in the OUTDOORS", schedule, schedule, location, "Expect rain"));

            events.Add(new Reception("Reception Party", "Don't miss out", schedule, schedule, location, "reception@fake.email.com"));

            // Display the summary of each activity
            foreach (Event e in events)
            {
                Console.WriteLine($"Standard Details\n----------------\n{e.GetStandardDetails()}\n");
                Console.WriteLine($"Full Details\n------------\n{e.GetFullDetails()}\n");
                Console.WriteLine($"Short Description\n-----------------\n{e.GetShortDescription()}\n");
                Console.WriteLine("\n");
            }
        }
    }
}