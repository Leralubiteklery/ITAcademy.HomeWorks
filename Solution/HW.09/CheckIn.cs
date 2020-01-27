using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09
{
    class CheckIn
    {
        public void RegisterForTheFlight()
        {
            Console.WriteLine("Have you registered for the flight online? YES/NO");

            if (Console.ReadLine().ToUpper() == "YES")
            {
                Console.WriteLine("Please, give me your ticket and passport");
            }
            else if (Console.ReadLine().ToUpper() == "NO")
            {
                Console.WriteLine("Please, give me your passport. I will print your ticket. ");
            }

            Console.WriteLine(".....................................................");
            Console.WriteLine("Thank you.You have been registered for the flight. " +
                "\n Please, proceed to security check.");
        }
    }
}
