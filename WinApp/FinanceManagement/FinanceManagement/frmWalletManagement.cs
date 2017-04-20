using FinanceManagement.Class;
using FinanceManagement.Custom;
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
    public partial class frmWalletManagement : Form
    {
        public frmWalletManagement()
        {
            InitializeComponent();
            GetListWallet();
        }

        private void GetListWallet()
        {
            try
            {
                DataSet.FinanceManagement.M_WalletDataTable rs = 
                    m_WalletTableAdapter1.Wallet_GetAll(AppContext.GetInstance().UserInfo.Username);

                lvWallet.RowStyles.Clear();
                lvWallet.Controls.Clear();
                int index = 0;
                foreach(var row in rs)
                {
                    lvWallet.RowCount = lvWallet.RowCount + 1;
                    var item = new CustomListViewItem();
                    item.WalletID = row.Wallet_ID.ToString();
                    item.WalletName = row.Wallet_Content;
                    item.TotalAmount = row.Wallet_Balance;
                    item.OnItemClick += item_OnItemClick;
                    item.Dock = DockStyle.Fill;
                    lvWallet.Controls.Add(item, 0, index++);
                }  
                lvWallet.Refresh();
            }catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng liên hệ người quản trị.", ex.Message);
            }
        }

        void item_OnItemClick(object sender, EventArgs e)
        {
            CustomListViewItem item = (CustomListViewItem)sender;
            
            foreach(var c in lvWallet.Controls)
            {
                if(c.GetType().Equals(typeof(CustomListViewItem)))
                {
                    CustomListViewItem selectedItem = c as CustomListViewItem;
                    if (selectedItem.WalletID.Equals(item.WalletID))
                    {
                        selectedItem.BackColor = Color.LightBlue;
                    }
                    else
                        selectedItem.BackColor = Color.Transparent;
                }
            }
        }


        private void btnAddNewWallet_Click(object sender, EventArgs e)
        {
            frmWalletInfo dialog = new frmWalletInfo(true);
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                GetListWallet();
            }
        }


    }
}
