using Back_End.Models;

namespace xx1.Repository.Interface
{
    public interface IOrder:IDisposable
    {
        IEnumerable<OrderEntity> GetAllOrders();
        OrderEntity GetOrderById(int id);
    }
}
