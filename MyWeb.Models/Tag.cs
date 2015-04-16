
using System.ComponentModel.DataAnnotations;
namespace MyWeb.Models
{
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
