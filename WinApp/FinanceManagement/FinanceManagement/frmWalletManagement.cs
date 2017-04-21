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
        private BackgroundWorker worker = null;
        public frmWalletManagement()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
            GetListWallet();
            //GetActivityData();
        }

        private void GetActivityData(int WalletID)
        {
            vActivityBindingSource.DataSource = v_ActivityTableAdapter1.v_Activity_GetAllDeposit(WalletID);
            vActivityBindingSource1.DataSource = v_ActivityTableAdapter1.v_Activity_GetAllWithDraw(WalletID);
            vActivityBindingSource2.DataSource = v_ActivityTableAdapter1.v_Activity_GetAllTransfer(WalletID);

            dgvDeposit.DataSource = vActivityBindingSource;
            dgvWithDraw.DataSource = vActivityBindingSource1;
            dgvTransfer.DataSource = vActivityBindingSource2;
        }

        private void GetListWallet()
        {
            try
            {
                DataSet.FinanceManagement.M_WalletDataTable rs = 
                    m_WalletTableAdapter1.Wallet_GetAll(AppContext.GetInstance().UserInfo.Username);

                lvWallet.RowCount = 1;
                lvWallet.Controls.Clear();
                lvWallet.RowStyles.Clear();

                int index = 0;
                foreach(var row in rs)
                {
                    lvWallet.RowCount = lvWallet.RowCount + 1;
                    var item = new CustomListViewItem();
                    item.WalletID = row.Wallet_ID.ToString();
                    item.WalletName = row.Wallet_Content;
                    item.TotalAmount = row.Wallet_Balance;

                    item.OnItemClick += item_OnItemClick;
                    item.OnReloadListView += item_OnReloadListView;

                    item.Dock = DockStyle.Fill;
                    item.ItemData = row;
                    lvWallet.Controls.Add(item, 0, index++);
                }  
                lvWallet.Refresh();


            }catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng liên hệ người quản trị.", ex.Message);
            }
        }


        private void SetSummaryBox()
        {
            lblSummary_FullName.Text = AppContext.GetInstance().UserInfo.Fullname;
        }



        void item_OnReloadListView(object sender, EventArgs e)
        {
            GetListWallet();
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

            GetActivityData(int.Parse(item.WalletID));
        }


        private void btnAddNewWallet_Click(object sender, EventArgs e)
        {
            frmWalletInfo dialog = new frmWalletInfo(null);
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                GetListWallet();
            }
        }


    }
}
