using System.Collections.Generic;
using BB.BankApp.Web.Data.Entities;

namespace BB.BankApp.Web.Data.Interfaces
{
    public interface IApplicationUserRepository
    {
        List<ApplicationUser> GetAll();
        ApplicationUser GetById(int id);
    }
}
