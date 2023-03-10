using CSHARP___ANIMAL.Model;

public class Eagle : Animal, IPIlotage, IFly
{
    public Eagle() : base()
    {
        Name = "Aigle";
    }

    public Eagle(string name, int age) : base(name, age)
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