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
    public partial class User22Comptele : Form
    {
        public User22Comptele()
        {
            InitializeComponent();
        }
        public User22Comptele(string id)
        {
            InitializeComponent();
            label2.Text = id;
            ShowContent(id);
        }
        public void ShowContent(string id)
        {
            DaoClass dao = new DaoClass();
            string sql = $"select * from t_studycontent where id=id";
            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                if (dc[0].ToString() == id)
                {
                    //MessageBox.Show($"{dc[1].ToString()}nn{dc[2].ToString()}nn{dc[3].ToString()}");
                    label4.Text = dc[1].ToString();
                    label6.Text = dc[2].ToString();
                    textBox1.Text = dc[3].ToString();

                }

            }
            dc.Close();
            dao.DaoClose();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCom_Click(object sender, EventArgs e)
        {
            string id = label2.Text;
            iscomple(id);
        }
        public void iscomple(string id)
        {
            string sql = $"insert into t_iscomplet ([uid],sid,[datetime]) values('{DataClass.UID}','{id}',getdate());update t_user set studysocer=studysocer+3 where id='{DataClass.UID}'";
            DaoClass dao = new DaoClass();
            if (dao.Execute(sql) > 1)//执行是两条sql ， 大于1才算成功
            {
                MessageBox.Show($"{DataClass.UNAME} is complete {id}mession");
                
            }
        }
    }
}
