using System;

public class Animal
{
    public string Name { get; set; }

    public Animal()
    {
        Name = "Habibi";
    }

    public Animal(string name)
    {
        Name = name;
    }

    public void Move()
    {
        Console.WriteLine(Name + " move");
    }

    public void Sleep()
    {
        Console.WriteLine(Name + " sleep");
    }
}
