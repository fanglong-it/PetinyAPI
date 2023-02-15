using System.ComponentModel.DataAnnotations;

namespace PetinyAPI.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }

        public ICollection<OrderDetail>? OrderDetails { get; set; }

        public ICollection<Category>? Categories { get; set; }
    
    }
}
