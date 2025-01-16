using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace YMYP4EntityFramework.InheritanceWinForm.DAL;
public class EfInheritanceDbContext : DbContext
{
	public DbSet<Author> Authors { get; set; }
	public DbSet<Book> Books { get; set; }
	public DbSet<AuthorBook> AuthorBooks { get; set; }
	public DbSet<Product> Products { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<ProductFeature> ProductFeatures { get; set; }
	public DbSet<Employee> Employees { get; set; }
	public DbSet<Customer> Customers { get; set; }
	public DbSet<Person> Persons { get; set; }
	public DbSet<Mammal> Mammals { get; set; }
	public DbSet<Bird> Birds { get; set; }
	public DbSet<Vehicle> Vehicles { get; set; }
	public DbSet<Car> Cars { get; set; }
	public DbSet<Bus> Buses { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Data Source=AKINCENGIZ; Initial Catalog=YMYP4EFInheritanceDb;Integrated Security=True;Trust Server Certificate=True;");
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
		modelBuilder.Entity<Bus>().ToTable("Buses");
		modelBuilder.Entity<Car>().ToTable("Cars");
		modelBuilder.Entity<AuthorBook>().HasKey(ab => new
		{
			ab.AuthorId, ab.BookId
		});
		modelBuilder.Entity<AuthorBook>().HasOne<Author>().WithMany().HasForeignKey(ab => ab.AuthorId);
		modelBuilder.Entity<AuthorBook>().HasOne<Book>().WithMany().HasForeignKey(ab => ab.BookId);
		modelBuilder.Entity<Category>().HasMany<Product>().WithOne().HasForeignKey(p => p.CategoryId);
		modelBuilder.Entity<Product>().HasOne<ProductFeature>().WithOne()
			.HasForeignKey<ProductFeature>(pf => pf.ProductId);
	}
}

/*
 * modelBuilder.Entity<StudentCourse>() .HasKey(sc => new { sc.StudentId, sc.CourseId }); modelBuilder.Entity<StudentCourse>() .HasOne(sc => sc.Student) .WithMany(s => s.StudentCourses) .HasForeignKey(sc => sc.StudentId); modelBuilder.Entity<StudentCourse>() .HasOne(sc => sc.Course) .WithMany(c => c.StudentCourses) .HasForeignKey(sc => sc.CourseId);
 *
 * modelBuilder.Entity<StudentCourse>() .HasOne<Student>() .WithMany() .HasForeignKey(sc => sc.StudentId); modelBuilder.Entity<StudentCourse>() .HasOne<Course>() .WithMany() .HasForeignKey(sc => sc.CourseId);
 */