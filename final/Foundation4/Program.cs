using System;
using System.Collections.Generic;
using FitnessCenter;

namespace FitnessCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create list of activities
            List<Activity> activities = new List<Activity>();

            // Add some activities to the list
            activities.Add(new Running(new DateTime(2023, 02, 3), 24, 6.2));
            activities.Add(new Cycling(new DateTime(2023, 03, 24), 320, 72));
            activities.Add(new Swimming(new DateTime(2023, 05, 7), 27, 10));

            // Display the summary of each activity
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}