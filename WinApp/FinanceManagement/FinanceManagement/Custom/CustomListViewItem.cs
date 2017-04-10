using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagement.Custom
{
    public partial class CustomListViewItem : UserControl
    {
        public event EventHandler OnItemClick;
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
