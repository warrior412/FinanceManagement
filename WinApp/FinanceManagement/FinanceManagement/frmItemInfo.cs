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
    public partial class frmItemInfo : Form
    {
        private FinanceManagement.DataSet.FinanceManagement.M_CategoryRow currentCategory = null;

        public FinanceManagement.DataSet.FinanceManagement.M_CategoryRow CurrentCategory
        {
            get { return currentCategory; }
            set {
                currentCategory = value; 
                if(currentCategory!=null)
                {
                    lblCategory.Text = currentCategory.Category_Name;
                }
            }
        }
        private FinanceManagement.DataSet.FinanceManagement.M_ItemRow currentItem = null;

        public FinanceManagement.DataSet.FinanceManagement.M_ItemRow CurrentItem
        {
            get { return currentItem; }
            set { 
                currentItem = value; 
                if(currentItem==null)
                {
                    lblStatus.Text = "Tạo mới";
                }else
                {

                }
            }
        }
        public frmItemInfo(FinanceManagement.DataSet.FinanceManagement.M_CategoryRow category,FinanceManagement.DataSet.FinanceManagement.M_ItemRow item)
        {
            InitializeComponent();
            CurrentCategory = category;
            CurrentItem = item;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(currentItem==null)
            {
                m_ItemTableAdapter1.Item_Insert(txtName.Text, currentCategory.Category_ID);
            }
            else
            {
                m_ItemTableAdapter1.Item_Update(txtName.Text,currentItem.Item_Status,currentItem.Item_ID);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
