using System;


public class Dog : Animal, IPIlotage
{
    public Dog() : base()
    {
        Name = "Dog";
    }

    public Dog(string name, int age) : base(name, age)
    {
    }

 

}