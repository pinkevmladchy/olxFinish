﻿using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entity
{
    public class UserAdditionalInfo
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string City { get; set; }
        public virtual User User { get; set; }

    }
}