using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class LongestWordInString
    {
        public static void Main()
        {
            int length = 0;
            String res="";
            String str = " Write a C# Sharp Program to display the following pattern using the alphabet.";
            string[] str_array = str.Split(new char[] { ' ', '.' });
            foreach(String s in str_array)
            {
                if (s.Length > length)
                {
                    length = s.Length;
                    res = s;
                }
             
            }
            Console.WriteLine(res);

        }
    }
}
