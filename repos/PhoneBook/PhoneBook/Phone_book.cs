using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PhoneBook
{
    class Phone_book
    {
        private List<Contact> contacts { get; set; } = new List<Contact>();
        private void DisplayContact(Contact contact)
        {
            Console.WriteLine($"Contact Name:{contact.ContactName} Contact No:{contact.PhoneNo}");
        }
        private void DisplayContacts(List<Contact> contacts)
        {
            foreach (Contact c in contacts)
            {
                DisplayContact(c);
            }
        }
        public void AddContacts(Contact c)
        {
            contacts.Add(c);
        }


        public void DisplayContact(String no)
        {
            var contact = contacts.FirstOrDefault(c => c.PhoneNo == no);
            if (contact == null)
            {
                Console.WriteLine("Contact doesnt exist");
            }
            else
            {
                DisplayContact(contact);
            }
        }

        public void DisplayAllCOntact()
        {
            DisplayContacts(contacts);
        }


        public void DisplayMatchingContacts(string name)
        {
            var MatchingContacts = contacts.Where(c => c.ContactName.Contains(name)).ToList();
            DisplayContacts(MatchingContacts);
        }
    }
}
