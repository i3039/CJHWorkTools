namespace CJH.CJHToolForWin
{
    partial class frmMidParent
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNewOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenImport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMoveReplaceM = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMoveReplace = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmJCodeSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.查询工号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返修ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRepairBoarding = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmToFac = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNewName = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNewTel = new System.Windows.Forms.ToolStripMenuItem();
            this.copyNewAddress = new System.Windows.Forms.ToolStripMenuItem();
            this.StopRectTimer = new System.Windows.Forms.Timer(this.components);
            this.tsmActionM = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开户ToolStripMenuItem,
            this.tsmMoveReplaceM,
            this.tsmJCodeSearch,
            this.返修ToolStripMenuItem,
            this.copyNewName,
            this.copyNewTel,
            this.copyNewAddress});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 开户ToolStripMenuItem
            // 
            this.开户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewOpen,
            this.tsmOpenSearch,
            this.tsmOpenImport});
            this.开户ToolStripMenuItem.Name = "开户ToolStripMenuItem";
            this.开户ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.开户ToolStripMenuItem.Text = "开户";
            // 
            // tsmNewOpen
            // 
            this.tsmNewOpen.Name = "tsmNewOpen";
            this.tsmNewOpen.Size = new System.Drawing.Size(118, 22);
            this.tsmNewOpen.Text = "新开户";
            // 
            // tsmOpenSearch
            // 
            this.tsmOpenSearch.Name = "tsmOpenSearch";
            this.tsmOpenSearch.Size = new System.Drawing.Size(118, 22);
            this.tsmOpenSearch.Text = "开户查询";
            // 
            // tsmOpenImport
            // 
            this.tsmOpenImport.Name = "tsmOpenImport";
            this.tsmOpenImport.Size = new System.Drawing.Size(118, 22);
            this.tsmOpenImport.Text = "数据导入";
            // 
            // tsmMoveReplaceM
            // 
            this.tsmMoveReplaceM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMoveReplace,
            this.tsmActionM});
            this.tsmMoveReplaceM.Name = "tsmMoveReplaceM";
            this.tsmMoveReplaceM.Size = new System.Drawing.Size(77, 20);
            this.tsmMoveReplaceM.Text = "移机与替换";
            // 
            // tsmMoveReplace
            // 
            this.tsmMoveReplace.Name = "tsmMoveReplace";
            this.tsmMoveReplace.Size = new System.Drawing.Size(152, 22);
            this.tsmMoveReplace.Text = "移机与替换";
            // 
            // tsmJCodeSearch
            // 
            this.tsmJCodeSearch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询工号ToolStripMenuItem});
            this.tsmJCodeSearch.Name = "tsmJCodeSearch";
            this.tsmJCodeSearch.Size = new System.Drawing.Size(65, 20);
            this.tsmJCodeSearch.Text = "工号管理";
            // 
            // 查询工号ToolStripMenuItem
            // 
            this.查询工号ToolStripMenuItem.Name = "查询工号ToolStripMenuItem";
            this.查询工号ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查询工号ToolStripMenuItem.Text = "查询工号";
            // 
            // 返修ToolStripMenuItem
            // 
            this.返修ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRepairBoarding,
            this.tsmToFac});
            this.返修ToolStripMenuItem.Name = "返修ToolStripMenuItem";
            this.返修ToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.返修ToolStripMenuItem.Text = "返修";
            // 
            // tsmRepairBoarding
            // 
            this.tsmRepairBoarding.Name = "tsmRepairBoarding";
            this.tsmRepairBoarding.Size = new System.Drawing.Size(152, 22);
            this.tsmRepairBoarding.Text = "返修登记";
            // 
            // tsmToFac
            // 
            this.tsmToFac.Name = "tsmToFac";
            this.tsmToFac.Size = new System.Drawing.Size(152, 22);
            this.tsmToFac.Text = "返厂处理";
            // 
            // copyNewName
            // 
            this.copyNewName.Name = "copyNewName";
            this.copyNewName.Size = new System.Drawing.Size(59, 20);
            this.copyNewName.Text = "NewName";
            // 
            // copyNewTel
            // 
            this.copyNewTel.Name = "copyNewTel";
            this.copyNewTel.Size = new System.Drawing.Size(53, 20);
            this.copyNewTel.Text = "NewTel";
            // 
            // copyNewAddress
            // 
            this.copyNewAddress.Name = "copyNewAddress";
            this.copyNewAddress.Size = new System.Drawing.Size(53, 20);
            this.copyNewAddress.Text = "NewAdr";
            // 
            // tsmActionM
            // 
            this.tsmActionM.Name = "tsmActionM";
            this.tsmActionM.Size = new System.Drawing.Size(152, 22);
            this.tsmActionM.Text = "刷模块";
            // 
            // frmMidParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 123);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMidParent";
            this.Text = "户户通工具";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmNewOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenSearch;
        private System.Windows.Forms.ToolStripMenuItem tsmOpenImport;
        private System.Windows.Forms.ToolStripMenuItem tsmMoveReplaceM;
        private System.Windows.Forms.ToolStripMenuItem tsmMoveReplace;
        private System.Windows.Forms.ToolStripMenuItem tsmJCodeSearch;
        private System.Windows.Forms.ToolStripMenuItem 查询工号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返修ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmRepairBoarding;
        private System.Windows.Forms.ToolStripMenuItem tsmToFac;
        private System.Windows.Forms.ToolStripMenuItem copyNewName;
        private System.Windows.Forms.ToolStripMenuItem copyNewTel;
        private System.Windows.Forms.ToolStripMenuItem copyNewAddress;
        private System.Windows.Forms.Timer StopRectTimer;
        private System.Windows.Forms.ToolStripMenuItem tsmActionM;
    }
}