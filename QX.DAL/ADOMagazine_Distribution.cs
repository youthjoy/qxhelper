using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   /// <summary>
   /// 报刊杂志分发记录
   /// </summary>
   [Serializable]
   public partial class ADOMagazine_Distribution
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加报刊杂志分发记录 Magazine_Distribution对象(即:一条记录)
      /// </summary>
      public int Add(Magazine_Distribution magazine_Distribution)
      {
         string sql = "INSERT INTO Magazine_Distribution (MDistribution_Code,MDistribution_OrderCode,MDistribution_OrderName,MDistribution_Dept,MDistribution_Company,MDistribution_Count,MDistribution_Date,MDistribution_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@MDistribution_Code,@MDistribution_OrderCode,@MDistribution_OrderName,@MDistribution_Dept,@MDistribution_Company,@MDistribution_Count,@MDistribution_Date,@MDistribution_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Code))
         {
            idb.AddParameter("@MDistribution_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Code", magazine_Distribution.MDistribution_Code);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_OrderCode))
         {
            idb.AddParameter("@MDistribution_OrderCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_OrderCode", magazine_Distribution.MDistribution_OrderCode);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_OrderName))
         {
            idb.AddParameter("@MDistribution_OrderName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_OrderName", magazine_Distribution.MDistribution_OrderName);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Dept))
         {
            idb.AddParameter("@MDistribution_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Dept", magazine_Distribution.MDistribution_Dept);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Company))
         {
            idb.AddParameter("@MDistribution_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Company", magazine_Distribution.MDistribution_Company);
         }
         if (magazine_Distribution.MDistribution_Count == 0)
         {
            idb.AddParameter("@MDistribution_Count", 0);
         }
         else
         {
            idb.AddParameter("@MDistribution_Count", magazine_Distribution.MDistribution_Count);
         }
         if (magazine_Distribution.MDistribution_Date == 0)
         {
            idb.AddParameter("@MDistribution_Date", 0);
         }
         else
         {
            idb.AddParameter("@MDistribution_Date", magazine_Distribution.MDistribution_Date);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Remark))
         {
            idb.AddParameter("@MDistribution_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Remark", magazine_Distribution.MDistribution_Remark);
         }
         if (magazine_Distribution.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", magazine_Distribution.Stat);
         }
         if (magazine_Distribution.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", magazine_Distribution.CreateDate);
         }
         if (magazine_Distribution.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", magazine_Distribution.UpdateDate);
         }
         if (magazine_Distribution.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", magazine_Distribution.DeleteDate);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
         
      }
      /// <summary>
      /// 添加报刊杂志分发记录 Magazine_Distribution对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Magazine_Distribution magazine_Distribution)
      {
         string sql = "INSERT INTO Magazine_Distribution (MDistribution_Code,MDistribution_OrderCode,MDistribution_OrderName,MDistribution_Dept,MDistribution_Company,MDistribution_Count,MDistribution_Date,MDistribution_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@MDistribution_Code,@MDistribution_OrderCode,@MDistribution_OrderName,@MDistribution_Dept,@MDistribution_Company,@MDistribution_Count,@MDistribution_Date,@MDistribution_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Code))
         {
            idb.AddParameter("@MDistribution_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Code", magazine_Distribution.MDistribution_Code);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_OrderCode))
         {
            idb.AddParameter("@MDistribution_OrderCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_OrderCode", magazine_Distribution.MDistribution_OrderCode);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_OrderName))
         {
            idb.AddParameter("@MDistribution_OrderName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_OrderName", magazine_Distribution.MDistribution_OrderName);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Dept))
         {
            idb.AddParameter("@MDistribution_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Dept", magazine_Distribution.MDistribution_Dept);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Company))
         {
            idb.AddParameter("@MDistribution_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Company", magazine_Distribution.MDistribution_Company);
         }
         if (magazine_Distribution.MDistribution_Count == 0)
         {
            idb.AddParameter("@MDistribution_Count", 0);
         }
         else
         {
            idb.AddParameter("@MDistribution_Count", magazine_Distribution.MDistribution_Count);
         }
         if (magazine_Distribution.MDistribution_Date == 0)
         {
            idb.AddParameter("@MDistribution_Date", 0);
         }
         else
         {
            idb.AddParameter("@MDistribution_Date", magazine_Distribution.MDistribution_Date);
         }
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Remark))
         {
            idb.AddParameter("@MDistribution_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Remark", magazine_Distribution.MDistribution_Remark);
         }
         if (magazine_Distribution.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", magazine_Distribution.Stat);
         }
         if (magazine_Distribution.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", magazine_Distribution.CreateDate);
         }
         if (magazine_Distribution.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", magazine_Distribution.UpdateDate);
         }
         if (magazine_Distribution.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", magazine_Distribution.DeleteDate);
         }

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 var Return = idb.ReturnValue(sql);
                 Ex = Return.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 更新报刊杂志分发记录 Magazine_Distribution对象(即:一条记录
      /// </summary>
      public int Update(Magazine_Distribution magazine_Distribution)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Magazine_Distribution       SET ");
            if(magazine_Distribution.MDistribution_Code_IsChanged){sbParameter.Append("MDistribution_Code=@MDistribution_Code, ");}
      if(magazine_Distribution.MDistribution_OrderCode_IsChanged){sbParameter.Append("MDistribution_OrderCode=@MDistribution_OrderCode, ");}
      if(magazine_Distribution.MDistribution_OrderName_IsChanged){sbParameter.Append("MDistribution_OrderName=@MDistribution_OrderName, ");}
      if(magazine_Distribution.MDistribution_Dept_IsChanged){sbParameter.Append("MDistribution_Dept=@MDistribution_Dept, ");}
      if(magazine_Distribution.MDistribution_Company_IsChanged){sbParameter.Append("MDistribution_Company=@MDistribution_Company, ");}
      if(magazine_Distribution.MDistribution_Count_IsChanged){sbParameter.Append("MDistribution_Count=@MDistribution_Count, ");}
      if(magazine_Distribution.MDistribution_Date_IsChanged){sbParameter.Append("MDistribution_Date=@MDistribution_Date, ");}
      if(magazine_Distribution.MDistribution_Remark_IsChanged){sbParameter.Append("MDistribution_Remark=@MDistribution_Remark, ");}
      if(magazine_Distribution.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(magazine_Distribution.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(magazine_Distribution.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(magazine_Distribution.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MDistributio_ID=@MDistributio_ID; " );
      string sql=sb.ToString();
         if(magazine_Distribution.MDistribution_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Code))
         {
            idb.AddParameter("@MDistribution_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Code", magazine_Distribution.MDistribution_Code);
         }
          }
         if(magazine_Distribution.MDistribution_OrderCode_IsChanged)
         {
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_OrderCode))
         {
            idb.AddParameter("@MDistribution_OrderCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_OrderCode", magazine_Distribution.MDistribution_OrderCode);
         }
          }
         if(magazine_Distribution.MDistribution_OrderName_IsChanged)
         {
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_OrderName))
         {
            idb.AddParameter("@MDistribution_OrderName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_OrderName", magazine_Distribution.MDistribution_OrderName);
         }
          }
         if(magazine_Distribution.MDistribution_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Dept))
         {
            idb.AddParameter("@MDistribution_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Dept", magazine_Distribution.MDistribution_Dept);
         }
          }
         if(magazine_Distribution.MDistribution_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Company))
         {
            idb.AddParameter("@MDistribution_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Company", magazine_Distribution.MDistribution_Company);
         }
          }
         if(magazine_Distribution.MDistribution_Count_IsChanged)
         {
         if (magazine_Distribution.MDistribution_Count == 0)
         {
            idb.AddParameter("@MDistribution_Count", 0);
         }
         else
         {
            idb.AddParameter("@MDistribution_Count", magazine_Distribution.MDistribution_Count);
         }
          }
         if(magazine_Distribution.MDistribution_Date_IsChanged)
         {
         if (magazine_Distribution.MDistribution_Date == 0)
         {
            idb.AddParameter("@MDistribution_Date", 0);
         }
         else
         {
            idb.AddParameter("@MDistribution_Date", magazine_Distribution.MDistribution_Date);
         }
          }
         if(magazine_Distribution.MDistribution_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(magazine_Distribution.MDistribution_Remark))
         {
            idb.AddParameter("@MDistribution_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MDistribution_Remark", magazine_Distribution.MDistribution_Remark);
         }
          }
         if(magazine_Distribution.Stat_IsChanged)
         {
         if (magazine_Distribution.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", magazine_Distribution.Stat);
         }
          }
         if(magazine_Distribution.CreateDate_IsChanged)
         {
         if (magazine_Distribution.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", magazine_Distribution.CreateDate);
         }
          }
         if(magazine_Distribution.UpdateDate_IsChanged)
         {
         if (magazine_Distribution.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", magazine_Distribution.UpdateDate);
         }
          }
         if(magazine_Distribution.DeleteDate_IsChanged)
         {
         if (magazine_Distribution.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", magazine_Distribution.DeleteDate);
         }
          }

         idb.AddParameter("@MDistributio_ID", magazine_Distribution.MDistributio_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 删除报刊杂志分发记录 Magazine_Distribution对象(即:一条记录
      /// </summary>
      public int Delete(decimal mDistributio_ID)
      {
         string sql = "DELETE Magazine_Distribution WHERE 1=1  AND MDistributio_ID=@MDistributio_ID ";
         idb.AddParameter("@MDistributio_ID", mDistributio_ID);

           
             int Re = 0;
             //SQL日志记录
             var RunMethod = System.Reflection.MethodBase.GetCurrentMethod();
             System.Collections.Hashtable param = new System.Collections.Hashtable();
             string Ex = "0";
             foreach (System.Collections.DictionaryEntry item in idb.GetParameters())
             {
                 param.Add(item.Key, item.Value);
             }
             try
             {
                 Re = idb.ExeCmd(sql);
                 Ex = Re.ToString();
             }
             catch (Exception ex)
             {
                 Ex = ex.Message;
             }
             
             SysRunLog.InsertRunSql(sql, param, RunMethod.DeclaringType + "." + RunMethod.Name,Ex);

             return Re;
      }
      /// <summary>
      /// 获取指定的报刊杂志分发记录 Magazine_Distribution对象(即:一条记录
      /// </summary>
      public Magazine_Distribution GetByKey(decimal mDistributio_ID)
      {
         Magazine_Distribution magazine_Distribution = new Magazine_Distribution();
         string sql = "SELECT  MDistributio_ID,MDistribution_Code,MDistribution_OrderCode,MDistribution_OrderName,MDistribution_Dept,MDistribution_Company,MDistribution_Count,MDistribution_Date,MDistribution_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Magazine_Distribution WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MDistributio_ID=@MDistributio_ID ";
         idb.AddParameter("@MDistributio_ID", mDistributio_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MDistributio_ID"] != DBNull.Value) magazine_Distribution.MDistributio_ID = Convert.ToDecimal(dr["MDistributio_ID"]);
            if (dr["MDistribution_Code"] != DBNull.Value) magazine_Distribution.MDistribution_Code = Convert.ToString(dr["MDistribution_Code"]);
            if (dr["MDistribution_OrderCode"] != DBNull.Value) magazine_Distribution.MDistribution_OrderCode = Convert.ToString(dr["MDistribution_OrderCode"]);
            if (dr["MDistribution_OrderName"] != DBNull.Value) magazine_Distribution.MDistribution_OrderName = Convert.ToString(dr["MDistribution_OrderName"]);
            if (dr["MDistribution_Dept"] != DBNull.Value) magazine_Distribution.MDistribution_Dept = Convert.ToString(dr["MDistribution_Dept"]);
            if (dr["MDistribution_Company"] != DBNull.Value) magazine_Distribution.MDistribution_Company = Convert.ToString(dr["MDistribution_Company"]);
            if (dr["MDistribution_Count"] != DBNull.Value) magazine_Distribution.MDistribution_Count = Convert.ToInt32(dr["MDistribution_Count"]);
            if (dr["MDistribution_Date"] != DBNull.Value) magazine_Distribution.MDistribution_Date = Convert.ToInt32(dr["MDistribution_Date"]);
            if (dr["MDistribution_Remark"] != DBNull.Value) magazine_Distribution.MDistribution_Remark = Convert.ToString(dr["MDistribution_Remark"]);
            if (dr["Stat"] != DBNull.Value) magazine_Distribution.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) magazine_Distribution.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) magazine_Distribution.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) magazine_Distribution.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return magazine_Distribution;
      }
      /// <summary>
      /// 获取指定的报刊杂志分发记录 Magazine_Distribution对象集合
      /// </summary>
      public List<Magazine_Distribution> GetListByWhere(string strCondition)
      {
         List<Magazine_Distribution> ret = new List<Magazine_Distribution>();
         string sql = "SELECT  MDistributio_ID,MDistribution_Code,MDistribution_OrderCode,MDistribution_OrderName,MDistribution_Dept,MDistribution_Company,MDistribution_Count,MDistribution_Date,MDistribution_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Magazine_Distribution WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Magazine_Distribution magazine_Distribution = new Magazine_Distribution();
            if (dr["MDistributio_ID"] != DBNull.Value) magazine_Distribution.MDistributio_ID = Convert.ToDecimal(dr["MDistributio_ID"]);
            if (dr["MDistribution_Code"] != DBNull.Value) magazine_Distribution.MDistribution_Code = Convert.ToString(dr["MDistribution_Code"]);
            if (dr["MDistribution_OrderCode"] != DBNull.Value) magazine_Distribution.MDistribution_OrderCode = Convert.ToString(dr["MDistribution_OrderCode"]);
            if (dr["MDistribution_OrderName"] != DBNull.Value) magazine_Distribution.MDistribution_OrderName = Convert.ToString(dr["MDistribution_OrderName"]);
            if (dr["MDistribution_Dept"] != DBNull.Value) magazine_Distribution.MDistribution_Dept = Convert.ToString(dr["MDistribution_Dept"]);
            if (dr["MDistribution_Company"] != DBNull.Value) magazine_Distribution.MDistribution_Company = Convert.ToString(dr["MDistribution_Company"]);
            if (dr["MDistribution_Count"] != DBNull.Value) magazine_Distribution.MDistribution_Count = Convert.ToInt32(dr["MDistribution_Count"]);
            if (dr["MDistribution_Date"] != DBNull.Value) magazine_Distribution.MDistribution_Date = Convert.ToInt32(dr["MDistribution_Date"]);
            if (dr["MDistribution_Remark"] != DBNull.Value) magazine_Distribution.MDistribution_Remark = Convert.ToString(dr["MDistribution_Remark"]);
            if (dr["Stat"] != DBNull.Value) magazine_Distribution.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) magazine_Distribution.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) magazine_Distribution.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) magazine_Distribution.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(magazine_Distribution);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的报刊杂志分发记录 Magazine_Distribution对象(即:一条记录
      /// </summary>
      public List<Magazine_Distribution> GetAll()
      {
         List<Magazine_Distribution> ret = new List<Magazine_Distribution>();
         string sql = "SELECT  MDistributio_ID,MDistribution_Code,MDistribution_OrderCode,MDistribution_OrderName,MDistribution_Dept,MDistribution_Company,MDistribution_Count,MDistribution_Date,MDistribution_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Magazine_Distribution where 1=1 AND ((Stat is null) or (Stat=0) ) order by MDistributio_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Magazine_Distribution magazine_Distribution = new Magazine_Distribution();
            if (dr["MDistributio_ID"] != DBNull.Value) magazine_Distribution.MDistributio_ID = Convert.ToDecimal(dr["MDistributio_ID"]);
            if (dr["MDistribution_Code"] != DBNull.Value) magazine_Distribution.MDistribution_Code = Convert.ToString(dr["MDistribution_Code"]);
            if (dr["MDistribution_OrderCode"] != DBNull.Value) magazine_Distribution.MDistribution_OrderCode = Convert.ToString(dr["MDistribution_OrderCode"]);
            if (dr["MDistribution_OrderName"] != DBNull.Value) magazine_Distribution.MDistribution_OrderName = Convert.ToString(dr["MDistribution_OrderName"]);
            if (dr["MDistribution_Dept"] != DBNull.Value) magazine_Distribution.MDistribution_Dept = Convert.ToString(dr["MDistribution_Dept"]);
            if (dr["MDistribution_Company"] != DBNull.Value) magazine_Distribution.MDistribution_Company = Convert.ToString(dr["MDistribution_Company"]);
            if (dr["MDistribution_Count"] != DBNull.Value) magazine_Distribution.MDistribution_Count = Convert.ToInt32(dr["MDistribution_Count"]);
            if (dr["MDistribution_Date"] != DBNull.Value) magazine_Distribution.MDistribution_Date = Convert.ToInt32(dr["MDistribution_Date"]);
            if (dr["MDistribution_Remark"] != DBNull.Value) magazine_Distribution.MDistribution_Remark = Convert.ToString(dr["MDistribution_Remark"]);
            if (dr["Stat"] != DBNull.Value) magazine_Distribution.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) magazine_Distribution.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) magazine_Distribution.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) magazine_Distribution.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(magazine_Distribution);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
