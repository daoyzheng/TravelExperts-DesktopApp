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

        private void homeButton_Click(object sender, EventArgs e) {
            // Set active bar
            pnlHomeBar.Visible = true;
            pnlPackBar.Visible = false;
            pnlProdBar.Visible = false;
            pnlSuppBar.Visible = false;

            // Set the active font color
            homeButton.ForeColor = Color.DodgerBlue;
            packageButton.ForeColor = Color.Black;
            productButton.ForeColor = Color.Black;
            supplierButton.ForeColor = Color.Black;

        }

        private void packageButton_Click(object sender, EventArgs e) {
            // Set active bar
            pnlHomeBar.Visible = false;
            pnlPackBar.Visible = true;
            pnlProdBar.Visible = false;
            pnlSuppBar.Visible = false;

            // Set the active font color
            homeButton.ForeColor = Color.Black;
            packageButton.ForeColor = Color.DodgerBlue;
            productButton.ForeColor = Color.Black;
            supplierButton.ForeColor = Color.Black;

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

        private void productButton_Click(object sender, EventArgs e) {
            // Set active bar
            pnlHomeBar.Visible = false;
            pnlPackBar.Visible = false;
            pnlProdBar.Visible = true;
            pnlSuppBar.Visible = false;

            // Set the active font color
            homeButton.ForeColor = Color.Black;
            packageButton.ForeColor = Color.Black;
            productButton.ForeColor = Color.DodgerBlue;
            supplierButton.ForeColor = Color.Black;

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

        private void supplierButton_Click(object sender, EventArgs e) {
            // Set active bar
            pnlHomeBar.Visible = false;
            pnlPackBar.Visible = false;
            pnlProdBar.Visible = false;
            pnlSuppBar.Visible = true;

            // Set the active font color
            homeButton.ForeColor = Color.Black;
            packageButton.ForeColor = Color.Black;
            productButton.ForeColor = Color.Black;
            supplierButton.ForeColor = Color.DodgerBlue;


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

        private void homeButton_MouseEnter(object sender, EventArgs e) {
            homeButton.BackColor = Color.LightGray;
        }

        private void packageButton_MouseEnter(object sender, EventArgs e) {
            packageButton.BackColor = Color.LightGray;
        }

        private void productButton_MouseEnter(object sender, EventArgs e) {
            productButton.BackColor = Color.LightGray;
        }

        private void supplierButton_MouseEnter(object sender, EventArgs e) {
            supplierButton.BackColor = Color.LightGray;
        }

        private void homeButton_MouseLeave(object sender, EventArgs e) {
            // Reset to default color
            homeButton.BackColor = Color.White;
        }

        private void packageButton_MouseLeave(object sender, EventArgs e) {
            // Reset to default color
            packageButton.BackColor = Color.White;
        }

        private void productButton_MouseLeave(object sender, EventArgs e) {
            // Reset to default color
            productButton.BackColor = Color.White;
        }

        private void supplierButton_MouseLeave(object sender, EventArgs e) {
            // Reset to default color
            supplierButton.BackColor = Color.White;
        }

    }
}
