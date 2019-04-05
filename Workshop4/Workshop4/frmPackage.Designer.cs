namespace Workshop4 {
    partial class frmPackage {
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackage));
            this.pkgNameComboBox = new System.Windows.Forms.ComboBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodNameComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supNameComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dummyPackageDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dummyPackageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.btnUpdatePkg = new System.Windows.Forms.Button();
            this.btnDeletePkg = new System.Windows.Forms.Button();
            pkgNameLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dummyPackageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dummyPackageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.BackColor = System.Drawing.Color.Transparent;
            pkgNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.ForeColor = System.Drawing.Color.Teal;
            pkgNameLabel.Location = new System.Drawing.Point(11, 23);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(106, 24);
            pkgNameLabel.TabIndex = 16;
            pkgNameLabel.Text = "Pkg Name";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.BackColor = System.Drawing.Color.Transparent;
            prodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.ForeColor = System.Drawing.Color.Teal;
            prodNameLabel.Location = new System.Drawing.Point(278, 23);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(115, 24);
            prodNameLabel.TabIndex = 19;
            prodNameLabel.Text = "Prod Name";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.BackColor = System.Drawing.Color.Transparent;
            supNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supNameLabel.ForeColor = System.Drawing.Color.Teal;
            supNameLabel.Location = new System.Drawing.Point(542, 23);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(108, 24);
            supNameLabel.TabIndex = 20;
            supNameLabel.Text = "Sup Name";
            // 
            // pkgNameComboBox
            // 
            this.pkgNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgNameComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pkgNameComboBox.FormattingEnabled = true;
            this.pkgNameComboBox.Location = new System.Drawing.Point(15, 62);
            this.pkgNameComboBox.Name = "pkgNameComboBox";
            this.pkgNameComboBox.Size = new System.Drawing.Size(179, 26);
            this.pkgNameComboBox.TabIndex = 17;
            this.pkgNameComboBox.SelectedIndexChanged += new System.EventHandler(this.pkgNameComboBox_SelectedIndexChanged);
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(ClassEntites.Package);
            // 
            // prodNameComboBox
            // 
            this.prodNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.prodNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prodNameComboBox.FormattingEnabled = true;
            this.prodNameComboBox.Location = new System.Drawing.Point(282, 62);
            this.prodNameComboBox.Name = "prodNameComboBox";
            this.prodNameComboBox.Size = new System.Drawing.Size(178, 26);
            this.prodNameComboBox.TabIndex = 20;
            this.prodNameComboBox.SelectedIndexChanged += new System.EventHandler(this.prodNameComboBox_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ClassEntites.Product);
            // 
            // supNameComboBox
            // 
            this.supNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupName", true));
            this.supNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNameComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.supNameComboBox.FormattingEnabled = true;
            this.supNameComboBox.Location = new System.Drawing.Point(546, 62);
            this.supNameComboBox.Name = "supNameComboBox";
            this.supNameComboBox.Size = new System.Drawing.Size(189, 26);
            this.supNameComboBox.TabIndex = 21;
            this.supNameComboBox.SelectedIndexChanged += new System.EventHandler(this.supNameComboBox_SelectedIndexChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(ClassEntites.Supplier);
            // 
            // dummyPackageDataGridView
            // 
            this.dummyPackageDataGridView.AutoGenerateColumns = false;
            this.dummyPackageDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dummyPackageDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dummyPackageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dummyPackageDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dummyPackageDataGridView.DataSource = this.dummyPackageBindingSource;
            this.dummyPackageDataGridView.Location = new System.Drawing.Point(15, 122);
            this.dummyPackageDataGridView.Name = "dummyPackageDataGridView";
            this.dummyPackageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dummyPackageDataGridView.Size = new System.Drawing.Size(1193, 177);
            this.dummyPackageDataGridView.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PackageId";
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "Package ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 82;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PkgName";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PkgStartDate";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Start Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 74;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PkgEndDate";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn4.HeaderText = "End Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 71;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PkgBasePrice";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle5.Format = "C2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn5.HeaderText = "Base Price";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 77;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ProductSupplierId";
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn8.HeaderText = "Product Supplier ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 104;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "ProdName";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn9.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn9.HeaderText = "Product Name";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 92;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SuppName";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn10.HeaderText = "Supplier Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 93;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PkgDesc";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewTextBoxColumn6.HeaderText = "Description";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 85;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PkgAgencyCommission";
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewTextBoxColumn7.HeaderText = "Agency Commission";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 115;
            // 
            // dummyPackageBindingSource
            // 
            this.dummyPackageBindingSource.DataSource = typeof(ClassEntites.DummyPackage);
            // 
            // btnAddPkg
            // 
            this.btnAddPkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPkg.ForeColor = System.Drawing.Color.Teal;
            this.btnAddPkg.Location = new System.Drawing.Point(61, 371);
            this.btnAddPkg.Name = "btnAddPkg";
            this.btnAddPkg.Size = new System.Drawing.Size(143, 46);
            this.btnAddPkg.TabIndex = 22;
            this.btnAddPkg.Text = "Add Packages";
            this.btnAddPkg.UseVisualStyleBackColor = true;
            this.btnAddPkg.Click += new System.EventHandler(this.btnAddPkg_Click);
            // 
            // btnUpdatePkg
            // 
            this.btnUpdatePkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePkg.ForeColor = System.Drawing.Color.Teal;
            this.btnUpdatePkg.Location = new System.Drawing.Point(282, 371);
            this.btnUpdatePkg.Name = "btnUpdatePkg";
            this.btnUpdatePkg.Size = new System.Drawing.Size(168, 46);
            this.btnUpdatePkg.TabIndex = 23;
            this.btnUpdatePkg.Text = "Update Packages";
            this.btnUpdatePkg.UseVisualStyleBackColor = true;
            this.btnUpdatePkg.Click += new System.EventHandler(this.btnUpdatePkg_Click);
            // 
            // btnDeletePkg
            // 
            this.btnDeletePkg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePkg.ForeColor = System.Drawing.Color.Teal;
            this.btnDeletePkg.Location = new System.Drawing.Point(546, 371);
            this.btnDeletePkg.Name = "btnDeletePkg";
            this.btnDeletePkg.Size = new System.Drawing.Size(179, 46);
            this.btnDeletePkg.TabIndex = 24;
            this.btnDeletePkg.Text = "Delete Packages";
            this.btnDeletePkg.UseVisualStyleBackColor = true;
            this.btnDeletePkg.Click += new System.EventHandler(this.btnDeletePkg_Click);
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 498);
            this.Controls.Add(this.btnDeletePkg);
            this.Controls.Add(this.btnUpdatePkg);
            this.Controls.Add(this.btnAddPkg);
            this.Controls.Add(this.dummyPackageDataGridView);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supNameComboBox);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameComboBox);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameComboBox);
            this.Name = "frmPackage";
            this.Text = "frmPackage";
            this.Load += new System.EventHandler(this.frmPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dummyPackageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dummyPackageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.ComboBox pkgNameComboBox;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource dummyPackageBindingSource;
        private System.Windows.Forms.ComboBox prodNameComboBox;
        private System.Windows.Forms.ComboBox supNameComboBox;
        private System.Windows.Forms.DataGridView dummyPackageDataGridView;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.Button btnUpdatePkg;
        private System.Windows.Forms.Button btnDeletePkg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}