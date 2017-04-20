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
    public partial class CustomTitlePanel : UserControl
    {
        private CustomTitlePanelType type;

        public CustomTitlePanelType Type
        {
            get { return type; }
            set {
                type = value;
                switch (type)
                {
                    case CustomTitlePanelType.MainTitle:
                        this.tableLayoutPanel1.BackColor = Color.SteelBlue;
                        break;
                    case CustomTitlePanelType.SubTitle:
                        lblTitle.Font = new Font(lblTitle.Font.FontFamily, 10, FontStyle.Regular);
                        this.tableLayoutPanel1.BackColor = Color.LightSteelBlue;
                        break;
                    case CustomTitlePanelType.SummaryTitle:
                        lblTitle.Font = new Font(lblTitle.Font.FontFamily, 10, FontStyle.Regular);
                        this.tableLayoutPanel1.BackColor = Color.LimeGreen;
                        break;
                }
            }
        }
        private string title;

        public string Title
        {
            get { return title; }
            set { 
                title = value;
                lblTitle.Text = title;
            }
        }

        public CustomTitlePanel()
        {
            InitializeComponent(); 
        }

    }
    public enum CustomTitlePanelType
    {
        Default = 0,
        MainTitle = 1,
        SubTitle = 2,
        SummaryTitle = 3
    }
}
