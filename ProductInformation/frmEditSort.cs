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
    public partial class frmEditSort : Form
    {
        #region 变量
        public int sortID = 0;
        #endregion

        #region 构造函数
        public frmEditSort()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckItem())
            {
                if (this.sortID == 0)//新增
                {
                    InsertDB();
                }
                else//更新
                {
                    UpdateDB();
                }
            }
        }
        //修改
        private void frmEditSort_Load(object sender, EventArgs e)
        {
            if (this.sortID != 0)//修改
            {
                GetSortInfo();
                btnSave.Text = "修改(&U)";
            }

        }
        #endregion

        #region 方法
        #region 非空验证
        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns></returns>
        private bool CheckItem()
        {
            bool checkValue = true;
            if (this.txtSort.Text.Trim().Length == 0)
            {
                MessageBox.Show("名称不能为空", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkValue = false;
                this.txtSort.Text = "";
            }
            return checkValue;
        }
        #endregion

        #region 检查类别名称是否已经存在
        /// <summary>
        /// 检查类别名称是否已经存在
        /// </summary>
        /// <returns></returns>
        private bool CheckSortNameExit()
        {
            bool exit = false;
            DBHelper helper = new DBHelper();
            try
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("select * from PSort where SortName={0}", txtSort.Text.Trim());
                SqlCommand cmd = new SqlCommand(sb.ToString(), helper.Connection);
                helper.OpenConnection();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    exit = true;
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                helper.CloseConnection();
            }
            return exit;
        }
        #endregion

        #region 新增
        /// <summary>
        /// 新增
        /// </summary>
        /// <returns></returns>
        private void InsertDB()
        {
            DBHelper helper = new DBHelper();
            try
            {
                StringBuilder sb = new StringBuilder();
                //SQL语句
                sb.AppendLine("insert into PSort(SortName)");
                sb.AppendFormat("values('{0}')", txtSort.Text.Trim());
                //执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), helper.Connection);
                //打开连接
                helper.OpenConnection();
                //执行
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("新增成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                helper.CloseConnection();
            }
        }
        #endregion

        #region 从数据库通过id查找类别
        /// <summary>
        /// 从数据库通过id查找类别
        /// </summary>
        private void GetSortInfo()
        {
            DBHelper helper = new DBHelper();
            try
            {
                //SQL语句
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("select SortName");
                sb.AppendLine("from PSort");
                sb.AppendFormat("where SortID={0}", sortID);
                helper.OpenConnection();
                //工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), helper.Connection);
                //打开数据库连接
                helper.OpenConnection();
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtSort.Text = reader["SortName"].ToString();
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                helper.CloseConnection();
            }
        }
        #endregion

        #region 修改
        private void UpdateDB()
        {
            DBHelper helper = new DBHelper();
            try
            {
                //sql语句
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("update PSort");
                sb.AppendFormat("set SortName='{0}'", txtSort.Text.Trim());
                sb.AppendFormat("where SortID={0}", sortID);
                //执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), helper.Connection);
                //打开连接
                helper.OpenConnection();
                //执行
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("修改成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                helper.CloseConnection();
            }
        }

        #endregion

        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
