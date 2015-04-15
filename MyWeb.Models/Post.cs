
namespace MyWeb.Models
{
    public class Post : BaseEntity
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
