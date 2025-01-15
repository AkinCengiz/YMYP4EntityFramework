using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

	//EAGER LOADING
	public List<Product> GetFullInfos()
	{
		using (var _context = new CodeFirstDbContext())
		{
			var products = _context.Products.Include(p => p.Category).Include(p => p.ProductFeature).ToList();
			//var products = _context.Products.ToList();
			return products;
		}
	}

	public List<ProductFeature> GetFullCategories()
	{
		using (var _contex = new CodeFirstDbContext())
		{
			var productFeature = _contex.ProductFeatures.Include(p => p.Product).ThenInclude(p => p.Category).ToList();
			return productFeature;
		}
	}
	//EXPLICIT LOADING

	public Category GetCategory()
	{
		using (var _context = new CodeFirstDbContext())
		{
			var category = _context.Categories.First();

			return category;
		}
	}

	//LAZY LOADING
	public Product GetProduct()
	{
		using (var _context = new CodeFirstDbContext())
		{
			//Lazy loading her ilişkili entiti arasında gezmek istenildiğinde veritabanına sorgu gönderir.
			//1. SQL Sorgusu yapıldı
			var category = _context.Categories.First();
			//2. SQL Sorgusu
			var product = category.Products.First();
			//3. SQL Sorgusu
			var pFeature = product.ProductFeature;

			return product;
		}
	}
	public List<object> ExplicitLoading(Category category)
	{
		using (var _context = new CodeFirstDbContext())
		{
			_context.Entry(category).Collection(c => c.Products).Load();
			
			List<object> products = new List<object>();
			foreach (var cp in category.Products)
			{
				var product = new
				{
					Name = cp.Name,
					Price = cp.Price,
					Stock = cp.Stock,
					Category = cp.Category.Name,
					Description = cp.Description
				};
				products.Add(product);
			}

			return products;
		}
	}
	public Product ProductExplicitLoading()
	{
		using (var _context = new CodeFirstDbContext())
		{
			var product = _context.Products.First();
			_context.Entry(product).Reference(p => p.ProductFeature).Load();
			return product;
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
