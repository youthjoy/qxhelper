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
   /// 混凝土信息
   /// </summary>
   [Serializable]
   public partial class ADOPC_Concrete
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加混凝土信息 PC_Concrete对象(即:一条记录)
      /// </summary>
      public int Add(PC_Concrete pC_Concrete)
      {
         string sql = "INSERT INTO PC_Concrete (PCC_Code,PCC_Name,PCC_Level,PCC_SLev,PCC_ZLev,PCC_Spec1,PCC_Spec2,PCC_Minutes,PCC_High,PCC_Low,PCC_Date,PCC_RefPrice,PCC_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCC_Code,@PCC_Name,@PCC_Level,@PCC_SLev,@PCC_ZLev,@PCC_Spec1,@PCC_Spec2,@PCC_Minutes,@PCC_High,@PCC_Low,@PCC_Date,@PCC_RefPrice,@PCC_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Code))
         {
            idb.AddParameter("@PCC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Code", pC_Concrete.PCC_Code);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Name))
         {
            idb.AddParameter("@PCC_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Name", pC_Concrete.PCC_Name);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Level))
         {
            idb.AddParameter("@PCC_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Level", pC_Concrete.PCC_Level);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_SLev))
         {
            idb.AddParameter("@PCC_SLev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_SLev", pC_Concrete.PCC_SLev);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_ZLev))
         {
            idb.AddParameter("@PCC_ZLev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_ZLev", pC_Concrete.PCC_ZLev);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Spec1))
         {
            idb.AddParameter("@PCC_Spec1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Spec1", pC_Concrete.PCC_Spec1);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Spec2))
         {
            idb.AddParameter("@PCC_Spec2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Spec2", pC_Concrete.PCC_Spec2);
         }
         if (pC_Concrete.PCC_Minutes == 0)
         {
            idb.AddParameter("@PCC_Minutes", 0);
         }
         else
         {
            idb.AddParameter("@PCC_Minutes", pC_Concrete.PCC_Minutes);
         }
         if (pC_Concrete.PCC_High == 0)
         {
            idb.AddParameter("@PCC_High", 0);
         }
         else
         {
            idb.AddParameter("@PCC_High", pC_Concrete.PCC_High);
         }
         if (pC_Concrete.PCC_Low == 0)
         {
            idb.AddParameter("@PCC_Low", 0);
         }
         else
         {
            idb.AddParameter("@PCC_Low", pC_Concrete.PCC_Low);
         }
         if (pC_Concrete.PCC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Date", pC_Concrete.PCC_Date);
         }
         if (pC_Concrete.PCC_RefPrice == 0)
         {
            idb.AddParameter("@PCC_RefPrice", 0);
         }
         else
         {
            idb.AddParameter("@PCC_RefPrice", pC_Concrete.PCC_RefPrice);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Bak))
         {
            idb.AddParameter("@PCC_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Bak", pC_Concrete.PCC_Bak);
         }
         if (pC_Concrete.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_Concrete.Stat);
         }
         if (pC_Concrete.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_Concrete.CreateDate);
         }
         if (pC_Concrete.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_Concrete.UpdateDate);
         }
         if (pC_Concrete.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_Concrete.DeleteDate);
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
      /// 添加混凝土信息 PC_Concrete对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PC_Concrete pC_Concrete)
      {
         string sql = "INSERT INTO PC_Concrete (PCC_Code,PCC_Name,PCC_Level,PCC_SLev,PCC_ZLev,PCC_Spec1,PCC_Spec2,PCC_Minutes,PCC_High,PCC_Low,PCC_Date,PCC_RefPrice,PCC_Bak,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCC_Code,@PCC_Name,@PCC_Level,@PCC_SLev,@PCC_ZLev,@PCC_Spec1,@PCC_Spec2,@PCC_Minutes,@PCC_High,@PCC_Low,@PCC_Date,@PCC_RefPrice,@PCC_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Code))
         {
            idb.AddParameter("@PCC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Code", pC_Concrete.PCC_Code);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Name))
         {
            idb.AddParameter("@PCC_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Name", pC_Concrete.PCC_Name);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Level))
         {
            idb.AddParameter("@PCC_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Level", pC_Concrete.PCC_Level);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_SLev))
         {
            idb.AddParameter("@PCC_SLev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_SLev", pC_Concrete.PCC_SLev);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_ZLev))
         {
            idb.AddParameter("@PCC_ZLev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_ZLev", pC_Concrete.PCC_ZLev);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Spec1))
         {
            idb.AddParameter("@PCC_Spec1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Spec1", pC_Concrete.PCC_Spec1);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Spec2))
         {
            idb.AddParameter("@PCC_Spec2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Spec2", pC_Concrete.PCC_Spec2);
         }
         if (pC_Concrete.PCC_Minutes == 0)
         {
            idb.AddParameter("@PCC_Minutes", 0);
         }
         else
         {
            idb.AddParameter("@PCC_Minutes", pC_Concrete.PCC_Minutes);
         }
         if (pC_Concrete.PCC_High == 0)
         {
            idb.AddParameter("@PCC_High", 0);
         }
         else
         {
            idb.AddParameter("@PCC_High", pC_Concrete.PCC_High);
         }
         if (pC_Concrete.PCC_Low == 0)
         {
            idb.AddParameter("@PCC_Low", 0);
         }
         else
         {
            idb.AddParameter("@PCC_Low", pC_Concrete.PCC_Low);
         }
         if (pC_Concrete.PCC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Date", pC_Concrete.PCC_Date);
         }
         if (pC_Concrete.PCC_RefPrice == 0)
         {
            idb.AddParameter("@PCC_RefPrice", 0);
         }
         else
         {
            idb.AddParameter("@PCC_RefPrice", pC_Concrete.PCC_RefPrice);
         }
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Bak))
         {
            idb.AddParameter("@PCC_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Bak", pC_Concrete.PCC_Bak);
         }
         if (pC_Concrete.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_Concrete.Stat);
         }
         if (pC_Concrete.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_Concrete.CreateDate);
         }
         if (pC_Concrete.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_Concrete.UpdateDate);
         }
         if (pC_Concrete.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_Concrete.DeleteDate);
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
      /// 更新混凝土信息 PC_Concrete对象(即:一条记录
      /// </summary>
      public int Update(PC_Concrete pC_Concrete)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PC_Concrete       SET ");
            if(pC_Concrete.PCC_Code_IsChanged){sbParameter.Append("PCC_Code=@PCC_Code, ");}
      if(pC_Concrete.PCC_Name_IsChanged){sbParameter.Append("PCC_Name=@PCC_Name, ");}
      if(pC_Concrete.PCC_Level_IsChanged){sbParameter.Append("PCC_Level=@PCC_Level, ");}
      if(pC_Concrete.PCC_SLev_IsChanged){sbParameter.Append("PCC_SLev=@PCC_SLev, ");}
      if(pC_Concrete.PCC_ZLev_IsChanged){sbParameter.Append("PCC_ZLev=@PCC_ZLev, ");}
      if(pC_Concrete.PCC_Spec1_IsChanged){sbParameter.Append("PCC_Spec1=@PCC_Spec1, ");}
      if(pC_Concrete.PCC_Spec2_IsChanged){sbParameter.Append("PCC_Spec2=@PCC_Spec2, ");}
      if(pC_Concrete.PCC_Minutes_IsChanged){sbParameter.Append("PCC_Minutes=@PCC_Minutes, ");}
      if(pC_Concrete.PCC_High_IsChanged){sbParameter.Append("PCC_High=@PCC_High, ");}
      if(pC_Concrete.PCC_Low_IsChanged){sbParameter.Append("PCC_Low=@PCC_Low, ");}
      if(pC_Concrete.PCC_Date_IsChanged){sbParameter.Append("PCC_Date=@PCC_Date, ");}
      if(pC_Concrete.PCC_RefPrice_IsChanged){sbParameter.Append("PCC_RefPrice=@PCC_RefPrice, ");}
      if(pC_Concrete.PCC_Bak_IsChanged){sbParameter.Append("PCC_Bak=@PCC_Bak, ");}
      if(pC_Concrete.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pC_Concrete.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pC_Concrete.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pC_Concrete.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCC_ID=@PCC_ID; " );
      string sql=sb.ToString();
         if(pC_Concrete.PCC_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Code))
         {
            idb.AddParameter("@PCC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Code", pC_Concrete.PCC_Code);
         }
          }
         if(pC_Concrete.PCC_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Name))
         {
            idb.AddParameter("@PCC_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Name", pC_Concrete.PCC_Name);
         }
          }
         if(pC_Concrete.PCC_Level_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Level))
         {
            idb.AddParameter("@PCC_Level", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Level", pC_Concrete.PCC_Level);
         }
          }
         if(pC_Concrete.PCC_SLev_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Concrete.PCC_SLev))
         {
            idb.AddParameter("@PCC_SLev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_SLev", pC_Concrete.PCC_SLev);
         }
          }
         if(pC_Concrete.PCC_ZLev_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Concrete.PCC_ZLev))
         {
            idb.AddParameter("@PCC_ZLev", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_ZLev", pC_Concrete.PCC_ZLev);
         }
          }
         if(pC_Concrete.PCC_Spec1_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Spec1))
         {
            idb.AddParameter("@PCC_Spec1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Spec1", pC_Concrete.PCC_Spec1);
         }
          }
         if(pC_Concrete.PCC_Spec2_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Spec2))
         {
            idb.AddParameter("@PCC_Spec2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Spec2", pC_Concrete.PCC_Spec2);
         }
          }
         if(pC_Concrete.PCC_Minutes_IsChanged)
         {
         if (pC_Concrete.PCC_Minutes == 0)
         {
            idb.AddParameter("@PCC_Minutes", 0);
         }
         else
         {
            idb.AddParameter("@PCC_Minutes", pC_Concrete.PCC_Minutes);
         }
          }
         if(pC_Concrete.PCC_High_IsChanged)
         {
         if (pC_Concrete.PCC_High == 0)
         {
            idb.AddParameter("@PCC_High", 0);
         }
         else
         {
            idb.AddParameter("@PCC_High", pC_Concrete.PCC_High);
         }
          }
         if(pC_Concrete.PCC_Low_IsChanged)
         {
         if (pC_Concrete.PCC_Low == 0)
         {
            idb.AddParameter("@PCC_Low", 0);
         }
         else
         {
            idb.AddParameter("@PCC_Low", pC_Concrete.PCC_Low);
         }
          }
         if(pC_Concrete.PCC_Date_IsChanged)
         {
         if (pC_Concrete.PCC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Date", pC_Concrete.PCC_Date);
         }
          }
         if(pC_Concrete.PCC_RefPrice_IsChanged)
         {
         if (pC_Concrete.PCC_RefPrice == 0)
         {
            idb.AddParameter("@PCC_RefPrice", 0);
         }
         else
         {
            idb.AddParameter("@PCC_RefPrice", pC_Concrete.PCC_RefPrice);
         }
          }
         if(pC_Concrete.PCC_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(pC_Concrete.PCC_Bak))
         {
            idb.AddParameter("@PCC_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCC_Bak", pC_Concrete.PCC_Bak);
         }
          }
         if(pC_Concrete.Stat_IsChanged)
         {
         if (pC_Concrete.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pC_Concrete.Stat);
         }
          }
         if(pC_Concrete.CreateDate_IsChanged)
         {
         if (pC_Concrete.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pC_Concrete.CreateDate);
         }
          }
         if(pC_Concrete.UpdateDate_IsChanged)
         {
         if (pC_Concrete.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pC_Concrete.UpdateDate);
         }
          }
         if(pC_Concrete.DeleteDate_IsChanged)
         {
         if (pC_Concrete.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pC_Concrete.DeleteDate);
         }
          }

         idb.AddParameter("@PCC_ID", pC_Concrete.PCC_ID);

           
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
      /// 删除混凝土信息 PC_Concrete对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCC_ID)
      {
         string sql = "DELETE PC_Concrete WHERE 1=1  AND PCC_ID=@PCC_ID ";
         idb.AddParameter("@PCC_ID", pCC_ID);

           
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
      /// 获取指定的混凝土信息 PC_Concrete对象(即:一条记录
      /// </summary>
      public PC_Concrete GetByKey(decimal pCC_ID)
      {
         PC_Concrete pC_Concrete = new PC_Concrete();
         string sql = "SELECT  PCC_ID,PCC_Code,PCC_Name,PCC_Level,PCC_SLev,PCC_ZLev,PCC_Spec1,PCC_Spec2,PCC_Minutes,PCC_High,PCC_Low,PCC_Date,PCC_RefPrice,PCC_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_Concrete WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCC_ID=@PCC_ID ";
         idb.AddParameter("@PCC_ID", pCC_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCC_ID"] != DBNull.Value) pC_Concrete.PCC_ID = Convert.ToDecimal(dr["PCC_ID"]);
            if (dr["PCC_Code"] != DBNull.Value) pC_Concrete.PCC_Code = Convert.ToString(dr["PCC_Code"]);
            if (dr["PCC_Name"] != DBNull.Value) pC_Concrete.PCC_Name = Convert.ToString(dr["PCC_Name"]);
            if (dr["PCC_Level"] != DBNull.Value) pC_Concrete.PCC_Level = Convert.ToString(dr["PCC_Level"]);
            if (dr["PCC_SLev"] != DBNull.Value) pC_Concrete.PCC_SLev = Convert.ToString(dr["PCC_SLev"]);
            if (dr["PCC_ZLev"] != DBNull.Value) pC_Concrete.PCC_ZLev = Convert.ToString(dr["PCC_ZLev"]);
            if (dr["PCC_Spec1"] != DBNull.Value) pC_Concrete.PCC_Spec1 = Convert.ToString(dr["PCC_Spec1"]);
            if (dr["PCC_Spec2"] != DBNull.Value) pC_Concrete.PCC_Spec2 = Convert.ToString(dr["PCC_Spec2"]);
            if (dr["PCC_Minutes"] != DBNull.Value) pC_Concrete.PCC_Minutes = Convert.ToInt32(dr["PCC_Minutes"]);
            if (dr["PCC_High"] != DBNull.Value) pC_Concrete.PCC_High = Convert.ToInt32(dr["PCC_High"]);
            if (dr["PCC_Low"] != DBNull.Value) pC_Concrete.PCC_Low = Convert.ToInt32(dr["PCC_Low"]);
            if (dr["PCC_Date"] != DBNull.Value) pC_Concrete.PCC_Date = Convert.ToDateTime(dr["PCC_Date"]);
            if (dr["PCC_RefPrice"] != DBNull.Value) pC_Concrete.PCC_RefPrice = Convert.ToDecimal(dr["PCC_RefPrice"]);
            if (dr["PCC_Bak"] != DBNull.Value) pC_Concrete.PCC_Bak = Convert.ToString(dr["PCC_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_Concrete.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_Concrete.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_Concrete.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_Concrete.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pC_Concrete;
      }
      /// <summary>
      /// 获取指定的混凝土信息 PC_Concrete对象集合
      /// </summary>
      public List<PC_Concrete> GetListByWhere(string strCondition)
      {
         List<PC_Concrete> ret = new List<PC_Concrete>();
         string sql = "SELECT  PCC_ID,PCC_Code,PCC_Name,PCC_Level,PCC_SLev,PCC_ZLev,PCC_Spec1,PCC_Spec2,PCC_Minutes,PCC_High,PCC_Low,PCC_Date,PCC_RefPrice,PCC_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_Concrete WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PC_Concrete pC_Concrete = new PC_Concrete();
            if (dr["PCC_ID"] != DBNull.Value) pC_Concrete.PCC_ID = Convert.ToDecimal(dr["PCC_ID"]);
            if (dr["PCC_Code"] != DBNull.Value) pC_Concrete.PCC_Code = Convert.ToString(dr["PCC_Code"]);
            if (dr["PCC_Name"] != DBNull.Value) pC_Concrete.PCC_Name = Convert.ToString(dr["PCC_Name"]);
            if (dr["PCC_Level"] != DBNull.Value) pC_Concrete.PCC_Level = Convert.ToString(dr["PCC_Level"]);
            if (dr["PCC_SLev"] != DBNull.Value) pC_Concrete.PCC_SLev = Convert.ToString(dr["PCC_SLev"]);
            if (dr["PCC_ZLev"] != DBNull.Value) pC_Concrete.PCC_ZLev = Convert.ToString(dr["PCC_ZLev"]);
            if (dr["PCC_Spec1"] != DBNull.Value) pC_Concrete.PCC_Spec1 = Convert.ToString(dr["PCC_Spec1"]);
            if (dr["PCC_Spec2"] != DBNull.Value) pC_Concrete.PCC_Spec2 = Convert.ToString(dr["PCC_Spec2"]);
            if (dr["PCC_Minutes"] != DBNull.Value) pC_Concrete.PCC_Minutes = Convert.ToInt32(dr["PCC_Minutes"]);
            if (dr["PCC_High"] != DBNull.Value) pC_Concrete.PCC_High = Convert.ToInt32(dr["PCC_High"]);
            if (dr["PCC_Low"] != DBNull.Value) pC_Concrete.PCC_Low = Convert.ToInt32(dr["PCC_Low"]);
            if (dr["PCC_Date"] != DBNull.Value) pC_Concrete.PCC_Date = Convert.ToDateTime(dr["PCC_Date"]);
            if (dr["PCC_RefPrice"] != DBNull.Value) pC_Concrete.PCC_RefPrice = Convert.ToDecimal(dr["PCC_RefPrice"]);
            if (dr["PCC_Bak"] != DBNull.Value) pC_Concrete.PCC_Bak = Convert.ToString(dr["PCC_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_Concrete.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_Concrete.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_Concrete.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_Concrete.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_Concrete);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的混凝土信息 PC_Concrete对象(即:一条记录
      /// </summary>
      public List<PC_Concrete> GetAll()
      {
         List<PC_Concrete> ret = new List<PC_Concrete>();
         string sql = "SELECT  PCC_ID,PCC_Code,PCC_Name,PCC_Level,PCC_SLev,PCC_ZLev,PCC_Spec1,PCC_Spec2,PCC_Minutes,PCC_High,PCC_Low,PCC_Date,PCC_RefPrice,PCC_Bak,Stat,CreateDate,UpdateDate,DeleteDate FROM PC_Concrete where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCC_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PC_Concrete pC_Concrete = new PC_Concrete();
            if (dr["PCC_ID"] != DBNull.Value) pC_Concrete.PCC_ID = Convert.ToDecimal(dr["PCC_ID"]);
            if (dr["PCC_Code"] != DBNull.Value) pC_Concrete.PCC_Code = Convert.ToString(dr["PCC_Code"]);
            if (dr["PCC_Name"] != DBNull.Value) pC_Concrete.PCC_Name = Convert.ToString(dr["PCC_Name"]);
            if (dr["PCC_Level"] != DBNull.Value) pC_Concrete.PCC_Level = Convert.ToString(dr["PCC_Level"]);
            if (dr["PCC_SLev"] != DBNull.Value) pC_Concrete.PCC_SLev = Convert.ToString(dr["PCC_SLev"]);
            if (dr["PCC_ZLev"] != DBNull.Value) pC_Concrete.PCC_ZLev = Convert.ToString(dr["PCC_ZLev"]);
            if (dr["PCC_Spec1"] != DBNull.Value) pC_Concrete.PCC_Spec1 = Convert.ToString(dr["PCC_Spec1"]);
            if (dr["PCC_Spec2"] != DBNull.Value) pC_Concrete.PCC_Spec2 = Convert.ToString(dr["PCC_Spec2"]);
            if (dr["PCC_Minutes"] != DBNull.Value) pC_Concrete.PCC_Minutes = Convert.ToInt32(dr["PCC_Minutes"]);
            if (dr["PCC_High"] != DBNull.Value) pC_Concrete.PCC_High = Convert.ToInt32(dr["PCC_High"]);
            if (dr["PCC_Low"] != DBNull.Value) pC_Concrete.PCC_Low = Convert.ToInt32(dr["PCC_Low"]);
            if (dr["PCC_Date"] != DBNull.Value) pC_Concrete.PCC_Date = Convert.ToDateTime(dr["PCC_Date"]);
            if (dr["PCC_RefPrice"] != DBNull.Value) pC_Concrete.PCC_RefPrice = Convert.ToDecimal(dr["PCC_RefPrice"]);
            if (dr["PCC_Bak"] != DBNull.Value) pC_Concrete.PCC_Bak = Convert.ToString(dr["PCC_Bak"]);
            if (dr["Stat"] != DBNull.Value) pC_Concrete.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pC_Concrete.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pC_Concrete.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pC_Concrete.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pC_Concrete);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
