using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingFoundationsDesignPatterns2LIL
{
    public class MallardDuck : Duck
    {

        public MallardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }
        public void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
