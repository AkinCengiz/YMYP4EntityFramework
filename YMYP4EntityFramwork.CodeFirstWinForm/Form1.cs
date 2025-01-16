using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using YMYP4EntityFramwork.CodeFirstWinForm.DAL;

namespace YMYP4EntityFramwork.CodeFirstWinForm;

public partial class Form1 : Form
{
	public Form1()
	{
		InitializeComponent();
	}

	private ProductDal _productDal = new ProductDal();
	private void groupBox2_Enter(object sender, EventArgs e)
	{

	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		Product product = new Product()
		{
			Name = "Dell Laptop",
			Stock = 7,
			Price = 13000m,
			Description = "Core I5 iþlemcili 4Gb Ekran Kartý 8 Gb Ram"
		};
		_productDal.Add(product);
	}

	private void btnAdd2_Click(object sender, EventArgs e)
	{
		Product product = new Product()
		{
			Name = "Lenovo Desktop",
			Stock = 9,
			Price = 10000m,
			Description = "Core I3 iþlemcili 4Gb Ekran Kartý 16 Gb Ram"
		};
		_productDal.Add2(product);
	}

	private void btnGetProducts_Click(object sender, EventArgs e)
	{
		var products = _productDal.GetProducts();
		dgvProducts.DataSource = products;
	}

	private void btnUpdate_Click(object sender, EventArgs e)
	{
		_productDal.Update();
	}

	private void btnUpdate2_Click(object sender, EventArgs e)
	{
		Product product = new Product()
		{
			Id = 4,
			Name = "Lenovo Desktop",
			Stock = 3,
			Price = 11000m,
			Description = "Core I3 iþlemcili 4Gb Ekran Kartý 16 Gb Ram"
		};
		_productDal.Update2(product);
	}

	private void btnUpdate3_Click(object sender, EventArgs e)
	{
		_productDal.Update3(3);
	}

	private void btnUpdate4_Click(object sender, EventArgs e)
	{
		_productDal.Update4(4);
	}

	private void btnDelete_Click(object sender, EventArgs e)
	{
		_productDal.Delete(6);
	}

	private void btnDelete2_Click(object sender, EventArgs e)
	{
		_productDal.Delete2(5);
	}

	private void getFull_Click(object sender, EventArgs e)
	{
		var products = _productDal.GetFullInfos();
		products.ForEach(p =>
			{
				string message = $"Name : {p.Name} - Price : {p.Price} - Category : {p.Category.Name}";
				MessageBox.Show(message);
			}
			);
	}

	private void btnFullCategories_Click(object sender, EventArgs e)
	{
		var productFeatures = _productDal.GetFullCategories();
		List<object> products = new List<object>();
		productFeatures.ForEach(p =>
		{
			var product = new
			{
				Name = p.Product.Name,
				Price = p.Product.Price,
				Stock = p.Product.Stock,
				Category = p.Product.Category.Name,
				Color = p.Color,
				Height = p.Height,
				Width = p.Width
			};
			products.Add(product);
		});
		dgvProducts.DataSource = products;

	}

	private void btnExplicit_Click(object sender, EventArgs e)
	{
		var category = _productDal.GetCategory();
		MessageBox.Show($"Id : {category.Id} - Name : {category.Name} - Products : {category.Products}");


		DgvProductFill(category);
	}

	public void DgvProductFill(Category category)
	{
		dgvProducts.DataSource = _productDal.ExplicitLoading(category);
	}

	private void btnProductMessage_Click(object sender, EventArgs e)
	{
		var product = _productDal.ProductExplicitLoading();
		MessageBox.Show($"Name : {product.Name} - Price : {product.Price} - Color : {product.ProductFeature.Color}");
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//Product product = new Product();
		//var cName = product.Category.Name;
	}

	private void btnLazyProduct_Click(object sender, EventArgs e)
	{
		var product = _productDal.GetProduct();
		MessageBox.Show($"Name : {product.Name} - Price : {product.Price} Category : {product.Category.Name}");
	}
}
