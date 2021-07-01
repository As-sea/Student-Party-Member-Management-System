using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyBuildingManagement
{
    class DaoClass
    {
        SqlConnection sc;
        public SqlConnection connect()  //数据库连接：登陆服务器名称，数据库名称，参数
        {
            string str = "Data Source=DESKTOP-61PJF22;Initial Catalog=PartyDB;Integrated Security=True";
            sc = new SqlConnection(str);//创建数据库连接对象 
            sc.Open();//打开数据库
            return sc;//返回数据库连接对象
        }

        public SqlCommand command(string sql)//封装数据库的操作
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)//更新操作
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql)//读取操作
        {
            return command(sql).ExecuteReader();
        }

        public void DaoClose()//关闭数据库
        {
            sc.Close();
        }
    }
}
