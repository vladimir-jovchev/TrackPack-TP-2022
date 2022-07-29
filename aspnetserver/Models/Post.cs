using System.ComponentModel.DataAnnotations;

namespace aspnetserver.Models
{
    internal sealed class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string CustomerName { get; set; } = string.Empty;
        [Required]
        //public string Email { get; set; } = string.Empty;
        public string FromCountry { get; set; } = string.Empty;
        [Required]
        public string ToCountry { get; set; } = string.Empty;
        [Required]
        public string PostalCode { get; set; } = string.Empty;
        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MaxLength(100000)]
        public string Content { get; set; } = string.Empty;
        public double Price { get; set; }
        public string CurrentLocation { get; set; } = string.Empty;
    }
}