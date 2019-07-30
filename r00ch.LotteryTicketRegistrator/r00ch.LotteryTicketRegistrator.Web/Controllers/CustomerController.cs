using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using r00ch.LotteryTicketRegistrator.Services;
using r00ch.LotteryTicketRegistrator.Web.Models;

namespace r00ch.LotteryTicketRegistrator.Web.Controllers
{
    public class CustomerController : Controller
    {
        private CustomerService CustomerService { get; }

        public CustomerController(CustomerService custService)
        {
            CustomerService = custService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CustomerModel customer)
        {
            var isModelValid = TryValidateModel(customer);
            if (isModelValid)
            {
                try
                {
                    var customerEntity = customer.ToEntity();
                    CustomerService.Create(customerEntity);
                    RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {
                    ViewBag.ErrorMessage = e.Message;
                    return View();
                }
            }
            return View();
        }
    }
}