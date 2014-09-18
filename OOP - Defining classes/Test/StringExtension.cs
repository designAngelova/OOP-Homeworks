using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class StringExtending
    {
        public static int CountWords(this string str)
        {
            return str.Split(new char[] {' ', ',', '.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static int CountSillables(this string str)
        {
            int counter = 0;
            foreach (var c in str)
            {
                if (c == 'a' || c == 'u' || c == 'i' || c == 'o' || c == 'y' || c == 'e')
                {
                    counter++;
                }
            }
            return counter;
        }

        public static bool isPalindrome(this string str)
        {
            int i = 0;
            int j = str.Length - 1;
            while (i != j)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
                i++;
                if (i == j)
                {
                    break;
                }
                j--;
            }
            return true;
        }     
    }
    class StringExtension
    {
        static void Main(string[] args)
        {
            string myString = "ValaleV";
            Console.WriteLine(myString.isPalindrome());

            //Test Int Array Extension Method
            int[] array = { 11, 2, 12, 3, 123, 6 };
            array.SortArray();
            //foreach (var num in array)
            //{
            //    Console.WriteLine(num);
            //}

            List<int> listey = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8
            };

            listey.IncreaseAll(10);

            Console.WriteLine(listey.ExtendToString());

            var myAnonomousClass = new {name = "Vasil", age = "23", wins = 12};
            var secondClass = new {name = "vasil", age = "23", wins = 12};

            Console.WriteLine(myAnonomousClass.Equals(secondClass));
            Console.WriteLine(myAnonomousClass.GetHashCode());
            Console.WriteLine(secondClass.GetHashCode());

            var arr = new[]
            {
                new {X = 1, Y = 0},
                new {X = 1, Y = 0}
            };

            Console.WriteLine(arr);
        }
    }
}
