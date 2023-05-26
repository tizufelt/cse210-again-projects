using System;

namespace FitnessCenter
{
    class Swimming : Activity
    {
        private int laps;

        public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
        {
            this.laps = laps;
        }

        // Override the GetDistanceMiles method to calculate distance for swimming
        public override double GetDistance()
        {
            // Each lap is 50 meters
            double distanceKm = laps * 50.0 / 1000.0;
            double distanceMiles = distanceKm * 0.62;
            return distanceMiles;
        }

        // Override the GetSummary method to produce a summary string for swimming
        public override string GetSummary()
        {
            return $"{Date.ToString("dd MMM yyyy")} Swimming ({Minutes} min)- Distance {GetDistance():F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        }
    }
}
