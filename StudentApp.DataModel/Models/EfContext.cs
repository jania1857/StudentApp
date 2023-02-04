using Microsoft.EntityFrameworkCore;

namespace StudentApp.DataModel.Models
{
	public class EfContext : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Course> Courses { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			var connectionString = @"Data Source=localhost;Initial Catalog=studentdb2;Integrated Security=True;TrustServerCertificate=True";

			optionsBuilder.UseSqlServer(connectionString);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Course>()
				.HasMany(s => s.Students)
				.WithOne(c => c.Course)
				.HasForeignKey(c => c.CourseId);
		}
	}
}
