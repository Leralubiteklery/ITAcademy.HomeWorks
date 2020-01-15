using System;

namespace HW._09
{
    class Program
    {
        public void Main(string[] args)
        {
            WelcomePassenger();

        }

        public void WelcomePassenger()
        {
            const string AirportName = "Domodedovo";

            Console.WriteLine($"Welcome to {AirportName} airport! Please, introduce yourself.");

            Passenger passenger = new Passenger(Console.ReadLine(), Console.ReadLine());

            Console.WriteLine($"Hello, {passenger.PassengerName}! Please, enter your flight number");
            Console.ReadLine();
            Console.WriteLine("Please, proceed to check-in counter");
        }
    }
}
