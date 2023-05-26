using System;

namespace EventPlanning
{
    // Class to represent an address
    public class Address
    {
        private string street;
        private string city;
        private string state;
        private string zipCode;

        // Constructor to initialize the address
        public Address(string street, string city, string state, string zipCode)
        {
            this.street = street;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
        }

        // Method to return a string representation of the address
        public string GetAddressString()
        {
            return $"{street}, {city}, {state} {zipCode}";
        }
    }
}