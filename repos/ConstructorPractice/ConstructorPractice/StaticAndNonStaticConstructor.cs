using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorPractice
{
    class StaticAndNonStaticConstructor
    {
        int x;
        static int y;

        static StaticAndNonStaticConstructor()
        {
            Console.WriteLine("Static cons is called");
        }

       public StaticAndNonStaticConstructor()
        {
            Console.WriteLine("Non Static cons is called");
        }

        static void Main()
        {
            StaticAndNonStaticConstructor s1 = new StaticAndNonStaticConstructor();//Instance
            StaticAndNonStaticConstructor s2=;//variable
            StaticAndNonStaticConstructor s3 = s1;//reference
        }
    }
}
