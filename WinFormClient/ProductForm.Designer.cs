namespace WinFormClient
{
	partial class ProductForm
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
			textBoxName = new TextBox();
			textBoxDesc = new TextBox();
			btnSave = new Button();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			numericUpDownPrice = new NumericUpDown();
			numericUpDownQuantity = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
			SuspendLayout();
			// 
			// textBoxName
			// 
			textBoxName.Font = new Font("Segoe UI", 12F);
			textBoxName.Location = new Point(191, 89);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(159, 29);
			textBoxName.TabIndex = 0;
			// 
			// textBoxDesc
			// 
			textBoxDesc.Font = new Font("Segoe UI", 12F);
			textBoxDesc.Location = new Point(191, 132);
			textBoxDesc.Name = "textBoxDesc";
			textBoxDesc.Size = new Size(159, 29);
			textBoxDesc.TabIndex = 1;
			// 
			// btnSave
			// 
			btnSave.Font = new Font("Segoe UI", 12F);
			btnSave.Location = new Point(205, 268);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(134, 38);
			btnSave.TabIndex = 4;
			btnSave.Text = "button";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(133, 92);
			label1.Name = "label1";
			label1.Size = new Size(55, 21);
			label1.TabIndex = 5;
			label1.Text = "Name:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 12F);
			label2.Location = new Point(96, 135);
			label2.Name = "label2";
			label2.Size = new Size(92, 21);
			label2.TabIndex = 6;
			label2.Text = "Description:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F);
			label3.Location = new Point(133, 176);
			label3.Name = "label3";
			label3.Size = new Size(47, 21);
			label3.TabIndex = 7;
			label3.Text = "Price:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 12F);
			label4.Location = new Point(115, 216);
			label4.Name = "label4";
			label4.Size = new Size(73, 21);
			label4.TabIndex = 8;
			label4.Text = "Quantity:";
			// 
			// numericUpDownPrice
			// 
			numericUpDownPrice.Font = new Font("Segoe UI", 12F);
			numericUpDownPrice.Location = new Point(191, 174);
			numericUpDownPrice.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
			numericUpDownPrice.Name = "numericUpDownPrice";
			numericUpDownPrice.Size = new Size(159, 29);
			numericUpDownPrice.TabIndex = 9;
			// 
			// numericUpDownQuantity
			// 
			numericUpDownQuantity.Font = new Font("Segoe UI", 12F);
			numericUpDownQuantity.Location = new Point(193, 216);
			numericUpDownQuantity.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			numericUpDownQuantity.Name = "numericUpDownQuantity";
			numericUpDownQuantity.Size = new Size(157, 29);
			numericUpDownQuantity.TabIndex = 10;
			// 
			// ProductForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(542, 391);
			Controls.Add(numericUpDownQuantity);
			Controls.Add(numericUpDownPrice);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnSave);
			Controls.Add(textBoxDesc);
			Controls.Add(textBoxName);
			Name = "ProductForm";
			Text = "ProductForm";
			Load += ProductForm_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBoxName;
		private TextBox textBoxDesc;
		private Button btnSave;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private NumericUpDown numericUpDownPrice;
		private NumericUpDown numericUpDownQuantity;
	}
}