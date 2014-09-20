namespace SoftUni_Learning_System
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    class SulsTest
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
 
            CurrentStudent student1 = new OnsiteStudent("Ivan", "Stoianov", 23, "1828283", 5.56m, "PHP Basics", 12);
            CurrentStudent student2 = new OnlineStudent("Asan", "Mehmed", 34, "2372833", 11.8m, "C# Basics");
            Student student3 = new GraduateStudent("Philip", "Stoned", 16, "12388383", 1.00m, "QA");
            JuniorTrainer trainer1 = new JuniorTrainer("Amedobi", "Delara", 29);
            Trainer trainer2 = new SeniorTrainer("Stoimen", "Ivanov", 40);

            var allPeople = new List<Person>()
            {
                student1,
                student2,
                student3,
                trainer1,
                trainer2
            };

            Func<Person, bool> where = o => o.GetType().IsSubclassOf(typeof(CurrentStudent));
            var result = allPeople.Where(where)
                                    .Cast<CurrentStudent>()
                                    .ToList()
                                    .OrderBy(x => x.AverageGrade);

            foreach (var person in result)
            {
                Console.WriteLine(person);
            }
        }
    }
}
