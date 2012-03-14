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
   /// 会议通知
   /// </summary>
   [Serializable]
   public partial class ADOMeeting_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加会议通知 Meeting_Record对象(即:一条记录)
      /// </summary>
      public int Add(Meeting_Record meeting_Record)
      {
         string sql = "INSERT INTO Meeting_Record (HRetal_Code,HRetal_Date,HRetal_Locale,HRetal_Title,HRetal_Intro,HRetal_Handler,HRetal_Content,HRetal_Type,HRental_Dept,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HRetal_Code,@HRetal_Date,@HRetal_Locale,@HRetal_Title,@HRetal_Intro,@HRetal_Handler,@HRetal_Content,@HRetal_Type,@HRental_Dept,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Code))
         {
            idb.AddParameter("@HRetal_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Code", meeting_Record.HRetal_Code);
         }
         if (meeting_Record.HRetal_Date == DateTime.MinValue)
         {
            idb.AddParameter("@HRetal_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Date", meeting_Record.HRetal_Date);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Locale))
         {
            idb.AddParameter("@HRetal_Locale", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Locale", meeting_Record.HRetal_Locale);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Title))
         {
            idb.AddParameter("@HRetal_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Title", meeting_Record.HRetal_Title);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Intro))
         {
            idb.AddParameter("@HRetal_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Intro", meeting_Record.HRetal_Intro);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Handler))
         {
            idb.AddParameter("@HRetal_Handler", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Handler", meeting_Record.HRetal_Handler);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Content))
         {
            idb.AddParameter("@HRetal_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Content", meeting_Record.HRetal_Content);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Type))
         {
            idb.AddParameter("@HRetal_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Type", meeting_Record.HRetal_Type);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRental_Dept))
         {
            idb.AddParameter("@HRental_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Dept", meeting_Record.HRental_Dept);
         }
         if (meeting_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", meeting_Record.Stat);
         }
         if (meeting_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", meeting_Record.CreateDate);
         }
         if (meeting_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", meeting_Record.UpdateDate);
         }
         if (meeting_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", meeting_Record.DeleteDate);
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
      /// 添加会议通知 Meeting_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Meeting_Record meeting_Record)
      {
         string sql = "INSERT INTO Meeting_Record (HRetal_Code,HRetal_Date,HRetal_Locale,HRetal_Title,HRetal_Intro,HRetal_Handler,HRetal_Content,HRetal_Type,HRental_Dept,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@HRetal_Code,@HRetal_Date,@HRetal_Locale,@HRetal_Title,@HRetal_Intro,@HRetal_Handler,@HRetal_Content,@HRetal_Type,@HRental_Dept,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Code))
         {
            idb.AddParameter("@HRetal_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Code", meeting_Record.HRetal_Code);
         }
         if (meeting_Record.HRetal_Date == DateTime.MinValue)
         {
            idb.AddParameter("@HRetal_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Date", meeting_Record.HRetal_Date);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Locale))
         {
            idb.AddParameter("@HRetal_Locale", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Locale", meeting_Record.HRetal_Locale);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Title))
         {
            idb.AddParameter("@HRetal_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Title", meeting_Record.HRetal_Title);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Intro))
         {
            idb.AddParameter("@HRetal_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Intro", meeting_Record.HRetal_Intro);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Handler))
         {
            idb.AddParameter("@HRetal_Handler", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Handler", meeting_Record.HRetal_Handler);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Content))
         {
            idb.AddParameter("@HRetal_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Content", meeting_Record.HRetal_Content);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Type))
         {
            idb.AddParameter("@HRetal_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Type", meeting_Record.HRetal_Type);
         }
         if (string.IsNullOrEmpty(meeting_Record.HRental_Dept))
         {
            idb.AddParameter("@HRental_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Dept", meeting_Record.HRental_Dept);
         }
         if (meeting_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", meeting_Record.Stat);
         }
         if (meeting_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", meeting_Record.CreateDate);
         }
         if (meeting_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", meeting_Record.UpdateDate);
         }
         if (meeting_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", meeting_Record.DeleteDate);
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
      /// 更新会议通知 Meeting_Record对象(即:一条记录
      /// </summary>
      public int Update(Meeting_Record meeting_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Meeting_Record       SET ");
            if(meeting_Record.HRetal_Code_IsChanged){sbParameter.Append("HRetal_Code=@HRetal_Code, ");}
      if(meeting_Record.HRetal_Date_IsChanged){sbParameter.Append("HRetal_Date=@HRetal_Date, ");}
      if(meeting_Record.HRetal_Locale_IsChanged){sbParameter.Append("HRetal_Locale=@HRetal_Locale, ");}
      if(meeting_Record.HRetal_Title_IsChanged){sbParameter.Append("HRetal_Title=@HRetal_Title, ");}
      if(meeting_Record.HRetal_Intro_IsChanged){sbParameter.Append("HRetal_Intro=@HRetal_Intro, ");}
      if(meeting_Record.HRetal_Handler_IsChanged){sbParameter.Append("HRetal_Handler=@HRetal_Handler, ");}
      if(meeting_Record.HRetal_Content_IsChanged){sbParameter.Append("HRetal_Content=@HRetal_Content, ");}
      if(meeting_Record.HRetal_Type_IsChanged){sbParameter.Append("HRetal_Type=@HRetal_Type, ");}
      if(meeting_Record.HRental_Dept_IsChanged){sbParameter.Append("HRental_Dept=@HRental_Dept, ");}
      if(meeting_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(meeting_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(meeting_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(meeting_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and HRetal_ID=@HRetal_ID; " );
      string sql=sb.ToString();
         if(meeting_Record.HRetal_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Code))
         {
            idb.AddParameter("@HRetal_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Code", meeting_Record.HRetal_Code);
         }
          }
         if(meeting_Record.HRetal_Date_IsChanged)
         {
         if (meeting_Record.HRetal_Date == DateTime.MinValue)
         {
            idb.AddParameter("@HRetal_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Date", meeting_Record.HRetal_Date);
         }
          }
         if(meeting_Record.HRetal_Locale_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Locale))
         {
            idb.AddParameter("@HRetal_Locale", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Locale", meeting_Record.HRetal_Locale);
         }
          }
         if(meeting_Record.HRetal_Title_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Title))
         {
            idb.AddParameter("@HRetal_Title", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Title", meeting_Record.HRetal_Title);
         }
          }
         if(meeting_Record.HRetal_Intro_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Intro))
         {
            idb.AddParameter("@HRetal_Intro", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Intro", meeting_Record.HRetal_Intro);
         }
          }
         if(meeting_Record.HRetal_Handler_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Handler))
         {
            idb.AddParameter("@HRetal_Handler", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Handler", meeting_Record.HRetal_Handler);
         }
          }
         if(meeting_Record.HRetal_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Content))
         {
            idb.AddParameter("@HRetal_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Content", meeting_Record.HRetal_Content);
         }
          }
         if(meeting_Record.HRetal_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Record.HRetal_Type))
         {
            idb.AddParameter("@HRetal_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRetal_Type", meeting_Record.HRetal_Type);
         }
          }
         if(meeting_Record.HRental_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(meeting_Record.HRental_Dept))
         {
            idb.AddParameter("@HRental_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@HRental_Dept", meeting_Record.HRental_Dept);
         }
          }
         if(meeting_Record.Stat_IsChanged)
         {
         if (meeting_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", meeting_Record.Stat);
         }
          }
         if(meeting_Record.CreateDate_IsChanged)
         {
         if (meeting_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", meeting_Record.CreateDate);
         }
          }
         if(meeting_Record.UpdateDate_IsChanged)
         {
         if (meeting_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", meeting_Record.UpdateDate);
         }
          }
         if(meeting_Record.DeleteDate_IsChanged)
         {
         if (meeting_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", meeting_Record.DeleteDate);
         }
          }

         idb.AddParameter("@HRetal_ID", meeting_Record.HRetal_ID);

           
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
      /// 删除会议通知 Meeting_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal hRetal_ID)
      {
         string sql = "DELETE Meeting_Record WHERE 1=1  AND HRetal_ID=@HRetal_ID ";
         idb.AddParameter("@HRetal_ID", hRetal_ID);

           
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
      /// 获取指定的会议通知 Meeting_Record对象(即:一条记录
      /// </summary>
      public Meeting_Record GetByKey(decimal hRetal_ID)
      {
         Meeting_Record meeting_Record = new Meeting_Record();
         string sql = "SELECT  HRetal_ID,HRetal_Code,HRetal_Date,HRetal_Locale,HRetal_Title,HRetal_Intro,HRetal_Handler,HRetal_Content,HRetal_Type,HRental_Dept,Stat,CreateDate,UpdateDate,DeleteDate FROM Meeting_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND HRetal_ID=@HRetal_ID ";
         idb.AddParameter("@HRetal_ID", hRetal_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["HRetal_ID"] != DBNull.Value) meeting_Record.HRetal_ID = Convert.ToDecimal(dr["HRetal_ID"]);
            if (dr["HRetal_Code"] != DBNull.Value) meeting_Record.HRetal_Code = Convert.ToString(dr["HRetal_Code"]);
            if (dr["HRetal_Date"] != DBNull.Value) meeting_Record.HRetal_Date = Convert.ToDateTime(dr["HRetal_Date"]);
            if (dr["HRetal_Locale"] != DBNull.Value) meeting_Record.HRetal_Locale = Convert.ToString(dr["HRetal_Locale"]);
            if (dr["HRetal_Title"] != DBNull.Value) meeting_Record.HRetal_Title = Convert.ToString(dr["HRetal_Title"]);
            if (dr["HRetal_Intro"] != DBNull.Value) meeting_Record.HRetal_Intro = Convert.ToString(dr["HRetal_Intro"]);
            if (dr["HRetal_Handler"] != DBNull.Value) meeting_Record.HRetal_Handler = Convert.ToString(dr["HRetal_Handler"]);
            if (dr["HRetal_Content"] != DBNull.Value) meeting_Record.HRetal_Content = Convert.ToString(dr["HRetal_Content"]);
            if (dr["HRetal_Type"] != DBNull.Value) meeting_Record.HRetal_Type = Convert.ToString(dr["HRetal_Type"]);
            if (dr["HRental_Dept"] != DBNull.Value) meeting_Record.HRental_Dept = Convert.ToString(dr["HRental_Dept"]);
            if (dr["Stat"] != DBNull.Value) meeting_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) meeting_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) meeting_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) meeting_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return meeting_Record;
      }
      /// <summary>
      /// 获取指定的会议通知 Meeting_Record对象集合
      /// </summary>
      public List<Meeting_Record> GetListByWhere(string strCondition)
      {
         List<Meeting_Record> ret = new List<Meeting_Record>();
         string sql = "SELECT  HRetal_ID,HRetal_Code,HRetal_Date,HRetal_Locale,HRetal_Title,HRetal_Intro,HRetal_Handler,HRetal_Content,HRetal_Type,HRental_Dept,Stat,CreateDate,UpdateDate,DeleteDate FROM Meeting_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Meeting_Record meeting_Record = new Meeting_Record();
            if (dr["HRetal_ID"] != DBNull.Value) meeting_Record.HRetal_ID = Convert.ToDecimal(dr["HRetal_ID"]);
            if (dr["HRetal_Code"] != DBNull.Value) meeting_Record.HRetal_Code = Convert.ToString(dr["HRetal_Code"]);
            if (dr["HRetal_Date"] != DBNull.Value) meeting_Record.HRetal_Date = Convert.ToDateTime(dr["HRetal_Date"]);
            if (dr["HRetal_Locale"] != DBNull.Value) meeting_Record.HRetal_Locale = Convert.ToString(dr["HRetal_Locale"]);
            if (dr["HRetal_Title"] != DBNull.Value) meeting_Record.HRetal_Title = Convert.ToString(dr["HRetal_Title"]);
            if (dr["HRetal_Intro"] != DBNull.Value) meeting_Record.HRetal_Intro = Convert.ToString(dr["HRetal_Intro"]);
            if (dr["HRetal_Handler"] != DBNull.Value) meeting_Record.HRetal_Handler = Convert.ToString(dr["HRetal_Handler"]);
            if (dr["HRetal_Content"] != DBNull.Value) meeting_Record.HRetal_Content = Convert.ToString(dr["HRetal_Content"]);
            if (dr["HRetal_Type"] != DBNull.Value) meeting_Record.HRetal_Type = Convert.ToString(dr["HRetal_Type"]);
            if (dr["HRental_Dept"] != DBNull.Value) meeting_Record.HRental_Dept = Convert.ToString(dr["HRental_Dept"]);
            if (dr["Stat"] != DBNull.Value) meeting_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) meeting_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) meeting_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) meeting_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(meeting_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的会议通知 Meeting_Record对象(即:一条记录
      /// </summary>
      public List<Meeting_Record> GetAll()
      {
         List<Meeting_Record> ret = new List<Meeting_Record>();
         string sql = "SELECT  HRetal_ID,HRetal_Code,HRetal_Date,HRetal_Locale,HRetal_Title,HRetal_Intro,HRetal_Handler,HRetal_Content,HRetal_Type,HRental_Dept,Stat,CreateDate,UpdateDate,DeleteDate FROM Meeting_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by HRetal_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Meeting_Record meeting_Record = new Meeting_Record();
            if (dr["HRetal_ID"] != DBNull.Value) meeting_Record.HRetal_ID = Convert.ToDecimal(dr["HRetal_ID"]);
            if (dr["HRetal_Code"] != DBNull.Value) meeting_Record.HRetal_Code = Convert.ToString(dr["HRetal_Code"]);
            if (dr["HRetal_Date"] != DBNull.Value) meeting_Record.HRetal_Date = Convert.ToDateTime(dr["HRetal_Date"]);
            if (dr["HRetal_Locale"] != DBNull.Value) meeting_Record.HRetal_Locale = Convert.ToString(dr["HRetal_Locale"]);
            if (dr["HRetal_Title"] != DBNull.Value) meeting_Record.HRetal_Title = Convert.ToString(dr["HRetal_Title"]);
            if (dr["HRetal_Intro"] != DBNull.Value) meeting_Record.HRetal_Intro = Convert.ToString(dr["HRetal_Intro"]);
            if (dr["HRetal_Handler"] != DBNull.Value) meeting_Record.HRetal_Handler = Convert.ToString(dr["HRetal_Handler"]);
            if (dr["HRetal_Content"] != DBNull.Value) meeting_Record.HRetal_Content = Convert.ToString(dr["HRetal_Content"]);
            if (dr["HRetal_Type"] != DBNull.Value) meeting_Record.HRetal_Type = Convert.ToString(dr["HRetal_Type"]);
            if (dr["HRental_Dept"] != DBNull.Value) meeting_Record.HRental_Dept = Convert.ToString(dr["HRental_Dept"]);
            if (dr["Stat"] != DBNull.Value) meeting_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) meeting_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) meeting_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) meeting_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(meeting_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
