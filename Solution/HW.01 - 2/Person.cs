﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW._01___2
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
