using System;

namespace StudentClassApp
{
    public class Student
    {
        private string name;
        private int age;
        public event InfoChangedEventHandler PropertyChanged;

        public Student(string value, int age)
        {
            this.Name = value;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                OnPropertyChanged("Name", this.name, value);
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }
            set
            {        
                OnPropertyChanged("Age", this.age, value);
                this.age = value;
            }
        }

        protected void OnPropertyChanged(string name, dynamic oldValue, dynamic newValue)
        {
            InfoChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new InfoChangedEventArgs(name, oldValue, newValue));
            }
        }
    }   
}