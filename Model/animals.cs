using CSHARP___ANIMAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal()
    {
        Name = "Habibis";
        Age = 0;
    }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public virtual void Move()
    {
        Console.WriteLine(Name + " ddaz");
    }

    public virtual void Sleep()
    {
        Console.WriteLine(Name + " dort fort");
    }
 
}

public class Griffin : Animal
{
    public Griffin() : base()
    {
        Name = "Griffin";
    }

    public Griffin(string name, int age) : base(name, age)
    {
    }

    public override void Move()
    {
        Console.WriteLine(Name + " Voltige comme un pigeon");
    }
    public new void Sleep()
    {
        Console.WriteLine(Name + " Dort");
    }
}



public class Dragon : Animal, IPIlotage, IFly
{
    public Dragon() : base()
    {
        Name = "Dragon";
    }

    public Dragon(string name, int age) : base(name, age)
    {
    }

    public override void Move()
    {
        Console.WriteLine(Name + " bouge");
    }

    public new void Sleep()
    {
        Console.WriteLine(Name + " Dort fort aussi");
    }
    public  void Fly()
    {
        Console.WriteLine(Name + " S'envole like a pure OG");
    }


}
