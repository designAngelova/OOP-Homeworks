namespace SULearningSys
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SULSTester
    {
        public static void Main()
        {
            List<Person> people = new List<Person>()
            {
                new OnsiteStudent("Valeri", "Hristov", 23, "129293", 5.80, "C# OOP", 12),
                new DropoutStudent("Anani", "Ananov", 20, "2323292", 3.90, "Java Basics"),
                new GraduateStudent("Maria", "Petrova", 29, "219292", 5.92),
                new OnlineStudent("Denica", "Marinova", 31, "223333", 5.00, "HTML/CSS"),
                new OnsiteStudent("Polia", "Genova", 22, "239292", 4.78, "JavaScript", 112),
                new SeniorTrainer("Svetlin", "Nakov", 30)
            };

            Func<Person, bool> where = p => p.GetType().IsSubclassOf(typeof (CurrentStudent));

            var result = people.Where(where)
                            .Cast<CurrentStudent>()
                            .OrderByDescending(p => p.AverageGrade);

            foreach (var currentStudent in result)
            {
                Console.WriteLine(currentStudent);
            }
        }
    }
}
