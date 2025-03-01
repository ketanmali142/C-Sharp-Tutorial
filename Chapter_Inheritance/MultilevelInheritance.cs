using System;

class GrandParent
{
    public void GrandParent1()
    {
        Console.WriteLine("This is Grandparent class.");
    }
}

class Parent : GrandParent
{
    public void Parent1()
    {
        Console.WriteLine("This is Parent class.");
    }
}

class Child : Parent
{
    public void Child1()
    {
        Console.WriteLine("This is Child class.");
    }
}

class MultilevelInheritance
{
    public static void Run()
    {
        Console.WriteLine("Multilevel Inheritance :");
        Child obj = new Child();
        obj.GrandParent1();
        obj.Parent1();
        obj.Child1();
        Console.WriteLine();
    }
}
