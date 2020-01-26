using System;
using System.Collections.Generic;
using System.Text;

namespace HW._11
{
    public class Figure
    {
        public double CountSquareArea(double side)
        {
            return Math.Pow(side, 2);
        }

        public double CountCircleArea(double side)
        {
            return Math.Pow(side, 2) * Math.PI;
        }

        public double CountTriangleArea(double side)
        {
           double p = (side * 3) / 2;
            return Math.Sqrt(p*(p - side) * 3);
        }

    }
}
