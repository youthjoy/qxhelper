using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using QX.Model;
using QX.DataAcess;

namespace QX.DAL
{
   [Serializable]
   public partial class ADOMeeting_Come
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加Meeting_Come对象(即:一条记录)
      /// </summary>
      public int Add(Meeting_Come meeting_Come)
      {
         string sql = "INSERT INTO Meeting_Come (MeetingCome_Code,MeetingCome_MeetCode,MeetingCome_User,MeetingCome_Remark,MeetingCome_Date,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@MeetingCome_Code,@MeetingCome_MeetCode,@MeetingCome_User,@MeetingCome_Remark,@MeetingCome_Date,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_Code))
         {
            idb.AddParameter("@MeetingCome_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_Code", meeting_Come.MeetingCome_Code);
         }
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_MeetCode))
         {
            idb.AddParameter("@MeetingCome_MeetCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_MeetCode", meeting_Come.MeetingCome_MeetCode);
         }
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_User))
         {
            idb.AddParameter("@MeetingCome_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_User", meeting_Come.MeetingCome_User);
         }
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_Remark))
         {
            idb.AddParameter("@MeetingCome_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_Remark", meeting_Come.MeetingCome_Remark);
         }
         if (meeting_Come.MeetingCome_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MeetingCome_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_Date", meeting_Come.MeetingCome_Date);
         }
         if (meeting_Come.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", meeting_Come.Stat);
         }
         if (meeting_Come.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", meeting_Come.CreateDate);
         }
         if (meeting_Come.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", meeting_Come.UpdateDate);
         }
         if (meeting_Come.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", meeting_Come.DeleteDate);
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
      /// 添加Meeting_Come对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Meeting_Come meeting_Come)
      {
         string sql = "INSERT INTO Meeting_Come (MeetingCome_Code,MeetingCome_MeetCode,MeetingCome_User,MeetingCome_Remark,MeetingCome_Date,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@MeetingCome_Code,@MeetingCome_MeetCode,@MeetingCome_User,@MeetingCome_Remark,@MeetingCome_Date,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_Code))
         {
            idb.AddParameter("@MeetingCome_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_Code", meeting_Come.MeetingCome_Code);
         }
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_MeetCode))
         {
            idb.AddParameter("@MeetingCome_MeetCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_MeetCode", meeting_Come.MeetingCome_MeetCode);
         }
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_User))
         {
            idb.AddParameter("@MeetingCome_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_User", meeting_Come.MeetingCome_User);
         }
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_Remark))
         {
            idb.AddParameter("@MeetingCome_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_Remark", meeting_Come.MeetingCome_Remark);
         }
         if (meeting_Come.MeetingCome_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MeetingCome_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_Date", meeting_Come.MeetingCome_Date);
         }
         if (meeting_Come.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", meeting_Come.Stat);
         }
         if (meeting_Come.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", meeting_Come.CreateDate);
         }
         if (meeting_Come.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", meeting_Come.UpdateDate);
         }
         if (meeting_Come.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", meeting_Come.DeleteDate);
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
      /// 更新Meeting_Come对象(即:一条记录
      /// </summary>
      public int Update(Meeting_Come meeting_Come)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Meeting_Come       SET ");
            if(meeting_Come.MeetingCome_Code_IsChanged){sbParameter.Append("MeetingCome_Code=@MeetingCome_Code, ");}
      if(meeting_Come.MeetingCome_MeetCode_IsChanged){sbParameter.Append("MeetingCome_MeetCode=@MeetingCome_MeetCode, ");}
      if(meeting_Come.MeetingCome_User_IsChanged){sbParameter.Append("MeetingCome_User=@MeetingCome_User, ");}
      if(meeting_Come.MeetingCome_Remark_IsChanged){sbParameter.Append("MeetingCome_Remark=@MeetingCome_Remark, ");}
      if(meeting_Come.MeetingCome_Date_IsChanged){sbParameter.Append("MeetingCome_Date=@MeetingCome_Date, ");}
      if(meeting_Come.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(meeting_Come.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(meeting_Come.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(meeting_Come.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MeetingCome_ID=@MeetingCome_ID; " );
      string sql=sb.ToString();
         if(meeting_Come.MeetingCome_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_Code))
         {
            idb.AddParameter("@MeetingCome_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_Code", meeting_Come.MeetingCome_Code);
         }
          }
         if(meeting_Come.MeetingCome_MeetCode_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_MeetCode))
         {
            idb.AddParameter("@MeetingCome_MeetCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_MeetCode", meeting_Come.MeetingCome_MeetCode);
         }
          }
         if(meeting_Come.MeetingCome_User_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_User))
         {
            idb.AddParameter("@MeetingCome_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_User", meeting_Come.MeetingCome_User);
         }
          }
         if(meeting_Come.MeetingCome_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Come.MeetingCome_Remark))
         {
            idb.AddParameter("@MeetingCome_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_Remark", meeting_Come.MeetingCome_Remark);
         }
          }
         if(meeting_Come.MeetingCome_Date_IsChanged)
         {
         if (meeting_Come.MeetingCome_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MeetingCome_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MeetingCome_Date", meeting_Come.MeetingCome_Date);
         }
          }
         if(meeting_Come.Stat_IsChanged)
         {
         if (meeting_Come.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", meeting_Come.Stat);
         }
          }
         if(meeting_Come.CreateDate_IsChanged)
         {
         if (meeting_Come.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", meeting_Come.CreateDate);
         }
          }
         if(meeting_Come.UpdateDate_IsChanged)
         {
         if (meeting_Come.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", meeting_Come.UpdateDate);
         }
          }
         if(meeting_Come.DeleteDate_IsChanged)
         {
         if (meeting_Come.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", meeting_Come.DeleteDate);
         }
          }

         idb.AddParameter("@MeetingCome_ID", meeting_Come.MeetingCome_ID);

           
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
      /// 删除Meeting_Come对象(即:一条记录
      /// </summary>
      public int Delete(decimal meetingCome_ID)
      {
         string sql = "DELETE Meeting_Come WHERE 1=1  AND MeetingCome_ID=@MeetingCome_ID ";
         idb.AddParameter("@MeetingCome_ID", meetingCome_ID);

           
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
      /// 获取指定的Meeting_Come对象(即:一条记录
      /// </summary>
      public Meeting_Come GetByKey(decimal meetingCome_ID)
      {
         Meeting_Come meeting_Come = new Meeting_Come();
         string sql = "SELECT  MeetingCome_ID,MeetingCome_Code,MeetingCome_MeetCode,MeetingCome_User,MeetingCome_Remark,MeetingCome_Date,Stat,CreateDate,UpdateDate,DeleteDate FROM Meeting_Come WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MeetingCome_ID=@MeetingCome_ID ";
         idb.AddParameter("@MeetingCome_ID", meetingCome_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MeetingCome_ID"] != DBNull.Value) meeting_Come.MeetingCome_ID = Convert.ToDecimal(dr["MeetingCome_ID"]);
            if (dr["MeetingCome_Code"] != DBNull.Value) meeting_Come.MeetingCome_Code = Convert.ToString(dr["MeetingCome_Code"]);
            if (dr["MeetingCome_MeetCode"] != DBNull.Value) meeting_Come.MeetingCome_MeetCode = Convert.ToString(dr["MeetingCome_MeetCode"]);
            if (dr["MeetingCome_User"] != DBNull.Value) meeting_Come.MeetingCome_User = Convert.ToString(dr["MeetingCome_User"]);
            if (dr["MeetingCome_Remark"] != DBNull.Value) meeting_Come.MeetingCome_Remark = Convert.ToString(dr["MeetingCome_Remark"]);
            if (dr["MeetingCome_Date"] != DBNull.Value) meeting_Come.MeetingCome_Date = Convert.ToDateTime(dr["MeetingCome_Date"]);
            if (dr["Stat"] != DBNull.Value) meeting_Come.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) meeting_Come.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) meeting_Come.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) meeting_Come.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return meeting_Come;
      }
      /// <summary>
      /// 获取指定的Meeting_Come对象集合
      /// </summary>
      public List<Meeting_Come> GetListByWhere(string strCondition)
      {
         List<Meeting_Come> ret = new List<Meeting_Come>();
         string sql = "SELECT  MeetingCome_ID,MeetingCome_Code,MeetingCome_MeetCode,MeetingCome_User,MeetingCome_Remark,MeetingCome_Date,Stat,CreateDate,UpdateDate,DeleteDate FROM Meeting_Come WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Meeting_Come meeting_Come = new Meeting_Come();
            if (dr["MeetingCome_ID"] != DBNull.Value) meeting_Come.MeetingCome_ID = Convert.ToDecimal(dr["MeetingCome_ID"]);
            if (dr["MeetingCome_Code"] != DBNull.Value) meeting_Come.MeetingCome_Code = Convert.ToString(dr["MeetingCome_Code"]);
            if (dr["MeetingCome_MeetCode"] != DBNull.Value) meeting_Come.MeetingCome_MeetCode = Convert.ToString(dr["MeetingCome_MeetCode"]);
            if (dr["MeetingCome_User"] != DBNull.Value) meeting_Come.MeetingCome_User = Convert.ToString(dr["MeetingCome_User"]);
            if (dr["MeetingCome_Remark"] != DBNull.Value) meeting_Come.MeetingCome_Remark = Convert.ToString(dr["MeetingCome_Remark"]);
            if (dr["MeetingCome_Date"] != DBNull.Value) meeting_Come.MeetingCome_Date = Convert.ToDateTime(dr["MeetingCome_Date"]);
            if (dr["Stat"] != DBNull.Value) meeting_Come.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) meeting_Come.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) meeting_Come.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) meeting_Come.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(meeting_Come);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的Meeting_Come对象(即:一条记录
      /// </summary>
      public List<Meeting_Come> GetAll()
      {
         List<Meeting_Come> ret = new List<Meeting_Come>();
         string sql = "SELECT  MeetingCome_ID,MeetingCome_Code,MeetingCome_MeetCode,MeetingCome_User,MeetingCome_Remark,MeetingCome_Date,Stat,CreateDate,UpdateDate,DeleteDate FROM Meeting_Come where 1=1 AND ((Stat is null) or (Stat=0) ) order by MeetingCome_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Meeting_Come meeting_Come = new Meeting_Come();
            if (dr["MeetingCome_ID"] != DBNull.Value) meeting_Come.MeetingCome_ID = Convert.ToDecimal(dr["MeetingCome_ID"]);
            if (dr["MeetingCome_Code"] != DBNull.Value) meeting_Come.MeetingCome_Code = Convert.ToString(dr["MeetingCome_Code"]);
            if (dr["MeetingCome_MeetCode"] != DBNull.Value) meeting_Come.MeetingCome_MeetCode = Convert.ToString(dr["MeetingCome_MeetCode"]);
            if (dr["MeetingCome_User"] != DBNull.Value) meeting_Come.MeetingCome_User = Convert.ToString(dr["MeetingCome_User"]);
            if (dr["MeetingCome_Remark"] != DBNull.Value) meeting_Come.MeetingCome_Remark = Convert.ToString(dr["MeetingCome_Remark"]);
            if (dr["MeetingCome_Date"] != DBNull.Value) meeting_Come.MeetingCome_Date = Convert.ToDateTime(dr["MeetingCome_Date"]);
            if (dr["Stat"] != DBNull.Value) meeting_Come.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) meeting_Come.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) meeting_Come.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) meeting_Come.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(meeting_Come);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
