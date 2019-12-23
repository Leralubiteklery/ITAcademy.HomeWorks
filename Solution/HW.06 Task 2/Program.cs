using System;

namespace HW._06_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            
            for( int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine();

            array.SetValue(array.GetValue(0), 3);

            /*int[] array2 = new int[5];
            Array.Copy(array, 3, array2, 3, array.Length);

            for(int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);*/
            }
            Console.ReadLine();

        }
    }
}
