using YMYP4EntityFramework.InheritanceWinForm.DAL;

namespace YMYP4EntityFramework.InheritanceWinForm;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//AddData();
		//DataGridTwoEntityFillLinqQueryV1();
		//DataGridTwoEntityFillLinqQueryV2();
		//DataGridThreeEntityFillLinqQueryV1();
		//DataGridThreeEntityFillLinqQueryV2();
		DataGridEntityLeftJoin();
	}


	public void DataGridTwoEntityFillLinqQueryV1()
	{
		using (var _context = new EfInheritanceDbContext())
		{
			var data = _context.Categories
				.Join(_context.Products, c => c.Id, p => p.CategoryId, (c, p) => new
				{
					Category = c.Name,
					Product = p.Name,
					Price = p.Price,
					Stock = p.Stock,
					Description = p.Description
				}).ToList();

			dgvProducts.DataSource = data;
		}
	}

	public void DataGridTwoEntityFillLinqQueryV2()
	{
		using (var _context = new EfInheritanceDbContext())
		{
			var data = (from c in _context.Categories
				join p in _context.Products on c.Id equals p.CategoryId
				select new
				{
					Category = c.Name,
					Product = p.Name,
					Price = p.Price,
					Stock = p.Stock,
					Description = p.Description
				}).ToList();

			dgvProducts.DataSource = data;
		}
	}
	public void DataGridThreeEntityFillLinqQueryV1()
	{
		using (var _context = new EfInheritanceDbContext())
		{
			var data = _context.Categories.Join(_context.Products, c => c.Id, p => p.CategoryId, (c, p) => new { c, p })
				.Join(_context.ProductFeatures, cp => cp.p.Id, pf => pf.ProductId, (cp, pf) => new
				{
					Category = cp.c.Name,
					Product = cp.p.Name,
					Price = cp.p.Price,
					Stock = cp.p.Stock,
					Description = cp.p.Description,
					Color = pf.Color,
					Width = pf.Width,
					Height = pf.Height
				}).ToList();
			dgvProducts.DataSource = data;
		}
	}
	public void DataGridThreeEntityFillLinqQueryV2()
	{
		using (var _context = new EfInheritanceDbContext())
		{
			var data = (from c in _context.Categories
				join p in _context.Products on c.Id equals p.CategoryId
				join pf in _context.ProductFeatures on p.Id equals pf.ProductId
				select new
				{
					Category = c.Name,
					Product = p.Name,
					Price = p.Price,
					Stock = p.Stock,
					Description = p.Description,
					Color = pf.Color,
					Width = pf.Width,
					Height = pf.Height
				}).ToList();
				   dgvProducts.DataSource = data;
		}
	}
	public void DataGridEntityLeftJoin()
	{
		using (var _context = new EfInheritanceDbContext())
		{
			var data = (from c in _context.Categories
					join p in _context.Products on c.Id equals p.CategoryId
						//Eðer kategoriye ait bir product yoksa o categorinin product bilgisini null bir product olarak iþaretle
						into plist from p in plist.DefaultIfEmpty()
					select new
					{
						Category = c.Name,
						Product = p != null ? p.Name : "",
						Price = p != null ? p.Price : 0,
						Stock = p != null ? p.Stock : 0,
						Description = p != null ? p.Description : ""
					}
			).ToList();
			dgvProducts.DataSource = data;
		}
	}

	public void AddData()
	{
		//Employee employee = new()
		//{
		//	FirstName = "Akýn", LastName = "Cengiz", Department = "IT", IdentityNumber = "12345678901", Salary = 5000
		//};
		//Customer customer = new Customer()
		//{
		//	FirstName = "Murat",
		//	LastName = "Karakaya",
		//	IdentityNumber = "98765432101",
		//	Balance = 15000
		//};

		Car car = new()
		{
			Brand = "Togg",
			Color = "Black",
			DoorNumber = 4,
			Length = 2.5m,
			Weight = 1600m
		};
		Bus bus = new()
		{
			Brand = "Ford",
			Color = "White",
			Length = 7m,
			Weight = 12000m,
			GuestCapacity = 40
		};
		using (var _context = new EfInheritanceDbContext())
		{
			_context.Cars.Add(car);
			_context.Buses.Add(bus);
			_context.SaveChanges();
		}
	}
}
