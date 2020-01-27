using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09
{
    class Passenger
    {
        public string PassengerName { get; set; }
        public string FlightNumber { get; set; }
        public bool HasProhibitedStaff { get; set; }
        public bool HasPassport { get; set; }
        public bool HasVisa { get; set; }

        public Passenger() { }
        public Passenger(string name, string flightNumber, bool hasProhibitedStaff, bool hasPassport, bool hasVisa)
        {
            PassengerName = name;
            FlightNumber = flightNumber;
            HasProhibitedStaff = hasProhibitedStaff;
            HasPassport = hasPassport;
            HasVisa = hasVisa;
        }

        

    }
}
