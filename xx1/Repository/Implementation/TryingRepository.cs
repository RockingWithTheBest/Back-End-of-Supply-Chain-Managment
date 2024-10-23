using Back_End.Models;
using Back_End.Repositories.Interfaces;

namespace Back_End.Repositories.Implementation
{
    //public class TryingRepository : ITrying
    //{
    //    private readonly ApplicationDBContext _context;
    //    public TryingRepository(ApplicationDBContext db)
    //    {
    //        _context = db;
    //    }
    //    public int CreateTry(Customer customer)
    //    {
    //        int result = -1;
    //        if (customer == null)
    //        {
    //            result = 0;
    //        }
    //        else 
    //        { 
    //            _context.Trying.Add(customer);
    //            _context.SaveChanges();
    //            result = customer.Id;
    //        }
    //        return result;
    //    }

    //    public int DeleteTry(int id)
    //    {
    //        int result = -1;
    //        if (id <= 0)
    //        {
    //            return -1;
    //        }
    //        var customer = _context.Trying.Find(id);
    //        if (customer == null)
    //        {
    //            return -1;
    //        }
    //        _context.Trying.Remove(customer);
    //        _context.SaveChanges();
    //        return id;
    //    }

    //    public void Dispose()
    //    {
    //        _context?.Dispose();
    //    }

    //    public IEnumerable<Customer> GetAllTryings()
    //    {
    //        var y = _context.Trying.ToList();
    //        return y;
    //    }

    //    public Customer GetById(int id)
    //    {
    //        var y = _context.Trying.Where(x=> x.Id == id).FirstOrDefault()?? null;
    //        return y;
    //    }

    //    public int UpdateTry(Customer customer)
    //    {
    //        var y = _context.Trying.Where(x => x.Id == customer.Id).FirstOrDefault() ?? null;
    //        if (y != null)
    //        {
    //            y.Id = customer.Id;
    //            y.Amount = customer.Amount;  
    //            _context.SaveChanges();
    //            return y.Id;
    //        }
    //        return -1;      
    //    }
    //}
}
