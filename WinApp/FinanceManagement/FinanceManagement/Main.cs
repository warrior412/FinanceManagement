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
            frmWalletManagement frm = null;
            if (CheckShowingForm("frmWalletManagement")){
                frm = this.ActiveMdiChild as frmWalletManagement;
                frm.frmWalletManagement_Shown(sender, e);
            }
                
            else
            {
                frm = new frmWalletManagement();
                frm.MdiParent = this;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
                
        }

        private void btnItemManagement_Click(object sender, EventArgs e)
        {
            frmItemManagement frm = new frmItemManagement();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }

        private bool CheckShowingForm(string formName)
        {
            if (this.ActiveMdiChild == null)
                return false;
            if (this.ActiveMdiChild.GetType().Name.Equals(formName))
                return true;
            return false;

        }
    }
}
