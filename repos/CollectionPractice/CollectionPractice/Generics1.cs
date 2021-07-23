using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice
{
    class Generics1<T>
    {
        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 + d2);
        }

        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
        }

        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
        }

        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
        }
    }
    class TestGenerics { 
        static void Main()
        {
            Generics1<float> obj = new Generics1<float>();
            obj.Add(10, 20);
            obj.Sub(10, 20);
            obj.Mul(10, 20);
            obj.Div(10, 20);


        }
    }
}
