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
}
