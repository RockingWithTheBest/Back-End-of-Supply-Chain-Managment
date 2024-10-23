using Back_End.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Back_End.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Precision(10, 2)]
        public decimal Amount { get; set; }

    }
}
