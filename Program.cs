using System;
public class Animal
{
    public virtual void eat()
    {
        Console.WriteLine("Eating...");
    }
}
public class Dog : Animal
{
    public override void eat()
    {
        Console.WriteLine("Eating bread...");
    }
}
public class TestOverriding
{
    public static void Main()
    {
        Dog d1 = new Dog();
        Animal d2 = d1;
        d1.eat();
        d2.eat();
    }
}