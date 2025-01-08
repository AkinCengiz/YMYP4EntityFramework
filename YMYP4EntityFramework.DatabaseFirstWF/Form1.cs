using Microsoft.EntityFrameworkCore;

namespace YMYP4EntityFramework.DatabaseFirstWF
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private ProductDal _productDal = new ProductDal();
		private Product _selectedProduct;

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadControls();

			//var context = new DbFirstContext();
			//var x = context.Products.ToList();
			//dgvProducts.DataSource = x;
		}

		public void LoadControls()
		{
			var products = _productDal.GetProducts();
			dgvProducts.DataSource = products;
			using (var _context = new DbFirstContext())
			{
				var categories = _context.Categories.ToList();
				dgvCategories.DataSource = categories;
				cmbCategories.DataSource = categories;
				cmbCategories.ValueMember = "Id";
				cmbCategories.DisplayMember = "Name";
				cmbUpdateProducts.DataSource = categories;
				cmbUpdateProducts.ValueMember = "Id";
				cmbUpdateProducts.DisplayMember = "Name";
			}

			_selectedProduct = null;
		}

		private void btnAddProduct_Click(object sender, EventArgs e)
		{
			Product product = new Product();
			product.Name = txtProductName.Text;
			product.Price = Convert.ToDecimal(mtxtPrice.Text);
			product.Stock = Convert.ToInt16(nudStock.Value);
			product.CategoryId = Convert.ToInt32(cmbCategories.SelectedValue);
			//MessageBox.Show($"{product.Name} - {product.CategoryId}");
			_productDal.Add(product);
			LoadControls();
		}

		private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			_selectedProduct = _productDal.GetProductById(Convert.ToInt32(dgvProducts.CurrentRow.Cells["Id"].Value));
			//MessageBox.Show($"{_selectedProduct.Name}");
			txtUpdateProduct.Text = _selectedProduct.Name;
			nudUpdateStock.Value = _selectedProduct.Stock;
			nudUpdatePrice.Value = _selectedProduct.Price;
			cmbUpdateProducts.SelectedValue = _selectedProduct.CategoryId;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			_selectedProduct.Name = txtUpdateProduct.Text;
			_selectedProduct.Stock = Convert.ToInt16(nudUpdateStock.Value);
			_selectedProduct.Price = Convert.ToDecimal(nudUpdatePrice.Value);
			_selectedProduct.CategoryId = Convert.ToInt32(cmbUpdateProducts.SelectedValue);
			_productDal.Update(_selectedProduct);
			LoadControls();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (_selectedProduct != null)
			{
				_productDal.Delete(_selectedProduct);
			}
			LoadControls();
		}
	}
}
