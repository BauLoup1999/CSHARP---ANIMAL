using CSHARP___ANIMAL.Model;

public class Bird : Animal, IPIlotage, IFly
{
    public Bird() : base()
    {
        Name = "Oiseau";
    }

    public Bird(string name, int age) : base(name, age)
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
        Console.WriteLine(Name + " Vole mais ne rends pas l'argent");
    }


}