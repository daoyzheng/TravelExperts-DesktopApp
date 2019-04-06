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
        List<Package> packageList = PackageDB.GetAllPackages();
        // Get a list of all Product_Suppliers objects from database
        List<ProductsSupplier> prodSuppList = ProductsSupplierDB.GetAllProductsSuppliers();
        // Get a list of all Products objects from database
        List<Product> productsList = ProductDB.GetProducts();
        // Get a list of all Suppliers objects from database
        List<Supplier> suppliersList = SupplierDB.GetSuppliers();
        // Get a list of all Package_Product_Suppliers by package id
        List<PackagesProductsSuppliers> pkgProdSuppList = 
            PackagesProductsSuppliersDB.GetPackagesProductsSuppliers();

        public frmPackage() {
            InitializeComponent();
        }

        private void frmPackage_Load(object sender, EventArgs e) {
            // Display a list of Package ids to the package Id combobox
            pkgNameComboBox.DisplayMember = "PkgName";
            pkgNameComboBox.ValueMember = "PackageId";
            pkgNameComboBox.DataSource = packageList;
        }

        private void pkgNameComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (pkgNameComboBox.DataSource != null) {
                // Get Selected Package ID
                int pkgId = (int)pkgNameComboBox.SelectedValue;

                // Get Selected Package Object from a list of all packages
                Package pkgObj = packageList.SingleOrDefault(p => p.PackageId == pkgId);

                // Display Package information
                DisplayPkg(pkgObj);

                // Get associated product supplier
                var pkgProductSupplier = pkgProdSuppList.Where(pps => pps.PackageId == pkgId).ToList();

                // Join the product supplier table to products table and supplier table
                var productSupplierTable = from pps in pkgProductSupplier
                                join ps in prodSuppList
                                on pps.ProductSupplierId equals ps.ProductSupplierId
                                join p in productsList
                                on ps.ProductId equals p.ProductId
                                join s in suppliersList
                                on ps.SupplierId equals s.SupplierId
                                select new ProductSupplierViewModel {
                                    ProductSupplierId = ps.ProductSupplierId,
                                    ProdName = p.ProdName,
                                    SuppName = s.SupName
                                };

                var productSupplierViewModel = productSupplierTable.ToList();

                // Bind List to data grid
                productSupplierViewModelDataGridView.DataSource = productSupplierViewModel;
            }
        }

        private void DisplayPkg (Package pkgObj) {
            DateTime startDate = pkgObj.PkgStartDate ?? DateTime.MinValue;
            if (DateTime.Compare(startDate,DateTime.MinValue) == 0) {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgStartDateDateTimePicker.CustomFormat = " ";
            } else {
                pkgStartDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgStartDateDateTimePicker.Value = startDate;
            }

            DateTime endDate = pkgObj.PkgEndDate ?? DateTime.MinValue;
            if (DateTime.Compare(endDate,DateTime.MinValue) == 0) {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Custom;
                pkgEndDateDateTimePicker.CustomFormat = " ";
            } else {
                pkgEndDateDateTimePicker.Format = DateTimePickerFormat.Long;
                pkgEndDateDateTimePicker.Value = endDate;
            }

            pkgBasePriceTextBox.Text = pkgObj.PkgBasePrice.ToString("c");

            decimal commission = pkgObj.PkgAgencyCommission ?? -1;
            if (commission == -1) {
                pkgAgencyCommissionTextBox.Text = pkgObj.PkgAgencyCommission.ToString();
            } else {
                pkgAgencyCommissionTextBox.Text = commission.ToString("c");
            }

            pkgDescTextBox.Text = pkgObj.PkgDesc;

        }

        private void btnAddPkg_Click(object sender, EventArgs e) {
            frmAddPackages frmAddPackages = new frmAddPackages();
            frmAddPackages.products = productsList;
            frmAddPackages.suppliers = suppliersList;
            frmAddPackages.packages = packageList;
            frmAddPackages.pkgProdSupps = pkgProdSuppList;
            DialogResult result = frmAddPackages.ShowDialog();
            if (result == DialogResult.OK) {
                if (frmAddPackages.PkgInserted == true) {
                    packageList.Add(frmAddPackages.Package);
                }

                if (frmAddPackages.ProdSuppInserted == true) {
                    prodSuppList.Add(frmAddPackages.productsSupplier);
                }

                pkgProdSuppList.Add(frmAddPackages.pkgProdSupp);

                // Reload Combo box
                refreshComboBox();

                // Select the Last index
                int index = packageList.Count() - 1;
                pkgNameComboBox.SelectedIndex = index;
            }
        }

        private void btnUpdatePkg_Click(object sender, EventArgs e) {
            // Get Selected Package Id
            int pkgId = (int)pkgNameComboBox.SelectedValue;

            // Get Selected Package Object
            Package selectedPkg = packageList.SingleOrDefault(p => p.PackageId == pkgId);

            // Get Data from datagridview
            int prodSuppId = (int)productSupplierViewModelDataGridView.CurrentRow.Cells[0].Value;
            var selectedProdSupp = prodSuppList.SingleOrDefault(ps => ps.ProductSupplierId == prodSuppId);

            var selectedPkgProdSupp = pkgProdSuppList.SingleOrDefault(pps => pps.ProductSupplierId == prodSuppId &&
                                                                    pps.PackageId == pkgId);

            frmUpdatePackages frmUpdatePackages = new frmUpdatePackages();
            // Assign reference to update form
            frmUpdatePackages.SelectedPackage = selectedPkg;
            frmUpdatePackages.SelectedProductsSupplier = selectedProdSupp;
            frmUpdatePackages.SelectedPkgProdSupp = selectedPkgProdSupp;

            // Assign list of all tables to update form
            frmUpdatePackages.Products = productsList;
            frmUpdatePackages.Suppliers = suppliersList;
            frmUpdatePackages.Packages = packageList;
            frmUpdatePackages.PkgProdSupps = pkgProdSuppList;

            DialogResult result = frmUpdatePackages.ShowDialog();
            if (result == DialogResult.OK) {
                selectedPkg = frmUpdatePackages.SelectedPackage;
                selectedPkgProdSupp = frmUpdatePackages.SelectedPkgProdSupp;
                if (frmUpdatePackages.ProdSuppInserted) {
                    prodSuppList.Add(frmUpdatePackages.SelectedProductsSupplier);
                }

                // Refresh DataGridView
                // Reload Combo box
                refreshComboBox();

                // Change combo box to the selected Package
                pkgNameComboBox.SelectedValue = selectedPkg.PackageId;
            } else if (result == DialogResult.Retry) {
                // Reload from database
                packageList = PackageDB.GetAllPackages();
                productsList = ProductDB.GetProducts();
                suppliersList = SupplierDB.GetSuppliers();
                prodSuppList = ProductsSupplierDB.GetAllProductsSuppliers();
                pkgProdSuppList = PackagesProductsSuppliersDB.GetPackagesProductsSuppliers();
            }
        }

        private void refreshComboBox () {
            pkgNameComboBox.DataSource = null;
            pkgNameComboBox.DataSource = packageList;
            pkgNameComboBox.DisplayMember = "PkgName";
            pkgNameComboBox.ValueMember = "PackageId";
        }

        //private void btnDeletePkg_Click(object sender, EventArgs e) {
        //    // Get Data from datagridview
        //    int packageId = (int)dummyPackageDataGridView.CurrentRow.Cells[0].Value;
        //    var selectedPkg = packages.SingleOrDefault(p => p.PackageId == packageId);

        //    int prodSuppId = (int)dummyPackageDataGridView.CurrentRow.Cells[5].Value;

        //    var selectedPkgProdSupp = pkgProdSupps.SingleOrDefault(pps => pps.ProductSupplierId == prodSuppId &&
        //                                                            pps.PackageId == packageId);

        //    int pkgIdCount = pkgProdSupps.Where(pps => pps.PackageId == packageId).Count();
        //    if(pkgIdCount == 1) {
        //        // If the packageId is the last one inside the Package_Products_Supplier table
        //        // Then we delete that package in the Package Table
        //        deletePkgProdSupp(selectedPkgProdSupp);
        //        try {
        //            if (!PackageDB.DeletePackage(selectedPkg)) {
        //                MessageBox.Show("Another user has updated or " +
        //                    "deleted that Package.", "Database Error");
        //                // Refresh data
        //                packages = PackageDB.GetAllPackages();
        //                Refresh();
        //                Invalidate();
        //            } else {
        //                packages.Remove(selectedPkg);
        //                pkgNameComboBox.SelectedIndex = 0;
        //                pkgNameComboBox.DataSource = null;
        //                pkgNameComboBox.DataSource = packages;
        //                pkgNameComboBox.DisplayMember = "PkgName";
        //                pkgNameComboBox.ValueMember = "PackageId";
        //            }
        //        } catch (Exception ex) {
        //            MessageBox.Show("Error: " + ex.Message, ex.GetType().ToString());
        //        }
        //    } else {
        //        deletePkgProdSupp(selectedPkgProdSupp);
        //        // If there are 2 or more packageIds inside Package_Products_Supplier, only delete
        //        // from the package_products_supplier table, not the Package table
        //    }
        //}

        //private void deletePkgProdSupp (PackagesProductsSuppliers packagesProductsSuppliers) {
        //    try {
        //        if (!PackagesProductsSuppliersDB.DeletePackagesProductsSuppliers(packagesProductsSuppliers)) {
        //            MessageBox.Show("Another user has updated or " +
        //                "deleted that Package.", "Database Error");
        //            // Refresh data
        //            pkgProdSupps = PackagesProductsSuppliersDB.GetPackagesProductsSuppliers();
        //            Refresh();
        //            Invalidate();
        //        } else {
        //            pkgProdSupps.Remove(packagesProductsSuppliers);
        //            // Reload Combo box
        //            pkgNameComboBox.DataSource = null;
        //            pkgNameComboBox.DisplayMember = "PkgName";
        //            pkgNameComboBox.ValueMember = "PackageId";
        //            pkgNameComboBox.DataSource = packages;
        //        }
        //    } catch (Exception ex) {
        //        MessageBox.Show("Error: " + ex.Message, ex.GetType().ToString());
        //    }
        //}
    }
}
