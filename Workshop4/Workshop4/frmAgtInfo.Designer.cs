namespace Workshop4 {
    partial class frmAgtInfo {
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
            System.Windows.Forms.Label agencyIdLabel;
            System.Windows.Forms.Label agtBusPhoneLabel;
            System.Windows.Forms.Label agtEmailLabel;
            System.Windows.Forms.Label agtFirstNameLabel;
            System.Windows.Forms.Label agtLastNameLabel;
            System.Windows.Forms.Label agtMiddleInitialLabel;
            System.Windows.Forms.Label agtPositionLabel;
            this.agencyIdLabel1 = new System.Windows.Forms.Label();
            this.agtBusPhoneLabel1 = new System.Windows.Forms.Label();
            this.agtEmailLabel1 = new System.Windows.Forms.Label();
            this.agtFirstNameLabel1 = new System.Windows.Forms.Label();
            this.agtLastNameLabel1 = new System.Windows.Forms.Label();
            this.agtMiddleInitialLabel1 = new System.Windows.Forms.Label();
            this.agtPositionLabel1 = new System.Windows.Forms.Label();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            agencyIdLabel = new System.Windows.Forms.Label();
            agtBusPhoneLabel = new System.Windows.Forms.Label();
            agtEmailLabel = new System.Windows.Forms.Label();
            agtFirstNameLabel = new System.Windows.Forms.Label();
            agtLastNameLabel = new System.Windows.Forms.Label();
            agtMiddleInitialLabel = new System.Windows.Forms.Label();
            agtPositionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // agencyIdLabel
            // 
            agencyIdLabel.AutoSize = true;
            agencyIdLabel.Location = new System.Drawing.Point(154, 94);
            agencyIdLabel.Name = "agencyIdLabel";
            agencyIdLabel.Size = new System.Drawing.Size(58, 13);
            agencyIdLabel.TabIndex = 1;
            agencyIdLabel.Text = "Agency Id:";
            // 
            // agencyIdLabel1
            // 
            this.agencyIdLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgencyId", true));
            this.agencyIdLabel1.Location = new System.Drawing.Point(247, 94);
            this.agencyIdLabel1.Name = "agencyIdLabel1";
            this.agencyIdLabel1.Size = new System.Drawing.Size(208, 23);
            this.agencyIdLabel1.TabIndex = 2;
            this.agencyIdLabel1.Text = "label1";
            // 
            // agtBusPhoneLabel
            // 
            agtBusPhoneLabel.AutoSize = true;
            agtBusPhoneLabel.Location = new System.Drawing.Point(154, 120);
            agtBusPhoneLabel.Name = "agtBusPhoneLabel";
            agtBusPhoneLabel.Size = new System.Drawing.Size(81, 13);
            agtBusPhoneLabel.TabIndex = 5;
            agtBusPhoneLabel.Text = "Agt Bus Phone:";
            // 
            // agtBusPhoneLabel1
            // 
            this.agtBusPhoneLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtBusPhone", true));
            this.agtBusPhoneLabel1.Location = new System.Drawing.Point(247, 120);
            this.agtBusPhoneLabel1.Name = "agtBusPhoneLabel1";
            this.agtBusPhoneLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtBusPhoneLabel1.TabIndex = 6;
            this.agtBusPhoneLabel1.Text = "label1";
            // 
            // agtEmailLabel
            // 
            agtEmailLabel.AutoSize = true;
            agtEmailLabel.Location = new System.Drawing.Point(154, 143);
            agtEmailLabel.Name = "agtEmailLabel";
            agtEmailLabel.Size = new System.Drawing.Size(54, 13);
            agtEmailLabel.TabIndex = 7;
            agtEmailLabel.Text = "Agt Email:";
            // 
            // agtEmailLabel1
            // 
            this.agtEmailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtEmail", true));
            this.agtEmailLabel1.Location = new System.Drawing.Point(247, 143);
            this.agtEmailLabel1.Name = "agtEmailLabel1";
            this.agtEmailLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtEmailLabel1.TabIndex = 8;
            this.agtEmailLabel1.Text = "label1";
            // 
            // agtFirstNameLabel
            // 
            agtFirstNameLabel.AutoSize = true;
            agtFirstNameLabel.Location = new System.Drawing.Point(154, 166);
            agtFirstNameLabel.Name = "agtFirstNameLabel";
            agtFirstNameLabel.Size = new System.Drawing.Size(79, 13);
            agtFirstNameLabel.TabIndex = 9;
            agtFirstNameLabel.Text = "Agt First Name:";
            // 
            // agtFirstNameLabel1
            // 
            this.agtFirstNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtFirstName", true));
            this.agtFirstNameLabel1.Location = new System.Drawing.Point(247, 166);
            this.agtFirstNameLabel1.Name = "agtFirstNameLabel1";
            this.agtFirstNameLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtFirstNameLabel1.TabIndex = 10;
            this.agtFirstNameLabel1.Text = "label1";
            // 
            // agtLastNameLabel
            // 
            agtLastNameLabel.AutoSize = true;
            agtLastNameLabel.Location = new System.Drawing.Point(154, 189);
            agtLastNameLabel.Name = "agtLastNameLabel";
            agtLastNameLabel.Size = new System.Drawing.Size(80, 13);
            agtLastNameLabel.TabIndex = 11;
            agtLastNameLabel.Text = "Agt Last Name:";
            // 
            // agtLastNameLabel1
            // 
            this.agtLastNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtLastName", true));
            this.agtLastNameLabel1.Location = new System.Drawing.Point(247, 189);
            this.agtLastNameLabel1.Name = "agtLastNameLabel1";
            this.agtLastNameLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtLastNameLabel1.TabIndex = 12;
            this.agtLastNameLabel1.Text = "label1";
            // 
            // agtMiddleInitialLabel
            // 
            agtMiddleInitialLabel.AutoSize = true;
            agtMiddleInitialLabel.Location = new System.Drawing.Point(154, 212);
            agtMiddleInitialLabel.Name = "agtMiddleInitialLabel";
            agtMiddleInitialLabel.Size = new System.Drawing.Size(87, 13);
            agtMiddleInitialLabel.TabIndex = 13;
            agtMiddleInitialLabel.Text = "Agt Middle Initial:";
            // 
            // agtMiddleInitialLabel1
            // 
            this.agtMiddleInitialLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtMiddleInitial", true));
            this.agtMiddleInitialLabel1.Location = new System.Drawing.Point(247, 212);
            this.agtMiddleInitialLabel1.Name = "agtMiddleInitialLabel1";
            this.agtMiddleInitialLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtMiddleInitialLabel1.TabIndex = 14;
            this.agtMiddleInitialLabel1.Text = "label1";
            // 
            // agtPositionLabel
            // 
            agtPositionLabel.AutoSize = true;
            agtPositionLabel.Location = new System.Drawing.Point(154, 235);
            agtPositionLabel.Name = "agtPositionLabel";
            agtPositionLabel.Size = new System.Drawing.Size(66, 13);
            agtPositionLabel.TabIndex = 15;
            agtPositionLabel.Text = "Agt Position:";
            // 
            // agtPositionLabel1
            // 
            this.agtPositionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agentBindingSource, "AgtPosition", true));
            this.agtPositionLabel1.Location = new System.Drawing.Point(247, 235);
            this.agtPositionLabel1.Name = "agtPositionLabel1";
            this.agtPositionLabel1.Size = new System.Drawing.Size(208, 23);
            this.agtPositionLabel1.TabIndex = 16;
            this.agtPositionLabel1.Text = "label1";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataSource = typeof(ClassEntites.Agent);
            // 
            // frmAgtInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(agencyIdLabel);
            this.Controls.Add(this.agencyIdLabel1);
            this.Controls.Add(agtBusPhoneLabel);
            this.Controls.Add(this.agtBusPhoneLabel1);
            this.Controls.Add(agtEmailLabel);
            this.Controls.Add(this.agtEmailLabel1);
            this.Controls.Add(agtFirstNameLabel);
            this.Controls.Add(this.agtFirstNameLabel1);
            this.Controls.Add(agtLastNameLabel);
            this.Controls.Add(this.agtLastNameLabel1);
            this.Controls.Add(agtMiddleInitialLabel);
            this.Controls.Add(this.agtMiddleInitialLabel1);
            this.Controls.Add(agtPositionLabel);
            this.Controls.Add(this.agtPositionLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgtInfo";
            this.Text = "frmAgtInfo";
            this.Load += new System.EventHandler(this.frmAgtInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.Label agencyIdLabel1;
        private System.Windows.Forms.Label agtBusPhoneLabel1;
        private System.Windows.Forms.Label agtEmailLabel1;
        private System.Windows.Forms.Label agtFirstNameLabel1;
        private System.Windows.Forms.Label agtLastNameLabel1;
        private System.Windows.Forms.Label agtMiddleInitialLabel1;
        private System.Windows.Forms.Label agtPositionLabel1;
    }
}