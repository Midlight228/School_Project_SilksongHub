using Microsoft.AspNetCore.Mvc.Formatters;
using System.ComponentModel.DataAnnotations;

namespace School_Project_SilksongHub.Models
{
    public enum MediaType { Image,Video }
    public class PostMedia
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public Post? Post { get; set; }

        [Required]
        public MediaType Type { get; set; }

        [Required, StringLength(512)]
        public string Url { get; set; } = "";
    }
}
