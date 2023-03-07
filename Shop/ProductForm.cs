using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Child form - Product management
namespace Shop
{
    public partial class ProductForm : Form
    {
        private List<Country> countries { get; set; }
        public Product Product { get; set; }
        public ProductForm(string type)
        {
            InitializeComponent();
            productLabel.Text = type;
            Product = new Product();
        }

        public ProductForm(string type, Product product)
        {
            InitializeComponent();
            productLabel.Text = type;
            Product = new Product();
            EditInformation(Product);
        }

        // change information
        private void EditInformation(Product product)
        {
            nameTextBox.Text = product.Name;
            priceNumeric.Value = product.Price;
            amountNumeric.Value = product.Amount;
            countryComboBox.Text = product.Country;
            discountNumeric.Value = product.Discount;
        }

        // add new product
        private void RegisterBtnClick(object sender, EventArgs e)
        {
            Product = new Product()
            {
                Name = nameTextBox.Text,
                Price = priceNumeric.Value,
                Country = countryComboBox.Text,
                Amount = (int)amountNumeric.Value,
                Discount = (int)discountNumeric.Value
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // cancel addition
        private void CancelBtnClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
