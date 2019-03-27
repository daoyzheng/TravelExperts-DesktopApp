using ClassEntites;
using DBAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop4 {
    public partial class frmProducts : Form {
        public frmProducts()
        {
            InitializeComponent();
        }



        private void cmbProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Product product = new Product();

            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Product> products = new List<Product>();

            // assign suppliers to return of GetSuppliers nmethod call
            products = ProductDB.GetProducts();

            // bind suppliers list to combo box
            // cmbSuppliers.DataSource = suppliers;

            product = products[cmbProducts.SelectedIndex];

            txtProductId.Text = (product.ProductId).ToString();
            txtProductName.Text = product.ProdName;
        }

        private void frmProducts_Load_1(object sender, EventArgs e)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Product> products = new List<Product>();

            // assign suppliers to return of GetSuppliers nethod call
            products = ProductDB.GetProducts();

            // bind products list to combo box
            cmbProducts.DataSource = products;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Product> products = new List<Product>();

            // assign suppliers to return of GetSuppliers nethod call
            products = ProductDB.GetProducts();

            // validate input
            if (Validator.IsPresent(txtProductName))
            {
                // text boxes validated
                // now check that the entered Supplier Id does not already exist in the database
                foreach (Product prod in products)
                {
                    if (txtProductId.Text != "" && prod.ProductId == Convert.ToInt32(txtProductId.Text))
                    {
                        MessageBox.Show("Supplier Id already exists in database");
                        return;
                    }
                }
                // create Product object to be added
                Product product = new Product();
                product.ProductId = Convert.ToInt32(txtProductId.Text);
                product.ProdName = txtProductName.Text;

                int newProductId = ProductDB.AddProduct(product);
                DisplayProducts();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // create Supplier object to be deleted
            Product product = new Product();
            product.ProductId = Convert.ToInt32(txtProductId.Text);
            product.ProdName = txtProductName.Text;

            bool result = ProductDB.DeleteProduct(product);

            DisplayProducts();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // close this form
            this.Close();
        }
        public void DisplayProducts()
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Product> products = new List<Product>();
            Product product = new Product();

            // track selected index
            int sIndex = cmbProducts.SelectedIndex;

            // assign suppliers to return of GetSuppliers nethod call
            products = ProductDB.GetProducts();
            // bind suppliers list to combo box
            cmbProducts.DataSource = products;

            cmbProducts.SelectedIndex = sIndex - 1;

            txtProductId.Text = (product.ProductId).ToString();
            txtProductName.Text = product.ProdName;

        }

    }
}
