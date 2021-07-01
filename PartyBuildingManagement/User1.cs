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
    public partial class User1 : Form
    {
        public User1()
        {
            InitializeComponent();
            labName.Text = DataClass.UNAME + ",欢迎使用党员管理系统！";
            showScore();
        }

        public void showScore()
        {
            
            DaoClass dao = new DaoClass();
            string sql = $"select studysocer from t_user where id='{DataClass.UID}'";
            IDataReader dc = dao.read(sql);

            if (dc.Read())
            {
                labscore.Text = dc[0].ToString();
            }
            dao.DaoClose();
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User1UpdateMessage user1 = new User1UpdateMessage();
            user1.ShowDialog();
        }

        private void 刷新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labName.Text = DataClass.UNAME+ ",欢迎使用党员管理系统！";
            showScore();
        }

        private void 更改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User12UpdatePs user12 = new User12UpdatePs();
            user12.ShowDialog();
        }

        private void 查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User2CheckMission user2 = new User2CheckMission();
            user2.ShowDialog();
        }

        private void 积分排名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User2check user2 = new User2check();
            user2.ShowDialog();
        }
    }
}
