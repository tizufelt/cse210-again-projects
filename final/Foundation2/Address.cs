using System;

namespace ProductOrderingSystem
{
    public class Address
    {
        // Private member variables for the address fields
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }

        // Constructor to initialize the address fields
        public Address(string streetAddress, string city, string stateOrProvince, string country)
        {
            StreetAddress = streetAddress;
            City = city;
            StateOrProvince = stateOrProvince;
            Country = country;
        }

        // Method to check if the address is in the USA
        public bool IsInUSA()
        {
            return Country.ToLower() == "usa" || Country.ToLower() == "united states" || Country.ToLower() == "united states of america";
        }

        // Method to return the full address as a string
        public override string ToString()
        {
            return StreetAddress + "\n" + City + ", " + StateOrProvince + "\n" + Country;
        }
    }
}