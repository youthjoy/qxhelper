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
   /// 搅拌站信息
   /// </summary>
   [Serializable]
   public partial class ADOPC_BStation
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加搅拌站信息 PC_BStation对象(即:一条记录)
      /// </summary>
      public int Add(PC_BStation pC_BStation)
      {
         string sql = "INSERT INTO PC_BStation (PCBS_Code,PCBS_Name,PCBS_Addr,PCBS_Start,PCBS_Status,PCBS_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCBS_Code,@PCBS_Name,@PCBS_Addr,@PCBS_Start,@PCBS_Status,@PCBS_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Code))
         {
            idb.AddParameter("@PCBS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Code", pC_BStation.PCBS_Code);
         }
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Name))
         {
            idb.AddParameter("@PCBS_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Name", pC_BStation.PCBS_Name);
         }
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Addr))
         {
            idb.AddParameter("@PCBS_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Addr", pC_BStation.PCBS_Addr);
         }
         if (pC_BStation.PCBS_Start == DateTime.MinValue)
         {
            idb.AddParameter("@PCBS_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Start", pC_BStation.PCBS_Start);
         }
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Status))
         {
            idb.AddParameter("@PCBS_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Status", pC_BStation.PCBS_Status);
         }
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Bak))
         {
            idb.AddParameter("@PCBS_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Bak", pC_BStation.PCBS_Bak);
         }
         if (pC_BStation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_BStation.Stat);
         }
         if (pC_BStation.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_BStation.CreateDate);
         }
         if (pC_BStation.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_BStation.UpdateDate);
         }
         if (pC_BStation.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_BStation.DeleteDate);
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
      /// 添加搅拌站信息 PC_BStation对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_BStation pC_BStation)
      {
         string sql = "INSERT INTO PC_BStation (PCBS_Code,PCBS_Name,PCBS_Addr,PCBS_Start,PCBS_Status,PCBS_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCBS_Code,@PCBS_Name,@PCBS_Addr,@PCBS_Start,@PCBS_Status,@PCBS_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Code))
         {
            idb.AddParameter("@PCBS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Code", pC_BStation.PCBS_Code);
         }
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Name))
         {
            idb.AddParameter("@PCBS_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Name", pC_BStation.PCBS_Name);
         }
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Addr))
         {
            idb.AddParameter("@PCBS_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Addr", pC_BStation.PCBS_Addr);
         }
         if (pC_BStation.PCBS_Start == DateTime.MinValue)
         {
            idb.AddParameter("@PCBS_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Start", pC_BStation.PCBS_Start);
         }
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Status))
         {
            idb.AddParameter("@PCBS_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Status", pC_BStation.PCBS_Status);
         }
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Bak))
         {
            idb.AddParameter("@PCBS_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Bak", pC_BStation.PCBS_Bak);
         }
         if (pC_BStation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_BStation.Stat);
         }
         if (pC_BStation.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_BStation.CreateDate);
         }
         if (pC_BStation.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_BStation.UpdateDate);
         }
         if (pC_BStation.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_BStation.DeleteDate);
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
      /// 更新搅拌站信息 PC_BStation对象(即:一条记录
      /// </summary>
      public int Update(PC_BStation pC_BStation)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_BStation       SET ");
            if(pC_BStation.PCBS_Code_IsChanged){sbParameter.Append("PCBS_Code=@PCBS_Code, ");}
      if(pC_BStation.PCBS_Name_IsChanged){sbParameter.Append("PCBS_Name=@PCBS_Name, ");}
      if(pC_BStation.PCBS_Addr_IsChanged){sbParameter.Append("PCBS_Addr=@PCBS_Addr, ");}
      if(pC_BStation.PCBS_Start_IsChanged){sbParameter.Append("PCBS_Start=@PCBS_Start, ");}
      if(pC_BStation.PCBS_Status_IsChanged){sbParameter.Append("PCBS_Status=@PCBS_Status, ");}
      if(pC_BStation.PCBS_Bak_IsChanged){sbParameter.Append("PCBS_Bak=@PCBS_Bak, ");}
      if(pC_BStation.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_BStation.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_BStation.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_BStation.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCBS_ID=@PCBS_ID; " );
      string sql=sb.ToString();
         if(pC_BStation.PCBS_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Code))
         {
            idb.AddParameter("@PCBS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Code", pC_BStation.PCBS_Code);
         }
          }
         if(pC_BStation.PCBS_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Name))
         {
            idb.AddParameter("@PCBS_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Name", pC_BStation.PCBS_Name);
         }
          }
         if(pC_BStation.PCBS_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Addr))
         {
            idb.AddParameter("@PCBS_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Addr", pC_BStation.PCBS_Addr);
         }
          }
         if(pC_BStation.PCBS_Start_IsChanged)
         {
         if (pC_BStation.PCBS_Start == DateTime.MinValue)
         {
            idb.AddParameter("@PCBS_Start", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Start", pC_BStation.PCBS_Start);
         }
          }
         if(pC_BStation.PCBS_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Status))
         {
            idb.AddParameter("@PCBS_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Status", pC_BStation.PCBS_Status);
         }
          }
         if(pC_BStation.PCBS_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BStation.PCBS_Bak))
         {
            idb.AddParameter("@PCBS_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBS_Bak", pC_BStation.PCBS_Bak);
         }
          }
         if(pC_BStation.Stat_IsChanged)
         {
         if (pC_BStation.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_BStation.Stat);
         }
          }
         if(pC_BStation.CreateDate_IsChanged)
         {
         if (pC_BStation.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_BStation.CreateDate);
         }
          }
         if(pC_BStation.UpdateDate_IsChanged)
         {
         if (pC_BStation.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_BStation.UpdateDate);
         }
          }
         if(pC_BStation.DeleteDate_IsChanged)
         {
         if (pC_BStation.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_BStation.DeleteDate);
         }
          }

         idb.AddParameter("@PCBS_ID", pC_BStation.PCBS_ID);

           
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
      /// 删除搅拌站信息 PC_BStation对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCBS_ID)
      {
         string sql = "DELETE PC_BStation WHERE 1=1  AND PCBS_ID=@PCBS_ID ";
         idb.AddParameter("@PCBS_ID", pCBS_ID);

           
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
      /// 获取指定的搅拌站信息 PC_BStation对象(即:一条记录
      /// </summary>
      public PC_BStation GetByKey(decimal pCBS_ID)
      {
         PC_BStation pC_BStation = new PC_BStation();
         string sql = "SELECT  PCBS_ID,PCBS_Code,PCBS_Name,PCBS_Addr,PCBS_Start,PCBS_Status,PCBS_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_BStation WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCBS_ID=@PCBS_ID ";
         idb.AddParameter("@PCBS_ID", pCBS_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCBS_ID"] != DBNull.Value) pC_BStation.PCBS_ID = Convert.ToDecimal(dr["PCBS_ID"]);
            if (dr["PCBS_Code"] != DBNull.Value) pC_BStation.PCBS_Code = Convert.ToString(dr["PCBS_Code"]);
            if (dr["PCBS_Name"] != DBNull.Value) pC_BStation.PCBS_Name = Convert.ToString(dr["PCBS_Name"]);
            if (dr["PCBS_Addr"] != DBNull.Value) pC_BStation.PCBS_Addr = Convert.ToString(dr["PCBS_Addr"]);
            if (dr["PCBS_Start"] != DBNull.Value) pC_BStation.PCBS_Start = Convert.ToDateTime(dr["PCBS_Start"]);
            if (dr["PCBS_Status"] != DBNull.Value) pC_BStation.PCBS_Status = Convert.ToString(dr["PCBS_Status"]);
            if (dr["PCBS_Bak"] != DBNull.Value) pC_BStation.PCBS_Bak = Convert.ToString(dr["PCBS_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_BStation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_BStation.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_BStation.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_BStation.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_BStation;
      }
      /// <summary>
      /// 获取指定的搅拌站信息 PC_BStation对象集合
      /// </summary>
      public List<PC_BStation> GetListByWhere(string strCondition)
      {
         List<PC_BStation> ret = new List<PC_BStation>();
         string sql = "SELECT  PCBS_ID,PCBS_Code,PCBS_Name,PCBS_Addr,PCBS_Start,PCBS_Status,PCBS_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_BStation WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_BStation pC_BStation = new PC_BStation();
            if (dr["PCBS_ID"] != DBNull.Value) pC_BStation.PCBS_ID = Convert.ToDecimal(dr["PCBS_ID"]);
            if (dr["PCBS_Code"] != DBNull.Value) pC_BStation.PCBS_Code = Convert.ToString(dr["PCBS_Code"]);
            if (dr["PCBS_Name"] != DBNull.Value) pC_BStation.PCBS_Name = Convert.ToString(dr["PCBS_Name"]);
            if (dr["PCBS_Addr"] != DBNull.Value) pC_BStation.PCBS_Addr = Convert.ToString(dr["PCBS_Addr"]);
            if (dr["PCBS_Start"] != DBNull.Value) pC_BStation.PCBS_Start = Convert.ToDateTime(dr["PCBS_Start"]);
            if (dr["PCBS_Status"] != DBNull.Value) pC_BStation.PCBS_Status = Convert.ToString(dr["PCBS_Status"]);
            if (dr["PCBS_Bak"] != DBNull.Value) pC_BStation.PCBS_Bak = Convert.ToString(dr["PCBS_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_BStation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_BStation.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_BStation.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_BStation.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_BStation);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的搅拌站信息 PC_BStation对象(即:一条记录
      /// </summary>
      public List<PC_BStation> GetAll()
      {
         List<PC_BStation> ret = new List<PC_BStation>();
         string sql = "SELECT  PCBS_ID,PCBS_Code,PCBS_Name,PCBS_Addr,PCBS_Start,PCBS_Status,PCBS_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_BStation where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCBS_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_BStation pC_BStation = new PC_BStation();
            if (dr["PCBS_ID"] != DBNull.Value) pC_BStation.PCBS_ID = Convert.ToDecimal(dr["PCBS_ID"]);
            if (dr["PCBS_Code"] != DBNull.Value) pC_BStation.PCBS_Code = Convert.ToString(dr["PCBS_Code"]);
            if (dr["PCBS_Name"] != DBNull.Value) pC_BStation.PCBS_Name = Convert.ToString(dr["PCBS_Name"]);
            if (dr["PCBS_Addr"] != DBNull.Value) pC_BStation.PCBS_Addr = Convert.ToString(dr["PCBS_Addr"]);
            if (dr["PCBS_Start"] != DBNull.Value) pC_BStation.PCBS_Start = Convert.ToDateTime(dr["PCBS_Start"]);
            if (dr["PCBS_Status"] != DBNull.Value) pC_BStation.PCBS_Status = Convert.ToString(dr["PCBS_Status"]);
            if (dr["PCBS_Bak"] != DBNull.Value) pC_BStation.PCBS_Bak = Convert.ToString(dr["PCBS_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_BStation.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_BStation.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_BStation.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_BStation.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_BStation);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
