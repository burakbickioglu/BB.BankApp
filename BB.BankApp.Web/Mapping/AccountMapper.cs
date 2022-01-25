using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BB.BankApp.Web.Data.Entities;
using BB.BankApp.Web.Models;

namespace BB.BankApp.Web.Mapping
{
    public class AccountMapper : IAccountMapper
    {
        public Account MapToAccount(AccountCreateModel model)
        {
            return new Account
            {
                AccountNumber = model.AccountNumber,
                ApplicationUserId = model.ApplicationUserId,
                Balance = model.Balance
            };
        }
    }
}
