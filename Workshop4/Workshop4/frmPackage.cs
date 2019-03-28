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
    public partial class frmPackage : Form {
        // FORM-LEVEL VARIABLE
        // Get a list of all Package objects from database
        List<Package> packages = PackageDB.GetAllPackages();
        // Get a list of all Product_Suppliers objects from database
        List<ProductsSupplier> productsSuppliers = ProductsSupplierDB.GetAllProductsSuppliers();
        // Get a list of all Products objects from database
        List<Product> products = ProductDB.GetProducts();
        // Get a list of all Suppliers objects from database
        List<Supplier> suppliers = SupplierDB.GetSuppliers();
        // Get a list of all Package_Product_Suppliers by package id
        List<PackagesProductsSuppliers> pkgProdSupps = 
            PackagesProductsSuppliersDB.GetAllPackagesProductsSuppliers();
        

        public frmPackage() {
            InitializeComponent();
        }

        private void frmPackage_Load(object sender, EventArgs e) {
            // Display a list of Package ids to the package Id combobox
            // Select all pakage ids from the list of package objects
            //var pkgIdList = packages.Select(pkg => pkg.PackageId).ToList();
            //packageIdComboBox.DataSource = pkgIdList;

            pkgNameComboBox.DisplayMember = "PkgName";
            pkgNameComboBox.ValueMember = "PackageId";
            pkgNameComboBox.DataSource = packages;
        }

        private void pkgNameComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                // Get the selected PackageID
                int pkgId = (int)pkgNameComboBox.SelectedValue;

                // Get the current selected Package Object
                var pkgObj = packages.SingleOrDefault(pkg => pkg.PackageId == pkgId);

                // Display Package object information
                DisplayPkgInfo(pkgObj);

                // Get Package_Product_Supplier by package id
                var pkgProdSuppList = pkgProdSupps.Where(pps => pps.PackageId == pkgId);

                // Join Package_Product_Suppliers table with Product_Suppliers table and 
                // Products table and Suppliers table
                var prodSuppTable = from pkgProdSupp in pkgProdSuppList
                                         join prodSupp in productsSuppliers
                                         on pkgProdSupp.ProductSupplierId equals prodSupp.ProductSupplierId
                                         join prod in products
                                         on prodSupp.ProductId equals prod.ProductId
                                         join supp in suppliers
                                         on prodSupp.SupplierId equals supp.SupplierId
                                         select new {
                                            prodSupp.ProductSupplierId,   
                                            prod.ProdName,
                                            supp.SupName
                                         };

                // Assign from the prodSuppTable to a list of DummyProductsSupplier objects
                List<DummyProductsSupplier> dummyProductsSuppliers = new List<DummyProductsSupplier>();
                foreach (var prod in prodSuppTable) {
                    DummyProductsSupplier dummyProductsSupplier = new DummyProductsSupplier();
                    dummyProductsSupplier.ProductSupplierId = prod.ProductSupplierId;
                    dummyProductsSupplier.ProdName = prod.ProdName;
                    dummyProductsSupplier.SuppName = prod.SupName;
                    dummyProductsSuppliers.Add(dummyProductsSupplier);
                }

                // Assign DummyProdSupps to datagridview
                dummyProductsSupplierDataGridView.DataSource = dummyProductsSuppliers;

                // Load Product Supplier Id textbox with the first default product supplier id,
                // if there is any
                var prodSuppId = prodSuppTable.FirstOrDefault().ProductSupplierId;
                productSupplierIdTextBox.Text = prodSuppId.ToString();

                DisplayProdNameSuppName(prodSuppId);

            } catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message, ex.GetType().ToString());
            }
        }

        // Display Product name and Supplier name in textbox
        private void DisplayProdNameSuppName(int prodSuppId) {

            ProductsSupplier productsSupplier = ProductsSupplierDB.GetProductsSupplierByProductSupplierId(prodSuppId);

            // find the Product and Supplier object 
            var product = products.SingleOrDefault(p => p.ProductId == productsSupplier.ProductId);
            var supplier = suppliers.SingleOrDefault(s => s.SupplierId == productsSupplier.SupplierId);

            // Load the Product and Supplier text box
            prodNameTextBox.Text = product.ProdName;
            supNameTextBox.Text = supplier.SupName;
        }

        // Display package information
        private void DisplayPkgInfo(Package pkgObj) {
            // Check if incoming data is null
            if (pkgDescTextBox.Text == null) {
                pkgDescTextBox.Text = string.Empty;
            }else {
                pkgDescTextBox.Text = pkgObj.PkgDesc;
            }

            // Check if incoming data is null
            if (pkgObj.PkgAgencyCommission == null) {
                pkgAgencyCommissionTextBox.Text = string.Empty;
            } else {
                pkgAgencyCommissionTextBox.Text = pkgObj.PkgAgencyCommission.ToString();
            }

            pkgBasePriceTextBox.Text = pkgObj.PkgBasePrice.ToString();

            // Check if incoming data is null
            DateTime startDate = pkgObj.PkgStartDate ?? DateTime.MinValue;
            if (startDate == DateTime.MinValue) { // if orderObj.OrderDate == null, orderDate = DateTime.MinValue
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgStartDateDateTimePicker.CustomFormat = " "; // Display empty if null
            } else { // if orderObj.OrderDate is not null
                // Reset format
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgStartDateDateTimePicker.Value = startDate;
            }

            // Check if incoming data is null
            DateTime endDate = pkgObj.PkgEndDate ?? DateTime.MinValue;
            if (endDate == DateTime.MinValue) { // if orderObj.OrderDate == null, orderDate = DateTime.MinValue
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgEndDateDateTimePicker.CustomFormat = " "; // Display empty if null
            } else { // if orderObj.OrderDate is not null
                // Reset format
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgEndDateDateTimePicker.Value = endDate;
            }
        }

        // Change Products Suppliers id textbox when cell is clicked
        private void dummyProductsSupplierDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            // If row is empty, don't select, if row is not empty, select the product supplier id
            if (dummyProductsSupplierDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) {

                // When a single cell is seleted, it will select the whole row
                dummyProductsSupplierDataGridView.CurrentRow.Selected = true;
                int psId = (int)dummyProductsSupplierDataGridView.Rows[e.RowIndex].Cells[0].Value;
                productSupplierIdTextBox.Text = psId.ToString();
                DisplayProdNameSuppName(psId);
            }
        }
    }
}
