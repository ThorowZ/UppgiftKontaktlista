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

            var contact = new ContactFormat();

            Console.WriteLine("Enter first name: ");
            contact.Firstname = Console.ReadLine()!;

            Console.WriteLine("Enter last name: ");
            contact.Lastname = Console.ReadLine()!;

            Console.WriteLine("Enter mail: ");
            contact.Email = Console.ReadLine()!;


            //Console.WriteLine("Enter phonenumber: ");
            //contact.Phone = Console.ReadLine();

            _contactService.Equals(contact);

        }

        public void ViewAllKontakts()
        {
            Console.Clear();

            
            //foreach (var contact in contacts)
            //{

            //}
        }

    }
}
