namespace Workshop4 {
    partial class frmAddPackages {
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
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label supNameLabel;
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pkgAgencyCommissionTextBox = new System.Windows.Forms.TextBox();
            this.pkgBasePriceTextBox = new System.Windows.Forms.TextBox();
            this.pkgDescTextBox = new System.Windows.Forms.TextBox();
            this.pkgEndDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pkgNameTextBox = new System.Windows.Forms.TextBox();
            this.pkgStartDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodNameComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supNameComboBox = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            prodNameLabel = new System.Windows.Forms.Label();
            supNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.BackColor = System.Drawing.Color.Transparent;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(42, 291);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(156, 20);
            pkgAgencyCommissionLabel.TabIndex = 0;
            pkgAgencyCommissionLabel.Text = "Agency Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.BackColor = System.Drawing.Color.Transparent;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(106, 248);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(89, 20);
            pkgBasePriceLabel.TabIndex = 2;
            pkgBasePriceLabel.Text = "Base Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.BackColor = System.Drawing.Color.Transparent;
            pkgDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(105, 329);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(93, 20);
            pkgDescLabel.TabIndex = 4;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.BackColor = System.Drawing.Color.Transparent;
            pkgEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(114, 204);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(81, 20);
            pkgEndDateLabel.TabIndex = 6;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.BackColor = System.Drawing.Color.Transparent;
            pkgNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(140, 34);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(55, 20);
            pkgNameLabel.TabIndex = 8;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.BackColor = System.Drawing.Color.Transparent;
            pkgStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(108, 162);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(87, 20);
            pkgStartDateLabel.TabIndex = 10;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.BackColor = System.Drawing.Color.Transparent;
            prodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.Location = new System.Drawing.Point(81, 77);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(114, 20);
            prodNameLabel.TabIndex = 12;
            prodNameLabel.Text = "Product Name:";
            // 
            // supNameLabel
            // 
            supNameLabel.AutoSize = true;
            supNameLabel.BackColor = System.Drawing.Color.Transparent;
            supNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            supNameLabel.Location = new System.Drawing.Point(81, 119);
            supNameLabel.Name = "supNameLabel";
            supNameLabel.Size = new System.Drawing.Size(117, 20);
            supNameLabel.TabIndex = 14;
            supNameLabel.Text = "Supplier Name:";
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(ClassEntites.Package);
            // 
            // pkgAgencyCommissionTextBox
            // 
            this.pkgAgencyCommissionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.pkgAgencyCommissionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgAgencyCommissionTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pkgAgencyCommissionTextBox.Location = new System.Drawing.Point(246, 287);
            this.pkgAgencyCommissionTextBox.Name = "pkgAgencyCommissionTextBox";
            this.pkgAgencyCommissionTextBox.Size = new System.Drawing.Size(237, 24);
            this.pkgAgencyCommissionTextBox.TabIndex = 1;
            this.pkgAgencyCommissionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pkgAgencyCommissionTextBox_KeyPress);
            // 
            // pkgBasePriceTextBox
            // 
            this.pkgBasePriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.pkgBasePriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgBasePriceTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pkgBasePriceTextBox.Location = new System.Drawing.Point(246, 244);
            this.pkgBasePriceTextBox.Name = "pkgBasePriceTextBox";
            this.pkgBasePriceTextBox.Size = new System.Drawing.Size(237, 24);
            this.pkgBasePriceTextBox.TabIndex = 3;
            this.pkgBasePriceTextBox.Tag = "Package Base Price";
            this.pkgBasePriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pkgBasePriceTextBox_KeyPress);
            // 
            // pkgDescTextBox
            // 
            this.pkgDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.pkgDescTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgDescTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pkgDescTextBox.Location = new System.Drawing.Point(246, 329);
            this.pkgDescTextBox.Multiline = true;
            this.pkgDescTextBox.Name = "pkgDescTextBox";
            this.pkgDescTextBox.Size = new System.Drawing.Size(237, 102);
            this.pkgDescTextBox.TabIndex = 5;
            // 
            // pkgEndDateDateTimePicker
            // 
            this.pkgEndDateDateTimePicker.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.pkgEndDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.pkgEndDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgEndDateDateTimePicker.Location = new System.Drawing.Point(246, 198);
            this.pkgEndDateDateTimePicker.Name = "pkgEndDateDateTimePicker";
            this.pkgEndDateDateTimePicker.ShowCheckBox = true;
            this.pkgEndDateDateTimePicker.Size = new System.Drawing.Size(237, 26);
            this.pkgEndDateDateTimePicker.TabIndex = 7;
            // 
            // pkgNameTextBox
            // 
            this.pkgNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.pkgNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgNameTextBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.pkgNameTextBox.Location = new System.Drawing.Point(246, 28);
            this.pkgNameTextBox.Name = "pkgNameTextBox";
            this.pkgNameTextBox.Size = new System.Drawing.Size(237, 26);
            this.pkgNameTextBox.TabIndex = 9;
            this.pkgNameTextBox.Tag = "Package Name";
            this.pkgNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.pkgNameTextBox_Validating);
            // 
            // pkgStartDateDateTimePicker
            // 
            this.pkgStartDateDateTimePicker.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.pkgStartDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.pkgStartDateDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pkgStartDateDateTimePicker.Location = new System.Drawing.Point(246, 156);
            this.pkgStartDateDateTimePicker.Name = "pkgStartDateDateTimePicker";
            this.pkgStartDateDateTimePicker.ShowCheckBox = true;
            this.pkgStartDateDateTimePicker.Size = new System.Drawing.Size(237, 26);
            this.pkgStartDateDateTimePicker.TabIndex = 11;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(ClassEntites.Product);
            // 
            // prodNameComboBox
            // 
            this.prodNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.prodNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.prodNameComboBox.FormattingEnabled = true;
            this.prodNameComboBox.Location = new System.Drawing.Point(246, 71);
            this.prodNameComboBox.Name = "prodNameComboBox";
            this.prodNameComboBox.Size = new System.Drawing.Size(237, 26);
            this.prodNameComboBox.TabIndex = 13;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(ClassEntites.Supplier);
            // 
            // supNameComboBox
            // 
            this.supNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.supplierBindingSource, "SupName", true));
            this.supNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supNameComboBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.supNameComboBox.FormattingEnabled = true;
            this.supNameComboBox.Location = new System.Drawing.Point(246, 113);
            this.supNameComboBox.Name = "supNameComboBox";
            this.supNameComboBox.Size = new System.Drawing.Size(237, 26);
            this.supNameComboBox.TabIndex = 15;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(399, 505);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(84, 38);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Teal;
            this.btnClear.Location = new System.Drawing.Point(118, 505);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 38);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmAddPackages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 586);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(supNameLabel);
            this.Controls.Add(this.supNameComboBox);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameComboBox);
            this.Controls.Add(pkgAgencyCommissionLabel);
            this.Controls.Add(this.pkgAgencyCommissionTextBox);
            this.Controls.Add(pkgBasePriceLabel);
            this.Controls.Add(this.pkgBasePriceTextBox);
            this.Controls.Add(pkgDescLabel);
            this.Controls.Add(this.pkgDescTextBox);
            this.Controls.Add(pkgEndDateLabel);
            this.Controls.Add(this.pkgEndDateDateTimePicker);
            this.Controls.Add(pkgNameLabel);
            this.Controls.Add(this.pkgNameTextBox);
            this.Controls.Add(pkgStartDateLabel);
            this.Controls.Add(this.pkgStartDateDateTimePicker);
            this.Name = "frmAddPackages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Package";
            this.Load += new System.EventHandler(this.frmAddPackages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox pkgAgencyCommissionTextBox;
        private System.Windows.Forms.TextBox pkgBasePriceTextBox;
        private System.Windows.Forms.TextBox pkgDescTextBox;
        private System.Windows.Forms.DateTimePicker pkgEndDateDateTimePicker;
        private System.Windows.Forms.TextBox pkgNameTextBox;
        private System.Windows.Forms.DateTimePicker pkgStartDateDateTimePicker;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.ComboBox prodNameComboBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ComboBox supNameComboBox;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
    }
}