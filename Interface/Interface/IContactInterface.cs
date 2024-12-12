using Business.Models;

namespace Presentation.Interface
{
    public interface IContactInterface
    {
        bool CreateContact(ContactFormat contact);

        IEnumerable<ContactFormat> GetContacts();

        ContactFormat GetUsByPhone(string phoneNumber);

        ContactFormat GetUsByEmail(string email);
    }
}
