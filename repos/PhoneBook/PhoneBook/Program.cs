using System;

namespace PhoneBook
{
    
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Phone Book App");
            Console.WriteLine("Select operation");
            Console.WriteLine("1.Add Contacts");
            Console.WriteLine("2.Display contact by number");
            Console.WriteLine("3.View All Contacts");
            Console.WriteLine("4.Search contat by Pharse");
            Phone_book p = new Phone_book();
            var input = Console.ReadLine();
            while (true)
            {
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter phone no:");
                        var phoneNo = Console.ReadLine();
                        Contact c = new Contact(name, phoneNo);
                        p.AddContacts(c);           
                        
                        break;
                    case "2":
                        Console.WriteLine("Enter number");
                        phoneNo = Console.ReadLine();
                        p.DisplayContact(phoneNo);
                        break;
                    case "3":
                        Console.WriteLine("All contacts:");
                        p.DisplayAllCOntact();
                        break;
                    case "4":
                        Console.WriteLine("Enter name");
                        var prase = Console.ReadLine();
                        p.DisplayMatchingContacts(prase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.WriteLine("Enter input ");
                input = Console.ReadLine();
            }
        }
    }
}
