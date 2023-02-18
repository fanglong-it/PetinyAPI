﻿using System.ComponentModel.DataAnnotations;

namespace PetinyAPI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }

        public string? UrlImage { get; set; }

        public string? Phone { get; set; }


        public ICollection<Order>? Orders { get; set; }

        public ICollection<Owner>? Owner { get; set; }


    }
}
