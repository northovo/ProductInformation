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
    public partial class frmPIM : Form
    {
        #region 变量
        DataSet ds = new DataSet();
        #endregion

        #region 构造函数
        public frmPIM()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        #region 显示产品
        //窗体加载
        private void frmPIM_Load(object sender, EventArgs e)
        {
            FillProductInfo();
        }
        //选择被更改
        private void PSort_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.PSort.SelectedNode.Parent == null)//根结点(没有父结点
            {
                this.dgvProduct.DataSource = ds.Tables["Product"];
            }
            else
            {
                if (e.Node.Text == "正价产品")//当前节点
                {
                    this.Filter(true);
                }
                else
                {
                    this.Filter(false);
                }
            }
        }
        #endregion

        #region 退出
        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 增加
        //增加
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmEditProduct frm = new frmEditProduct();
            //表示新增
            frm.PID = 0;
            frm.ShowDialog();//模式窗体打开 窗体关闭后才能完成
            //重新绑定
            ds.Clear();
            this.FillProductInfo();
        }
        #endregion

        #region 修改
        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            frmEditProduct frm = new frmEditProduct();
            frm.PID = Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value);//object类 强转
            frm.ShowDialog();
            //重新绑定dgv
            ds.Clear();
            this.FillProductInfo();
        }
        #endregion

        #region 删除
        private void tsbtnDel_Click(object sender, EventArgs e)
        {
            DeleteProductByID();
        }
        #endregion

        #region 查询
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        #endregion
        #endregion

        #region 方法

        #region 填充DataGridView控件
        /// <summary>
        /// 填充DataGridView控件
        /// </summary>
        private void FillProductInfo()
        {
            ds = new DataSet();
            DBHelper dbHelper = new DBHelper();
            try
            {
                //查询
                string sql = @"select a.PID 产品编号,a.PName 产品名称,a.PSize 产品规格,a.PNum 产品数量,a.PDate 创建时间,b.SortName 类别名称,a.Price 产品价格,a.IsDiscount 是否特价,a.ReducedPrice 打折价格
                            from Product as A
                            inner join PSort as B
                            on a.SortID=b.SortID";
                //创建适配器 自动打开关闭
                SqlDataAdapter adapter = new SqlDataAdapter(sql, dbHelper.Connection);
                //数据填充到数据集里面
                adapter.Fill(ds, "Product");
                //绑定
                this.dgvProduct.DataSource = this.ds.Tables["Product"];
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 从DataSet中过滤数据
        /// <summary>
        /// 从DataSet中过滤数据
        /// </summary>
        /// <param name="isDiscount">true：特价，false:非特价</param>
        private void Filter(Boolean isDiscount)
        {
            //视图
            DataView dv = new DataView(ds.Tables["Product"]);
            if (isDiscount == true)
            {
                //过滤
                dv.RowFilter = "是否特价='false'";
            }
            else
            {
                dv.RowFilter = "是否特价='true'";
            }
            //重新绑定dgv
            this.dgvProduct.DataSource = dv;
        }
        #endregion

        #region 删除
        /// <summary>
        /// 删除
        /// </summary>
        private void DeleteProductByID()
        {
            if (this.dgvProduct.CurrentRow != null)//有当前行被选中
            {
                DialogResult dr = MessageBox.Show("确定要删除名称为" + dgvProduct.CurrentRow.Cells[1].Value + "的产品", "系统提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    DBHelper helper = new DBHelper();
                    try
                    {
                        StringBuilder sb = new StringBuilder();//实例化动态字符串
                        //sql语句
                        sb.AppendFormat("delete from Product where PID={0}", Convert.ToInt32(dgvProduct.CurrentRow.Cells[0].Value));
                        //执行工具
                        SqlCommand cmd = new SqlCommand(sb.ToString(), helper.Connection);
                        //打开数据库
                        helper.OpenConnection();
                        //执行
                        int result = cmd.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //重新绑定dgv
                            ds.Clear();
                            this.FillProductInfo();
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

            }

        }
        #endregion

        #region 查询
        /// <summary>
        /// 封装方法，用于执行查询语句，并返回DataSet对象
        /// </summary>
        /// <param name="sql">执行的查询语句</param>
        /// <param name="ps">查询语句的条件参数</param>
        /// <returns>DataSet对象</returns>
        private DataSet ExcuteDataSet(string sql, params SqlParameter[] ps)
        {
            ds = new DataSet();
            DBHelper helper = new DBHelper();

            try
            {
                //查询
                SqlCommand cmd = new SqlCommand(sql, helper.Connection);

                if (ps != null && ps.Length != 0)
                {
                    cmd.Parameters.AddRange(ps);
                }
                //创建适配器 自动打开关闭
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //数据填充到数据集里面
                adapter.Fill(ds, "Product");
            }
            catch (Exception)
            {
                MessageBox.Show("查询失败！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return ds;
        }

        private void Search()
        {
            //定义一个List容器，用户存储参数
            List<SqlParameter> list = new List<SqlParameter>();

            //1、参数化sql语句（不是固定的SQL语句，它根据用户是否输入条件来决定）
            string sql = ("select * from Product where 1=1 ");

            //2、根据用户是否输入条件来拼接SQL语句（拼接查询条件）
            string PName = txtName.Text.Trim();
            string PID = txtID.Text.Trim();
            string PSize = txtSize.Text.Trim();
            if (!string.IsNullOrEmpty(PID))
            {
                sql = sql + "and PID like @PID ";
                //创建参数对象，并设置参数值
                SqlParameter p = new SqlParameter("@PID", "%" + PID + "%");
                list.Add(p);
            }
            if (!string.IsNullOrEmpty(PSize))
            {
                sql = sql + "and PSize like @PSize ";
                SqlParameter p = new SqlParameter("@PSize", "%" + PSize + "%");
                list.Add(p);
            }
            if (!string.IsNullOrEmpty(PName))
            {
                sql = sql + "and PName like @PName ";
                SqlParameter p = new SqlParameter("@PName", "%" + PName + "%");
                list.Add(p);
            }

            //3、调用工具类，执行查询操作
            SqlParameter[] ps = list.ToArray();
            ds = ExcuteDataSet(sql, ps);
            //4、把查询结果给dgv控件
            this.dgvProduct.DataSource = this.ds.Tables["Product"];
        }
        #endregion

        #endregion

    }
}
