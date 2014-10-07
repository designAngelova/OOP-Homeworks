using System;

namespace AnimalsApp
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private Gender gender;

        protected Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("Age cannot be negative or above 100");
                }

                this.age = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1}, Gender: {2}", this.Name, this.Age, this.gender);
        }

        public abstract void ProduceSound();
    }
}
