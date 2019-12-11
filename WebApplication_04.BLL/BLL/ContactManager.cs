using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.Repository.Repository;
using System.Threading.Tasks;

namespace WebApplication_04.BLL.BLL
{
    public class ContactManager
    {
        ContactRepository _studentRepository = new ContactRepository();
        public bool Contact(Contact Contact)
        {
            return _studentRepository.Contact(Contact);
        }
        public List<Contact> ViewContact()
        {
            return _studentRepository.ViewContact();
        }
    }
}
