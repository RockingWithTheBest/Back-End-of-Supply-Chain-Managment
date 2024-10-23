using Back_End.Models;
using SupplyChain.Entities_Models_;

namespace Back_End.Repositories.Interfaces
{
    public interface ICheque:IDisposable
    {
        IEnumerable<ChequeEntity> GetAll();
    }
}
