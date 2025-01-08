using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace YMYP4EntityFramework.DatabaseFirstWF;
public class DbFirstContext : DbContext
{
	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer(@"Data Source=AKINCENGIZ;Initial Catalog=YMYP4-DatabaseFirst;Integrated Security=True;Trust Server Certificate=True;");
		//base.OnConfiguring(optionsBuilder);
	}

	public DbSet<Product> Products { get; set; }
	public DbSet<Category> Categories { get; set; }
}
