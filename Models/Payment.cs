using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetinyAPI.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public string? Date { get; set; }

        public double Total { get; set; }

        [JsonIgnore]
        //Key for Order
        public ICollection<Order>? Orders { get; set; }

        public int PaymentMethodId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }


    }
}
