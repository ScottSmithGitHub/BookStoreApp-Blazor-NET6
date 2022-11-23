﻿using System.ComponentModel.DataAnnotations;

namespace BookstoreApp.API.Models.User
{
    public class UserDto : LoginUserDto
    {
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Role { get; set; }
    }
}