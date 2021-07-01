using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyBuildingManagement
{
    public partial class Admin1StudentMan : Form
    {
        public Admin1StudentMan()
        {
            InitializeComponent();
            Table();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labText.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+ dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//获取选中人员
        }


        //从数据库中读取数据显示在表格中
        public void Table()
        {
            //清空表格旧数据
            dataGridView1.Rows.Clear();

            //打开数据库，读取结果
            DaoClass dao = new DaoClass();
            string sql = "select * from t_user";

            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[3].ToString(), dc[2].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());
            }

            dc.Close();
            dao.DaoClose();
        }


        //根据id显示数据
        public void TableID()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            DaoClass dao = new DaoClass();
            string sql = $"select * from t_user where id='{txtId.Text}'";
            IDataReader dc = dao.read(sql);

            //对dc进行操作
            while (dc.Read())
            {
                //将数据添加到表格中，一行一行填
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[3].ToString(), dc[2].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());

            }
            dc.Close();
            dao.DaoClose();

        }





        //根据书名显示数据 模糊查询
        public void TableName()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            DaoClass dao = new DaoClass();
            string sql = $"select * from t_user where name like '%{txtName.Text}%'";
            IDataReader dc = dao.read(sql);

            //对dc进行操作
            while (dc.Read())
            {
                //将数据添加到表格中，一行一行填
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[3].ToString(), dc[2].ToString(), dc[5].ToString(), dc[6].ToString(), dc[7].ToString());

            }
            dc.Close();
            dao.DaoClose();

        }



        private void btnRelease_Click(object sender, EventArgs e)
        {
            Table();//刷新数据
            txtId.Text = "";
            txtName.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Admin12StudentMan admin12 = new Admin12StudentMan();
            admin12.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                //因为不能是点按钮才触发，所以放在上面
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//获取党员交编号
                labText.Text = id + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = $"delete from t_user where id='{id}'";
                    DaoClass dao = new DaoClass();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败" + sql);
                    }
                    dao.DaoClose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的数据", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string level = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string score = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                Admin13StudentMan a = new Admin13StudentMan(id,name,level,score);
                a.ShowDialog();

                Table();
            }
            catch
            {
                 MessageBox.Show("ERROR");
            }
         
        }



        private void btnSearchName_Click(object sender, EventArgs e)
        {
            TableName();
        }

        private void btnSearchNum_Click_1(object sender, EventArgs e)
        {  
            TableID();
        }
    }
}
