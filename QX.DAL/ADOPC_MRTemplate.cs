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
   public partial class ADOPC_MRTemplate
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加PC_MRTemplate对象(即:一条记录)
      /// </summary>
      public int Add(PC_MRTemplate pC_MRTemplate)
      {
         string sql = "INSERT INTO PC_MRTemplate (PCMRT_Code,PCMRT_Name,PCMRT_LCode,PCMRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCMRT_Code,@PCMRT_Name,@PCMRT_LCode,@PCMRT_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_Code))
         {
            idb.AddParameter("@PCMRT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_Code", pC_MRTemplate.PCMRT_Code);
         }
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_Name))
         {
            idb.AddParameter("@PCMRT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_Name", pC_MRTemplate.PCMRT_Name);
         }
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_LCode))
         {
            idb.AddParameter("@PCMRT_LCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_LCode", pC_MRTemplate.PCMRT_LCode);
         }
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_Remark))
         {
            idb.AddParameter("@PCMRT_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_Remark", pC_MRTemplate.PCMRT_Remark);
         }
         if (pC_MRTemplate.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_MRTemplate.Stat);
         }
         if (pC_MRTemplate.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_MRTemplate.CreateDate);
         }
         if (pC_MRTemplate.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_MRTemplate.UpdateDate);
         }
         if (pC_MRTemplate.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_MRTemplate.DeleteDate);
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
      /// 添加PC_MRTemplate对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_MRTemplate pC_MRTemplate)
      {
         string sql = "INSERT INTO PC_MRTemplate (PCMRT_Code,PCMRT_Name,PCMRT_LCode,PCMRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCMRT_Code,@PCMRT_Name,@PCMRT_LCode,@PCMRT_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_Code))
         {
            idb.AddParameter("@PCMRT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_Code", pC_MRTemplate.PCMRT_Code);
         }
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_Name))
         {
            idb.AddParameter("@PCMRT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_Name", pC_MRTemplate.PCMRT_Name);
         }
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_LCode))
         {
            idb.AddParameter("@PCMRT_LCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_LCode", pC_MRTemplate.PCMRT_LCode);
         }
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_Remark))
         {
            idb.AddParameter("@PCMRT_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_Remark", pC_MRTemplate.PCMRT_Remark);
         }
         if (pC_MRTemplate.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_MRTemplate.Stat);
         }
         if (pC_MRTemplate.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_MRTemplate.CreateDate);
         }
         if (pC_MRTemplate.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_MRTemplate.UpdateDate);
         }
         if (pC_MRTemplate.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_MRTemplate.DeleteDate);
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
      /// 更新PC_MRTemplate对象(即:一条记录
      /// </summary>
      public int Update(PC_MRTemplate pC_MRTemplate)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_MRTemplate       SET ");
            if(pC_MRTemplate.PCMRT_Code_IsChanged){sbParameter.Append("PCMRT_Code=@PCMRT_Code, ");}
      if(pC_MRTemplate.PCMRT_Name_IsChanged){sbParameter.Append("PCMRT_Name=@PCMRT_Name, ");}
      if(pC_MRTemplate.PCMRT_LCode_IsChanged){sbParameter.Append("PCMRT_LCode=@PCMRT_LCode, ");}
      if(pC_MRTemplate.PCMRT_Remark_IsChanged){sbParameter.Append("PCMRT_Remark=@PCMRT_Remark, ");}
      if(pC_MRTemplate.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_MRTemplate.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_MRTemplate.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_MRTemplate.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCMRT_ID=@PCMRT_ID; " );
      string sql=sb.ToString();
         if(pC_MRTemplate.PCMRT_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_Code))
         {
            idb.AddParameter("@PCMRT_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_Code", pC_MRTemplate.PCMRT_Code);
         }
          }
         if(pC_MRTemplate.PCMRT_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_Name))
         {
            idb.AddParameter("@PCMRT_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_Name", pC_MRTemplate.PCMRT_Name);
         }
          }
         if(pC_MRTemplate.PCMRT_LCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_LCode))
         {
            idb.AddParameter("@PCMRT_LCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_LCode", pC_MRTemplate.PCMRT_LCode);
         }
          }
         if(pC_MRTemplate.PCMRT_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRTemplate.PCMRT_Remark))
         {
            idb.AddParameter("@PCMRT_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMRT_Remark", pC_MRTemplate.PCMRT_Remark);
         }
          }
         if(pC_MRTemplate.Stat_IsChanged)
         {
         if (pC_MRTemplate.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_MRTemplate.Stat);
         }
          }
         if(pC_MRTemplate.CreateDate_IsChanged)
         {
         if (pC_MRTemplate.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_MRTemplate.CreateDate);
         }
          }
         if(pC_MRTemplate.UpdateDate_IsChanged)
         {
         if (pC_MRTemplate.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_MRTemplate.UpdateDate);
         }
          }
         if(pC_MRTemplate.DeleteDate_IsChanged)
         {
         if (pC_MRTemplate.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_MRTemplate.DeleteDate);
         }
          }

         idb.AddParameter("@PCMRT_ID", pC_MRTemplate.PCMRT_ID);

           
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
      /// 删除PC_MRTemplate对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCMRT_ID)
      {
         string sql = "DELETE PC_MRTemplate WHERE 1=1  AND PCMRT_ID=@PCMRT_ID ";
         idb.AddParameter("@PCMRT_ID", pCMRT_ID);

           
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
      /// 获取指定的PC_MRTemplate对象(即:一条记录
      /// </summary>
      public PC_MRTemplate GetByKey(decimal pCMRT_ID)
      {
         PC_MRTemplate pC_MRTemplate = new PC_MRTemplate();
         string sql = "SELECT  PCMRT_ID,PCMRT_Code,PCMRT_Name,PCMRT_LCode,PCMRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_MRTemplate WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCMRT_ID=@PCMRT_ID ";
         idb.AddParameter("@PCMRT_ID", pCMRT_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCMRT_ID"] != DBNull.Value) pC_MRTemplate.PCMRT_ID = Convert.ToDecimal(dr["PCMRT_ID"]);
            if (dr["PCMRT_Code"] != DBNull.Value) pC_MRTemplate.PCMRT_Code = Convert.ToString(dr["PCMRT_Code"]);
            if (dr["PCMRT_Name"] != DBNull.Value) pC_MRTemplate.PCMRT_Name = Convert.ToString(dr["PCMRT_Name"]);
            if (dr["PCMRT_LCode"] != DBNull.Value) pC_MRTemplate.PCMRT_LCode = Convert.ToString(dr["PCMRT_LCode"]);
            if (dr["PCMRT_Remark"] != DBNull.Value) pC_MRTemplate.PCMRT_Remark = Convert.ToString(dr["PCMRT_Remark"]);
            if (dr["Stat"] != DBNull.Value) pC_MRTemplate.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_MRTemplate.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_MRTemplate.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_MRTemplate.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_MRTemplate;
      }
      /// <summary>
      /// 获取指定的PC_MRTemplate对象集合
      /// </summary>
      public List<PC_MRTemplate> GetListByWhere(string strCondition)
      {
         List<PC_MRTemplate> ret = new List<PC_MRTemplate>();
         string sql = "SELECT  PCMRT_ID,PCMRT_Code,PCMRT_Name,PCMRT_LCode,PCMRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_MRTemplate WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_MRTemplate pC_MRTemplate = new PC_MRTemplate();
            if (dr["PCMRT_ID"] != DBNull.Value) pC_MRTemplate.PCMRT_ID = Convert.ToDecimal(dr["PCMRT_ID"]);
            if (dr["PCMRT_Code"] != DBNull.Value) pC_MRTemplate.PCMRT_Code = Convert.ToString(dr["PCMRT_Code"]);
            if (dr["PCMRT_Name"] != DBNull.Value) pC_MRTemplate.PCMRT_Name = Convert.ToString(dr["PCMRT_Name"]);
            if (dr["PCMRT_LCode"] != DBNull.Value) pC_MRTemplate.PCMRT_LCode = Convert.ToString(dr["PCMRT_LCode"]);
            if (dr["PCMRT_Remark"] != DBNull.Value) pC_MRTemplate.PCMRT_Remark = Convert.ToString(dr["PCMRT_Remark"]);
            if (dr["Stat"] != DBNull.Value) pC_MRTemplate.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_MRTemplate.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_MRTemplate.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_MRTemplate.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_MRTemplate);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的PC_MRTemplate对象(即:一条记录
      /// </summary>
      public List<PC_MRTemplate> GetAll()
      {
         List<PC_MRTemplate> ret = new List<PC_MRTemplate>();
         string sql = "SELECT  PCMRT_ID,PCMRT_Code,PCMRT_Name,PCMRT_LCode,PCMRT_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_MRTemplate where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCMRT_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_MRTemplate pC_MRTemplate = new PC_MRTemplate();
            if (dr["PCMRT_ID"] != DBNull.Value) pC_MRTemplate.PCMRT_ID = Convert.ToDecimal(dr["PCMRT_ID"]);
            if (dr["PCMRT_Code"] != DBNull.Value) pC_MRTemplate.PCMRT_Code = Convert.ToString(dr["PCMRT_Code"]);
            if (dr["PCMRT_Name"] != DBNull.Value) pC_MRTemplate.PCMRT_Name = Convert.ToString(dr["PCMRT_Name"]);
            if (dr["PCMRT_LCode"] != DBNull.Value) pC_MRTemplate.PCMRT_LCode = Convert.ToString(dr["PCMRT_LCode"]);
            if (dr["PCMRT_Remark"] != DBNull.Value) pC_MRTemplate.PCMRT_Remark = Convert.ToString(dr["PCMRT_Remark"]);
            if (dr["Stat"] != DBNull.Value) pC_MRTemplate.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_MRTemplate.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_MRTemplate.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_MRTemplate.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_MRTemplate);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
