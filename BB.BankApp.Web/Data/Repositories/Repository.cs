using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using BB.BankApp.Web.Data.Context;
using BB.BankApp.Web.Data.Interfaces;

namespace BB.BankApp.Web.Data.Repositories
{
    public class Repository<T>: IRepository<T> where T: class, new() 
    {
        private readonly BankContext _context;

        public Repository(BankContext context)
        {
            _context = context;
        }

        public void Create(T entity) 
        {
            _context.Set<T>().Add(entity);
        }

        public void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public IQueryable<T> getQueryable()
        {
            return _context.Set<T>().AsQueryable();
        }

        public T GetById(object id)
        {
            return _context.Set<T>().Find(id);
        }


    }
}
