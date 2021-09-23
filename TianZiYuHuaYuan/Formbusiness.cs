using AccessDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TianZiYuHuaYuan.DAO;

namespace TianZiYuHuaYuan
{
    public partial class FormBusiness : Form
    {
        public FormBusiness()
        {
            InitializeComponent();
        }

        private void FormBusiness_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            BusinessDAO dao = new BusinessDAO();
            this.dataGridView1.DataSource = dao.GetAllBusiness();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dataGridView1.DataSource as DataTable;
            BusinessDAO dao = new BusinessDAO();
            if (dao.SaveData(dt))
                MessageBox.Show("保存成功！");
            else
                MessageBox.Show("保存失败！");
        }
    }
}
