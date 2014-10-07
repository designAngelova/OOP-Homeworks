using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace HumanStudentWorkerApp
{
    public class Tester
    {
        public static void Main()
        {
            ICollection<Student> students = new Collection<Student>()
            {
                new Student("Samson", "Weaver", "QQK01GRD3E"),
                new Student("Oren", "Alston", "SEC56MNQ9L"),
                new Student("Hamish", "Spears", "RXL23WN5FL"),
                new Student("Chester", "Luna", "FQJ10XOGMR"),
                new Student("Tyrone", "Burris", "EHG52ZP0PR"),
                new Student("Palmer", "Reed", "ITF39VMIGN"),
                new Student("Fritz", "Weber", "LFZ54BJ4BR"),
                new Student("Nero", "Romero", "VVG90AH2PF"),
                new Student("Giacomo", "Stein", "OVH15YV4MO"),
                new Student("Merrill", "Baxter", "PZV0KEU0GS")
            };

            var sortedStudents = students.OrderBy(s => s.FacultyNumber);

            ICollection<Worker> workers = new Collection<Worker>()
            {
                new Worker("Urielle", "Dorsey", 96.56m, 4),
                new Worker("Haley", "Keller", 79.51m, 4),
                new Worker("Zenia", "Pena", 14.76m, 3),
                new Worker("MacKensie", "Bean", 42.71m, 5),
                new Worker("Rhea", "Hood", 9.33m, 3),
                new Worker("Caryn", "Figueroa", 74.21m, 8),
                new Worker("Charde", "Peterson", 89.30m, 8),
                new Worker("Sylvia", "Gonzalez", 65.00m, 6),
                new Worker("Catherine", "Bishop", 90.58m, 7),
                new Worker("Ramona", "King", 18.02m, 8),
            };

            var sortedWorkers = workers.OrderByDescending(w => w.MoneyPerHour());

            // check data validity here
            foreach (var worker in workers)
            {
                //Console.WriteLine(worker);
            }

            var allHumans = new List<Human>(students.Count + workers.Count);

            allHumans.AddRange(students);
            allHumans.AddRange(workers);

            var sortedHumans = allHumans.OrderBy(h => h.FirstName).ThenBy(h => h.LastName);

            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }
    }
}
