using System.ComponentModel.DataAnnotations;

namespace LoginPageDemo.Models
{
    public class GridItem
    {
        [MaxLength(100)]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        [Required]
        public string Name { get; set; } = null!;
        [MaxLength(100)]
        [Required]
        public string City { get; set; } = null!;
        [MaxLength(100)]
        [Required]
        public int Age { get; set; }
        [MaxLength(100)]
        [Required]
        public string Status { get; set; } = null!;
        [MaxLength(100)]
        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
