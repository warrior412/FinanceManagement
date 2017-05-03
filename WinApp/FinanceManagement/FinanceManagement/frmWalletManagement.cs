using FinanceManagement.Class;
using FinanceManagement.Custom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceManagement
{
    public partial class frmWalletManagement : Form
    {
        private const int GET_WALLETS = 100;
        private const int GET_ACTIVITY = 101;
        private const int MaxThreads = 20;
        private BackgroundWorker worker = null;

        CustomListViewItem selectedWallet = null;

        CustomProgressBar dialog = null;
        public frmWalletManagement()
        {
            InitializeComponent();

            
        }
        private void frmWalletManagement_Shown(object sender, EventArgs e)
        {
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);


            dialog = new CustomProgressBar();
            dialog.Shown += delegate
            {
                worker.RunWorkerAsync(GET_WALLETS);
            };
            dialog.Show();
        }



        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dialog.Close();
            dialog.Dispose();
            this.ResumeLayout();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            this.SuspendLayout();
            if(int.Parse(e.Argument.ToString())== GET_ACTIVITY)
            {
                GetActivityData(int.Parse(selectedWallet.WalletID));
            }
            if(int.Parse(e.Argument.ToString())== GET_WALLETS)
            {
                GetListWallet();
            }
        }

        private void GetActivityData(int WalletID)
        {
            BeginInvoke((MethodInvoker)delegate
                {
                    vActivityBindingSource.DataSource = v_ActivityTableAdapter1.v_Activity_GetAllDeposit(WalletID);
                    vActivityBindingSource1.DataSource = v_ActivityTableAdapter1.v_Activity_GetAllWithDraw(WalletID);
                    vActivityBindingSource2.DataSource = v_ActivityTableAdapter1.v_Activity_GetAllTransfer(WalletID);

                    dgvDeposit.DataSource = vActivityBindingSource;
                    dgvWithDraw.DataSource = vActivityBindingSource1;
                    dgvTransfer.DataSource = vActivityBindingSource2;
                });
            
                    
        }

        private void GetListWallet()
        {
            try
            {
                DataSet.FinanceManagement.M_WalletDataTable rs = 
                    m_WalletTableAdapter1.Wallet_GetAll(AppContext.GetInstance().UserInfo.Username);
                Thread.Sleep(2000);
                BeginInvoke((MethodInvoker)delegate
                {
                    lvWallet.RowCount = 1;
                    lvWallet.Controls.Clear();
                    lvWallet.RowStyles.Clear();
                    lvWallet.SuspendLayout();

                    
                    int index = 0;
                    foreach (var row in rs)
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
                    lvWallet.ResumeLayout();
                });

                


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
            worker.RunWorkerAsync(GET_WALLETS);
            dialog = new CustomProgressBar();
            dialog.Show();
        }

        void item_OnItemClick(object sender, EventArgs e)
        {
            selectedWallet = (CustomListViewItem)sender;
            
            foreach(var c in lvWallet.Controls)
            {
                if(c.GetType().Equals(typeof(CustomListViewItem)))
                {
                    CustomListViewItem selectedItem = c as CustomListViewItem;
                    if (selectedItem.WalletID.Equals(selectedWallet.WalletID))
                    {
                        selectedItem.BackColor = Color.LightBlue;
                    }
                    else
                        selectedItem.BackColor = Color.Transparent;
                }
            }
            dialog = new CustomProgressBar();
            dialog.Shown += delegate
            {
                worker.RunWorkerAsync(GET_ACTIVITY);
            };
            dialog.Show();
        }


        private void btnAddNewWallet_Click(object sender, EventArgs e)
        {
            frmWalletInfo frm = new frmWalletInfo(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                dialog = new CustomProgressBar();
                dialog.Shown += delegate
                {
                    worker.RunWorkerAsync(GET_WALLETS);
                };
                dialog.Show();
            }
        }

        

        


    }
}
