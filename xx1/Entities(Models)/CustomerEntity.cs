using Back_End.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Back_End.Models
{
    public class CustomerEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        [Required]
        [StringLength(50)]
        public string ShippingAddress { get; set; }
        [Required]
        public int PhoneNumber { get; set; }
        [Required]
        public List<OrderEntity>? OrdersList { get; set; } = new List<OrderEntity>();

        public int? ReturnId {  get; set; }

        //Navigation property
        public virtual ReturnEntity Return{ get; set; }
    }
}
