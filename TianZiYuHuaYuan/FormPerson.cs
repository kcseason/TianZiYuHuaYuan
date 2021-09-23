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
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        private void FormPerson_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            PersonDAO dao = new PersonDAO();
            this.dataGridView1.DataSource = dao.GetAllPerson();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataTable dt = this.dataGridView1.DataSource as DataTable;
            PersonDAO dao = new PersonDAO();
            if (dao.SaveData(dt))
                MessageBox.Show("保存成功！");
            else
                MessageBox.Show("保存失败！");
        }
    }
}
