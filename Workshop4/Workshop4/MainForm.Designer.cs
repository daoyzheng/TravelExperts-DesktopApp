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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlSuppBar = new System.Windows.Forms.Panel();
            this.pnlProdBar = new System.Windows.Forms.Panel();
            this.pnlPackBar = new System.Windows.Forms.Panel();
            this.pnlHomeBar = new System.Windows.Forms.Panel();
            this.supplierButton = new Workshop4.SupplierButton();
            this.productButton = new Workshop4.ProductButton();
            this.packageButton = new Workshop4.PackageButton();
            this.homeButton = new Workshop4.HomeButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.btnSignIn);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Controls.Add(this.supplierButton);
            this.pnlMenu.Controls.Add(this.pnlSuppBar);
            this.pnlMenu.Controls.Add(this.productButton);
            this.pnlMenu.Controls.Add(this.pnlProdBar);
            this.pnlMenu.Controls.Add(this.packageButton);
            this.pnlMenu.Controls.Add(this.pnlPackBar);
            this.pnlMenu.Controls.Add(this.homeButton);
            this.pnlMenu.Controls.Add(this.pnlHomeBar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(226, 586);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlSuppBar
            // 
            this.pnlSuppBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlSuppBar.Location = new System.Drawing.Point(0, 351);
            this.pnlSuppBar.Name = "pnlSuppBar";
            this.pnlSuppBar.Size = new System.Drawing.Size(10, 44);
            this.pnlSuppBar.TabIndex = 8;
            this.pnlSuppBar.Visible = false;
            // 
            // pnlProdBar
            // 
            this.pnlProdBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlProdBar.Location = new System.Drawing.Point(0, 270);
            this.pnlProdBar.Name = "pnlProdBar";
            this.pnlProdBar.Size = new System.Drawing.Size(10, 44);
            this.pnlProdBar.TabIndex = 7;
            this.pnlProdBar.Visible = false;
            // 
            // pnlPackBar
            // 
            this.pnlPackBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlPackBar.Location = new System.Drawing.Point(0, 189);
            this.pnlPackBar.Name = "pnlPackBar";
            this.pnlPackBar.Size = new System.Drawing.Size(10, 44);
            this.pnlPackBar.TabIndex = 6;
            this.pnlPackBar.Visible = false;
            // 
            // pnlHomeBar
            // 
            this.pnlHomeBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.pnlHomeBar.Location = new System.Drawing.Point(0, 108);
            this.pnlHomeBar.Name = "pnlHomeBar";
            this.pnlHomeBar.Size = new System.Drawing.Size(10, 44);
            this.pnlHomeBar.TabIndex = 3;
            this.pnlHomeBar.Visible = false;
            // 
            // supplierButton
            // 
            this.supplierButton.Location = new System.Drawing.Point(10, 351);
            this.supplierButton.Name = "supplierButton";
            this.supplierButton.Size = new System.Drawing.Size(214, 44);
            this.supplierButton.TabIndex = 0;
            this.supplierButton.Click += new System.EventHandler(this.supplierButton_Click);
            this.supplierButton.MouseEnter += new System.EventHandler(this.supplierButton_MouseEnter);
            this.supplierButton.MouseLeave += new System.EventHandler(this.supplierButton_MouseLeave);
            // 
            // productButton
            // 
            this.productButton.Location = new System.Drawing.Point(10, 270);
            this.productButton.Name = "productButton";
            this.productButton.Size = new System.Drawing.Size(214, 44);
            this.productButton.TabIndex = 0;
            this.productButton.Click += new System.EventHandler(this.productButton_Click);
            this.productButton.MouseEnter += new System.EventHandler(this.productButton_MouseEnter);
            this.productButton.MouseLeave += new System.EventHandler(this.productButton_MouseLeave);
            // 
            // packageButton
            // 
            this.packageButton.Location = new System.Drawing.Point(10, 189);
            this.packageButton.Name = "packageButton";
            this.packageButton.Size = new System.Drawing.Size(214, 44);
            this.packageButton.TabIndex = 0;
            this.packageButton.Click += new System.EventHandler(this.packageButton_Click);
            this.packageButton.MouseEnter += new System.EventHandler(this.packageButton_MouseEnter);
            this.packageButton.MouseLeave += new System.EventHandler(this.packageButton_MouseLeave);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(10, 108);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(214, 44);
            this.homeButton.TabIndex = 0;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            this.homeButton.MouseEnter += new System.EventHandler(this.homeButton_MouseEnter);
            this.homeButton.MouseLeave += new System.EventHandler(this.homeButton_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 505);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.Location = new System.Drawing.Point(45, 505);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(61, 32);
            this.btnSignIn.TabIndex = 9;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 586);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlHomeBar;
        private HomeButton homeButton;
        private PackageButton packageButton;
        private System.Windows.Forms.Panel pnlPackBar;
        private SupplierButton supplierButton;
        private System.Windows.Forms.Panel pnlSuppBar;
        private ProductButton productButton;
        private System.Windows.Forms.Panel pnlProdBar;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}