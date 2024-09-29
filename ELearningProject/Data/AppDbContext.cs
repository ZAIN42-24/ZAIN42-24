namespace ELearningProject.Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {


        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Course> courses { get; set; }
        public DbSet<Course_Review> reviews { get; set; }
        public DbSet<Enrolment> enrolments { get; set; }
        public DbSet<Instructor> instructors { get; set; }
        public DbSet<Lesson> lessons { get; set; }
        public DbSet<Module> modules { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Student_Lesson> Student_Lessons { get; set; }
        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
