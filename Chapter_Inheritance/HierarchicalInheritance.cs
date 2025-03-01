using System;

namespace Chapter_Inheritance
{
    class Vehicle
    {
        public string Brand;

        public void ShowBrand()
        {
            Console.WriteLine($"Brand: {Brand}");
        }
    }

    class Car : Vehicle
    {
        public void ShowCarDetails()
        {
            ShowBrand();
            Console.WriteLine("This is a Car.");
        }
    }

    class Bike : Vehicle
    {
        public void ShowBikeDetails()
        {
            ShowBrand();
            Console.WriteLine("This is a Bike.");
        }
    }

    class HierarchicalInheritance
    {
        public static void Run()
        {
            Console.WriteLine("Hierarchical Inheritance :");
            Car myCar = new Car();
            myCar.Brand = "G-Wagon";
            myCar.ShowCarDetails();

            Bike myBike = new Bike();
            myBike.Brand = "BMW";
            myBike.ShowBikeDetails();
            Console.WriteLine();
        }
    }
}
