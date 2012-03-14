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
   /// 打罐记录
   /// </summary>
   [Serializable]
   public partial class ADOPCT_Clear
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加打罐记录 PCT_Clear对象(即:一条记录)
      /// </summary>
      public int Add(PCT_Clear pCT_Clear)
      {
         string sql = "INSERT INTO PCT_Clear (PCTC_Code,PCTC_GCode,PCTC_GNo,PCTC_BBak,PCTC_BWeight,PCTC_ABak,PCTC_AWeight,PCTC_Unit,PCTC_Date,PCTC_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCTC_iType,PCTC_TCode,PCTC_Udef2,PCTC_Udef3) VALUES (@PCTC_Code,@PCTC_GCode,@PCTC_GNo,@PCTC_BBak,@PCTC_BWeight,@PCTC_ABak,@PCTC_AWeight,@PCTC_Unit,@PCTC_Date,@PCTC_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCTC_iType,@PCTC_TCode,@PCTC_Udef2,@PCTC_Udef3)";
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Code))
         {
            idb.AddParameter("@PCTC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Code", pCT_Clear.PCTC_Code);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_GCode))
         {
            idb.AddParameter("@PCTC_GCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_GCode", pCT_Clear.PCTC_GCode);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_GNo))
         {
            idb.AddParameter("@PCTC_GNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_GNo", pCT_Clear.PCTC_GNo);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_BBak))
         {
            idb.AddParameter("@PCTC_BBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_BBak", pCT_Clear.PCTC_BBak);
         }
         if (pCT_Clear.PCTC_BWeight == 0)
         {
            idb.AddParameter("@PCTC_BWeight", 0);
         }
         else
         {
            idb.AddParameter("@PCTC_BWeight", pCT_Clear.PCTC_BWeight);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_ABak))
         {
            idb.AddParameter("@PCTC_ABak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_ABak", pCT_Clear.PCTC_ABak);
         }
         if (pCT_Clear.PCTC_AWeight == 0)
         {
            idb.AddParameter("@PCTC_AWeight", 0);
         }
         else
         {
            idb.AddParameter("@PCTC_AWeight", pCT_Clear.PCTC_AWeight);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Unit))
         {
            idb.AddParameter("@PCTC_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Unit", pCT_Clear.PCTC_Unit);
         }
         if (pCT_Clear.PCTC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCTC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Date", pCT_Clear.PCTC_Date);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Bak))
         {
            idb.AddParameter("@PCTC_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Bak", pCT_Clear.PCTC_Bak);
         }
         if (pCT_Clear.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Clear.Stat);
         }
         if (pCT_Clear.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Clear.CreateDate);
         }
         if (pCT_Clear.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Clear.UpdateDate);
         }
         if (pCT_Clear.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Clear.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_iType))
         {
            idb.AddParameter("@PCTC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_iType", pCT_Clear.PCTC_iType);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_TCode))
         {
            idb.AddParameter("@PCTC_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_TCode", pCT_Clear.PCTC_TCode);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Udef2))
         {
            idb.AddParameter("@PCTC_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Udef2", pCT_Clear.PCTC_Udef2);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Udef3))
         {
            idb.AddParameter("@PCTC_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Udef3", pCT_Clear.PCTC_Udef3);
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
      /// 添加打罐记录 PCT_Clear对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCT_Clear pCT_Clear)
      {
         string sql = "INSERT INTO PCT_Clear (PCTC_Code,PCTC_GCode,PCTC_GNo,PCTC_BBak,PCTC_BWeight,PCTC_ABak,PCTC_AWeight,PCTC_Unit,PCTC_Date,PCTC_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCTC_iType,PCTC_TCode,PCTC_Udef2,PCTC_Udef3) VALUES (@PCTC_Code,@PCTC_GCode,@PCTC_GNo,@PCTC_BBak,@PCTC_BWeight,@PCTC_ABak,@PCTC_AWeight,@PCTC_Unit,@PCTC_Date,@PCTC_Bak,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCTC_iType,@PCTC_TCode,@PCTC_Udef2,@PCTC_Udef3);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Code))
         {
            idb.AddParameter("@PCTC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Code", pCT_Clear.PCTC_Code);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_GCode))
         {
            idb.AddParameter("@PCTC_GCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_GCode", pCT_Clear.PCTC_GCode);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_GNo))
         {
            idb.AddParameter("@PCTC_GNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_GNo", pCT_Clear.PCTC_GNo);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_BBak))
         {
            idb.AddParameter("@PCTC_BBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_BBak", pCT_Clear.PCTC_BBak);
         }
         if (pCT_Clear.PCTC_BWeight == 0)
         {
            idb.AddParameter("@PCTC_BWeight", 0);
         }
         else
         {
            idb.AddParameter("@PCTC_BWeight", pCT_Clear.PCTC_BWeight);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_ABak))
         {
            idb.AddParameter("@PCTC_ABak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_ABak", pCT_Clear.PCTC_ABak);
         }
         if (pCT_Clear.PCTC_AWeight == 0)
         {
            idb.AddParameter("@PCTC_AWeight", 0);
         }
         else
         {
            idb.AddParameter("@PCTC_AWeight", pCT_Clear.PCTC_AWeight);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Unit))
         {
            idb.AddParameter("@PCTC_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Unit", pCT_Clear.PCTC_Unit);
         }
         if (pCT_Clear.PCTC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCTC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Date", pCT_Clear.PCTC_Date);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Bak))
         {
            idb.AddParameter("@PCTC_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Bak", pCT_Clear.PCTC_Bak);
         }
         if (pCT_Clear.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Clear.Stat);
         }
         if (pCT_Clear.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Clear.CreateDate);
         }
         if (pCT_Clear.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Clear.UpdateDate);
         }
         if (pCT_Clear.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Clear.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_iType))
         {
            idb.AddParameter("@PCTC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_iType", pCT_Clear.PCTC_iType);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_TCode))
         {
            idb.AddParameter("@PCTC_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_TCode", pCT_Clear.PCTC_TCode);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Udef2))
         {
            idb.AddParameter("@PCTC_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Udef2", pCT_Clear.PCTC_Udef2);
         }
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Udef3))
         {
            idb.AddParameter("@PCTC_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Udef3", pCT_Clear.PCTC_Udef3);
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
      /// 更新打罐记录 PCT_Clear对象(即:一条记录
      /// </summary>
      public int Update(PCT_Clear pCT_Clear)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCT_Clear       SET ");
            if(pCT_Clear.PCTC_Code_IsChanged){sbParameter.Append("PCTC_Code=@PCTC_Code, ");}
      if(pCT_Clear.PCTC_GCode_IsChanged){sbParameter.Append("PCTC_GCode=@PCTC_GCode, ");}
      if(pCT_Clear.PCTC_GNo_IsChanged){sbParameter.Append("PCTC_GNo=@PCTC_GNo, ");}
      if(pCT_Clear.PCTC_BBak_IsChanged){sbParameter.Append("PCTC_BBak=@PCTC_BBak, ");}
      if(pCT_Clear.PCTC_BWeight_IsChanged){sbParameter.Append("PCTC_BWeight=@PCTC_BWeight, ");}
      if(pCT_Clear.PCTC_ABak_IsChanged){sbParameter.Append("PCTC_ABak=@PCTC_ABak, ");}
      if(pCT_Clear.PCTC_AWeight_IsChanged){sbParameter.Append("PCTC_AWeight=@PCTC_AWeight, ");}
      if(pCT_Clear.PCTC_Unit_IsChanged){sbParameter.Append("PCTC_Unit=@PCTC_Unit, ");}
      if(pCT_Clear.PCTC_Date_IsChanged){sbParameter.Append("PCTC_Date=@PCTC_Date, ");}
      if(pCT_Clear.PCTC_Bak_IsChanged){sbParameter.Append("PCTC_Bak=@PCTC_Bak, ");}
      if(pCT_Clear.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCT_Clear.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pCT_Clear.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pCT_Clear.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pCT_Clear.PCTC_iType_IsChanged){sbParameter.Append("PCTC_iType=@PCTC_iType, ");}
      if(pCT_Clear.PCTC_TCode_IsChanged){sbParameter.Append("PCTC_TCode=@PCTC_TCode, ");}
      if(pCT_Clear.PCTC_Udef2_IsChanged){sbParameter.Append("PCTC_Udef2=@PCTC_Udef2, ");}
      if(pCT_Clear.PCTC_Udef3_IsChanged){sbParameter.Append("PCTC_Udef3=@PCTC_Udef3 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCTC_ID=@PCTC_ID; " );
      string sql=sb.ToString();
         if(pCT_Clear.PCTC_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Code))
         {
            idb.AddParameter("@PCTC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Code", pCT_Clear.PCTC_Code);
         }
          }
         if(pCT_Clear.PCTC_GCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_GCode))
         {
            idb.AddParameter("@PCTC_GCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_GCode", pCT_Clear.PCTC_GCode);
         }
          }
         if(pCT_Clear.PCTC_GNo_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_GNo))
         {
            idb.AddParameter("@PCTC_GNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_GNo", pCT_Clear.PCTC_GNo);
         }
          }
         if(pCT_Clear.PCTC_BBak_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_BBak))
         {
            idb.AddParameter("@PCTC_BBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_BBak", pCT_Clear.PCTC_BBak);
         }
          }
         if(pCT_Clear.PCTC_BWeight_IsChanged)
         {
         if (pCT_Clear.PCTC_BWeight == 0)
         {
            idb.AddParameter("@PCTC_BWeight", 0);
         }
         else
         {
            idb.AddParameter("@PCTC_BWeight", pCT_Clear.PCTC_BWeight);
         }
          }
         if(pCT_Clear.PCTC_ABak_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_ABak))
         {
            idb.AddParameter("@PCTC_ABak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_ABak", pCT_Clear.PCTC_ABak);
         }
          }
         if(pCT_Clear.PCTC_AWeight_IsChanged)
         {
         if (pCT_Clear.PCTC_AWeight == 0)
         {
            idb.AddParameter("@PCTC_AWeight", 0);
         }
         else
         {
            idb.AddParameter("@PCTC_AWeight", pCT_Clear.PCTC_AWeight);
         }
          }
         if(pCT_Clear.PCTC_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Unit))
         {
            idb.AddParameter("@PCTC_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Unit", pCT_Clear.PCTC_Unit);
         }
          }
         if(pCT_Clear.PCTC_Date_IsChanged)
         {
         if (pCT_Clear.PCTC_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCTC_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Date", pCT_Clear.PCTC_Date);
         }
          }
         if(pCT_Clear.PCTC_Bak_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Bak))
         {
            idb.AddParameter("@PCTC_Bak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Bak", pCT_Clear.PCTC_Bak);
         }
          }
         if(pCT_Clear.Stat_IsChanged)
         {
         if (pCT_Clear.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Clear.Stat);
         }
          }
         if(pCT_Clear.CreateDate_IsChanged)
         {
         if (pCT_Clear.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Clear.CreateDate);
         }
          }
         if(pCT_Clear.UpdateDate_IsChanged)
         {
         if (pCT_Clear.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Clear.UpdateDate);
         }
          }
         if(pCT_Clear.DeleteDate_IsChanged)
         {
         if (pCT_Clear.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Clear.DeleteDate);
         }
          }
         if(pCT_Clear.PCTC_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_iType))
         {
            idb.AddParameter("@PCTC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_iType", pCT_Clear.PCTC_iType);
         }
          }
         if(pCT_Clear.PCTC_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_TCode))
         {
            idb.AddParameter("@PCTC_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_TCode", pCT_Clear.PCTC_TCode);
         }
          }
         if(pCT_Clear.PCTC_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Udef2))
         {
            idb.AddParameter("@PCTC_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Udef2", pCT_Clear.PCTC_Udef2);
         }
          }
         if(pCT_Clear.PCTC_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Clear.PCTC_Udef3))
         {
            idb.AddParameter("@PCTC_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTC_Udef3", pCT_Clear.PCTC_Udef3);
         }
          }

         idb.AddParameter("@PCTC_ID", pCT_Clear.PCTC_ID);

           
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
      /// 删除打罐记录 PCT_Clear对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCTC_ID)
      {
         string sql = "DELETE PCT_Clear WHERE 1=1  AND PCTC_ID=@PCTC_ID ";
         idb.AddParameter("@PCTC_ID", pCTC_ID);

           
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
      /// 获取指定的打罐记录 PCT_Clear对象(即:一条记录
      /// </summary>
      public PCT_Clear GetByKey(decimal pCTC_ID)
      {
         PCT_Clear pCT_Clear = new PCT_Clear();
         string sql = "SELECT  PCTC_ID,PCTC_Code,PCTC_GCode,PCTC_GNo,PCTC_BBak,PCTC_BWeight,PCTC_ABak,PCTC_AWeight,PCTC_Unit,PCTC_Date,PCTC_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCTC_iType,PCTC_TCode,PCTC_Udef2,PCTC_Udef3 FROM PCT_Clear WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCTC_ID=@PCTC_ID ";
         idb.AddParameter("@PCTC_ID", pCTC_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCTC_ID"] != DBNull.Value) pCT_Clear.PCTC_ID = Convert.ToDecimal(dr["PCTC_ID"]);
            if (dr["PCTC_Code"] != DBNull.Value) pCT_Clear.PCTC_Code = Convert.ToString(dr["PCTC_Code"]);
            if (dr["PCTC_GCode"] != DBNull.Value) pCT_Clear.PCTC_GCode = Convert.ToString(dr["PCTC_GCode"]);
            if (dr["PCTC_GNo"] != DBNull.Value) pCT_Clear.PCTC_GNo = Convert.ToString(dr["PCTC_GNo"]);
            if (dr["PCTC_BBak"] != DBNull.Value) pCT_Clear.PCTC_BBak = Convert.ToString(dr["PCTC_BBak"]);
            if (dr["PCTC_BWeight"] != DBNull.Value) pCT_Clear.PCTC_BWeight = Convert.ToSingle(dr["PCTC_BWeight"]);
            if (dr["PCTC_ABak"] != DBNull.Value) pCT_Clear.PCTC_ABak = Convert.ToString(dr["PCTC_ABak"]);
            if (dr["PCTC_AWeight"] != DBNull.Value) pCT_Clear.PCTC_AWeight = Convert.ToSingle(dr["PCTC_AWeight"]);
            if (dr["PCTC_Unit"] != DBNull.Value) pCT_Clear.PCTC_Unit = Convert.ToString(dr["PCTC_Unit"]);
            if (dr["PCTC_Date"] != DBNull.Value) pCT_Clear.PCTC_Date = Convert.ToDateTime(dr["PCTC_Date"]);
            if (dr["PCTC_Bak"] != DBNull.Value) pCT_Clear.PCTC_Bak = Convert.ToString(dr["PCTC_Bak"]);
            if (dr["Stat"] != DBNull.Value) pCT_Clear.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Clear.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Clear.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Clear.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTC_iType"] != DBNull.Value) pCT_Clear.PCTC_iType = Convert.ToString(dr["PCTC_iType"]);
            if (dr["PCTC_TCode"] != DBNull.Value) pCT_Clear.PCTC_TCode = Convert.ToString(dr["PCTC_TCode"]);
            if (dr["PCTC_Udef2"] != DBNull.Value) pCT_Clear.PCTC_Udef2 = Convert.ToString(dr["PCTC_Udef2"]);
            if (dr["PCTC_Udef3"] != DBNull.Value) pCT_Clear.PCTC_Udef3 = Convert.ToString(dr["PCTC_Udef3"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCT_Clear;
      }
      /// <summary>
      /// 获取指定的打罐记录 PCT_Clear对象集合
      /// </summary>
      public List<PCT_Clear> GetListByWhere(string strCondition)
      {
         List<PCT_Clear> ret = new List<PCT_Clear>();
         string sql = "SELECT  PCTC_ID,PCTC_Code,PCTC_GCode,PCTC_GNo,PCTC_BBak,PCTC_BWeight,PCTC_ABak,PCTC_AWeight,PCTC_Unit,PCTC_Date,PCTC_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCTC_iType,PCTC_TCode,PCTC_Udef2,PCTC_Udef3 FROM PCT_Clear WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCT_Clear pCT_Clear = new PCT_Clear();
            if (dr["PCTC_ID"] != DBNull.Value) pCT_Clear.PCTC_ID = Convert.ToDecimal(dr["PCTC_ID"]);
            if (dr["PCTC_Code"] != DBNull.Value) pCT_Clear.PCTC_Code = Convert.ToString(dr["PCTC_Code"]);
            if (dr["PCTC_GCode"] != DBNull.Value) pCT_Clear.PCTC_GCode = Convert.ToString(dr["PCTC_GCode"]);
            if (dr["PCTC_GNo"] != DBNull.Value) pCT_Clear.PCTC_GNo = Convert.ToString(dr["PCTC_GNo"]);
            if (dr["PCTC_BBak"] != DBNull.Value) pCT_Clear.PCTC_BBak = Convert.ToString(dr["PCTC_BBak"]);
            if (dr["PCTC_BWeight"] != DBNull.Value) pCT_Clear.PCTC_BWeight = Convert.ToSingle(dr["PCTC_BWeight"]);
            if (dr["PCTC_ABak"] != DBNull.Value) pCT_Clear.PCTC_ABak = Convert.ToString(dr["PCTC_ABak"]);
            if (dr["PCTC_AWeight"] != DBNull.Value) pCT_Clear.PCTC_AWeight = Convert.ToSingle(dr["PCTC_AWeight"]);
            if (dr["PCTC_Unit"] != DBNull.Value) pCT_Clear.PCTC_Unit = Convert.ToString(dr["PCTC_Unit"]);
            if (dr["PCTC_Date"] != DBNull.Value) pCT_Clear.PCTC_Date = Convert.ToDateTime(dr["PCTC_Date"]);
            if (dr["PCTC_Bak"] != DBNull.Value) pCT_Clear.PCTC_Bak = Convert.ToString(dr["PCTC_Bak"]);
            if (dr["Stat"] != DBNull.Value) pCT_Clear.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Clear.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Clear.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Clear.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTC_iType"] != DBNull.Value) pCT_Clear.PCTC_iType = Convert.ToString(dr["PCTC_iType"]);
            if (dr["PCTC_TCode"] != DBNull.Value) pCT_Clear.PCTC_TCode = Convert.ToString(dr["PCTC_TCode"]);
            if (dr["PCTC_Udef2"] != DBNull.Value) pCT_Clear.PCTC_Udef2 = Convert.ToString(dr["PCTC_Udef2"]);
            if (dr["PCTC_Udef3"] != DBNull.Value) pCT_Clear.PCTC_Udef3 = Convert.ToString(dr["PCTC_Udef3"]);
            ret.Add(pCT_Clear);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的打罐记录 PCT_Clear对象(即:一条记录
      /// </summary>
      public List<PCT_Clear> GetAll()
      {
         List<PCT_Clear> ret = new List<PCT_Clear>();
         string sql = "SELECT  PCTC_ID,PCTC_Code,PCTC_GCode,PCTC_GNo,PCTC_BBak,PCTC_BWeight,PCTC_ABak,PCTC_AWeight,PCTC_Unit,PCTC_Date,PCTC_Bak,Stat,CreateDate,UpdateDate,DeleteDate,PCTC_iType,PCTC_TCode,PCTC_Udef2,PCTC_Udef3 FROM PCT_Clear where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCTC_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCT_Clear pCT_Clear = new PCT_Clear();
            if (dr["PCTC_ID"] != DBNull.Value) pCT_Clear.PCTC_ID = Convert.ToDecimal(dr["PCTC_ID"]);
            if (dr["PCTC_Code"] != DBNull.Value) pCT_Clear.PCTC_Code = Convert.ToString(dr["PCTC_Code"]);
            if (dr["PCTC_GCode"] != DBNull.Value) pCT_Clear.PCTC_GCode = Convert.ToString(dr["PCTC_GCode"]);
            if (dr["PCTC_GNo"] != DBNull.Value) pCT_Clear.PCTC_GNo = Convert.ToString(dr["PCTC_GNo"]);
            if (dr["PCTC_BBak"] != DBNull.Value) pCT_Clear.PCTC_BBak = Convert.ToString(dr["PCTC_BBak"]);
            if (dr["PCTC_BWeight"] != DBNull.Value) pCT_Clear.PCTC_BWeight = Convert.ToSingle(dr["PCTC_BWeight"]);
            if (dr["PCTC_ABak"] != DBNull.Value) pCT_Clear.PCTC_ABak = Convert.ToString(dr["PCTC_ABak"]);
            if (dr["PCTC_AWeight"] != DBNull.Value) pCT_Clear.PCTC_AWeight = Convert.ToSingle(dr["PCTC_AWeight"]);
            if (dr["PCTC_Unit"] != DBNull.Value) pCT_Clear.PCTC_Unit = Convert.ToString(dr["PCTC_Unit"]);
            if (dr["PCTC_Date"] != DBNull.Value) pCT_Clear.PCTC_Date = Convert.ToDateTime(dr["PCTC_Date"]);
            if (dr["PCTC_Bak"] != DBNull.Value) pCT_Clear.PCTC_Bak = Convert.ToString(dr["PCTC_Bak"]);
            if (dr["Stat"] != DBNull.Value) pCT_Clear.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Clear.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Clear.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Clear.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTC_iType"] != DBNull.Value) pCT_Clear.PCTC_iType = Convert.ToString(dr["PCTC_iType"]);
            if (dr["PCTC_TCode"] != DBNull.Value) pCT_Clear.PCTC_TCode = Convert.ToString(dr["PCTC_TCode"]);
            if (dr["PCTC_Udef2"] != DBNull.Value) pCT_Clear.PCTC_Udef2 = Convert.ToString(dr["PCTC_Udef2"]);
            if (dr["PCTC_Udef3"] != DBNull.Value) pCT_Clear.PCTC_Udef3 = Convert.ToString(dr["PCTC_Udef3"]);
            ret.Add(pCT_Clear);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
