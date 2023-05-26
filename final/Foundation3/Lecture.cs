using System;

namespace EventPlanning
{
    // Class to represent a lecture event
    public class Lecture : Event
    {
        private string speakerName;
        private int capacity;

        // Constructor to initialize the lecture
        public Lecture(string title, string description, DateTime date, DateTime time, Address address, string speakerName, int capacity) : base(title, description, date, time, address)
        {
            this.speakerName = speakerName;
            this.capacity = capacity;
        }

        // Method to return a string with the full details of the lecture
        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nSpeaker: {speakerName}\nCapacity: {capacity}";
        }
    }
}