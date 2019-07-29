using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using r00ch.LotteryTicketRegistrator.Repositories.Architecture;
using r00ch.LotteryTicketRegistrator.Web.Models;

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

        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserModel userData)
        {
            if (TryValidateModel(userData))
            {
                try
                {
                    ViewBag.Message = "User already registered";

                    var user = await UserManager.FindByNameAsync(userData.Login);

                    if (user == null)
                    {
                        user = new ApplicationUser {UserName = userData.Login};

                        var result = await UserManager.CreateAsync(user, userData.Password);
                        ViewBag.Message = "User was created";
                        
                        if(result.Succeeded)
                            return RedirectToAction("Index", "Home");

                        var sb = new StringBuilder();
                        foreach (var error in result.Errors)
                        {
                            sb.AppendLine(error.Description);
                        }
                        throw new Exception(sb.ToString());
                    }
                }
                catch (Exception exception)
                {
                    ViewBag.Message = exception.Message;
                }
            }

            return View();
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserModel user)
        {
            if (TryValidateModel(user))
            {
                var result = await SignInManager.PasswordSignInAsync(user.Login, user.Password, false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Result = $"Login result: {result.ToString()}";
                }
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await SignInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}