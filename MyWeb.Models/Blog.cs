using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MyWeb.Models
{
    [Table("V_Blogs")]
    public class Blog : BaseEntity
    {
        public Blog()
        {
            Owner = new User();
        }
        [Key]
        public int BlogId { get; set; }

        [Required]
        public string BlogName { get; set; }


        public virtual User Owner { get; set; }
    }
}
