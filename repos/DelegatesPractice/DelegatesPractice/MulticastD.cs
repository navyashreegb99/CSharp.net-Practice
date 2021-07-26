using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesPractice
{
    public delegate void rectangle(int l, int b);
    class MulticastD
    {
        public void area(int l, int b)
        {
            Console.WriteLine("Area " + (l * b));
        }

        public void perimeter(int l,int b)
        {
            Console.WriteLine("perimeter" + (2 * (l + b)));
        }

        public static void Main()
        {
            MulticastD md = new MulticastD();
            md.area(10, 20);
            md.perimeter(10, 20);
            Console.WriteLine("Called using delegate");
            rectangle rd = md.area;
            rd += md.perimeter;
            rd(10, 20);





        }
    }
}
