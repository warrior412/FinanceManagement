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
    public partial class frmWalletInfo : Form
    {
        private bool isInsert;

        public bool IsInsert
        {
            get { return isInsert; }
            set { 
                isInsert = value;
                if(isInsert)
                {
                    lblCreateDate.Text = DateTime.Now.ToShortDateString();
                    lblStatus.Text = "Tạo mới";
                    lblUser.Text = AppContext.GetInstance().UserInfo.Fullname;
                }else
                {

                }
                
            }
        }
        public frmWalletInfo(bool mode)
        {
            InitializeComponent();
            IsInsert = mode;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validate())
                return;
            if(IsInsert)
            {
                try
                {
                    m_WalletTableAdapter1.Wallet_Insert(txtContent.Text, txtDescription.Text, DateTime.Now,AppContext.GetInstance().UserInfo.Username);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }catch(Exception ex)
                {
                    MessageBox.Show("Lưu thất bại ! Vui lòng liên hệ người quản trị.",ex.Message);
                }
            }
        }
        bool validate ()
        {
            if(txtContent.Text.Trim().Equals("")|| txtDescription.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi lưu !");
                return false;
            }
            return true;
        }
    }
}
