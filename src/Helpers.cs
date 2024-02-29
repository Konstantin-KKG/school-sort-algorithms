using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.src
{
    internal static class Helpers
    {
        public static int[] CreateRandomNumberArray(int count)
        {
            Random random = new Random();
            int[] array = new int[count];
            
            for (int i = 0; i < count; i++)
                array[i] = random.Next(0, 50);

            return array;
        }

        public static void SwapNumbers(int index1, int index2, int[] array)
        {
            int helper = array[index1];
            array[index1] = array[index2];
            array[index2] = helper;
        }
    }
}
