using SupplyChain.Entities_Models_;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SupplyChain.Data_Transfer_Object_DTOs_
{
    public class CashDto
    {
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [Required]
        public int PaymentId { get; set; }
    }
}
