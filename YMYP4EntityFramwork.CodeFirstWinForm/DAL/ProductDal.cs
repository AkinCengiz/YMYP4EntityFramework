using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace YMYP4EntityFramwork.CodeFirstWinForm.DAL;
public class ProductDal
{
	public void Add(Product product)
	{
		using (var _context = new CodeFirstDbContext())
		{
			MessageBox.Show($"1. State : {_context.Entry(product).State}");
			_context.Add(product);
			MessageBox.Show($"2. State : {_context.Entry(product).State}");
			_context.SaveChanges();
			MessageBox.Show($"3. State : {_context.Entry(product).State}");
		}
	}

	public void Add2(Product product)
	{
		using (var _context = new CodeFirstDbContext())
		{
			MessageBox.Show($"1. State : {_context.Entry(product).State}");
			_context.Entry(product).State = EntityState.Added;
			MessageBox.Show($"2. State : {_context.Entry(product).State}");
			_context.SaveChanges();
			MessageBox.Show($"3. State : {_context.Entry(product).State}");
		}
	}

	public List<Product> GetProducts()
	{
		using (var _context = new CodeFirstDbContext())
		{
			var products = _context.Products.ToList();
			products.ForEach(p =>
			{
				var state = _context.Entry(p).State;
				MessageBox.Show($"1. State : {_context.Entry(p).State}");
			});
			return products;
		}
	}

	public void Update()
	{
		using (var _context = new CodeFirstDbContext())
		{
			var product = _context.Products.First();
			//MessageBox.Show($"{product.Name} - {product.Price}");
			MessageBox.Show($"1. State : {_context.Entry(product).State}");
			product.Price = 18500m;
			MessageBox.Show($"2. State : {_context.Entry(product).State}");
			_context.SaveChanges();
			MessageBox.Show($"3. State : {_context.Entry(product).State}");
		}
	}

	public void Update2(Product product)
	{
		using (var _context = new CodeFirstDbContext())
		{
			MessageBox.Show($"1. State : {_context.Entry(product).State}");
			_context.Update(product);
			MessageBox.Show($"2. State : {_context.Entry(product).State}");
			_context.SaveChanges();
			MessageBox.Show($"3. State : {_context.Entry(product).State}");
		}
	}

	public void Update3(int id)
	{
		using (var _context = new CodeFirstDbContext())
		{
			var product = _context.Products.FirstOrDefault(p => p.Id == id);
			MessageBox.Show($"1. State : {_context.Entry(product).State}");
			product.Price = 13500m;
			MessageBox.Show($"2. State : {_context.Entry(product).State}");
			_context.SaveChanges();
			MessageBox.Show($"3. State : {_context.Entry(product).State}");
		}
	}

	public void Update4(int id)
	{
		using (var _context = new CodeFirstDbContext())
		{
			var product = _context.Products.FirstOrDefault(p => p.Id == id);
			MessageBox.Show($"1. State : {_context.Entry(product).State}");
			product.Stock = 17;
			MessageBox.Show($"2. State : {_context.Entry(product).State}");
			_context.Entry(product).State = EntityState.Detached;
			MessageBox.Show($"3. State : {_context.Entry(product).State}");
			_context.SaveChanges();
			MessageBox.Show($"4. State : {_context.Entry(product).State}");
		}
	}

	public void Delete(int id)
	{
		using (var _context = new CodeFirstDbContext())
		{
			var product = _context.Products.FirstOrDefault(p => p.Id == id);
			MessageBox.Show($"1. State : {_context.Entry(product).State}");
			_context.Remove(product);
			MessageBox.Show($"2. State : {_context.Entry(product).State}");
			MessageBox.Show($"Silinecek ürün : {product.Name} - {product.Price}");
			_context.SaveChanges();
			MessageBox.Show($"3. State : {_context.Entry(product).State}");
		}
	}

	public void Delete2(int id)
	{
		using (var _context = new CodeFirstDbContext())
		{
			var product = _context.Products.SingleOrDefault(p => p.Id == id);
			MessageBox.Show($"1. State : {_context.Entry(product).State}");
			_context.Entry(product).State = EntityState.Deleted;
			MessageBox.Show($"2. State : {_context.Entry(product).State}");
			MessageBox.Show($"Silinecek ürün : {product.Name} - {product.Price}");
			_context.SaveChanges();
			MessageBox.Show($"2. State : {_context.Entry(product).State}");
		}
	}
}
