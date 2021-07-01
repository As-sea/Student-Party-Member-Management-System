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
    public partial class User2check : Form
    {
        public User2check()
        {
            InitializeComponent();
            Table();
        }
        public void Table()
        {
            dataGridView1.Rows.Clear();
       
            DaoClass dao = new DaoClass();
            string sql = "select name,studysocer from t_user order by studysocer desc";

            IDataReader dc = dao.read(sql);

            while (dc.Read())
            {
                dataGridView1.Rows.Add(dc[0].ToString(), dc[1].ToString());
                
            }

            dc.Close();
            dao.DaoClose();
        }
    }
}
