using Microsoft.EntityFrameworkCore;
using SchoolManagementSystem.DTO;

namespace SchoolManagementSystem.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        { }
        public DbSet<Student> Student { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<Class> Class { get; set; }

        public DbSet<Subject> Subject { get; set; }

        public DbSet<Timing> Timing { get; set; }

        public DbSet<SubjectType> SubjectType { get; set; }

        public DbSet<Section> Section { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Rider> Rider { get; set; }
  

        public DbSet<User> User { get; set; }
        public DbSet<Dto> Dto{ get; set; }













    }

}