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
    public partial class User12UpdatePs : Form
    {
        public User12UpdatePs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                DaoClass dao = new DaoClass();
                string sql = $"update t_user set pwd='{textBox1.Text}' where id='{DataClass.UID}'";
                if (dao.Execute(sql) > 0)
                {
                    MessageBox.Show("Update Succeed");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("两次输入不一致！");
            }
        }
    }
}
