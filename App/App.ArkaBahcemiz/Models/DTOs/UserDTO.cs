﻿using System.ComponentModel.DataAnnotations;

namespace App.ArkaBahcemiz.Models.DTOs
{
    public class UserDTO 
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? Name { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        [StringLength(50)]
        public string? Password { get; set; }
    }
}
