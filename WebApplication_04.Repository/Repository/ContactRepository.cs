using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebApplication_04.Model.Model;
using WebApplication_04.DatabaseContext.DatabaseContext;
using System.Threading.Tasks;

namespace WebApplication_04.Repository.Repository
{
  public  class ContactRepository
  {
        ProjectDbContext _dbContext = new ProjectDbContext();
        public bool Contact(Contact contact)
        {

            //int i = _dbContext.Contacts.Where(c => c.Email == contact.Email).Count();
            //{
            //    if (i > 0)
            //    {
            //        return false;
            //    }

                _dbContext.Contacts.Add(contact);


                return _dbContext.SaveChanges() > 0;
        }

        public List<Contact> ViewContact()
        {
            return _dbContext.Contacts.ToList();
        }

   }
   

}
