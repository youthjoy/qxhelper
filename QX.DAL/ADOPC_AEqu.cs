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
   /// 设备安排
   /// </summary>
   [Serializable]
   public partial class ADOPC_AEqu
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加设备安排 PC_AEqu对象(即:一条记录)
      /// </summary>
      public int Add(PC_AEqu pC_AEqu)
      {
         string sql = "INSERT INTO PC_AEqu (PCAS_Code,PCAS_PCode,PCAS_Type,PCAS_ECode,PCAS_EName,PCAS_Owner,PCAS_OContact,PCAS_Num,PCAS_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCAS_Code,@PCAS_PCode,@PCAS_Type,@PCAS_ECode,@PCAS_EName,@PCAS_Owner,@PCAS_OContact,@PCAS_Num,@PCAS_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Code))
         {
            idb.AddParameter("@PCAS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Code", pC_AEqu.PCAS_Code);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_PCode))
         {
            idb.AddParameter("@PCAS_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_PCode", pC_AEqu.PCAS_PCode);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Type))
         {
            idb.AddParameter("@PCAS_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Type", pC_AEqu.PCAS_Type);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_ECode))
         {
            idb.AddParameter("@PCAS_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_ECode", pC_AEqu.PCAS_ECode);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_EName))
         {
            idb.AddParameter("@PCAS_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_EName", pC_AEqu.PCAS_EName);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Owner))
         {
            idb.AddParameter("@PCAS_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Owner", pC_AEqu.PCAS_Owner);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_OContact))
         {
            idb.AddParameter("@PCAS_OContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_OContact", pC_AEqu.PCAS_OContact);
         }
         if (pC_AEqu.PCAS_Num == 0)
         {
            idb.AddParameter("@PCAS_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCAS_Num", pC_AEqu.PCAS_Num);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Bak))
         {
            idb.AddParameter("@PCAS_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Bak", pC_AEqu.PCAS_Bak);
         }
         if (pC_AEqu.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_AEqu.Stat);
         }
         if (pC_AEqu.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_AEqu.CreateDate);
         }
         if (pC_AEqu.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_AEqu.UpdateDate);
         }
         if (pC_AEqu.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_AEqu.DeleteDate);
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
      /// 添加设备安排 PC_AEqu对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_AEqu pC_AEqu)
      {
         string sql = "INSERT INTO PC_AEqu (PCAS_Code,PCAS_PCode,PCAS_Type,PCAS_ECode,PCAS_EName,PCAS_Owner,PCAS_OContact,PCAS_Num,PCAS_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCAS_Code,@PCAS_PCode,@PCAS_Type,@PCAS_ECode,@PCAS_EName,@PCAS_Owner,@PCAS_OContact,@PCAS_Num,@PCAS_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Code))
         {
            idb.AddParameter("@PCAS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Code", pC_AEqu.PCAS_Code);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_PCode))
         {
            idb.AddParameter("@PCAS_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_PCode", pC_AEqu.PCAS_PCode);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Type))
         {
            idb.AddParameter("@PCAS_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Type", pC_AEqu.PCAS_Type);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_ECode))
         {
            idb.AddParameter("@PCAS_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_ECode", pC_AEqu.PCAS_ECode);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_EName))
         {
            idb.AddParameter("@PCAS_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_EName", pC_AEqu.PCAS_EName);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Owner))
         {
            idb.AddParameter("@PCAS_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Owner", pC_AEqu.PCAS_Owner);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_OContact))
         {
            idb.AddParameter("@PCAS_OContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_OContact", pC_AEqu.PCAS_OContact);
         }
         if (pC_AEqu.PCAS_Num == 0)
         {
            idb.AddParameter("@PCAS_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCAS_Num", pC_AEqu.PCAS_Num);
         }
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Bak))
         {
            idb.AddParameter("@PCAS_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Bak", pC_AEqu.PCAS_Bak);
         }
         if (pC_AEqu.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_AEqu.Stat);
         }
         if (pC_AEqu.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_AEqu.CreateDate);
         }
         if (pC_AEqu.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_AEqu.UpdateDate);
         }
         if (pC_AEqu.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_AEqu.DeleteDate);
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
      /// 更新设备安排 PC_AEqu对象(即:一条记录
      /// </summary>
      public int Update(PC_AEqu pC_AEqu)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_AEqu       SET ");
            if(pC_AEqu.PCAS_Code_IsChanged){sbParameter.Append("PCAS_Code=@PCAS_Code, ");}
      if(pC_AEqu.PCAS_PCode_IsChanged){sbParameter.Append("PCAS_PCode=@PCAS_PCode, ");}
      if(pC_AEqu.PCAS_Type_IsChanged){sbParameter.Append("PCAS_Type=@PCAS_Type, ");}
      if(pC_AEqu.PCAS_ECode_IsChanged){sbParameter.Append("PCAS_ECode=@PCAS_ECode, ");}
      if(pC_AEqu.PCAS_EName_IsChanged){sbParameter.Append("PCAS_EName=@PCAS_EName, ");}
      if(pC_AEqu.PCAS_Owner_IsChanged){sbParameter.Append("PCAS_Owner=@PCAS_Owner, ");}
      if(pC_AEqu.PCAS_OContact_IsChanged){sbParameter.Append("PCAS_OContact=@PCAS_OContact, ");}
      if(pC_AEqu.PCAS_Num_IsChanged){sbParameter.Append("PCAS_Num=@PCAS_Num, ");}
      if(pC_AEqu.PCAS_Bak_IsChanged){sbParameter.Append("PCAS_Bak=@PCAS_Bak, ");}
      if(pC_AEqu.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_AEqu.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_AEqu.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_AEqu.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCAS_ID=@PCAS_ID; " );
      string sql=sb.ToString();
         if(pC_AEqu.PCAS_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Code))
         {
            idb.AddParameter("@PCAS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Code", pC_AEqu.PCAS_Code);
         }
          }
         if(pC_AEqu.PCAS_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_PCode))
         {
            idb.AddParameter("@PCAS_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_PCode", pC_AEqu.PCAS_PCode);
         }
          }
         if(pC_AEqu.PCAS_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Type))
         {
            idb.AddParameter("@PCAS_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Type", pC_AEqu.PCAS_Type);
         }
          }
         if(pC_AEqu.PCAS_ECode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_ECode))
         {
            idb.AddParameter("@PCAS_ECode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_ECode", pC_AEqu.PCAS_ECode);
         }
          }
         if(pC_AEqu.PCAS_EName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_EName))
         {
            idb.AddParameter("@PCAS_EName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_EName", pC_AEqu.PCAS_EName);
         }
          }
         if(pC_AEqu.PCAS_Owner_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Owner))
         {
            idb.AddParameter("@PCAS_Owner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Owner", pC_AEqu.PCAS_Owner);
         }
          }
         if(pC_AEqu.PCAS_OContact_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_OContact))
         {
            idb.AddParameter("@PCAS_OContact", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_OContact", pC_AEqu.PCAS_OContact);
         }
          }
         if(pC_AEqu.PCAS_Num_IsChanged)
         {
         if (pC_AEqu.PCAS_Num == 0)
         {
            idb.AddParameter("@PCAS_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCAS_Num", pC_AEqu.PCAS_Num);
         }
          }
         if(pC_AEqu.PCAS_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_AEqu.PCAS_Bak))
         {
            idb.AddParameter("@PCAS_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCAS_Bak", pC_AEqu.PCAS_Bak);
         }
          }
         if(pC_AEqu.Stat_IsChanged)
         {
         if (pC_AEqu.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_AEqu.Stat);
         }
          }
         if(pC_AEqu.CreateDate_IsChanged)
         {
         if (pC_AEqu.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_AEqu.CreateDate);
         }
          }
         if(pC_AEqu.UpdateDate_IsChanged)
         {
         if (pC_AEqu.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_AEqu.UpdateDate);
         }
          }
         if(pC_AEqu.DeleteDate_IsChanged)
         {
         if (pC_AEqu.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_AEqu.DeleteDate);
         }
          }

         idb.AddParameter("@PCAS_ID", pC_AEqu.PCAS_ID);

           
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
      /// 删除设备安排 PC_AEqu对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCAS_ID)
      {
         string sql = "DELETE PC_AEqu WHERE 1=1  AND PCAS_ID=@PCAS_ID ";
         idb.AddParameter("@PCAS_ID", pCAS_ID);

           
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
      /// 获取指定的设备安排 PC_AEqu对象(即:一条记录
      /// </summary>
      public PC_AEqu GetByKey(decimal pCAS_ID)
      {
         PC_AEqu pC_AEqu = new PC_AEqu();
         string sql = "SELECT  PCAS_ID,PCAS_Code,PCAS_PCode,PCAS_Type,PCAS_ECode,PCAS_EName,PCAS_Owner,PCAS_OContact,PCAS_Num,PCAS_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_AEqu WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCAS_ID=@PCAS_ID ";
         idb.AddParameter("@PCAS_ID", pCAS_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCAS_ID"] != DBNull.Value) pC_AEqu.PCAS_ID = Convert.ToDecimal(dr["PCAS_ID"]);
            if (dr["PCAS_Code"] != DBNull.Value) pC_AEqu.PCAS_Code = Convert.ToString(dr["PCAS_Code"]);
            if (dr["PCAS_PCode"] != DBNull.Value) pC_AEqu.PCAS_PCode = Convert.ToString(dr["PCAS_PCode"]);
            if (dr["PCAS_Type"] != DBNull.Value) pC_AEqu.PCAS_Type = Convert.ToString(dr["PCAS_Type"]);
            if (dr["PCAS_ECode"] != DBNull.Value) pC_AEqu.PCAS_ECode = Convert.ToString(dr["PCAS_ECode"]);
            if (dr["PCAS_EName"] != DBNull.Value) pC_AEqu.PCAS_EName = Convert.ToString(dr["PCAS_EName"]);
            if (dr["PCAS_Owner"] != DBNull.Value) pC_AEqu.PCAS_Owner = Convert.ToString(dr["PCAS_Owner"]);
            if (dr["PCAS_OContact"] != DBNull.Value) pC_AEqu.PCAS_OContact = Convert.ToString(dr["PCAS_OContact"]);
            if (dr["PCAS_Num"] != DBNull.Value) pC_AEqu.PCAS_Num = Convert.ToDecimal(dr["PCAS_Num"]);
            if (dr["PCAS_Bak"] != DBNull.Value) pC_AEqu.PCAS_Bak = Convert.ToString(dr["PCAS_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_AEqu.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_AEqu.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_AEqu.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_AEqu.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_AEqu;
      }
      /// <summary>
      /// 获取指定的设备安排 PC_AEqu对象集合
      /// </summary>
      public List<PC_AEqu> GetListByWhere(string strCondition)
      {
         List<PC_AEqu> ret = new List<PC_AEqu>();
         string sql = "SELECT  PCAS_ID,PCAS_Code,PCAS_PCode,PCAS_Type,PCAS_ECode,PCAS_EName,PCAS_Owner,PCAS_OContact,PCAS_Num,PCAS_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_AEqu WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_AEqu pC_AEqu = new PC_AEqu();
            if (dr["PCAS_ID"] != DBNull.Value) pC_AEqu.PCAS_ID = Convert.ToDecimal(dr["PCAS_ID"]);
            if (dr["PCAS_Code"] != DBNull.Value) pC_AEqu.PCAS_Code = Convert.ToString(dr["PCAS_Code"]);
            if (dr["PCAS_PCode"] != DBNull.Value) pC_AEqu.PCAS_PCode = Convert.ToString(dr["PCAS_PCode"]);
            if (dr["PCAS_Type"] != DBNull.Value) pC_AEqu.PCAS_Type = Convert.ToString(dr["PCAS_Type"]);
            if (dr["PCAS_ECode"] != DBNull.Value) pC_AEqu.PCAS_ECode = Convert.ToString(dr["PCAS_ECode"]);
            if (dr["PCAS_EName"] != DBNull.Value) pC_AEqu.PCAS_EName = Convert.ToString(dr["PCAS_EName"]);
            if (dr["PCAS_Owner"] != DBNull.Value) pC_AEqu.PCAS_Owner = Convert.ToString(dr["PCAS_Owner"]);
            if (dr["PCAS_OContact"] != DBNull.Value) pC_AEqu.PCAS_OContact = Convert.ToString(dr["PCAS_OContact"]);
            if (dr["PCAS_Num"] != DBNull.Value) pC_AEqu.PCAS_Num = Convert.ToDecimal(dr["PCAS_Num"]);
            if (dr["PCAS_Bak"] != DBNull.Value) pC_AEqu.PCAS_Bak = Convert.ToString(dr["PCAS_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_AEqu.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_AEqu.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_AEqu.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_AEqu.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_AEqu);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的设备安排 PC_AEqu对象(即:一条记录
      /// </summary>
      public List<PC_AEqu> GetAll()
      {
         List<PC_AEqu> ret = new List<PC_AEqu>();
         string sql = "SELECT  PCAS_ID,PCAS_Code,PCAS_PCode,PCAS_Type,PCAS_ECode,PCAS_EName,PCAS_Owner,PCAS_OContact,PCAS_Num,PCAS_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_AEqu where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCAS_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_AEqu pC_AEqu = new PC_AEqu();
            if (dr["PCAS_ID"] != DBNull.Value) pC_AEqu.PCAS_ID = Convert.ToDecimal(dr["PCAS_ID"]);
            if (dr["PCAS_Code"] != DBNull.Value) pC_AEqu.PCAS_Code = Convert.ToString(dr["PCAS_Code"]);
            if (dr["PCAS_PCode"] != DBNull.Value) pC_AEqu.PCAS_PCode = Convert.ToString(dr["PCAS_PCode"]);
            if (dr["PCAS_Type"] != DBNull.Value) pC_AEqu.PCAS_Type = Convert.ToString(dr["PCAS_Type"]);
            if (dr["PCAS_ECode"] != DBNull.Value) pC_AEqu.PCAS_ECode = Convert.ToString(dr["PCAS_ECode"]);
            if (dr["PCAS_EName"] != DBNull.Value) pC_AEqu.PCAS_EName = Convert.ToString(dr["PCAS_EName"]);
            if (dr["PCAS_Owner"] != DBNull.Value) pC_AEqu.PCAS_Owner = Convert.ToString(dr["PCAS_Owner"]);
            if (dr["PCAS_OContact"] != DBNull.Value) pC_AEqu.PCAS_OContact = Convert.ToString(dr["PCAS_OContact"]);
            if (dr["PCAS_Num"] != DBNull.Value) pC_AEqu.PCAS_Num = Convert.ToDecimal(dr["PCAS_Num"]);
            if (dr["PCAS_Bak"] != DBNull.Value) pC_AEqu.PCAS_Bak = Convert.ToString(dr["PCAS_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_AEqu.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_AEqu.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_AEqu.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_AEqu.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_AEqu);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
