using System.ComponentModel.DataAnnotations;

namespace PetinyAPI.Models
{
    public class Shop
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
        public double Rate { get; set; }
        public string? Description { get; set; }
        public string? Longtidute { get; set; }
        public string? Latidute { get; set; }

        public string? UrlImage { get; set; }

        public ICollection<Service>? Services { get; set; }


    }
}
