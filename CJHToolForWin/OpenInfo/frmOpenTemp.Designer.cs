namespace CJH.CJHToolForWin
{
    partial class frmOpenTemp
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxCommonJobNum = new System.Windows.Forms.ComboBox();
            this.cboxCustomer = new System.Windows.Forms.ComboBox();
            this.btnCopyPwd = new System.Windows.Forms.Button();
            this.btnCopyJN = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCAID = new System.Windows.Forms.Button();
            this.btnSCID = new System.Windows.Forms.Button();
            this.btnNewSave = new System.Windows.Forms.Button();
            this.txtCAID = new System.Windows.Forms.TextBox();
            this.txtSCID = new System.Windows.Forms.TextBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cboxGroup = new System.Windows.Forms.ComboBox();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.btnSearchGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // cboxCommonJobNum
            // 
            this.cboxCommonJobNum.FormattingEnabled = true;
            this.cboxCommonJobNum.Location = new System.Drawing.Point(91, 0);
            this.cboxCommonJobNum.Name = "cboxCommonJobNum";
            this.cboxCommonJobNum.Size = new System.Drawing.Size(161, 20);
            this.cboxCommonJobNum.TabIndex = 128;
            // 
            // cboxCustomer
            // 
            this.cboxCustomer.FormattingEnabled = true;
            this.cboxCustomer.Location = new System.Drawing.Point(0, 0);
            this.cboxCustomer.Name = "cboxCustomer";
            this.cboxCustomer.Size = new System.Drawing.Size(90, 20);
            this.cboxCustomer.TabIndex = 129;
            // 
            // btnCopyPwd
            // 
            this.btnCopyPwd.Location = new System.Drawing.Point(284, 0);
            this.btnCopyPwd.Name = "btnCopyPwd";
            this.btnCopyPwd.Size = new System.Drawing.Size(38, 20);
            this.btnCopyPwd.TabIndex = 131;
            this.btnCopyPwd.Text = "cPWD";
            this.btnCopyPwd.UseVisualStyleBackColor = true;
            // 
            // btnCopyJN
            // 
            this.btnCopyJN.Location = new System.Drawing.Point(252, 0);
            this.btnCopyJN.Name = "btnCopyJN";
            this.btnCopyJN.Size = new System.Drawing.Size(32, 20);
            this.btnCopyJN.TabIndex = 130;
            this.btnCopyJN.Text = "cJN";
            this.btnCopyJN.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(110, 51);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(44, 21);
            this.btnEdit.TabIndex = 284;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnCAID
            // 
            this.btnCAID.Location = new System.Drawing.Point(-2, 72);
            this.btnCAID.Name = "btnCAID";
            this.btnCAID.Size = new System.Drawing.Size(27, 21);
            this.btnCAID.TabIndex = 283;
            this.btnCAID.Text = "CAID";
            this.btnCAID.UseVisualStyleBackColor = true;
            // 
            // btnSCID
            // 
            this.btnSCID.Location = new System.Drawing.Point(-2, 51);
            this.btnSCID.Name = "btnSCID";
            this.btnSCID.Size = new System.Drawing.Size(27, 21);
            this.btnSCID.TabIndex = 282;
            this.btnSCID.Text = "SCID";
            this.btnSCID.UseVisualStyleBackColor = true;
            // 
            // btnNewSave
            // 
            this.btnNewSave.Location = new System.Drawing.Point(110, 72);
            this.btnNewSave.Name = "btnNewSave";
            this.btnNewSave.Size = new System.Drawing.Size(44, 21);
            this.btnNewSave.TabIndex = 281;
            this.btnNewSave.Text = "保存";
            this.btnNewSave.UseVisualStyleBackColor = true;
            // 
            // txtCAID
            // 
            this.txtCAID.Location = new System.Drawing.Point(26, 72);
            this.txtCAID.MaxLength = 11;
            this.txtCAID.Name = "txtCAID";
            this.txtCAID.Size = new System.Drawing.Size(83, 21);
            this.txtCAID.TabIndex = 280;
            // 
            // txtSCID
            // 
            this.txtSCID.AllowDrop = true;
            this.txtSCID.Location = new System.Drawing.Point(26, 51);
            this.txtSCID.MaxLength = 12;
            this.txtSCID.Name = "txtSCID";
            this.txtSCID.Size = new System.Drawing.Size(83, 21);
            this.txtSCID.TabIndex = 279;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(328, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(457, 94);
            this.dgvList.TabIndex = 285;
            // 
            // cboxGroup
            // 
            this.cboxGroup.FormattingEnabled = true;
            this.cboxGroup.Location = new System.Drawing.Point(160, 21);
            this.cboxGroup.Name = "cboxGroup";
            this.cboxGroup.Size = new System.Drawing.Size(162, 20);
            this.cboxGroup.TabIndex = 287;
            // 
            // txtGroup
            // 
            this.txtGroup.AllowDrop = true;
            this.txtGroup.Location = new System.Drawing.Point(0, 20);
            this.txtGroup.MaxLength = 12;
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(135, 21);
            this.txtGroup.TabIndex = 286;
            // 
            // btnSearchGroup
            // 
            this.btnSearchGroup.Location = new System.Drawing.Point(136, 20);
            this.btnSearchGroup.Name = "btnSearchGroup";
            this.btnSearchGroup.Size = new System.Drawing.Size(22, 21);
            this.btnSearchGroup.TabIndex = 288;
            this.btnSearchGroup.Text = "查";
            this.btnSearchGroup.UseVisualStyleBackColor = true;
            // 
            // frmOpenTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 93);
            this.Controls.Add(this.btnSearchGroup);
            this.Controls.Add(this.cboxGroup);
            this.Controls.Add(this.txtGroup);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCAID);
            this.Controls.Add(this.btnSCID);
            this.Controls.Add(this.btnNewSave);
            this.Controls.Add(this.txtCAID);
            this.Controls.Add(this.txtSCID);
            this.Controls.Add(this.btnCopyPwd);
            this.Controls.Add(this.btnCopyJN);
            this.Controls.Add(this.cboxCustomer);
            this.Controls.Add(this.cboxCommonJobNum);
            this.MaximizeBox = false;
            this.Name = "frmOpenTemp";
            this.Text = "开户记录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxCommonJobNum;
        private System.Windows.Forms.ComboBox cboxCustomer;
        private System.Windows.Forms.Button btnCopyPwd;
        private System.Windows.Forms.Button btnCopyJN;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCAID;
        private System.Windows.Forms.Button btnSCID;
        private System.Windows.Forms.Button btnNewSave;
        private System.Windows.Forms.TextBox txtCAID;
        private System.Windows.Forms.TextBox txtSCID;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ComboBox cboxGroup;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Button btnSearchGroup;
    }
}