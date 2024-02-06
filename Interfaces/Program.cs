using System;

// Abstract class Animal
public abstract class Animal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public int Age { get; set; }

    public abstract void Eat();
}

// Dog class that inherits from Animal
public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Dogs eat meat.");
    }
}

// Cat class that inherits from Animal
public class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cats eat mice.");
    }
}