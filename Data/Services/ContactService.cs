using Business.Models;
using System;
using System.Collections.Generic;
using System.Collections.Generic;

namespace Data.Services
{
    public class ContactService
    {

        private List<ContactFormat> _contacts = [];
        private readonly FileService _fileService = new(fileName: "Contact.json"); 


        public ContactFormat Add(ContactFormat contact)
        {
            _contacts.Add(contact);
            _fileService.SaveList(_contacts);

            return contact;
        }


        public IEnumerable<ContactFormat> GetAll()
        {
            _contacts = _fileService.LoadList<ContactFormat>();
            return _contacts;
        }

        
    }
}
