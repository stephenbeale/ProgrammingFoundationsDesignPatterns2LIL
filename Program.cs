//Strategy pattern

//Encapsulates a family of flying algorithms
public class FlyWithWings: IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}

public class FlyNoWay : IFlyBehaviour
{
    public void Fly()
    {
        Console.WriteLine("I can't fly");
    }
}

//Family of quacking algorithms
public class Quack : IQuackBehaviour
{
    public void Quacks()
    {
        Console.WriteLine("Quack");
    }
}

public class Squeak : IQuackBehaviour
{
    public void Quacks()
    {
        Console.WriteLine("Squeak");
    }
}