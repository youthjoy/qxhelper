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
   /// 外联协调信息
   /// </summary>
   [Serializable]
   public partial class ADOOutreach_Coordination
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加外联协调信息 Outreach_Coordination对象(即:一条记录)
      /// </summary>
      public int Add(Outreach_Coordination outreach_Coordination)
      {
         string sql = "INSERT INTO Outreach_Coordination (OC_Code,OC_OutretachCode,OC_OutreachName,OC_CoordinationType,OC_MainContactor,OC_Telephone,OC_Content,OC_Result,OC_ResultType,OC_Cost,OC_Remark,OC_Attachment,OC_Company,OC_Dept,OC_iType,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@OC_Code,@OC_OutretachCode,@OC_OutreachName,@OC_CoordinationType,@OC_MainContactor,@OC_Telephone,@OC_Content,@OC_Result,@OC_ResultType,@OC_Cost,@OC_Remark,@OC_Attachment,@OC_Company,@OC_Dept,@OC_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Code))
         {
            idb.AddParameter("@OC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Code", outreach_Coordination.OC_Code);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_OutretachCode))
         {
            idb.AddParameter("@OC_OutretachCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_OutretachCode", outreach_Coordination.OC_OutretachCode);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_OutreachName))
         {
            idb.AddParameter("@OC_OutreachName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_OutreachName", outreach_Coordination.OC_OutreachName);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_CoordinationType))
         {
            idb.AddParameter("@OC_CoordinationType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_CoordinationType", outreach_Coordination.OC_CoordinationType);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_MainContactor))
         {
            idb.AddParameter("@OC_MainContactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_MainContactor", outreach_Coordination.OC_MainContactor);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Telephone))
         {
            idb.AddParameter("@OC_Telephone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Telephone", outreach_Coordination.OC_Telephone);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Content))
         {
            idb.AddParameter("@OC_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Content", outreach_Coordination.OC_Content);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Result))
         {
            idb.AddParameter("@OC_Result", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Result", outreach_Coordination.OC_Result);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_ResultType))
         {
            idb.AddParameter("@OC_ResultType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_ResultType", outreach_Coordination.OC_ResultType);
         }
         if (outreach_Coordination.OC_Cost == 0)
         {
            idb.AddParameter("@OC_Cost", 0);
         }
         else
         {
            idb.AddParameter("@OC_Cost", outreach_Coordination.OC_Cost);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Remark))
         {
            idb.AddParameter("@OC_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Remark", outreach_Coordination.OC_Remark);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Attachment))
         {
            idb.AddParameter("@OC_Attachment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Attachment", outreach_Coordination.OC_Attachment);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Company))
         {
            idb.AddParameter("@OC_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Company", outreach_Coordination.OC_Company);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Dept))
         {
            idb.AddParameter("@OC_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Dept", outreach_Coordination.OC_Dept);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_iType))
         {
            idb.AddParameter("@OC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_iType", outreach_Coordination.OC_iType);
         }
         if (outreach_Coordination.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", outreach_Coordination.Stat);
         }
         if (outreach_Coordination.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", outreach_Coordination.CreateDate);
         }
         if (outreach_Coordination.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", outreach_Coordination.UpdateDate);
         }
         if (outreach_Coordination.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", outreach_Coordination.DeleteDate);
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
      /// 添加外联协调信息 Outreach_Coordination对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(Outreach_Coordination outreach_Coordination)
      {
         string sql = "INSERT INTO Outreach_Coordination (OC_Code,OC_OutretachCode,OC_OutreachName,OC_CoordinationType,OC_MainContactor,OC_Telephone,OC_Content,OC_Result,OC_ResultType,OC_Cost,OC_Remark,OC_Attachment,OC_Company,OC_Dept,OC_iType,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@OC_Code,@OC_OutretachCode,@OC_OutreachName,@OC_CoordinationType,@OC_MainContactor,@OC_Telephone,@OC_Content,@OC_Result,@OC_ResultType,@OC_Cost,@OC_Remark,@OC_Attachment,@OC_Company,@OC_Dept,@OC_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Code))
         {
            idb.AddParameter("@OC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Code", outreach_Coordination.OC_Code);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_OutretachCode))
         {
            idb.AddParameter("@OC_OutretachCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_OutretachCode", outreach_Coordination.OC_OutretachCode);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_OutreachName))
         {
            idb.AddParameter("@OC_OutreachName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_OutreachName", outreach_Coordination.OC_OutreachName);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_CoordinationType))
         {
            idb.AddParameter("@OC_CoordinationType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_CoordinationType", outreach_Coordination.OC_CoordinationType);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_MainContactor))
         {
            idb.AddParameter("@OC_MainContactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_MainContactor", outreach_Coordination.OC_MainContactor);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Telephone))
         {
            idb.AddParameter("@OC_Telephone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Telephone", outreach_Coordination.OC_Telephone);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Content))
         {
            idb.AddParameter("@OC_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Content", outreach_Coordination.OC_Content);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Result))
         {
            idb.AddParameter("@OC_Result", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Result", outreach_Coordination.OC_Result);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_ResultType))
         {
            idb.AddParameter("@OC_ResultType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_ResultType", outreach_Coordination.OC_ResultType);
         }
         if (outreach_Coordination.OC_Cost == 0)
         {
            idb.AddParameter("@OC_Cost", 0);
         }
         else
         {
            idb.AddParameter("@OC_Cost", outreach_Coordination.OC_Cost);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Remark))
         {
            idb.AddParameter("@OC_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Remark", outreach_Coordination.OC_Remark);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Attachment))
         {
            idb.AddParameter("@OC_Attachment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Attachment", outreach_Coordination.OC_Attachment);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Company))
         {
            idb.AddParameter("@OC_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Company", outreach_Coordination.OC_Company);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Dept))
         {
            idb.AddParameter("@OC_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Dept", outreach_Coordination.OC_Dept);
         }
         if (string.IsNullOrEmpty(outreach_Coordination.OC_iType))
         {
            idb.AddParameter("@OC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_iType", outreach_Coordination.OC_iType);
         }
         if (outreach_Coordination.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", outreach_Coordination.Stat);
         }
         if (outreach_Coordination.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", outreach_Coordination.CreateDate);
         }
         if (outreach_Coordination.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", outreach_Coordination.UpdateDate);
         }
         if (outreach_Coordination.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", outreach_Coordination.DeleteDate);
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
      /// 更新外联协调信息 Outreach_Coordination对象(即:一条记录
      /// </summary>
      public int Update(Outreach_Coordination outreach_Coordination)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       Outreach_Coordination       SET ");
            if(outreach_Coordination.OC_Code_IsChanged){sbParameter.Append("OC_Code=@OC_Code, ");}
      if(outreach_Coordination.OC_OutretachCode_IsChanged){sbParameter.Append("OC_OutretachCode=@OC_OutretachCode, ");}
      if(outreach_Coordination.OC_OutreachName_IsChanged){sbParameter.Append("OC_OutreachName=@OC_OutreachName, ");}
      if(outreach_Coordination.OC_CoordinationType_IsChanged){sbParameter.Append("OC_CoordinationType=@OC_CoordinationType, ");}
      if(outreach_Coordination.OC_MainContactor_IsChanged){sbParameter.Append("OC_MainContactor=@OC_MainContactor, ");}
      if(outreach_Coordination.OC_Telephone_IsChanged){sbParameter.Append("OC_Telephone=@OC_Telephone, ");}
      if(outreach_Coordination.OC_Content_IsChanged){sbParameter.Append("OC_Content=@OC_Content, ");}
      if(outreach_Coordination.OC_Result_IsChanged){sbParameter.Append("OC_Result=@OC_Result, ");}
      if(outreach_Coordination.OC_ResultType_IsChanged){sbParameter.Append("OC_ResultType=@OC_ResultType, ");}
      if(outreach_Coordination.OC_Cost_IsChanged){sbParameter.Append("OC_Cost=@OC_Cost, ");}
      if(outreach_Coordination.OC_Remark_IsChanged){sbParameter.Append("OC_Remark=@OC_Remark, ");}
      if(outreach_Coordination.OC_Attachment_IsChanged){sbParameter.Append("OC_Attachment=@OC_Attachment, ");}
      if(outreach_Coordination.OC_Company_IsChanged){sbParameter.Append("OC_Company=@OC_Company, ");}
      if(outreach_Coordination.OC_Dept_IsChanged){sbParameter.Append("OC_Dept=@OC_Dept, ");}
      if(outreach_Coordination.OC_iType_IsChanged){sbParameter.Append("OC_iType=@OC_iType, ");}
      if(outreach_Coordination.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(outreach_Coordination.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(outreach_Coordination.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(outreach_Coordination.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and OC_ID=@OC_ID; " );
      string sql=sb.ToString();
         if(outreach_Coordination.OC_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Code))
         {
            idb.AddParameter("@OC_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Code", outreach_Coordination.OC_Code);
         }
          }
         if(outreach_Coordination.OC_OutretachCode_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_OutretachCode))
         {
            idb.AddParameter("@OC_OutretachCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_OutretachCode", outreach_Coordination.OC_OutretachCode);
         }
          }
         if(outreach_Coordination.OC_OutreachName_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_OutreachName))
         {
            idb.AddParameter("@OC_OutreachName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_OutreachName", outreach_Coordination.OC_OutreachName);
         }
          }
         if(outreach_Coordination.OC_CoordinationType_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_CoordinationType))
         {
            idb.AddParameter("@OC_CoordinationType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_CoordinationType", outreach_Coordination.OC_CoordinationType);
         }
          }
         if(outreach_Coordination.OC_MainContactor_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_MainContactor))
         {
            idb.AddParameter("@OC_MainContactor", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_MainContactor", outreach_Coordination.OC_MainContactor);
         }
          }
         if(outreach_Coordination.OC_Telephone_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Telephone))
         {
            idb.AddParameter("@OC_Telephone", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Telephone", outreach_Coordination.OC_Telephone);
         }
          }
         if(outreach_Coordination.OC_Content_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Content))
         {
            idb.AddParameter("@OC_Content", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Content", outreach_Coordination.OC_Content);
         }
          }
         if(outreach_Coordination.OC_Result_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Result))
         {
            idb.AddParameter("@OC_Result", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Result", outreach_Coordination.OC_Result);
         }
          }
         if(outreach_Coordination.OC_ResultType_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_ResultType))
         {
            idb.AddParameter("@OC_ResultType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_ResultType", outreach_Coordination.OC_ResultType);
         }
          }
         if(outreach_Coordination.OC_Cost_IsChanged)
         {
         if (outreach_Coordination.OC_Cost == 0)
         {
            idb.AddParameter("@OC_Cost", 0);
         }
         else
         {
            idb.AddParameter("@OC_Cost", outreach_Coordination.OC_Cost);
         }
          }
         if(outreach_Coordination.OC_Remark_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Remark))
         {
            idb.AddParameter("@OC_Remark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Remark", outreach_Coordination.OC_Remark);
         }
          }
         if(outreach_Coordination.OC_Attachment_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Attachment))
         {
            idb.AddParameter("@OC_Attachment", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Attachment", outreach_Coordination.OC_Attachment);
         }
          }
         if(outreach_Coordination.OC_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Company))
         {
            idb.AddParameter("@OC_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Company", outreach_Coordination.OC_Company);
         }
          }
         if(outreach_Coordination.OC_Dept_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_Dept))
         {
            idb.AddParameter("@OC_Dept", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_Dept", outreach_Coordination.OC_Dept);
         }
          }
         if(outreach_Coordination.OC_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(outreach_Coordination.OC_iType))
         {
            idb.AddParameter("@OC_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@OC_iType", outreach_Coordination.OC_iType);
         }
          }
         if(outreach_Coordination.Stat_IsChanged)
         {
         if (outreach_Coordination.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", outreach_Coordination.Stat);
         }
          }
         if(outreach_Coordination.CreateDate_IsChanged)
         {
         if (outreach_Coordination.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", outreach_Coordination.CreateDate);
         }
          }
         if(outreach_Coordination.UpdateDate_IsChanged)
         {
         if (outreach_Coordination.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", outreach_Coordination.UpdateDate);
         }
          }
         if(outreach_Coordination.DeleteDate_IsChanged)
         {
         if (outreach_Coordination.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", outreach_Coordination.DeleteDate);
         }
          }

         idb.AddParameter("@OC_ID", outreach_Coordination.OC_ID);

           
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
      /// 删除外联协调信息 Outreach_Coordination对象(即:一条记录
      /// </summary>
      public int Delete(decimal oC_ID)
      {
         string sql = "DELETE Outreach_Coordination WHERE 1=1  AND OC_ID=@OC_ID ";
         idb.AddParameter("@OC_ID", oC_ID);

           
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
      /// 获取指定的外联协调信息 Outreach_Coordination对象(即:一条记录
      /// </summary>
      public Outreach_Coordination GetByKey(decimal oC_ID)
      {
         Outreach_Coordination outreach_Coordination = new Outreach_Coordination();
         string sql = "SELECT  OC_ID,OC_Code,OC_OutretachCode,OC_OutreachName,OC_CoordinationType,OC_MainContactor,OC_Telephone,OC_Content,OC_Result,OC_ResultType,OC_Cost,OC_Remark,OC_Attachment,OC_Company,OC_Dept,OC_iType,Stat,CreateDate,UpdateDate,DeleteDate FROM Outreach_Coordination WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND OC_ID=@OC_ID ";
         idb.AddParameter("@OC_ID", oC_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["OC_ID"] != DBNull.Value) outreach_Coordination.OC_ID = Convert.ToDecimal(dr["OC_ID"]);
            if (dr["OC_Code"] != DBNull.Value) outreach_Coordination.OC_Code = Convert.ToString(dr["OC_Code"]);
            if (dr["OC_OutretachCode"] != DBNull.Value) outreach_Coordination.OC_OutretachCode = Convert.ToString(dr["OC_OutretachCode"]);
            if (dr["OC_OutreachName"] != DBNull.Value) outreach_Coordination.OC_OutreachName = Convert.ToString(dr["OC_OutreachName"]);
            if (dr["OC_CoordinationType"] != DBNull.Value) outreach_Coordination.OC_CoordinationType = Convert.ToString(dr["OC_CoordinationType"]);
            if (dr["OC_MainContactor"] != DBNull.Value) outreach_Coordination.OC_MainContactor = Convert.ToString(dr["OC_MainContactor"]);
            if (dr["OC_Telephone"] != DBNull.Value) outreach_Coordination.OC_Telephone = Convert.ToString(dr["OC_Telephone"]);
            if (dr["OC_Content"] != DBNull.Value) outreach_Coordination.OC_Content = Convert.ToString(dr["OC_Content"]);
            if (dr["OC_Result"] != DBNull.Value) outreach_Coordination.OC_Result = Convert.ToString(dr["OC_Result"]);
            if (dr["OC_ResultType"] != DBNull.Value) outreach_Coordination.OC_ResultType = Convert.ToString(dr["OC_ResultType"]);
            if (dr["OC_Cost"] != DBNull.Value) outreach_Coordination.OC_Cost = Convert.ToDecimal(dr["OC_Cost"]);
            if (dr["OC_Remark"] != DBNull.Value) outreach_Coordination.OC_Remark = Convert.ToString(dr["OC_Remark"]);
            if (dr["OC_Attachment"] != DBNull.Value) outreach_Coordination.OC_Attachment = Convert.ToString(dr["OC_Attachment"]);
            if (dr["OC_Company"] != DBNull.Value) outreach_Coordination.OC_Company = Convert.ToString(dr["OC_Company"]);
            if (dr["OC_Dept"] != DBNull.Value) outreach_Coordination.OC_Dept = Convert.ToString(dr["OC_Dept"]);
            if (dr["OC_iType"] != DBNull.Value) outreach_Coordination.OC_iType = Convert.ToString(dr["OC_iType"]);
            if (dr["Stat"] != DBNull.Value) outreach_Coordination.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) outreach_Coordination.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) outreach_Coordination.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) outreach_Coordination.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return outreach_Coordination;
      }
      /// <summary>
      /// 获取指定的外联协调信息 Outreach_Coordination对象集合
      /// </summary>
      public List<Outreach_Coordination> GetListByWhere(string strCondition)
      {
         List<Outreach_Coordination> ret = new List<Outreach_Coordination>();
         string sql = "SELECT  OC_ID,OC_Code,OC_OutretachCode,OC_OutreachName,OC_CoordinationType,OC_MainContactor,OC_Telephone,OC_Content,OC_Result,OC_ResultType,OC_Cost,OC_Remark,OC_Attachment,OC_Company,OC_Dept,OC_iType,Stat,CreateDate,UpdateDate,DeleteDate FROM Outreach_Coordination WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            Outreach_Coordination outreach_Coordination = new Outreach_Coordination();
            if (dr["OC_ID"] != DBNull.Value) outreach_Coordination.OC_ID = Convert.ToDecimal(dr["OC_ID"]);
            if (dr["OC_Code"] != DBNull.Value) outreach_Coordination.OC_Code = Convert.ToString(dr["OC_Code"]);
            if (dr["OC_OutretachCode"] != DBNull.Value) outreach_Coordination.OC_OutretachCode = Convert.ToString(dr["OC_OutretachCode"]);
            if (dr["OC_OutreachName"] != DBNull.Value) outreach_Coordination.OC_OutreachName = Convert.ToString(dr["OC_OutreachName"]);
            if (dr["OC_CoordinationType"] != DBNull.Value) outreach_Coordination.OC_CoordinationType = Convert.ToString(dr["OC_CoordinationType"]);
            if (dr["OC_MainContactor"] != DBNull.Value) outreach_Coordination.OC_MainContactor = Convert.ToString(dr["OC_MainContactor"]);
            if (dr["OC_Telephone"] != DBNull.Value) outreach_Coordination.OC_Telephone = Convert.ToString(dr["OC_Telephone"]);
            if (dr["OC_Content"] != DBNull.Value) outreach_Coordination.OC_Content = Convert.ToString(dr["OC_Content"]);
            if (dr["OC_Result"] != DBNull.Value) outreach_Coordination.OC_Result = Convert.ToString(dr["OC_Result"]);
            if (dr["OC_ResultType"] != DBNull.Value) outreach_Coordination.OC_ResultType = Convert.ToString(dr["OC_ResultType"]);
            if (dr["OC_Cost"] != DBNull.Value) outreach_Coordination.OC_Cost = Convert.ToDecimal(dr["OC_Cost"]);
            if (dr["OC_Remark"] != DBNull.Value) outreach_Coordination.OC_Remark = Convert.ToString(dr["OC_Remark"]);
            if (dr["OC_Attachment"] != DBNull.Value) outreach_Coordination.OC_Attachment = Convert.ToString(dr["OC_Attachment"]);
            if (dr["OC_Company"] != DBNull.Value) outreach_Coordination.OC_Company = Convert.ToString(dr["OC_Company"]);
            if (dr["OC_Dept"] != DBNull.Value) outreach_Coordination.OC_Dept = Convert.ToString(dr["OC_Dept"]);
            if (dr["OC_iType"] != DBNull.Value) outreach_Coordination.OC_iType = Convert.ToString(dr["OC_iType"]);
            if (dr["Stat"] != DBNull.Value) outreach_Coordination.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) outreach_Coordination.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) outreach_Coordination.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) outreach_Coordination.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(outreach_Coordination);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的外联协调信息 Outreach_Coordination对象(即:一条记录
      /// </summary>
      public List<Outreach_Coordination> GetAll()
      {
         List<Outreach_Coordination> ret = new List<Outreach_Coordination>();
         string sql = "SELECT  OC_ID,OC_Code,OC_OutretachCode,OC_OutreachName,OC_CoordinationType,OC_MainContactor,OC_Telephone,OC_Content,OC_Result,OC_ResultType,OC_Cost,OC_Remark,OC_Attachment,OC_Company,OC_Dept,OC_iType,Stat,CreateDate,UpdateDate,DeleteDate FROM Outreach_Coordination where 1=1 AND ((Stat is null) or (Stat=0) ) order by OC_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            Outreach_Coordination outreach_Coordination = new Outreach_Coordination();
            if (dr["OC_ID"] != DBNull.Value) outreach_Coordination.OC_ID = Convert.ToDecimal(dr["OC_ID"]);
            if (dr["OC_Code"] != DBNull.Value) outreach_Coordination.OC_Code = Convert.ToString(dr["OC_Code"]);
            if (dr["OC_OutretachCode"] != DBNull.Value) outreach_Coordination.OC_OutretachCode = Convert.ToString(dr["OC_OutretachCode"]);
            if (dr["OC_OutreachName"] != DBNull.Value) outreach_Coordination.OC_OutreachName = Convert.ToString(dr["OC_OutreachName"]);
            if (dr["OC_CoordinationType"] != DBNull.Value) outreach_Coordination.OC_CoordinationType = Convert.ToString(dr["OC_CoordinationType"]);
            if (dr["OC_MainContactor"] != DBNull.Value) outreach_Coordination.OC_MainContactor = Convert.ToString(dr["OC_MainContactor"]);
            if (dr["OC_Telephone"] != DBNull.Value) outreach_Coordination.OC_Telephone = Convert.ToString(dr["OC_Telephone"]);
            if (dr["OC_Content"] != DBNull.Value) outreach_Coordination.OC_Content = Convert.ToString(dr["OC_Content"]);
            if (dr["OC_Result"] != DBNull.Value) outreach_Coordination.OC_Result = Convert.ToString(dr["OC_Result"]);
            if (dr["OC_ResultType"] != DBNull.Value) outreach_Coordination.OC_ResultType = Convert.ToString(dr["OC_ResultType"]);
            if (dr["OC_Cost"] != DBNull.Value) outreach_Coordination.OC_Cost = Convert.ToDecimal(dr["OC_Cost"]);
            if (dr["OC_Remark"] != DBNull.Value) outreach_Coordination.OC_Remark = Convert.ToString(dr["OC_Remark"]);
            if (dr["OC_Attachment"] != DBNull.Value) outreach_Coordination.OC_Attachment = Convert.ToString(dr["OC_Attachment"]);
            if (dr["OC_Company"] != DBNull.Value) outreach_Coordination.OC_Company = Convert.ToString(dr["OC_Company"]);
            if (dr["OC_Dept"] != DBNull.Value) outreach_Coordination.OC_Dept = Convert.ToString(dr["OC_Dept"]);
            if (dr["OC_iType"] != DBNull.Value) outreach_Coordination.OC_iType = Convert.ToString(dr["OC_iType"]);
            if (dr["Stat"] != DBNull.Value) outreach_Coordination.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) outreach_Coordination.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) outreach_Coordination.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) outreach_Coordination.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(outreach_Coordination);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
