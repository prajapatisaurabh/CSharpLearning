using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLearning.OperatorOverloading
{
    internal class Matrix : IDisposable
    {
        private int a, b, c, d;
        public Matrix(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        ~ Matrix()
        {
        }

        public void Dispose()
        {
            GC.SuppressFinalize(true);  

        }


        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            return new Matrix(m1.a + m2.a, m1.b + m2.b, m1.c + m2.c, m1.d + m2.d);
        }
        
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            return new Matrix(m1.a - m2.a, m1.b - m2.b, m1.c - m2.c, m1.d - m2.d);
        }

        public override string ToString()
        {
            return $"a: {a}, b: {b},c: {c},d: {d}";
        }
    }
}
