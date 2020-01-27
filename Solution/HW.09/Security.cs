using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09
{
    class Security
    {
        public void CheckForProhibitedStaff(bool hasSthProhibited)
        {
            Console.WriteLine(".....................................................");
            Console.WriteLine("Welcome to security check. Please, proceed to the check-up point. \nPress any key to continue.");
            Console.ReadLine();

            if (hasSthProhibited == true)
            {
                Console.WriteLine("You cannot take this on board. Please, hand it over.");
                Console.WriteLine(".....................................................\n");
            }
            else
            {
                Console.WriteLine("Everything is OK.");
            }
        }

    }
}
