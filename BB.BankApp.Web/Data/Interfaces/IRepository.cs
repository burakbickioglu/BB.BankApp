using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BB.BankApp.Web.Data.Interfaces
{
    public interface IRepository<T> where T : class, new()
    {
        void Create(T entity);
        void Remove(T entity);
        void Update(T entity);
        T GetById(object id);
        List<T> GetAll();
        IQueryable<T> getQueryable();
    }
}
