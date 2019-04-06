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
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            this.btnAddPkg = new System.Windows.Forms.Button();
            this.btnUpdatePkg = new System.Windows.Forms.Button();
            this.btnDeletePkg = new System.Windows.Forms.Button();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameComboBox = new System.Windows.Forms.ComboBox();
            this.productSupplierViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSupplierViewModelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierViewModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierViewModelDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(304, 154);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 24;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(304, 129);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(83, 13);
            pkgBasePriceLabel.TabIndex = 26;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(304, 182);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(57, 13);
            pkgDescLabel.TabIndex = 28;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(304, 107);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(77, 13);
            pkgEndDateLabel.TabIndex = 30;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(304, 77);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(80, 13);
            pkgStartDateLabel.TabIndex = 34;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(304, 45);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(60, 13);
            pkgNameLabel.TabIndex = 36;
            pkgNameLabel.Text = "Pkg Name:";
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
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(ClassEntites.Supplier);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ClassEntites.Product);
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(ClassEntites.Package);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(436, 151);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.ReadOnly = true;
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgAgencyCommissionTextBox.TabIndex = 25;
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(436, 126);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.ReadOnly = true;
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgBasePriceTextBox.TabIndex = 27;
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Location = new System.Drawing.Point(436, 179);
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.ReadOnly = true;
            this.pkgDescTextBox.Size = new System.Drawing.Size(200, 20);
            this.pkgDescTextBox.TabIndex = 29;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Enabled = false;
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(436, 103);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgEndDateDateTimePicker.TabIndex = 31;
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Enabled = false;
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(436, 73);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.pkgStartDateDateTimePicker.TabIndex = 35;
            // 
            // pkgNameComboBox
            // 
            this.pkgNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameComboBox.FormattingEnabled = true;
            this.pkgNameComboBox.Location = new System.Drawing.Point(436, 42);
            this.pkgNameComboBox.Name = "pkgNameComboBox";
            this.pkgNameComboBox.Size = new System.Drawing.Size(200, 21);
            this.pkgNameComboBox.TabIndex = 37;
            this.pkgNameComboBox.SelectedIndexChanged += new System.EventHandler(this.pkgNameComboBox_SelectedIndexChanged);
            // 
            // productSupplierViewModelBindingSource
            // 
            this.productSupplierViewModelBindingSource.DataSource = typeof(ClassEntites.ProductSupplierViewModel);
            // 
            // productSupplierViewModelDataGridView
            // 
            this.productSupplierViewModelDataGridView.AutoGenerateColumns = false;
            this.productSupplierViewModelDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productSupplierViewModelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productSupplierViewModelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.productSupplierViewModelDataGridView.DataSource = this.productSupplierViewModelBindingSource;
            this.productSupplierViewModelDataGridView.Location = new System.Drawing.Point(255, 205);
            this.productSupplierViewModelDataGridView.Name = "productSupplierViewModelDataGridView";
            this.productSupplierViewModelDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productSupplierViewModelDataGridView.Size = new System.Drawing.Size(463, 146);
            this.productSupplierViewModelDataGridView.TabIndex = 37;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductSupplierId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductSupplierId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 116;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 82;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SuppName";
            this.dataGridViewTextBoxColumn3.HeaderText = "SuppName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1204, 517);
            this.Controls.Add(this.productSupplierViewModelDataGridView);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameComboBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Controls.Add(this.btnDeletePkg);
            this.Controls.Add(this.btnUpdatePkg);
            this.Controls.Add(this.btnAddPkg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPackage";
            this.Text = "frmPackage";
            this.Load += new System.EventHandler(this.frmPackage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierViewModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierViewModelDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Button btnAddPkg;
        private System.Windows.Forms.Button btnUpdatePkg;
        private System.Windows.Forms.Button btnDeletePkg;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.ComboBox pkgNameComboBox;
        private System.Windows.Forms.BindingSource productSupplierViewModelBindingSource;
        private System.Windows.Forms.DataGridView productSupplierViewModelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}