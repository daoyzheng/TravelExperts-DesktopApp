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
    public partial class frmPackage : Form
    {
        // FORM-LEVEL VARIABLE
        // Get a list of all package objects from database
        List<Package> packages = PackageDB.GetAllPackages();
        // Get a list of all product_suppliers objects from database
        List<ProductsSupplier> productsSuppliers = ProductsSupplierDB.GetAllProductsSuppliers();
        // Get a list of all products objects from database
        List<Product> products = ProductDB.GetProducts();
        // Get a list of all suppliers objects from database
        List<Supplier> suppliers = SupplierDB.GetSuppliers();



        public frmPackage()
        {
            InitializeComponent();
        }

        private void frmPackage_Load(object sender, EventArgs e)
        {
            // Display a list of Package ids to the package Id combobox
            // Select all pakage ids from the list of package objects
            var pkgIdList = packages.Select(pkg => pkg.PackageId).ToList();
            packageIdComboBox.DataSource = pkgIdList;

            DataGridView dataGridView = new DataGridView();
        }

        private void packageIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the selected PackageID
                int pkgId = (int)packageIdComboBox.SelectedValue;

                // Get the current selected Package Object
                var pkgObj = packages.SingleOrDefault(pkg => pkg.PackageId == pkgId);

                // Display Package object information
                DisplayPkgInfo(pkgObj);

                // Get a list of package product suppliers by package id
                List<PackagesProductsSuppliers> packagesProductsSuppliers =
                    PackagesProductsSuppliersDB.GetPackagesProductsSuppliers(pkgId);

                // Get a list of product_supplier_id 
                var prodSuppList = packagesProductsSuppliers.Select(pps => pps.ProductSupplierId).ToList();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, ex.GetType().ToString());
            }
        }

        // Display package information
        private void DisplayPkgInfo(Package pkgObj)
        {
            pkgNameTextBox.Text = pkgObj.PkgName;
            // Check if incoming data is null
            if (pkgDescTextBox.Text == null)
            {
                pkgDescTextBox.Text = string.Empty;
            }
            else
            {
                pkgDescTextBox.Text = pkgObj.PkgDesc;
            }

            // Check if incoming data is null
            if (pkgObj.PkgAgencyCommission == null)
            {
                pkgAgencyCommissionTextBox.Text = string.Empty;
            }
            else
            {
                pkgAgencyCommissionTextBox.Text = pkgObj.PkgAgencyCommission.ToString();
            }

            pkgBasePriceTextBox.Text = pkgObj.PkgBasePrice.ToString();

            // Check if incoming data is null
            DateTime startDate = pkgObj.PkgStartDate ?? DateTime.MinValue;
            if (startDate == DateTime.MinValue)
            { // if orderObj.OrderDate == null, orderDate = DateTime.MinValue
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgStartDateDateTimePicker.CustomFormat = " "; // Display empty if null
            }
            else
            { // if orderObj.OrderDate is not null
                // Reset format
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgStartDateDateTimePicker.Value = startDate;
            }

            // Check if incoming data is null
            DateTime endDate = pkgObj.PkgEndDate ?? DateTime.MinValue;
            if (endDate == DateTime.MinValue)
            { // if orderObj.OrderDate == null, orderDate = DateTime.MinValue
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgEndDateDateTimePicker.CustomFormat = " "; // Display empty if null
            }
            else
            { // if orderObj.OrderDate is not null
                // Reset format
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgEndDateDateTimePicker.Value = endDate;
            }
        }
    }
}
