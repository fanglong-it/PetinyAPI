﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetinyAPI.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public string? UrlImage { get; set; }

        public Boolean IsCareService { get; set; }

        public ICollection<Service>? Services { get; set; }
    
    }
}
