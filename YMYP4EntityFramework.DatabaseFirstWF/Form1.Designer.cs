namespace YMYP4EntityFramework.DatabaseFirstWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			dgvProducts = new DataGridView();
			gbxProducts = new GroupBox();
			gbxCategories = new GroupBox();
			dgvCategories = new DataGridView();
			gbxProductPanel = new GroupBox();
			gbxUpdatePanel = new GroupBox();
			btnDelete = new Button();
			nudUpdatePrice = new NumericUpDown();
			btnUpdate = new Button();
			cmbUpdateProducts = new ComboBox();
			nudUpdateStock = new NumericUpDown();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtUpdateProduct = new TextBox();
			label4 = new Label();
			gbxAddProduct = new GroupBox();
			btnAddProduct = new Button();
			cmbCategories = new ComboBox();
			mtxtPrice = new MaskedTextBox();
			nudStock = new NumericUpDown();
			lblCategory = new Label();
			lblPrice = new Label();
			lblStock = new Label();
			txtProductName = new TextBox();
			lblProductName = new Label();
			((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
			gbxProducts.SuspendLayout();
			gbxCategories.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dgvCategories).BeginInit();
			gbxProductPanel.SuspendLayout();
			gbxUpdatePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudUpdatePrice).BeginInit();
			((System.ComponentModel.ISupportInitialize)nudUpdateStock).BeginInit();
			gbxAddProduct.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)nudStock).BeginInit();
			SuspendLayout();
			// 
			// dgvProducts
			// 
			dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvProducts.Dock = DockStyle.Fill;
			dgvProducts.Location = new Point(3, 19);
			dgvProducts.Name = "dgvProducts";
			dgvProducts.Size = new Size(627, 202);
			dgvProducts.TabIndex = 0;
			dgvProducts.CellContentClick += dgvProducts_CellContentClick;
			dgvProducts.CellDoubleClick += dgvProducts_CellDoubleClick;
			// 
			// gbxProducts
			// 
			gbxProducts.Controls.Add(dgvProducts);
			gbxProducts.Location = new Point(6, 222);
			gbxProducts.Name = "gbxProducts";
			gbxProducts.Size = new Size(633, 224);
			gbxProducts.TabIndex = 1;
			gbxProducts.TabStop = false;
			gbxProducts.Text = "Product List";
			// 
			// gbxCategories
			// 
			gbxCategories.Controls.Add(dgvCategories);
			gbxCategories.Location = new Point(15, 12);
			gbxCategories.Name = "gbxCategories";
			gbxCategories.Size = new Size(297, 150);
			gbxCategories.TabIndex = 2;
			gbxCategories.TabStop = false;
			gbxCategories.Text = "Category List";
			// 
			// dgvCategories
			// 
			dgvCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvCategories.Dock = DockStyle.Fill;
			dgvCategories.Location = new Point(3, 19);
			dgvCategories.Name = "dgvCategories";
			dgvCategories.Size = new Size(291, 128);
			dgvCategories.TabIndex = 0;
			// 
			// gbxProductPanel
			// 
			gbxProductPanel.Controls.Add(gbxUpdatePanel);
			gbxProductPanel.Controls.Add(gbxAddProduct);
			gbxProductPanel.Controls.Add(gbxProducts);
			gbxProductPanel.Location = new Point(18, 280);
			gbxProductPanel.Name = "gbxProductPanel";
			gbxProductPanel.Size = new Size(645, 452);
			gbxProductPanel.TabIndex = 3;
			gbxProductPanel.TabStop = false;
			gbxProductPanel.Text = "Product Panel";
			// 
			// gbxUpdatePanel
			// 
			gbxUpdatePanel.Controls.Add(btnDelete);
			gbxUpdatePanel.Controls.Add(nudUpdatePrice);
			gbxUpdatePanel.Controls.Add(btnUpdate);
			gbxUpdatePanel.Controls.Add(cmbUpdateProducts);
			gbxUpdatePanel.Controls.Add(nudUpdateStock);
			gbxUpdatePanel.Controls.Add(label1);
			gbxUpdatePanel.Controls.Add(label2);
			gbxUpdatePanel.Controls.Add(label3);
			gbxUpdatePanel.Controls.Add(txtUpdateProduct);
			gbxUpdatePanel.Controls.Add(label4);
			gbxUpdatePanel.Location = new Point(279, 22);
			gbxUpdatePanel.Name = "gbxUpdatePanel";
			gbxUpdatePanel.Size = new Size(267, 194);
			gbxUpdatePanel.TabIndex = 3;
			gbxUpdatePanel.TabStop = false;
			gbxUpdatePanel.Text = "Update Product";
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(15, 147);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(99, 23);
			btnDelete.TabIndex = 11;
			btnDelete.Text = "Delete Product";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// nudUpdatePrice
			// 
			nudUpdatePrice.DecimalPlaces = 2;
			nudUpdatePrice.Location = new Point(125, 89);
			nudUpdatePrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			nudUpdatePrice.Name = "nudUpdatePrice";
			nudUpdatePrice.Size = new Size(120, 23);
			nudUpdatePrice.TabIndex = 4;
			nudUpdatePrice.TextAlign = HorizontalAlignment.Right;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(124, 147);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(121, 23);
			btnUpdate.TabIndex = 10;
			btnUpdate.Text = "Update Product";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// cmbUpdateProducts
			// 
			cmbUpdateProducts.FormattingEnabled = true;
			cmbUpdateProducts.Location = new Point(124, 118);
			cmbUpdateProducts.Name = "cmbUpdateProducts";
			cmbUpdateProducts.Size = new Size(121, 23);
			cmbUpdateProducts.TabIndex = 9;
			// 
			// nudUpdateStock
			// 
			nudUpdateStock.Location = new Point(124, 59);
			nudUpdateStock.Name = "nudUpdateStock";
			nudUpdateStock.Size = new Size(121, 23);
			nudUpdateStock.TabIndex = 7;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(15, 118);
			label1.Name = "label1";
			label1.Size = new Size(99, 15);
			label1.TabIndex = 6;
			label1.Text = "Category Name : ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(72, 91);
			label2.Name = "label2";
			label2.Size = new Size(42, 15);
			label2.TabIndex = 4;
			label2.Text = "Price : ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(69, 61);
			label3.Name = "label3";
			label3.Size = new Size(45, 15);
			label3.TabIndex = 2;
			label3.Text = "Stock : ";
			// 
			// txtUpdateProduct
			// 
			txtUpdateProduct.Location = new Point(124, 29);
			txtUpdateProduct.Name = "txtUpdateProduct";
			txtUpdateProduct.Size = new Size(121, 23);
			txtUpdateProduct.TabIndex = 1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(21, 32);
			label4.Name = "label4";
			label4.Size = new Size(93, 15);
			label4.TabIndex = 0;
			label4.Text = "Product Name : ";
			// 
			// gbxAddProduct
			// 
			gbxAddProduct.Controls.Add(btnAddProduct);
			gbxAddProduct.Controls.Add(cmbCategories);
			gbxAddProduct.Controls.Add(mtxtPrice);
			gbxAddProduct.Controls.Add(nudStock);
			gbxAddProduct.Controls.Add(lblCategory);
			gbxAddProduct.Controls.Add(lblPrice);
			gbxAddProduct.Controls.Add(lblStock);
			gbxAddProduct.Controls.Add(txtProductName);
			gbxAddProduct.Controls.Add(lblProductName);
			gbxAddProduct.Location = new Point(6, 22);
			gbxAddProduct.Name = "gbxAddProduct";
			gbxAddProduct.Size = new Size(267, 194);
			gbxAddProduct.TabIndex = 2;
			gbxAddProduct.TabStop = false;
			gbxAddProduct.Text = "Add Product";
			// 
			// btnAddProduct
			// 
			btnAddProduct.Location = new Point(124, 147);
			btnAddProduct.Name = "btnAddProduct";
			btnAddProduct.Size = new Size(121, 23);
			btnAddProduct.TabIndex = 10;
			btnAddProduct.Text = "Add Product";
			btnAddProduct.UseVisualStyleBackColor = true;
			btnAddProduct.Click += btnAddProduct_Click;
			// 
			// cmbCategories
			// 
			cmbCategories.FormattingEnabled = true;
			cmbCategories.Location = new Point(124, 118);
			cmbCategories.Name = "cmbCategories";
			cmbCategories.Size = new Size(121, 23);
			cmbCategories.TabIndex = 9;
			// 
			// mtxtPrice
			// 
			mtxtPrice.Location = new Point(124, 88);
			mtxtPrice.Mask = "000000.00";
			mtxtPrice.Name = "mtxtPrice";
			mtxtPrice.Size = new Size(121, 23);
			mtxtPrice.TabIndex = 8;
			mtxtPrice.ValidatingType = typeof(int);
			// 
			// nudStock
			// 
			nudStock.Location = new Point(124, 59);
			nudStock.Name = "nudStock";
			nudStock.Size = new Size(121, 23);
			nudStock.TabIndex = 7;
			// 
			// lblCategory
			// 
			lblCategory.AutoSize = true;
			lblCategory.Location = new Point(15, 118);
			lblCategory.Name = "lblCategory";
			lblCategory.Size = new Size(99, 15);
			lblCategory.TabIndex = 6;
			lblCategory.Text = "Category Name : ";
			// 
			// lblPrice
			// 
			lblPrice.AutoSize = true;
			lblPrice.Location = new Point(72, 91);
			lblPrice.Name = "lblPrice";
			lblPrice.Size = new Size(42, 15);
			lblPrice.TabIndex = 4;
			lblPrice.Text = "Price : ";
			// 
			// lblStock
			// 
			lblStock.AutoSize = true;
			lblStock.Location = new Point(69, 61);
			lblStock.Name = "lblStock";
			lblStock.Size = new Size(45, 15);
			lblStock.TabIndex = 2;
			lblStock.Text = "Stock : ";
			// 
			// txtProductName
			// 
			txtProductName.Location = new Point(124, 29);
			txtProductName.Name = "txtProductName";
			txtProductName.Size = new Size(121, 23);
			txtProductName.TabIndex = 1;
			// 
			// lblProductName
			// 
			lblProductName.AutoSize = true;
			lblProductName.Location = new Point(21, 32);
			lblProductName.Name = "lblProductName";
			lblProductName.Size = new Size(93, 15);
			lblProductName.TabIndex = 0;
			lblProductName.Text = "Product Name : ";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1040, 744);
			Controls.Add(gbxProductPanel);
			Controls.Add(gbxCategories);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
			gbxProducts.ResumeLayout(false);
			gbxCategories.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dgvCategories).EndInit();
			gbxProductPanel.ResumeLayout(false);
			gbxUpdatePanel.ResumeLayout(false);
			gbxUpdatePanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudUpdatePrice).EndInit();
			((System.ComponentModel.ISupportInitialize)nudUpdateStock).EndInit();
			gbxAddProduct.ResumeLayout(false);
			gbxAddProduct.PerformLayout();
			((System.ComponentModel.ISupportInitialize)nudStock).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dgvProducts;
		private GroupBox gbxProducts;
		private GroupBox gbxCategories;
		private DataGridView dgvCategories;
		private GroupBox gbxProductPanel;
		private GroupBox gbxAddProduct;
		private TextBox txtProductName;
		private Label lblProductName;
		private Button btnAddProduct;
		private ComboBox cmbCategories;
		private MaskedTextBox mtxtPrice;
		private NumericUpDown nudStock;
		private Label lblCategory;
		private Label lblPrice;
		private Label lblStock;
		private GroupBox gbxUpdatePanel;
		private Button btnUpdate;
		private ComboBox cmbUpdateProducts;
		private NumericUpDown nudUpdateStock;
		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox txtUpdateProduct;
		private Label label4;
		private NumericUpDown nudUpdatePrice;
		private Button btnDelete;
	}
}
