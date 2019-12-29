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

            //SubTask1(stringArray);
            //SubTask2(stringArray);
            SubTask3(stringArray);

            Console.ReadLine();

        }

        static void SubTask1 (string[] str)
        {
            int maxLength = int.MinValue;
            int index = new int();

            for (int i = 0; i < str.Length; i++)
            {
                if(maxLength < str[i].Length)
                {
                    maxLength = str[i].Length;
                    index = i;
                }
            }
            str[index] = string.Empty;
        }

        static void SubTask2(string[] str)
        {
            int maxLength = int.MinValue;
            int indexMax = new int();
            int minLength = int.MaxValue;
            int indexMin = new int();
            
            for(int i = 0; i < str.Length; i++)
            {
                if( maxLength < str[i].Length)
                {
                    maxLength = str[i].Length;
                    indexMax = i;
                }
                else if(minLength > str[i].Length)
                {
                    minLength = str[i].Length;
                    indexMin = i;
                }

                string maxWord = str[indexMax];
                str[indexMax] = str[indexMin];
                str[indexMin] = maxWord;
            }
        }

        static void SubTask3(string[] str)
        {
            string str2 = String.Concat<string>(str);
            int strLength = str2.Length;
            Console.WriteLine("String length is: " + strLength);
        }
    }
}
