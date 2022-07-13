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
    public partial class frmPSort : Form
    {
        #region 变量
        DataSet ds = new DataSet();
        #endregion

        #region 构造函数
        public frmPSort()
        {
            InitializeComponent();
        }
        #endregion

        #region 事件
        //加载事件
        private void frmPSort_Load(object sender, EventArgs e)
        {
            GetDB();
        }
        //退出
        private void tsbtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //删除
        private void tsbtnDel_Click(object sender, EventArgs e)
        {
            DBHelper helper = new DBHelper();
            try
            {
                if (this.dgvSort.SelectedRows.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendFormat("确定要删除类别为{0}的数据吗？", this.dgvSort.SelectedCells[1].Value);
                    DialogResult dr = MessageBox.Show(sb.ToString(), "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == System.Windows.Forms.DialogResult.Yes)
                    {
                        sb = new StringBuilder();
                        sb.AppendFormat("delete from Product where SortID={0} ", Convert.ToInt32(dgvSort.SelectedCells[0].Value));
                        sb.AppendFormat("delete from PSort where SortID={0}", Convert.ToInt32(dgvSort.SelectedCells[0].Value));
                        SqlCommand cmd = new SqlCommand(sb.ToString(), helper.Connection);
                        helper.OpenConnection();
                        int result = cmd.ExecuteNonQuery();
                        if (result == 1)
                        {
                            MessageBox.Show("删除成功！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //重新绑定
                            //dgvSort.DataSource = null;
                            ds.Clear();
                            GetDB();
                        }
                    }
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
        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            frmEditSort frm = new frmEditSort();
            frm.ShowDialog();
            ds.Clear();
            GetDB();
        }
        private void tsbtnUpdate_Click(object sender, EventArgs e)
        {
            frmEditSort frm = new frmEditSort();
            frm.sortID = Convert.ToInt32(this.dgvSort.SelectedCells[0].Value);
            frm.ShowDialog();
            ds.Clear();
            GetDB();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 得到全部类别
        /// </summary>
        private void GetDB()
        {
            DBHelper helper = new DBHelper();
            try
            {
                string sql = "select SortID as 编号,SortName as 类别名称 from PSort order by SortID";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, helper.Connection);
                adapter.Fill(ds, "PSort");
                this.dgvSort.DataSource = ds.Tables["PSort"];
            }
            catch (Exception)
            {
                MessageBox.Show("数据库操作错误！", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        #endregion

        
    }
}
