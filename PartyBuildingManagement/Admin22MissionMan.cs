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
    public partial class Admin22MissionMan : Form
    {
        
        public Admin22MissionMan()
        {
            InitializeComponent();
        }
        public Admin22MissionMan(string id)
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

        private void btnRe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
