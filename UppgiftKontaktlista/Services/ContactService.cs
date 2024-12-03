using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UppgiftKontaktlista.Services
{
    public class ContactService
    {
        private List<ContactService> _contactService = [];

        public void Add(ContactService contactService)
        {
            _contactService.Add(contactService);
        }

        public IEnumerable<ContactService> GetAll() 
        {
        return _contactService;
        }

    }
}
