using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupplyChain.Entities_Models_
{
    public class ChequeEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Details { get; set; }

        
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Amount { get; set; }
        [Required]
        public int PaymentId { get; set; }

        //Navigation Property
        public virtual PaymentEntity Payment { get; set; }
    }
}
