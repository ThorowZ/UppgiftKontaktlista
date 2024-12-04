using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UppgiftKontaktlista.Services;

namespace UppgiftKontaktlista.Models
{
    public class RegisterConcact
    {
        private readonly ContactService _contactService = new();
        public void CreateContact() 
        {
            Console.Clear();

            ContactFormat contact = new ContactFormat();

            Console.WriteLine("Enter first name: ");
            contact.Firstname = Console.ReadLine()!;

            Console.WriteLine("Enter last name: ");
            contact.Lastname = Console.ReadLine()!;

            Console.WriteLine("Enter mail: ");
            contact.Email = Console.ReadLine()!;


            //Console.WriteLine("Enter phonenumber: ");
            //contact.Phone = Console.ReadLine();

            _contactService.Add(contact);

        }

        public void ViewAllContacts()
        {
            Console.Clear();

            var contacts = _contactService.GetAll();

            if(contacts.Count() == 0)
            {
                Console.WriteLine("No contacts found.");
            }

            Console.WriteLine("All Contacts: ");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Name: {contact.Firstname} {contact.Lastname}");
                Console.WriteLine($"Email: {contact.Email}");
                Console.WriteLine(new string('-', 20));

            }
        }

    }
}
