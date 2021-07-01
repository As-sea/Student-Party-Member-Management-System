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
    public partial class User2CheckMission : Form
    {
        public User2CheckMission()
        {
            InitializeComponent();
            Table();
        }

        public void Table()
        {
            dataGridView1.Rows.Clear();

            //打开数据库，读取结果
            DaoClass dao = new DaoClass();
            string sql = "select * from t_studycontent";

            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());
            }

            dc.Close();
            dao.DaoClose();
        }

        public void TableID()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            DaoClass dao = new DaoClass();
            string sql = $"select * from  t_studycontent where id='{txtId.Text}'";
            IDataReader dc = dao.read(sql);

            //对dc进行操作
            while (dc.Read())
            {
                //将数据添加到表格中，一行一行填
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString(), dc[2].ToString());

            }
            dc.Close();
            dao.DaoClose();

        }

        private void btnSearchId_Click(object sender, EventArgs e)
        {
            TableID();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labText.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {          
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            User22Comptele user = new User22Comptele(id);
            user.ShowDialog();
        }
    }
}
