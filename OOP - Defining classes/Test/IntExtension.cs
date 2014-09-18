using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class IntExtending
    {
        public static int SumArray(this int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }
            return sum;
        }

        public static void SortArray(this int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }           
        }

    }
}
