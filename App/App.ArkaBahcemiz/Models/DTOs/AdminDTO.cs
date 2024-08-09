﻿using System.ComponentModel.DataAnnotations;

namespace App.ArkaBahcemiz.Models.DTOs
{
    public class AdminDTO
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [StringLength(50)]
        public string? PasswordHashed { get; set; }
        [Required]
        public string? AdminRole { get; set; }
    }

}
