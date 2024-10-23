using Back_End.Models;

namespace Back_End.Repositories.Interfaces
{
    public interface ITrying:IDisposable
    {
        IEnumerable<Customer> GetAllTryings();
        Customer GetById(int id);
        int CreateTry(Customer customer);
        int UpdateTry(Customer customer);
        int DeleteTry(int id);
    }
}
