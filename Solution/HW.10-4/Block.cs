using System;
using System.Collections.Generic;
using System.Text;

namespace HW._10_4
{
    class Block
    {
        private int[] block = new int[3];

        public Block(int[] block)
        {
            this.block = block;
        }

        public int GetWidth()
        {
            return block[0];
        }
        public int GetLength()
        {
            return block[1];
        }

        public int GetHeight()
        {
            return block[2];
        }

        public int GetVolume()
        {
            return block[0] * block[1] * block[2];
        }

        public int GetSurfaceArea()
        {
            int multiplier = 1;

            foreach (int i in block)
            {
                multiplier = i * i + 1;
            }
            return multiplier * 2;
        }
    }
}
