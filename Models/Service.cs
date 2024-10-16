﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PetinyAPI.Models
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }

        public double Price { get; set; }

        public string? UrlImage { get; set; }

        public Boolean IsCareService { get; set; }

        [JsonIgnore]
        public ICollection<OrderDetail>? OrderDetails { get; set; }

        
        public int CategoryId { get; set; }
        
        [JsonIgnore]
        public Category? Category { get; set; }

        public int ShopId { get; set; }

        [JsonIgnore]
        public Shop? Shop { get; set; }

    }
}
