using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormClient
{
	public partial class ProductForm : Form
	{
		public Product? SelectedProduct { get; private set; }

		public ProductForm(Product? selectedProduct = null)
		{
			InitializeComponent();
			if (selectedProduct != null)
			{
				SelectedProduct = selectedProduct;
				textBoxName.Text = selectedProduct.ProductName;
				textBoxDesc.Text = selectedProduct.Description;
				numericUpDownPrice.Value = selectedProduct.Price;
				numericUpDownQuantity.Value = selectedProduct.StockQuantity;
				btnSave.Text = "Update Product";
			}
			else
			{
				btnSave.Text = "Add Product";
			}
		}

		private void ProductForm_Load(object sender, EventArgs e)
		{

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxDesc.Text))
			{
				MessageBox.Show("Product name and description is required.");
				return;
			}

			if (numericUpDownPrice.Value <= 0)
			{
				MessageBox.Show("Price must be greater than 0.");
				return;
			}

			if (numericUpDownQuantity.Value < 0)
			{
				MessageBox.Show("Quantity cannot be negative.");
				return;
			}

			if (SelectedProduct == null)
			{
				SelectedProduct = new Product
				{
					ProductName = textBoxName.Text,
					Description = textBoxDesc.Text,
					Price = numericUpDownPrice.Value,
					StockQuantity = (int)numericUpDownQuantity.Value
				};
			}
			else
			{
				SelectedProduct.ProductName = textBoxName.Text;
				SelectedProduct.Description = textBoxDesc.Text;
				SelectedProduct.Price = numericUpDownPrice.Value; 
				SelectedProduct.StockQuantity = (int)numericUpDownQuantity.Value;
			}

			this.DialogResult = DialogResult.OK;

			this.Close();

		}
	}
}
