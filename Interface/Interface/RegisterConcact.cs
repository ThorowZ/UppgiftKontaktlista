using Business.Models;
using Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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


            while (true) 
            { 
                Console.WriteLine("Please enter your phone number");
                string Phoneinput = Console.ReadLine()!;

                if (Phoneinput.All(char.IsDigit))
                {
                    contact.Phone = Phoneinput;
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a vaild phone numnber");
                }
            }

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
                Console.WriteLine($"Phone: {contact.Phone}");
                Console.WriteLine(new string('-', 20));

            }
        }

    }
}
