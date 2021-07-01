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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //登录按钮，需要判断登陆身份
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //判断输入框中是否有值，有则调用login
            if (txtName.Text != "" && txtPsw.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("输入有误，请重新输入！！");
            }
        }


        //login()判断身份 直接登录
        public void login()
        {
            //用户
            if (radioUser.Checked == true)
            {
                //数据库实例
                DaoClass dao = new DaoClass();
             
                string sql1 = $"select * from t_user where id='{txtName.Text}' and pwd='{txtPsw.Text}'";
                IDataReader dc = dao.read(sql1);

                if (dc.Read())
                {
                    DataClass.UID = dc["id"].ToString();
                    DataClass.UNAME = dc["name"].ToString();//方便传参

                    MessageBox.Show("登陆成功");
                    

                    //实例化窗体
                    User1 user = new User1();
                    this.Hide();//隐藏（旧）登录窗体
                    user.ShowDialog();//等该窗体关闭后才能打开其他窗体
                    this.Show();

                }
                else
                {
                    MessageBox.Show("登陆失败");
                }
                //MessageBox.Show(dc[0].ToString(),dc["name"].ToString());
                dao.DaoClose();
            }
            //Admin
            if (radioAdmin.Checked == true)
            {
                DaoClass dao = new DaoClass();
                string sql1 = $"select * from t_admin where id='{txtName.Text}' and pwd='{txtPsw.Text}'";
                IDataReader dc = dao.read(sql1);
                if (dc.Read())
                {
                    MessageBox.Show("登陆成功");
                    //return true;

                    Admin1 a = new Admin1();
                    this.Hide();
                    a.ShowDialog();//等该窗体关闭后才能打开其他窗体
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败");
                   
                }
                dao.DaoClose();
            }
            //return true;
            //MessageBox.Show("单选框要选中");
            //return false;
        }







        //退出按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
