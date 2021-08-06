using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    class Contact
    {

        public Contact(String name, String no)
        {
            ContactName = name;
            PhoneNo = no;
        }
        public String ContactName
        {
            get; set;
        }
        public string PhoneNo
        {
            get; set;
        }

        public void AddContact(String Name, int no)
        {

        }

    }
}
