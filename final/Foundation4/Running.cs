using System;

namespace FitnessCenter
{
    class Running : Activity
    {
        // distance in miles
        private double distance;

        // Define a constructor for the "Running" class that takes in the date, time, and distance of the event
        public Running(DateTime date, int minutes, double miles) : base(date, minutes)
        {
            this.distance = miles;
        }

        // Override the "Sport" class's abstract method "GetDistanceMiles" to return the distance of the running event
        public override double GetDistance()
        {
            return this.distance;
        }

        // Override the "Sport" class's virtual method "GetSummary" to return a summary of the running event
        public override string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} Running ({Minutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}