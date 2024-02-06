class Program
{
    static void Main(string[] args)
    {
        List<IAnimal> animals = new List<IAnimal>();

        Console.WriteLine("Enter dog's name:");
        var dogName = Console.ReadLine();
        InterfaceDog dog = new InterfaceDog { Name = dogName };
        dog.Eat();
        Console.WriteLine(dog.Cry());

        Console.WriteLine("Enter cat's name:");
        var catName = Console.ReadLine();
        InterfaceCat cat = new InterfaceCat { Name = catName };
        cat.Eat();
        Console.WriteLine(cat.Cry());

        //adding InterfaceDog and InterfaceCat objects to the list of IAnimal
        animals.Add(dog);
        animals.Add(cat);

        foreach (var animal in animals)
        {
            Console.WriteLine(animal.Name);
        }
    }
}