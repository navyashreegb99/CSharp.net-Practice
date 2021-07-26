using System;

namespace DelegatesPractice
{
    public delegate void addDelegate(int a, int b);
    public delegate string printDelegate(string name);
    class Program
    {
        public void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public static string printMessage(string name)
        {
            return "Hi " + name;
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            addDelegate ad = new addDelegate(p.add);
            ad(100, 300);
            p.add(100,500);

            printDelegate pd = new printDelegate(printMessage);
            Console.WriteLine(pd.Invoke("NAnditha"));
            Console.WriteLine(Program.printMessage("Navya"));
        }
    }
}
