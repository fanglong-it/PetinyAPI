using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetinyAPI.Models
{
    public class Owner
    {
        [Key]
        public int Id { get; set; }
        
        public string? Description { get; set; }

        public string? Date { get; set; }

        public string? Contact { get; set; }


        public string? Request { get; set; }


        public string? UrlImage { get; set; }


        //Key for User
        public int UserId { get; set; }

        [JsonIgnore]
        public User? User { get; set; }


        //Key for Animal
        public int AnimalId { get; set; }

        [JsonIgnore]
        public Animal? Animal { get; set; }


    }
}
