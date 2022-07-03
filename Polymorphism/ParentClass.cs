using System;

namespace CSharpLearning.Polymorphism
{

    internal class ParentClass
    {

        public void Call1()
        {
            Console.WriteLine("First Method call");
        }
        
        public virtual void Call2()
        {
            Console.WriteLine("Secoud Method call");
        }
    }
}
