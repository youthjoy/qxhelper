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
   public partial class ADOPC_WError
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加PC_WError对象(即:一条记录)
      /// </summary>
      public int Add(PC_WError pC_WError)
      {
         string sql = "INSERT INTO PC_WError (PCWE_Code,PCWE_Module,PCWE_WHCode,PCWE_WHName,PCWE_MCode,PCWE_MName,PCWE_Unit,PCWE_Num,PCWE_Operator,PCWE_OpDate,PCWE_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCWE_Code,@PCWE_Module,@PCWE_WHCode,@PCWE_WHName,@PCWE_MCode,@PCWE_MName,@PCWE_Unit,@PCWE_Num,@PCWE_Operator,@PCWE_OpDate,@PCWE_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_WError.PCWE_Code))
         {
            idb.AddParameter("@PCWE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Code", pC_WError.PCWE_Code);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_Module))
         {
            idb.AddParameter("@PCWE_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Module", pC_WError.PCWE_Module);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_WHCode))
         {
            idb.AddParameter("@PCWE_WHCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_WHCode", pC_WError.PCWE_WHCode);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_WHName))
         {
            idb.AddParameter("@PCWE_WHName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_WHName", pC_WError.PCWE_WHName);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_MCode))
         {
            idb.AddParameter("@PCWE_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_MCode", pC_WError.PCWE_MCode);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_MName))
         {
            idb.AddParameter("@PCWE_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_MName", pC_WError.PCWE_MName);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_Unit))
         {
            idb.AddParameter("@PCWE_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Unit", pC_WError.PCWE_Unit);
         }
         if (pC_WError.PCWE_Num == 0)
         {
            idb.AddParameter("@PCWE_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCWE_Num", pC_WError.PCWE_Num);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_Operator))
         {
            idb.AddParameter("@PCWE_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Operator", pC_WError.PCWE_Operator);
         }
         if (pC_WError.PCWE_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCWE_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_OpDate", pC_WError.PCWE_OpDate);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_Bak))
         {
            idb.AddParameter("@PCWE_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Bak", pC_WError.PCWE_Bak);
         }
         if (pC_WError.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_WError.Stat);
         }
         if (pC_WError.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_WError.CreateDate);
         }
         if (pC_WError.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_WError.UpdateDate);
         }
         if (pC_WError.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_WError.DeleteDate);
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
      /// 添加PC_WError对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_WError pC_WError)
      {
         string sql = "INSERT INTO PC_WError (PCWE_Code,PCWE_Module,PCWE_WHCode,PCWE_WHName,PCWE_MCode,PCWE_MName,PCWE_Unit,PCWE_Num,PCWE_Operator,PCWE_OpDate,PCWE_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCWE_Code,@PCWE_Module,@PCWE_WHCode,@PCWE_WHName,@PCWE_MCode,@PCWE_MName,@PCWE_Unit,@PCWE_Num,@PCWE_Operator,@PCWE_OpDate,@PCWE_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_WError.PCWE_Code))
         {
            idb.AddParameter("@PCWE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Code", pC_WError.PCWE_Code);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_Module))
         {
            idb.AddParameter("@PCWE_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Module", pC_WError.PCWE_Module);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_WHCode))
         {
            idb.AddParameter("@PCWE_WHCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_WHCode", pC_WError.PCWE_WHCode);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_WHName))
         {
            idb.AddParameter("@PCWE_WHName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_WHName", pC_WError.PCWE_WHName);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_MCode))
         {
            idb.AddParameter("@PCWE_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_MCode", pC_WError.PCWE_MCode);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_MName))
         {
            idb.AddParameter("@PCWE_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_MName", pC_WError.PCWE_MName);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_Unit))
         {
            idb.AddParameter("@PCWE_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Unit", pC_WError.PCWE_Unit);
         }
         if (pC_WError.PCWE_Num == 0)
         {
            idb.AddParameter("@PCWE_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCWE_Num", pC_WError.PCWE_Num);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_Operator))
         {
            idb.AddParameter("@PCWE_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Operator", pC_WError.PCWE_Operator);
         }
         if (pC_WError.PCWE_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCWE_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_OpDate", pC_WError.PCWE_OpDate);
         }
         if (string.IsNullOrEmpty(pC_WError.PCWE_Bak))
         {
            idb.AddParameter("@PCWE_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Bak", pC_WError.PCWE_Bak);
         }
         if (pC_WError.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_WError.Stat);
         }
         if (pC_WError.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_WError.CreateDate);
         }
         if (pC_WError.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_WError.UpdateDate);
         }
         if (pC_WError.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_WError.DeleteDate);
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
      /// 更新PC_WError对象(即:一条记录
      /// </summary>
      public int Update(PC_WError pC_WError)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_WError       SET ");
            if(pC_WError.PCWE_Code_IsChanged){sbParameter.Append("PCWE_Code=@PCWE_Code, ");}
      if(pC_WError.PCWE_Module_IsChanged){sbParameter.Append("PCWE_Module=@PCWE_Module, ");}
      if(pC_WError.PCWE_WHCode_IsChanged){sbParameter.Append("PCWE_WHCode=@PCWE_WHCode, ");}
      if(pC_WError.PCWE_WHName_IsChanged){sbParameter.Append("PCWE_WHName=@PCWE_WHName, ");}
      if(pC_WError.PCWE_MCode_IsChanged){sbParameter.Append("PCWE_MCode=@PCWE_MCode, ");}
      if(pC_WError.PCWE_MName_IsChanged){sbParameter.Append("PCWE_MName=@PCWE_MName, ");}
      if(pC_WError.PCWE_Unit_IsChanged){sbParameter.Append("PCWE_Unit=@PCWE_Unit, ");}
      if(pC_WError.PCWE_Num_IsChanged){sbParameter.Append("PCWE_Num=@PCWE_Num, ");}
      if(pC_WError.PCWE_Operator_IsChanged){sbParameter.Append("PCWE_Operator=@PCWE_Operator, ");}
      if(pC_WError.PCWE_OpDate_IsChanged){sbParameter.Append("PCWE_OpDate=@PCWE_OpDate, ");}
      if(pC_WError.PCWE_Bak_IsChanged){sbParameter.Append("PCWE_Bak=@PCWE_Bak, ");}
      if(pC_WError.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_WError.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_WError.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_WError.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCWE_ID=@PCWE_ID; " );
      string sql=sb.ToString();
         if(pC_WError.PCWE_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_WError.PCWE_Code))
         {
            idb.AddParameter("@PCWE_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Code", pC_WError.PCWE_Code);
         }
          }
         if(pC_WError.PCWE_Module_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_WError.PCWE_Module))
         {
            idb.AddParameter("@PCWE_Module", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Module", pC_WError.PCWE_Module);
         }
          }
         if(pC_WError.PCWE_WHCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_WError.PCWE_WHCode))
         {
            idb.AddParameter("@PCWE_WHCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_WHCode", pC_WError.PCWE_WHCode);
         }
          }
         if(pC_WError.PCWE_WHName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_WError.PCWE_WHName))
         {
            idb.AddParameter("@PCWE_WHName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_WHName", pC_WError.PCWE_WHName);
         }
          }
         if(pC_WError.PCWE_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_WError.PCWE_MCode))
         {
            idb.AddParameter("@PCWE_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_MCode", pC_WError.PCWE_MCode);
         }
          }
         if(pC_WError.PCWE_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_WError.PCWE_MName))
         {
            idb.AddParameter("@PCWE_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_MName", pC_WError.PCWE_MName);
         }
          }
         if(pC_WError.PCWE_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_WError.PCWE_Unit))
         {
            idb.AddParameter("@PCWE_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Unit", pC_WError.PCWE_Unit);
         }
          }
         if(pC_WError.PCWE_Num_IsChanged)
         {
         if (pC_WError.PCWE_Num == 0)
         {
            idb.AddParameter("@PCWE_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCWE_Num", pC_WError.PCWE_Num);
         }
          }
         if(pC_WError.PCWE_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_WError.PCWE_Operator))
         {
            idb.AddParameter("@PCWE_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Operator", pC_WError.PCWE_Operator);
         }
          }
         if(pC_WError.PCWE_OpDate_IsChanged)
         {
         if (pC_WError.PCWE_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCWE_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_OpDate", pC_WError.PCWE_OpDate);
         }
          }
         if(pC_WError.PCWE_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_WError.PCWE_Bak))
         {
            idb.AddParameter("@PCWE_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCWE_Bak", pC_WError.PCWE_Bak);
         }
          }
         if(pC_WError.Stat_IsChanged)
         {
         if (pC_WError.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_WError.Stat);
         }
          }
         if(pC_WError.CreateDate_IsChanged)
         {
         if (pC_WError.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_WError.CreateDate);
         }
          }
         if(pC_WError.UpdateDate_IsChanged)
         {
         if (pC_WError.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_WError.UpdateDate);
         }
          }
         if(pC_WError.DeleteDate_IsChanged)
         {
         if (pC_WError.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_WError.DeleteDate);
         }
          }

         idb.AddParameter("@PCWE_ID", pC_WError.PCWE_ID);

           
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
      /// 删除PC_WError对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCWE_ID)
      {
         string sql = "DELETE PC_WError WHERE 1=1  AND PCWE_ID=@PCWE_ID ";
         idb.AddParameter("@PCWE_ID", pCWE_ID);

           
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
      /// 获取指定的PC_WError对象(即:一条记录
      /// </summary>
      public PC_WError GetByKey(decimal pCWE_ID)
      {
         PC_WError pC_WError = new PC_WError();
         string sql = "SELECT  PCWE_ID,PCWE_Code,PCWE_Module,PCWE_WHCode,PCWE_WHName,PCWE_MCode,PCWE_MName,PCWE_Unit,PCWE_Num,PCWE_Operator,PCWE_OpDate,PCWE_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_WError WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCWE_ID=@PCWE_ID ";
         idb.AddParameter("@PCWE_ID", pCWE_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCWE_ID"] != DBNull.Value) pC_WError.PCWE_ID = Convert.ToDecimal(dr["PCWE_ID"]);
            if (dr["PCWE_Code"] != DBNull.Value) pC_WError.PCWE_Code = Convert.ToString(dr["PCWE_Code"]);
            if (dr["PCWE_Module"] != DBNull.Value) pC_WError.PCWE_Module = Convert.ToString(dr["PCWE_Module"]);
            if (dr["PCWE_WHCode"] != DBNull.Value) pC_WError.PCWE_WHCode = Convert.ToString(dr["PCWE_WHCode"]);
            if (dr["PCWE_WHName"] != DBNull.Value) pC_WError.PCWE_WHName = Convert.ToString(dr["PCWE_WHName"]);
            if (dr["PCWE_MCode"] != DBNull.Value) pC_WError.PCWE_MCode = Convert.ToString(dr["PCWE_MCode"]);
            if (dr["PCWE_MName"] != DBNull.Value) pC_WError.PCWE_MName = Convert.ToString(dr["PCWE_MName"]);
            if (dr["PCWE_Unit"] != DBNull.Value) pC_WError.PCWE_Unit = Convert.ToString(dr["PCWE_Unit"]);
            if (dr["PCWE_Num"] != DBNull.Value) pC_WError.PCWE_Num = Convert.ToDecimal(dr["PCWE_Num"]);
            if (dr["PCWE_Operator"] != DBNull.Value) pC_WError.PCWE_Operator = Convert.ToString(dr["PCWE_Operator"]);
            if (dr["PCWE_OpDate"] != DBNull.Value) pC_WError.PCWE_OpDate = Convert.ToDateTime(dr["PCWE_OpDate"]);
            if (dr["PCWE_Bak"] != DBNull.Value) pC_WError.PCWE_Bak = Convert.ToString(dr["PCWE_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_WError.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_WError.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_WError.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_WError.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_WError;
      }
      /// <summary>
      /// 获取指定的PC_WError对象集合
      /// </summary>
      public List<PC_WError> GetListByWhere(string strCondition)
      {
         List<PC_WError> ret = new List<PC_WError>();
         string sql = "SELECT  PCWE_ID,PCWE_Code,PCWE_Module,PCWE_WHCode,PCWE_WHName,PCWE_MCode,PCWE_MName,PCWE_Unit,PCWE_Num,PCWE_Operator,PCWE_OpDate,PCWE_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_WError WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_WError pC_WError = new PC_WError();
            if (dr["PCWE_ID"] != DBNull.Value) pC_WError.PCWE_ID = Convert.ToDecimal(dr["PCWE_ID"]);
            if (dr["PCWE_Code"] != DBNull.Value) pC_WError.PCWE_Code = Convert.ToString(dr["PCWE_Code"]);
            if (dr["PCWE_Module"] != DBNull.Value) pC_WError.PCWE_Module = Convert.ToString(dr["PCWE_Module"]);
            if (dr["PCWE_WHCode"] != DBNull.Value) pC_WError.PCWE_WHCode = Convert.ToString(dr["PCWE_WHCode"]);
            if (dr["PCWE_WHName"] != DBNull.Value) pC_WError.PCWE_WHName = Convert.ToString(dr["PCWE_WHName"]);
            if (dr["PCWE_MCode"] != DBNull.Value) pC_WError.PCWE_MCode = Convert.ToString(dr["PCWE_MCode"]);
            if (dr["PCWE_MName"] != DBNull.Value) pC_WError.PCWE_MName = Convert.ToString(dr["PCWE_MName"]);
            if (dr["PCWE_Unit"] != DBNull.Value) pC_WError.PCWE_Unit = Convert.ToString(dr["PCWE_Unit"]);
            if (dr["PCWE_Num"] != DBNull.Value) pC_WError.PCWE_Num = Convert.ToDecimal(dr["PCWE_Num"]);
            if (dr["PCWE_Operator"] != DBNull.Value) pC_WError.PCWE_Operator = Convert.ToString(dr["PCWE_Operator"]);
            if (dr["PCWE_OpDate"] != DBNull.Value) pC_WError.PCWE_OpDate = Convert.ToDateTime(dr["PCWE_OpDate"]);
            if (dr["PCWE_Bak"] != DBNull.Value) pC_WError.PCWE_Bak = Convert.ToString(dr["PCWE_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_WError.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_WError.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_WError.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_WError.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_WError);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的PC_WError对象(即:一条记录
      /// </summary>
      public List<PC_WError> GetAll()
      {
         List<PC_WError> ret = new List<PC_WError>();
         string sql = "SELECT  PCWE_ID,PCWE_Code,PCWE_Module,PCWE_WHCode,PCWE_WHName,PCWE_MCode,PCWE_MName,PCWE_Unit,PCWE_Num,PCWE_Operator,PCWE_OpDate,PCWE_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_WError where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCWE_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_WError pC_WError = new PC_WError();
            if (dr["PCWE_ID"] != DBNull.Value) pC_WError.PCWE_ID = Convert.ToDecimal(dr["PCWE_ID"]);
            if (dr["PCWE_Code"] != DBNull.Value) pC_WError.PCWE_Code = Convert.ToString(dr["PCWE_Code"]);
            if (dr["PCWE_Module"] != DBNull.Value) pC_WError.PCWE_Module = Convert.ToString(dr["PCWE_Module"]);
            if (dr["PCWE_WHCode"] != DBNull.Value) pC_WError.PCWE_WHCode = Convert.ToString(dr["PCWE_WHCode"]);
            if (dr["PCWE_WHName"] != DBNull.Value) pC_WError.PCWE_WHName = Convert.ToString(dr["PCWE_WHName"]);
            if (dr["PCWE_MCode"] != DBNull.Value) pC_WError.PCWE_MCode = Convert.ToString(dr["PCWE_MCode"]);
            if (dr["PCWE_MName"] != DBNull.Value) pC_WError.PCWE_MName = Convert.ToString(dr["PCWE_MName"]);
            if (dr["PCWE_Unit"] != DBNull.Value) pC_WError.PCWE_Unit = Convert.ToString(dr["PCWE_Unit"]);
            if (dr["PCWE_Num"] != DBNull.Value) pC_WError.PCWE_Num = Convert.ToDecimal(dr["PCWE_Num"]);
            if (dr["PCWE_Operator"] != DBNull.Value) pC_WError.PCWE_Operator = Convert.ToString(dr["PCWE_Operator"]);
            if (dr["PCWE_OpDate"] != DBNull.Value) pC_WError.PCWE_OpDate = Convert.ToDateTime(dr["PCWE_OpDate"]);
            if (dr["PCWE_Bak"] != DBNull.Value) pC_WError.PCWE_Bak = Convert.ToString(dr["PCWE_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_WError.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_WError.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_WError.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_WError.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_WError);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
