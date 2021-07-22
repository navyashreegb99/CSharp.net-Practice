using System;

namespace EnumTest
{
    class Program
    {
        public enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

        public static void Main()
        {
            foreach (string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }
        }
    }
}
