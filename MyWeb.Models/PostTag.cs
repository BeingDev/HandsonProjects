
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyWeb.Models
{
    [Table("V_PostTag")]
    public class PostTag : BaseEntity
    {
        [Key]
        public int PostTagId { get; set; }

        public int TagId { get; set; }
        public int PostId { get; set; }

    }
}
