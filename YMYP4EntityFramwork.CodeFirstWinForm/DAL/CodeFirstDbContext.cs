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
	public DbSet<User> Users { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		//optionsBuilder
		//	.UseSqlServer(
		//		@"Data Source=AKINCENGIZ;Initial Catalog=YMYP4CodeFirst;Integrated Security=True;Trust Server Certificate=True;")
		//	.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
		var connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		optionsBuilder.UseSqlServer(connectionString).ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
	}
}
