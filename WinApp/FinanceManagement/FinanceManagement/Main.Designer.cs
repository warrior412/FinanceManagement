namespace FinanceManagement
{
    partial class Main
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnWalletManagement = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnItemManagement = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnWalletManagement,
            this.toolStripSeparator1,
            this.btnItemManagement,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(894, 70);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnWalletManagement
            // 
            this.btnWalletManagement.AutoSize = false;
            this.btnWalletManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnWalletManagement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnWalletManagement.Image = global::FinanceManagement.Properties.Resources.Wallet_icon;
            this.btnWalletManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnWalletManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWalletManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnWalletManagement.Name = "btnWalletManagement";
            this.btnWalletManagement.Size = new System.Drawing.Size(100, 70);
            this.btnWalletManagement.Text = "VÍ TIỀN";
            this.btnWalletManagement.Click += new System.EventHandler(this.btnWalletManagement_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // btnItemManagement
            // 
            this.btnItemManagement.AutoSize = false;
            this.btnItemManagement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItemManagement.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnItemManagement.Image = global::FinanceManagement.Properties.Resources.dollar_folder_icon;
            this.btnItemManagement.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnItemManagement.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemManagement.Margin = new System.Windows.Forms.Padding(0);
            this.btnItemManagement.Name = "btnItemManagement";
            this.btnItemManagement.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnItemManagement.Size = new System.Drawing.Size(100, 70);
            this.btnItemManagement.Text = "MỤC CHI TIÊU";
            this.btnItemManagement.Click += new System.EventHandler(this.btnItemManagement_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 53);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 485);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.Text = "Finance Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnWalletManagement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnItemManagement;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

