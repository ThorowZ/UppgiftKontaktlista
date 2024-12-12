using Business.Models;
using Data.Services;
using Presentation.Interface;


namespace Data.Services
{
    internal class ConcactIntefaceService : IContactInterface
    {
        public bool CreateContact(ContactFormat contact)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactFormat> GetContacts()
        {
            throw new NotImplementedException();
        }

        public ContactFormat GetUsByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public ContactFormat GetUsByPhone(string phoneNumber)
        {
            throw new NotImplementedException();
        }
    }
}
