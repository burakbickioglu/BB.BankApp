using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BB.BankApp.Web.Data.Entities;

namespace BB.BankApp.Web.Data.Interfaces
{
    public interface IAccountRepository
    {
        public void Create(Account account);
    }
}
