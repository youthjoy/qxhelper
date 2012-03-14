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
   /// 计量信息
   /// </summary>
   [Serializable]
   public partial class ADOLM_Details
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加计量信息 LM_Details对象(即:一条记录)
      /// </summary>
      public int Add(LM_Details lM_Details)
      {
         string sql = "INSERT INTO LM_Details (LMD_Code,LMD_MCode,LMD_ItemName,LMD_Item,LMD_Result,LMD_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@LMD_Code,@LMD_MCode,@LMD_ItemName,@LMD_Item,@LMD_Result,@LMD_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(lM_Details.LMD_Code))
         {
            idb.AddParameter("@LMD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_Code", lM_Details.LMD_Code);
         }
         if (string.IsNullOrEmpty(lM_Details.LMD_MCode))
         {
            idb.AddParameter("@LMD_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_MCode", lM_Details.LMD_MCode);
         }
         if (string.IsNullOrEmpty(lM_Details.LMD_ItemName))
         {
            idb.AddParameter("@LMD_ItemName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_ItemName", lM_Details.LMD_ItemName);
         }
         if (string.IsNullOrEmpty(lM_Details.LMD_Item))
         {
            idb.AddParameter("@LMD_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_Item", lM_Details.LMD_Item);
         }
         if (lM_Details.LMD_Result == 0)
         {
            idb.AddParameter("@LMD_Result", 0);
         }
         else
         {
            idb.AddParameter("@LMD_Result", lM_Details.LMD_Result);
         }
         if (string.IsNullOrEmpty(lM_Details.LMD_Remark))
         {
            idb.AddParameter("@LMD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_Remark", lM_Details.LMD_Remark);
         }
         if (lM_Details.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", lM_Details.Stat);
         }
         if (lM_Details.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", lM_Details.CreateDate);
         }
         if (lM_Details.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", lM_Details.UpdateDate);
         }
         if (lM_Details.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", lM_Details.DeleteDate);
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
      /// 添加计量信息 LM_Details对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(LM_Details lM_Details)
      {
         string sql = "INSERT INTO LM_Details (LMD_Code,LMD_MCode,LMD_ItemName,LMD_Item,LMD_Result,LMD_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@LMD_Code,@LMD_MCode,@LMD_ItemName,@LMD_Item,@LMD_Result,@LMD_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(lM_Details.LMD_Code))
         {
            idb.AddParameter("@LMD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_Code", lM_Details.LMD_Code);
         }
         if (string.IsNullOrEmpty(lM_Details.LMD_MCode))
         {
            idb.AddParameter("@LMD_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_MCode", lM_Details.LMD_MCode);
         }
         if (string.IsNullOrEmpty(lM_Details.LMD_ItemName))
         {
            idb.AddParameter("@LMD_ItemName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_ItemName", lM_Details.LMD_ItemName);
         }
         if (string.IsNullOrEmpty(lM_Details.LMD_Item))
         {
            idb.AddParameter("@LMD_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_Item", lM_Details.LMD_Item);
         }
         if (lM_Details.LMD_Result == 0)
         {
            idb.AddParameter("@LMD_Result", 0);
         }
         else
         {
            idb.AddParameter("@LMD_Result", lM_Details.LMD_Result);
         }
         if (string.IsNullOrEmpty(lM_Details.LMD_Remark))
         {
            idb.AddParameter("@LMD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_Remark", lM_Details.LMD_Remark);
         }
         if (lM_Details.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", lM_Details.Stat);
         }
         if (lM_Details.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", lM_Details.CreateDate);
         }
         if (lM_Details.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", lM_Details.UpdateDate);
         }
         if (lM_Details.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", lM_Details.DeleteDate);
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
      /// 更新计量信息 LM_Details对象(即:一条记录
      /// </summary>
      public int Update(LM_Details lM_Details)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       LM_Details       SET ");
            if(lM_Details.LMD_Code_IsChanged){sbParameter.Append("LMD_Code=@LMD_Code, ");}
      if(lM_Details.LMD_MCode_IsChanged){sbParameter.Append("LMD_MCode=@LMD_MCode, ");}
      if(lM_Details.LMD_ItemName_IsChanged){sbParameter.Append("LMD_ItemName=@LMD_ItemName, ");}
      if(lM_Details.LMD_Item_IsChanged){sbParameter.Append("LMD_Item=@LMD_Item, ");}
      if(lM_Details.LMD_Result_IsChanged){sbParameter.Append("LMD_Result=@LMD_Result, ");}
      if(lM_Details.LMD_Remark_IsChanged){sbParameter.Append("LMD_Remark=@LMD_Remark, ");}
      if(lM_Details.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(lM_Details.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(lM_Details.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(lM_Details.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and Measure_ID=@Measure_ID; " );
      string sql=sb.ToString();
         if(lM_Details.LMD_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Details.LMD_Code))
         {
            idb.AddParameter("@LMD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_Code", lM_Details.LMD_Code);
         }
          }
         if(lM_Details.LMD_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Details.LMD_MCode))
         {
            idb.AddParameter("@LMD_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_MCode", lM_Details.LMD_MCode);
         }
          }
         if(lM_Details.LMD_ItemName_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Details.LMD_ItemName))
         {
            idb.AddParameter("@LMD_ItemName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_ItemName", lM_Details.LMD_ItemName);
         }
          }
         if(lM_Details.LMD_Item_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Details.LMD_Item))
         {
            idb.AddParameter("@LMD_Item", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_Item", lM_Details.LMD_Item);
         }
          }
         if(lM_Details.LMD_Result_IsChanged)
         {
         if (lM_Details.LMD_Result == 0)
         {
            idb.AddParameter("@LMD_Result", 0);
         }
         else
         {
            idb.AddParameter("@LMD_Result", lM_Details.LMD_Result);
         }
          }
         if(lM_Details.LMD_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(lM_Details.LMD_Remark))
         {
            idb.AddParameter("@LMD_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@LMD_Remark", lM_Details.LMD_Remark);
         }
          }
         if(lM_Details.Stat_IsChanged)
         {
         if (lM_Details.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", lM_Details.Stat);
         }
          }
         if(lM_Details.CreateDate_IsChanged)
         {
         if (lM_Details.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", lM_Details.CreateDate);
         }
          }
         if(lM_Details.UpdateDate_IsChanged)
         {
         if (lM_Details.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", lM_Details.UpdateDate);
         }
          }
         if(lM_Details.DeleteDate_IsChanged)
         {
         if (lM_Details.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", lM_Details.DeleteDate);
         }
          }

         idb.AddParameter("@Measure_ID", lM_Details.Measure_ID);

           
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
      /// 删除计量信息 LM_Details对象(即:一条记录
      /// </summary>
      public int Delete(decimal measure_ID)
      {
         string sql = "DELETE LM_Details WHERE 1=1  AND Measure_ID=@Measure_ID ";
         idb.AddParameter("@Measure_ID", measure_ID);

           
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
      /// 获取指定的计量信息 LM_Details对象(即:一条记录
      /// </summary>
      public LM_Details GetByKey(decimal measure_ID)
      {
         LM_Details lM_Details = new LM_Details();
         string sql = "SELECT  Measure_ID,LMD_Code,LMD_MCode,LMD_ItemName,LMD_Item,LMD_Result,LMD_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM LM_Details WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND Measure_ID=@Measure_ID ";
         idb.AddParameter("@Measure_ID", measure_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["Measure_ID"] != DBNull.Value) lM_Details.Measure_ID = Convert.ToDecimal(dr["Measure_ID"]);
            if (dr["LMD_Code"] != DBNull.Value) lM_Details.LMD_Code = Convert.ToString(dr["LMD_Code"]);
            if (dr["LMD_MCode"] != DBNull.Value) lM_Details.LMD_MCode = Convert.ToString(dr["LMD_MCode"]);
            if (dr["LMD_ItemName"] != DBNull.Value) lM_Details.LMD_ItemName = Convert.ToString(dr["LMD_ItemName"]);
            if (dr["LMD_Item"] != DBNull.Value) lM_Details.LMD_Item = Convert.ToString(dr["LMD_Item"]);
            if (dr["LMD_Result"] != DBNull.Value) lM_Details.LMD_Result = Convert.ToSingle(dr["LMD_Result"]);
            if (dr["LMD_Remark"] != DBNull.Value) lM_Details.LMD_Remark = Convert.ToString(dr["LMD_Remark"]);
            if (dr["Stat"] != DBNull.Value) lM_Details.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) lM_Details.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) lM_Details.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) lM_Details.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return lM_Details;
      }
      /// <summary>
      /// 获取指定的计量信息 LM_Details对象集合
      /// </summary>
      public List<LM_Details> GetListByWhere(string strCondition)
      {
         List<LM_Details> ret = new List<LM_Details>();
         string sql = "SELECT  Measure_ID,LMD_Code,LMD_MCode,LMD_ItemName,LMD_Item,LMD_Result,LMD_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM LM_Details WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            LM_Details lM_Details = new LM_Details();
            if (dr["Measure_ID"] != DBNull.Value) lM_Details.Measure_ID = Convert.ToDecimal(dr["Measure_ID"]);
            if (dr["LMD_Code"] != DBNull.Value) lM_Details.LMD_Code = Convert.ToString(dr["LMD_Code"]);
            if (dr["LMD_MCode"] != DBNull.Value) lM_Details.LMD_MCode = Convert.ToString(dr["LMD_MCode"]);
            if (dr["LMD_ItemName"] != DBNull.Value) lM_Details.LMD_ItemName = Convert.ToString(dr["LMD_ItemName"]);
            if (dr["LMD_Item"] != DBNull.Value) lM_Details.LMD_Item = Convert.ToString(dr["LMD_Item"]);
            if (dr["LMD_Result"] != DBNull.Value) lM_Details.LMD_Result = Convert.ToSingle(dr["LMD_Result"]);
            if (dr["LMD_Remark"] != DBNull.Value) lM_Details.LMD_Remark = Convert.ToString(dr["LMD_Remark"]);
            if (dr["Stat"] != DBNull.Value) lM_Details.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) lM_Details.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) lM_Details.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) lM_Details.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(lM_Details);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的计量信息 LM_Details对象(即:一条记录
      /// </summary>
      public List<LM_Details> GetAll()
      {
         List<LM_Details> ret = new List<LM_Details>();
         string sql = "SELECT  Measure_ID,LMD_Code,LMD_MCode,LMD_ItemName,LMD_Item,LMD_Result,LMD_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM LM_Details where 1=1 AND ((Stat is null) or (Stat=0) ) order by Measure_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            LM_Details lM_Details = new LM_Details();
            if (dr["Measure_ID"] != DBNull.Value) lM_Details.Measure_ID = Convert.ToDecimal(dr["Measure_ID"]);
            if (dr["LMD_Code"] != DBNull.Value) lM_Details.LMD_Code = Convert.ToString(dr["LMD_Code"]);
            if (dr["LMD_MCode"] != DBNull.Value) lM_Details.LMD_MCode = Convert.ToString(dr["LMD_MCode"]);
            if (dr["LMD_ItemName"] != DBNull.Value) lM_Details.LMD_ItemName = Convert.ToString(dr["LMD_ItemName"]);
            if (dr["LMD_Item"] != DBNull.Value) lM_Details.LMD_Item = Convert.ToString(dr["LMD_Item"]);
            if (dr["LMD_Result"] != DBNull.Value) lM_Details.LMD_Result = Convert.ToSingle(dr["LMD_Result"]);
            if (dr["LMD_Remark"] != DBNull.Value) lM_Details.LMD_Remark = Convert.ToString(dr["LMD_Remark"]);
            if (dr["Stat"] != DBNull.Value) lM_Details.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) lM_Details.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) lM_Details.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) lM_Details.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(lM_Details);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
