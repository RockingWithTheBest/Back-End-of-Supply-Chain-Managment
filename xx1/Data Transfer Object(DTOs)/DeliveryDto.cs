using Back_End.Models;
using System.ComponentModel.DataAnnotations;

namespace SupplyChain.Data_Transfer_Object_DTOs_
{
    public class DeliveryDto
    {
        public int Id { get; set; }
        public string TrackNumber { get; set; }
        public string DeliveryStatus { get; set; }
        public int SupplierId { get; set; }
    }
}
