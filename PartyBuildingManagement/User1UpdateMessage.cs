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
    public partial class User1UpdateMessage : Form
    {
        public User1UpdateMessage()
        {
            InitializeComponent();
            showMessage();
        }
        public void showMessage()
        {
            DaoClass dao =new  DaoClass();
            string sql = $"select * from t_user where id='{DataClass.UID}'";

            IDataReader dc = dao.read(sql);
             if (dc.Read())
            {
                labid.Text = dc[0].ToString();
                labname.Text= dc[1].ToString();
                labgender.Text= dc[2].ToString();
                labno.Text = dc[3].ToString();
                labage.Text = dc[5].ToString();
                lablevel.Text = dc[6].ToString();
                labscore.Text = dc[7].ToString();
            }

        }
        private void User1UpdateMessage_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //加一个健壮分析，每个空都不许为空
            if (txtname.Text != "" && txtgender.Text != "" && txtsno.Text != ""&& txtage.Text != "")
            {
                DaoClass dao = new DaoClass();
                string sql = $"update t_user set name='{txtname.Text}',gender='{txtgender.Text}',sno='{txtsno.Text}',age='{txtage.Text}'where id='{DataClass.UID}'";
                if (dao.Execute(sql) > 0)
                {
                    DataClass.UNAME = txtname.Text;
                    MessageBox.Show("Update Succeed");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("添加失败,有值为空");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
