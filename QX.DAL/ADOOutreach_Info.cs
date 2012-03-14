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
   /// 外联单位管理
   /// </summary>
   [Serializable]
   public partial class ADOOutreach_Info
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加外联单位管理 Outreach_Info对象(即:一条记录)
      /// </summary>
      public int Add(Outreach_Info outreach_Info)
      {
         string sql = "INSERT INTO Outreach_Info (OI_Code,OI_Name,OI_Address,OI_Telephone,OI_CompanyType,OI_iType,OI_MainContactor,OI_ContactPhone,OI_Contactor,Ol_Attachment,OI_Remark,OI_Company,OI_Dept,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@OI_Code,@OI_Name,@OI_Address,@OI_Telephone,@OI_CompanyType,@OI_iType,@OI_MainContactor,@OI_ContactPhone,@OI_Contactor,@Ol_Attachment,@OI_Remark,@OI_Company,@OI_Dept,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(outreach_Info.OI_Code))
         {
            idb.AddParameter("@OI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Code", outreach_Info.OI_Code);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Name))
         {
            idb.AddParameter("@OI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Name", outreach_Info.OI_Name);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Address))
         {
            idb.AddParameter("@OI_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Address", outreach_Info.OI_Address);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Telephone))
         {
            idb.AddParameter("@OI_Telephone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Telephone", outreach_Info.OI_Telephone);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_CompanyType))
         {
            idb.AddParameter("@OI_CompanyType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_CompanyType", outreach_Info.OI_CompanyType);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_iType))
         {
            idb.AddParameter("@OI_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_iType", outreach_Info.OI_iType);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_MainContactor))
         {
            idb.AddParameter("@OI_MainContactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_MainContactor", outreach_Info.OI_MainContactor);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_ContactPhone))
         {
            idb.AddParameter("@OI_ContactPhone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_ContactPhone", outreach_Info.OI_ContactPhone);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Contactor))
         {
            idb.AddParameter("@OI_Contactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Contactor", outreach_Info.OI_Contactor);
         }
         if (string.IsNullOrEmpty(outreach_Info.Ol_Attachment))
         {
            idb.AddParameter("@Ol_Attachment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Ol_Attachment", outreach_Info.Ol_Attachment);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Remark))
         {
            idb.AddParameter("@OI_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Remark", outreach_Info.OI_Remark);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Company))
         {
            idb.AddParameter("@OI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Company", outreach_Info.OI_Company);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Dept))
         {
            idb.AddParameter("@OI_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Dept", outreach_Info.OI_Dept);
         }
         if (outreach_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", outreach_Info.Stat);
         }
         if (outreach_Info.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", outreach_Info.CreateDate);
         }
         if (outreach_Info.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", outreach_Info.UpdateDate);
         }
         if (outreach_Info.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", outreach_Info.DeleteDate);
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
      /// 添加外联单位管理 Outreach_Info对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Outreach_Info outreach_Info)
      {
         string sql = "INSERT INTO Outreach_Info (OI_Code,OI_Name,OI_Address,OI_Telephone,OI_CompanyType,OI_iType,OI_MainContactor,OI_ContactPhone,OI_Contactor,Ol_Attachment,OI_Remark,OI_Company,OI_Dept,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@OI_Code,@OI_Name,@OI_Address,@OI_Telephone,@OI_CompanyType,@OI_iType,@OI_MainContactor,@OI_ContactPhone,@OI_Contactor,@Ol_Attachment,@OI_Remark,@OI_Company,@OI_Dept,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(outreach_Info.OI_Code))
         {
            idb.AddParameter("@OI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Code", outreach_Info.OI_Code);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Name))
         {
            idb.AddParameter("@OI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Name", outreach_Info.OI_Name);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Address))
         {
            idb.AddParameter("@OI_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Address", outreach_Info.OI_Address);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Telephone))
         {
            idb.AddParameter("@OI_Telephone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Telephone", outreach_Info.OI_Telephone);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_CompanyType))
         {
            idb.AddParameter("@OI_CompanyType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_CompanyType", outreach_Info.OI_CompanyType);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_iType))
         {
            idb.AddParameter("@OI_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_iType", outreach_Info.OI_iType);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_MainContactor))
         {
            idb.AddParameter("@OI_MainContactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_MainContactor", outreach_Info.OI_MainContactor);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_ContactPhone))
         {
            idb.AddParameter("@OI_ContactPhone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_ContactPhone", outreach_Info.OI_ContactPhone);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Contactor))
         {
            idb.AddParameter("@OI_Contactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Contactor", outreach_Info.OI_Contactor);
         }
         if (string.IsNullOrEmpty(outreach_Info.Ol_Attachment))
         {
            idb.AddParameter("@Ol_Attachment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Ol_Attachment", outreach_Info.Ol_Attachment);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Remark))
         {
            idb.AddParameter("@OI_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Remark", outreach_Info.OI_Remark);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Company))
         {
            idb.AddParameter("@OI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Company", outreach_Info.OI_Company);
         }
         if (string.IsNullOrEmpty(outreach_Info.OI_Dept))
         {
            idb.AddParameter("@OI_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Dept", outreach_Info.OI_Dept);
         }
         if (outreach_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", outreach_Info.Stat);
         }
         if (outreach_Info.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", outreach_Info.CreateDate);
         }
         if (outreach_Info.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", outreach_Info.UpdateDate);
         }
         if (outreach_Info.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", outreach_Info.DeleteDate);
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
      /// 更新外联单位管理 Outreach_Info对象(即:一条记录
      /// </summary>
      public int Update(Outreach_Info outreach_Info)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Outreach_Info       SET ");
            if(outreach_Info.OI_Code_IsChanged){sbParameter.Append("OI_Code=@OI_Code, ");}
      if(outreach_Info.OI_Name_IsChanged){sbParameter.Append("OI_Name=@OI_Name, ");}
      if(outreach_Info.OI_Address_IsChanged){sbParameter.Append("OI_Address=@OI_Address, ");}
      if(outreach_Info.OI_Telephone_IsChanged){sbParameter.Append("OI_Telephone=@OI_Telephone, ");}
      if(outreach_Info.OI_CompanyType_IsChanged){sbParameter.Append("OI_CompanyType=@OI_CompanyType, ");}
      if(outreach_Info.OI_iType_IsChanged){sbParameter.Append("OI_iType=@OI_iType, ");}
      if(outreach_Info.OI_MainContactor_IsChanged){sbParameter.Append("OI_MainContactor=@OI_MainContactor, ");}
      if(outreach_Info.OI_ContactPhone_IsChanged){sbParameter.Append("OI_ContactPhone=@OI_ContactPhone, ");}
      if(outreach_Info.OI_Contactor_IsChanged){sbParameter.Append("OI_Contactor=@OI_Contactor, ");}
      if(outreach_Info.Ol_Attachment_IsChanged){sbParameter.Append("Ol_Attachment=@Ol_Attachment, ");}
      if(outreach_Info.OI_Remark_IsChanged){sbParameter.Append("OI_Remark=@OI_Remark, ");}
      if(outreach_Info.OI_Company_IsChanged){sbParameter.Append("OI_Company=@OI_Company, ");}
      if(outreach_Info.OI_Dept_IsChanged){sbParameter.Append("OI_Dept=@OI_Dept, ");}
      if(outreach_Info.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(outreach_Info.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(outreach_Info.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(outreach_Info.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and OI_ID=@OI_ID; " );
      string sql=sb.ToString();
         if(outreach_Info.OI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_Code))
         {
            idb.AddParameter("@OI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Code", outreach_Info.OI_Code);
         }
          }
         if(outreach_Info.OI_Name_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_Name))
         {
            idb.AddParameter("@OI_Name", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Name", outreach_Info.OI_Name);
         }
          }
         if(outreach_Info.OI_Address_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_Address))
         {
            idb.AddParameter("@OI_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Address", outreach_Info.OI_Address);
         }
          }
         if(outreach_Info.OI_Telephone_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_Telephone))
         {
            idb.AddParameter("@OI_Telephone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Telephone", outreach_Info.OI_Telephone);
         }
          }
         if(outreach_Info.OI_CompanyType_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_CompanyType))
         {
            idb.AddParameter("@OI_CompanyType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_CompanyType", outreach_Info.OI_CompanyType);
         }
          }
         if(outreach_Info.OI_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_iType))
         {
            idb.AddParameter("@OI_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_iType", outreach_Info.OI_iType);
         }
          }
         if(outreach_Info.OI_MainContactor_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_MainContactor))
         {
            idb.AddParameter("@OI_MainContactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_MainContactor", outreach_Info.OI_MainContactor);
         }
          }
         if(outreach_Info.OI_ContactPhone_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_ContactPhone))
         {
            idb.AddParameter("@OI_ContactPhone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_ContactPhone", outreach_Info.OI_ContactPhone);
         }
          }
         if(outreach_Info.OI_Contactor_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_Contactor))
         {
            idb.AddParameter("@OI_Contactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Contactor", outreach_Info.OI_Contactor);
         }
          }
         if(outreach_Info.Ol_Attachment_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.Ol_Attachment))
         {
            idb.AddParameter("@Ol_Attachment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@Ol_Attachment", outreach_Info.Ol_Attachment);
         }
          }
         if(outreach_Info.OI_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_Remark))
         {
            idb.AddParameter("@OI_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Remark", outreach_Info.OI_Remark);
         }
          }
         if(outreach_Info.OI_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_Company))
         {
            idb.AddParameter("@OI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Company", outreach_Info.OI_Company);
         }
          }
         if(outreach_Info.OI_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Info.OI_Dept))
         {
            idb.AddParameter("@OI_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OI_Dept", outreach_Info.OI_Dept);
         }
          }
         if(outreach_Info.Stat_IsChanged)
         {
         if (outreach_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", outreach_Info.Stat);
         }
          }
         if(outreach_Info.CreateDate_IsChanged)
         {
         if (outreach_Info.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", outreach_Info.CreateDate);
         }
          }
         if(outreach_Info.UpdateDate_IsChanged)
         {
         if (outreach_Info.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", outreach_Info.UpdateDate);
         }
          }
         if(outreach_Info.DeleteDate_IsChanged)
         {
         if (outreach_Info.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", outreach_Info.DeleteDate);
         }
          }

         idb.AddParameter("@OI_ID", outreach_Info.OI_ID);

           
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
      /// 删除外联单位管理 Outreach_Info对象(即:一条记录
      /// </summary>
      public int Delete(decimal oI_ID)
      {
         string sql = "DELETE Outreach_Info WHERE 1=1  AND OI_ID=@OI_ID ";
         idb.AddParameter("@OI_ID", oI_ID);

           
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
      /// 获取指定的外联单位管理 Outreach_Info对象(即:一条记录
      /// </summary>
      public Outreach_Info GetByKey(decimal oI_ID)
      {
         Outreach_Info outreach_Info = new Outreach_Info();
         string sql = "SELECT  OI_ID,OI_Code,OI_Name,OI_Address,OI_Telephone,OI_CompanyType,OI_iType,OI_MainContactor,OI_ContactPhone,OI_Contactor,Ol_Attachment,OI_Remark,OI_Company,OI_Dept,Stat,CreateDate,UpdateDate,DeleteDate FROM Outreach_Info WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND OI_ID=@OI_ID ";
         idb.AddParameter("@OI_ID", oI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["OI_ID"] != DBNull.Value) outreach_Info.OI_ID = Convert.ToDecimal(dr["OI_ID"]);
            if (dr["OI_Code"] != DBNull.Value) outreach_Info.OI_Code = Convert.ToString(dr["OI_Code"]);
            if (dr["OI_Name"] != DBNull.Value) outreach_Info.OI_Name = Convert.ToString(dr["OI_Name"]);
            if (dr["OI_Address"] != DBNull.Value) outreach_Info.OI_Address = Convert.ToString(dr["OI_Address"]);
            if (dr["OI_Telephone"] != DBNull.Value) outreach_Info.OI_Telephone = Convert.ToString(dr["OI_Telephone"]);
            if (dr["OI_CompanyType"] != DBNull.Value) outreach_Info.OI_CompanyType = Convert.ToString(dr["OI_CompanyType"]);
            if (dr["OI_iType"] != DBNull.Value) outreach_Info.OI_iType = Convert.ToString(dr["OI_iType"]);
            if (dr["OI_MainContactor"] != DBNull.Value) outreach_Info.OI_MainContactor = Convert.ToString(dr["OI_MainContactor"]);
            if (dr["OI_ContactPhone"] != DBNull.Value) outreach_Info.OI_ContactPhone = Convert.ToString(dr["OI_ContactPhone"]);
            if (dr["OI_Contactor"] != DBNull.Value) outreach_Info.OI_Contactor = Convert.ToString(dr["OI_Contactor"]);
            if (dr["Ol_Attachment"] != DBNull.Value) outreach_Info.Ol_Attachment = Convert.ToString(dr["Ol_Attachment"]);
            if (dr["OI_Remark"] != DBNull.Value) outreach_Info.OI_Remark = Convert.ToString(dr["OI_Remark"]);
            if (dr["OI_Company"] != DBNull.Value) outreach_Info.OI_Company = Convert.ToString(dr["OI_Company"]);
            if (dr["OI_Dept"] != DBNull.Value) outreach_Info.OI_Dept = Convert.ToString(dr["OI_Dept"]);
            if (dr["Stat"] != DBNull.Value) outreach_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) outreach_Info.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) outreach_Info.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) outreach_Info.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return outreach_Info;
      }
      /// <summary>
      /// 获取指定的外联单位管理 Outreach_Info对象集合
      /// </summary>
      public List<Outreach_Info> GetListByWhere(string strCondition)
      {
         List<Outreach_Info> ret = new List<Outreach_Info>();
         string sql = "SELECT  OI_ID,OI_Code,OI_Name,OI_Address,OI_Telephone,OI_CompanyType,OI_iType,OI_MainContactor,OI_ContactPhone,OI_Contactor,Ol_Attachment,OI_Remark,OI_Company,OI_Dept,Stat,CreateDate,UpdateDate,DeleteDate FROM Outreach_Info WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Outreach_Info outreach_Info = new Outreach_Info();
            if (dr["OI_ID"] != DBNull.Value) outreach_Info.OI_ID = Convert.ToDecimal(dr["OI_ID"]);
            if (dr["OI_Code"] != DBNull.Value) outreach_Info.OI_Code = Convert.ToString(dr["OI_Code"]);
            if (dr["OI_Name"] != DBNull.Value) outreach_Info.OI_Name = Convert.ToString(dr["OI_Name"]);
            if (dr["OI_Address"] != DBNull.Value) outreach_Info.OI_Address = Convert.ToString(dr["OI_Address"]);
            if (dr["OI_Telephone"] != DBNull.Value) outreach_Info.OI_Telephone = Convert.ToString(dr["OI_Telephone"]);
            if (dr["OI_CompanyType"] != DBNull.Value) outreach_Info.OI_CompanyType = Convert.ToString(dr["OI_CompanyType"]);
            if (dr["OI_iType"] != DBNull.Value) outreach_Info.OI_iType = Convert.ToString(dr["OI_iType"]);
            if (dr["OI_MainContactor"] != DBNull.Value) outreach_Info.OI_MainContactor = Convert.ToString(dr["OI_MainContactor"]);
            if (dr["OI_ContactPhone"] != DBNull.Value) outreach_Info.OI_ContactPhone = Convert.ToString(dr["OI_ContactPhone"]);
            if (dr["OI_Contactor"] != DBNull.Value) outreach_Info.OI_Contactor = Convert.ToString(dr["OI_Contactor"]);
            if (dr["Ol_Attachment"] != DBNull.Value) outreach_Info.Ol_Attachment = Convert.ToString(dr["Ol_Attachment"]);
            if (dr["OI_Remark"] != DBNull.Value) outreach_Info.OI_Remark = Convert.ToString(dr["OI_Remark"]);
            if (dr["OI_Company"] != DBNull.Value) outreach_Info.OI_Company = Convert.ToString(dr["OI_Company"]);
            if (dr["OI_Dept"] != DBNull.Value) outreach_Info.OI_Dept = Convert.ToString(dr["OI_Dept"]);
            if (dr["Stat"] != DBNull.Value) outreach_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) outreach_Info.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) outreach_Info.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) outreach_Info.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(outreach_Info);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的外联单位管理 Outreach_Info对象(即:一条记录
      /// </summary>
      public List<Outreach_Info> GetAll()
      {
         List<Outreach_Info> ret = new List<Outreach_Info>();
         string sql = "SELECT  OI_ID,OI_Code,OI_Name,OI_Address,OI_Telephone,OI_CompanyType,OI_iType,OI_MainContactor,OI_ContactPhone,OI_Contactor,Ol_Attachment,OI_Remark,OI_Company,OI_Dept,Stat,CreateDate,UpdateDate,DeleteDate FROM Outreach_Info where 1=1 AND ((Stat is null) or (Stat=0) ) order by OI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Outreach_Info outreach_Info = new Outreach_Info();
            if (dr["OI_ID"] != DBNull.Value) outreach_Info.OI_ID = Convert.ToDecimal(dr["OI_ID"]);
            if (dr["OI_Code"] != DBNull.Value) outreach_Info.OI_Code = Convert.ToString(dr["OI_Code"]);
            if (dr["OI_Name"] != DBNull.Value) outreach_Info.OI_Name = Convert.ToString(dr["OI_Name"]);
            if (dr["OI_Address"] != DBNull.Value) outreach_Info.OI_Address = Convert.ToString(dr["OI_Address"]);
            if (dr["OI_Telephone"] != DBNull.Value) outreach_Info.OI_Telephone = Convert.ToString(dr["OI_Telephone"]);
            if (dr["OI_CompanyType"] != DBNull.Value) outreach_Info.OI_CompanyType = Convert.ToString(dr["OI_CompanyType"]);
            if (dr["OI_iType"] != DBNull.Value) outreach_Info.OI_iType = Convert.ToString(dr["OI_iType"]);
            if (dr["OI_MainContactor"] != DBNull.Value) outreach_Info.OI_MainContactor = Convert.ToString(dr["OI_MainContactor"]);
            if (dr["OI_ContactPhone"] != DBNull.Value) outreach_Info.OI_ContactPhone = Convert.ToString(dr["OI_ContactPhone"]);
            if (dr["OI_Contactor"] != DBNull.Value) outreach_Info.OI_Contactor = Convert.ToString(dr["OI_Contactor"]);
            if (dr["Ol_Attachment"] != DBNull.Value) outreach_Info.Ol_Attachment = Convert.ToString(dr["Ol_Attachment"]);
            if (dr["OI_Remark"] != DBNull.Value) outreach_Info.OI_Remark = Convert.ToString(dr["OI_Remark"]);
            if (dr["OI_Company"] != DBNull.Value) outreach_Info.OI_Company = Convert.ToString(dr["OI_Company"]);
            if (dr["OI_Dept"] != DBNull.Value) outreach_Info.OI_Dept = Convert.ToString(dr["OI_Dept"]);
            if (dr["Stat"] != DBNull.Value) outreach_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) outreach_Info.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) outreach_Info.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) outreach_Info.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(outreach_Info);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
