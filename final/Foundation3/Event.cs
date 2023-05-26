using System;

namespace EventPlanning
{
    // Abstract base class to represent an event
    public abstract class Event
    {
        private string title;
        private string description;
        private DateTime date;
        private DateTime time;
        private Address address;

        // Constructor to initialize the event
        public Event(string title, string description, DateTime date, DateTime time, Address address)
        {
            this.title = title;
            this.description = description;
            this.date = date;
            this.time = time;
            this.address = address;
        }

        // Method to return a string with the standard details of the event
        public string GetStandardDetails()
        {
            return $"Title: {title}\nDescription: {description}\nDate: {date.ToShortDateString()}\nTime: {time.ToShortTimeString()}\nAddress: {address.GetAddressString()}";
        }

        // Virtual method to return a string with the full details of the event
        public virtual string GetFullDetails()
        {
            string eventType = GetType().Name;
            return $"Event Type: {eventType}\n{GetStandardDetails()}";
        }

        // Method to return a string with the short description of the event
        public string GetShortDescription()
        {
            string eventType = GetType().Name;
            return $"Event Type: {eventType}\nTitle: {title}\nDate: {date.ToShortDateString()}";
        }
    }
}

