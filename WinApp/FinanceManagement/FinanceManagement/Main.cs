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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnWalletManagement_Click(object sender, EventArgs e)
        {
            frmWalletManagement frm = new frmWalletManagement();
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
