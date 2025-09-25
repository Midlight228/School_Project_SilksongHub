using Microsoft.EntityFrameworkCore;
using School_Project_SilksongHub.Models;

namespace School_Project_SilksongHub.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt) { }
        public DbSet<Post> Posts => Set<Post>();
        public DbSet<Tag> Tags => Set<Tag>();
        public DbSet<PostTag> PostTags => Set<PostTag>();
        public DbSet<PostMedia> Media => Set<PostMedia>();
        public DbSet<Comment> Comments => Set<Comment>();
    }
}
