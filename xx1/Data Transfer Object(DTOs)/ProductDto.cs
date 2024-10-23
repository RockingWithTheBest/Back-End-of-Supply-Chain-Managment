using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SupplyChain.Data_Transfer_Object_DTOs_
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string? Description { get; set; }
        [Required]
        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public int SupplierId { get; set; }
    }
}
