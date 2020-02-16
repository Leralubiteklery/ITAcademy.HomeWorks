using System;
using System.Collections.Generic;
using System.Text;

namespace HW._11
{
    class Square : Figure
    {
        private int _squareSide;

        public int SquareSide { get; set; }

        public Square(int side)
        {
            SquareSide = side;
        }
    }
}
