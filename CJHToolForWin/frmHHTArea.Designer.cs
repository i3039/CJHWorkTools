namespace CJH.CJHToolForWin
{
    partial class frmHHTArea
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtHHTAreaName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblAreaName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地区编码:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(68, 5);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(93, 21);
            this.txtCode.TabIndex = 1;
            // 
            // txtHHTAreaName
            // 
            this.txtHHTAreaName.Location = new System.Drawing.Point(68, 32);
            this.txtHHTAreaName.Name = "txtHHTAreaName";
            this.txtHHTAreaName.Size = new System.Drawing.Size(152, 21);
            this.txtHHTAreaName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "地区名称:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(226, 32);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 21);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(5, 76);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.Size = new System.Drawing.Size(311, 457);
            this.dgvList.TabIndex = 6;
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(7, 61);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(35, 12);
            this.lblRemark.TabIndex = 7;
            this.lblRemark.Text = "说明:";
            // 
            // lblAreaName
            // 
            this.lblAreaName.AutoSize = true;
            this.lblAreaName.ForeColor = System.Drawing.Color.Maroon;
            this.lblAreaName.Location = new System.Drawing.Point(178, 8);
            this.lblAreaName.Name = "lblAreaName";
            this.lblAreaName.Size = new System.Drawing.Size(0, 12);
            this.lblAreaName.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(274, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(42, 21);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // frmHHTArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 545);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAreaName);
            this.Controls.Add(this.lblRemark);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtHHTAreaName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Name = "frmHHTArea";
            this.Text = "户户通乡镇村名管理";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtHHTAreaName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblAreaName;
        private System.Windows.Forms.Button btnSearch;
    }
}