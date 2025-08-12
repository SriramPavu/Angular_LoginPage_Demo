using System.ComponentModel.DataAnnotations;

namespace LoginPageDemo.Models
{
    public class User
    {
        [MaxLength(100)]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Email { get; set; } = null!;
        [MaxLength(100)]
        [Required]
        public string PasswordHash { get; set; } = null!;
        [MaxLength(100)]
        [Required]
        public string FullName { get; set; } = null!;
    }
}
