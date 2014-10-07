using System;

namespace AnimalsApp
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Djaf djaf");
        }
    }
}
