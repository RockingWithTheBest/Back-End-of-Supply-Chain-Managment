using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Back_End.Models;

namespace SupplyChain.Entities_Models_
{
    public class PaymentEntity
    {
        [Key]
        public int Id { get; set; }
        public int? ChequeId { get; set; }
        public int? CashId { get; set; }
        
        [Required]
        public int SupplierId { get; set; } 

        //Navigation property
        public virtual ChequeEntity Cheque { get; set; }
        public virtual CashEntity Cash { get; set; }
        public virtual SupplierEntity Supplier { get; set; }
    }
}
