using System;

class Program
{
    static void Main(string[] args)
    {

        List<Dog> dogs = new List<Dog>
        {
            new Dog { Name = "Snow" },
            new Dog { Name = "Yanis" },
            new Dog { Name = "Aziz" },
            new Dog { Name = "Habibi" },
            new Dog { Name = "Jul" }
        };


        var otherDogs = dogs.Where(d => d.Name != "Snow").Select(d => d.Name);

        Console.WriteLine("Les autres chiens sont :");
        foreach (var dogName in otherDogs)
        {
            Console.WriteLine(dogName);
        }
        Console.ReadLine();
    



    Griffin griffin = new Griffin("Griffux");
        griffin.Move();
        griffin.Sleep();

        Dragon dragon = new Dragon("Graou le dragon");
        dragon.Move();
        dragon.Sleep();

        Console.ReadLine();
    }
}

