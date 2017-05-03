namespace FinanceManagement
{
    partial class frmItemManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.customTitlePanel2 = new FinanceManagement.Custom.CustomTitlePanel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dvItem = new System.Windows.Forms.DataGridView();
            this.itemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financeManagement = new FinanceManagement.DataSet.FinanceManagement();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dvCategory = new System.Windows.Forms.DataGridView();
            this.categoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customTitlePanel1 = new FinanceManagement.Custom.CustomTitlePanel();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.m_CategoryTableAdapter1 = new FinanceManagement.DataSet.FinanceManagementTableAdapters.M_CategoryTableAdapter();
            this.m_ItemTableAdapter1 = new FinanceManagement.DataSet.FinanceManagementTableAdapters.M_ItemTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeManagement)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCategoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(687, 456);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.customTitlePanel2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnAddItem, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.dvItem, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(449, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(235, 450);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // customTitlePanel2
            // 
            this.customTitlePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTitlePanel2.Location = new System.Drawing.Point(3, 3);
            this.customTitlePanel2.Name = "customTitlePanel2";
            this.customTitlePanel2.Size = new System.Drawing.Size(229, 24);
            this.customTitlePanel2.TabIndex = 0;
            this.customTitlePanel2.Title = "Danh sách mục chi tiêu";
            this.customTitlePanel2.Type = FinanceManagement.Custom.CustomTitlePanelType.Default;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddItem.Location = new System.Drawing.Point(3, 423);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(229, 24);
            this.btnAddItem.TabIndex = 1;
            this.btnAddItem.Text = "Tạo mới danh mục chi tiêu";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dvItem
            // 
            this.dvItem.AllowUserToAddRows = false;
            this.dvItem.AllowUserToDeleteRows = false;
            this.dvItem.AutoGenerateColumns = false;
            this.dvItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemIDDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.itemStatusDataGridViewTextBoxColumn});
            this.dvItem.DataSource = this.mItemBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvItem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dvItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvItem.Location = new System.Drawing.Point(3, 33);
            this.dvItem.Name = "dvItem";
            this.dvItem.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dvItem.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvItem.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dvItem.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvItem.RowTemplate.Height = 30;
            this.dvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvItem.Size = new System.Drawing.Size(229, 384);
            this.dvItem.TabIndex = 2;
            // 
            // itemIDDataGridViewTextBoxColumn
            // 
            this.itemIDDataGridViewTextBoxColumn.DataPropertyName = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.HeaderText = "Item_ID";
            this.itemIDDataGridViewTextBoxColumn.Name = "itemIDDataGridViewTextBoxColumn";
            this.itemIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "Item_Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.itemNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.itemNameDataGridViewTextBoxColumn.HeaderText = "Tên mục chi tiêu";
            this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryDataGridViewTextBoxColumn.Visible = false;
            // 
            // itemStatusDataGridViewTextBoxColumn
            // 
            this.itemStatusDataGridViewTextBoxColumn.DataPropertyName = "Item_Status";
            this.itemStatusDataGridViewTextBoxColumn.HeaderText = "Item_Status";
            this.itemStatusDataGridViewTextBoxColumn.Name = "itemStatusDataGridViewTextBoxColumn";
            this.itemStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // mItemBindingSource
            // 
            this.mItemBindingSource.DataMember = "M_Item";
            this.mItemBindingSource.DataSource = this.financeManagement;
            // 
            // financeManagement
            // 
            this.financeManagement.DataSetName = "FinanceManagement";
            this.financeManagement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dvCategory, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.customTitlePanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnAddCategory, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 450);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dvCategory
            // 
            this.dvCategory.AllowUserToAddRows = false;
            this.dvCategory.AllowUserToDeleteRows = false;
            this.dvCategory.AllowUserToResizeRows = false;
            this.dvCategory.AutoGenerateColumns = false;
            this.dvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryIDDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.categoryDescriptionDataGridViewTextBoxColumn,
            this.categoryStatusDataGridViewTextBoxColumn});
            this.dvCategory.DataSource = this.mCategoryBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dvCategory.DefaultCellStyle = dataGridViewCellStyle7;
            this.dvCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvCategory.Location = new System.Drawing.Point(3, 33);
            this.dvCategory.Name = "dvCategory";
            this.dvCategory.ReadOnly = true;
            this.dvCategory.RowHeadersVisible = false;
            this.dvCategory.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dvCategory.RowTemplate.Height = 30;
            this.dvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvCategory.Size = new System.Drawing.Size(434, 384);
            this.dvCategory.TabIndex = 0;
            this.dvCategory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dvCategory_MouseClick);
            // 
            // categoryIDDataGridViewTextBoxColumn
            // 
            this.categoryIDDataGridViewTextBoxColumn.DataPropertyName = "Category_ID";
            this.categoryIDDataGridViewTextBoxColumn.FillWeight = 45.68528F;
            this.categoryIDDataGridViewTextBoxColumn.HeaderText = "Mã";
            this.categoryIDDataGridViewTextBoxColumn.MinimumWidth = 30;
            this.categoryIDDataGridViewTextBoxColumn.Name = "categoryIDDataGridViewTextBoxColumn";
            this.categoryIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "Category_Name";
            this.categoryNameDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Tên danh mục";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDescriptionDataGridViewTextBoxColumn
            // 
            this.categoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Category_Description";
            this.categoryDescriptionDataGridViewTextBoxColumn.FillWeight = 127.1574F;
            this.categoryDescriptionDataGridViewTextBoxColumn.HeaderText = "Mô tả";
            this.categoryDescriptionDataGridViewTextBoxColumn.Name = "categoryDescriptionDataGridViewTextBoxColumn";
            this.categoryDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryStatusDataGridViewTextBoxColumn
            // 
            this.categoryStatusDataGridViewTextBoxColumn.DataPropertyName = "Category_Status";
            this.categoryStatusDataGridViewTextBoxColumn.HeaderText = "Category_Status";
            this.categoryStatusDataGridViewTextBoxColumn.Name = "categoryStatusDataGridViewTextBoxColumn";
            this.categoryStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.categoryStatusDataGridViewTextBoxColumn.Visible = false;
            // 
            // mCategoryBindingSource
            // 
            this.mCategoryBindingSource.DataMember = "M_Category";
            this.mCategoryBindingSource.DataSource = this.financeManagement;
            // 
            // customTitlePanel1
            // 
            this.customTitlePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customTitlePanel1.Location = new System.Drawing.Point(3, 3);
            this.customTitlePanel1.Name = "customTitlePanel1";
            this.customTitlePanel1.Size = new System.Drawing.Size(434, 24);
            this.customTitlePanel1.TabIndex = 1;
            this.customTitlePanel1.Title = "Danh sách loại hình chi tiêu";
            this.customTitlePanel1.Type = FinanceManagement.Custom.CustomTitlePanelType.Default;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCategory.Location = new System.Drawing.Point(3, 423);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(434, 24);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Tạo mới loại hình chi tiêu";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // m_CategoryTableAdapter1
            // 
            this.m_CategoryTableAdapter1.ClearBeforeFill = true;
            // 
            // m_ItemTableAdapter1
            // 
            this.m_ItemTableAdapter1.ClearBeforeFill = true;
            // 
            // frmItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 456);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmItemManagement";
            this.ShowInTaskbar = false;
            this.Text = "frmItemManagement";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financeManagement)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mCategoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Custom.CustomTitlePanel customTitlePanel2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dvCategory;
        private Custom.CustomTitlePanel customTitlePanel1;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.DataGridView dvItem;
        private System.Windows.Forms.BindingSource mCategoryBindingSource;
        private DataSet.FinanceManagement financeManagement;
        private DataSet.FinanceManagementTableAdapters.M_CategoryTableAdapter m_CategoryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryStatusDataGridViewTextBoxColumn;
        private DataSet.FinanceManagementTableAdapters.M_ItemTableAdapter m_ItemTableAdapter1;
        private System.Windows.Forms.BindingSource mItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemStatusDataGridViewTextBoxColumn;
    }
}