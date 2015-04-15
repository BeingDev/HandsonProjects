
namespace MyWeb.Models
{
    public class Comment : BaseEntity
    {
        public int CommentId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string Content { get; set; }
        public int PostId { get; set; }
    }
}
