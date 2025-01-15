namespace YMYP4EntityFramwork.CodeFirstWinForm;

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
		groupBox1 = new GroupBox();
		dgvProducts = new DataGridView();
		groupBox2 = new GroupBox();
		btnProductMessage = new Button();
		btnExplicit = new Button();
		btnDelete2 = new Button();
		btnDelete = new Button();
		getFull = new Button();
		btnUpdate4 = new Button();
		btnUpdate3 = new Button();
		btnUpdate2 = new Button();
		btnUpdate = new Button();
		btnAdd2 = new Button();
		btnAdd = new Button();
		btnGetProducts = new Button();
		btnFullCategories = new Button();
		btnLazyProduct = new Button();
		groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
		groupBox2.SuspendLayout();
		SuspendLayout();
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(dgvProducts);
		groupBox1.Location = new Point(12, 253);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(712, 275);
		groupBox1.TabIndex = 0;
		groupBox1.TabStop = false;
		groupBox1.Text = "groupBox1";
		// 
		// dgvProducts
		// 
		dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvProducts.Dock = DockStyle.Fill;
		dgvProducts.Location = new Point(3, 19);
		dgvProducts.Name = "dgvProducts";
		dgvProducts.Size = new Size(706, 253);
		dgvProducts.TabIndex = 0;
		// 
		// groupBox2
		// 
		groupBox2.Controls.Add(btnLazyProduct);
		groupBox2.Controls.Add(btnProductMessage);
		groupBox2.Controls.Add(btnExplicit);
		groupBox2.Controls.Add(btnDelete2);
		groupBox2.Controls.Add(btnDelete);
		groupBox2.Controls.Add(getFull);
		groupBox2.Controls.Add(btnUpdate4);
		groupBox2.Controls.Add(btnUpdate3);
		groupBox2.Controls.Add(btnUpdate2);
		groupBox2.Controls.Add(btnUpdate);
		groupBox2.Controls.Add(btnAdd2);
		groupBox2.Controls.Add(btnAdd);
		groupBox2.Controls.Add(btnGetProducts);
		groupBox2.Location = new Point(15, 12);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(439, 235);
		groupBox2.TabIndex = 1;
		groupBox2.TabStop = false;
		groupBox2.Text = "groupBox2";
		groupBox2.Enter += groupBox2_Enter;
		// 
		// btnProductMessage
		// 
		btnProductMessage.Location = new Point(218, 138);
		btnProductMessage.Name = "btnProductMessage";
		btnProductMessage.Size = new Size(206, 23);
		btnProductMessage.TabIndex = 11;
		btnProductMessage.Text = "Explicit Product Message";
		btnProductMessage.UseVisualStyleBackColor = true;
		btnProductMessage.Click += btnProductMessage_Click;
		// 
		// btnExplicit
		// 
		btnExplicit.Location = new Point(218, 109);
		btnExplicit.Name = "btnExplicit";
		btnExplicit.Size = new Size(206, 23);
		btnExplicit.TabIndex = 10;
		btnExplicit.Text = "Explicit Loading";
		btnExplicit.UseVisualStyleBackColor = true;
		btnExplicit.Click += btnExplicit_Click;
		// 
		// btnDelete2
		// 
		btnDelete2.Location = new Point(115, 80);
		btnDelete2.Name = "btnDelete2";
		btnDelete2.Size = new Size(97, 23);
		btnDelete2.TabIndex = 8;
		btnDelete2.Text = "DELETE 2";
		btnDelete2.UseVisualStyleBackColor = true;
		btnDelete2.Click += btnDelete2_Click;
		// 
		// btnDelete
		// 
		btnDelete.Location = new Point(115, 51);
		btnDelete.Name = "btnDelete";
		btnDelete.Size = new Size(97, 23);
		btnDelete.TabIndex = 7;
		btnDelete.Text = "DELETE";
		btnDelete.UseVisualStyleBackColor = true;
		btnDelete.Click += btnDelete_Click;
		// 
		// getFull
		// 
		getFull.Location = new Point(218, 51);
		getFull.Name = "getFull";
		getFull.Size = new Size(206, 23);
		getFull.TabIndex = 9;
		getFull.Text = "Get Products Full Info";
		getFull.UseVisualStyleBackColor = true;
		getFull.Click += getFull_Click;
		// 
		// btnUpdate4
		// 
		btnUpdate4.Location = new Point(115, 138);
		btnUpdate4.Name = "btnUpdate4";
		btnUpdate4.Size = new Size(97, 23);
		btnUpdate4.TabIndex = 6;
		btnUpdate4.Text = "UPDATE 4";
		btnUpdate4.UseVisualStyleBackColor = true;
		btnUpdate4.Click += btnUpdate4_Click;
		// 
		// btnUpdate3
		// 
		btnUpdate3.Location = new Point(115, 109);
		btnUpdate3.Name = "btnUpdate3";
		btnUpdate3.Size = new Size(97, 23);
		btnUpdate3.TabIndex = 5;
		btnUpdate3.Text = "UPDATE 3";
		btnUpdate3.UseVisualStyleBackColor = true;
		btnUpdate3.Click += btnUpdate3_Click;
		// 
		// btnUpdate2
		// 
		btnUpdate2.Location = new Point(6, 138);
		btnUpdate2.Name = "btnUpdate2";
		btnUpdate2.Size = new Size(97, 23);
		btnUpdate2.TabIndex = 4;
		btnUpdate2.Text = "UPDATE 2";
		btnUpdate2.UseVisualStyleBackColor = true;
		btnUpdate2.Click += btnUpdate2_Click;
		// 
		// btnUpdate
		// 
		btnUpdate.Location = new Point(6, 109);
		btnUpdate.Name = "btnUpdate";
		btnUpdate.Size = new Size(97, 23);
		btnUpdate.TabIndex = 3;
		btnUpdate.Text = "UPDATE";
		btnUpdate.UseVisualStyleBackColor = true;
		btnUpdate.Click += btnUpdate_Click;
		// 
		// btnAdd2
		// 
		btnAdd2.Location = new Point(6, 80);
		btnAdd2.Name = "btnAdd2";
		btnAdd2.Size = new Size(97, 23);
		btnAdd2.TabIndex = 2;
		btnAdd2.Text = "ADD - 2";
		btnAdd2.UseVisualStyleBackColor = true;
		btnAdd2.Click += btnAdd2_Click;
		// 
		// btnAdd
		// 
		btnAdd.Location = new Point(6, 51);
		btnAdd.Name = "btnAdd";
		btnAdd.Size = new Size(97, 23);
		btnAdd.TabIndex = 1;
		btnAdd.Text = "ADD";
		btnAdd.UseVisualStyleBackColor = true;
		btnAdd.Click += btnAdd_Click;
		// 
		// btnGetProducts
		// 
		btnGetProducts.Location = new Point(6, 22);
		btnGetProducts.Name = "btnGetProducts";
		btnGetProducts.Size = new Size(97, 23);
		btnGetProducts.TabIndex = 0;
		btnGetProducts.Text = "Get Products";
		btnGetProducts.UseVisualStyleBackColor = true;
		btnGetProducts.Click += btnGetProducts_Click;
		// 
		// btnFullCategories
		// 
		btnFullCategories.Location = new Point(233, 92);
		btnFullCategories.Name = "btnFullCategories";
		btnFullCategories.Size = new Size(206, 23);
		btnFullCategories.TabIndex = 10;
		btnFullCategories.Text = "Get Categories Full Info";
		btnFullCategories.UseVisualStyleBackColor = true;
		btnFullCategories.Click += btnFullCategories_Click;
		// 
		// btnLazyProduct
		// 
		btnLazyProduct.Location = new Point(115, 22);
		btnLazyProduct.Name = "btnLazyProduct";
		btnLazyProduct.Size = new Size(97, 23);
		btnLazyProduct.TabIndex = 12;
		btnLazyProduct.Text = "Get Product Lazy";
		btnLazyProduct.UseVisualStyleBackColor = true;
		btnLazyProduct.Click += btnLazyProduct_Click;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(736, 540);
		Controls.Add(btnFullCategories);
		Controls.Add(groupBox2);
		Controls.Add(groupBox1);
		Name = "Form1";
		Text = "Form1";
		Load += Form1_Load;
		groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
		groupBox2.ResumeLayout(false);
		ResumeLayout(false);
	}

	#endregion

	private GroupBox groupBox1;
	private DataGridView dgvProducts;
	private GroupBox groupBox2;
	private Button btnUpdate2;
	private Button btnUpdate;
	private Button btnAdd2;
	private Button btnAdd;
	private Button btnGetProducts;
	private Button btnUpdate3;
	private Button btnUpdate4;
	private Button btnDelete2;
	private Button btnDelete;
	private Button getFull;
	private Button btnFullCategories;
	private Button btnExplicit;
	private Button btnProductMessage;
	private Button btnLazyProduct;
}
