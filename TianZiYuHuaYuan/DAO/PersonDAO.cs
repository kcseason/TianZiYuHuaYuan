using AccessDb;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TianZiYuHuaYuan.DAO
{
    class PersonDAO
    {
        public DataTable GetAllPerson()
        {
            //初始化，载入数据库路径
            AccessDbClass mydb = new AccessDbClass();
            //返回符合SQL要求的DataTable，并且与控件dataGridView1绑定
            DataTable dt = new DataTable();
            dt = mydb.SelectToDataTable(@"select * from Person ");
            mydb.Close();
            return dt;
        }

        public bool SaveData(DataTable dt)
        {
            try
            {
                //初始化，载入数据库路径
                AccessDbClass mydb = new AccessDbClass();
                mydb.dbUpdate("select * from Person", dt);
                return true;
            }
            catch { return false; }
        }
    }
}
