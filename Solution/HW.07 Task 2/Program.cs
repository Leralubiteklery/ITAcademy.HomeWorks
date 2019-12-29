using System;

namespace HW._07_Task_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a string");
            string enteredString = Console.ReadLine();
            string[] stringArray = enteredString.Split(' ');
            
            SubTask1(stringArray);
          
        }

        static void SubTask1 (string[] str)
        {
            int maxLength = int.MinValue;
            int index = new int();

            Console.WriteLine("Final string: ");

            for (int i = 0; i < str.Length; i++)
            {
                if(maxLength < str[i].Length)
                {
                    maxLength = (int)str[i].Length;
                    index = i;
                }
            }
            str[index] = string.Empty;
        }

        static void SubTask2(string[] str)
        {

        }
    }
}
