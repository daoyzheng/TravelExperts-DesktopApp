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
    public partial class frmSuppliers : Form {
        public frmSuppliers()
        {
            InitializeComponent();
        }

        private void frmSuppliers_Load(object sender, EventArgs e)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();

            // assign suppliers to return of GetSuppliers nethod call
            suppliers = SupplierDB.GetSuppliers();

            // bind suppliers list to combo box
            cmbSuppliers.DataSource = suppliers;

            txtIndex.Text = cmbSuppliers.SelectedIndex.ToString();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // close this form
            this.Close();
        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();

            // assign suppliers to return of GetSuppliers method call
            suppliers = SupplierDB.GetSuppliers();

            // bind suppliers list to combo box
            // cmbSuppliers.DataSource = suppliers;

            supplier = suppliers[cmbSuppliers.SelectedIndex];

            txtSupplierId.Text   = (supplier.SupplierId).ToString();
            txtSupplierName.Text = supplier.SupName;
            txtIndex.Text = cmbSuppliers.SelectedIndex.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();

            // assign suppliers to return of GetSuppliers method call
            suppliers = SupplierDB.GetSuppliers();

            // validate input
            if (Validator.IsPresent(txtSupplierName))
            {
                // text boxes validated
                // now check that the entered Supplier Name does not already exist in the database
                foreach (Supplier supp in suppliers)
                {
                    if (txtSupplierName.Text != "" && supp.SupName == txtSupplierName.Text)
                    {
                        MessageBox.Show("The Supplier Name already exists in the database");
                        return;
                    }
                }

                // business logic here is to determine the largest SupplierId in the database
                // and then assign this value + 1, to the new Supplier entry

                // Find largest SupplierID
                int maxId = SupplierDB.FindMaxSupplierId(suppliers);

                // create Supplier object to be added
                Supplier supplier = new Supplier();

                supplier.SupplierId = ++maxId;
                supplier.SupName = txtSupplierName.Text;

                txtIndex.Text = cmbSuppliers.SelectedIndex.ToString();

                int newSupplierId = SupplierDB.AddSupplier(supplier);
                DisplaySuppliers(cmbSuppliers.SelectedIndex - 1);
            }
        }
        public void DisplaySuppliers(int sIndex)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();

            // assign suppliers to return of GetSuppliers method call
            suppliers = SupplierDB.GetSuppliers();
            // bind suppliers list to combo box
            cmbSuppliers.DataSource = suppliers;

            txtSupplierId.Text = (suppliers[sIndex].SupplierId).ToString();
            txtSupplierName.Text = suppliers[sIndex].SupName;

            txtIndex.Text = cmbSuppliers.SelectedIndex.ToString();

            cmbSuppliers.SelectedIndex = sIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // create Supplier object to be deleted
            Supplier supplier = new Supplier();
            supplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            supplier.SupName = txtSupplierName.Text;

            bool result = SupplierDB.DeleteSupplier(supplier);

            DisplaySuppliers(cmbSuppliers.SelectedIndex - 1);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtIndex.Text = cmbSuppliers.SelectedIndex.ToString();
            Supplier supplier = new Supplier();

            // declare products List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();
            suppliers = SupplierDB.GetSuppliers();
            supplier = suppliers[cmbSuppliers.SelectedIndex];

            // check if product to be updated already exists in Products_Suppliers
            // table and if so, the user may not update it.

            if (SupplierDB.IsInProductsSuppliers(supplier))
            {
                MessageBox.Show("This supplier is already being used in " +
                    " the Products_Suppliers table and you may not update it.");
                return;
            }

            Supplier newSupplier = new Supplier();
            newSupplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            newSupplier.SupName = txtSupplierName.Text;

            bool result = SupplierDB.UpdateSupplier(supplier, newSupplier);
            DisplaySuppliers(cmbSuppliers.SelectedIndex);
        }
    }
}

