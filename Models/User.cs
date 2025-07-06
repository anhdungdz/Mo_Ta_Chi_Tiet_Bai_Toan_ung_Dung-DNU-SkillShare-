using System;
using System.ComponentModel.DataAnnotations;

namespace DashboardDaiNam.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;

        public string? Role { get; set; } = "User";

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? Skill { get; set; } // ✅ Thêm dòng này nếu bạn cần

    }
}