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
            lvWallet.RowStyles.Clear();
            for (int i = 0; i <10; i++)
            {
                lvWallet.RowCount = lvWallet.RowCount + 1;
                var item = new CustomListViewItem();
                item.WalletID = i.ToString();
                item.OnItemClick += item_OnItemClick;
                item.Dock = DockStyle.Fill;
                lvWallet.Controls.Add(item, 0, i);
            }
            lvWallet.Refresh();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var s = this.Size;
        }

        private void btnAddNewWallet_Click(object sender, EventArgs e)
        {

        }


    }
}
