﻿namespace FestivalManagementSystem.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }
    }
}