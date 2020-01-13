using System;
using System.Text;

namespace HW._08_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder initialStr = new StringBuilder("1a!2.3!!.. 4.!.?6 7! ..?");

           for(int i = 0; i <= initialStr.Length; i++)
            {
                initialStr.Replace("!", "", 0, 14);
                initialStr.Replace(" ", "_", 12, 8);
            }

            Console.WriteLine(initialStr);
            Console.ReadLine();
        }
    }
}
