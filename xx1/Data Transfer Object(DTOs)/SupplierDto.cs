using Back_End.Models;
using System.ComponentModel.DataAnnotations;

namespace SupplyChain.Data_Transfer_Object_DTOs_
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? PaymentId { get; set; }
        public int? DeliveryId { get; set; }
        public List<ProductEntity> ProductList { get; set; } = new List<ProductEntity>();
    }
}
