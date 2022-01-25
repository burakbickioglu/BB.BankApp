using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BB.BankApp.Web.Data.Context;
using BB.BankApp.Web.Data.Interfaces;
using BB.BankApp.Web.Data.Repositories;

namespace BB.BankApp.Web.Data.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly BankContext _context;

        public Uow(BankContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
