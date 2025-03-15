﻿using MayNghien.Infrastructure.Models;
using MiniShop.Commons.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace MiniShop.DTOs.Requests
{
    public class StaffRequest : BaseDto
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name must not exceed 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Date of Birth is required")]
        public DateTime DateOfBirth { get; set; }

        [Range(16, 100, ErrorMessage = "Age must be between 16 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required")]
        public Genders Gender { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [StringLength(500, ErrorMessage = "Address must not exceed 500 characters")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number format")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Role is required")]
        public string Role { get; set; }
    }
}
