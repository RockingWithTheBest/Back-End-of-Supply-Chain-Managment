using Back_End.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SupplyChain.Data_Transfer_Object_DTOs_
{
    public class CustomerDto
    {
        public int Id { get; set; }
        public string FNames { get; set; }
        public string LName { get; set; }
        public string ShippingAddress { get; set; }
        public int PhoneNumber { get; set; }
    }
}
