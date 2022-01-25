using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BB.BankApp.Web.Data.Context;
using BB.BankApp.Web.Data.Entities;
using BB.BankApp.Web.Data.Interfaces;

namespace BB.BankApp.Web.Data.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly BankContext _context;

        public ApplicationUserRepository(BankContext context)
        {
            _context = context;
        }

        //public List<ApplicationUser> GetAll()
        //{
        //    return _context.ApplicationUsers.ToList();
        //}

        public ApplicationUser GetById(int id)
        {
            return _context.ApplicationUsers.SingleOrDefault(x => x.Id == id);
        }

        public void Create(ApplicationUser user)
        {
            //var userset = _context.ApplicationUsers;
            //var userset2 = _context.Set<ApplicationUser>(); 
            _context.Set<ApplicationUser>().Add(user);
            _context.SaveChanges();
        }

        public void Remove(ApplicationUser user)
        {
            _context.Set<ApplicationUser>().Remove(user);
            _context.SaveChanges();
        }


        public List<ApplicationUser> GetAll()
        {
            return _context.Set<ApplicationUser>().ToList();
        }
    }
}
