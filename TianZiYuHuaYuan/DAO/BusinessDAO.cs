using AccessDb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TianZiYuHuaYuan.DAO
{
    class BusinessDAO
    {
        public DataTable GetAllBusiness()
        {
            //初始化，载入数据库路径
            AccessDbClass mydb = new AccessDbClass();
            //返回符合SQL要求的DataTable，并且与控件dataGridView1绑定
            DataTable dt = new DataTable();
            dt = mydb.SelectToDataTable(@"select * from Business order by ID");
            mydb.Close();
            return dt;
        }
        public DataTable GetAllBusiness(string condition)
        {
            //初始化，载入数据库路径
            AccessDbClass mydb = new AccessDbClass();
            //返回符合SQL要求的DataTable，并且与控件dataGridView1绑定
            DataTable dt = new DataTable();
            dt = mydb.SelectToDataTable(@"select * from Business where " + condition +" order by ID");
            mydb.Close();
            return dt;
        }
        public bool SaveData(DataTable dt)
        {
            try
            {
                //初始化，载入数据库路径
                AccessDbClass mydb = new AccessDbClass();
                mydb.dbUpdate("select * from Business", dt);
                return true;
            }
            catch { return false; }
        }
    }
}
