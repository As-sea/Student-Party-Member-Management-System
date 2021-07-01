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
    public partial class Admin2MissionMan : Form
    {
        public Admin2MissionMan()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //加一个健壮分析，每个空都不许为空
            if (txtid.Text != "" && txtitle.Text != "" && textContent.Text != "")
            {
                DaoClass dao = new DaoClass();
                string sql = $"insert into t_studycontent values('{txtid.Text}','{txtitle.Text}',getdate(),'{textContent.Text}')";
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtid.Text = "";
            txtitle.Text = "";
            textContent.Text = "";
        }
    }
}
