using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetinyAPI.Models
{
    public class OrderDetail
    {

        [Key]
        public int Id { get; set; }
        
        public string? Description { get; set; }
        
        public double Price { get; set; }

        public int Qty { get; set; }


        //Key for Order
        public int OrderId { get; set; }
        [JsonIgnore]
        public Order? Order { get; set; }


        //Key for Service
        public int ServiceId { get; set; }
        [JsonIgnore]
        public Service? Service { get; set; }

    }
}
