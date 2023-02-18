using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetinyAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        public string? Date { get; set; }

        public double TotalAmount { get; set; }

        //Key for user
        public int UserId { get; set; }

        [JsonIgnore]
        public User? User { get; set; }
     
        //Key for payment
        public int PaymentId { get; set; }

        [JsonIgnore]
        public Payment? Payment { get; set; }




        //key for OderDetail
        public ICollection<OrderDetail>? OrderDetails { get; set; }


    }
}
