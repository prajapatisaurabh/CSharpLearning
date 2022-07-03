using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.Abstracts
{
    class MainMethod
    {
        static void Main()
        {
            Console.WriteLine("Int");
            Console.ReadLine();
        }
    }

    internal abstract class AbstractClass
    {
        public void AddThenRemoveOne(int x, int y)
        {

        }

        public abstract void Add(int x, int y);
    }

    internal class Class1 : AbstractClass
    {
        public override void Add(int x, int y)
        {
            throw new NotImplementedException();
        }

    }

   
}
