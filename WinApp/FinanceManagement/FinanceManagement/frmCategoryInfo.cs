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
    public partial class frmCategoryInfo : Form
    {
        private FinanceManagement.DataSet.FinanceManagement.M_CategoryRow selectedCategory = null;

        public FinanceManagement.DataSet.FinanceManagement.M_CategoryRow SelectedCategory
        {
            get { return selectedCategory; }
            set {
                selectedCategory = value; 
                if(selectedCategory==null)
                {
                    lblStatus.Text = "Tạo mới";
                }
                else
                {

                }
            }
        }
        public frmCategoryInfo(FinanceManagement.DataSet.FinanceManagement.M_CategoryRow data)
        {
            InitializeComponent();
            SelectedCategory = data;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(SelectedCategory==null)
            {
                m_CategoryTableAdapter1.Category_Insert(txtCategoryName.Text, txtDescription.Text,AppContext.GetInstance().UserInfo.Username);
            }
            else
            {
                m_CategoryTableAdapter1.Category_Update(txtCategoryName.Text,txtDescription.Text,SelectedCategory.Category_Status);
            }
            DialogResult = DialogResult.OK;
        }
    }
}
