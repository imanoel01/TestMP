namespace MP
{
    partial class CreateMP
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbMp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbResidence = new System.Windows.Forms.ComboBox();
            this.Residence = new System.Windows.Forms.Label();
            this.cmbBelief = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecondname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // cmbMp
            // 
            this.cmbMp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMp.FormattingEnabled = true;
            this.cmbMp.Location = new System.Drawing.Point(146, 119);
            this.cmbMp.Name = "cmbMp";
            this.cmbMp.Size = new System.Drawing.Size(158, 21);
            this.cmbMp.TabIndex = 2;
            this.cmbMp.SelectedIndexChanged += new System.EventHandler(this.CmbMp_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "MP Type";
            // 
            // cmbResidence
            // 
            this.cmbResidence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResidence.FormattingEnabled = true;
            this.cmbResidence.Location = new System.Drawing.Point(146, 191);
            this.cmbResidence.Name = "cmbResidence";
            this.cmbResidence.Size = new System.Drawing.Size(158, 21);
            this.cmbResidence.TabIndex = 4;
            // 
            // Residence
            // 
            this.Residence.AutoSize = true;
            this.Residence.Location = new System.Drawing.Point(34, 192);
            this.Residence.Name = "Residence";
            this.Residence.Size = new System.Drawing.Size(58, 13);
            this.Residence.TabIndex = 17;
            this.Residence.Text = "Residence";
            // 
            // cmbBelief
            // 
            this.cmbBelief.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBelief.FormattingEnabled = true;
            this.cmbBelief.Location = new System.Drawing.Point(146, 154);
            this.cmbBelief.Name = "cmbBelief";
            this.cmbBelief.Size = new System.Drawing.Size(158, 21);
            this.cmbBelief.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Belief";
            // 
            // txtSecondname
            // 
            this.txtSecondname.Location = new System.Drawing.Point(146, 85);
            this.txtSecondname.Name = "txtSecondname";
            this.txtSecondname.Size = new System.Drawing.Size(158, 20);
            this.txtSecondname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Secondname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(146, 45);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(158, 20);
            this.txtFirstname.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Firstname";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.txtSecondname);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMp);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbResidence);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Residence);
            this.groupBox1.Controls.Add(this.cmbBelief);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 344);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New MP";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(252, 282);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CreateMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateMP";
            this.Size = new System.Drawing.Size(549, 344);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbMp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbResidence;
        private System.Windows.Forms.Label Residence;
        private System.Windows.Forms.ComboBox cmbBelief;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSecondname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
    }
}
