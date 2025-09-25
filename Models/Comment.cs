namespace School_Project_SilksongHub.Models
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        public int PostId { get; set; }

        public Post? Post { get; set; }

        [Required, StringLength(2000)]
        public string Text { get; set; } = "";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }
    }

}