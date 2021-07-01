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
    public partial class Admin1 : Form
    {
        public Admin1()
        {
            InitializeComponent();
        }

        private void 学生管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin1StudentMan admin1StudentMan = new Admin1StudentMan();
            admin1StudentMan.ShowDialog();
        }

        private void 增加任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin2MissionMan admin2 = new Admin2MissionMan();
            admin2.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 查看任务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin21MissionMan admin21 = new Admin21MissionMan();
            admin21.ShowDialog();
        }

        private void 查看学生完成状况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin3complete admin3 = new Admin3complete();
            admin3.ShowDialog();
        }
    }
}
