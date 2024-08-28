using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFoundationsDesignPatterns2LIL;

public class MallardDuck : Duck
{
    public MallardDuck() : base(new FlyWithWings(), new Quack()) { }
    public override void Display()
    {
        Console.WriteLine("I'm a real Mallard duck");
    }
}
