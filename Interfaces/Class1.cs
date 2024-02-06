using System;
using System.Collections.Generic;

// IAnimal interface 
public interface IAnimal
{
    string Name { get; set; }
    string Colour { get; set; }
    double Height { get; set; }
    int Age { get; set; }

    void Eat();
    string Cry();
}

//  InterfaceDog class that implements IAnimal
public class InterfaceDog : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Dogs eat meat");
    }

    public string Cry()
    {
        return "Woof!";
    }
}

// InterfaceCat class that implements IAnimal
public class InterfaceCat : IAnimal
{
    public string Name { get; set; }
    public string Colour { get; set; }
    public double Height { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine("Cats eat mice");
    }

    public string Cry()
    {
        return "Meow!";
    }
}