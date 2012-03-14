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
   /// 车辆调度表
   /// </summary>
   [Serializable]
   public partial class ADOPCT_Schedule
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加车辆调度表 PCT_Schedule对象(即:一条记录)
      /// </summary>
      public int Add(PCT_Schedule pCT_Schedule)
      {
         string sql = "INSERT INTO PCT_Schedule (PCTS_Code,PCTS_ICode,PCTS_NO,PCTS_INO,PCTS_Driver,PCTS_Aim,PCTS_AType,PCTS_SType,PCTS_Date,PCTS_Emp,PCTS_ADate,Stat,PCTS_Stat,PCTS_TankerStat,PCTS_Udef1,PCTS_Udef2,PCTS_Udef3,PCTS_Udef4,PCTS_Udef5) VALUES (@PCTS_Code,@PCTS_ICode,@PCTS_NO,@PCTS_INO,@PCTS_Driver,@PCTS_Aim,@PCTS_AType,@PCTS_SType,@PCTS_Date,@PCTS_Emp,@PCTS_ADate,@Stat,@PCTS_Stat,@PCTS_TankerStat,@PCTS_Udef1,@PCTS_Udef2,@PCTS_Udef3,@PCTS_Udef4,@PCTS_Udef5)";
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Code))
         {
            idb.AddParameter("@PCTS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Code", pCT_Schedule.PCTS_Code);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_ICode))
         {
            idb.AddParameter("@PCTS_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_ICode", pCT_Schedule.PCTS_ICode);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_NO))
         {
            idb.AddParameter("@PCTS_NO", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_NO", pCT_Schedule.PCTS_NO);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_INO))
         {
            idb.AddParameter("@PCTS_INO", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_INO", pCT_Schedule.PCTS_INO);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Driver))
         {
            idb.AddParameter("@PCTS_Driver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Driver", pCT_Schedule.PCTS_Driver);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Aim))
         {
            idb.AddParameter("@PCTS_Aim", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Aim", pCT_Schedule.PCTS_Aim);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_AType))
         {
            idb.AddParameter("@PCTS_AType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_AType", pCT_Schedule.PCTS_AType);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_SType))
         {
            idb.AddParameter("@PCTS_SType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_SType", pCT_Schedule.PCTS_SType);
         }
         if (pCT_Schedule.PCTS_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCTS_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Date", pCT_Schedule.PCTS_Date);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Emp))
         {
            idb.AddParameter("@PCTS_Emp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Emp", pCT_Schedule.PCTS_Emp);
         }
         if (pCT_Schedule.PCTS_ADate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTS_ADate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_ADate", pCT_Schedule.PCTS_ADate);
         }
         if (pCT_Schedule.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Schedule.Stat);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Stat))
         {
            idb.AddParameter("@PCTS_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Stat", pCT_Schedule.PCTS_Stat);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_TankerStat))
         {
            idb.AddParameter("@PCTS_TankerStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_TankerStat", pCT_Schedule.PCTS_TankerStat);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef1))
         {
            idb.AddParameter("@PCTS_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef1", pCT_Schedule.PCTS_Udef1);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef2))
         {
            idb.AddParameter("@PCTS_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef2", pCT_Schedule.PCTS_Udef2);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef3))
         {
            idb.AddParameter("@PCTS_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef3", pCT_Schedule.PCTS_Udef3);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef4))
         {
            idb.AddParameter("@PCTS_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef4", pCT_Schedule.PCTS_Udef4);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef5))
         {
            idb.AddParameter("@PCTS_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef5", pCT_Schedule.PCTS_Udef5);
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
      /// 添加车辆调度表 PCT_Schedule对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCT_Schedule pCT_Schedule)
      {
         string sql = "INSERT INTO PCT_Schedule (PCTS_Code,PCTS_ICode,PCTS_NO,PCTS_INO,PCTS_Driver,PCTS_Aim,PCTS_AType,PCTS_SType,PCTS_Date,PCTS_Emp,PCTS_ADate,Stat,PCTS_Stat,PCTS_TankerStat,PCTS_Udef1,PCTS_Udef2,PCTS_Udef3,PCTS_Udef4,PCTS_Udef5) VALUES (@PCTS_Code,@PCTS_ICode,@PCTS_NO,@PCTS_INO,@PCTS_Driver,@PCTS_Aim,@PCTS_AType,@PCTS_SType,@PCTS_Date,@PCTS_Emp,@PCTS_ADate,@Stat,@PCTS_Stat,@PCTS_TankerStat,@PCTS_Udef1,@PCTS_Udef2,@PCTS_Udef3,@PCTS_Udef4,@PCTS_Udef5);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Code))
         {
            idb.AddParameter("@PCTS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Code", pCT_Schedule.PCTS_Code);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_ICode))
         {
            idb.AddParameter("@PCTS_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_ICode", pCT_Schedule.PCTS_ICode);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_NO))
         {
            idb.AddParameter("@PCTS_NO", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_NO", pCT_Schedule.PCTS_NO);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_INO))
         {
            idb.AddParameter("@PCTS_INO", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_INO", pCT_Schedule.PCTS_INO);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Driver))
         {
            idb.AddParameter("@PCTS_Driver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Driver", pCT_Schedule.PCTS_Driver);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Aim))
         {
            idb.AddParameter("@PCTS_Aim", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Aim", pCT_Schedule.PCTS_Aim);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_AType))
         {
            idb.AddParameter("@PCTS_AType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_AType", pCT_Schedule.PCTS_AType);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_SType))
         {
            idb.AddParameter("@PCTS_SType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_SType", pCT_Schedule.PCTS_SType);
         }
         if (pCT_Schedule.PCTS_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCTS_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Date", pCT_Schedule.PCTS_Date);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Emp))
         {
            idb.AddParameter("@PCTS_Emp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Emp", pCT_Schedule.PCTS_Emp);
         }
         if (pCT_Schedule.PCTS_ADate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTS_ADate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_ADate", pCT_Schedule.PCTS_ADate);
         }
         if (pCT_Schedule.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Schedule.Stat);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Stat))
         {
            idb.AddParameter("@PCTS_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Stat", pCT_Schedule.PCTS_Stat);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_TankerStat))
         {
            idb.AddParameter("@PCTS_TankerStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_TankerStat", pCT_Schedule.PCTS_TankerStat);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef1))
         {
            idb.AddParameter("@PCTS_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef1", pCT_Schedule.PCTS_Udef1);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef2))
         {
            idb.AddParameter("@PCTS_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef2", pCT_Schedule.PCTS_Udef2);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef3))
         {
            idb.AddParameter("@PCTS_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef3", pCT_Schedule.PCTS_Udef3);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef4))
         {
            idb.AddParameter("@PCTS_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef4", pCT_Schedule.PCTS_Udef4);
         }
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef5))
         {
            idb.AddParameter("@PCTS_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef5", pCT_Schedule.PCTS_Udef5);
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
      /// 更新车辆调度表 PCT_Schedule对象(即:一条记录
      /// </summary>
      public int Update(PCT_Schedule pCT_Schedule)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCT_Schedule       SET ");
            if(pCT_Schedule.PCTS_Code_IsChanged){sbParameter.Append("PCTS_Code=@PCTS_Code, ");}
      if(pCT_Schedule.PCTS_ICode_IsChanged){sbParameter.Append("PCTS_ICode=@PCTS_ICode, ");}
      if(pCT_Schedule.PCTS_NO_IsChanged){sbParameter.Append("PCTS_NO=@PCTS_NO, ");}
      if(pCT_Schedule.PCTS_INO_IsChanged){sbParameter.Append("PCTS_INO=@PCTS_INO, ");}
      if(pCT_Schedule.PCTS_Driver_IsChanged){sbParameter.Append("PCTS_Driver=@PCTS_Driver, ");}
      if(pCT_Schedule.PCTS_Aim_IsChanged){sbParameter.Append("PCTS_Aim=@PCTS_Aim, ");}
      if(pCT_Schedule.PCTS_AType_IsChanged){sbParameter.Append("PCTS_AType=@PCTS_AType, ");}
      if(pCT_Schedule.PCTS_SType_IsChanged){sbParameter.Append("PCTS_SType=@PCTS_SType, ");}
      if(pCT_Schedule.PCTS_Date_IsChanged){sbParameter.Append("PCTS_Date=@PCTS_Date, ");}
      if(pCT_Schedule.PCTS_Emp_IsChanged){sbParameter.Append("PCTS_Emp=@PCTS_Emp, ");}
      if(pCT_Schedule.PCTS_ADate_IsChanged){sbParameter.Append("PCTS_ADate=@PCTS_ADate, ");}
      if(pCT_Schedule.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCT_Schedule.PCTS_Stat_IsChanged){sbParameter.Append("PCTS_Stat=@PCTS_Stat, ");}
      if(pCT_Schedule.PCTS_TankerStat_IsChanged){sbParameter.Append("PCTS_TankerStat=@PCTS_TankerStat, ");}
      if(pCT_Schedule.PCTS_Udef1_IsChanged){sbParameter.Append("PCTS_Udef1=@PCTS_Udef1, ");}
      if(pCT_Schedule.PCTS_Udef2_IsChanged){sbParameter.Append("PCTS_Udef2=@PCTS_Udef2, ");}
      if(pCT_Schedule.PCTS_Udef3_IsChanged){sbParameter.Append("PCTS_Udef3=@PCTS_Udef3, ");}
      if(pCT_Schedule.PCTS_Udef4_IsChanged){sbParameter.Append("PCTS_Udef4=@PCTS_Udef4, ");}
      if(pCT_Schedule.PCTS_Udef5_IsChanged){sbParameter.Append("PCTS_Udef5=@PCTS_Udef5 ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCTS_ID=@PCTS_ID; " );
      string sql=sb.ToString();
         if(pCT_Schedule.PCTS_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Code))
         {
            idb.AddParameter("@PCTS_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Code", pCT_Schedule.PCTS_Code);
         }
          }
         if(pCT_Schedule.PCTS_ICode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_ICode))
         {
            idb.AddParameter("@PCTS_ICode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_ICode", pCT_Schedule.PCTS_ICode);
         }
          }
         if(pCT_Schedule.PCTS_NO_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_NO))
         {
            idb.AddParameter("@PCTS_NO", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_NO", pCT_Schedule.PCTS_NO);
         }
          }
         if(pCT_Schedule.PCTS_INO_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_INO))
         {
            idb.AddParameter("@PCTS_INO", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_INO", pCT_Schedule.PCTS_INO);
         }
          }
         if(pCT_Schedule.PCTS_Driver_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Driver))
         {
            idb.AddParameter("@PCTS_Driver", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Driver", pCT_Schedule.PCTS_Driver);
         }
          }
         if(pCT_Schedule.PCTS_Aim_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Aim))
         {
            idb.AddParameter("@PCTS_Aim", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Aim", pCT_Schedule.PCTS_Aim);
         }
          }
         if(pCT_Schedule.PCTS_AType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_AType))
         {
            idb.AddParameter("@PCTS_AType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_AType", pCT_Schedule.PCTS_AType);
         }
          }
         if(pCT_Schedule.PCTS_SType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_SType))
         {
            idb.AddParameter("@PCTS_SType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_SType", pCT_Schedule.PCTS_SType);
         }
          }
         if(pCT_Schedule.PCTS_Date_IsChanged)
         {
         if (pCT_Schedule.PCTS_Date == DateTime.MinValue)
         {
            idb.AddParameter("@PCTS_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Date", pCT_Schedule.PCTS_Date);
         }
          }
         if(pCT_Schedule.PCTS_Emp_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Emp))
         {
            idb.AddParameter("@PCTS_Emp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Emp", pCT_Schedule.PCTS_Emp);
         }
          }
         if(pCT_Schedule.PCTS_ADate_IsChanged)
         {
         if (pCT_Schedule.PCTS_ADate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTS_ADate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_ADate", pCT_Schedule.PCTS_ADate);
         }
          }
         if(pCT_Schedule.Stat_IsChanged)
         {
         if (pCT_Schedule.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Schedule.Stat);
         }
          }
         if(pCT_Schedule.PCTS_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Stat))
         {
            idb.AddParameter("@PCTS_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Stat", pCT_Schedule.PCTS_Stat);
         }
          }
         if(pCT_Schedule.PCTS_TankerStat_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_TankerStat))
         {
            idb.AddParameter("@PCTS_TankerStat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_TankerStat", pCT_Schedule.PCTS_TankerStat);
         }
          }
         if(pCT_Schedule.PCTS_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef1))
         {
            idb.AddParameter("@PCTS_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef1", pCT_Schedule.PCTS_Udef1);
         }
          }
         if(pCT_Schedule.PCTS_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef2))
         {
            idb.AddParameter("@PCTS_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef2", pCT_Schedule.PCTS_Udef2);
         }
          }
         if(pCT_Schedule.PCTS_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef3))
         {
            idb.AddParameter("@PCTS_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef3", pCT_Schedule.PCTS_Udef3);
         }
          }
         if(pCT_Schedule.PCTS_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef4))
         {
            idb.AddParameter("@PCTS_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef4", pCT_Schedule.PCTS_Udef4);
         }
          }
         if(pCT_Schedule.PCTS_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Schedule.PCTS_Udef5))
         {
            idb.AddParameter("@PCTS_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTS_Udef5", pCT_Schedule.PCTS_Udef5);
         }
          }

         idb.AddParameter("@PCTS_ID", pCT_Schedule.PCTS_ID);

           
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
      /// 删除车辆调度表 PCT_Schedule对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCTS_ID)
      {
         string sql = "DELETE PCT_Schedule WHERE 1=1  AND PCTS_ID=@PCTS_ID ";
         idb.AddParameter("@PCTS_ID", pCTS_ID);

           
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
      /// 获取指定的车辆调度表 PCT_Schedule对象(即:一条记录
      /// </summary>
      public PCT_Schedule GetByKey(decimal pCTS_ID)
      {
         PCT_Schedule pCT_Schedule = new PCT_Schedule();
         string sql = "SELECT  PCTS_ID,PCTS_Code,PCTS_ICode,PCTS_NO,PCTS_INO,PCTS_Driver,PCTS_Aim,PCTS_AType,PCTS_SType,PCTS_Date,PCTS_Emp,PCTS_ADate,Stat,PCTS_Stat,PCTS_TankerStat,PCTS_Udef1,PCTS_Udef2,PCTS_Udef3,PCTS_Udef4,PCTS_Udef5 FROM PCT_Schedule WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCTS_ID=@PCTS_ID ";
         idb.AddParameter("@PCTS_ID", pCTS_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCTS_ID"] != DBNull.Value) pCT_Schedule.PCTS_ID = Convert.ToDecimal(dr["PCTS_ID"]);
            if (dr["PCTS_Code"] != DBNull.Value) pCT_Schedule.PCTS_Code = Convert.ToString(dr["PCTS_Code"]);
            if (dr["PCTS_ICode"] != DBNull.Value) pCT_Schedule.PCTS_ICode = Convert.ToString(dr["PCTS_ICode"]);
            if (dr["PCTS_NO"] != DBNull.Value) pCT_Schedule.PCTS_NO = Convert.ToString(dr["PCTS_NO"]);
            if (dr["PCTS_INO"] != DBNull.Value) pCT_Schedule.PCTS_INO = Convert.ToString(dr["PCTS_INO"]);
            if (dr["PCTS_Driver"] != DBNull.Value) pCT_Schedule.PCTS_Driver = Convert.ToString(dr["PCTS_Driver"]);
            if (dr["PCTS_Aim"] != DBNull.Value) pCT_Schedule.PCTS_Aim = Convert.ToString(dr["PCTS_Aim"]);
            if (dr["PCTS_AType"] != DBNull.Value) pCT_Schedule.PCTS_AType = Convert.ToString(dr["PCTS_AType"]);
            if (dr["PCTS_SType"] != DBNull.Value) pCT_Schedule.PCTS_SType = Convert.ToString(dr["PCTS_SType"]);
            if (dr["PCTS_Date"] != DBNull.Value) pCT_Schedule.PCTS_Date = Convert.ToDateTime(dr["PCTS_Date"]);
            if (dr["PCTS_Emp"] != DBNull.Value) pCT_Schedule.PCTS_Emp = Convert.ToString(dr["PCTS_Emp"]);
            if (dr["PCTS_ADate"] != DBNull.Value) pCT_Schedule.PCTS_ADate = Convert.ToDateTime(dr["PCTS_ADate"]);
            if (dr["Stat"] != DBNull.Value) pCT_Schedule.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PCTS_Stat"] != DBNull.Value) pCT_Schedule.PCTS_Stat = Convert.ToString(dr["PCTS_Stat"]);
            if (dr["PCTS_TankerStat"] != DBNull.Value) pCT_Schedule.PCTS_TankerStat = Convert.ToString(dr["PCTS_TankerStat"]);
            if (dr["PCTS_Udef1"] != DBNull.Value) pCT_Schedule.PCTS_Udef1 = Convert.ToString(dr["PCTS_Udef1"]);
            if (dr["PCTS_Udef2"] != DBNull.Value) pCT_Schedule.PCTS_Udef2 = Convert.ToString(dr["PCTS_Udef2"]);
            if (dr["PCTS_Udef3"] != DBNull.Value) pCT_Schedule.PCTS_Udef3 = Convert.ToString(dr["PCTS_Udef3"]);
            if (dr["PCTS_Udef4"] != DBNull.Value) pCT_Schedule.PCTS_Udef4 = Convert.ToString(dr["PCTS_Udef4"]);
            if (dr["PCTS_Udef5"] != DBNull.Value) pCT_Schedule.PCTS_Udef5 = Convert.ToString(dr["PCTS_Udef5"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCT_Schedule;
      }
      /// <summary>
      /// 获取指定的车辆调度表 PCT_Schedule对象集合
      /// </summary>
      public List<PCT_Schedule> GetListByWhere(string strCondition)
      {
         List<PCT_Schedule> ret = new List<PCT_Schedule>();
         string sql = "SELECT  PCTS_ID,PCTS_Code,PCTS_ICode,PCTS_NO,PCTS_INO,PCTS_Driver,PCTS_Aim,PCTS_AType,PCTS_SType,PCTS_Date,PCTS_Emp,PCTS_ADate,Stat,PCTS_Stat,PCTS_TankerStat,PCTS_Udef1,PCTS_Udef2,PCTS_Udef3,PCTS_Udef4,PCTS_Udef5 FROM PCT_Schedule WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCT_Schedule pCT_Schedule = new PCT_Schedule();
            if (dr["PCTS_ID"] != DBNull.Value) pCT_Schedule.PCTS_ID = Convert.ToDecimal(dr["PCTS_ID"]);
            if (dr["PCTS_Code"] != DBNull.Value) pCT_Schedule.PCTS_Code = Convert.ToString(dr["PCTS_Code"]);
            if (dr["PCTS_ICode"] != DBNull.Value) pCT_Schedule.PCTS_ICode = Convert.ToString(dr["PCTS_ICode"]);
            if (dr["PCTS_NO"] != DBNull.Value) pCT_Schedule.PCTS_NO = Convert.ToString(dr["PCTS_NO"]);
            if (dr["PCTS_INO"] != DBNull.Value) pCT_Schedule.PCTS_INO = Convert.ToString(dr["PCTS_INO"]);
            if (dr["PCTS_Driver"] != DBNull.Value) pCT_Schedule.PCTS_Driver = Convert.ToString(dr["PCTS_Driver"]);
            if (dr["PCTS_Aim"] != DBNull.Value) pCT_Schedule.PCTS_Aim = Convert.ToString(dr["PCTS_Aim"]);
            if (dr["PCTS_AType"] != DBNull.Value) pCT_Schedule.PCTS_AType = Convert.ToString(dr["PCTS_AType"]);
            if (dr["PCTS_SType"] != DBNull.Value) pCT_Schedule.PCTS_SType = Convert.ToString(dr["PCTS_SType"]);
            if (dr["PCTS_Date"] != DBNull.Value) pCT_Schedule.PCTS_Date = Convert.ToDateTime(dr["PCTS_Date"]);
            if (dr["PCTS_Emp"] != DBNull.Value) pCT_Schedule.PCTS_Emp = Convert.ToString(dr["PCTS_Emp"]);
            if (dr["PCTS_ADate"] != DBNull.Value) pCT_Schedule.PCTS_ADate = Convert.ToDateTime(dr["PCTS_ADate"]);
            if (dr["Stat"] != DBNull.Value) pCT_Schedule.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PCTS_Stat"] != DBNull.Value) pCT_Schedule.PCTS_Stat = Convert.ToString(dr["PCTS_Stat"]);
            if (dr["PCTS_TankerStat"] != DBNull.Value) pCT_Schedule.PCTS_TankerStat = Convert.ToString(dr["PCTS_TankerStat"]);
            if (dr["PCTS_Udef1"] != DBNull.Value) pCT_Schedule.PCTS_Udef1 = Convert.ToString(dr["PCTS_Udef1"]);
            if (dr["PCTS_Udef2"] != DBNull.Value) pCT_Schedule.PCTS_Udef2 = Convert.ToString(dr["PCTS_Udef2"]);
            if (dr["PCTS_Udef3"] != DBNull.Value) pCT_Schedule.PCTS_Udef3 = Convert.ToString(dr["PCTS_Udef3"]);
            if (dr["PCTS_Udef4"] != DBNull.Value) pCT_Schedule.PCTS_Udef4 = Convert.ToString(dr["PCTS_Udef4"]);
            if (dr["PCTS_Udef5"] != DBNull.Value) pCT_Schedule.PCTS_Udef5 = Convert.ToString(dr["PCTS_Udef5"]);
            ret.Add(pCT_Schedule);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的车辆调度表 PCT_Schedule对象(即:一条记录
      /// </summary>
      public List<PCT_Schedule> GetAll()
      {
         List<PCT_Schedule> ret = new List<PCT_Schedule>();
         string sql = "SELECT  PCTS_ID,PCTS_Code,PCTS_ICode,PCTS_NO,PCTS_INO,PCTS_Driver,PCTS_Aim,PCTS_AType,PCTS_SType,PCTS_Date,PCTS_Emp,PCTS_ADate,Stat,PCTS_Stat,PCTS_TankerStat,PCTS_Udef1,PCTS_Udef2,PCTS_Udef3,PCTS_Udef4,PCTS_Udef5 FROM PCT_Schedule where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCTS_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCT_Schedule pCT_Schedule = new PCT_Schedule();
            if (dr["PCTS_ID"] != DBNull.Value) pCT_Schedule.PCTS_ID = Convert.ToDecimal(dr["PCTS_ID"]);
            if (dr["PCTS_Code"] != DBNull.Value) pCT_Schedule.PCTS_Code = Convert.ToString(dr["PCTS_Code"]);
            if (dr["PCTS_ICode"] != DBNull.Value) pCT_Schedule.PCTS_ICode = Convert.ToString(dr["PCTS_ICode"]);
            if (dr["PCTS_NO"] != DBNull.Value) pCT_Schedule.PCTS_NO = Convert.ToString(dr["PCTS_NO"]);
            if (dr["PCTS_INO"] != DBNull.Value) pCT_Schedule.PCTS_INO = Convert.ToString(dr["PCTS_INO"]);
            if (dr["PCTS_Driver"] != DBNull.Value) pCT_Schedule.PCTS_Driver = Convert.ToString(dr["PCTS_Driver"]);
            if (dr["PCTS_Aim"] != DBNull.Value) pCT_Schedule.PCTS_Aim = Convert.ToString(dr["PCTS_Aim"]);
            if (dr["PCTS_AType"] != DBNull.Value) pCT_Schedule.PCTS_AType = Convert.ToString(dr["PCTS_AType"]);
            if (dr["PCTS_SType"] != DBNull.Value) pCT_Schedule.PCTS_SType = Convert.ToString(dr["PCTS_SType"]);
            if (dr["PCTS_Date"] != DBNull.Value) pCT_Schedule.PCTS_Date = Convert.ToDateTime(dr["PCTS_Date"]);
            if (dr["PCTS_Emp"] != DBNull.Value) pCT_Schedule.PCTS_Emp = Convert.ToString(dr["PCTS_Emp"]);
            if (dr["PCTS_ADate"] != DBNull.Value) pCT_Schedule.PCTS_ADate = Convert.ToDateTime(dr["PCTS_ADate"]);
            if (dr["Stat"] != DBNull.Value) pCT_Schedule.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["PCTS_Stat"] != DBNull.Value) pCT_Schedule.PCTS_Stat = Convert.ToString(dr["PCTS_Stat"]);
            if (dr["PCTS_TankerStat"] != DBNull.Value) pCT_Schedule.PCTS_TankerStat = Convert.ToString(dr["PCTS_TankerStat"]);
            if (dr["PCTS_Udef1"] != DBNull.Value) pCT_Schedule.PCTS_Udef1 = Convert.ToString(dr["PCTS_Udef1"]);
            if (dr["PCTS_Udef2"] != DBNull.Value) pCT_Schedule.PCTS_Udef2 = Convert.ToString(dr["PCTS_Udef2"]);
            if (dr["PCTS_Udef3"] != DBNull.Value) pCT_Schedule.PCTS_Udef3 = Convert.ToString(dr["PCTS_Udef3"]);
            if (dr["PCTS_Udef4"] != DBNull.Value) pCT_Schedule.PCTS_Udef4 = Convert.ToString(dr["PCTS_Udef4"]);
            if (dr["PCTS_Udef5"] != DBNull.Value) pCT_Schedule.PCTS_Udef5 = Convert.ToString(dr["PCTS_Udef5"]);
            ret.Add(pCT_Schedule);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
