﻿using System.ComponentModel.DataAnnotations;

namespace SchoolManagementSystem.Models

{
    public class User
    {
        public int UserId { get; set; }

        public string? UserName { get; set; }

        public string? Password { get; set; }

        public string? Email { get; set; }

        public string? CNIC { get; set; }
    }
}
