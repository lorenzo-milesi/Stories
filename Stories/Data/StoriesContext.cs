using Microsoft.EntityFrameworkCore;
using Stories.Models;

namespace Stories.Data
{
    public class StoriesContext : DbContext
    {
        public DbSet<Project> Projects { get; set; }

        public StoriesContext(DbContextOptions<StoriesContext> options) : base(options)
        {
        }
    }
}