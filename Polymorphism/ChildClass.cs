using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Polymorphism
{
    internal class ChildClass : ParentClass
    {
        public new void Call1()
        {
            Console.WriteLine("Child Class method 1");
        }

        public override void Call2()
        {
            Console.WriteLine("Child Class method 2");
        }


        //static void Main(string[] args)
        //{


        //    ParentClass pc;
        //    ChildClass cc = new ChildClass();
        //    //program.Call1();
        //    //program.Call2();

        //    pc = cc;
        //    pc.Call1();
        //    pc.Call2();

        //    Console.ReadKey();
        //}

    }
}
