
using System.ComponentModel.DataAnnotations;
namespace MyWeb.Models
{
    public class Comment : BaseEntity
    {
        [Key]
        public int CommentId { get; set; }
        
        [Required]
        public string UserName { get; set; }

        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public int PostId { get; set; }
    }
}
