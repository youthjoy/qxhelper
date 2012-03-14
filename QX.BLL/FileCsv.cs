//读文件源代码；
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using QX.DataAcess;
namespace QX.BLL
{
    public partial class ReadCSV
    {
        private string FileName;
        private string FilsPath;
        /// <summary>
        /// 构造函数:文件所在路径
        /// </summary>
        /// <param name="Path">文件路径（为Csv文件所在的文件夹路径）</param>
        /// <param name="Files">读Csv文件时的文件名</param>
        public ReadCSV(string Path, string Files)//构造
        {
            FileName = Path;
            FilsPath = Files;
        }
        OleDbConnection OleCon = new OleDbConnection();
        OleDbCommand OleCmd = new OleDbCommand();
        OleDbDataAdapter OleDa = new OleDbDataAdapter();
        #region 读取Csv文件返回DataSet
        /// <summary>
        ///  读取Csv文件返回DataSet
        /// </summary>
        /// <returns>Csv内容</returns>
        public DataSet Csv()
        {
            DataSet CsvData = new DataSet();
            OleCon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FileName + ";Extended Properties='Text;FMT=Delimited;HDR=YES;'";
            OleCon.Open();
            OleCmd.Connection = OleCon;
            OleCmd.CommandText = "select * From " + FilsPath;
            OleDa.SelectCommand = OleCmd;
            try
            {
                OleDa.Fill(CsvData, "Csv");
                return CsvData;
            }
            catch
            {
                return CsvData;
            }
            finally
            {
                OleCon.Close();
                OleCmd.Dispose();
                OleDa.Dispose();
                OleCon.Dispose();
            }
        }
        #endregion
    }

    public partial class SqlBulkData
    {
        SqlConnection SqlCon = new SqlConnection();

        #region 将数据写数据库表中
        /// <summary>
        /// 将数据写数据库表中
        /// </summary>
        /// <param name="_Ds">数据源内容</param>
        /// <param name="_TableName">表名</param>
        /// <returns>返回是否成功！</returns>
        public bool BulkData(DataSet _Ds, string _TableName)
        {
            SqlCon.ConnectionString = ConfigurationSettings.AppSettings["ConnectionString"].ToString();
            SqlCon.Open();
            SqlBulkCopy SqlBulk = new SqlBulkCopy(SqlCon);
            SqlBulk.DestinationTableName = _TableName;
            try
            {
                
                SqlBulk.WriteToServer(_Ds.Tables[0], DataRowState.Unchanged);
                return true;
            }
            catch (Exception ex)
            {   
                return false;
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
                SqlBulk.Close();
            }
        }
        #endregion
    }
    public partial class SqlINSERT
    {
        public IDBOperator idb = DBOperator.GetInstance();
        private DataTable dt=null;
        private DataTable dts = null;
        StringBuilder Csb = new StringBuilder();
        private string ModuleCode;
        private string NameSpace;
        private string DefaultValue;
       // public readonly string Sql = "select a.name,a.length,b.name from syscolumns a,   systypes   b,sysobjects   c where   a.xtype=b.xtype   and   a.id=c.id   and   c.name= 'HR_Stuff '";
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="ModuleCode">模板编码</param>
        /// <param name="NameSpace">命名空间</param>
        public SqlINSERT(string ModuleCode,string NameSpace)
        {
            this.ModuleCode = ModuleCode;
            this.NameSpace = NameSpace;
            string Sql = "SELECT  cf.D_Index,cf.D_Type,clp.M_TableName,cf.D_EditHidden,cf.D_DefaultValue FROM Config_Fieled cf,Config_ListPage clp WHERE cf.D_ModuleCode='" + this.ModuleCode + "' AND cf.D_NameSpace='" + this.NameSpace + "' AND ( Cf.D_EditHidden!='true' or Cf.D_EditHidden is null )AND  clp.M_ModuleCode=cf.D_ModuleCode AND clp.M_NameSpace=cf.D_NameSpace";
            string SqlValue = "SELECT top 1 cf.D_Index,cf.D_DefaultValue FROM Config_Fieled cf,Config_ListPage clp WHERE cf.D_ModuleCode='Document_LendingModule' AND cf.D_NameSpace='Document_Lending' AND ( Cf.D_EditHidden!='true' or Cf.D_EditHidden is null )AND  clp.M_ModuleCode=cf.D_ModuleCode AND clp.M_NameSpace=cf.D_NameSpace AND cf.D_DefaultValue  is not null";
            dt = idb.ReturnDataTable(Sql);
            dts = idb.ReturnDataTable(SqlValue);
            DefaultValue = dts.Rows.Count.Equals(0) ? null : dts.Rows[0][1].ToString();
        }
       /// <summary>
        /// 将数据写数据库表中
       /// </summary>
        /// <param name="_DS">数据源内容</param>
       /// <returns>返回验证信息，为空则插入数据成功</returns>
        public string INSERTData(DataSet _DS)
        {
            
                bool bl = true;
                StringBuilder sb = new StringBuilder();
                StringBuilder clname = new StringBuilder();
                string sql = string.Empty;
                int count = _DS.Tables[0].Columns.Count;
                List<string> Caption = new List<string>();
                List<string> caption = new List<string>();
                string TableName = dt.Rows[0][2].ToString();
                string Code = dt.Rows[0][0].ToString();
                try
                {
                    for (int i = 0; i < _DS.Tables[0].Columns.Count; i++)
                    {
                        Caption.Add(_DS.Tables[0].Columns[i].Caption.Split('(')[1].Split(')')[0]);
                    }
                    for (int i = 0; i < _DS.Tables[0].Columns.Count; i++)
                    {
                        caption.Add(_DS.Tables[0].Columns[i].ToString());
                    }
                    foreach (var list in Caption)
                    {
                        foreach (DataRow ct in dt.Rows)
                        {
                            if (list.Contains(ct[0].ToString()))
                            {
                                bl = true;
                                break;
                            }
                            else
                                bl = false;
                        }
                        if (bl == false) sb.Append(string.Format("{0},", list));
                    }
                    if (sb.Length == 0)
                    {
                        for (int i = 0; i < Caption.Count; i++)
                        {
                            Csb.Append(Caption[i]);
                            Csb.Append(",");
                        }
                        string csb = Csb.Remove(Csb.Length - 1, 1).ToString();
                        for (int y = 0; y < _DS.Tables[0].Rows.Count; y++)
                        {
                                //添加自动生成Code
                                clname.Append("'");
                                clname.Append(NameSpace + new Bll_Sys_Config_ListPage().GetTableKeyCode(NameSpace));
                                clname.Append("'");
                                clname.Append(",");
                            for (int i = 0; i < Caption.Count; i++)
                            {
                                
                                if (_DS.Tables[0].Columns[caption[i]].DataType.IsValueType && _DS.Tables[0].Columns[caption[i]].DataType.ToString() != "System.DateTime")
                                {
                                    clname.Append(_DS.Tables[0].Rows[y][caption[i]].ToString());
                                    clname.Append(",");
                                }
                                else
                                {
                                    clname.Append("'");
                                    clname.Append(_DS.Tables[0].Rows[y][caption[i]].ToString());
                                    clname.Append("'");
                                    clname.Append(",");
                                }
                            }
                            if (string.IsNullOrEmpty(DefaultValue))
                                sql = "INSERT INTO " + TableName + " (" + dt.Rows[0][0].ToString() + "," + csb + ") VALUES (" + clname.ToString().Remove(clname.Length - 1, 1) + ")";
                            else
                            {
                                sql = "INSERT INTO " + TableName + " (" + dts.Rows[0][0].ToString() + "," + dt.Rows[0][0].ToString() + "," + csb + ") VALUES (" + dts.Rows[0][1].ToString() + "," + clname.ToString().Remove(clname.Length - 1, 1) + ")";
                            }
                            clname.Remove(0, clname.Length);
                            //idb.ExeCmd(sql).Equals(1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    sb.Append(string.Format("{0},", ex));
                }
            return sb.ToString();
        }
    }
}
