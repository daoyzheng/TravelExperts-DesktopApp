namespace Workshop4 {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSuppliers = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnPackage = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.pnlMenu.Controls.Add(this.btnSuppliers);
            this.pnlMenu.Controls.Add(this.btnProducts);
            this.pnlMenu.Controls.Add(this.btnPackage);
            this.pnlMenu.Controls.Add(this.btnHome);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(113, 586);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSuppliers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 320);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Size = new System.Drawing.Size(113, 40);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Location = new System.Drawing.Point(0, 250);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(113, 40);
            this.btnProducts.TabIndex = 4;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnPackage
            // 
            this.btnPackage.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPackage.FlatAppearance.BorderSize = 0;
            this.btnPackage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPackage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnPackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackage.Location = new System.Drawing.Point(0, 180);
            this.btnPackage.Name = "btnPackage";
            this.btnPackage.Size = new System.Drawing.Size(113, 40);
            this.btnPackage.TabIndex = 3;
            this.btnPackage.Text = "Packages";
            this.btnPackage.UseVisualStyleBackColor = false;
            this.btnPackage.Click += new System.EventHandler(this.btnPackage_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(0, 110);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(113, 40);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Tomato;
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(113, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(919, 54);
            this.pnlTopBar.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 586);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnSuppliers;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnPackage;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlTopBar;
    }
}