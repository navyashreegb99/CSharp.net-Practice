using System;
using System.Collections.Generic;
using System.Text;

namespace BasicComputations
{
    class ReverseWordsOfString
    {
        public static void Main()
        {
            string str = "Display the pattern like pyramid using the alphabet.";
            String[] arr = str.Split(' ');
            String new_str = "";
            for(int i=arr.Length-1;i>=0;i--)
            {
                new_str = new_str +arr[i] + " ";
            }
            Console.WriteLine(new_str);
            
        }
    }
}
