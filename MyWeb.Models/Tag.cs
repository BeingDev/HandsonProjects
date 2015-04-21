
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyWeb.Models
{
    [Table("V_Comments")]
    public class Tag : BaseEntity
    {
        [Key]
        public int TagId { get; set; }

        [Required]
        public string TagName { get; set; }

        [Required]
        public string TagDescription { get; set; }

    }
}
