using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BB.BankApp.Web.Data.Entities;
using BB.BankApp.Web.Models;

namespace BB.BankApp.Web.Mapping
{
    public interface IUserMapper
    {
        List<UserListModel> MapToListOfUserList(List<ApplicationUser> users);
        UserListModel MapToUserList(ApplicationUser user);
    }
}
