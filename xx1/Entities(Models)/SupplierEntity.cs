using SupplyChain.Entities_Models_;
using System.ComponentModel.DataAnnotations;

namespace Back_End.Models
{
    public class SupplierEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        public List<ProductEntity> ProductList { get; set; } = new List<ProductEntity>();
     
    }
}
