
namespace MyWeb.Models
{
    public class Blog : BaseEntity
    {
        public int BlogId { get; set; }
        public int BlogName { get; set; }
        public int OwnerId { get; set; }
    }
}
