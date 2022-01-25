using BB.BankApp.Web.Data.Entities;
using BB.BankApp.Web.Models;

namespace BB.BankApp.Web.Mapping
{
    public interface IAccountMapper
    {
        Account MapToAccount(AccountCreateModel model);
    }
}