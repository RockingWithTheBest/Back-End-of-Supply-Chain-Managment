using Back_End.Models;

namespace xx1.Repository.Interface
{
    public interface ICustomer: IDisposable
    {
        IEnumerable<CustomerEntity> GetAllCustomers();
        CustomerEntity GetCustomerById(int id);
    }
}
