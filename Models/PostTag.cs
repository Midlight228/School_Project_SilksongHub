using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    [PrimaryKey(nameof(PostId),nameof(TagId))]
    public class PostTag
    {
        public int PostId { get; set; }
        public Post? Post { get; set; }
        
        public int TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}
