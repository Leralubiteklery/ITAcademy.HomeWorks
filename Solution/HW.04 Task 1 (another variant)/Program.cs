using System;

namespace HW._04_Task_1__another_variant_
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;
            for(letter = 'Z'; letter >= 'A'; letter--)
            {
                Console.WriteLine(letter);
            }
            Console.ReadLine();
        }
    }
}
