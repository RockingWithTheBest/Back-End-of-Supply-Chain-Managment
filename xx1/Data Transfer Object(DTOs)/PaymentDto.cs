using Back_End.Models;
using SupplyChain.Entities_Models_;
using System.ComponentModel.DataAnnotations;

namespace SupplyChain.Data_Transfer_Object_DTOs_
{
    public class PaymentDto
    {
        public int Id { get; set; }
        public int? ChequeId { get; set; }
        public int? CashId { get; set; }
        public int SupplierId { get; set; }
    }
}
