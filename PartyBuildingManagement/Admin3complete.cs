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
    public partial class Admin3complete : Form
    {
        public Admin3complete()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            check();
        }
        public void check()
        {
            dataGridView1.Rows.Clear();
            string sid = textBox1.Text;
            string sql = $"select id , name from t_user , t_iscomplet where sid='{sid}'and t_iscomplet.uid=t_user.id";
            DaoClass dao = new DaoClass();

            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString());
            }

            string sql2 = $"select count(*) from t_iscomplet where sid='{sid}'";
            IDataReader dc1 = dao.read(sql2);
            while (dc1.Read())
            {
                label3.Text = dc1[0].ToString() + "人";
                //MessageBox.Show($"{dc1[0].ToString()}");
            }
            dc.Close();
            dao.DaoClose();
        }
    }
}
