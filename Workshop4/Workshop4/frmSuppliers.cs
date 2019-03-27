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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();

            // assign suppliers to return of GetSuppliers nethod call
            suppliers = SupplierDB.GetSuppliers();

            // validate input
            if (Validator.IsPresent(txtSupplierName))
            {
                // text boxes validated
                // now check that the entered Supplier Id does not already exist in the database
                foreach (Supplier supp in suppliers)
                {
                    if (txtSupplierId.Text != "" && supp.SupplierId == Convert.ToInt32(txtSupplierId.Text))
                    {
                        MessageBox.Show("Supplier Id already exists in database");
                        return;
                    }
                }
                // create Supplier object to be added
                Supplier supplier = new Supplier();
                supplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
                supplier.SupName = txtSupplierName.Text;

                int newSupplierId = SupplierDB.AddSupplier(supplier);
                DisplaySuppliers();
            }
        }
        public void DisplaySuppliers()
        {
            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();
            Supplier supplier = new Supplier();

            // track selected index
            // int sIndex = cmbSuppliers.SelectedIndex;

            // assign suppliers to return of GetSuppliers method call
            suppliers = SupplierDB.GetSuppliers();
            // bind suppliers list to combo box
            cmbSuppliers.DataSource = suppliers;

            // cmbSuppliers.SelectedIndex = sIndex - 1;

            txtSupplierId.Text = (supplier.SupplierId).ToString();
            txtSupplierName.Text = supplier.SupName;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // create Supplier object to be deleted
            Supplier supplier = new Supplier();
            supplier.SupplierId = Convert.ToInt32(txtSupplierId.Text);
            supplier.SupName = txtSupplierName.Text;

            bool result = SupplierDB.DeleteSupplier(supplier);

            DisplaySuppliers();
        }
    }
}
