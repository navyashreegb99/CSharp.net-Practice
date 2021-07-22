using System;
using System.Collections;

namespace CollectionPractice
{
    class Program
    {
        public void printArrayList(ArrayList al)
        {
            foreach (Object ob in al)
            {
                Console.Write(ob + " ");
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            ArrayList al = new ArrayList();
            al.Add(100);
            al.Add(200);
            al.Add(300);
            al.Add(200);
            al.Add(600);
            al.Add(700);
            al.Insert(3, 400);
            p.printArrayList(al);
            al.Remove(200);
            al.RemoveAt(3);

            Console.WriteLine(al.Capacity);
           p.printArrayList(al);
        }

        
    }

    class HashCollection
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("EId", 1);
            ht.Add("Ename", "Navya");
            ht.Add("Job", "ASE");
            Console.WriteLine(ht["Enamew"]);

            foreach(Object key in ht.Keys)
            {
                Console.WriteLine(key+": "+ht[key]);
            }
        }
    }
}
