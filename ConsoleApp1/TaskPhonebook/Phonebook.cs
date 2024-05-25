using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskPhonebook
{
    public class Phonebook
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();
        public Phonebook() 
        {
           contacts = new Dictionary<string, string>();
        }
        public void AddContact(string name, string phonenumber)
        {
            contacts.Add(name, phonenumber);
        }
        public void RemoveContact(string name)
        {
            contacts.Remove(name);
        }
        public void GetAllContacts()
        {
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
        public void FindContactByName(string name) 
        {
            Console.WriteLine(contacts.GetValueOrDefault(name));
        }
        

    }
}
