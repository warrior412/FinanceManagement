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
        private FinanceManagement.DataSet.FinanceManagement.M_WalletRow itemData;

        public FinanceManagement.DataSet.FinanceManagement.M_WalletRow ItemData
        {
            get { return itemData; }
            set { 
                itemData = value;
                if (itemData==null)
                {
                    lblCreateDate.Text = DateTime.Now.ToShortDateString();
                    lblStatus.Text = "Tạo mới";
                    lblUser.Text = AppContext.GetInstance().UserInfo.Fullname;
                }
                else
                {
                    txtContent.Text = itemData.Wallet_Content;
                    txtDescription.Text = itemData.Wallet_Description;
                    lblCreateDate.Text = itemData.Create_Date.ToShortDateString();
                    lblUser.Text = AppContext.GetInstance().UserInfo.Fullname;

                    switch(itemData.Wallet_Status)
                    {
                        case (int)WalletStatus.Delete:
                            lblStatus.Text = "Đã xóa";
                            break;
                        case (int)WalletStatus.Active:
                            lblStatus.Text = "Đang hoạt động";
                            break;
                        case (int)WalletStatus.Finish:
                            lblStatus.Text = "Đã hoàn thành";
                            break;
                    }
                }
            }
        }

        private bool isInsert;

        public bool IsInsert
        {
            get { return isInsert; }
            set { 
                isInsert = value;
                
                
            }
        }
        public frmWalletInfo(FinanceManagement.DataSet.FinanceManagement.M_WalletRow itemData)
        {
            InitializeComponent();
            ItemData = itemData;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validate())
                return;
            if(itemData==null)
            {
                try
                {
                    m_WalletTableAdapter1.Wallet_Insert(txtContent.Text, txtDescription.Text, DateTime.Now,AppContext.GetInstance().UserInfo.Username);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }catch(Exception ex)
                {
                    MessageBox.Show("Lưu thất bại ! Vui lòng liên hệ người quản trị.",ex.Message);
                }
            }else
            {
                try
                {
                    m_WalletTableAdapter1.Wallet_Update(txtContent.Text, txtDescription.Text,itemData.Wallet_Status,itemData.Wallet_ID);
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lưu thất bại ! Vui lòng liên hệ người quản trị.", ex.Message);
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
