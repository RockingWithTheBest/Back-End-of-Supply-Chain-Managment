using Back_End.Models;
using Back_End.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using SupplyChain.Entities_Models_;
using xx1.Db;

namespace Back_End.Repositories.Implementation
{
    public class ChequeRepositiory: ICheque
    {
        private readonly ApplicationDBContext _context;
        public ChequeRepositiory(ApplicationDBContext db)
        {
            _context = db;
        }
        public void Dispose()
        {
            _context?.Dispose();
        }

        IEnumerable<ChequeEntity> ICheque.GetAll()
        {
            var cheque = _context.Cheques.ToList();// Ensure this retrieves all records correctly
            return cheque;
        }
    }
}


