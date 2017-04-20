using FinanceManagement.Class;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Trim().Length > 0
                && txtPass.Text.Trim().Length > 0)
            {
                string user = txtUser.Text.Trim();
                string pass = txtPass.Text.Trim();

                DataSet.FinanceManagement.M_UserDataTable rs = m_UserTableAdapter1.User_GetInfo(user, pass);
                if (rs.Count > 0)
                {
                    UserInfo info = new UserInfo();
                    info.Username = rs[0].UserName;
                    info.Password = rs[0].Password;
                    info.Fullname = rs[0].FullName;
                    info.Role = rs[0].Role;

                    AppContext.GetInstance().UserInfo = info;

                    Main frm = new Main();
                    frm.FormClosing += frm_FormClosing;
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng !");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập thông tin đăng nhập !");
        }

        void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.txtUser.Text = "";
            this.txtPass.Text = "";
            this.Show();
        }


        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
