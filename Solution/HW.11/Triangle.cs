using System;
using System.Collections.Generic;
using System.Text;

namespace HW._11
{
    class Triangle : Figure
    {
        private int _triangleSide;

        public int TriangleSide { get; set; }

        public Triangle(int side)
        {
            TriangleSide = side;
        }
                
    }
}
