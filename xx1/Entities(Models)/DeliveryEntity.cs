using SupplyChain.Entities_Models_;
using System.ComponentModel.DataAnnotations;

namespace Back_End.Models
{
    public class DeliveryEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string TrackNumber { get; set; }
        [Required]
        [StringLength(50)]
        public string DeliveryStatus { get; set; }
        [Required]
        [StringLength(50)]
        public DateTime? EstimatedDelivery {  get; set; }
        [Required]
        public int SupplierId { get; set; }
        //Navigation property
        public virtual SupplierEntity Supplier { get; set; }
    }
}
