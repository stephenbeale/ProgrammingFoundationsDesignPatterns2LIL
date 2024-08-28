using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFoundationsDesignPatterns2LIL;

public abstract class Duck
{
    protected IFlyBehaviour flyBehaviour;
    protected IQuackBehaviour quackBehaviour;

    protected Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
    {
        this.flyBehaviour = flyBehaviour;
        this.quackBehaviour = quackBehaviour;
    }

    public abstract void Display();
    
    public void PerformFly() {
        flyBehaviour.Fly();
    }
    
    public void PerformQuack()
    {
        quackBehaviour.Quacks();
    }
    
    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}
