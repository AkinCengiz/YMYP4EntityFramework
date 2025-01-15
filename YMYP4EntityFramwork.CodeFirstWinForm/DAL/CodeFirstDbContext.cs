using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace YMYP4EntityFramwork.CodeFirstWinForm.DAL;
public class CodeFirstDbContext : DbContext
{
	public DbSet<Product> Products { get; set; }
	//public DbSet<User> Users { get; set; }
	public DbSet<Category> Categories { get; set; }
	public DbSet<ProductFeature> ProductFeatures { get; set; }
	//public DbSet<Deneme> Denemes { get; set; }
	//public DbSet<Author> Authors { get; set; }
	//public DbSet<Book> Books { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		//optionsBuilder
		//	.UseSqlServer(
		//		@"Data Source=AKINCENGIZ;Initial Catalog=YMYP4CodeFirst;Integrated Security=True;Trust Server Certificate=True;")
		//	.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
		var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString).ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
	}
	
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		//modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category)
		//	.HasForeignKey(p => p.CategoryId);
		modelBuilder.Entity<Category>().HasMany(c => c.Products).WithOne(p => p.Category)
			.HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.NoAction);
		modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(30);
		modelBuilder.Entity<Product>().HasKey(p => p.Id);
		modelBuilder.Entity<Product>().Property(p => p.Stock).HasDefaultValue(0);
		modelBuilder.Entity<Product>().Property(p => p.Price).HasPrecision(9, 2);
		modelBuilder.Entity<Product>().HasOne(p => p.ProductFeature).WithOne(p => p.Product)
			.HasForeignKey<ProductFeature>(p => p.ProductId).OnDelete(DeleteBehavior.NoAction);
		base.OnModelCreating(modelBuilder);

		


		//SEED DATA
		//Category Seed Data
		modelBuilder.Entity<Category>().HasData(
			new Category{Id = 1,Name = "Bilgisayar"},
			new Category{Id = 2,Name = "Cep Telefonu"},
			new Category{Id = 3, Name = "Televizyon"}
		);
		//Product Seed Data
		modelBuilder.Entity<Product>().HasData(
			new Product(){Id = 1,Name="Toshiba Laptop", Price = 15000,Stock = 11,Description = "Core I7 9900 16Gb ram 8Gb Ekran Kartı",CategoryId = 1},
			new Product() { Id = 2, Name = "HP Laptop", Price = 13000, Stock = 14, Description = "Core I5 9800 16Gb ram 4Gb Ekran Kartı", CategoryId = 1 },
			new Product() { Id = 3, Name = "Casper Desktop", Price = 10000, Stock = 7, Description = "Core I3 9900 8Gb ram 8Gb Ekran Kartı", CategoryId = 1 },
			new Product() { Id = 4, Name = "Lenovo Desktop", Price = 13000, Stock = 9, Description = "Core I5 9000 8Gb ram 8Gb Ekran Kartı", CategoryId = 1 },
			new Product() { Id = 5, Name = "IPhone 15", Price = 15000, Stock = 17, Description = "256Gb Hafıza", CategoryId = 2 },
			new Product() { Id = 6, Name = "Samsung S20", Price = 14000, Stock = 19, Description = "512Gb Hafıza", CategoryId = 2 },
			new Product() { Id = 7, Name = "LG Televizyon", Price = 12500, Stock = 5, Description = "55\"", CategoryId = 3 }
		);

		var denemList = new List<Deneme>();
		for (int i = 1; i <= 100; i++)
		{
			denemList.Add(new Deneme() { Id = i, Name = $"Name - {i}", Description = $"Description - {i}" });
		}
		modelBuilder.Entity<Deneme>().HasData(denemList);

	}
}


/*
 *
 *var category = new Category() { Id = 5, Name = "Deneme" };
   category.Products.Add(new Product()
   {
   
   });
   
   var product = new Product()
   {
   	Id = 1, Category = category, Name = "Pc500", Stock = 15, Price = 22000
   };
 */