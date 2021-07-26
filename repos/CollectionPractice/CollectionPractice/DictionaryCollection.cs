using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice
{
    class DictionaryCollection
    {
        static void Main()
        {
            Dictionary<string, object> dt = new Dictionary<string, object>();
            dt.Add("Name", "Navya");
            dt.Add("Phno", 7090350886);
            dt.Add("Address", "Bistuvalli");
            dt.Add("Email", "navyashreegb99@gmail.com");
            dt.Add("Position", "ASE");
            dt.Add("Company", "Clarivate");

            foreach (string key in dt.Keys)
                Console.WriteLine(dt[key]);

            dt.
          

        }
    }
}
