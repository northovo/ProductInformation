using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInformation
{
    public partial class frmPIMain : Form
    {
        #region 变量
        public User user;
        #endregion

        #region 构造函数
        public frmPIMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region 事件
        //退出事件
        private void tsmiCancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确定要退出吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                Application.Exit();
            }
        }

        //关于
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.ShowDialog();//以模式窗体显示，一直获取焦点，如果不关闭，其他窗体无法获取焦点
        }

        

        //修改密码
        private void tsmiModifyPassword_Click(object sender, EventArgs e)
        {
            //实例化窗体
            frmChangePwd fcp = new frmChangePwd();
            fcp.user = this.user;
            fcp.Show();
        }
        //单击产品管理
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmPIM fpim = new frmPIM();
            fpim.ShowDialog();
        }
        //单击产品类别
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmPSort fpim = new frmPSort();
            fpim.ShowDialog();
        }

        #endregion


    }
}
