using System;

namespace ConstructorPractice
{
    class Program
    {
        int n;
        string s;
        bool b;
      
        Program()
        {
            n = 10;
            s = "Navya";
            b = true;
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            Console.WriteLine(p1.b);
            Console.WriteLine(p1.s);
            Console.WriteLine(p1.n);
        }
    }
}
