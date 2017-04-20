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
    public partial class frmActivityManagement : Form
    {
        private FinanceManagement.DataSet.FinanceManagement.M_WalletRow walletData;

        public FinanceManagement.DataSet.FinanceManagement.M_WalletRow WalletData
        {
            get { return walletData; }
            set { 
                walletData = value;
                lblWalletName.Text = walletData.Wallet_Content;
                lblWalletName_2.Text = walletData.Wallet_Content;
                lblWalletName_3.Text = walletData.Wallet_Content;
            }
        }

        public frmActivityManagement(FinanceManagement.DataSet.FinanceManagement.M_WalletRow wallet)
        {
            InitializeComponent();
            WalletData = wallet;

            m_CategoryTableAdapter1 = new DataSet.FinanceManagementTableAdapters.M_CategoryTableAdapter();
            m_ItemTableAdapter1 = new DataSet.FinanceManagementTableAdapters.M_ItemTableAdapter();
            m_WalletTableAdapter1 = new DataSet.FinanceManagementTableAdapters.M_WalletTableAdapter();
            t_ActivityTableAdapter1 = new DataSet.FinanceManagementTableAdapters.T_ActivityTableAdapter();

            mCategoryBindingSource.CurrentItemChanged += mCategoryBindingSource_CurrentItemChanged;

            FillData();
        }

        void mCategoryBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            //Fill Item
            if (cbxCategory.SelectedValue == null)
                return;
            mItemBindingSource.DataSource = m_ItemTableAdapter1.Item_GetByCategory((int)cbxCategory.SelectedValue);
            cbxItem.DataSource = mItemBindingSource;
        }

        public void FillData()
        {
            //Fill Category
            mCategoryBindingSource.DataSource = m_CategoryTableAdapter1.Category_GetAll(AppContext.GetInstance().UserInfo.Username);
            cbxCategory.DataSource = mCategoryBindingSource;
            //Fill Wallet
            FinanceManagement.DataSet.FinanceManagement.M_WalletDataTable tblWallet = 
                m_WalletTableAdapter1.Wallet_GetAll(AppContext.GetInstance().UserInfo.Username);

            foreach(var item in tblWallet)
            {
                if(walletData.Wallet_ID==item.Wallet_ID)
                {
                    tblWallet.Rows.Remove(item);
                    break;
                }
            }
            mWalletBindingSource.DataSource = tblWallet;
            cbxWallet.DataSource = mWalletBindingSource;
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            if(ShowConfirmMessage()==DialogResult.OK)
            {
                t_ActivityTableAdapter1.Activity_Withdraw(walletData.Wallet_ID, getDateTime(), double.Parse(txtWithDrawAmount.Text), txtDescription.Text, (int)cbxItem.SelectedValue);
            }
        }

        private DialogResult ShowConfirmMessage()
        {
            return MessageBox.Show("Để lưu thông tin, vui lòng nhấn OK.","Xác nhận" ,MessageBoxButtons.OKCancel);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (ShowConfirmMessage() == DialogResult.OK)
            {
                t_ActivityTableAdapter1.Activity_Deposit(getDateTime(), walletData.Wallet_ID, double.Parse(txtDepositAmount.Text), cbxDeposit.Text);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (ShowConfirmMessage() == DialogResult.OK)
            {
                t_ActivityTableAdapter1.Activity_Transfer(getDateTime(), walletData.Wallet_ID, double.Parse(txtTransferAmount.Text), txtDescription.Text, (int)cbxWallet.SelectedValue);
            }
        }

        private DateTime getDateTime()
        {
            DateTime current = DateTime.Now;
            DateTime selectedDate = dateTimePicker1.Value;
            return new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day, current.Hour, current.Minute, current.Second, current.Millisecond);
        }
    }
}
