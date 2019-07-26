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

        public async Task<IActionResult> Register(string name = "TestUser", string password = "TestPassword")
        {
            try
            {
                ViewBag.Message = "User already regustered";

                var user = await UserManager.FindByNameAsync(name);

                if (user == null)
                {
                    user = new ApplicationUser { UserName = name };

                    var result = await UserManager.CreateAsync(user, password);
                    ViewBag.Message = "User was created";
                }
            }
            catch (Exception exception)
            {
                ViewBag.Message = exception.Message;
            }

            return View();
        }
    }
}