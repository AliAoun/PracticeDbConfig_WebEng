using Microsoft.EntityFrameworkCore;
using practiceDB.Model;

namespace practiceDB.Data
{
    public class AppDbContext : DbContext
    {

        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration) 
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }

        public DbSet<TeacherClass> teachers { get; set; }
        public DbSet<CoursesClass> courses { get; set; }   

    }
}
