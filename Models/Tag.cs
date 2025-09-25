using System.ComponentModel.DataAnnotations;

namespace School_Project_SilksongHub.Models
    public class Tag
    {
        public int Id { get; set; }

        [Required, StringLength(40)]
        public string Name { get; set; } = "";

        public List<PostTag> PostTags { get; set; } = new();
    }
}
