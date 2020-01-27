using System;
using System.Collections.Generic;
using System.Text;

namespace HW._09
{
    class PassportControl
    {
        Passenger passenger = new Passenger();

        public void CheckPassport(bool hasPassport, bool hasVisa)
        {
            Console.WriteLine("Welcome to passport control. Please, give me your passport.");

            if (hasPassport == true)
            {
                    if(hasVisa == true)
                    {
                        Console.WriteLine("Everything is OK. Have a good flight!");
                    }
                    else
                    {
                        Console.WriteLine("You can not board the flight without visa.");
                    }
            }
            else
            {
                Console.WriteLine("You can not board the flight without passport.");
            }
        }
    }
}
