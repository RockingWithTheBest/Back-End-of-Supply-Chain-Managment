using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End.Models
{
    public class ProductEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Brand { get; set; }
        public string? Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        [Required]
        public int StockQuantity { get; set; }

        [Required]
        public int SupplierId {  get; set; }
        public virtual SupplierEntity? Supplier { get; set; }
    }
}