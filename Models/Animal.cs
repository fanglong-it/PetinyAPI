﻿using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace PetinyAPI.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string DateOfBirth { get; set; }

        public string Age { get; set; }
        public string? Description { get; set; }

        public int AnimalTypeId { get; set; }

        public AnimalType? AnimalType { get; set; }

        public ICollection<Owner>? Owners { get; set; }
    
    }
}
