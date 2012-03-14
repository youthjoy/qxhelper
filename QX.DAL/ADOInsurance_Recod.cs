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
   /// 保险卡领用登记
   /// </summary>
   [Serializable]
   public partial class ADOInsurance_Recod
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加保险卡领用登记 Insurance_Recod对象(即:一条记录)
      /// </summary>
      public int Add(Insurance_Recod insurance_Recod)
      {
         string sql = "INSERT INTO Insurance_Recod (IRecord_Code,IRecord_VehiclesNo,IRecord_VehiclesCode,IRecord_Card,IRecord_InsuranceCompany,IRecord_Period,IRecord_Unit,IRecord_User,IRecord_Date,IRecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@IRecord_Code,@IRecord_VehiclesNo,@IRecord_VehiclesCode,@IRecord_Card,@IRecord_InsuranceCompany,@IRecord_Period,@IRecord_Unit,@IRecord_User,@IRecord_Date,@IRecord_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Code))
         {
            idb.AddParameter("@IRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Code", insurance_Recod.IRecord_Code);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_VehiclesNo))
         {
            idb.AddParameter("@IRecord_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_VehiclesNo", insurance_Recod.IRecord_VehiclesNo);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_VehiclesCode))
         {
            idb.AddParameter("@IRecord_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_VehiclesCode", insurance_Recod.IRecord_VehiclesCode);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Card))
         {
            idb.AddParameter("@IRecord_Card", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Card", insurance_Recod.IRecord_Card);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_InsuranceCompany))
         {
            idb.AddParameter("@IRecord_InsuranceCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_InsuranceCompany", insurance_Recod.IRecord_InsuranceCompany);
         }
         if (insurance_Recod.IRecord_Period == 0)
         {
            idb.AddParameter("@IRecord_Period", 0);
         }
         else
         {
            idb.AddParameter("@IRecord_Period", insurance_Recod.IRecord_Period);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Unit))
         {
            idb.AddParameter("@IRecord_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Unit", insurance_Recod.IRecord_Unit);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_User))
         {
            idb.AddParameter("@IRecord_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_User", insurance_Recod.IRecord_User);
         }
         if (insurance_Recod.IRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@IRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Date", insurance_Recod.IRecord_Date);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Remark))
         {
            idb.AddParameter("@IRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Remark", insurance_Recod.IRecord_Remark);
         }
         if (insurance_Recod.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", insurance_Recod.Stat);
         }
         if (insurance_Recod.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", insurance_Recod.CreateDate);
         }
         if (insurance_Recod.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", insurance_Recod.UpdateDate);
         }
         if (insurance_Recod.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", insurance_Recod.DeleteDate);
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
      /// 添加保险卡领用登记 Insurance_Recod对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Insurance_Recod insurance_Recod)
      {
         string sql = "INSERT INTO Insurance_Recod (IRecord_Code,IRecord_VehiclesNo,IRecord_VehiclesCode,IRecord_Card,IRecord_InsuranceCompany,IRecord_Period,IRecord_Unit,IRecord_User,IRecord_Date,IRecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@IRecord_Code,@IRecord_VehiclesNo,@IRecord_VehiclesCode,@IRecord_Card,@IRecord_InsuranceCompany,@IRecord_Period,@IRecord_Unit,@IRecord_User,@IRecord_Date,@IRecord_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Code))
         {
            idb.AddParameter("@IRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Code", insurance_Recod.IRecord_Code);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_VehiclesNo))
         {
            idb.AddParameter("@IRecord_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_VehiclesNo", insurance_Recod.IRecord_VehiclesNo);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_VehiclesCode))
         {
            idb.AddParameter("@IRecord_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_VehiclesCode", insurance_Recod.IRecord_VehiclesCode);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Card))
         {
            idb.AddParameter("@IRecord_Card", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Card", insurance_Recod.IRecord_Card);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_InsuranceCompany))
         {
            idb.AddParameter("@IRecord_InsuranceCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_InsuranceCompany", insurance_Recod.IRecord_InsuranceCompany);
         }
         if (insurance_Recod.IRecord_Period == 0)
         {
            idb.AddParameter("@IRecord_Period", 0);
         }
         else
         {
            idb.AddParameter("@IRecord_Period", insurance_Recod.IRecord_Period);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Unit))
         {
            idb.AddParameter("@IRecord_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Unit", insurance_Recod.IRecord_Unit);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_User))
         {
            idb.AddParameter("@IRecord_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_User", insurance_Recod.IRecord_User);
         }
         if (insurance_Recod.IRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@IRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Date", insurance_Recod.IRecord_Date);
         }
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Remark))
         {
            idb.AddParameter("@IRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Remark", insurance_Recod.IRecord_Remark);
         }
         if (insurance_Recod.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", insurance_Recod.Stat);
         }
         if (insurance_Recod.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", insurance_Recod.CreateDate);
         }
         if (insurance_Recod.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", insurance_Recod.UpdateDate);
         }
         if (insurance_Recod.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", insurance_Recod.DeleteDate);
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
      /// 更新保险卡领用登记 Insurance_Recod对象(即:一条记录
      /// </summary>
      public int Update(Insurance_Recod insurance_Recod)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Insurance_Recod       SET ");
            if(insurance_Recod.IRecord_Code_IsChanged){sbParameter.Append("IRecord_Code=@IRecord_Code, ");}
      if(insurance_Recod.IRecord_VehiclesNo_IsChanged){sbParameter.Append("IRecord_VehiclesNo=@IRecord_VehiclesNo, ");}
      if(insurance_Recod.IRecord_VehiclesCode_IsChanged){sbParameter.Append("IRecord_VehiclesCode=@IRecord_VehiclesCode, ");}
      if(insurance_Recod.IRecord_Card_IsChanged){sbParameter.Append("IRecord_Card=@IRecord_Card, ");}
      if(insurance_Recod.IRecord_InsuranceCompany_IsChanged){sbParameter.Append("IRecord_InsuranceCompany=@IRecord_InsuranceCompany, ");}
      if(insurance_Recod.IRecord_Period_IsChanged){sbParameter.Append("IRecord_Period=@IRecord_Period, ");}
      if(insurance_Recod.IRecord_Unit_IsChanged){sbParameter.Append("IRecord_Unit=@IRecord_Unit, ");}
      if(insurance_Recod.IRecord_User_IsChanged){sbParameter.Append("IRecord_User=@IRecord_User, ");}
      if(insurance_Recod.IRecord_Date_IsChanged){sbParameter.Append("IRecord_Date=@IRecord_Date, ");}
      if(insurance_Recod.IRecord_Remark_IsChanged){sbParameter.Append("IRecord_Remark=@IRecord_Remark, ");}
      if(insurance_Recod.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(insurance_Recod.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(insurance_Recod.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(insurance_Recod.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and IRecord_ID=@IRecord_ID; " );
      string sql=sb.ToString();
         if(insurance_Recod.IRecord_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Code))
         {
            idb.AddParameter("@IRecord_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Code", insurance_Recod.IRecord_Code);
         }
          }
         if(insurance_Recod.IRecord_VehiclesNo_IsChanged)
         {
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_VehiclesNo))
         {
            idb.AddParameter("@IRecord_VehiclesNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_VehiclesNo", insurance_Recod.IRecord_VehiclesNo);
         }
          }
         if(insurance_Recod.IRecord_VehiclesCode_IsChanged)
         {
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_VehiclesCode))
         {
            idb.AddParameter("@IRecord_VehiclesCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_VehiclesCode", insurance_Recod.IRecord_VehiclesCode);
         }
          }
         if(insurance_Recod.IRecord_Card_IsChanged)
         {
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Card))
         {
            idb.AddParameter("@IRecord_Card", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Card", insurance_Recod.IRecord_Card);
         }
          }
         if(insurance_Recod.IRecord_InsuranceCompany_IsChanged)
         {
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_InsuranceCompany))
         {
            idb.AddParameter("@IRecord_InsuranceCompany", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_InsuranceCompany", insurance_Recod.IRecord_InsuranceCompany);
         }
          }
         if(insurance_Recod.IRecord_Period_IsChanged)
         {
         if (insurance_Recod.IRecord_Period == 0)
         {
            idb.AddParameter("@IRecord_Period", 0);
         }
         else
         {
            idb.AddParameter("@IRecord_Period", insurance_Recod.IRecord_Period);
         }
          }
         if(insurance_Recod.IRecord_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Unit))
         {
            idb.AddParameter("@IRecord_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Unit", insurance_Recod.IRecord_Unit);
         }
          }
         if(insurance_Recod.IRecord_User_IsChanged)
         {
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_User))
         {
            idb.AddParameter("@IRecord_User", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_User", insurance_Recod.IRecord_User);
         }
          }
         if(insurance_Recod.IRecord_Date_IsChanged)
         {
         if (insurance_Recod.IRecord_Date == DateTime.MinValue)
         {
            idb.AddParameter("@IRecord_Date", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Date", insurance_Recod.IRecord_Date);
         }
          }
         if(insurance_Recod.IRecord_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(insurance_Recod.IRecord_Remark))
         {
            idb.AddParameter("@IRecord_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@IRecord_Remark", insurance_Recod.IRecord_Remark);
         }
          }
         if(insurance_Recod.Stat_IsChanged)
         {
         if (insurance_Recod.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", insurance_Recod.Stat);
         }
          }
         if(insurance_Recod.CreateDate_IsChanged)
         {
         if (insurance_Recod.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", insurance_Recod.CreateDate);
         }
          }
         if(insurance_Recod.UpdateDate_IsChanged)
         {
         if (insurance_Recod.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", insurance_Recod.UpdateDate);
         }
          }
         if(insurance_Recod.DeleteDate_IsChanged)
         {
         if (insurance_Recod.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", insurance_Recod.DeleteDate);
         }
          }

         idb.AddParameter("@IRecord_ID", insurance_Recod.IRecord_ID);

           
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
      /// 删除保险卡领用登记 Insurance_Recod对象(即:一条记录
      /// </summary>
      public int Delete(decimal iRecord_ID)
      {
         string sql = "DELETE Insurance_Recod WHERE 1=1  AND IRecord_ID=@IRecord_ID ";
         idb.AddParameter("@IRecord_ID", iRecord_ID);

           
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
      /// 获取指定的保险卡领用登记 Insurance_Recod对象(即:一条记录
      /// </summary>
      public Insurance_Recod GetByKey(decimal iRecord_ID)
      {
         Insurance_Recod insurance_Recod = new Insurance_Recod();
         string sql = "SELECT  IRecord_ID,IRecord_Code,IRecord_VehiclesNo,IRecord_VehiclesCode,IRecord_Card,IRecord_InsuranceCompany,IRecord_Period,IRecord_Unit,IRecord_User,IRecord_Date,IRecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Insurance_Recod WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND IRecord_ID=@IRecord_ID ";
         idb.AddParameter("@IRecord_ID", iRecord_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["IRecord_ID"] != DBNull.Value) insurance_Recod.IRecord_ID = Convert.ToDecimal(dr["IRecord_ID"]);
            if (dr["IRecord_Code"] != DBNull.Value) insurance_Recod.IRecord_Code = Convert.ToString(dr["IRecord_Code"]);
            if (dr["IRecord_VehiclesNo"] != DBNull.Value) insurance_Recod.IRecord_VehiclesNo = Convert.ToString(dr["IRecord_VehiclesNo"]);
            if (dr["IRecord_VehiclesCode"] != DBNull.Value) insurance_Recod.IRecord_VehiclesCode = Convert.ToString(dr["IRecord_VehiclesCode"]);
            if (dr["IRecord_Card"] != DBNull.Value) insurance_Recod.IRecord_Card = Convert.ToString(dr["IRecord_Card"]);
            if (dr["IRecord_InsuranceCompany"] != DBNull.Value) insurance_Recod.IRecord_InsuranceCompany = Convert.ToString(dr["IRecord_InsuranceCompany"]);
            if (dr["IRecord_Period"] != DBNull.Value) insurance_Recod.IRecord_Period = Convert.ToSingle(dr["IRecord_Period"]);
            if (dr["IRecord_Unit"] != DBNull.Value) insurance_Recod.IRecord_Unit = Convert.ToString(dr["IRecord_Unit"]);
            if (dr["IRecord_User"] != DBNull.Value) insurance_Recod.IRecord_User = Convert.ToString(dr["IRecord_User"]);
            if (dr["IRecord_Date"] != DBNull.Value) insurance_Recod.IRecord_Date = Convert.ToDateTime(dr["IRecord_Date"]);
            if (dr["IRecord_Remark"] != DBNull.Value) insurance_Recod.IRecord_Remark = Convert.ToString(dr["IRecord_Remark"]);
            if (dr["Stat"] != DBNull.Value) insurance_Recod.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) insurance_Recod.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) insurance_Recod.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) insurance_Recod.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return insurance_Recod;
      }
      /// <summary>
      /// 获取指定的保险卡领用登记 Insurance_Recod对象集合
      /// </summary>
      public List<Insurance_Recod> GetListByWhere(string strCondition)
      {
         List<Insurance_Recod> ret = new List<Insurance_Recod>();
         string sql = "SELECT  IRecord_ID,IRecord_Code,IRecord_VehiclesNo,IRecord_VehiclesCode,IRecord_Card,IRecord_InsuranceCompany,IRecord_Period,IRecord_Unit,IRecord_User,IRecord_Date,IRecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Insurance_Recod WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Insurance_Recod insurance_Recod = new Insurance_Recod();
            if (dr["IRecord_ID"] != DBNull.Value) insurance_Recod.IRecord_ID = Convert.ToDecimal(dr["IRecord_ID"]);
            if (dr["IRecord_Code"] != DBNull.Value) insurance_Recod.IRecord_Code = Convert.ToString(dr["IRecord_Code"]);
            if (dr["IRecord_VehiclesNo"] != DBNull.Value) insurance_Recod.IRecord_VehiclesNo = Convert.ToString(dr["IRecord_VehiclesNo"]);
            if (dr["IRecord_VehiclesCode"] != DBNull.Value) insurance_Recod.IRecord_VehiclesCode = Convert.ToString(dr["IRecord_VehiclesCode"]);
            if (dr["IRecord_Card"] != DBNull.Value) insurance_Recod.IRecord_Card = Convert.ToString(dr["IRecord_Card"]);
            if (dr["IRecord_InsuranceCompany"] != DBNull.Value) insurance_Recod.IRecord_InsuranceCompany = Convert.ToString(dr["IRecord_InsuranceCompany"]);
            if (dr["IRecord_Period"] != DBNull.Value) insurance_Recod.IRecord_Period = Convert.ToSingle(dr["IRecord_Period"]);
            if (dr["IRecord_Unit"] != DBNull.Value) insurance_Recod.IRecord_Unit = Convert.ToString(dr["IRecord_Unit"]);
            if (dr["IRecord_User"] != DBNull.Value) insurance_Recod.IRecord_User = Convert.ToString(dr["IRecord_User"]);
            if (dr["IRecord_Date"] != DBNull.Value) insurance_Recod.IRecord_Date = Convert.ToDateTime(dr["IRecord_Date"]);
            if (dr["IRecord_Remark"] != DBNull.Value) insurance_Recod.IRecord_Remark = Convert.ToString(dr["IRecord_Remark"]);
            if (dr["Stat"] != DBNull.Value) insurance_Recod.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) insurance_Recod.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) insurance_Recod.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) insurance_Recod.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(insurance_Recod);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的保险卡领用登记 Insurance_Recod对象(即:一条记录
      /// </summary>
      public List<Insurance_Recod> GetAll()
      {
         List<Insurance_Recod> ret = new List<Insurance_Recod>();
         string sql = "SELECT  IRecord_ID,IRecord_Code,IRecord_VehiclesNo,IRecord_VehiclesCode,IRecord_Card,IRecord_InsuranceCompany,IRecord_Period,IRecord_Unit,IRecord_User,IRecord_Date,IRecord_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM Insurance_Recod where 1=1 AND ((Stat is null) or (Stat=0) ) order by IRecord_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Insurance_Recod insurance_Recod = new Insurance_Recod();
            if (dr["IRecord_ID"] != DBNull.Value) insurance_Recod.IRecord_ID = Convert.ToDecimal(dr["IRecord_ID"]);
            if (dr["IRecord_Code"] != DBNull.Value) insurance_Recod.IRecord_Code = Convert.ToString(dr["IRecord_Code"]);
            if (dr["IRecord_VehiclesNo"] != DBNull.Value) insurance_Recod.IRecord_VehiclesNo = Convert.ToString(dr["IRecord_VehiclesNo"]);
            if (dr["IRecord_VehiclesCode"] != DBNull.Value) insurance_Recod.IRecord_VehiclesCode = Convert.ToString(dr["IRecord_VehiclesCode"]);
            if (dr["IRecord_Card"] != DBNull.Value) insurance_Recod.IRecord_Card = Convert.ToString(dr["IRecord_Card"]);
            if (dr["IRecord_InsuranceCompany"] != DBNull.Value) insurance_Recod.IRecord_InsuranceCompany = Convert.ToString(dr["IRecord_InsuranceCompany"]);
            if (dr["IRecord_Period"] != DBNull.Value) insurance_Recod.IRecord_Period = Convert.ToSingle(dr["IRecord_Period"]);
            if (dr["IRecord_Unit"] != DBNull.Value) insurance_Recod.IRecord_Unit = Convert.ToString(dr["IRecord_Unit"]);
            if (dr["IRecord_User"] != DBNull.Value) insurance_Recod.IRecord_User = Convert.ToString(dr["IRecord_User"]);
            if (dr["IRecord_Date"] != DBNull.Value) insurance_Recod.IRecord_Date = Convert.ToDateTime(dr["IRecord_Date"]);
            if (dr["IRecord_Remark"] != DBNull.Value) insurance_Recod.IRecord_Remark = Convert.ToString(dr["IRecord_Remark"]);
            if (dr["Stat"] != DBNull.Value) insurance_Recod.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) insurance_Recod.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) insurance_Recod.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) insurance_Recod.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(insurance_Recod);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
