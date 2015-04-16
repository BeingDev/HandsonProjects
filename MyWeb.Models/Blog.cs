using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace MyWeb.Models
{
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
