using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}";
        }
    }

    class CaseStudy5
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            // adding thw students
            students.Add(new Student(1, "Alice"));
            students.Add(new Student(2, "Bob"));
            students.Add(new Student(3, "Charlie"));

            // displaying students
            Console.WriteLine("All Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // Search for a student by name (ignoring the case here)
            Console.Write("\nEnter name to search: ");
            string searchName = Console.ReadLine();
            var found = students.FirstOrDefault(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
            if (found != null)
            {
                Console.WriteLine($"Found: ID={found.ID}, Name={found.Name}");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            // Remove a student by name (ere to ignoring the case)
            Console.Write("\nEnter name to remove: ");
            string removeName = Console.ReadLine();
            var toRemove = students.FirstOrDefault(s => s.Name.Equals(removeName, StringComparison.OrdinalIgnoreCase));
            if (toRemove != null)
            {
                students.Remove(toRemove);
                Console.WriteLine("Student removed.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }

            // Display updated list
            Console.WriteLine("\nUpdated List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            // Count total students
            Console.WriteLine($"\nTotal number of students: {students.Count}");
        }
    }
}
