using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLINQExtension
{
    public class TestLinqExtension
    {
        public static void Main()
        {
            List<int> myList = new List<int>() {1, 2, 65, 22, 456, 112356, 11};

            // Will print all odd numbers instead of even
            myList = myList.WhereNot(x => x % 2 == 0).ToList();


            myList = myList.Repeat(3).ToList();

            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }

            List<string> websites = new List<string>()
            {
                "www.boomerang.com",
                "www.Aslaito.bg",
                "www.Kokodinev.co",
                "www.btv.bg",
                "www.bbc.com"
            };

            IEnumerable<string> suffixes = new List<string>()
            {
                ".com",
                ".co"
            };

            websites = websites.WhereEndsWith<string>(suffixes).ToList();

            foreach (var w in websites)
            {
                Console.WriteLine(w);
            }
        }
    }
}
