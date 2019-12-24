using System;

namespace HW._04_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter A,S,D or W key to move the figure");

            var userInput = Console.ReadKey().Key;
            char inputKey = Convert.ToChar(userInput);

            switch (inputKey)
            {
                case 'W':
                    Console.WriteLine(" Figure moves up");
                    break;
                case 'S':
                    Console.WriteLine(" Figure moves down");
                    break;
                case 'A':
                    Console.WriteLine(" Figure moves left");
                    break;
                case 'D':
                    Console.WriteLine(" Figure moves right");
                    break;
                default:
                    Console.WriteLine(" Wrong key. Please, enter W,A,S or D key");
                    break;
            }


            
            
            
            
        }
    }
}
