using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mvc_10._01._2024.Models;

namespace mvc_10._01._2024.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<mvc_10._01._2024.Models.Task> Tasks { get; set; }
        public DbSet<mvc_10._01._2024.Models.User> Users { get; set; }
        public DbSet<mvc_10._01._2024.Models.Comment> Comments { get; set; }
        public DbSet<mvc_10._01._2024.Models.Project> Projects { get; set; }
    }
}