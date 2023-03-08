using System;

public abstract class Animal
{
    public string Name { get; set; }

    public Animal()
    {
        Name = "Habibis";
    }

    public Animal(string name)
    {
        Name = name;
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

    public Griffin(string name) : base(name)
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

public class Dragon : Animal, IPIlotage
{
    public Dragon() : base()
    {
        Name = "Dragon";
    }

    public Dragon(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine(Name + " S'envole like a pure OG");
    }

    public new void Sleep()
    {
        Console.WriteLine(Name + " Dort fort aussi");
    }
}
