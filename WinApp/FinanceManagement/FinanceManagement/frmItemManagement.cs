using FinanceManagement.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagement
{
    public partial class frmItemManagement : Form
    {

        private FinanceManagement.DataSet.FinanceManagement.M_CategoryRow currentCategory = null;
        private FinanceManagement.DataSet.FinanceManagement.M_ItemRow currentItem= null;
        public frmItemManagement()
        {
            InitializeComponent();
            FillData();
        }

        public void FillData()
        {
            mCategoryBindingSource.CurrentItemChanged += mCategoryBindingSource_CurrentItemChanged;
            mItemBindingSource.CurrentItemChanged += mItemBindingSource_CurrentItemChanged;

            mCategoryBindingSource.DataSource = m_CategoryTableAdapter1.Category_GetAll(AppContext.GetInstance().UserInfo.Username);
            dvCategory.DataSource = mCategoryBindingSource;
        }

        void mItemBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if(mItemBindingSource==null || mItemBindingSource.Current==null)
            {
                return;
            }
            currentItem = ((DataRowView)mItemBindingSource.Current).Row
                as FinanceManagement.DataSet.FinanceManagement.M_ItemRow;
        }


        void mCategoryBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            currentCategory = ((DataRowView)mCategoryBindingSource.Current).Row 
                as FinanceManagement.DataSet.FinanceManagement.M_CategoryRow;
            if(currentCategory!=null)
            {
                mItemBindingSource.DataSource = m_ItemTableAdapter1.Item_GetByCategory(currentCategory.Category_ID);
                dvItem.DataSource = mItemBindingSource;
            }

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmCategoryInfo frm = new frmCategoryInfo(null);
            if(frm.ShowDialog()==DialogResult.OK)
            {
                FillData();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmItemInfo frm = new frmItemInfo(currentCategory, null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                FillData();
            }
        }

        private void dvCategory_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                

                ContextMenu m = new ContextMenu();
                int currentMouseOverRow = dvCategory.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow < 0)
                    return;

                dvCategory.CurrentCell = dvCategory.Rows[currentMouseOverRow].Cells[0];
                dvCategory.Rows[currentMouseOverRow].Selected = true;
                dvCategory.Focus();

                m.MenuItems.Add(new MenuItem("Chỉnh sửa", (o, ev) =>
                {

                    frmCategoryInfo frm = new frmCategoryInfo(currentCategory);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        FillData();
                    }
                }));
                m.MenuItems.Add(new MenuItem("Đóng"));


                

                m.Show(dvCategory, new Point(e.X, e.Y));

            }
        }

        private void dvItem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {


                ContextMenu m = new ContextMenu();
                int currentMouseOverRow = dvItem.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow < 0)
                    return;
                dvItem.CurrentCell = dvItem.Rows[currentMouseOverRow].Cells[1];
                dvItem.Rows[currentMouseOverRow].Selected = true;
                dvItem.Focus();

                m.MenuItems.Add(new MenuItem("Chỉnh sửa", (o, ev) =>
                {

                    frmItemInfo frm = new frmItemInfo(currentCategory,currentItem);
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        FillData();
                    }
                }));
                m.MenuItems.Add(new MenuItem("Đóng"));




                m.Show(dvItem, new Point(e.X, e.Y));

            }
        }

    }
}
