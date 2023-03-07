using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Task - Create Product Shop Manager using parent and child form
namespace Shop
{
    public partial class ManagerForm : Form
    {
        private List<Product> products = new List<Product>();
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = products;
        }

        // add new product
        private void AddNewBtnClick(object sender, EventArgs e)
        {
            ProductForm form = new ProductForm("Add Product");

            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                products.Add(form.Product);
                UpdateList();
            }
        }

        // edit product information
        private void EditBtnClick(object sender, EventArgs e)
        {
            var product = listBox1.SelectedItem as Product;
            ProductForm form = new ProductForm("Edit Product");

            form.ShowDialog();
            UpdateList();
        }

        // show product information
        private void ShowInfoBtnClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("No products were selected!");
                return;
            }

            var product = listBox1.SelectedItem as Product;

            MessageBox.Show($"Name - {product.Name}\n" +
                $"Price - {product.Price}\n" +
                $"Country - {product.Country}\n" +
                $"Amount - {product.Amount}\n" +
                $"Discount - {product.Discount}");
        }

        // remove product form list
        private void Removebtnclick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("No products were selected!");
                return;
            }

            var product = listBox1.SelectedItem as Product;
            products.Remove(product);

            UpdateList();
        }
    }
}
