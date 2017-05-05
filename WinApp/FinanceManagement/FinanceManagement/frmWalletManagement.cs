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
        private const int DELETE_ACTIVITY = 102;
        private const int MaxThreads = 20;
        private int countThread = 0;

        CustomListViewItem selectedWallet = null;
        FinanceManagement.DataSet.FinanceManagement.v_ActivityRow currentActivityRow = null;

        CustomProgressBar dialog = new CustomProgressBar();
        public frmWalletManagement()
        {
            InitializeComponent();
        }
        public void frmWalletManagement_Shown(object sender, EventArgs e)
        {
            createBackGroundWorkerInstance(GET_WALLETS);
        }
        private void createBackGroundWorkerInstance(int tag)
        {
            countThread++;
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            //dialog.Shown += delegate
            //{
               
            //};
            worker.RunWorkerAsync(tag);
            dialog.Show();
        }


        #region BackgroundWorker Delegate
        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            countThread--;
            dialog.Hide();
            this.ResumeLayout();

            if(e.Result!=null&& int.Parse(e.Result.ToString()) == DELETE_ACTIVITY)
            {
                createBackGroundWorkerInstance(GET_ACTIVITY);
                createBackGroundWorkerInstance(GET_WALLETS);
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = e.Argument;
            this.SuspendLayout();
            if (int.Parse(e.Argument.ToString()) == GET_ACTIVITY)
            {
                GetActivityData(int.Parse(selectedWallet.WalletID));
            }
            if (int.Parse(e.Argument.ToString()) == GET_WALLETS)
            {
                GetListWallet();
            }
            if (int.Parse(e.Argument.ToString()) == DELETE_ACTIVITY)
            {
                DeleteActivity(currentActivityRow.Create_Date);
            }
        } 
        #endregion

        

        void vActivityBindingSource1_CurrentItemChanged(object sender, EventArgs e)
        {
            if (vActivityBindingSource1.Current == null)
                return;
            currentActivityRow = ((DataRowView)vActivityBindingSource1.Current).Row
                as FinanceManagement.DataSet.FinanceManagement.v_ActivityRow;
        }


        #region Data Manipulation
        private void GetActivityData(int WalletID)
        {
            Thread.Sleep(100);
            BeginInvoke((MethodInvoker)delegate
            {
                vActivityBindingSource.DataSource = v_ActivityTableAdapter1.v_Activity_GetAllDeposit(WalletID);
                vActivityBindingSource1.DataSource = v_ActivityTableAdapter1.v_Activity_GetAllWithDraw(WalletID);
                vActivityBindingSource2.DataSource = v_ActivityTableAdapter1.v_Activity_GetAllTransfer(WalletID);

                vActivityBindingSource1.CurrentItemChanged += vActivityBindingSource1_CurrentItemChanged;

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
                Thread.Sleep(100);
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




            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra! Vui lòng liên hệ người quản trị.", ex.Message);
            }
        }

        private void DeleteActivity(DateTime createdate)
        {
            Thread.Sleep(100);
            t_ActivityTableAdapter1.Activity_DeleteActivity(createdate);

        } 
        #endregion


        private void SetSummaryBox()
        {
            lblSummary_FullName.Text = AppContext.GetInstance().UserInfo.Fullname;
        }



        void item_OnReloadListView(object sender, EventArgs e)
        {
            createBackGroundWorkerInstance(GET_ACTIVITY);
            createBackGroundWorkerInstance(GET_WALLETS);
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
            createBackGroundWorkerInstance(GET_ACTIVITY);
        }


        private void btnAddNewWallet_Click(object sender, EventArgs e)
        {
            frmWalletInfo frm = new frmWalletInfo(null);
            if (frm.ShowDialog() == DialogResult.OK)
            {
                createBackGroundWorkerInstance(GET_WALLETS);
            }
        }

        private void dgvWithDraw_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && dgvWithDraw.Rows.Count>0)
            {
                ContextMenu m = new ContextMenu();
                int currentMouseOverRow = dgvWithDraw.HitTest(e.X, e.Y).RowIndex;

                dgvWithDraw.CurrentCell = dgvWithDraw.Rows[currentMouseOverRow].Cells[0];
                dgvWithDraw.Rows[currentMouseOverRow].Selected = true;
                dgvWithDraw.Focus();

                m.MenuItems.Add(new MenuItem("Xóa dữ liệu", (o, ev) =>
                {
                    if(MessageBox.Show("Bạn muốn xóa dòng dữ liệu này ?","Xác nhận",MessageBoxButtons.OKCancel)==DialogResult.OK)
                    {
                        createBackGroundWorkerInstance(DELETE_ACTIVITY);
                    }
                    
                }));
                m.MenuItems.Add(new MenuItem("Đóng"));




                m.Show(dgvWithDraw, new Point(e.X, e.Y));

            }
        }

        private void dgvTransfer_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dgvDeposit_MouseClick(object sender, MouseEventArgs e)
        {

        }

        

        


    }
}
