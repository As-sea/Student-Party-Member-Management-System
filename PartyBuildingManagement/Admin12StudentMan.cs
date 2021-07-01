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
    public partial class Admin12StudentMan : Form
    {
        public Admin12StudentMan()
        {
           
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtname.Text = "";
            txtlevel.Text = "";
           // txtpwd.Text = "123456";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //加一个健壮分析，每个空都不许为空
            if (txtid.Text != "" && txtname.Text != "" && txtlevel.Text != "")//&& txtpwd.Text != ""
            {
                DaoClass dao = new DaoClass();
                string sql = $"insert into t_user values('{txtid.Text}','{txtname.Text}','','','123456','','{txtlevel.Text}',0)";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("添加成功");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
