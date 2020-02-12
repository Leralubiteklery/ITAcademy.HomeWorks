using System;

namespace HW._07_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter your poem: ");

            string userInput = Console.ReadLine();
            string poem = userInput.ToUpper();
            string[] arrayPoem = poem.Split(";");

            for(int i = 0; i < arrayPoem.Length; i++)
            {
                Console.WriteLine(arrayPoem[i].Replace("O", "A"));
            }

            Console.ReadLine();
        }
    }
}
