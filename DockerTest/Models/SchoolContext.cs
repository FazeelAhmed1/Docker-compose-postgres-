using Microsoft.EntityFrameworkCore;

namespace DockerTest.Models
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options) { }
        public DbSet<Models.Student>? Students { get; set; }
    }
}
