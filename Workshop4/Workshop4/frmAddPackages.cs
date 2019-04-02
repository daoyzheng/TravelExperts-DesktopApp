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
    public partial class frmAddPackages : Form {
        public ProductsSupplier productsSupplier { get; set; }
        public Package Package { get; set; }
        public PackagesProductsSuppliers pkgProdSupp { get; set; }

        public List<Product> products { get; set; }
        public List<Supplier> suppliers { get; set; }
        public List<PackagesProductsSuppliers> pkgProdSupps { get; set; }
        public List<Package> packages { get; set; }

        public frmAddPackages() {
            InitializeComponent();
        }

        private void frmAddPackages_Load(object sender, EventArgs e) {
            // Load combo boxes
            prodNameComboBox.DisplayMember = "ProdName";
            prodNameComboBox.ValueMember = "ProductId";
            prodNameComboBox.DataSource = products;

            supNameComboBox.DisplayMember = "SupName";
            supNameComboBox.ValueMember = "SupplierId";
            supNameComboBox.DataSource = suppliers;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            string pkgName;
            decimal basePrice;
            int productId;
            int supplierId;

            if (Validator.IsPresent(pkgNameTextBox) &&
                Validator.IsPresent(pkgBasePriceTextBox)) { 
                pkgName = pkgNameTextBox.Text;
                basePrice = Convert.ToDecimal(pkgBasePriceTextBox.Text);

                // If Package Name already exists, get package object from database
                var pkg = packages.SingleOrDefault(p => p.PkgName == pkgName);
                if (pkg != null) {
                    Package = pkg;
                } else {
                    Package.PkgName = pkgName;
                    Package.PkgBasePrice = basePrice;
                    
                    if (string.IsNullOrWhiteSpace(pkgAgencyCommissionTextBox.Text)) {
                        Package.PkgAgencyCommission = null;
                    } else {
                        Package.PkgAgencyCommission = Convert.ToDecimal(pkgAgencyCommissionTextBox.Text);
                    }

                    if (string.IsNullOrWhiteSpace(pkgDescTextBox.Text)) {
                        Package.PkgDesc = null;
                    } else {
                        Package.PkgDesc = pkgDescTextBox.Text;
                    }

                    if (pkgStartDateDateTimePicker.Checked == false &&
                        pkgEndDateDateTimePicker.Checked == false) {
                        Package.PkgStartDate = null;
                        Package.PkgEndDate = null;
                    } else if (pkgStartDateDateTimePicker.Checked == true &&
                        pkgEndDateDateTimePicker.Checked == false) {
                        // Package End Date has not been provided yet
                        Package.PkgStartDate = pkgStartDateDateTimePicker.Value;
                        Package.PkgEndDate = null;
                    } else if (pkgStartDateDateTimePicker.Checked == false &&
                        pkgEndDateDateTimePicker.Checked == true) {
                        MessageBox.Show("Must Provide a Valid Start Date");
                        DialogResult = DialogResult.None;
                    } else {
                        if (DateTime.Compare(pkgStartDateDateTimePicker.Value, pkgEndDateDateTimePicker.Value) >= 0 ) {
                            MessageBox.Show("Start Date must be earlier than End Date");
                            DialogResult = DialogResult.None;
                        } else {
                            Package.PkgStartDate = pkgStartDateDateTimePicker.Value;
                            Package.PkgEndDate = pkgEndDateDateTimePicker.Value;
                        }
                    }
                }
            } else {
                DialogResult = DialogResult.None;
            }

            productId = (int)prodNameComboBox.SelectedValue;
            supplierId = (int)supNameComboBox.SelectedValue;

            // Check if the combination of productId and supplierId already exists in database
            if (ProductsSupplierDB.GetProductsSupplierByProductIdAndSupplierId(productId, supplierId) == null) {
                // if doesn't exist in database, insert a new record
                ProductsSupplier prodSupps = new ProductsSupplier {
                    ProductId = productId,
                    SupplierId = supplierId
                };

                int prodSuppId = ProductsSupplierDB.AddProductsSupplier(productsSupplier);
                prodSupps.ProductSupplierId = prodSuppId;

                productsSupplier = prodSupps;
            } else {
                productsSupplier =
                    ProductsSupplierDB.GetProductsSupplierByProductIdAndSupplierId(productId, supplierId);
            }

            // Bind data to form-level variable

            // First, Bind to Package 
        }

        // Only allow numerics and one decimal
        private void pkgBasePriceTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            // e.KeyChar is the character pressed
            // e.Handled - boolean flag that says "I am done"
            if (!char.IsDigit(e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != '.') {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void pkgAgencyCommissionTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            pkgBasePriceTextBox_KeyPress(sender, e);
        }

        private void pkgNameTextBox_Validating(object sender, CancelEventArgs e) {
            TextBox tb = sender as TextBox;

            // If Package Name already exists, get package object from database
            var pkg = packages.SingleOrDefault(p => p.PkgName == tb.Text);

            if (pkg != null) {
                pkgBasePriceTextBox.ReadOnly = true;
                pkgDescTextBox.ReadOnly = true;
                pkgStartDateDateTimePicker.Enabled = false;
                pkgEndDateDateTimePicker.Enabled = false;
                pkgAgencyCommissionTextBox.ReadOnly = true;
            }
        }
    }
}
