namespace YMYP4EntityFramework.InheritanceWinForm;

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
		groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
		SuspendLayout();
		// 
		// groupBox1
		// 
		groupBox1.Controls.Add(dgvProducts);
		groupBox1.Location = new Point(12, 154);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(776, 284);
		groupBox1.TabIndex = 0;
		groupBox1.TabStop = false;
		groupBox1.Text = "groupBox1";
		// 
		// dgvProducts
		// 
		dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgvProducts.Dock = DockStyle.Fill;
		dgvProducts.Location = new Point(3, 19);
		dgvProducts.Name = "dgvProducts";
		dgvProducts.Size = new Size(770, 262);
		dgvProducts.TabIndex = 0;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(groupBox1);
		Name = "Form1";
		Text = "Form1";
		Load += Form1_Load;
		groupBox1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private GroupBox groupBox1;
	private DataGridView dgvProducts;
}
