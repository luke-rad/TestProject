using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using Domain.Entities;
using System.Text.Json;
using System.Net.Http.Json;

namespace WinFormClient
{
	public partial class InitForm : Form
	{
		private static readonly HttpClient _httpClient = new HttpClient();
		private readonly string baseUrl = "http://localhost:5151/api/Product";
		JsonSerializerOptions options = new JsonSerializerOptions
		{
			PropertyNameCaseInsensitive = true,
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase
		};

		public InitForm()
		{
			InitializeComponent();
			this.Load += InitForm_Load;

		}

		private void AddEditAndDeleteButtons()
		{
			DataGridViewButtonColumn editButtonColumn = new DataGridViewButtonColumn();
			editButtonColumn.Name = "Edit";
			editButtonColumn.HeaderText = "";
			editButtonColumn.Text = "Edit";
			editButtonColumn.UseColumnTextForButtonValue = true;

			DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
			deleteButtonColumn.Name = "Delete";
			deleteButtonColumn.HeaderText = "";
			deleteButtonColumn.Text = "Delete";
			deleteButtonColumn.UseColumnTextForButtonValue = true;

			dataGridProducts.Columns.Add(editButtonColumn);
			dataGridProducts.Columns.Add(deleteButtonColumn);
		}

		private async void InitForm_Load(object? sender, EventArgs e)
		{
			await FetchData();
			AddEditAndDeleteButtons();

		}

		private async Task FetchData()
		{

			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(baseUrl);

				if (response.IsSuccessStatusCode)
				{
					string jsonResponse = await response.Content.ReadAsStringAsync();

					List<Product>? products = JsonSerializer.Deserialize<List<Product>>(jsonResponse, options);

					dataGridProducts.DataSource = products;

				}
				else
				{
					MessageBox.Show("Error: Unable to retrieve products");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
			}
		}

		private async void btnSearch_Click(object sender, EventArgs e)
		{
			string keyword = textBoxSearch.Text;
			string apiUrl = baseUrl + "/?name=" + keyword;

			HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

			if (response.IsSuccessStatusCode)
			{
				string jsonResponse = await response.Content.ReadAsStringAsync();


				List<Product>? products = JsonSerializer.Deserialize<List<Product>>(jsonResponse, options);

				dataGridProducts.DataSource = products;
			}
			else
			{
				MessageBox.Show("Error: Unable to retrieve products");
			}

		}

		private void dataGridProducts_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				if (dataGridProducts.Columns[e.ColumnIndex].Name == "Edit")
				{
					var product = (Product)dataGridProducts.Rows[e.RowIndex].DataBoundItem;

					EditProduct(product);
				}
				else if (dataGridProducts.Columns[e.ColumnIndex].Name == "Delete")
				{
					var product = (Product)dataGridProducts.Rows[e.RowIndex].DataBoundItem;

					var result = MessageBox.Show($"Are you sure you want to delete {product.ProductName}?", "Confirm Deletion", MessageBoxButtons.YesNo);
					if (result == DialogResult.Yes)
					{
						DeleteProduct(product);
					}
				}
			}
		}

		private async void DeleteProduct(Product product)
		{
			string apiUrl = baseUrl + "/" + product.ProductId;

			HttpResponseMessage response = await _httpClient.DeleteAsync(apiUrl);

			if (response.IsSuccessStatusCode)
			{
				MessageBox.Show("Product deleted successfully!");
				await FetchData(); 
			}
			else
			{
				MessageBox.Show("Error: Unable to delete the product.");
			}
		}

		private async void EditProduct(Product product)
		{
			var productForm = new ProductForm(product);

			if (productForm.ShowDialog() == DialogResult.OK)
			{
				var updatedProduct = productForm.SelectedProduct;

				var response = await _httpClient.PutAsJsonAsync(baseUrl, updatedProduct);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Product updated successfully!");
					await FetchData();
				}
				else
				{
					MessageBox.Show("Error: Unable to update product");
				}
			}

			productForm.Dispose();
		}

		private async void buttonNewProduct_Click(object sender, EventArgs e)
		{
			var newProductForm = new ProductForm();

			if (newProductForm.ShowDialog() == DialogResult.OK)
			{
				var product = newProductForm.SelectedProduct;

				var response = await _httpClient.PostAsJsonAsync(baseUrl, product);

				if (response.IsSuccessStatusCode)
				{
					MessageBox.Show("Product added successfully!");
					await FetchData();
				}
				else
				{
					MessageBox.Show("Error: Unable to add product");
				}
			}

			newProductForm.Dispose();

		}
	}
}
