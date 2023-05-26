using System;

namespace EventPlanning
{
    // Class to represent a reception event
    public class Reception : Event
    {
        private string rsvpEmail;

        // Constructor to initialize the reception
        public Reception(string title, string description, DateTime date, DateTime time, Address address, string rsvpEmail) : base(title, description, date, time, address)
        {
            this.rsvpEmail = rsvpEmail;
        }

        // Method to return a string with the full details of the reception
        public override string GetFullDetails()
        {
            return $"{base.GetFullDetails()}\nRSVP Email: {rsvpEmail}";
        }
    }
}