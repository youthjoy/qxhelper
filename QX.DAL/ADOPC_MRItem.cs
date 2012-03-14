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
   public partial class ADOPC_MRItem
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加PC_MRItem对象(即:一条记录)
      /// </summary>
      public int Add(PC_MRItem pC_MRItem)
      {
         string sql = "INSERT INTO PC_MRItem (PCMI_Code,PCMI_TCode,PCMI_WCode,PCMI_WNo,PCMI_MCode,PCMI_MName,PCMI_CCode,PCMI_Unit,PCMI_Spec,PCMI_Price,PCMI_Num,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCMI_Code,@PCMI_TCode,@PCMI_WCode,@PCMI_WNo,@PCMI_MCode,@PCMI_MName,@PCMI_CCode,@PCMI_Unit,@PCMI_Spec,@PCMI_Price,@PCMI_Num,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_Code))
         {
            idb.AddParameter("@PCMI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_Code", pC_MRItem.PCMI_Code);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_TCode))
         {
            idb.AddParameter("@PCMI_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_TCode", pC_MRItem.PCMI_TCode);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_WCode))
         {
            idb.AddParameter("@PCMI_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_WCode", pC_MRItem.PCMI_WCode);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_WNo))
         {
            idb.AddParameter("@PCMI_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_WNo", pC_MRItem.PCMI_WNo);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_MCode))
         {
            idb.AddParameter("@PCMI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_MCode", pC_MRItem.PCMI_MCode);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_MName))
         {
            idb.AddParameter("@PCMI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_MName", pC_MRItem.PCMI_MName);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_CCode))
         {
            idb.AddParameter("@PCMI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_CCode", pC_MRItem.PCMI_CCode);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_Unit))
         {
            idb.AddParameter("@PCMI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_Unit", pC_MRItem.PCMI_Unit);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_Spec))
         {
            idb.AddParameter("@PCMI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_Spec", pC_MRItem.PCMI_Spec);
         }
         if (pC_MRItem.PCMI_Price == 0)
         {
            idb.AddParameter("@PCMI_Price", 0);
         }
         else
         {
            idb.AddParameter("@PCMI_Price", pC_MRItem.PCMI_Price);
         }
         if (pC_MRItem.PCMI_Num == 0)
         {
            idb.AddParameter("@PCMI_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCMI_Num", pC_MRItem.PCMI_Num);
         }
         if (pC_MRItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_MRItem.Stat);
         }
         if (pC_MRItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_MRItem.CreateDate);
         }
         if (pC_MRItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_MRItem.UpdateDate);
         }
         if (pC_MRItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_MRItem.DeleteDate);
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
      /// 添加PC_MRItem对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_MRItem pC_MRItem)
      {
         string sql = "INSERT INTO PC_MRItem (PCMI_Code,PCMI_TCode,PCMI_WCode,PCMI_WNo,PCMI_MCode,PCMI_MName,PCMI_CCode,PCMI_Unit,PCMI_Spec,PCMI_Price,PCMI_Num,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCMI_Code,@PCMI_TCode,@PCMI_WCode,@PCMI_WNo,@PCMI_MCode,@PCMI_MName,@PCMI_CCode,@PCMI_Unit,@PCMI_Spec,@PCMI_Price,@PCMI_Num,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_Code))
         {
            idb.AddParameter("@PCMI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_Code", pC_MRItem.PCMI_Code);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_TCode))
         {
            idb.AddParameter("@PCMI_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_TCode", pC_MRItem.PCMI_TCode);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_WCode))
         {
            idb.AddParameter("@PCMI_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_WCode", pC_MRItem.PCMI_WCode);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_WNo))
         {
            idb.AddParameter("@PCMI_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_WNo", pC_MRItem.PCMI_WNo);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_MCode))
         {
            idb.AddParameter("@PCMI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_MCode", pC_MRItem.PCMI_MCode);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_MName))
         {
            idb.AddParameter("@PCMI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_MName", pC_MRItem.PCMI_MName);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_CCode))
         {
            idb.AddParameter("@PCMI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_CCode", pC_MRItem.PCMI_CCode);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_Unit))
         {
            idb.AddParameter("@PCMI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_Unit", pC_MRItem.PCMI_Unit);
         }
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_Spec))
         {
            idb.AddParameter("@PCMI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_Spec", pC_MRItem.PCMI_Spec);
         }
         if (pC_MRItem.PCMI_Price == 0)
         {
            idb.AddParameter("@PCMI_Price", 0);
         }
         else
         {
            idb.AddParameter("@PCMI_Price", pC_MRItem.PCMI_Price);
         }
         if (pC_MRItem.PCMI_Num == 0)
         {
            idb.AddParameter("@PCMI_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCMI_Num", pC_MRItem.PCMI_Num);
         }
         if (pC_MRItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_MRItem.Stat);
         }
         if (pC_MRItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_MRItem.CreateDate);
         }
         if (pC_MRItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_MRItem.UpdateDate);
         }
         if (pC_MRItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_MRItem.DeleteDate);
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
      /// 更新PC_MRItem对象(即:一条记录
      /// </summary>
      public int Update(PC_MRItem pC_MRItem)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_MRItem       SET ");
            if(pC_MRItem.PCMI_Code_IsChanged){sbParameter.Append("PCMI_Code=@PCMI_Code, ");}
      if(pC_MRItem.PCMI_TCode_IsChanged){sbParameter.Append("PCMI_TCode=@PCMI_TCode, ");}
      if(pC_MRItem.PCMI_WCode_IsChanged){sbParameter.Append("PCMI_WCode=@PCMI_WCode, ");}
      if(pC_MRItem.PCMI_WNo_IsChanged){sbParameter.Append("PCMI_WNo=@PCMI_WNo, ");}
      if(pC_MRItem.PCMI_MCode_IsChanged){sbParameter.Append("PCMI_MCode=@PCMI_MCode, ");}
      if(pC_MRItem.PCMI_MName_IsChanged){sbParameter.Append("PCMI_MName=@PCMI_MName, ");}
      if(pC_MRItem.PCMI_CCode_IsChanged){sbParameter.Append("PCMI_CCode=@PCMI_CCode, ");}
      if(pC_MRItem.PCMI_Unit_IsChanged){sbParameter.Append("PCMI_Unit=@PCMI_Unit, ");}
      if(pC_MRItem.PCMI_Spec_IsChanged){sbParameter.Append("PCMI_Spec=@PCMI_Spec, ");}
      if(pC_MRItem.PCMI_Price_IsChanged){sbParameter.Append("PCMI_Price=@PCMI_Price, ");}
      if(pC_MRItem.PCMI_Num_IsChanged){sbParameter.Append("PCMI_Num=@PCMI_Num, ");}
      if(pC_MRItem.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_MRItem.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_MRItem.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_MRItem.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCMI_ID=@PCMI_ID; " );
      string sql=sb.ToString();
         if(pC_MRItem.PCMI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_Code))
         {
            idb.AddParameter("@PCMI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_Code", pC_MRItem.PCMI_Code);
         }
          }
         if(pC_MRItem.PCMI_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_TCode))
         {
            idb.AddParameter("@PCMI_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_TCode", pC_MRItem.PCMI_TCode);
         }
          }
         if(pC_MRItem.PCMI_WCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_WCode))
         {
            idb.AddParameter("@PCMI_WCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_WCode", pC_MRItem.PCMI_WCode);
         }
          }
         if(pC_MRItem.PCMI_WNo_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_WNo))
         {
            idb.AddParameter("@PCMI_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_WNo", pC_MRItem.PCMI_WNo);
         }
          }
         if(pC_MRItem.PCMI_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_MCode))
         {
            idb.AddParameter("@PCMI_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_MCode", pC_MRItem.PCMI_MCode);
         }
          }
         if(pC_MRItem.PCMI_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_MName))
         {
            idb.AddParameter("@PCMI_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_MName", pC_MRItem.PCMI_MName);
         }
          }
         if(pC_MRItem.PCMI_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_CCode))
         {
            idb.AddParameter("@PCMI_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_CCode", pC_MRItem.PCMI_CCode);
         }
          }
         if(pC_MRItem.PCMI_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_Unit))
         {
            idb.AddParameter("@PCMI_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_Unit", pC_MRItem.PCMI_Unit);
         }
          }
         if(pC_MRItem.PCMI_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_MRItem.PCMI_Spec))
         {
            idb.AddParameter("@PCMI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCMI_Spec", pC_MRItem.PCMI_Spec);
         }
          }
         if(pC_MRItem.PCMI_Price_IsChanged)
         {
         if (pC_MRItem.PCMI_Price == 0)
         {
            idb.AddParameter("@PCMI_Price", 0);
         }
         else
         {
            idb.AddParameter("@PCMI_Price", pC_MRItem.PCMI_Price);
         }
          }
         if(pC_MRItem.PCMI_Num_IsChanged)
         {
         if (pC_MRItem.PCMI_Num == 0)
         {
            idb.AddParameter("@PCMI_Num", 0);
         }
         else
         {
            idb.AddParameter("@PCMI_Num", pC_MRItem.PCMI_Num);
         }
          }
         if(pC_MRItem.Stat_IsChanged)
         {
         if (pC_MRItem.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_MRItem.Stat);
         }
          }
         if(pC_MRItem.CreateDate_IsChanged)
         {
         if (pC_MRItem.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_MRItem.CreateDate);
         }
          }
         if(pC_MRItem.UpdateDate_IsChanged)
         {
         if (pC_MRItem.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_MRItem.UpdateDate);
         }
          }
         if(pC_MRItem.DeleteDate_IsChanged)
         {
         if (pC_MRItem.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_MRItem.DeleteDate);
         }
          }

         idb.AddParameter("@PCMI_ID", pC_MRItem.PCMI_ID);

           
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
      /// 删除PC_MRItem对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCMI_ID)
      {
         string sql = "DELETE PC_MRItem WHERE 1=1  AND PCMI_ID=@PCMI_ID ";
         idb.AddParameter("@PCMI_ID", pCMI_ID);

           
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
      /// 获取指定的PC_MRItem对象(即:一条记录
      /// </summary>
      public PC_MRItem GetByKey(decimal pCMI_ID)
      {
         PC_MRItem pC_MRItem = new PC_MRItem();
         string sql = "SELECT  PCMI_ID,PCMI_Code,PCMI_TCode,PCMI_WCode,PCMI_WNo,PCMI_MCode,PCMI_MName,PCMI_CCode,PCMI_Unit,PCMI_Spec,PCMI_Price,PCMI_Num,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_MRItem WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCMI_ID=@PCMI_ID ";
         idb.AddParameter("@PCMI_ID", pCMI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCMI_ID"] != DBNull.Value) pC_MRItem.PCMI_ID = Convert.ToDecimal(dr["PCMI_ID"]);
            if (dr["PCMI_Code"] != DBNull.Value) pC_MRItem.PCMI_Code = Convert.ToString(dr["PCMI_Code"]);
            if (dr["PCMI_TCode"] != DBNull.Value) pC_MRItem.PCMI_TCode = Convert.ToString(dr["PCMI_TCode"]);
            if (dr["PCMI_WCode"] != DBNull.Value) pC_MRItem.PCMI_WCode = Convert.ToString(dr["PCMI_WCode"]);
            if (dr["PCMI_WNo"] != DBNull.Value) pC_MRItem.PCMI_WNo = Convert.ToString(dr["PCMI_WNo"]);
            if (dr["PCMI_MCode"] != DBNull.Value) pC_MRItem.PCMI_MCode = Convert.ToString(dr["PCMI_MCode"]);
            if (dr["PCMI_MName"] != DBNull.Value) pC_MRItem.PCMI_MName = Convert.ToString(dr["PCMI_MName"]);
            if (dr["PCMI_CCode"] != DBNull.Value) pC_MRItem.PCMI_CCode = Convert.ToString(dr["PCMI_CCode"]);
            if (dr["PCMI_Unit"] != DBNull.Value) pC_MRItem.PCMI_Unit = Convert.ToString(dr["PCMI_Unit"]);
            if (dr["PCMI_Spec"] != DBNull.Value) pC_MRItem.PCMI_Spec = Convert.ToString(dr["PCMI_Spec"]);
            if (dr["PCMI_Price"] != DBNull.Value) pC_MRItem.PCMI_Price = Convert.ToDecimal(dr["PCMI_Price"]);
            if (dr["PCMI_Num"] != DBNull.Value) pC_MRItem.PCMI_Num = Convert.ToDecimal(dr["PCMI_Num"]);
            if (dr["Stat"] != DBNull.Value) pC_MRItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_MRItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_MRItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_MRItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_MRItem;
      }
      /// <summary>
      /// 获取指定的PC_MRItem对象集合
      /// </summary>
      public List<PC_MRItem> GetListByWhere(string strCondition)
      {
         List<PC_MRItem> ret = new List<PC_MRItem>();
         string sql = "SELECT  PCMI_ID,PCMI_Code,PCMI_TCode,PCMI_WCode,PCMI_WNo,PCMI_MCode,PCMI_MName,PCMI_CCode,PCMI_Unit,PCMI_Spec,PCMI_Price,PCMI_Num,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_MRItem WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_MRItem pC_MRItem = new PC_MRItem();
            if (dr["PCMI_ID"] != DBNull.Value) pC_MRItem.PCMI_ID = Convert.ToDecimal(dr["PCMI_ID"]);
            if (dr["PCMI_Code"] != DBNull.Value) pC_MRItem.PCMI_Code = Convert.ToString(dr["PCMI_Code"]);
            if (dr["PCMI_TCode"] != DBNull.Value) pC_MRItem.PCMI_TCode = Convert.ToString(dr["PCMI_TCode"]);
            if (dr["PCMI_WCode"] != DBNull.Value) pC_MRItem.PCMI_WCode = Convert.ToString(dr["PCMI_WCode"]);
            if (dr["PCMI_WNo"] != DBNull.Value) pC_MRItem.PCMI_WNo = Convert.ToString(dr["PCMI_WNo"]);
            if (dr["PCMI_MCode"] != DBNull.Value) pC_MRItem.PCMI_MCode = Convert.ToString(dr["PCMI_MCode"]);
            if (dr["PCMI_MName"] != DBNull.Value) pC_MRItem.PCMI_MName = Convert.ToString(dr["PCMI_MName"]);
            if (dr["PCMI_CCode"] != DBNull.Value) pC_MRItem.PCMI_CCode = Convert.ToString(dr["PCMI_CCode"]);
            if (dr["PCMI_Unit"] != DBNull.Value) pC_MRItem.PCMI_Unit = Convert.ToString(dr["PCMI_Unit"]);
            if (dr["PCMI_Spec"] != DBNull.Value) pC_MRItem.PCMI_Spec = Convert.ToString(dr["PCMI_Spec"]);
            if (dr["PCMI_Price"] != DBNull.Value) pC_MRItem.PCMI_Price = Convert.ToDecimal(dr["PCMI_Price"]);
            if (dr["PCMI_Num"] != DBNull.Value) pC_MRItem.PCMI_Num = Convert.ToDecimal(dr["PCMI_Num"]);
            if (dr["Stat"] != DBNull.Value) pC_MRItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_MRItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_MRItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_MRItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_MRItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的PC_MRItem对象(即:一条记录
      /// </summary>
      public List<PC_MRItem> GetAll()
      {
         List<PC_MRItem> ret = new List<PC_MRItem>();
         string sql = "SELECT  PCMI_ID,PCMI_Code,PCMI_TCode,PCMI_WCode,PCMI_WNo,PCMI_MCode,PCMI_MName,PCMI_CCode,PCMI_Unit,PCMI_Spec,PCMI_Price,PCMI_Num,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_MRItem where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCMI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_MRItem pC_MRItem = new PC_MRItem();
            if (dr["PCMI_ID"] != DBNull.Value) pC_MRItem.PCMI_ID = Convert.ToDecimal(dr["PCMI_ID"]);
            if (dr["PCMI_Code"] != DBNull.Value) pC_MRItem.PCMI_Code = Convert.ToString(dr["PCMI_Code"]);
            if (dr["PCMI_TCode"] != DBNull.Value) pC_MRItem.PCMI_TCode = Convert.ToString(dr["PCMI_TCode"]);
            if (dr["PCMI_WCode"] != DBNull.Value) pC_MRItem.PCMI_WCode = Convert.ToString(dr["PCMI_WCode"]);
            if (dr["PCMI_WNo"] != DBNull.Value) pC_MRItem.PCMI_WNo = Convert.ToString(dr["PCMI_WNo"]);
            if (dr["PCMI_MCode"] != DBNull.Value) pC_MRItem.PCMI_MCode = Convert.ToString(dr["PCMI_MCode"]);
            if (dr["PCMI_MName"] != DBNull.Value) pC_MRItem.PCMI_MName = Convert.ToString(dr["PCMI_MName"]);
            if (dr["PCMI_CCode"] != DBNull.Value) pC_MRItem.PCMI_CCode = Convert.ToString(dr["PCMI_CCode"]);
            if (dr["PCMI_Unit"] != DBNull.Value) pC_MRItem.PCMI_Unit = Convert.ToString(dr["PCMI_Unit"]);
            if (dr["PCMI_Spec"] != DBNull.Value) pC_MRItem.PCMI_Spec = Convert.ToString(dr["PCMI_Spec"]);
            if (dr["PCMI_Price"] != DBNull.Value) pC_MRItem.PCMI_Price = Convert.ToDecimal(dr["PCMI_Price"]);
            if (dr["PCMI_Num"] != DBNull.Value) pC_MRItem.PCMI_Num = Convert.ToDecimal(dr["PCMI_Num"]);
            if (dr["Stat"] != DBNull.Value) pC_MRItem.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_MRItem.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_MRItem.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_MRItem.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_MRItem);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
