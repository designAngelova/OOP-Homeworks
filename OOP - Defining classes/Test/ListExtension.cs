using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class ListExtension
    {
        public static void IncreaseAll(this List<int> myList, int amount)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                myList[i] += amount;
            }
        }

        public static string ExtendToString(this List<int> array)
        {
            return String.Join(", ", array);
        }
    }
}
