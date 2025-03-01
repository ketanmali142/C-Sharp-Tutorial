using System;

namespace Chapter_Inheritance
{
    class Employee
    {
        public string Name;
        public int Id;

        public void ShowDetails()
        {
            Console.WriteLine($"Employee ID: {Id}, Name: {Name}");
        }
    }

    class Manager : Employee
    {
        public string Department;

        public void ShowManagerDetails()
        {
            ShowDetails();
            Console.WriteLine($"Department: {Department}");
        }
    }

    class SingleInheritance
    {
        public static void Run()
        {
            Console.WriteLine("Single Inheritance :");
            Manager manager = new Manager();
            manager.Id = 101;
            manager.Name = "Dustin";
            manager.Department = "IT";
            manager.ShowManagerDetails();
            Console.WriteLine();
        }
    }
}
