namespace WinFormClient
{
	partial class InitForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			btnSearch = new Button();
			textBoxSearch = new TextBox();
			labelSearch = new Label();
			dataGridProducts = new DataGridView();
			buttonNewProduct = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridProducts).BeginInit();
			SuspendLayout();
			// 
			// btnSearch
			// 
			btnSearch.Font = new Font("Segoe UI", 12F);
			btnSearch.Location = new Point(363, 69);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(101, 33);
			btnSearch.TabIndex = 0;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
			// 
			// textBoxSearch
			// 
			textBoxSearch.Font = new Font("Segoe UI", 12F);
			textBoxSearch.Location = new Point(187, 72);
			textBoxSearch.Name = "textBoxSearch";
			textBoxSearch.Size = new Size(161, 29);
			textBoxSearch.TabIndex = 1;
			// 
			// labelSearch
			// 
			labelSearch.AutoSize = true;
			labelSearch.Font = new Font("Segoe UI", 12F);
			labelSearch.Location = new Point(56, 72);
			labelSearch.Name = "labelSearch";
			labelSearch.Size = new Size(125, 21);
			labelSearch.TabIndex = 2;
			labelSearch.Text = "Search Products:";
			// 
			// dataGridProducts
			// 
			dataGridProducts.BackgroundColor = SystemColors.GradientInactiveCaption;
			dataGridProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridProducts.Location = new Point(56, 151);
			dataGridProducts.Name = "dataGridProducts";
			dataGridProducts.Size = new Size(842, 306);
			dataGridProducts.TabIndex = 3;
			dataGridProducts.CellClick += dataGridProducts_CellClick;
			// 
			// buttonNewProduct
			// 
			buttonNewProduct.Font = new Font("Segoe UI", 12F);
			buttonNewProduct.Location = new Point(754, 72);
			buttonNewProduct.Name = "buttonNewProduct";
			buttonNewProduct.Size = new Size(144, 33);
			buttonNewProduct.TabIndex = 4;
			buttonNewProduct.Text = "Add New Product";
			buttonNewProduct.UseVisualStyleBackColor = true;
			buttonNewProduct.Click += buttonNewProduct_Click;
			// 
			// InitForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1004, 561);
			Controls.Add(buttonNewProduct);
			Controls.Add(dataGridProducts);
			Controls.Add(labelSearch);
			Controls.Add(textBoxSearch);
			Controls.Add(btnSearch);
			Name = "InitForm";
			Text = "Test App Client";
			((System.ComponentModel.ISupportInitialize)dataGridProducts).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSearch;
		private TextBox textBoxSearch;
		private Label labelSearch;
		private DataGridView dataGridProducts;
		private Button buttonNewProduct;
	}
}