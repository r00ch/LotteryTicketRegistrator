using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using r00ch.LotteryTicketRegistrator.Repositories.Architecture;

namespace r00ch.LotteryTicketRegistrator.Web.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> UserManager { get; }
        private SignInManager<ApplicationUser> SignInManager { get; }

        public AccountController(UserManager<ApplicationUser> usrMgr, SignInManager<ApplicationUser> siMgr)
        {
            UserManager = usrMgr;
            SignInManager = siMgr;
        }
    }
}