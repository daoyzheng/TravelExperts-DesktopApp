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

        // Form-level variable
        public MainForm mainForm { get; set; }
        public Agent loggedInAgt { get; set; }

        public frmProducts()
        {
            InitializeComponent();
        }

        private void cmbProducts_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtIndex.Text = cmbProducts.SelectedIndex.ToString();
            Product product = new Product();

            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Product> products = new List<Product>();

            // assign suppliers to return of GetSuppliers method call
            products = ProductDB.GetProducts();

            if (cmbProducts.SelectedIndex < 0)
                cmbProducts.SelectedIndex = 0;

            product = products[cmbProducts.SelectedIndex];

            txtProductId.Text = (product.ProductId).ToString();
            txtProductName.Text = product.ProdName;
        }

        private void frmProducts_Load_1(object sender, EventArgs e)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Product> products = new List<Product>();

            // assign suppliers to return of GetSuppliers method call
            products = ProductDB.GetProducts();

            // bind products list to combo box
            cmbProducts.DataSource = products;
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Product> products = new List<Product>();

            // assign suppliers to return of GetSuppliers method call
            products = ProductDB.GetProducts();

            // validate input
            if (Validator.IsPresent(txtProductName))
            {
                // text boxes validated
                // now check that the entered Product Name does not already exist in the database
                foreach (Product prod in products)
                {
                    if (txtProductName.Text != "" && prod.ProdName == txtProductName.Text)
                    {
                        MessageBox.Show("This Product Name already exists in the database.");
                        return;
                    }
                }
                // create Product object to be added
                Product product = new Product();
                product.ProdName = txtProductName.Text;

                int newProductId = ProductDB.AddProduct(product);
                txtId.Text = newProductId.ToString();
                DisplayProducts(cmbProducts.SelectedIndex + 1);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            // create Product object to be deleted
            Product product = new Product();
            product.ProductId = Convert.ToInt32(txtProductId.Text);
            product.ProdName = txtProductName.Text;

            // check if product to be deleted already exists in Products_Suppliers
            // table and if so, the user may not delete it.

            if (ProductDB.IsInProductsSuppliers(product))
            {
                MessageBox.Show("This product is already being used in " +
                    " the Products_Suppliers table and you may not delete it.");
                return;
            }

            bool result = ProductDB.DeleteProduct(product);

            DisplayProducts(cmbProducts.SelectedIndex - 1);
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            // close this form
            this.Close();
        }
        public void DisplayProducts(int sIndex)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Product> products = new List<Product>();

            // track selected index
            // int sIndex = cmbProducts.SelectedIndex;

            // assign suppliers to return of GetSuppliers nethod call
            products = ProductDB.GetProducts();
            // bind suppliers list to combo box
            cmbProducts.DataSource = products;

            cmbProducts.SelectedIndex = sIndex; ;

            txtProductId.Text = (products[sIndex].ProductId).ToString();
            txtProductName.Text = products[sIndex].ProdName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtIndex.Text = cmbProducts.SelectedIndex.ToString();
            Product product = new Product();

            // declare products List variable and instantiate new List<Supplier> object
            List<Product> products = new List<Product>();
            products = ProductDB.GetProducts();
            product = products[cmbProducts.SelectedIndex];

            // check if product to be updated already exists in Products_Suppliers
            // table and if so, the user may not update it.

            if (ProductDB.IsInProductsSuppliers(product))
            {
                MessageBox.Show("This product is already being used in " +
                    " the Products_Suppliers table and you may not update it.");
                return;
            }

            Product newProduct = new Product();
            newProduct.ProductId = Convert.ToInt32(txtProductId.Text);
            newProduct.ProdName = txtProductName.Text;

            bool result = ProductDB.UpdateProduct(product, newProduct);
            DisplayProducts(cmbProducts.SelectedIndex);
        }
    }
}
