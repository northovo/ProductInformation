using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;//包含操作数据库的一些类
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//导入命名空间

namespace ProductInformation
{
    public partial class frmLogin : Form
    {
        User user = new User();
        #region 构造函数
        public frmLogin()
        {
            InitializeComponent();
        }
        #endregion
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }


        #region 事件
        //登录事件
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (Login())
                {
                    frmPIMain fpim = new frmPIMain();
                    fpim.user = user;//登录信息以对象形式保存，窗体间进行传值
                    fpim.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("登录失败");
                }
            }

        }
        //取消事件
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 方法

        #region 非空验证
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            if (txtName.Text.Trim() == "" || txtPwd.Text.Trim() == "")
            {
                MessageBox.Show("请输入用户名和密码");
                return false;
            }
            return true;
        }
        #endregion

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns>true:登录成功 false:登录失败</returns>
        public bool Login()
        {
            bool flag = false;
            string name = txtName.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            DBHelper dbHelper = new DBHelper();
            try
            {
                //1、SQL语句
                string sql = string.Format("select * from [User] where UserName='{0}' and Password='{1}'", name, pwd);
                //2、command工具
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //3、打开连接
                dbHelper.OpenConnection();
                //4、执行 
                SqlDataReader reader = cmd.ExecuteReader();
                //5、判断
                if (reader.Read())//能读 有值
                {
                    user.UserID = Convert.ToInt32(reader[0]);
                    user.UserName = reader[1].ToString();
                    user.Password = reader[2].ToString();
                    flag = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("发生异常：" + ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
            return flag;
        }
        #endregion

        #endregion

        
    }
}
