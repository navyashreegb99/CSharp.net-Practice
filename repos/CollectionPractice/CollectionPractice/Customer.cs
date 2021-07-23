using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionPractice
{
    class Customer
    {
      public int CId {get;set;}
        public string Cname { get; set; }
        public long Phno { get; set; }

        public string Address { get; set; }
    }

    class TestCustomer
    {
        public static void Main()
        {
            List<Customer> customers= new List<Customer>();
        
            customers.Add(new Customer { CId = 1, Cname = "Navya", Phno = 7090350886, Address = "Bistuvalli" });
            customers.Add(new Customer { CId = 2, Cname = "Nanditha", Phno = 9916725651, Address = "Bistuvalli1" });
            customers.Add(new Customer { CId = 3, Cname = "Bhuvan", Phno =9731098714, Address = "Bistuvalli2" });
            customers.Add(new Customer { CId = 4, Cname = "Bharatesh", Phno = 9916725651, Address = "Bistuvalli3" });
            customers.Add(new Customer { CId = 5, Cname = "Latha", Phno = 9731098714, Address = "Bistuvalli4" });

            foreach(Customer obj in customers)
            {
                Console.WriteLine(obj.CId + " " + obj.Cname + " " + obj.Phno + " " + obj.Address);
            }


        }
    }
}
