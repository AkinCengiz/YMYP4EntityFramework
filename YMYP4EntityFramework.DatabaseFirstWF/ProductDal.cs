using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace YMYP4EntityFramework.DatabaseFirstWF;
public class ProductDal
{
	public List<Product> GetProducts()
	{
		using (var _context = new DbFirstContext())
		{
			return _context.Products.ToList();
		}
	}

	public Product GetProductById(int id)
	{
		using (var _context = new DbFirstContext())
		{
			return _context.Set<Product>().FirstOrDefault(p => p.Id == id);
		}
	}
	

	public void Add(Product product)
	{
		using (var _context = new DbFirstContext())
		{
			var addedProduct = _context.Entry(product);
			addedProduct.State = EntityState.Added;
			//_context.Add(product);
			_context.SaveChanges();
		}
	}

	public void Update(Product product)
	{
		using (var _context = new DbFirstContext())
		{
			var updatedProduct = _context.Entry(product);
			updatedProduct.State = EntityState.Modified;
			_context.SaveChanges();
		}
	}

	public void Delete(Product product)
	{
		using (var _context = new DbFirstContext())
		{
			var deletedProduct = _context.Entry(product);
			deletedProduct.State = EntityState.Deleted;
			_context.SaveChanges();
		}
	}
}
