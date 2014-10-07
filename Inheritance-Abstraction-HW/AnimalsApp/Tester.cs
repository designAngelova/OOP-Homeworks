using System;
using System.Linq;

namespace AnimalsApp
{
    public class Tester
    {
        public static void Main()
        {
            Dog[] dogs = new Dog[5];
            Cat[] cats = new Cat[5];

            dogs[0] = new Dog("Beau", 7, Gender.Female);
            dogs[1] = new Dog("Ulric", 10, Gender.Male);
            dogs[2] = new Dog("Conan", 8, Gender.Female);
            dogs[3] = new Dog("Graiden", 1, Gender.Male);
            dogs[4] = new Dog("Kuame", 3, Gender.Male);

            cats[0] = new Kitten("Ocean", 3);
            cats[1] = new Kitten("Leah", 6);
            cats[2] = new Kitten("Hillary", 1);
            cats[3] = new Kitten("Candice", 3);
            cats[4] = new Kitten("Isabelle", 4);

            Console.WriteLine(dogs.Average(d => d.Age));
            Console.WriteLine(cats.Average(c => c.Age));    
        }
    }
}
