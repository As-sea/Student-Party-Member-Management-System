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
    public partial class Admin13StudentMan : Form
    {
        string ID = "";
        public Admin13StudentMan()
        {
            InitializeComponent();
        }

        public Admin13StudentMan(string id ,string name ,  string level , string score)
        {
            InitializeComponent();
            ID = txtid.Text = id;
            txtname.Text = name;
            txtlevel.Text = level;
            txscore.Text = score;
            //txtpwd.Text = "***";

            getPwd();

            
        }
        
         public void getPwd()
        {
            //将密码导入txt
            DaoClass dao = new DaoClass();
            string sql = "select id ,pwd from t_user where id=ID";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                //MessageBox.Show($"{ID}   {dc[0].ToString()}  {{dc[4].ToString()}}");
                if (dc[0].ToString() == ID)
                {
                    //MessageBox.Show($"{dc[1].ToString()}");
                    txtpwd.Text = dc[1].ToString();
                }
            }
            
            dc.Close();
            dao.DaoClose();
        }
         

        private void button3_Click(object sender, EventArgs e)
        {
            txtpwd.Text = "123456"; //重置密码

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = $"update t_user set id='{txtid.Text}',[name]='{txtname.Text}',pwd='{txtpwd.Text}',parlevel='{txtlevel.Text}',studysocer='{int.Parse(txscore.Text)}' where id='{ID}'";
            DaoClass dao = new DaoClass();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("Update Succeed");
                this.Close();
            }
        }

      
    }
}
