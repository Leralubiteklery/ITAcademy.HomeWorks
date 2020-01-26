using System;
using System.Collections.Generic;
using System.Text;

namespace HW._11
{
    class Circle : Figure
    {
        private int _circleSide;

        public int CircleSide { get; set; }

        public Circle(int side)
        {
            CircleSide = side;
        }
    }
}
