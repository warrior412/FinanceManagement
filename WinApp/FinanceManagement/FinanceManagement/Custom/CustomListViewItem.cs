using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinanceManagement.Class;

namespace FinanceManagement.Custom
{
    public partial class CustomListViewItem : UserControl
    {
        public event EventHandler OnItemClick;
        public event EventHandler OnReloadListView;

        public bool OnSelected
        {
            set {
                if (value)
                    OnItemClick(this, null);
            }
        }

        private string walletID;

        public string WalletID
        {
            get { return walletID; }
            set { walletID = value; }
        }

        private string walletName;

        public string WalletName
        {
            get { return walletName; }
            set { 
                walletName = value;
                lblName.Text = walletName;
            }
        }

        private double totalAmount;

        public double TotalAmount
        {
            get { return totalAmount; }
            set {
                totalAmount = value;
                lblAmount.Text = AppContext.GetInstance().getMoneyFormatByDouble(totalAmount);
            }
        }

        private FinanceManagement.DataSet.FinanceManagement.M_WalletRow itemData;

        public FinanceManagement.DataSet.FinanceManagement.M_WalletRow ItemData
        {
            get { return itemData; }
            set { itemData = value; }
        }
        public CustomListViewItem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (OnItemClick != null)
                OnItemClick(this, e);
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {
            if (OnItemClick != null)
                OnItemClick(this, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmWalletInfo frm = new frmWalletInfo(itemData);
            if(frm.ShowDialog()==DialogResult.OK)
            {
                if (OnReloadListView != null)
                    OnReloadListView(this, e);
            }
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            frmActivityManagement frm = new frmActivityManagement(itemData);
            frm.FormClosing += delegate
            {
                if (OnReloadListView != null)
                    OnReloadListView(this, e);
            };
            frm.ShowDialog();
        }


    }
}
