using System;

namespace HW._09
{
    class Program
    {
        static void Main(string[] args)
        {
            const string AirportName = "Domodedovo";

            Console.WriteLine($"Welcome to {AirportName} airport! Please, introduce yourself.");

            Passenger passenger = new Passenger(Console.ReadLine(), Console.ReadLine(), false, true, true);

            Console.WriteLine($"Hello, {passenger.PassengerName}! Please, enter your flight number");
            Console.ReadLine();
            Console.WriteLine("Please, proceed to check-in counter. \nPress any key to continue.");
            Console.ReadLine();

            CheckIn checkIn = new CheckIn();
          
            checkIn.RegisterForTheFlight();

            Security security = new Security();

            security.CheckForProhibitedStaff(passenger.HasProhibitedStaff);

            Console.WriteLine("Please, proceed to passport control. \nPress any key to continue.");
            Console.ReadLine();
            Console.WriteLine(".....................................................");

            PassportControl passportControl = new PassportControl();

            passportControl.CheckPassport(passenger.HasPassport, passenger.HasVisa);
        }
    }
}
