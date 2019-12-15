using System;
using System.Collections.Generic;


namespace HW._04_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {

                List<char> alphabet = new List<char>();
                for (int i = 90; i > 64; i--)
                {
                    alphabet.Add((char)i);
                }
                for (int i = 0; i < alphabet.Count; i++)
                {
                    Console.WriteLine(alphabet[i]);
                }
                Console.ReadLine();
            
        }
    }
}
