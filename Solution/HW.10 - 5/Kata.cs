using System;
using System.Collections.Generic;
using System.Text;

namespace HW._10___5
{
    class Kata
    {
        public static int[] Remove(int[] integerList, int[] valuesList)
        {
            int count = integerList.Length;

            for (int i = 0; i < integerList.Length; i++)
            {
                for (int j = 0; j < valuesList.Length; j++)
                {
                    if (integerList[i].Equals(valuesList[j]))
                    {
                        integerList[i] = 0;
                        count--;
                    }
                }
            }

            int[] updatedList = new int[count];

            count = 0;
            for (int i = 0; i < integerList.Length; i++)
            {
                if (integerList[i] != 0)
                {
                    updatedList[count] = integerList[i];
                    count++;
                }
            }
            return updatedList;
        }
    }
}
