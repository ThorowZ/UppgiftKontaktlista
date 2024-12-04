using System;
using System.Collections.Generic;
using System.Collections.Generic;
using UppgiftKontaktlista.Models;

namespace UppgiftKontaktlista.Services
{
    public class ContactService
    {

        private readonly List<ContactFormat> _contacts = new(); 

   
        public void Add(ContactFormat contact)
        {
            _contacts.Add(contact);
        }

   
        public IEnumerable<ContactFormat> GetAll()
        {
            return _contacts;
        }
    }
}
