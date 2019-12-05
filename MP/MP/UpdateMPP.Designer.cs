namespace MP
{
    partial class UpdateMPP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.gdvSearch = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cmbMp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbResidence);
            this.groupBox1.Controls.Add(this.Residence);
            this.groupBox1.Controls.Add(this.cmbBelief);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSecondname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFirstname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 503);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Update MP Records";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.gdvSearch);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(301, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 484);
            this.panel1.TabIndex = 37;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(216, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // gdvSearch
            // 
            this.gdvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdvSearch.Location = new System.Drawing.Point(14, 51);
            this.gdvSearch.Name = "gdvSearch";
            this.gdvSearch.Size = new System.Drawing.Size(607, 276);
            this.gdvSearch.TabIndex = 2;
            this.gdvSearch.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GdvSearch_RowHeaderMouseClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmbMp
            // 
            this.cmbMp.Enabled = false;
            this.cmbMp.FormattingEnabled = true;
            this.cmbMp.Location = new System.Drawing.Point(122, 239);
            this.cmbMp.Name = "cmbMp";
            this.cmbMp.Size = new System.Drawing.Size(158, 21);
            this.cmbMp.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "MP Type";
            // 
            // cmbResidence
            // 
            this.cmbResidence.FormattingEnabled = true;
            this.cmbResidence.Location = new System.Drawing.Point(122, 194);
            this.cmbResidence.Name = "cmbResidence";
            this.cmbResidence.Size = new System.Drawing.Size(158, 21);
            this.cmbResidence.TabIndex = 6;
            // 
            // Residence
            // 
            this.Residence.AutoSize = true;
            this.Residence.Location = new System.Drawing.Point(10, 195);
            this.Residence.Name = "Residence";
            this.Residence.Size = new System.Drawing.Size(58, 13);
            this.Residence.TabIndex = 32;
            this.Residence.Text = "Residence";
            // 
            // cmbBelief
            // 
            this.cmbBelief.FormattingEnabled = true;
            this.cmbBelief.Location = new System.Drawing.Point(122, 147);
            this.cmbBelief.Name = "cmbBelief";
            this.cmbBelief.Size = new System.Drawing.Size(158, 21);
            this.cmbBelief.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Belief";
            // 
            // txtSecondname
            // 
            this.txtSecondname.Location = new System.Drawing.Point(122, 111);
            this.txtSecondname.Name = "txtSecondname";
            this.txtSecondname.Size = new System.Drawing.Size(158, 20);
            this.txtSecondname.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Secondname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(122, 71);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(158, 20);
            this.txtFirstname.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Firstname";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(217, 292);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // UpdateMPP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "UpdateMPP";
            this.Size = new System.Drawing.Size(946, 503);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView gdvSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
    }
}
