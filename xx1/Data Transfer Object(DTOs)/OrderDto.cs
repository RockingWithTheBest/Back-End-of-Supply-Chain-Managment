using Back_End.Models;
using System.ComponentModel.DataAnnotations;

namespace SupplyChain.Data_Transfer_Object_DTOs_
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string OrderStatus { get; set; }
        public string TaxStatus { get; set; }
        public int Quantity { get; set; }
        public int ProductsId { get; set; }
        public int CustomerId { get; set; }
    }
}
