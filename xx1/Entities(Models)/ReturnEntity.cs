using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End.Models
{
    public class ReturnEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Reason { get; set; }
        [Required]
        [StringLength(50)]
        public string ReturnStatus { get; set; }
        [Required]
        public List<CustomerEntity>? CustomersList { get; set; } = new List<CustomerEntity>();
        public int? ProductId { get; set; }

        //Navigation Property
        public ProductEntity Product { get; set; }
    }
}
