namespace FinanceManagement
{
    partial class frmWalletManagement
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
            this.layoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.lvWallet = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddNewWallet = new System.Windows.Forms.Button();
            this.layoutListWallet = new System.Windows.Forms.TableLayoutPanel();
            this.layoutDatailInfo = new System.Windows.Forms.TableLayoutPanel();
            this.customTitlePanel5 = new FinanceManagement.Custom.CustomTitlePanel();
            this.customTitlePanel1 = new FinanceManagement.Custom.CustomTitlePanel();
            this.layoutMain.SuspendLayout();
            this.layoutListWallet.SuspendLayout();
            this.layoutDatailInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutMain
            // 
            this.layoutMain.ColumnCount = 2;
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.layoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Controls.Add(this.layoutListWallet, 0, 0);
            this.layoutMain.Controls.Add(this.layoutDatailInfo, 1, 0);
            this.layoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutMain.Location = new System.Drawing.Point(0, 0);
            this.layoutMain.Margin = new System.Windows.Forms.Padding(0);
            this.layoutMain.Name = "layoutMain";
            this.layoutMain.RowCount = 1;
            this.layoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutMain.Size = new System.Drawing.Size(1370, 621);
            this.layoutMain.TabIndex = 0;
            // 
            // lvWallet
            // 
            this.lvWallet.AutoScroll = true;
            this.lvWallet.ColumnCount = 1;
            this.lvWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lvWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWallet.Location = new System.Drawing.Point(5, 37);
            this.lvWallet.Name = "lvWallet";
            this.lvWallet.RowCount = 1;
            this.lvWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lvWallet.Size = new System.Drawing.Size(390, 535);
            this.lvWallet.TabIndex = 0;
            // 
            // btnAddNewWallet
            // 
            this.btnAddNewWallet.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddNewWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNewWallet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddNewWallet.FlatAppearance.BorderSize = 0;
            this.btnAddNewWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewWallet.Location = new System.Drawing.Point(3, 578);
            this.btnAddNewWallet.Margin = new System.Windows.Forms.Padding(1);
            this.btnAddNewWallet.Name = "btnAddNewWallet";
            this.btnAddNewWallet.Size = new System.Drawing.Size(394, 38);
            this.btnAddNewWallet.TabIndex = 1;
            this.btnAddNewWallet.Text = "Add new wallet";
            this.btnAddNewWallet.UseVisualStyleBackColor = false;
            this.btnAddNewWallet.Click += new System.EventHandler(this.btnAddNewWallet_Click);
            // 
            // layoutListWallet
            // 
            this.layoutListWallet.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.layoutListWallet.ColumnCount = 1;
            this.layoutListWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutListWallet.Controls.Add(this.btnAddNewWallet, 0, 2);
            this.layoutListWallet.Controls.Add(this.lvWallet, 0, 1);
            this.layoutListWallet.Controls.Add(this.customTitlePanel5, 0, 0);
            this.layoutListWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutListWallet.Location = new System.Drawing.Point(0, 0);
            this.layoutListWallet.Margin = new System.Windows.Forms.Padding(0);
            this.layoutListWallet.Name = "layoutListWallet";
            this.layoutListWallet.RowCount = 3;
            this.layoutListWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutListWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutListWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.layoutListWallet.Size = new System.Drawing.Size(400, 621);
            this.layoutListWallet.TabIndex = 2;
            // 
            // layoutDatailInfo
            // 
            this.layoutDatailInfo.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.layoutDatailInfo.ColumnCount = 1;
            this.layoutDatailInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDatailInfo.Controls.Add(this.customTitlePanel1, 0, 0);
            this.layoutDatailInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutDatailInfo.Location = new System.Drawing.Point(400, 0);
            this.layoutDatailInfo.Margin = new System.Windows.Forms.Padding(0);
            this.layoutDatailInfo.Name = "layoutDatailInfo";
            this.layoutDatailInfo.RowCount = 2;
            this.layoutDatailInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.layoutDatailInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.layoutDatailInfo.Size = new System.Drawing.Size(970, 621);
            this.layoutDatailInfo.TabIndex = 3;
            // 
            // customTitlePanel5
            // 
            this.customTitlePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTitlePanel5.Location = new System.Drawing.Point(2, 2);
            this.customTitlePanel5.Margin = new System.Windows.Forms.Padding(0);
            this.customTitlePanel5.Name = "customTitlePanel5";
            this.customTitlePanel5.Size = new System.Drawing.Size(396, 30);
            this.customTitlePanel5.TabIndex = 2;
            // 
            // customTitlePanel1
            // 
            this.customTitlePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTitlePanel1.Location = new System.Drawing.Point(2, 2);
            this.customTitlePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.customTitlePanel1.Name = "customTitlePanel1";
            this.customTitlePanel1.Size = new System.Drawing.Size(966, 30);
            this.customTitlePanel1.TabIndex = 0;
            // 
            // frmWalletManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 621);
            this.ControlBox = false;
            this.Controls.Add(this.layoutMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWalletManagement";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý ví tiền";
            this.layoutMain.ResumeLayout(false);
            this.layoutListWallet.ResumeLayout(false);
            this.layoutDatailInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel layoutMain;
        private System.Windows.Forms.TableLayoutPanel lvWallet;
        private System.Windows.Forms.Button btnAddNewWallet;
        private System.Windows.Forms.TableLayoutPanel layoutListWallet;
        private Custom.CustomTitlePanel customTitlePanel5;
        private System.Windows.Forms.TableLayoutPanel layoutDatailInfo;
        private Custom.CustomTitlePanel customTitlePanel1;
    }
}