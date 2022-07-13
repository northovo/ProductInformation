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
    public partial class frmEditProduct : Form
    {
        #region 变量
        public int PID = 0;
        //定义数据源
        DataSet ds = new DataSet();
        #endregion

        #region 构造函数
        public frmEditProduct()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        //加载事件
        private void frmEditProduct_Load(object sender, EventArgs e)
        {
            if (PID == 0)//添加
            {
                this.GetProductSort();
            }
            else//修改
            {
                this.GetProduct();
                this.btnSave.Text = "修改";
            }
        }
        //保存
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (PID == 0)//新增
                {
                    InsertProduct();
                }
                else//修改
                {
                    UpdateProduct();
                }
            }
        }
        //选择被更改
        private void chkIsPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsPrice.Checked)
            {
                this.numReducedPrice.Enabled = true;
            }
            else
            {
                this.numReducedPrice.Enabled = false;
                this.numReducedPrice.Value = this.numPrice.Value;
            }
        }
        #endregion

        #region 方法
        #region 从数据库得到商品类别
        /// <summary>
        /// 从数据库得到商品类别
        /// </summary>
        private void GetProductSort()
        {
            DBHelper helper = new DBHelper();
            try
            {
                string sql = "select * from PSort order by SortID";
                //适配器 不需要打开关闭数据库 自动的
                SqlDataAdapter adapter = new SqlDataAdapter(sql, helper.Connection);
                adapter.Fill(ds, "PSort");
                //绑定数据
                this.cboSort.DataSource = ds.Tables["PSort"];
                this.cboSort.ValueMember = "SortID";//隐藏
                this.cboSort.DisplayMember = "SortName";//显示
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        #endregion

        #region 检查窗体输入
        /// <summary>
        /// 检查窗体输入
        /// </summary>
        /// <returns></returns>
        private bool CheckInput()
        {
            bool ok = true;
            if (txtName.Text.Trim().Length == 0)
            {
                MessageBox.Show("名称不能为空!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ok = false;
            }
            return ok;
        }
        #endregion

        #region 新增
        private void InsertProduct()
        {
            DBHelper db = new DBHelper();
            try
            {
                string sql = string.Format("insert into Product(PName,SortID,Price,IsDiscount,ReducedPrice,PSize,PNum) values('{0}',{1},{2},{3},{4},'{5}',{6})",
                             txtName.Text.Trim(), Convert.ToInt32(cboSort.SelectedValue), this.numPrice.Value,
                             this.chkIsPrice.Checked ? 1 : 0, numReducedPrice.Value,txtSize.Text.Trim(), Convert.ToInt32(txtNum.Text.Trim()));
                //执行工具
                SqlCommand cmd = new SqlCommand(sql, db.Connection);
                //打开数据库连接
                db.OpenConnection();
                //执行
                int result = cmd.ExecuteNonQuery();//返回受影响的行数
                if (result == 1)
                {
                    MessageBox.Show("添加成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region 获取商品信息
        /// <summary>
        /// 获取商品信息
        /// </summary>
        private void GetProduct()
        {
            //获取类别值
            GetProductSort();
            DBHelper helper = new DBHelper();
            try
            {
                //sql语句
                string sql = string.Format("select * from Product where PID={0}", PID);
                //执行工具
                SqlCommand cmd = new SqlCommand(sql, helper.Connection);
                //打开连接
                helper.OpenConnection();
                //执行
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //给相应控件赋值
                    this.txtName.Text = reader["PName"].ToString();
                    this.cboSort.SelectedValue = reader["SortID"].ToString();
                    this.numPrice.Value = Convert.ToDecimal(reader["Price"]);
                    this.chkIsPrice.Checked = Convert.ToBoolean(reader["isDiscount"]);
                    this.numReducedPrice.Value = Convert.ToDecimal(reader["ReducedPrice"]);
                    this.txtSize.Text = reader["PSize"].ToString();
                    this.txtNum.Text = reader["PNum"].ToString();
                }
                reader.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 更新产品
        /// <summary>
        /// 更新产品
        /// </summary>
        private void UpdateProduct()
        {
            DBHelper helper = new DBHelper();
            try
            {
                //string sql = string.Format(@"update Product
                //                            set Product.PName='{0}',Product.SortID={1},Product.Price={2},
                //                            Product.IsDiscount={3},Product.ReducedPrice={4}
                //                            where Product.PID={5}");
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("update Product");
                sb.AppendFormat("set Product.PName='{0}',Product.SortID={1},Product.Price={2},Product.IsDiscount ={3},Product.ReducedPrice ={4} where Product.PID ={5}", txtName.Text.Trim(), Convert.ToInt32(cboSort.SelectedValue), this.numPrice.Value,
                             this.chkIsPrice.Checked ? 1 : 0, numReducedPrice.Value,PID);
                //执行工具
                SqlCommand cmd = new SqlCommand(sb.ToString(), helper.Connection);
                //打开数据库连接
                helper.OpenConnection();
                //执行
                int result = cmd.ExecuteNonQuery();
                //判断
                if (result == 1)
                {
                    MessageBox.Show("修改成功", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
