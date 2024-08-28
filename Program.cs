public class FlyWithWings: FlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("I'm flying!!");
    }
}

public class FlyNoWay : FlyBehaviour
{
    public void fly()
    {
        Console.WriteLine("I can't fly");
    }
}

public class Quack : QuackBehaviour
{
    public void quack()
    {
        Console.WriteLine("Quack");
    }
}