using Back_End.Models;
using System.ComponentModel.DataAnnotations;

namespace SupplyChain.Data_Transfer_Object_DTOs_
{
    public class ReturnDto
    {
        public int Id { get; set; }
        public string Reason { get; set; }
        public string ReturnStatus { get; set; }
        public List<CustomerEntity>? CustomersList { get; set; } = new List<CustomerEntity>();
    }
}
