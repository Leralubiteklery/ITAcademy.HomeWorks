﻿using System;

namespace HW._01___2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://www.codewars.com/kata/55a144eff5124e546400005a
             Classy Classes
Basic Classes, this kata is mainly aimed at the new JS ES6 Update introducing classes
Task
Your task is to complete this Class, the Person class has been created. You must fill in the Constructor method to accept a name as string and an age as number, complete the get Info property and getInfo method/Info getter which should return
johns age is 34*/

            Person john = new Person("john", 34);
            Console.WriteLine($"{john.Name}'s age is {john.Age}");
        }
    }
}
