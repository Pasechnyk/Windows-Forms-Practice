using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarCollection
{
    // Task - Create Car Collection App 
    public partial class Form1 : Form
    {
        // classes lists
        List<Car> cars = new List<Car>();
        List<Brand> brands = new List<Brand>();
        List<Model> models = new List<Model>();

        public Form1()
        {
            InitializeComponent();
            LoadBrands();
            LoadModels();
        }

        // load lists
        private void LoadBrands()
        {
            brands.AddRange(new[]
            {
                new Brand() {Name = "Porsche", Country = "Germany"},
                new Brand() {Name = "Tesla", Country = "USA"},
                new Brand() {Name = "Honda", Country = "Japan"},
                new Brand() {Name = "Volvo", Country = "Sweeden"},
                new Brand() {Name = "Mazda", Country = "Japan"}
            });

            UpdateBrandsComboBox();
        }
        private void LoadModels()
        {
            models.AddRange(new[]
            {
                new Model() {Name = "718 Spyder", Price = 1000},
                new Model() {Name = "911 Turbo", Price = 1200},
                new Model() {Name = "718 Cayman", Price = 980},
                new Model() {Name = "718 Boxster", Price = 1300},
                new Model() {Name = "Panamera E-Hybrid", Price = 1250}
            });

            UpdateModelsComboBox();
        }

        // update combo boxes
        public void UpdateBrandsComboBox()
        {
            titleComboBox.DataSource = null;
            titleComboBox.DataSource = brands;
        }

        public void UpdateModelsComboBox()
        {
            modelComboBox.DataSource = null;
            modelComboBox.DataSource = models;
        }
        public void UpdateCarListBox()
        {
            carCollection.DataSource = null;
            carCollection.DataSource = cars;
        }

        // add new car
        private void AddCarBtnClick(object sender, EventArgs e)
        {
            // check for empty space in Combo-boxes
            if (string.IsNullOrWhiteSpace(titleComboBox.Text) ||
                string.IsNullOrWhiteSpace(modelComboBox.Text))
            {
                MessageBox.Show("You haven't chose one or two items from given lists!");
                return;
            }

            cars.Add
                (
                new Car
                {
                    Brand = titleComboBox.Text,
                    Model = modelComboBox.Text,
                    Colour = colourTextBox.Text,
                    Year = (int)yearNumeric.Value,
                    StateNumber = stateNumberMaskedTextBox.Text,
                    VinNumber = vinNumberTextBox.Text
                }
            );

            UpdateCarListBox();
        }

        // remove car 
        private void DeleteCarBtn(object sender, EventArgs e)
        {
            if (carCollection.SelectedItem == null)
            {
                MessageBox.Show("No car was selected to delete!");
                return;
            }

            var car = carCollection.SelectedItem as Car;
            cars.Remove(car);

            UpdateCarListBox();
        }

        // show car information
        private void ShowCarByClueBtn(object sender, EventArgs e)
        {
            if (carComboBox.SelectedItem == null)
            {
                MessageBox.Show("Select a car to show information!");
                return;
            }

            var car = carComboBox.SelectedItem as Car;

            MessageBox.Show($"Brand - {car.Brand}\n" +
                $"Model - {car.Model}\n" +
                $"Colour - {car.Colour}\n" +
				$"Year of Release - {car.Year}\n" +
				$"State Number - {car.StateNumber}\n" +
				$"VIN Number - {car.VinNumber}");
        }
    }
}
