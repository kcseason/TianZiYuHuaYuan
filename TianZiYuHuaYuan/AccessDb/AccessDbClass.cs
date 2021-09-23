using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace AccessDb
{
    /**//// <summary>   
        /// AccessDb 的摘要说明，以下信息请完整保留   
        /// 请在数据传递完毕后调用Close()方法，关闭数据链接。   
        /// </summary>   
    public class AccessDbClass
    {
        #region 变量声明处   
        public OleDbConnection Conn;
        public string ConnString;//连接字符串  
        #endregion

        #region 构造函数与连接关闭数据库   
        /**//// <summary>   
            /// 构造函数   
            /// </summary>   
            /// <param name="Dbpath">ACCESS数据库路径</param>   
        public AccessDbClass(string Dbpath)
        {
            ConnString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=";
            ConnString += Dbpath;
            Conn = new OleDbConnection(ConnString);
            Conn.Open();
        }
        public AccessDbClass()
        {
            ConnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=";
            ConnString += System.AppDomain.CurrentDomain.BaseDirectory + @"\db.accdb";
            Conn = new OleDbConnection(ConnString);
            Conn.Open();
        }
        /**//// <summary>   
            /// 打开数据源链接   
            /// </summary>   
            /// <returns></returns>   
        public OleDbConnection DbConn()
        {
            Conn.Open();
            return Conn;
        }

        /**//// <summary>   
            /// 请在数据传递完毕后调用该函数，关闭数据链接。   
            /// </summary>   
        public void Close()
        {
            Conn.Close();
        }
        #endregion

        #region 数据库基本操作   
        /**//// <summary>   
            /// 根据SQL命令返回数据DataTable数据表,   
            /// 可直接作为dataGridView的数据源   
            /// </summary>   
            /// <param name="SQL"></param>   
            /// <returns></returns>   
        public DataTable SelectToDataTable(string SQL)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(SQL, Conn);
            adapter.SelectCommand = command;
            DataTable Dt = new DataTable();
            adapter.Fill(Dt);
            return Dt;
        }

        /**//// <summary>   
            /// 根据SQL命令返回数据DataSet数据集，其中的表可直接作为dataGridView的数据源。   
            /// </summary>   
            /// <param name="SQL"></param>   
            /// <param name="subtableName">在返回的数据集中所添加的表的名称</param>   
            /// <returns></returns>   
        public DataSet SelectToDataSet(string SQL, string subtableName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(SQL, Conn);
            adapter.SelectCommand = command;
            DataSet Ds = new DataSet();
            Ds.Tables.Add(subtableName);
            adapter.Fill(Ds, subtableName);
            return Ds;
        }

        /**//// <summary>   
            /// 在指定的数据集中添加带有指定名称的表，由于存在覆盖已有名称表的危险，返回操作之前的数据集。   
            /// </summary>   
            /// <param name="SQL"></param>   
            /// <param name="subtableName">添加的表名</param>   
            /// <param name="DataSetName">被添加的数据集名</param>   
            /// <returns></returns>   
        public DataSet SelectToDataSet(string SQL, string subtableName, DataSet DataSetName)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(SQL, Conn);
            adapter.SelectCommand = command;
            DataTable Dt = new DataTable();
            DataSet Ds = new DataSet();
            Ds = DataSetName;
            adapter.Fill(DataSetName, subtableName);
            return Ds;
        }

        /**//// <summary>   
            /// 根据SQL命令返回OleDbDataAdapter，   
            /// 使用前请在主程序中添加命名空间System.Data.OleDb   
            /// </summary>   
            /// <param name="SQL"></param>   
            /// <returns></returns>   
        public OleDbDataAdapter SelectToOleDbDataAdapter(string SQL)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(SQL, Conn);
            adapter.SelectCommand = command;
            return adapter;
        }

        /**//// <summary>   
            /// 执行SQL命令，不需要返回数据的修改，删除可以使用本函数   
            /// </summary>   
            /// <param name="SQL"></param>   
            /// <returns></returns>   
        public bool ExecuteSQLNonquery(string SQL)
        {
            OleDbCommand cmd = new OleDbCommand(SQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion


        //#region 使用SqlBulkCopy将DataTable中的数据批量插入数据库中  
        ///// <summary>  
        ///// 使用SqlBulkCopy将DataTable中的数据批量插入数据库中  
        ///// </summary>  
        ///// <param name="strTableName">数据库中对应的表名</param>  
        ///// <param name="dtData">数据集</param>  
        //public void SqlBulkCopyInsert(string strTableName, DataTable dtData)
        //{
        //    string ConStr = ConnString;// 数据库连接字符串  

        //    try
        //    {
        //        using (SqlBulkCopy sqlRevdBulkCopy = new SqlBulkCopy(ConStr))//引用SqlBulkCopy  
        //        {
        //            sqlRevdBulkCopy.DestinationTableName = strTableName;//数据库中对应的表名  
        //            sqlRevdBulkCopy.NotifyAfter = dtData.Rows.Count;//有几行数据  
        //            sqlRevdBulkCopy.WriteToServer(dtData);//数据导入数据库  
        //            sqlRevdBulkCopy.Close();//关闭连接  
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //WriteErrorLog(ex.Message + "数据库处理出错654行。SqlBulkCopyInsert");
        //        throw (ex);
        //    }
        //}
        //#endregion

        //-------------更新数据库----------------------------

        public bool dbUpdate(string sql, DataTable dtShow)
        {
            //创建一个DataTable
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            OleDbCommand command = new OleDbCommand(sql, Conn);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter); //没有这句会出错
            adapter.SelectCommand = command;
            DataTable dtUpdate = new DataTable();
            adapter.Fill(dtUpdate);

            //调用Clear方法
            dtUpdate.Rows.Clear();

            //使用for循环遍历行
            for (int i = 0; i < dtShow.Rows.Count; i++)
                //使用ImportRow方法复制dtShow中的值
                dtUpdate.ImportRow(dtShow.Rows[i]);

            adapter.Update(dtUpdate);   //调用Update方法更新数据库

            //提交更改
            dtUpdate.AcceptChanges();
            return true;
        }
    }
}