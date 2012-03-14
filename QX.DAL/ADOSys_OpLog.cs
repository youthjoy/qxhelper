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
   /// 系统操作日志
   /// </summary>
   [Serializable]
   public partial class ADOSys_OpLog
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加系统操作日志 Sys_OpLog对象(即:一条记录)
      /// </summary>
      public int Add(Sys_OpLog sys_OpLog)
      {
         string sql = "INSERT INTO Sys_OpLog (EL_Module,EL_ModuleName,EL_Date,EL_Author,EL_AuthorName,EL_ClientIP,EL_RequireURL,EL_Message,Stat) VALUES (@EL_Module,@EL_ModuleName,@EL_Date,@EL_Author,@EL_AuthorName,@EL_ClientIP,@EL_RequireURL,@EL_Message,@Stat)";
         if (string.IsNullOrEmpty(sys_OpLog.EL_Module))
         {
            idb.AddParameter("@EL_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Module", sys_OpLog.EL_Module);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_ModuleName))
         {
            idb.AddParameter("@EL_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_ModuleName", sys_OpLog.EL_ModuleName);
         }
         if (sys_OpLog.EL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@EL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Date", sys_OpLog.EL_Date);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_Author))
         {
            idb.AddParameter("@EL_Author", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Author", sys_OpLog.EL_Author);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_AuthorName))
         {
            idb.AddParameter("@EL_AuthorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_AuthorName", sys_OpLog.EL_AuthorName);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_ClientIP))
         {
            idb.AddParameter("@EL_ClientIP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_ClientIP", sys_OpLog.EL_ClientIP);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_RequireURL))
         {
            idb.AddParameter("@EL_RequireURL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_RequireURL", sys_OpLog.EL_RequireURL);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_Message))
         {
            idb.AddParameter("@EL_Message", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Message", sys_OpLog.EL_Message);
         }
         if (sys_OpLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_OpLog.Stat);
         }

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 添加系统操作日志 Sys_OpLog对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Sys_OpLog sys_OpLog)
      {
         string sql = "INSERT INTO Sys_OpLog (EL_Module,EL_ModuleName,EL_Date,EL_Author,EL_AuthorName,EL_ClientIP,EL_RequireURL,EL_Message,Stat) VALUES (@EL_Module,@EL_ModuleName,@EL_Date,@EL_Author,@EL_AuthorName,@EL_ClientIP,@EL_RequireURL,@EL_Message,@Stat);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(sys_OpLog.EL_Module))
         {
            idb.AddParameter("@EL_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Module", sys_OpLog.EL_Module);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_ModuleName))
         {
            idb.AddParameter("@EL_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_ModuleName", sys_OpLog.EL_ModuleName);
         }
         if (sys_OpLog.EL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@EL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Date", sys_OpLog.EL_Date);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_Author))
         {
            idb.AddParameter("@EL_Author", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Author", sys_OpLog.EL_Author);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_AuthorName))
         {
            idb.AddParameter("@EL_AuthorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_AuthorName", sys_OpLog.EL_AuthorName);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_ClientIP))
         {
            idb.AddParameter("@EL_ClientIP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_ClientIP", sys_OpLog.EL_ClientIP);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_RequireURL))
         {
            idb.AddParameter("@EL_RequireURL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_RequireURL", sys_OpLog.EL_RequireURL);
         }
         if (string.IsNullOrEmpty(sys_OpLog.EL_Message))
         {
            idb.AddParameter("@EL_Message", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Message", sys_OpLog.EL_Message);
         }
         if (sys_OpLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_OpLog.Stat);
         }

         return idb.ReturnValue(sql);
      }
      /// <summary>
      /// 更新系统操作日志 Sys_OpLog对象(即:一条记录
      /// </summary>
      public int Update(Sys_OpLog sys_OpLog)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Sys_OpLog       SET ");
            if(sys_OpLog.EL_Module_IsChanged){sbParameter.Append("EL_Module=@EL_Module, ");}
      if(sys_OpLog.EL_ModuleName_IsChanged){sbParameter.Append("EL_ModuleName=@EL_ModuleName, ");}
      if(sys_OpLog.EL_Date_IsChanged){sbParameter.Append("EL_Date=@EL_Date, ");}
      if(sys_OpLog.EL_Author_IsChanged){sbParameter.Append("EL_Author=@EL_Author, ");}
      if(sys_OpLog.EL_AuthorName_IsChanged){sbParameter.Append("EL_AuthorName=@EL_AuthorName, ");}
      if(sys_OpLog.EL_ClientIP_IsChanged){sbParameter.Append("EL_ClientIP=@EL_ClientIP, ");}
      if(sys_OpLog.EL_RequireURL_IsChanged){sbParameter.Append("EL_RequireURL=@EL_RequireURL, ");}
      if(sys_OpLog.EL_Message_IsChanged){sbParameter.Append("EL_Message=@EL_Message, ");}
      if(sys_OpLog.Stat_IsChanged){sbParameter.Append("Stat=@Stat ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and EL_ID=@EL_ID; " );
      string sql=sb.ToString();
         if(sys_OpLog.EL_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_OpLog.EL_Module))
         {
            idb.AddParameter("@EL_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Module", sys_OpLog.EL_Module);
         }
          }
         if(sys_OpLog.EL_ModuleName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_OpLog.EL_ModuleName))
         {
            idb.AddParameter("@EL_ModuleName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_ModuleName", sys_OpLog.EL_ModuleName);
         }
          }
         if(sys_OpLog.EL_Date_IsChanged)
         {
         if (sys_OpLog.EL_Date == DateTime.MinValue)
         {
            idb.AddParameter("@EL_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Date", sys_OpLog.EL_Date);
         }
          }
         if(sys_OpLog.EL_Author_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_OpLog.EL_Author))
         {
            idb.AddParameter("@EL_Author", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Author", sys_OpLog.EL_Author);
         }
          }
         if(sys_OpLog.EL_AuthorName_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_OpLog.EL_AuthorName))
         {
            idb.AddParameter("@EL_AuthorName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_AuthorName", sys_OpLog.EL_AuthorName);
         }
          }
         if(sys_OpLog.EL_ClientIP_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_OpLog.EL_ClientIP))
         {
            idb.AddParameter("@EL_ClientIP", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_ClientIP", sys_OpLog.EL_ClientIP);
         }
          }
         if(sys_OpLog.EL_RequireURL_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_OpLog.EL_RequireURL))
         {
            idb.AddParameter("@EL_RequireURL", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_RequireURL", sys_OpLog.EL_RequireURL);
         }
          }
         if(sys_OpLog.EL_Message_IsChanged)
         {
         if (string.IsNullOrEmpty(sys_OpLog.EL_Message))
         {
            idb.AddParameter("@EL_Message", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@EL_Message", sys_OpLog.EL_Message);
         }
          }
         if(sys_OpLog.Stat_IsChanged)
         {
         if (sys_OpLog.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", sys_OpLog.Stat);
         }
          }

         idb.AddParameter("@EL_ID", sys_OpLog.EL_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 删除系统操作日志 Sys_OpLog对象(即:一条记录
      /// </summary>
      public int Delete(decimal eL_ID)
      {
         string sql = "DELETE Sys_OpLog WHERE 1=1  AND EL_ID=@EL_ID ";
         idb.AddParameter("@EL_ID", eL_ID);

         return idb.ExeCmd(sql);
      }
      /// <summary>
      /// 获取指定的系统操作日志 Sys_OpLog对象(即:一条记录
      /// </summary>
      public Sys_OpLog GetByKey(decimal eL_ID)
      {
         Sys_OpLog sys_OpLog = new Sys_OpLog();
         string sql = "SELECT  EL_ID,EL_Module,EL_ModuleName,EL_Date,EL_Author,EL_AuthorName,EL_ClientIP,EL_RequireURL,EL_Message,Stat FROM Sys_OpLog WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND EL_ID=@EL_ID ";
         idb.AddParameter("@EL_ID", eL_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["EL_ID"] != DBNull.Value) sys_OpLog.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_Module"] != DBNull.Value) sys_OpLog.EL_Module = Convert.ToString(dr["EL_Module"]);
            if (dr["EL_ModuleName"] != DBNull.Value) sys_OpLog.EL_ModuleName = Convert.ToString(dr["EL_ModuleName"]);
            if (dr["EL_Date"] != DBNull.Value) sys_OpLog.EL_Date = Convert.ToDateTime(dr["EL_Date"]);
            if (dr["EL_Author"] != DBNull.Value) sys_OpLog.EL_Author = Convert.ToString(dr["EL_Author"]);
            if (dr["EL_AuthorName"] != DBNull.Value) sys_OpLog.EL_AuthorName = Convert.ToString(dr["EL_AuthorName"]);
            if (dr["EL_ClientIP"] != DBNull.Value) sys_OpLog.EL_ClientIP = Convert.ToString(dr["EL_ClientIP"]);
            if (dr["EL_RequireURL"] != DBNull.Value) sys_OpLog.EL_RequireURL = Convert.ToString(dr["EL_RequireURL"]);
            if (dr["EL_Message"] != DBNull.Value) sys_OpLog.EL_Message = Convert.ToString(dr["EL_Message"]);
            if (dr["Stat"] != DBNull.Value) sys_OpLog.Stat = Convert.ToInt32(dr["Stat"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return sys_OpLog;
      }
      /// <summary>
      /// 获取指定的系统操作日志 Sys_OpLog对象集合
      /// </summary>
      public List<Sys_OpLog> GetListByWhere(string strCondition)
      {
         List<Sys_OpLog> ret = new List<Sys_OpLog>();
         string sql = "SELECT  EL_ID,EL_Module,EL_ModuleName,EL_Date,EL_Author,EL_AuthorName,EL_ClientIP,EL_RequireURL,EL_Message,Stat FROM Sys_OpLog WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
         if(!string.IsNullOrEmpty(strCondition))
         {
            strCondition.Replace('\'','"'); //防sql注入
            sql += strCondition ;
         }
          sql += " ORDER BY EL_ID DESC "; 
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_OpLog sys_OpLog = new Sys_OpLog();
            if (dr["EL_ID"] != DBNull.Value) sys_OpLog.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_Module"] != DBNull.Value) sys_OpLog.EL_Module = Convert.ToString(dr["EL_Module"]);
            if (dr["EL_ModuleName"] != DBNull.Value) sys_OpLog.EL_ModuleName = Convert.ToString(dr["EL_ModuleName"]);
            if (dr["EL_Date"] != DBNull.Value) sys_OpLog.EL_Date = Convert.ToDateTime(dr["EL_Date"]);
            if (dr["EL_Author"] != DBNull.Value) sys_OpLog.EL_Author = Convert.ToString(dr["EL_Author"]);
            if (dr["EL_AuthorName"] != DBNull.Value) sys_OpLog.EL_AuthorName = Convert.ToString(dr["EL_AuthorName"]);
            if (dr["EL_ClientIP"] != DBNull.Value) sys_OpLog.EL_ClientIP = Convert.ToString(dr["EL_ClientIP"]);
            if (dr["EL_RequireURL"] != DBNull.Value) sys_OpLog.EL_RequireURL = Convert.ToString(dr["EL_RequireURL"]);
            if (dr["EL_Message"] != DBNull.Value) sys_OpLog.EL_Message = Convert.ToString(dr["EL_Message"]);
            if (dr["Stat"] != DBNull.Value) sys_OpLog.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_OpLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的系统操作日志 Sys_OpLog对象(即:一条记录
      /// </summary>
      public List<Sys_OpLog> GetAll()
      {
         List<Sys_OpLog> ret = new List<Sys_OpLog>();
         string sql = "SELECT  EL_ID,EL_Module,EL_ModuleName,EL_Date,EL_Author,EL_AuthorName,EL_ClientIP,EL_RequireURL,EL_Message,Stat FROM Sys_OpLog where 1=1 AND ((Stat is null) or (Stat=0) ) order by EL_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Sys_OpLog sys_OpLog = new Sys_OpLog();
            if (dr["EL_ID"] != DBNull.Value) sys_OpLog.EL_ID = Convert.ToDecimal(dr["EL_ID"]);
            if (dr["EL_Module"] != DBNull.Value) sys_OpLog.EL_Module = Convert.ToString(dr["EL_Module"]);
            if (dr["EL_ModuleName"] != DBNull.Value) sys_OpLog.EL_ModuleName = Convert.ToString(dr["EL_ModuleName"]);
            if (dr["EL_Date"] != DBNull.Value) sys_OpLog.EL_Date = Convert.ToDateTime(dr["EL_Date"]);
            if (dr["EL_Author"] != DBNull.Value) sys_OpLog.EL_Author = Convert.ToString(dr["EL_Author"]);
            if (dr["EL_AuthorName"] != DBNull.Value) sys_OpLog.EL_AuthorName = Convert.ToString(dr["EL_AuthorName"]);
            if (dr["EL_ClientIP"] != DBNull.Value) sys_OpLog.EL_ClientIP = Convert.ToString(dr["EL_ClientIP"]);
            if (dr["EL_RequireURL"] != DBNull.Value) sys_OpLog.EL_RequireURL = Convert.ToString(dr["EL_RequireURL"]);
            if (dr["EL_Message"] != DBNull.Value) sys_OpLog.EL_Message = Convert.ToString(dr["EL_Message"]);
            if (dr["Stat"] != DBNull.Value) sys_OpLog.Stat = Convert.ToInt32(dr["Stat"]);
            ret.Add(sys_OpLog);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
