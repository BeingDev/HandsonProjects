
using System.ComponentModel.DataAnnotations;
namespace MyWeb.Models
{
    public class PostTag : BaseEntity
    {
        [Key]
        public int PostTagId { get; set; }

        public int TagId { get; set; }
        public int PostId { get; set; }

    }
}
