using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProductInformation
{
    public class DBHelper//数据库打开及关闭
    {
        //新建一个字符串
        private string connString = @"server=localhost;database=ProductInformation;uid=sa;pwd=123";
        private SqlConnection connection;
        /// <summary>
        /// 连接对象
        /// </summary>
        public SqlConnection Connection//封装字段
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connString);
                }
                return connection;
            }
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
            else if (Connection.State == ConnectionState.Broken)//损坏
            {
                Connection.Close();
                Connection.Open();
            }
        }
        /// <summary>
        /// 关闭数据库
        /// </summary>
        public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
