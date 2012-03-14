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
   /// 餐劵招待记录
   /// </summary>
   [Serializable]
   public partial class ADOMealReception_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加餐劵招待记录 MealReception_Record对象(即:一条记录)
      /// </summary>
      public int Add(MealReception_Record mealReception_Record)
      {
         string sql = "INSERT INTO MealReception_Record (MR_Code,MR_Date,MR_Reason,MR_Num,MR_ObjectiveCompany,MR_Persons,MR_PersonNum,MR_Handler,MR_Operator,MR_OpDate,MR_Company,MR_Dept,MR_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@MR_Code,@MR_Date,@MR_Reason,@MR_Num,@MR_ObjectiveCompany,@MR_Persons,@MR_PersonNum,@MR_Handler,@MR_Operator,@MR_OpDate,@MR_Company,@MR_Dept,@MR_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(mealReception_Record.MR_Code))
         {
            idb.AddParameter("@MR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Code", mealReception_Record.MR_Code);
         }
         if (mealReception_Record.MR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Date", mealReception_Record.MR_Date);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Reason))
         {
            idb.AddParameter("@MR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Reason", mealReception_Record.MR_Reason);
         }
         if (mealReception_Record.MR_Num == 0)
         {
            idb.AddParameter("@MR_Num", 0);
         }
         else
         {
            idb.AddParameter("@MR_Num", mealReception_Record.MR_Num);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_ObjectiveCompany))
         {
            idb.AddParameter("@MR_ObjectiveCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_ObjectiveCompany", mealReception_Record.MR_ObjectiveCompany);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Persons))
         {
            idb.AddParameter("@MR_Persons", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Persons", mealReception_Record.MR_Persons);
         }
         if (mealReception_Record.MR_PersonNum == 0)
         {
            idb.AddParameter("@MR_PersonNum", 0);
         }
         else
         {
            idb.AddParameter("@MR_PersonNum", mealReception_Record.MR_PersonNum);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Handler))
         {
            idb.AddParameter("@MR_Handler", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Handler", mealReception_Record.MR_Handler);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Operator))
         {
            idb.AddParameter("@MR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Operator", mealReception_Record.MR_Operator);
         }
         if (mealReception_Record.MR_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@MR_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_OpDate", mealReception_Record.MR_OpDate);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Company))
         {
            idb.AddParameter("@MR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Company", mealReception_Record.MR_Company);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Dept))
         {
            idb.AddParameter("@MR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Dept", mealReception_Record.MR_Dept);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Stat))
         {
            idb.AddParameter("@MR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Stat", mealReception_Record.MR_Stat);
         }
         if (mealReception_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", mealReception_Record.Stat);
         }
         if (mealReception_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", mealReception_Record.CreateDate);
         }
         if (mealReception_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", mealReception_Record.UpdateDate);
         }
         if (mealReception_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", mealReception_Record.DeleteDate);
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
      /// 添加餐劵招待记录 MealReception_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(MealReception_Record mealReception_Record)
      {
         string sql = "INSERT INTO MealReception_Record (MR_Code,MR_Date,MR_Reason,MR_Num,MR_ObjectiveCompany,MR_Persons,MR_PersonNum,MR_Handler,MR_Operator,MR_OpDate,MR_Company,MR_Dept,MR_Stat,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@MR_Code,@MR_Date,@MR_Reason,@MR_Num,@MR_ObjectiveCompany,@MR_Persons,@MR_PersonNum,@MR_Handler,@MR_Operator,@MR_OpDate,@MR_Company,@MR_Dept,@MR_Stat,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(mealReception_Record.MR_Code))
         {
            idb.AddParameter("@MR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Code", mealReception_Record.MR_Code);
         }
         if (mealReception_Record.MR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Date", mealReception_Record.MR_Date);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Reason))
         {
            idb.AddParameter("@MR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Reason", mealReception_Record.MR_Reason);
         }
         if (mealReception_Record.MR_Num == 0)
         {
            idb.AddParameter("@MR_Num", 0);
         }
         else
         {
            idb.AddParameter("@MR_Num", mealReception_Record.MR_Num);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_ObjectiveCompany))
         {
            idb.AddParameter("@MR_ObjectiveCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_ObjectiveCompany", mealReception_Record.MR_ObjectiveCompany);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Persons))
         {
            idb.AddParameter("@MR_Persons", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Persons", mealReception_Record.MR_Persons);
         }
         if (mealReception_Record.MR_PersonNum == 0)
         {
            idb.AddParameter("@MR_PersonNum", 0);
         }
         else
         {
            idb.AddParameter("@MR_PersonNum", mealReception_Record.MR_PersonNum);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Handler))
         {
            idb.AddParameter("@MR_Handler", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Handler", mealReception_Record.MR_Handler);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Operator))
         {
            idb.AddParameter("@MR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Operator", mealReception_Record.MR_Operator);
         }
         if (mealReception_Record.MR_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@MR_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_OpDate", mealReception_Record.MR_OpDate);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Company))
         {
            idb.AddParameter("@MR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Company", mealReception_Record.MR_Company);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Dept))
         {
            idb.AddParameter("@MR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Dept", mealReception_Record.MR_Dept);
         }
         if (string.IsNullOrEmpty(mealReception_Record.MR_Stat))
         {
            idb.AddParameter("@MR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Stat", mealReception_Record.MR_Stat);
         }
         if (mealReception_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", mealReception_Record.Stat);
         }
         if (mealReception_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", mealReception_Record.CreateDate);
         }
         if (mealReception_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", mealReception_Record.UpdateDate);
         }
         if (mealReception_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", mealReception_Record.DeleteDate);
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
      /// 更新餐劵招待记录 MealReception_Record对象(即:一条记录
      /// </summary>
      public int Update(MealReception_Record mealReception_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       MealReception_Record       SET ");
            if(mealReception_Record.MR_Code_IsChanged){sbParameter.Append("MR_Code=@MR_Code, ");}
      if(mealReception_Record.MR_Date_IsChanged){sbParameter.Append("MR_Date=@MR_Date, ");}
      if(mealReception_Record.MR_Reason_IsChanged){sbParameter.Append("MR_Reason=@MR_Reason, ");}
      if(mealReception_Record.MR_Num_IsChanged){sbParameter.Append("MR_Num=@MR_Num, ");}
      if(mealReception_Record.MR_ObjectiveCompany_IsChanged){sbParameter.Append("MR_ObjectiveCompany=@MR_ObjectiveCompany, ");}
      if(mealReception_Record.MR_Persons_IsChanged){sbParameter.Append("MR_Persons=@MR_Persons, ");}
      if(mealReception_Record.MR_PersonNum_IsChanged){sbParameter.Append("MR_PersonNum=@MR_PersonNum, ");}
      if(mealReception_Record.MR_Handler_IsChanged){sbParameter.Append("MR_Handler=@MR_Handler, ");}
      if(mealReception_Record.MR_Operator_IsChanged){sbParameter.Append("MR_Operator=@MR_Operator, ");}
      if(mealReception_Record.MR_OpDate_IsChanged){sbParameter.Append("MR_OpDate=@MR_OpDate, ");}
      if(mealReception_Record.MR_Company_IsChanged){sbParameter.Append("MR_Company=@MR_Company, ");}
      if(mealReception_Record.MR_Dept_IsChanged){sbParameter.Append("MR_Dept=@MR_Dept, ");}
      if(mealReception_Record.MR_Stat_IsChanged){sbParameter.Append("MR_Stat=@MR_Stat, ");}
      if(mealReception_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(mealReception_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(mealReception_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(mealReception_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MR_ID=@MR_ID; " );
      string sql=sb.ToString();
         if(mealReception_Record.MR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(mealReception_Record.MR_Code))
         {
            idb.AddParameter("@MR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Code", mealReception_Record.MR_Code);
         }
          }
         if(mealReception_Record.MR_Date_IsChanged)
         {
         if (mealReception_Record.MR_Date == DateTime.MinValue)
         {
            idb.AddParameter("@MR_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Date", mealReception_Record.MR_Date);
         }
          }
         if(mealReception_Record.MR_Reason_IsChanged)
         {
         if (string.IsNullOrEmpty(mealReception_Record.MR_Reason))
         {
            idb.AddParameter("@MR_Reason", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Reason", mealReception_Record.MR_Reason);
         }
          }
         if(mealReception_Record.MR_Num_IsChanged)
         {
         if (mealReception_Record.MR_Num == 0)
         {
            idb.AddParameter("@MR_Num", 0);
         }
         else
         {
            idb.AddParameter("@MR_Num", mealReception_Record.MR_Num);
         }
          }
         if(mealReception_Record.MR_ObjectiveCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(mealReception_Record.MR_ObjectiveCompany))
         {
            idb.AddParameter("@MR_ObjectiveCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_ObjectiveCompany", mealReception_Record.MR_ObjectiveCompany);
         }
          }
         if(mealReception_Record.MR_Persons_IsChanged)
         {
         if (string.IsNullOrEmpty(mealReception_Record.MR_Persons))
         {
            idb.AddParameter("@MR_Persons", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Persons", mealReception_Record.MR_Persons);
         }
          }
         if(mealReception_Record.MR_PersonNum_IsChanged)
         {
         if (mealReception_Record.MR_PersonNum == 0)
         {
            idb.AddParameter("@MR_PersonNum", 0);
         }
         else
         {
            idb.AddParameter("@MR_PersonNum", mealReception_Record.MR_PersonNum);
         }
          }
         if(mealReception_Record.MR_Handler_IsChanged)
         {
         if (string.IsNullOrEmpty(mealReception_Record.MR_Handler))
         {
            idb.AddParameter("@MR_Handler", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Handler", mealReception_Record.MR_Handler);
         }
          }
         if(mealReception_Record.MR_Operator_IsChanged)
         {
         if (string.IsNullOrEmpty(mealReception_Record.MR_Operator))
         {
            idb.AddParameter("@MR_Operator", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Operator", mealReception_Record.MR_Operator);
         }
          }
         if(mealReception_Record.MR_OpDate_IsChanged)
         {
         if (mealReception_Record.MR_OpDate == DateTime.MinValue)
         {
            idb.AddParameter("@MR_OpDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_OpDate", mealReception_Record.MR_OpDate);
         }
          }
         if(mealReception_Record.MR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(mealReception_Record.MR_Company))
         {
            idb.AddParameter("@MR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Company", mealReception_Record.MR_Company);
         }
          }
         if(mealReception_Record.MR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(mealReception_Record.MR_Dept))
         {
            idb.AddParameter("@MR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Dept", mealReception_Record.MR_Dept);
         }
          }
         if(mealReception_Record.MR_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(mealReception_Record.MR_Stat))
         {
            idb.AddParameter("@MR_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MR_Stat", mealReception_Record.MR_Stat);
         }
          }
         if(mealReception_Record.Stat_IsChanged)
         {
         if (mealReception_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", mealReception_Record.Stat);
         }
          }
         if(mealReception_Record.CreateDate_IsChanged)
         {
         if (mealReception_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", mealReception_Record.CreateDate);
         }
          }
         if(mealReception_Record.UpdateDate_IsChanged)
         {
         if (mealReception_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", mealReception_Record.UpdateDate);
         }
          }
         if(mealReception_Record.DeleteDate_IsChanged)
         {
         if (mealReception_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", mealReception_Record.DeleteDate);
         }
          }

         idb.AddParameter("@MR_ID", mealReception_Record.MR_ID);

           
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
      /// 删除餐劵招待记录 MealReception_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal mR_ID)
      {
         string sql = "DELETE MealReception_Record WHERE 1=1  AND MR_ID=@MR_ID ";
         idb.AddParameter("@MR_ID", mR_ID);

           
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
      /// 获取指定的餐劵招待记录 MealReception_Record对象(即:一条记录
      /// </summary>
      public MealReception_Record GetByKey(decimal mR_ID)
      {
         MealReception_Record mealReception_Record = new MealReception_Record();
         string sql = "SELECT  MR_ID,MR_Code,MR_Date,MR_Reason,MR_Num,MR_ObjectiveCompany,MR_Persons,MR_PersonNum,MR_Handler,MR_Operator,MR_OpDate,MR_Company,MR_Dept,MR_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM MealReception_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MR_ID=@MR_ID ";
         idb.AddParameter("@MR_ID", mR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MR_ID"] != DBNull.Value) mealReception_Record.MR_ID = Convert.ToDecimal(dr["MR_ID"]);
            if (dr["MR_Code"] != DBNull.Value) mealReception_Record.MR_Code = Convert.ToString(dr["MR_Code"]);
            if (dr["MR_Date"] != DBNull.Value) mealReception_Record.MR_Date = Convert.ToDateTime(dr["MR_Date"]);
            if (dr["MR_Reason"] != DBNull.Value) mealReception_Record.MR_Reason = Convert.ToString(dr["MR_Reason"]);
            if (dr["MR_Num"] != DBNull.Value) mealReception_Record.MR_Num = Convert.ToInt32(dr["MR_Num"]);
            if (dr["MR_ObjectiveCompany"] != DBNull.Value) mealReception_Record.MR_ObjectiveCompany = Convert.ToString(dr["MR_ObjectiveCompany"]);
            if (dr["MR_Persons"] != DBNull.Value) mealReception_Record.MR_Persons = Convert.ToString(dr["MR_Persons"]);
            if (dr["MR_PersonNum"] != DBNull.Value) mealReception_Record.MR_PersonNum = Convert.ToInt32(dr["MR_PersonNum"]);
            if (dr["MR_Handler"] != DBNull.Value) mealReception_Record.MR_Handler = Convert.ToString(dr["MR_Handler"]);
            if (dr["MR_Operator"] != DBNull.Value) mealReception_Record.MR_Operator = Convert.ToString(dr["MR_Operator"]);
            if (dr["MR_OpDate"] != DBNull.Value) mealReception_Record.MR_OpDate = Convert.ToDateTime(dr["MR_OpDate"]);
            if (dr["MR_Company"] != DBNull.Value) mealReception_Record.MR_Company = Convert.ToString(dr["MR_Company"]);
            if (dr["MR_Dept"] != DBNull.Value) mealReception_Record.MR_Dept = Convert.ToString(dr["MR_Dept"]);
            if (dr["MR_Stat"] != DBNull.Value) mealReception_Record.MR_Stat = Convert.ToString(dr["MR_Stat"]);
            if (dr["Stat"] != DBNull.Value) mealReception_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) mealReception_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) mealReception_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) mealReception_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return mealReception_Record;
      }
      /// <summary>
      /// 获取指定的餐劵招待记录 MealReception_Record对象集合
      /// </summary>
      public List<MealReception_Record> GetListByWhere(string strCondition)
      {
         List<MealReception_Record> ret = new List<MealReception_Record>();
         string sql = "SELECT  MR_ID,MR_Code,MR_Date,MR_Reason,MR_Num,MR_ObjectiveCompany,MR_Persons,MR_PersonNum,MR_Handler,MR_Operator,MR_OpDate,MR_Company,MR_Dept,MR_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM MealReception_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            MealReception_Record mealReception_Record = new MealReception_Record();
            if (dr["MR_ID"] != DBNull.Value) mealReception_Record.MR_ID = Convert.ToDecimal(dr["MR_ID"]);
            if (dr["MR_Code"] != DBNull.Value) mealReception_Record.MR_Code = Convert.ToString(dr["MR_Code"]);
            if (dr["MR_Date"] != DBNull.Value) mealReception_Record.MR_Date = Convert.ToDateTime(dr["MR_Date"]);
            if (dr["MR_Reason"] != DBNull.Value) mealReception_Record.MR_Reason = Convert.ToString(dr["MR_Reason"]);
            if (dr["MR_Num"] != DBNull.Value) mealReception_Record.MR_Num = Convert.ToInt32(dr["MR_Num"]);
            if (dr["MR_ObjectiveCompany"] != DBNull.Value) mealReception_Record.MR_ObjectiveCompany = Convert.ToString(dr["MR_ObjectiveCompany"]);
            if (dr["MR_Persons"] != DBNull.Value) mealReception_Record.MR_Persons = Convert.ToString(dr["MR_Persons"]);
            if (dr["MR_PersonNum"] != DBNull.Value) mealReception_Record.MR_PersonNum = Convert.ToInt32(dr["MR_PersonNum"]);
            if (dr["MR_Handler"] != DBNull.Value) mealReception_Record.MR_Handler = Convert.ToString(dr["MR_Handler"]);
            if (dr["MR_Operator"] != DBNull.Value) mealReception_Record.MR_Operator = Convert.ToString(dr["MR_Operator"]);
            if (dr["MR_OpDate"] != DBNull.Value) mealReception_Record.MR_OpDate = Convert.ToDateTime(dr["MR_OpDate"]);
            if (dr["MR_Company"] != DBNull.Value) mealReception_Record.MR_Company = Convert.ToString(dr["MR_Company"]);
            if (dr["MR_Dept"] != DBNull.Value) mealReception_Record.MR_Dept = Convert.ToString(dr["MR_Dept"]);
            if (dr["MR_Stat"] != DBNull.Value) mealReception_Record.MR_Stat = Convert.ToString(dr["MR_Stat"]);
            if (dr["Stat"] != DBNull.Value) mealReception_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) mealReception_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) mealReception_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) mealReception_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(mealReception_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的餐劵招待记录 MealReception_Record对象(即:一条记录
      /// </summary>
      public List<MealReception_Record> GetAll()
      {
         List<MealReception_Record> ret = new List<MealReception_Record>();
         string sql = "SELECT  MR_ID,MR_Code,MR_Date,MR_Reason,MR_Num,MR_ObjectiveCompany,MR_Persons,MR_PersonNum,MR_Handler,MR_Operator,MR_OpDate,MR_Company,MR_Dept,MR_Stat,Stat,CreateDate,UpdateDate,DeleteDate FROM MealReception_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by MR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            MealReception_Record mealReception_Record = new MealReception_Record();
            if (dr["MR_ID"] != DBNull.Value) mealReception_Record.MR_ID = Convert.ToDecimal(dr["MR_ID"]);
            if (dr["MR_Code"] != DBNull.Value) mealReception_Record.MR_Code = Convert.ToString(dr["MR_Code"]);
            if (dr["MR_Date"] != DBNull.Value) mealReception_Record.MR_Date = Convert.ToDateTime(dr["MR_Date"]);
            if (dr["MR_Reason"] != DBNull.Value) mealReception_Record.MR_Reason = Convert.ToString(dr["MR_Reason"]);
            if (dr["MR_Num"] != DBNull.Value) mealReception_Record.MR_Num = Convert.ToInt32(dr["MR_Num"]);
            if (dr["MR_ObjectiveCompany"] != DBNull.Value) mealReception_Record.MR_ObjectiveCompany = Convert.ToString(dr["MR_ObjectiveCompany"]);
            if (dr["MR_Persons"] != DBNull.Value) mealReception_Record.MR_Persons = Convert.ToString(dr["MR_Persons"]);
            if (dr["MR_PersonNum"] != DBNull.Value) mealReception_Record.MR_PersonNum = Convert.ToInt32(dr["MR_PersonNum"]);
            if (dr["MR_Handler"] != DBNull.Value) mealReception_Record.MR_Handler = Convert.ToString(dr["MR_Handler"]);
            if (dr["MR_Operator"] != DBNull.Value) mealReception_Record.MR_Operator = Convert.ToString(dr["MR_Operator"]);
            if (dr["MR_OpDate"] != DBNull.Value) mealReception_Record.MR_OpDate = Convert.ToDateTime(dr["MR_OpDate"]);
            if (dr["MR_Company"] != DBNull.Value) mealReception_Record.MR_Company = Convert.ToString(dr["MR_Company"]);
            if (dr["MR_Dept"] != DBNull.Value) mealReception_Record.MR_Dept = Convert.ToString(dr["MR_Dept"]);
            if (dr["MR_Stat"] != DBNull.Value) mealReception_Record.MR_Stat = Convert.ToString(dr["MR_Stat"]);
            if (dr["Stat"] != DBNull.Value) mealReception_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) mealReception_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) mealReception_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) mealReception_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(mealReception_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
