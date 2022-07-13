using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInformation
{
    public partial class frmChangePwd : Form
    {
        #region 变量
        public User user;

        #endregion

        #region 构造函数
        public frmChangePwd()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //返回
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //修改密码
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                int result = UpdatePwd();
                if (result > 0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }
        #endregion

        #region 方法

        #region 验证
        /// <summary>
        /// 验证
        /// </summary>
        /// <returns></returns>
        public bool CheckInput()
        {
            if (txtPwd1.Text.Trim() == "")
            {
                MessageBox.Show("请输入原密码！");
                return false;
            }
            if (txtPwd1.Text.Trim() != user.Password)
            {
                MessageBox.Show("原密码输入错误!");
                return false;
            }
            if (txtPwd2.Text.Trim() == "")
            {
                MessageBox.Show("请输入新密码!");
                return false;
            }
            if (txtPwd3.Text.Trim() == "")
            {
                MessageBox.Show("请再次输入新密码!");
                return false;
            }
            if (txtPwd2.Text.Trim() != txtPwd3.Text.Trim())
            {
                MessageBox.Show("两次密码输入不一致!");
                return false;
            }
            return true;
        }
        #endregion

        #region 更新密码
        /// <summary>
        /// 更新密码
        /// </summary>
        /// <returns>返回如果大于0表示成功，否则失败</returns>
        private int UpdatePwd()
        {
            int result = 0;
            DBHelper dbHelper = new DBHelper();
            //sql语句
            string sql = string.Format(@"update [User] set Password='{0}' where UserID='{1}'", txtPwd3.Text.Trim(), user.UserID);
            try
            {
                //创建cmd
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                //打开连接
                dbHelper.OpenConnection();
                //执行
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
            return result;
        }
        #endregion

        private void txtPwd1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
