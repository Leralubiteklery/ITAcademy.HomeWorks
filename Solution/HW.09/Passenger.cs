using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09
{
    class Passenger
    {
        public string PassengerName { get; set; }
        public string FlightNumber { get; set; }

        public Passenger(string name, string flightNumber)
        {
            PassengerName = name;
            FlightNumber = flightNumber;
        }
    }
}
