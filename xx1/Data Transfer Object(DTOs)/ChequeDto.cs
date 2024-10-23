using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SupplyChain.Data_Transfer_Object_DTOs_
{
    public class ChequeDto
    {
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }

        [Required]
        public string Details { get; set; }

        [Required]
        public int PaymentId { get; set; }
    }
}
