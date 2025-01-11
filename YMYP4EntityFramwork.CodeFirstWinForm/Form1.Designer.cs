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
		btnUpdate4 = new Button();
		btnUpdate3 = new Button();
		btnUpdate2 = new Button();
		btnUpdate = new Button();
		btnAdd2 = new Button();
		btnAdd = new Button();
		btnGetProducts = new Button();
		btnDelete2 = new Button();
		btnDelete = new Button();
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
		groupBox2.Controls.Add(btnDelete2);
		groupBox2.Controls.Add(btnDelete);
		groupBox2.Controls.Add(btnUpdate4);
		groupBox2.Controls.Add(btnUpdate3);
		groupBox2.Controls.Add(btnUpdate2);
		groupBox2.Controls.Add(btnUpdate);
		groupBox2.Controls.Add(btnAdd2);
		groupBox2.Controls.Add(btnAdd);
		groupBox2.Controls.Add(btnGetProducts);
		groupBox2.Location = new Point(15, 12);
		groupBox2.Name = "groupBox2";
		groupBox2.Size = new Size(218, 235);
		groupBox2.TabIndex = 1;
		groupBox2.TabStop = false;
		groupBox2.Text = "groupBox2";
		groupBox2.Enter += groupBox2_Enter;
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
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(736, 540);
		Controls.Add(groupBox2);
		Controls.Add(groupBox1);
		Name = "Form1";
		Text = "Form1";
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
}
