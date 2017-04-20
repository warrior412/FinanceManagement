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
        public CustomListViewItem()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (OnItemClick != null)
                OnItemClick(this, e);
        }


    }
}
