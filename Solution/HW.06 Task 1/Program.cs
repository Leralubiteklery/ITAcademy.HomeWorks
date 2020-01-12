using System;

namespace HW._06_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];
            Random value = new Random();
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i] = value.Next();
                Console.WriteLine(array1[i]);
            }

            int[] array2 = new int[] { 5, 11, 7 };
            foreach(int i in array2)
            {
                Console.WriteLine(i);
            }

            int[] array3 = new int[3];
            for(int i = 0; i < array3.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.WriteLine(array3[i]);
            } 
            Console.ReadLine();
        }
    }
}
