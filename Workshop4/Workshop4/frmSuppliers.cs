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
        }

        private void cmbSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Supplier supplier = new Supplier();

            // declare suppliers List variable and instantiate new List<Supplier> object
            List<Supplier> suppliers = new List<Supplier>();

            // assign suppliers to return of GetSuppliers nethod call
            suppliers = SupplierDB.GetSuppliers();

            // bind suppliers list to combo box
            // cmbSuppliers.DataSource = suppliers;

            supplier = suppliers[cmbSuppliers.SelectedIndex];

            txtSupplierId.Text   = (supplier.SupplierId).ToString();
            txtSupplierName.Text = supplier.SupName;
        }
    }
}
