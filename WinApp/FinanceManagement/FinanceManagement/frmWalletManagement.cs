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
            for (int i = 0; i < 5; i++)
            {
                lvWallet.RowCount = lvWallet.RowCount + 1;
                var item = new CustomListViewItem();
                item.OnItemClick += item_OnItemClick;
                item.Dock = DockStyle.Fill;
                lvWallet.Controls.Add(item, 0, i);
            }
            lvWallet.Refresh();
        }

        void item_OnItemClick(object sender, EventArgs e)
        {
            CustomListViewItem item = (CustomListViewItem)sender;
            item.BackColor = Color.AliceBlue;
        }

    }
}
