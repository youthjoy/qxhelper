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
   /// 生产线关联仓库
   /// </summary>
   [Serializable]
   public partial class ADOPC_BWarehouse
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产线关联仓库 PC_BWarehouse对象(即:一条记录)
      /// </summary>
      public int Add(PC_BWarehouse pC_BWarehouse)
      {
         string sql = "INSERT INTO PC_BWarehouse (PCBW_Code,PCBW_LCode,PCBW_RefWCode,PCBW_WNo,PCBW_MCode,PCBW_MName,PCBW_Contain,PCBW_Order,PCBW_Bak,PCBW_TCode,PCBW_TName,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCBW_Code,@PCBW_LCode,@PCBW_RefWCode,@PCBW_WNo,@PCBW_MCode,@PCBW_MName,@PCBW_Contain,@PCBW_Order,@PCBW_Bak,@PCBW_TCode,@PCBW_TName,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_Code))
         {
            idb.AddParameter("@PCBW_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_Code", pC_BWarehouse.PCBW_Code);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_LCode))
         {
            idb.AddParameter("@PCBW_LCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_LCode", pC_BWarehouse.PCBW_LCode);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_RefWCode))
         {
            idb.AddParameter("@PCBW_RefWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_RefWCode", pC_BWarehouse.PCBW_RefWCode);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_WNo))
         {
            idb.AddParameter("@PCBW_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_WNo", pC_BWarehouse.PCBW_WNo);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_MCode))
         {
            idb.AddParameter("@PCBW_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_MCode", pC_BWarehouse.PCBW_MCode);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_MName))
         {
            idb.AddParameter("@PCBW_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_MName", pC_BWarehouse.PCBW_MName);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_Contain))
         {
            idb.AddParameter("@PCBW_Contain", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_Contain", pC_BWarehouse.PCBW_Contain);
         }
         if (pC_BWarehouse.PCBW_Order == 0)
         {
            idb.AddParameter("@PCBW_Order", 0);
         }
         else
         {
            idb.AddParameter("@PCBW_Order", pC_BWarehouse.PCBW_Order);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_Bak))
         {
            idb.AddParameter("@PCBW_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_Bak", pC_BWarehouse.PCBW_Bak);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_TCode))
         {
            idb.AddParameter("@PCBW_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_TCode", pC_BWarehouse.PCBW_TCode);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_TName))
         {
            idb.AddParameter("@PCBW_TName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_TName", pC_BWarehouse.PCBW_TName);
         }
         if (pC_BWarehouse.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_BWarehouse.Stat);
         }
         if (pC_BWarehouse.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_BWarehouse.CreateDate);
         }
         if (pC_BWarehouse.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_BWarehouse.UpdateDate);
         }
         if (pC_BWarehouse.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_BWarehouse.DeleteDate);
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
      /// 添加生产线关联仓库 PC_BWarehouse对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_BWarehouse pC_BWarehouse)
      {
         string sql = "INSERT INTO PC_BWarehouse (PCBW_Code,PCBW_LCode,PCBW_RefWCode,PCBW_WNo,PCBW_MCode,PCBW_MName,PCBW_Contain,PCBW_Order,PCBW_Bak,PCBW_TCode,PCBW_TName,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCBW_Code,@PCBW_LCode,@PCBW_RefWCode,@PCBW_WNo,@PCBW_MCode,@PCBW_MName,@PCBW_Contain,@PCBW_Order,@PCBW_Bak,@PCBW_TCode,@PCBW_TName,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_Code))
         {
            idb.AddParameter("@PCBW_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_Code", pC_BWarehouse.PCBW_Code);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_LCode))
         {
            idb.AddParameter("@PCBW_LCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_LCode", pC_BWarehouse.PCBW_LCode);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_RefWCode))
         {
            idb.AddParameter("@PCBW_RefWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_RefWCode", pC_BWarehouse.PCBW_RefWCode);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_WNo))
         {
            idb.AddParameter("@PCBW_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_WNo", pC_BWarehouse.PCBW_WNo);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_MCode))
         {
            idb.AddParameter("@PCBW_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_MCode", pC_BWarehouse.PCBW_MCode);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_MName))
         {
            idb.AddParameter("@PCBW_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_MName", pC_BWarehouse.PCBW_MName);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_Contain))
         {
            idb.AddParameter("@PCBW_Contain", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_Contain", pC_BWarehouse.PCBW_Contain);
         }
         if (pC_BWarehouse.PCBW_Order == 0)
         {
            idb.AddParameter("@PCBW_Order", 0);
         }
         else
         {
            idb.AddParameter("@PCBW_Order", pC_BWarehouse.PCBW_Order);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_Bak))
         {
            idb.AddParameter("@PCBW_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_Bak", pC_BWarehouse.PCBW_Bak);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_TCode))
         {
            idb.AddParameter("@PCBW_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_TCode", pC_BWarehouse.PCBW_TCode);
         }
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_TName))
         {
            idb.AddParameter("@PCBW_TName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_TName", pC_BWarehouse.PCBW_TName);
         }
         if (pC_BWarehouse.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_BWarehouse.Stat);
         }
         if (pC_BWarehouse.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_BWarehouse.CreateDate);
         }
         if (pC_BWarehouse.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_BWarehouse.UpdateDate);
         }
         if (pC_BWarehouse.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_BWarehouse.DeleteDate);
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
      /// 更新生产线关联仓库 PC_BWarehouse对象(即:一条记录
      /// </summary>
      public int Update(PC_BWarehouse pC_BWarehouse)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_BWarehouse       SET ");
            if(pC_BWarehouse.PCBW_Code_IsChanged){sbParameter.Append("PCBW_Code=@PCBW_Code, ");}
      if(pC_BWarehouse.PCBW_LCode_IsChanged){sbParameter.Append("PCBW_LCode=@PCBW_LCode, ");}
      if(pC_BWarehouse.PCBW_RefWCode_IsChanged){sbParameter.Append("PCBW_RefWCode=@PCBW_RefWCode, ");}
      if(pC_BWarehouse.PCBW_WNo_IsChanged){sbParameter.Append("PCBW_WNo=@PCBW_WNo, ");}
      if(pC_BWarehouse.PCBW_MCode_IsChanged){sbParameter.Append("PCBW_MCode=@PCBW_MCode, ");}
      if(pC_BWarehouse.PCBW_MName_IsChanged){sbParameter.Append("PCBW_MName=@PCBW_MName, ");}
      if(pC_BWarehouse.PCBW_Contain_IsChanged){sbParameter.Append("PCBW_Contain=@PCBW_Contain, ");}
      if(pC_BWarehouse.PCBW_Order_IsChanged){sbParameter.Append("PCBW_Order=@PCBW_Order, ");}
      if(pC_BWarehouse.PCBW_Bak_IsChanged){sbParameter.Append("PCBW_Bak=@PCBW_Bak, ");}
      if(pC_BWarehouse.PCBW_TCode_IsChanged){sbParameter.Append("PCBW_TCode=@PCBW_TCode, ");}
      if(pC_BWarehouse.PCBW_TName_IsChanged){sbParameter.Append("PCBW_TName=@PCBW_TName, ");}
      if(pC_BWarehouse.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_BWarehouse.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_BWarehouse.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_BWarehouse.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCBW_ID=@PCBW_ID; " );
      string sql=sb.ToString();
         if(pC_BWarehouse.PCBW_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_Code))
         {
            idb.AddParameter("@PCBW_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_Code", pC_BWarehouse.PCBW_Code);
         }
          }
         if(pC_BWarehouse.PCBW_LCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_LCode))
         {
            idb.AddParameter("@PCBW_LCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_LCode", pC_BWarehouse.PCBW_LCode);
         }
          }
         if(pC_BWarehouse.PCBW_RefWCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_RefWCode))
         {
            idb.AddParameter("@PCBW_RefWCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_RefWCode", pC_BWarehouse.PCBW_RefWCode);
         }
          }
         if(pC_BWarehouse.PCBW_WNo_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_WNo))
         {
            idb.AddParameter("@PCBW_WNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_WNo", pC_BWarehouse.PCBW_WNo);
         }
          }
         if(pC_BWarehouse.PCBW_MCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_MCode))
         {
            idb.AddParameter("@PCBW_MCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_MCode", pC_BWarehouse.PCBW_MCode);
         }
          }
         if(pC_BWarehouse.PCBW_MName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_MName))
         {
            idb.AddParameter("@PCBW_MName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_MName", pC_BWarehouse.PCBW_MName);
         }
          }
         if(pC_BWarehouse.PCBW_Contain_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_Contain))
         {
            idb.AddParameter("@PCBW_Contain", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_Contain", pC_BWarehouse.PCBW_Contain);
         }
          }
         if(pC_BWarehouse.PCBW_Order_IsChanged)
         {
         if (pC_BWarehouse.PCBW_Order == 0)
         {
            idb.AddParameter("@PCBW_Order", 0);
         }
         else
         {
            idb.AddParameter("@PCBW_Order", pC_BWarehouse.PCBW_Order);
         }
          }
         if(pC_BWarehouse.PCBW_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_Bak))
         {
            idb.AddParameter("@PCBW_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_Bak", pC_BWarehouse.PCBW_Bak);
         }
          }
         if(pC_BWarehouse.PCBW_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_TCode))
         {
            idb.AddParameter("@PCBW_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_TCode", pC_BWarehouse.PCBW_TCode);
         }
          }
         if(pC_BWarehouse.PCBW_TName_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BWarehouse.PCBW_TName))
         {
            idb.AddParameter("@PCBW_TName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBW_TName", pC_BWarehouse.PCBW_TName);
         }
          }
         if(pC_BWarehouse.Stat_IsChanged)
         {
         if (pC_BWarehouse.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_BWarehouse.Stat);
         }
          }
         if(pC_BWarehouse.CreateDate_IsChanged)
         {
         if (pC_BWarehouse.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_BWarehouse.CreateDate);
         }
          }
         if(pC_BWarehouse.UpdateDate_IsChanged)
         {
         if (pC_BWarehouse.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_BWarehouse.UpdateDate);
         }
          }
         if(pC_BWarehouse.DeleteDate_IsChanged)
         {
         if (pC_BWarehouse.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_BWarehouse.DeleteDate);
         }
          }

         idb.AddParameter("@PCBW_ID", pC_BWarehouse.PCBW_ID);

           
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
      /// 删除生产线关联仓库 PC_BWarehouse对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCBW_ID)
      {
         string sql = "DELETE PC_BWarehouse WHERE 1=1  AND PCBW_ID=@PCBW_ID ";
         idb.AddParameter("@PCBW_ID", pCBW_ID);

           
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
      /// 获取指定的生产线关联仓库 PC_BWarehouse对象(即:一条记录
      /// </summary>
      public PC_BWarehouse GetByKey(decimal pCBW_ID)
      {
         PC_BWarehouse pC_BWarehouse = new PC_BWarehouse();
         string sql = "SELECT  PCBW_ID,PCBW_Code,PCBW_LCode,PCBW_RefWCode,PCBW_WNo,PCBW_MCode,PCBW_MName,PCBW_Contain,PCBW_Order,PCBW_Bak,PCBW_TCode,PCBW_TName,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_BWarehouse WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCBW_ID=@PCBW_ID ";
         idb.AddParameter("@PCBW_ID", pCBW_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCBW_ID"] != DBNull.Value) pC_BWarehouse.PCBW_ID = Convert.ToDecimal(dr["PCBW_ID"]);
            if (dr["PCBW_Code"] != DBNull.Value) pC_BWarehouse.PCBW_Code = Convert.ToString(dr["PCBW_Code"]);
            if (dr["PCBW_LCode"] != DBNull.Value) pC_BWarehouse.PCBW_LCode = Convert.ToString(dr["PCBW_LCode"]);
            if (dr["PCBW_RefWCode"] != DBNull.Value) pC_BWarehouse.PCBW_RefWCode = Convert.ToString(dr["PCBW_RefWCode"]);
            if (dr["PCBW_WNo"] != DBNull.Value) pC_BWarehouse.PCBW_WNo = Convert.ToString(dr["PCBW_WNo"]);
            if (dr["PCBW_MCode"] != DBNull.Value) pC_BWarehouse.PCBW_MCode = Convert.ToString(dr["PCBW_MCode"]);
            if (dr["PCBW_MName"] != DBNull.Value) pC_BWarehouse.PCBW_MName = Convert.ToString(dr["PCBW_MName"]);
            if (dr["PCBW_Contain"] != DBNull.Value) pC_BWarehouse.PCBW_Contain = Convert.ToString(dr["PCBW_Contain"]);
            if (dr["PCBW_Order"] != DBNull.Value) pC_BWarehouse.PCBW_Order = Convert.ToInt32(dr["PCBW_Order"]);
            if (dr["PCBW_Bak"] != DBNull.Value) pC_BWarehouse.PCBW_Bak = Convert.ToString(dr["PCBW_Bak"]);
            if (dr["PCBW_TCode"] != DBNull.Value) pC_BWarehouse.PCBW_TCode = Convert.ToString(dr["PCBW_TCode"]);
            if (dr["PCBW_TName"] != DBNull.Value) pC_BWarehouse.PCBW_TName = Convert.ToString(dr["PCBW_TName"]);
            if (dr["Stat"] != DBNull.Value) pC_BWarehouse.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_BWarehouse.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_BWarehouse.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_BWarehouse.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_BWarehouse;
      }
      /// <summary>
      /// 获取指定的生产线关联仓库 PC_BWarehouse对象集合
      /// </summary>
      public List<PC_BWarehouse> GetListByWhere(string strCondition)
      {
         List<PC_BWarehouse> ret = new List<PC_BWarehouse>();
         string sql = "SELECT  PCBW_ID,PCBW_Code,PCBW_LCode,PCBW_RefWCode,PCBW_WNo,PCBW_MCode,PCBW_MName,PCBW_Contain,PCBW_Order,PCBW_Bak,PCBW_TCode,PCBW_TName,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_BWarehouse WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_BWarehouse pC_BWarehouse = new PC_BWarehouse();
            if (dr["PCBW_ID"] != DBNull.Value) pC_BWarehouse.PCBW_ID = Convert.ToDecimal(dr["PCBW_ID"]);
            if (dr["PCBW_Code"] != DBNull.Value) pC_BWarehouse.PCBW_Code = Convert.ToString(dr["PCBW_Code"]);
            if (dr["PCBW_LCode"] != DBNull.Value) pC_BWarehouse.PCBW_LCode = Convert.ToString(dr["PCBW_LCode"]);
            if (dr["PCBW_RefWCode"] != DBNull.Value) pC_BWarehouse.PCBW_RefWCode = Convert.ToString(dr["PCBW_RefWCode"]);
            if (dr["PCBW_WNo"] != DBNull.Value) pC_BWarehouse.PCBW_WNo = Convert.ToString(dr["PCBW_WNo"]);
            if (dr["PCBW_MCode"] != DBNull.Value) pC_BWarehouse.PCBW_MCode = Convert.ToString(dr["PCBW_MCode"]);
            if (dr["PCBW_MName"] != DBNull.Value) pC_BWarehouse.PCBW_MName = Convert.ToString(dr["PCBW_MName"]);
            if (dr["PCBW_Contain"] != DBNull.Value) pC_BWarehouse.PCBW_Contain = Convert.ToString(dr["PCBW_Contain"]);
            if (dr["PCBW_Order"] != DBNull.Value) pC_BWarehouse.PCBW_Order = Convert.ToInt32(dr["PCBW_Order"]);
            if (dr["PCBW_Bak"] != DBNull.Value) pC_BWarehouse.PCBW_Bak = Convert.ToString(dr["PCBW_Bak"]);
            if (dr["PCBW_TCode"] != DBNull.Value) pC_BWarehouse.PCBW_TCode = Convert.ToString(dr["PCBW_TCode"]);
            if (dr["PCBW_TName"] != DBNull.Value) pC_BWarehouse.PCBW_TName = Convert.ToString(dr["PCBW_TName"]);
            if (dr["Stat"] != DBNull.Value) pC_BWarehouse.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_BWarehouse.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_BWarehouse.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_BWarehouse.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_BWarehouse);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产线关联仓库 PC_BWarehouse对象(即:一条记录
      /// </summary>
      public List<PC_BWarehouse> GetAll()
      {
         List<PC_BWarehouse> ret = new List<PC_BWarehouse>();
         string sql = "SELECT  PCBW_ID,PCBW_Code,PCBW_LCode,PCBW_RefWCode,PCBW_WNo,PCBW_MCode,PCBW_MName,PCBW_Contain,PCBW_Order,PCBW_Bak,PCBW_TCode,PCBW_TName,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_BWarehouse where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCBW_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_BWarehouse pC_BWarehouse = new PC_BWarehouse();
            if (dr["PCBW_ID"] != DBNull.Value) pC_BWarehouse.PCBW_ID = Convert.ToDecimal(dr["PCBW_ID"]);
            if (dr["PCBW_Code"] != DBNull.Value) pC_BWarehouse.PCBW_Code = Convert.ToString(dr["PCBW_Code"]);
            if (dr["PCBW_LCode"] != DBNull.Value) pC_BWarehouse.PCBW_LCode = Convert.ToString(dr["PCBW_LCode"]);
            if (dr["PCBW_RefWCode"] != DBNull.Value) pC_BWarehouse.PCBW_RefWCode = Convert.ToString(dr["PCBW_RefWCode"]);
            if (dr["PCBW_WNo"] != DBNull.Value) pC_BWarehouse.PCBW_WNo = Convert.ToString(dr["PCBW_WNo"]);
            if (dr["PCBW_MCode"] != DBNull.Value) pC_BWarehouse.PCBW_MCode = Convert.ToString(dr["PCBW_MCode"]);
            if (dr["PCBW_MName"] != DBNull.Value) pC_BWarehouse.PCBW_MName = Convert.ToString(dr["PCBW_MName"]);
            if (dr["PCBW_Contain"] != DBNull.Value) pC_BWarehouse.PCBW_Contain = Convert.ToString(dr["PCBW_Contain"]);
            if (dr["PCBW_Order"] != DBNull.Value) pC_BWarehouse.PCBW_Order = Convert.ToInt32(dr["PCBW_Order"]);
            if (dr["PCBW_Bak"] != DBNull.Value) pC_BWarehouse.PCBW_Bak = Convert.ToString(dr["PCBW_Bak"]);
            if (dr["PCBW_TCode"] != DBNull.Value) pC_BWarehouse.PCBW_TCode = Convert.ToString(dr["PCBW_TCode"]);
            if (dr["PCBW_TName"] != DBNull.Value) pC_BWarehouse.PCBW_TName = Convert.ToString(dr["PCBW_TName"]);
            if (dr["Stat"] != DBNull.Value) pC_BWarehouse.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_BWarehouse.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_BWarehouse.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_BWarehouse.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_BWarehouse);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
