using System;

namespace AnimalsApp
{
    public abstract class Cat : Animal
    {
        protected Cat(string name, int age, Gender gender) : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Myauuu");
        }
    }
}
