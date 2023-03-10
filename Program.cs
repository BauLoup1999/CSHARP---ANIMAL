using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Dog> dogs = new List<Dog>
        {
            new Dog { Name = "Snow", Age = 2 },
            new Dog { Name = "Yanis", Age = 4 },
            new Dog { Name = "Aziz", Age = 1 },
            new Dog { Name = "Habibi", Age = 5 },
            new Dog { Name = "Jul", Age = 3 }
        };

        var otherDogs = dogs.Where(d => d.Name != "Snow").Select(d => d.Name);

        Console.WriteLine("Les autres chiens sont :");
        foreach (var dogName in otherDogs)
        {
            Console.WriteLine(dogName);
        }

        Griffin griffin = new Griffin("Griffux", 3);
        griffin.Move();
        griffin.Sleep();
        

        Dragon dragon = new Dragon("Graou le dragon", 7);
        dragon.Move();
        dragon.Sleep();

        Eagle eagle = new Eagle("L'aigle de la hess", 8);
        eagle.Fly();

        Bird bird = new Bird("Le piaf", 4);
        bird.Fly();

        List<Animal> animals = new List<Animal>();
        animals.Add(griffin);
        animals.Add(dragon);
        animals.AddRange(dogs);

        List<Animal> sortedAnimals = animals
            .Where(a => a is Dog && a.Age >= 2 && a.Age <= 5)
            .OrderBy(a => a.Age)
            .ToList();

        Console.WriteLine("Les animaux triés par âge sont :");
        foreach (Animal animal in sortedAnimals)
        {
            Console.WriteLine(animal.Name + " - " + animal.Age + "ans");
        }

        Console.ReadLine();
    }
}
