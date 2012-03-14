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
   /// 报刊杂志订阅情况
   /// </summary>
   [Serializable]
   public partial class ADOMagazineOrder_Record
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加报刊杂志订阅情况 MagazineOrder_Record对象(即:一条记录)
      /// </summary>
      public int Add(MagazineOrder_Record magazineOrder_Record)
      {
         string sql = "INSERT INTO MagazineOrder_Record (MOR_Code,MOR_Company,MOR_Dept,MOR_Name,MOR_Count,MOR_Issue,MOR_Unit,MOR_Price,MOR_PostalCode,MOR_iType,MOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@MOR_Code,@MOR_Company,@MOR_Dept,@MOR_Name,@MOR_Count,@MOR_Issue,@MOR_Unit,@MOR_Price,@MOR_PostalCode,@MOR_iType,@MOR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Code))
         {
            idb.AddParameter("@MOR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Code", magazineOrder_Record.MOR_Code);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Company))
         {
            idb.AddParameter("@MOR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Company", magazineOrder_Record.MOR_Company);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Dept))
         {
            idb.AddParameter("@MOR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Dept", magazineOrder_Record.MOR_Dept);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Name))
         {
            idb.AddParameter("@MOR_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Name", magazineOrder_Record.MOR_Name);
         }
         if (magazineOrder_Record.MOR_Count == 0)
         {
            idb.AddParameter("@MOR_Count", 0);
         }
         else
         {
            idb.AddParameter("@MOR_Count", magazineOrder_Record.MOR_Count);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Issue))
         {
            idb.AddParameter("@MOR_Issue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Issue", magazineOrder_Record.MOR_Issue);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Unit))
         {
            idb.AddParameter("@MOR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Unit", magazineOrder_Record.MOR_Unit);
         }
         if (magazineOrder_Record.MOR_Price == 0)
         {
            idb.AddParameter("@MOR_Price", 0);
         }
         else
         {
            idb.AddParameter("@MOR_Price", magazineOrder_Record.MOR_Price);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_PostalCode))
         {
            idb.AddParameter("@MOR_PostalCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_PostalCode", magazineOrder_Record.MOR_PostalCode);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_iType))
         {
            idb.AddParameter("@MOR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_iType", magazineOrder_Record.MOR_iType);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Remark))
         {
            idb.AddParameter("@MOR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Remark", magazineOrder_Record.MOR_Remark);
         }
         if (magazineOrder_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", magazineOrder_Record.Stat);
         }
         if (magazineOrder_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", magazineOrder_Record.CreateDate);
         }
         if (magazineOrder_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", magazineOrder_Record.UpdateDate);
         }
         if (magazineOrder_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", magazineOrder_Record.DeleteDate);
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
      /// 添加报刊杂志订阅情况 MagazineOrder_Record对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(MagazineOrder_Record magazineOrder_Record)
      {
         string sql = "INSERT INTO MagazineOrder_Record (MOR_Code,MOR_Company,MOR_Dept,MOR_Name,MOR_Count,MOR_Issue,MOR_Unit,MOR_Price,MOR_PostalCode,MOR_iType,MOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@MOR_Code,@MOR_Company,@MOR_Dept,@MOR_Name,@MOR_Count,@MOR_Issue,@MOR_Unit,@MOR_Price,@MOR_PostalCode,@MOR_iType,@MOR_Remark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Code))
         {
            idb.AddParameter("@MOR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Code", magazineOrder_Record.MOR_Code);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Company))
         {
            idb.AddParameter("@MOR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Company", magazineOrder_Record.MOR_Company);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Dept))
         {
            idb.AddParameter("@MOR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Dept", magazineOrder_Record.MOR_Dept);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Name))
         {
            idb.AddParameter("@MOR_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Name", magazineOrder_Record.MOR_Name);
         }
         if (magazineOrder_Record.MOR_Count == 0)
         {
            idb.AddParameter("@MOR_Count", 0);
         }
         else
         {
            idb.AddParameter("@MOR_Count", magazineOrder_Record.MOR_Count);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Issue))
         {
            idb.AddParameter("@MOR_Issue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Issue", magazineOrder_Record.MOR_Issue);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Unit))
         {
            idb.AddParameter("@MOR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Unit", magazineOrder_Record.MOR_Unit);
         }
         if (magazineOrder_Record.MOR_Price == 0)
         {
            idb.AddParameter("@MOR_Price", 0);
         }
         else
         {
            idb.AddParameter("@MOR_Price", magazineOrder_Record.MOR_Price);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_PostalCode))
         {
            idb.AddParameter("@MOR_PostalCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_PostalCode", magazineOrder_Record.MOR_PostalCode);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_iType))
         {
            idb.AddParameter("@MOR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_iType", magazineOrder_Record.MOR_iType);
         }
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Remark))
         {
            idb.AddParameter("@MOR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Remark", magazineOrder_Record.MOR_Remark);
         }
         if (magazineOrder_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", magazineOrder_Record.Stat);
         }
         if (magazineOrder_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", magazineOrder_Record.CreateDate);
         }
         if (magazineOrder_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", magazineOrder_Record.UpdateDate);
         }
         if (magazineOrder_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", magazineOrder_Record.DeleteDate);
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
      /// 更新报刊杂志订阅情况 MagazineOrder_Record对象(即:一条记录
      /// </summary>
      public int Update(MagazineOrder_Record magazineOrder_Record)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       MagazineOrder_Record       SET ");
            if(magazineOrder_Record.MOR_Code_IsChanged){sbParameter.Append("MOR_Code=@MOR_Code, ");}
      if(magazineOrder_Record.MOR_Company_IsChanged){sbParameter.Append("MOR_Company=@MOR_Company, ");}
      if(magazineOrder_Record.MOR_Dept_IsChanged){sbParameter.Append("MOR_Dept=@MOR_Dept, ");}
      if(magazineOrder_Record.MOR_Name_IsChanged){sbParameter.Append("MOR_Name=@MOR_Name, ");}
      if(magazineOrder_Record.MOR_Count_IsChanged){sbParameter.Append("MOR_Count=@MOR_Count, ");}
      if(magazineOrder_Record.MOR_Issue_IsChanged){sbParameter.Append("MOR_Issue=@MOR_Issue, ");}
      if(magazineOrder_Record.MOR_Unit_IsChanged){sbParameter.Append("MOR_Unit=@MOR_Unit, ");}
      if(magazineOrder_Record.MOR_Price_IsChanged){sbParameter.Append("MOR_Price=@MOR_Price, ");}
      if(magazineOrder_Record.MOR_PostalCode_IsChanged){sbParameter.Append("MOR_PostalCode=@MOR_PostalCode, ");}
      if(magazineOrder_Record.MOR_iType_IsChanged){sbParameter.Append("MOR_iType=@MOR_iType, ");}
      if(magazineOrder_Record.MOR_Remark_IsChanged){sbParameter.Append("MOR_Remark=@MOR_Remark, ");}
      if(magazineOrder_Record.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(magazineOrder_Record.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(magazineOrder_Record.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(magazineOrder_Record.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and MOR_ID=@MOR_ID; " );
      string sql=sb.ToString();
         if(magazineOrder_Record.MOR_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Code))
         {
            idb.AddParameter("@MOR_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Code", magazineOrder_Record.MOR_Code);
         }
          }
         if(magazineOrder_Record.MOR_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Company))
         {
            idb.AddParameter("@MOR_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Company", magazineOrder_Record.MOR_Company);
         }
          }
         if(magazineOrder_Record.MOR_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Dept))
         {
            idb.AddParameter("@MOR_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Dept", magazineOrder_Record.MOR_Dept);
         }
          }
         if(magazineOrder_Record.MOR_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Name))
         {
            idb.AddParameter("@MOR_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Name", magazineOrder_Record.MOR_Name);
         }
          }
         if(magazineOrder_Record.MOR_Count_IsChanged)
         {
         if (magazineOrder_Record.MOR_Count == 0)
         {
            idb.AddParameter("@MOR_Count", 0);
         }
         else
         {
            idb.AddParameter("@MOR_Count", magazineOrder_Record.MOR_Count);
         }
          }
         if(magazineOrder_Record.MOR_Issue_IsChanged)
         {
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Issue))
         {
            idb.AddParameter("@MOR_Issue", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Issue", magazineOrder_Record.MOR_Issue);
         }
          }
         if(magazineOrder_Record.MOR_Unit_IsChanged)
         {
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Unit))
         {
            idb.AddParameter("@MOR_Unit", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Unit", magazineOrder_Record.MOR_Unit);
         }
          }
         if(magazineOrder_Record.MOR_Price_IsChanged)
         {
         if (magazineOrder_Record.MOR_Price == 0)
         {
            idb.AddParameter("@MOR_Price", 0);
         }
         else
         {
            idb.AddParameter("@MOR_Price", magazineOrder_Record.MOR_Price);
         }
          }
         if(magazineOrder_Record.MOR_PostalCode_IsChanged)
         {
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_PostalCode))
         {
            idb.AddParameter("@MOR_PostalCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_PostalCode", magazineOrder_Record.MOR_PostalCode);
         }
          }
         if(magazineOrder_Record.MOR_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_iType))
         {
            idb.AddParameter("@MOR_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_iType", magazineOrder_Record.MOR_iType);
         }
          }
         if(magazineOrder_Record.MOR_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(magazineOrder_Record.MOR_Remark))
         {
            idb.AddParameter("@MOR_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@MOR_Remark", magazineOrder_Record.MOR_Remark);
         }
          }
         if(magazineOrder_Record.Stat_IsChanged)
         {
         if (magazineOrder_Record.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", magazineOrder_Record.Stat);
         }
          }
         if(magazineOrder_Record.CreateDate_IsChanged)
         {
         if (magazineOrder_Record.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", magazineOrder_Record.CreateDate);
         }
          }
         if(magazineOrder_Record.UpdateDate_IsChanged)
         {
         if (magazineOrder_Record.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", magazineOrder_Record.UpdateDate);
         }
          }
         if(magazineOrder_Record.DeleteDate_IsChanged)
         {
         if (magazineOrder_Record.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", magazineOrder_Record.DeleteDate);
         }
          }

         idb.AddParameter("@MOR_ID", magazineOrder_Record.MOR_ID);

           
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
      /// 删除报刊杂志订阅情况 MagazineOrder_Record对象(即:一条记录
      /// </summary>
      public int Delete(decimal mOR_ID)
      {
         string sql = "DELETE MagazineOrder_Record WHERE 1=1  AND MOR_ID=@MOR_ID ";
         idb.AddParameter("@MOR_ID", mOR_ID);

           
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
      /// 获取指定的报刊杂志订阅情况 MagazineOrder_Record对象(即:一条记录
      /// </summary>
      public MagazineOrder_Record GetByKey(decimal mOR_ID)
      {
         MagazineOrder_Record magazineOrder_Record = new MagazineOrder_Record();
         string sql = "SELECT  MOR_ID,MOR_Code,MOR_Company,MOR_Dept,MOR_Name,MOR_Count,MOR_Issue,MOR_Unit,MOR_Price,MOR_PostalCode,MOR_iType,MOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM MagazineOrder_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND MOR_ID=@MOR_ID ";
         idb.AddParameter("@MOR_ID", mOR_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["MOR_ID"] != DBNull.Value) magazineOrder_Record.MOR_ID = Convert.ToDecimal(dr["MOR_ID"]);
            if (dr["MOR_Code"] != DBNull.Value) magazineOrder_Record.MOR_Code = Convert.ToString(dr["MOR_Code"]);
            if (dr["MOR_Company"] != DBNull.Value) magazineOrder_Record.MOR_Company = Convert.ToString(dr["MOR_Company"]);
            if (dr["MOR_Dept"] != DBNull.Value) magazineOrder_Record.MOR_Dept = Convert.ToString(dr["MOR_Dept"]);
            if (dr["MOR_Name"] != DBNull.Value) magazineOrder_Record.MOR_Name = Convert.ToString(dr["MOR_Name"]);
            if (dr["MOR_Count"] != DBNull.Value) magazineOrder_Record.MOR_Count = Convert.ToInt32(dr["MOR_Count"]);
            if (dr["MOR_Issue"] != DBNull.Value) magazineOrder_Record.MOR_Issue = Convert.ToString(dr["MOR_Issue"]);
            if (dr["MOR_Unit"] != DBNull.Value) magazineOrder_Record.MOR_Unit = Convert.ToString(dr["MOR_Unit"]);
            if (dr["MOR_Price"] != DBNull.Value) magazineOrder_Record.MOR_Price = Convert.ToDecimal(dr["MOR_Price"]);
            if (dr["MOR_PostalCode"] != DBNull.Value) magazineOrder_Record.MOR_PostalCode = Convert.ToString(dr["MOR_PostalCode"]);
            if (dr["MOR_iType"] != DBNull.Value) magazineOrder_Record.MOR_iType = Convert.ToString(dr["MOR_iType"]);
            if (dr["MOR_Remark"] != DBNull.Value) magazineOrder_Record.MOR_Remark = Convert.ToString(dr["MOR_Remark"]);
            if (dr["Stat"] != DBNull.Value) magazineOrder_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) magazineOrder_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) magazineOrder_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) magazineOrder_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return magazineOrder_Record;
      }
      /// <summary>
      /// 获取指定的报刊杂志订阅情况 MagazineOrder_Record对象集合
      /// </summary>
      public List<MagazineOrder_Record> GetListByWhere(string strCondition)
      {
         List<MagazineOrder_Record> ret = new List<MagazineOrder_Record>();
         string sql = "SELECT  MOR_ID,MOR_Code,MOR_Company,MOR_Dept,MOR_Name,MOR_Count,MOR_Issue,MOR_Unit,MOR_Price,MOR_PostalCode,MOR_iType,MOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM MagazineOrder_Record WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            MagazineOrder_Record magazineOrder_Record = new MagazineOrder_Record();
            if (dr["MOR_ID"] != DBNull.Value) magazineOrder_Record.MOR_ID = Convert.ToDecimal(dr["MOR_ID"]);
            if (dr["MOR_Code"] != DBNull.Value) magazineOrder_Record.MOR_Code = Convert.ToString(dr["MOR_Code"]);
            if (dr["MOR_Company"] != DBNull.Value) magazineOrder_Record.MOR_Company = Convert.ToString(dr["MOR_Company"]);
            if (dr["MOR_Dept"] != DBNull.Value) magazineOrder_Record.MOR_Dept = Convert.ToString(dr["MOR_Dept"]);
            if (dr["MOR_Name"] != DBNull.Value) magazineOrder_Record.MOR_Name = Convert.ToString(dr["MOR_Name"]);
            if (dr["MOR_Count"] != DBNull.Value) magazineOrder_Record.MOR_Count = Convert.ToInt32(dr["MOR_Count"]);
            if (dr["MOR_Issue"] != DBNull.Value) magazineOrder_Record.MOR_Issue = Convert.ToString(dr["MOR_Issue"]);
            if (dr["MOR_Unit"] != DBNull.Value) magazineOrder_Record.MOR_Unit = Convert.ToString(dr["MOR_Unit"]);
            if (dr["MOR_Price"] != DBNull.Value) magazineOrder_Record.MOR_Price = Convert.ToDecimal(dr["MOR_Price"]);
            if (dr["MOR_PostalCode"] != DBNull.Value) magazineOrder_Record.MOR_PostalCode = Convert.ToString(dr["MOR_PostalCode"]);
            if (dr["MOR_iType"] != DBNull.Value) magazineOrder_Record.MOR_iType = Convert.ToString(dr["MOR_iType"]);
            if (dr["MOR_Remark"] != DBNull.Value) magazineOrder_Record.MOR_Remark = Convert.ToString(dr["MOR_Remark"]);
            if (dr["Stat"] != DBNull.Value) magazineOrder_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) magazineOrder_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) magazineOrder_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) magazineOrder_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(magazineOrder_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的报刊杂志订阅情况 MagazineOrder_Record对象(即:一条记录
      /// </summary>
      public List<MagazineOrder_Record> GetAll()
      {
         List<MagazineOrder_Record> ret = new List<MagazineOrder_Record>();
         string sql = "SELECT  MOR_ID,MOR_Code,MOR_Company,MOR_Dept,MOR_Name,MOR_Count,MOR_Issue,MOR_Unit,MOR_Price,MOR_PostalCode,MOR_iType,MOR_Remark,Stat,CreateDate,UpdateDate,DeleteDate FROM MagazineOrder_Record where 1=1 AND ((Stat is null) or (Stat=0) ) order by MOR_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            MagazineOrder_Record magazineOrder_Record = new MagazineOrder_Record();
            if (dr["MOR_ID"] != DBNull.Value) magazineOrder_Record.MOR_ID = Convert.ToDecimal(dr["MOR_ID"]);
            if (dr["MOR_Code"] != DBNull.Value) magazineOrder_Record.MOR_Code = Convert.ToString(dr["MOR_Code"]);
            if (dr["MOR_Company"] != DBNull.Value) magazineOrder_Record.MOR_Company = Convert.ToString(dr["MOR_Company"]);
            if (dr["MOR_Dept"] != DBNull.Value) magazineOrder_Record.MOR_Dept = Convert.ToString(dr["MOR_Dept"]);
            if (dr["MOR_Name"] != DBNull.Value) magazineOrder_Record.MOR_Name = Convert.ToString(dr["MOR_Name"]);
            if (dr["MOR_Count"] != DBNull.Value) magazineOrder_Record.MOR_Count = Convert.ToInt32(dr["MOR_Count"]);
            if (dr["MOR_Issue"] != DBNull.Value) magazineOrder_Record.MOR_Issue = Convert.ToString(dr["MOR_Issue"]);
            if (dr["MOR_Unit"] != DBNull.Value) magazineOrder_Record.MOR_Unit = Convert.ToString(dr["MOR_Unit"]);
            if (dr["MOR_Price"] != DBNull.Value) magazineOrder_Record.MOR_Price = Convert.ToDecimal(dr["MOR_Price"]);
            if (dr["MOR_PostalCode"] != DBNull.Value) magazineOrder_Record.MOR_PostalCode = Convert.ToString(dr["MOR_PostalCode"]);
            if (dr["MOR_iType"] != DBNull.Value) magazineOrder_Record.MOR_iType = Convert.ToString(dr["MOR_iType"]);
            if (dr["MOR_Remark"] != DBNull.Value) magazineOrder_Record.MOR_Remark = Convert.ToString(dr["MOR_Remark"]);
            if (dr["Stat"] != DBNull.Value) magazineOrder_Record.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) magazineOrder_Record.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) magazineOrder_Record.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) magazineOrder_Record.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(magazineOrder_Record);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
