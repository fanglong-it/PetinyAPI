using System.ComponentModel.DataAnnotations;

namespace PetinyAPI.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public string Date { get; set; }

        public double Total { get; set; }
        
        //Key for Order
        public Order Order { get; set; }


        public int PaymentMethodId { get; set; }
        public PaymentMethod? PaymentMethod { get; set; }


    }
}
