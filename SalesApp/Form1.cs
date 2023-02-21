using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesApp
{
    public partial class Form1 : Form
    {
        string connectionString = null;
        SqlConnection connection = null;
        SqlDataAdapter adapter = null;
        DataSet set = new DataSet();

        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["SalesManager"].ConnectionString;
            connection = new SqlConnection(connectionString);
        }

        // show sales info
        private void ShowSalesBtnClick(object sender, EventArgs e)
        {
            string cmd = "select * from Sales";
            adapter = new SqlDataAdapter(cmd, connection);  
            
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

            set.Clear();
            dataGridView.DataSource = null;

            adapter.Fill(set);
            dataGridView.DataSource = set.Tables[0];
        }

        // show sellers info
        private void ShowSellersBtnClick(object sender, EventArgs e)
        {
            string cmd = "select * from Sellers";
            adapter = new SqlDataAdapter(cmd, connection);

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

            set.Clear();
            dataGridView.DataSource = null;

            adapter.Fill(set);
            dataGridView.DataSource = set.Tables[0];
        }

        // show customers info
        private void ShowCustomersBtnClick(object sender, EventArgs e)
        {
            string cmd = "select * from Customers";
            adapter = new SqlDataAdapter(cmd, connection);

            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);

            set.Clear();
            dataGridView.DataSource = null;

            adapter.Fill(set);
            dataGridView.DataSource = set.Tables[0];
        }

        // update tables
        private void UpdateBtnClick(object sender, EventArgs e)
        {
            adapter.Update(set);
        }
    }
}
