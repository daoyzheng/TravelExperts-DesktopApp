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
    public partial class MainForm : Form {

        // Form-level variables
        private static bool pkgFormOpened = false;
        private static bool prodsFormOpened = false;
        private static bool suppsFormOpened = false;

        public MainForm() {
            InitializeComponent();
        }

        private void btnPackage_Click(object sender, EventArgs e) {
            // Reset all other forms
            prodsFormOpened = false;
            suppsFormOpened = false;

            if (pkgFormOpened == false) {
                Form pkgForm = new PackageMainForm();
                pkgForm.MdiParent = this;
                pkgForm.Dock = DockStyle.Fill;
                pkgForm.Show();
                pkgFormOpened = true;
            }
        }

        private void btnProducts_Click(object sender, EventArgs e) {
            // Reset all other forms
            pkgFormOpened = false;
            suppsFormOpened = false;

            if (prodsFormOpened == false) {
                Form prodsForm = new frmProducts();
                prodsForm.MdiParent = this;
                prodsForm.Dock = DockStyle.Fill;
                prodsForm.Show();
                prodsFormOpened = true;
            }
        }

        private void btnSuppliers_Click(object sender, EventArgs e) {
            // Reset all other forms
            pkgFormOpened = false;
            prodsFormOpened = false;

            if (suppsFormOpened == false) {
                Form suppsForm = new frmSuppliers();
                suppsForm.MdiParent = this;
                suppsForm.Dock = DockStyle.Fill;
                suppsForm.Show();
                suppsFormOpened = true;
            }
        }
    }
}
