using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required, StringLength(240)]
        public string Title { get; set; } = "";

        [StringLength(4000)]
        public string? Content { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // nav
        public List<PostTag> PostTags { get; set; } = new();
        public List<PostMedia> Media { get; set; } = new();



    }
}
