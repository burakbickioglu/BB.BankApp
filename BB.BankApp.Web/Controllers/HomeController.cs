using Microsoft.AspNetCore.Mvc;
using BB.BankApp.Web.Data.Context;
using BB.BankApp.Web.Data.Entities;
using BB.BankApp.Web.Data.Interfaces;
using BB.BankApp.Web.Data.UnitOfWork;
using BB.BankApp.Web.Mapping;

namespace BB.BankApp.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly IApplicationUserRepository _applicationUserRepository;
        private readonly IUserMapper _userMapper;
        private readonly IUow _uow;

        public HomeController(/*IApplicationUserRepository applicationUserRepository, */IUserMapper userMapper, IUow uow)
        {
            //_applicationUserRepository = applicationUserRepository;
            _userMapper = userMapper;
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View(_userMapper.MapToListOfUserList(_uow.GetRepository<ApplicationUser>().GetAll()));
        }
         
        
    }
}
