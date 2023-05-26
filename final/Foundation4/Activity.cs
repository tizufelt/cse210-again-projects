 public abstract class Activity
    {
        public DateTime Date { get; set; }
        public int Minutes { get; set; }

        public Activity(DateTime date, int minutes)
        {
            Date = date;
            Minutes = minutes;
        }

        // distance unit is miles
        public abstract double GetDistance();

        public virtual double GetSpeed()
        {
            // miles per hour
            return GetDistance() / (Minutes / 60.0);
        }

        public virtual double GetPace()
        {
            // minutes per mile
            return Minutes / GetDistance();
        }

        public abstract string GetSummary();
    }