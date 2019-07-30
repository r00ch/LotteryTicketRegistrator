using r00ch.LotteryTicketRegistrator.Models.Entities;
using r00ch.LotteryTicketRegostrator.Repositories.Repositories;

namespace r00ch.LotteryTicketRegistrator.Services
{
    public class CustomerService
    {
        private CustomerRepository CustomerRepository { get; }

        public CustomerService(CustomerRepository custRepo)
        {
            CustomerRepository = custRepo;
        }

        public void Create(Customer customer)
        {
            CustomerRepository.Create(customer);
        }
    }
}