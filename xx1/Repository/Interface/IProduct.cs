using Back_End.Models;
using SupplyChain.Data_Transfer_Object_DTOs_;

namespace SupplyChain.Repository.Interface
{
    public interface IProduct:IDisposable
    {
        IEnumerable<ProductEntity> GetAllProducts();
        IEnumerable<ProductEntity> GetProductByDescription(string description);
        ProductEntity GetProductById(int id);
        int AddProduct(ProductEntity product);
        int UpdateSingleProduct(ProductEntity product);
        int DeleteProduct(int id);
    }
}
