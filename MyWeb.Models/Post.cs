
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyWeb.Models
{
    [Table("V_Posts")]
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
