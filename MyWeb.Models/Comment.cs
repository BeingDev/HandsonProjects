
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyWeb.Models
{
    [Table("V_Comments")]
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
