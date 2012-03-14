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
   /// 生产线基本信息
   /// </summary>
   [Serializable]
   public partial class ADOPC_BLines
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加生产线基本信息 PC_BLines对象(即:一条记录)
      /// </summary>
      public int Add(PC_BLines pC_BLines)
      {
         string sql = "INSERT INTO PC_BLines (PCBL_Code,PCBL_SCode,PCBL_Name,PCBL_Description,PCBL_Remark,PCBL_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCBL_Code,@PCBL_SCode,@PCBL_Name,@PCBL_Description,@PCBL_Remark,@PCBL_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Code))
         {
            idb.AddParameter("@PCBL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Code", pC_BLines.PCBL_Code);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_SCode))
         {
            idb.AddParameter("@PCBL_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_SCode", pC_BLines.PCBL_SCode);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Name))
         {
            idb.AddParameter("@PCBL_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Name", pC_BLines.PCBL_Name);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Description))
         {
            idb.AddParameter("@PCBL_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Description", pC_BLines.PCBL_Description);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Remark))
         {
            idb.AddParameter("@PCBL_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Remark", pC_BLines.PCBL_Remark);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Stat))
         {
            idb.AddParameter("@PCBL_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Stat", pC_BLines.PCBL_Stat);
         }
         if (pC_BLines.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_BLines.Stat);
         }
         if (pC_BLines.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_BLines.CreateDate);
         }
         if (pC_BLines.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_BLines.UpdateDate);
         }
         if (pC_BLines.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_BLines.DeleteDate);
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
      /// 添加生产线基本信息 PC_BLines对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_BLines pC_BLines)
      {
         string sql = "INSERT INTO PC_BLines (PCBL_Code,PCBL_SCode,PCBL_Name,PCBL_Description,PCBL_Remark,PCBL_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCBL_Code,@PCBL_SCode,@PCBL_Name,@PCBL_Description,@PCBL_Remark,@PCBL_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Code))
         {
            idb.AddParameter("@PCBL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Code", pC_BLines.PCBL_Code);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_SCode))
         {
            idb.AddParameter("@PCBL_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_SCode", pC_BLines.PCBL_SCode);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Name))
         {
            idb.AddParameter("@PCBL_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Name", pC_BLines.PCBL_Name);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Description))
         {
            idb.AddParameter("@PCBL_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Description", pC_BLines.PCBL_Description);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Remark))
         {
            idb.AddParameter("@PCBL_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Remark", pC_BLines.PCBL_Remark);
         }
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Stat))
         {
            idb.AddParameter("@PCBL_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Stat", pC_BLines.PCBL_Stat);
         }
         if (pC_BLines.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_BLines.Stat);
         }
         if (pC_BLines.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_BLines.CreateDate);
         }
         if (pC_BLines.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_BLines.UpdateDate);
         }
         if (pC_BLines.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_BLines.DeleteDate);
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
      /// 更新生产线基本信息 PC_BLines对象(即:一条记录
      /// </summary>
      public int Update(PC_BLines pC_BLines)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_BLines       SET ");
            if(pC_BLines.PCBL_Code_IsChanged){sbParameter.Append("PCBL_Code=@PCBL_Code, ");}
      if(pC_BLines.PCBL_SCode_IsChanged){sbParameter.Append("PCBL_SCode=@PCBL_SCode, ");}
      if(pC_BLines.PCBL_Name_IsChanged){sbParameter.Append("PCBL_Name=@PCBL_Name, ");}
      if(pC_BLines.PCBL_Description_IsChanged){sbParameter.Append("PCBL_Description=@PCBL_Description, ");}
      if(pC_BLines.PCBL_Remark_IsChanged){sbParameter.Append("PCBL_Remark=@PCBL_Remark, ");}
      if(pC_BLines.PCBL_Stat_IsChanged){sbParameter.Append("PCBL_Stat=@PCBL_Stat, ");}
      if(pC_BLines.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_BLines.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_BLines.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_BLines.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCBL_ID=@PCBL_ID; " );
      string sql=sb.ToString();
         if(pC_BLines.PCBL_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Code))
         {
            idb.AddParameter("@PCBL_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Code", pC_BLines.PCBL_Code);
         }
          }
         if(pC_BLines.PCBL_SCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BLines.PCBL_SCode))
         {
            idb.AddParameter("@PCBL_SCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_SCode", pC_BLines.PCBL_SCode);
         }
          }
         if(pC_BLines.PCBL_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Name))
         {
            idb.AddParameter("@PCBL_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Name", pC_BLines.PCBL_Name);
         }
          }
         if(pC_BLines.PCBL_Description_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Description))
         {
            idb.AddParameter("@PCBL_Description", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Description", pC_BLines.PCBL_Description);
         }
          }
         if(pC_BLines.PCBL_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Remark))
         {
            idb.AddParameter("@PCBL_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Remark", pC_BLines.PCBL_Remark);
         }
          }
         if(pC_BLines.PCBL_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_BLines.PCBL_Stat))
         {
            idb.AddParameter("@PCBL_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCBL_Stat", pC_BLines.PCBL_Stat);
         }
          }
         if(pC_BLines.Stat_IsChanged)
         {
         if (pC_BLines.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_BLines.Stat);
         }
          }
         if(pC_BLines.CreateDate_IsChanged)
         {
         if (pC_BLines.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_BLines.CreateDate);
         }
          }
         if(pC_BLines.UpdateDate_IsChanged)
         {
         if (pC_BLines.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_BLines.UpdateDate);
         }
          }
         if(pC_BLines.DeleteDate_IsChanged)
         {
         if (pC_BLines.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_BLines.DeleteDate);
         }
          }

         idb.AddParameter("@PCBL_ID", pC_BLines.PCBL_ID);

           
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
      /// 删除生产线基本信息 PC_BLines对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCBL_ID)
      {
         string sql = "DELETE PC_BLines WHERE 1=1  AND PCBL_ID=@PCBL_ID ";
         idb.AddParameter("@PCBL_ID", pCBL_ID);

           
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
      /// 获取指定的生产线基本信息 PC_BLines对象(即:一条记录
      /// </summary>
      public PC_BLines GetByKey(decimal pCBL_ID)
      {
         PC_BLines pC_BLines = new PC_BLines();
         string sql = "SELECT  PCBL_ID,PCBL_Code,PCBL_SCode,PCBL_Name,PCBL_Description,PCBL_Remark,PCBL_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_BLines WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCBL_ID=@PCBL_ID ";
         idb.AddParameter("@PCBL_ID", pCBL_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCBL_ID"] != DBNull.Value) pC_BLines.PCBL_ID = Convert.ToDecimal(dr["PCBL_ID"]);
            if (dr["PCBL_Code"] != DBNull.Value) pC_BLines.PCBL_Code = Convert.ToString(dr["PCBL_Code"]);
            if (dr["PCBL_SCode"] != DBNull.Value) pC_BLines.PCBL_SCode = Convert.ToString(dr["PCBL_SCode"]);
            if (dr["PCBL_Name"] != DBNull.Value) pC_BLines.PCBL_Name = Convert.ToString(dr["PCBL_Name"]);
            if (dr["PCBL_Description"] != DBNull.Value) pC_BLines.PCBL_Description = Convert.ToString(dr["PCBL_Description"]);
            if (dr["PCBL_Remark"] != DBNull.Value) pC_BLines.PCBL_Remark = Convert.ToString(dr["PCBL_Remark"]);
            if (dr["PCBL_Stat"] != DBNull.Value) pC_BLines.PCBL_Stat = Convert.ToString(dr["PCBL_Stat"]);
            if (dr["Stat"] != DBNull.Value) pC_BLines.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_BLines.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_BLines.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_BLines.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_BLines;
      }
      /// <summary>
      /// 获取指定的生产线基本信息 PC_BLines对象集合
      /// </summary>
      public List<PC_BLines> GetListByWhere(string strCondition)
      {
         List<PC_BLines> ret = new List<PC_BLines>();
         string sql = "SELECT  PCBL_ID,PCBL_Code,PCBL_SCode,PCBL_Name,PCBL_Description,PCBL_Remark,PCBL_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_BLines WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_BLines pC_BLines = new PC_BLines();
            if (dr["PCBL_ID"] != DBNull.Value) pC_BLines.PCBL_ID = Convert.ToDecimal(dr["PCBL_ID"]);
            if (dr["PCBL_Code"] != DBNull.Value) pC_BLines.PCBL_Code = Convert.ToString(dr["PCBL_Code"]);
            if (dr["PCBL_SCode"] != DBNull.Value) pC_BLines.PCBL_SCode = Convert.ToString(dr["PCBL_SCode"]);
            if (dr["PCBL_Name"] != DBNull.Value) pC_BLines.PCBL_Name = Convert.ToString(dr["PCBL_Name"]);
            if (dr["PCBL_Description"] != DBNull.Value) pC_BLines.PCBL_Description = Convert.ToString(dr["PCBL_Description"]);
            if (dr["PCBL_Remark"] != DBNull.Value) pC_BLines.PCBL_Remark = Convert.ToString(dr["PCBL_Remark"]);
            if (dr["PCBL_Stat"] != DBNull.Value) pC_BLines.PCBL_Stat = Convert.ToString(dr["PCBL_Stat"]);
            if (dr["Stat"] != DBNull.Value) pC_BLines.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_BLines.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_BLines.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_BLines.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_BLines);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的生产线基本信息 PC_BLines对象(即:一条记录
      /// </summary>
      public List<PC_BLines> GetAll()
      {
         List<PC_BLines> ret = new List<PC_BLines>();
         string sql = "SELECT  PCBL_ID,PCBL_Code,PCBL_SCode,PCBL_Name,PCBL_Description,PCBL_Remark,PCBL_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_BLines where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCBL_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_BLines pC_BLines = new PC_BLines();
            if (dr["PCBL_ID"] != DBNull.Value) pC_BLines.PCBL_ID = Convert.ToDecimal(dr["PCBL_ID"]);
            if (dr["PCBL_Code"] != DBNull.Value) pC_BLines.PCBL_Code = Convert.ToString(dr["PCBL_Code"]);
            if (dr["PCBL_SCode"] != DBNull.Value) pC_BLines.PCBL_SCode = Convert.ToString(dr["PCBL_SCode"]);
            if (dr["PCBL_Name"] != DBNull.Value) pC_BLines.PCBL_Name = Convert.ToString(dr["PCBL_Name"]);
            if (dr["PCBL_Description"] != DBNull.Value) pC_BLines.PCBL_Description = Convert.ToString(dr["PCBL_Description"]);
            if (dr["PCBL_Remark"] != DBNull.Value) pC_BLines.PCBL_Remark = Convert.ToString(dr["PCBL_Remark"]);
            if (dr["PCBL_Stat"] != DBNull.Value) pC_BLines.PCBL_Stat = Convert.ToString(dr["PCBL_Stat"]);
            if (dr["Stat"] != DBNull.Value) pC_BLines.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_BLines.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_BLines.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_BLines.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_BLines);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
