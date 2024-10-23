using SupplyChain.Entities_Models_;
using SupplyChain.Repository.Interface;
using xx1.Db;

namespace SupplyChain.Repository.Implementation
{
    public class CashRepository : ICash
    {
        public ApplicationDBContext _context;
        public CashRepository(ApplicationDBContext cb) 
        {
            _context = cb;
        }
        public void Dispose()
        {
            _context?.Dispose();
        }

        IEnumerable<CashEntity> ICash.GetAll()
        {
            var cash = _context.Cash.ToList();
            return cash;
        }
    }
}
