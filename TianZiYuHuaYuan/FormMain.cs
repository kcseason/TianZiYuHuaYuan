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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPerson_Click(object sender, EventArgs e)
        {
            var pForm = new FormPerson();
            pForm.ShowDialog();
        }

        private void MenuBusiness_Click(object sender, EventArgs e)
        {
            var bForm = new FormBusiness();
            bForm.ShowDialog();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            var tp = tabControl1.SelectedTab;
            if (tp.Name.Contains("money"))
            {
                CalculateMoney();
            }
            else if (tp.Name.Contains("soldier"))
            {

            }
            else if (tp.Name.Contains("food"))
            {

            }
            else
            {

            }
        }

        private void CalculateMoney()
        {
            var pDao = new PersonDAO();
            var pDt = pDao.GetAllPerson();
            var maxLevelRow = pDt.Select(" ID = 1 ", " Level desc ");
            var maxLevel = Convert.ToInt32(maxLevelRow[0]["Level"].ToString());
            var bDao = new BusinessDAO();
            var bDt = bDao.GetAllBusiness(" ReturnMoney = True");

            var showDt = bDt.Clone();

            var list = new Dictionary<string, List<string[]>>();
            for (var i = bDt.Rows.Count - 1; i > 0; i--)
            {
                // 1,50,100,150,200,150,300
                var requirement = bDt.Rows[i]["Persons"].ToString();
                var array = requirement.Split(',');
                var childList = new List<string[]>();
                foreach (var temp in array)
                {
                    var arr = temp.Split('_');
                    childList.Add(arr);
                }
                list.Add(bDt.Rows[i]["BusinessName"].ToString(), childList);
            }
        }
    }
}
