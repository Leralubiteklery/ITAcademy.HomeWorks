using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //a. явное преобразование
            double num1 = 11.22;
            float num2 = (float)num1;

            ushort num3 = 10;
            int num4 = (int)num3;

            short num5 = -128;
            byte num6 = (byte)num5;


            //b. неявное преобразование
            byte num7 = 10;
            ushort num8 = num7;

            short num9 = 14555;
            int num10 = num9;

            int num11 = 2569854;
            long num12 = num11;


            //c. упаковка
            int num13 = 11;
            object obj1 = num13;

            char ch1 = 'f';
            object obj2 = ch1;

            string str1 = "Homework";
            object obj3 = str1;

            //d. распаковка
            int num14 = (int)obj1;

            char ch2 = (char)obj2;

            string str2 = (string)obj3;


        }
    }
}
