using Back_End.Models;
using xx1.Db;
using xx1.Repository.Interface;

namespace xx1.Repository.Implementation
{
    public class CustomerRepository : ICustomer
    {
        private readonly ApplicationDBContext dBContext;
        public CustomerRepository(ApplicationDBContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public void Dispose()
        {
            dBContext?.Dispose();
        }

        public IEnumerable<CustomerEntity> GetAllCustomers()
        {
            var customer = dBContext.Customers.ToList();
            return customer;
        }

        public CustomerEntity GetCustomerById(int id)
        {
            var customer = dBContext.Customers.FirstOrDefault(c => c.Id == id);
            return customer;
        }
    }
}
