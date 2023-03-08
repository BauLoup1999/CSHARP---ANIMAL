using System;

class Program
{
    static void Main(string[] args)
    {
        Griffin griffin = new Griffin("Griffux");
        griffin.Move();
        griffin.Sleep();

        Dragon dragon = new Dragon("Graou le dragon");
        dragon.Move();
        dragon.Sleep();

        Console.ReadLine();
    }
}
