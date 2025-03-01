using System;

namespace Chapter_Inheritance
{
    
    interface IPerson
    {
        void ShowName();
    }

    
    interface ISubject
    {
        void ShowSubject();
    }

    
    class Teacher : IPerson, ISubject
    {
        public string Name { get; set; }
        public string Subject { get; set; }

        public void ShowName()
        {
            Console.WriteLine($"Teacher Name: {Name}");
        }

        public void ShowSubject()
        {
            Console.WriteLine($"Teaches: {Subject}");
        }
    }

    class HybridInheritance
    {
        public static void Run()
        {
            Console.WriteLine("Hybrid Inheritance :");
            Teacher teacher = new Teacher
            {
                Name = "Mr.Wick",
                Subject = "Mathematics"
            };

            teacher.ShowName();
            teacher.ShowSubject();
            Console.WriteLine();
        }
    }
}
