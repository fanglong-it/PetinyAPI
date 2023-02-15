using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace PetinyAPI.Models
{
    public class AnimalType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        [JsonIgnore]
        public Animal Animal { get; set; }


    }
}
