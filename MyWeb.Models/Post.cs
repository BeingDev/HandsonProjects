
using System.ComponentModel.DataAnnotations;
namespace MyWeb.Models
{
    public class Post : BaseEntity
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        public int BlogId { get; set; }

        [Required, MaxLength(100), MinLength(10)]
        public string Title { get; set; }

        [Required, MaxLength(3000), MinLength(10)]
        public string Body { get; set; }

    }
}
