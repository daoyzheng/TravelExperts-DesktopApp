namespace Workshop4 {
    partial class frmSuppliers {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuppliers));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.lblSuppliers = new System.Windows.Forms.Label();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.txtSupplierId = new System.Windows.Forms.TextBox();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppliers Management Form Under Construction";
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.DropDownHeight = 310;
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSuppliers.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.IntegralHeight = false;
            this.cmbSuppliers.Location = new System.Drawing.Point(27, 273);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(723, 26);
            this.cmbSuppliers.TabIndex = 1;
            this.cmbSuppliers.SelectedIndexChanged += new System.EventHandler(this.cmbSuppliers_SelectedIndexChanged);
            // 
            // lblSuppliers
            // 
            this.lblSuppliers.AutoSize = true;
            this.lblSuppliers.BackColor = System.Drawing.Color.Transparent;
            this.lblSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuppliers.ForeColor = System.Drawing.Color.Teal;
            this.lblSuppliers.Location = new System.Drawing.Point(22, 229);
            this.lblSuppliers.Name = "lblSuppliers";
            this.lblSuppliers.Size = new System.Drawing.Size(98, 24);
            this.lblSuppliers.TabIndex = 2;
            this.lblSuppliers.Text = "Suppliers";
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierId.ForeColor = System.Drawing.Color.Teal;
            this.lblSupplierId.Location = new System.Drawing.Point(22, 74);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(111, 24);
            this.lblSupplierId.TabIndex = 3;
            this.lblSupplierId.Text = "Supplier Id";
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.ForeColor = System.Drawing.Color.Teal;
            this.lblSupplierName.Location = new System.Drawing.Point(22, 129);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(149, 24);
            this.lblSupplierName.TabIndex = 4;
            this.lblSupplierName.Text = "Supplier Name";
            // 
            // txtSupplierId
            // 
            this.txtSupplierId.Enabled = false;
            this.txtSupplierId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierId.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSupplierId.Location = new System.Drawing.Point(209, 74);
            this.txtSupplierId.Name = "txtSupplierId";
            this.txtSupplierId.Size = new System.Drawing.Size(122, 24);
            this.txtSupplierId.TabIndex = 5;
            // 
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtSupplierName.Location = new System.Drawing.Point(209, 126);
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(541, 24);
            this.txtSupplierName.TabIndex = 6;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Teal;
            this.btnAdd.Location = new System.Drawing.Point(338, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 56);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Teal;
            this.btnDelete.Location = new System.Drawing.Point(463, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 56);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Teal;
            this.btnUpdate.Location = new System.Drawing.Point(209, 176);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 56);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Teal;
            this.btnExit.Location = new System.Drawing.Point(595, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(99, 56);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtIndex.Location = new System.Drawing.Point(792, 273);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 24);
            this.txtIndex.TabIndex = 11;
            // 
            // frmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 741);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSupplierName);
            this.Controls.Add(this.txtSupplierId);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblSupplierId);
            this.Controls.Add(this.lblSuppliers);
            this.Controls.Add(this.cmbSuppliers);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmSuppliers";
            this.Text = "frmSuppliers";
            this.Load += new System.EventHandler(this.frmSuppliers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label lblSuppliers;
        private System.Windows.Forms.Label lblSupplierId;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.TextBox txtSupplierId;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtIndex;
    }
}