using SupplyChain.Entities_Models_;

namespace SupplyChain.Repository.Interface
{
    public interface ICash:IDisposable
    {
        IEnumerable<CashEntity> GetAll();
    }
}
