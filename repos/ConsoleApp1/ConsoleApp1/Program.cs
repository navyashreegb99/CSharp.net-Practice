

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("VALUE IS=" + args[i]);

            }
            Console.ReadLine();
        }
    }
    class Student
    {
        static void Main(string[] args)
        {
            if (args[0] == "user" && args[1] == "pass")
            {
                Console.WriteLine("welcome user");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("invalid  user");
                Console.ReadLine();
            }
        }

    }
}