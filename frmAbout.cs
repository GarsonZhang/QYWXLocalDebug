/*************************************************************************
    ========================微信企业号开发本地调试========================
    作者：GarsonZhang
    QQ：382237285
    感谢你使用本程序，将开源进行到底
    如果你有新需求，请联系我，增加对你的支持
 ************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QYWXLocalDebug
{
    public partial class frmAbout : Form
    {
        public static void ShowForm()
        {
            frmAbout frm = new frmAbout();
            frm.ShowInTaskbar = false;
            frm.ShowIcon = false;
            frm.StartPosition = FormStartPosition.CenterParent;
        }
        private frmAbout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
