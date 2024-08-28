public class FlyWithWings: IFlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}

public class FlyNoWay : IFlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("I can't fly");
    }
}

public class Quack : IQuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("Quack");
    }
}

public class Squeak : IQuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("Squeak");
    }
}