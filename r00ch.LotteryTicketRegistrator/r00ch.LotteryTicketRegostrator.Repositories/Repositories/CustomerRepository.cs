using System;
using System.Linq;
using r00ch.LotteryTicketRegistrator.Models.Entities;
using r00ch.LotteryTicketRegistrator.Repositories.Architecture;

namespace r00ch.LotteryTicketRegostrator.Repositories.Repositories
{
    public class CustomerRepository
    {
        private ApplicationDbContext DbContext { get; }

        public CustomerRepository(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void Create(Customer customer)
        {
            var existingCustomer = DbContext.Customers.FirstOrDefault(c => 
                String.Equals(c.PhoneNumber, customer.PhoneNumber, StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(c.PhoneNumber.Substring(4), customer.PhoneNumber, StringComparison.InvariantCultureIgnoreCase));

            if (existingCustomer != null)
            {
                throw new Exception("Customer with provided phone number is already registered");
            }

            DbContext.Customers.Add(customer);
            DbContext.SaveChanges();
        }
    }
}