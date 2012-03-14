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
   /// 异常记录
   /// </summary>
   [Serializable]
   public partial class ADOPCD_DRecord
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加异常记录 PCD_DRecord对象(即:一条记录)
      /// </summary>
      public int Add(PCD_DRecord pCD_DRecord)
      {
         string sql = "INSERT INTO PCD_DRecord (PCCD_Code,PCCD_Type,PCCD_RCode,PCCD_PRCode,PCCD_PPCode,PCCD_PTCode,PCCD_PTNum,PCCD_PNTCode,PCCD_NCode,PCCD_NTCode,PCCD_NTNum,PCCD_NPCode,PCCD_NRCode,PCCD_IsHandle,PCCD_IsOut,PCCD_Tester,PCCD_TestDate,PCCD_TestAdvice,PCCD_HType,PCCD_ERemark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCCD_Code,@PCCD_Type,@PCCD_RCode,@PCCD_PRCode,@PCCD_PPCode,@PCCD_PTCode,@PCCD_PTNum,@PCCD_PNTCode,@PCCD_NCode,@PCCD_NTCode,@PCCD_NTNum,@PCCD_NPCode,@PCCD_NRCode,@PCCD_IsHandle,@PCCD_IsOut,@PCCD_Tester,@PCCD_TestDate,@PCCD_TestAdvice,@PCCD_HType,@PCCD_ERemark,@Stat,@CreateDate,@UpdateDate,@DeleteDate)";
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_Code))
         {
            idb.AddParameter("@PCCD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_Code", pCD_DRecord.PCCD_Code);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_Type))
         {
            idb.AddParameter("@PCCD_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_Type", pCD_DRecord.PCCD_Type);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_RCode))
         {
            idb.AddParameter("@PCCD_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_RCode", pCD_DRecord.PCCD_RCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PRCode))
         {
            idb.AddParameter("@PCCD_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PRCode", pCD_DRecord.PCCD_PRCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PPCode))
         {
            idb.AddParameter("@PCCD_PPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PPCode", pCD_DRecord.PCCD_PPCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PTCode))
         {
            idb.AddParameter("@PCCD_PTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PTCode", pCD_DRecord.PCCD_PTCode);
         }
         if (pCD_DRecord.PCCD_PTNum == 0)
         {
            idb.AddParameter("@PCCD_PTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCCD_PTNum", pCD_DRecord.PCCD_PTNum);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PNTCode))
         {
            idb.AddParameter("@PCCD_PNTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PNTCode", pCD_DRecord.PCCD_PNTCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NCode))
         {
            idb.AddParameter("@PCCD_NCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NCode", pCD_DRecord.PCCD_NCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NTCode))
         {
            idb.AddParameter("@PCCD_NTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NTCode", pCD_DRecord.PCCD_NTCode);
         }
         if (pCD_DRecord.PCCD_NTNum == 0)
         {
            idb.AddParameter("@PCCD_NTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCCD_NTNum", pCD_DRecord.PCCD_NTNum);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NPCode))
         {
            idb.AddParameter("@PCCD_NPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NPCode", pCD_DRecord.PCCD_NPCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NRCode))
         {
            idb.AddParameter("@PCCD_NRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NRCode", pCD_DRecord.PCCD_NRCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_IsHandle))
         {
            idb.AddParameter("@PCCD_IsHandle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_IsHandle", pCD_DRecord.PCCD_IsHandle);
         }
         if (pCD_DRecord.PCCD_IsOut == 0)
         {
            idb.AddParameter("@PCCD_IsOut", 0);
         }
         else
         {
            idb.AddParameter("@PCCD_IsOut", pCD_DRecord.PCCD_IsOut);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_Tester))
         {
            idb.AddParameter("@PCCD_Tester", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_Tester", pCD_DRecord.PCCD_Tester);
         }
         if (pCD_DRecord.PCCD_TestDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCCD_TestDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_TestDate", pCD_DRecord.PCCD_TestDate);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_TestAdvice))
         {
            idb.AddParameter("@PCCD_TestAdvice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_TestAdvice", pCD_DRecord.PCCD_TestAdvice);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_HType))
         {
            idb.AddParameter("@PCCD_HType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_HType", pCD_DRecord.PCCD_HType);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_ERemark))
         {
            idb.AddParameter("@PCCD_ERemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_ERemark", pCD_DRecord.PCCD_ERemark);
         }
         if (pCD_DRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_DRecord.Stat);
         }
         if (pCD_DRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_DRecord.CreateDate);
         }
         if (pCD_DRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_DRecord.UpdateDate);
         }
         if (pCD_DRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_DRecord.DeleteDate);
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
      /// 添加异常记录 PCD_DRecord对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCD_DRecord pCD_DRecord)
      {
         string sql = "INSERT INTO PCD_DRecord (PCCD_Code,PCCD_Type,PCCD_RCode,PCCD_PRCode,PCCD_PPCode,PCCD_PTCode,PCCD_PTNum,PCCD_PNTCode,PCCD_NCode,PCCD_NTCode,PCCD_NTNum,PCCD_NPCode,PCCD_NRCode,PCCD_IsHandle,PCCD_IsOut,PCCD_Tester,PCCD_TestDate,PCCD_TestAdvice,PCCD_HType,PCCD_ERemark,Stat,CreateDate,UpdateDate,DeleteDate) VALUES (@PCCD_Code,@PCCD_Type,@PCCD_RCode,@PCCD_PRCode,@PCCD_PPCode,@PCCD_PTCode,@PCCD_PTNum,@PCCD_PNTCode,@PCCD_NCode,@PCCD_NTCode,@PCCD_NTNum,@PCCD_NPCode,@PCCD_NRCode,@PCCD_IsHandle,@PCCD_IsOut,@PCCD_Tester,@PCCD_TestDate,@PCCD_TestAdvice,@PCCD_HType,@PCCD_ERemark,@Stat,@CreateDate,@UpdateDate,@DeleteDate);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_Code))
         {
            idb.AddParameter("@PCCD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_Code", pCD_DRecord.PCCD_Code);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_Type))
         {
            idb.AddParameter("@PCCD_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_Type", pCD_DRecord.PCCD_Type);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_RCode))
         {
            idb.AddParameter("@PCCD_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_RCode", pCD_DRecord.PCCD_RCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PRCode))
         {
            idb.AddParameter("@PCCD_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PRCode", pCD_DRecord.PCCD_PRCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PPCode))
         {
            idb.AddParameter("@PCCD_PPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PPCode", pCD_DRecord.PCCD_PPCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PTCode))
         {
            idb.AddParameter("@PCCD_PTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PTCode", pCD_DRecord.PCCD_PTCode);
         }
         if (pCD_DRecord.PCCD_PTNum == 0)
         {
            idb.AddParameter("@PCCD_PTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCCD_PTNum", pCD_DRecord.PCCD_PTNum);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PNTCode))
         {
            idb.AddParameter("@PCCD_PNTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PNTCode", pCD_DRecord.PCCD_PNTCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NCode))
         {
            idb.AddParameter("@PCCD_NCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NCode", pCD_DRecord.PCCD_NCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NTCode))
         {
            idb.AddParameter("@PCCD_NTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NTCode", pCD_DRecord.PCCD_NTCode);
         }
         if (pCD_DRecord.PCCD_NTNum == 0)
         {
            idb.AddParameter("@PCCD_NTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCCD_NTNum", pCD_DRecord.PCCD_NTNum);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NPCode))
         {
            idb.AddParameter("@PCCD_NPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NPCode", pCD_DRecord.PCCD_NPCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NRCode))
         {
            idb.AddParameter("@PCCD_NRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NRCode", pCD_DRecord.PCCD_NRCode);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_IsHandle))
         {
            idb.AddParameter("@PCCD_IsHandle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_IsHandle", pCD_DRecord.PCCD_IsHandle);
         }
         if (pCD_DRecord.PCCD_IsOut == 0)
         {
            idb.AddParameter("@PCCD_IsOut", 0);
         }
         else
         {
            idb.AddParameter("@PCCD_IsOut", pCD_DRecord.PCCD_IsOut);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_Tester))
         {
            idb.AddParameter("@PCCD_Tester", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_Tester", pCD_DRecord.PCCD_Tester);
         }
         if (pCD_DRecord.PCCD_TestDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCCD_TestDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_TestDate", pCD_DRecord.PCCD_TestDate);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_TestAdvice))
         {
            idb.AddParameter("@PCCD_TestAdvice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_TestAdvice", pCD_DRecord.PCCD_TestAdvice);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_HType))
         {
            idb.AddParameter("@PCCD_HType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_HType", pCD_DRecord.PCCD_HType);
         }
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_ERemark))
         {
            idb.AddParameter("@PCCD_ERemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_ERemark", pCD_DRecord.PCCD_ERemark);
         }
         if (pCD_DRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_DRecord.Stat);
         }
         if (pCD_DRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_DRecord.CreateDate);
         }
         if (pCD_DRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_DRecord.UpdateDate);
         }
         if (pCD_DRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_DRecord.DeleteDate);
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
      /// 更新异常记录 PCD_DRecord对象(即:一条记录
      /// </summary>
      public int Update(PCD_DRecord pCD_DRecord)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCD_DRecord       SET ");
            if(pCD_DRecord.PCCD_Code_IsChanged){sbParameter.Append("PCCD_Code=@PCCD_Code, ");}
      if(pCD_DRecord.PCCD_Type_IsChanged){sbParameter.Append("PCCD_Type=@PCCD_Type, ");}
      if(pCD_DRecord.PCCD_RCode_IsChanged){sbParameter.Append("PCCD_RCode=@PCCD_RCode, ");}
      if(pCD_DRecord.PCCD_PRCode_IsChanged){sbParameter.Append("PCCD_PRCode=@PCCD_PRCode, ");}
      if(pCD_DRecord.PCCD_PPCode_IsChanged){sbParameter.Append("PCCD_PPCode=@PCCD_PPCode, ");}
      if(pCD_DRecord.PCCD_PTCode_IsChanged){sbParameter.Append("PCCD_PTCode=@PCCD_PTCode, ");}
      if(pCD_DRecord.PCCD_PTNum_IsChanged){sbParameter.Append("PCCD_PTNum=@PCCD_PTNum, ");}
      if(pCD_DRecord.PCCD_PNTCode_IsChanged){sbParameter.Append("PCCD_PNTCode=@PCCD_PNTCode, ");}
      if(pCD_DRecord.PCCD_NCode_IsChanged){sbParameter.Append("PCCD_NCode=@PCCD_NCode, ");}
      if(pCD_DRecord.PCCD_NTCode_IsChanged){sbParameter.Append("PCCD_NTCode=@PCCD_NTCode, ");}
      if(pCD_DRecord.PCCD_NTNum_IsChanged){sbParameter.Append("PCCD_NTNum=@PCCD_NTNum, ");}
      if(pCD_DRecord.PCCD_NPCode_IsChanged){sbParameter.Append("PCCD_NPCode=@PCCD_NPCode, ");}
      if(pCD_DRecord.PCCD_NRCode_IsChanged){sbParameter.Append("PCCD_NRCode=@PCCD_NRCode, ");}
      if(pCD_DRecord.PCCD_IsHandle_IsChanged){sbParameter.Append("PCCD_IsHandle=@PCCD_IsHandle, ");}
      if(pCD_DRecord.PCCD_IsOut_IsChanged){sbParameter.Append("PCCD_IsOut=@PCCD_IsOut, ");}
      if(pCD_DRecord.PCCD_Tester_IsChanged){sbParameter.Append("PCCD_Tester=@PCCD_Tester, ");}
      if(pCD_DRecord.PCCD_TestDate_IsChanged){sbParameter.Append("PCCD_TestDate=@PCCD_TestDate, ");}
      if(pCD_DRecord.PCCD_TestAdvice_IsChanged){sbParameter.Append("PCCD_TestAdvice=@PCCD_TestAdvice, ");}
      if(pCD_DRecord.PCCD_HType_IsChanged){sbParameter.Append("PCCD_HType=@PCCD_HType, ");}
      if(pCD_DRecord.PCCD_ERemark_IsChanged){sbParameter.Append("PCCD_ERemark=@PCCD_ERemark, ");}
      if(pCD_DRecord.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCD_DRecord.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pCD_DRecord.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pCD_DRecord.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCCD_ID=@PCCD_ID; " );
      string sql=sb.ToString();
         if(pCD_DRecord.PCCD_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_Code))
         {
            idb.AddParameter("@PCCD_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_Code", pCD_DRecord.PCCD_Code);
         }
          }
         if(pCD_DRecord.PCCD_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_Type))
         {
            idb.AddParameter("@PCCD_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_Type", pCD_DRecord.PCCD_Type);
         }
          }
         if(pCD_DRecord.PCCD_RCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_RCode))
         {
            idb.AddParameter("@PCCD_RCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_RCode", pCD_DRecord.PCCD_RCode);
         }
          }
         if(pCD_DRecord.PCCD_PRCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PRCode))
         {
            idb.AddParameter("@PCCD_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PRCode", pCD_DRecord.PCCD_PRCode);
         }
          }
         if(pCD_DRecord.PCCD_PPCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PPCode))
         {
            idb.AddParameter("@PCCD_PPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PPCode", pCD_DRecord.PCCD_PPCode);
         }
          }
         if(pCD_DRecord.PCCD_PTCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PTCode))
         {
            idb.AddParameter("@PCCD_PTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PTCode", pCD_DRecord.PCCD_PTCode);
         }
          }
         if(pCD_DRecord.PCCD_PTNum_IsChanged)
         {
         if (pCD_DRecord.PCCD_PTNum == 0)
         {
            idb.AddParameter("@PCCD_PTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCCD_PTNum", pCD_DRecord.PCCD_PTNum);
         }
          }
         if(pCD_DRecord.PCCD_PNTCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_PNTCode))
         {
            idb.AddParameter("@PCCD_PNTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_PNTCode", pCD_DRecord.PCCD_PNTCode);
         }
          }
         if(pCD_DRecord.PCCD_NCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NCode))
         {
            idb.AddParameter("@PCCD_NCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NCode", pCD_DRecord.PCCD_NCode);
         }
          }
         if(pCD_DRecord.PCCD_NTCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NTCode))
         {
            idb.AddParameter("@PCCD_NTCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NTCode", pCD_DRecord.PCCD_NTCode);
         }
          }
         if(pCD_DRecord.PCCD_NTNum_IsChanged)
         {
         if (pCD_DRecord.PCCD_NTNum == 0)
         {
            idb.AddParameter("@PCCD_NTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCCD_NTNum", pCD_DRecord.PCCD_NTNum);
         }
          }
         if(pCD_DRecord.PCCD_NPCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NPCode))
         {
            idb.AddParameter("@PCCD_NPCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NPCode", pCD_DRecord.PCCD_NPCode);
         }
          }
         if(pCD_DRecord.PCCD_NRCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_NRCode))
         {
            idb.AddParameter("@PCCD_NRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_NRCode", pCD_DRecord.PCCD_NRCode);
         }
          }
         if(pCD_DRecord.PCCD_IsHandle_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_IsHandle))
         {
            idb.AddParameter("@PCCD_IsHandle", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_IsHandle", pCD_DRecord.PCCD_IsHandle);
         }
          }
         if(pCD_DRecord.PCCD_IsOut_IsChanged)
         {
         if (pCD_DRecord.PCCD_IsOut == 0)
         {
            idb.AddParameter("@PCCD_IsOut", 0);
         }
         else
         {
            idb.AddParameter("@PCCD_IsOut", pCD_DRecord.PCCD_IsOut);
         }
          }
         if(pCD_DRecord.PCCD_Tester_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_Tester))
         {
            idb.AddParameter("@PCCD_Tester", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_Tester", pCD_DRecord.PCCD_Tester);
         }
          }
         if(pCD_DRecord.PCCD_TestDate_IsChanged)
         {
         if (pCD_DRecord.PCCD_TestDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCCD_TestDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_TestDate", pCD_DRecord.PCCD_TestDate);
         }
          }
         if(pCD_DRecord.PCCD_TestAdvice_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_TestAdvice))
         {
            idb.AddParameter("@PCCD_TestAdvice", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_TestAdvice", pCD_DRecord.PCCD_TestAdvice);
         }
          }
         if(pCD_DRecord.PCCD_HType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_HType))
         {
            idb.AddParameter("@PCCD_HType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_HType", pCD_DRecord.PCCD_HType);
         }
          }
         if(pCD_DRecord.PCCD_ERemark_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_DRecord.PCCD_ERemark))
         {
            idb.AddParameter("@PCCD_ERemark", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCCD_ERemark", pCD_DRecord.PCCD_ERemark);
         }
          }
         if(pCD_DRecord.Stat_IsChanged)
         {
         if (pCD_DRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_DRecord.Stat);
         }
          }
         if(pCD_DRecord.CreateDate_IsChanged)
         {
         if (pCD_DRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_DRecord.CreateDate);
         }
          }
         if(pCD_DRecord.UpdateDate_IsChanged)
         {
         if (pCD_DRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_DRecord.UpdateDate);
         }
          }
         if(pCD_DRecord.DeleteDate_IsChanged)
         {
         if (pCD_DRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_DRecord.DeleteDate);
         }
          }

         idb.AddParameter("@PCCD_ID", pCD_DRecord.PCCD_ID);

           
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
      /// 删除异常记录 PCD_DRecord对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCCD_ID)
      {
         string sql = "DELETE PCD_DRecord WHERE 1=1  AND PCCD_ID=@PCCD_ID ";
         idb.AddParameter("@PCCD_ID", pCCD_ID);

           
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
      /// 获取指定的异常记录 PCD_DRecord对象(即:一条记录
      /// </summary>
      public PCD_DRecord GetByKey(decimal pCCD_ID)
      {
         PCD_DRecord pCD_DRecord = new PCD_DRecord();
         string sql = "SELECT  PCCD_ID,PCCD_Code,PCCD_Type,PCCD_RCode,PCCD_PRCode,PCCD_PPCode,PCCD_PTCode,PCCD_PTNum,PCCD_PNTCode,PCCD_NCode,PCCD_NTCode,PCCD_NTNum,PCCD_NPCode,PCCD_NRCode,PCCD_IsHandle,PCCD_IsOut,PCCD_Tester,PCCD_TestDate,PCCD_TestAdvice,PCCD_HType,PCCD_ERemark,Stat,CreateDate,UpdateDate,DeleteDate FROM PCD_DRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCCD_ID=@PCCD_ID ";
         idb.AddParameter("@PCCD_ID", pCCD_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCCD_ID"] != DBNull.Value) pCD_DRecord.PCCD_ID = Convert.ToDecimal(dr["PCCD_ID"]);
            if (dr["PCCD_Code"] != DBNull.Value) pCD_DRecord.PCCD_Code = Convert.ToString(dr["PCCD_Code"]);
            if (dr["PCCD_Type"] != DBNull.Value) pCD_DRecord.PCCD_Type = Convert.ToString(dr["PCCD_Type"]);
            if (dr["PCCD_RCode"] != DBNull.Value) pCD_DRecord.PCCD_RCode = Convert.ToString(dr["PCCD_RCode"]);
            if (dr["PCCD_PRCode"] != DBNull.Value) pCD_DRecord.PCCD_PRCode = Convert.ToString(dr["PCCD_PRCode"]);
            if (dr["PCCD_PPCode"] != DBNull.Value) pCD_DRecord.PCCD_PPCode = Convert.ToString(dr["PCCD_PPCode"]);
            if (dr["PCCD_PTCode"] != DBNull.Value) pCD_DRecord.PCCD_PTCode = Convert.ToString(dr["PCCD_PTCode"]);
            if (dr["PCCD_PTNum"] != DBNull.Value) pCD_DRecord.PCCD_PTNum = Convert.ToDecimal(dr["PCCD_PTNum"]);
            if (dr["PCCD_PNTCode"] != DBNull.Value) pCD_DRecord.PCCD_PNTCode = Convert.ToString(dr["PCCD_PNTCode"]);
            if (dr["PCCD_NCode"] != DBNull.Value) pCD_DRecord.PCCD_NCode = Convert.ToString(dr["PCCD_NCode"]);
            if (dr["PCCD_NTCode"] != DBNull.Value) pCD_DRecord.PCCD_NTCode = Convert.ToString(dr["PCCD_NTCode"]);
            if (dr["PCCD_NTNum"] != DBNull.Value) pCD_DRecord.PCCD_NTNum = Convert.ToDecimal(dr["PCCD_NTNum"]);
            if (dr["PCCD_NPCode"] != DBNull.Value) pCD_DRecord.PCCD_NPCode = Convert.ToString(dr["PCCD_NPCode"]);
            if (dr["PCCD_NRCode"] != DBNull.Value) pCD_DRecord.PCCD_NRCode = Convert.ToString(dr["PCCD_NRCode"]);
            if (dr["PCCD_IsHandle"] != DBNull.Value) pCD_DRecord.PCCD_IsHandle = Convert.ToString(dr["PCCD_IsHandle"]);
            if (dr["PCCD_IsOut"] != DBNull.Value) pCD_DRecord.PCCD_IsOut = Convert.ToInt32(dr["PCCD_IsOut"]);
            if (dr["PCCD_Tester"] != DBNull.Value) pCD_DRecord.PCCD_Tester = Convert.ToString(dr["PCCD_Tester"]);
            if (dr["PCCD_TestDate"] != DBNull.Value) pCD_DRecord.PCCD_TestDate = Convert.ToDateTime(dr["PCCD_TestDate"]);
            if (dr["PCCD_TestAdvice"] != DBNull.Value) pCD_DRecord.PCCD_TestAdvice = Convert.ToString(dr["PCCD_TestAdvice"]);
            if (dr["PCCD_HType"] != DBNull.Value) pCD_DRecord.PCCD_HType = Convert.ToString(dr["PCCD_HType"]);
            if (dr["PCCD_ERemark"] != DBNull.Value) pCD_DRecord.PCCD_ERemark = Convert.ToString(dr["PCCD_ERemark"]);
            if (dr["Stat"] != DBNull.Value) pCD_DRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_DRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_DRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_DRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCD_DRecord;
      }
      /// <summary>
      /// 获取指定的异常记录 PCD_DRecord对象集合
      /// </summary>
      public List<PCD_DRecord> GetListByWhere(string strCondition)
      {
         List<PCD_DRecord> ret = new List<PCD_DRecord>();
         string sql = "SELECT  PCCD_ID,PCCD_Code,PCCD_Type,PCCD_RCode,PCCD_PRCode,PCCD_PPCode,PCCD_PTCode,PCCD_PTNum,PCCD_PNTCode,PCCD_NCode,PCCD_NTCode,PCCD_NTNum,PCCD_NPCode,PCCD_NRCode,PCCD_IsHandle,PCCD_IsOut,PCCD_Tester,PCCD_TestDate,PCCD_TestAdvice,PCCD_HType,PCCD_ERemark,Stat,CreateDate,UpdateDate,DeleteDate FROM PCD_DRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCD_DRecord pCD_DRecord = new PCD_DRecord();
            if (dr["PCCD_ID"] != DBNull.Value) pCD_DRecord.PCCD_ID = Convert.ToDecimal(dr["PCCD_ID"]);
            if (dr["PCCD_Code"] != DBNull.Value) pCD_DRecord.PCCD_Code = Convert.ToString(dr["PCCD_Code"]);
            if (dr["PCCD_Type"] != DBNull.Value) pCD_DRecord.PCCD_Type = Convert.ToString(dr["PCCD_Type"]);
            if (dr["PCCD_RCode"] != DBNull.Value) pCD_DRecord.PCCD_RCode = Convert.ToString(dr["PCCD_RCode"]);
            if (dr["PCCD_PRCode"] != DBNull.Value) pCD_DRecord.PCCD_PRCode = Convert.ToString(dr["PCCD_PRCode"]);
            if (dr["PCCD_PPCode"] != DBNull.Value) pCD_DRecord.PCCD_PPCode = Convert.ToString(dr["PCCD_PPCode"]);
            if (dr["PCCD_PTCode"] != DBNull.Value) pCD_DRecord.PCCD_PTCode = Convert.ToString(dr["PCCD_PTCode"]);
            if (dr["PCCD_PTNum"] != DBNull.Value) pCD_DRecord.PCCD_PTNum = Convert.ToDecimal(dr["PCCD_PTNum"]);
            if (dr["PCCD_PNTCode"] != DBNull.Value) pCD_DRecord.PCCD_PNTCode = Convert.ToString(dr["PCCD_PNTCode"]);
            if (dr["PCCD_NCode"] != DBNull.Value) pCD_DRecord.PCCD_NCode = Convert.ToString(dr["PCCD_NCode"]);
            if (dr["PCCD_NTCode"] != DBNull.Value) pCD_DRecord.PCCD_NTCode = Convert.ToString(dr["PCCD_NTCode"]);
            if (dr["PCCD_NTNum"] != DBNull.Value) pCD_DRecord.PCCD_NTNum = Convert.ToDecimal(dr["PCCD_NTNum"]);
            if (dr["PCCD_NPCode"] != DBNull.Value) pCD_DRecord.PCCD_NPCode = Convert.ToString(dr["PCCD_NPCode"]);
            if (dr["PCCD_NRCode"] != DBNull.Value) pCD_DRecord.PCCD_NRCode = Convert.ToString(dr["PCCD_NRCode"]);
            if (dr["PCCD_IsHandle"] != DBNull.Value) pCD_DRecord.PCCD_IsHandle = Convert.ToString(dr["PCCD_IsHandle"]);
            if (dr["PCCD_IsOut"] != DBNull.Value) pCD_DRecord.PCCD_IsOut = Convert.ToInt32(dr["PCCD_IsOut"]);
            if (dr["PCCD_Tester"] != DBNull.Value) pCD_DRecord.PCCD_Tester = Convert.ToString(dr["PCCD_Tester"]);
            if (dr["PCCD_TestDate"] != DBNull.Value) pCD_DRecord.PCCD_TestDate = Convert.ToDateTime(dr["PCCD_TestDate"]);
            if (dr["PCCD_TestAdvice"] != DBNull.Value) pCD_DRecord.PCCD_TestAdvice = Convert.ToString(dr["PCCD_TestAdvice"]);
            if (dr["PCCD_HType"] != DBNull.Value) pCD_DRecord.PCCD_HType = Convert.ToString(dr["PCCD_HType"]);
            if (dr["PCCD_ERemark"] != DBNull.Value) pCD_DRecord.PCCD_ERemark = Convert.ToString(dr["PCCD_ERemark"]);
            if (dr["Stat"] != DBNull.Value) pCD_DRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_DRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_DRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_DRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pCD_DRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的异常记录 PCD_DRecord对象(即:一条记录
      /// </summary>
      public List<PCD_DRecord> GetAll()
      {
         List<PCD_DRecord> ret = new List<PCD_DRecord>();
         string sql = "SELECT  PCCD_ID,PCCD_Code,PCCD_Type,PCCD_RCode,PCCD_PRCode,PCCD_PPCode,PCCD_PTCode,PCCD_PTNum,PCCD_PNTCode,PCCD_NCode,PCCD_NTCode,PCCD_NTNum,PCCD_NPCode,PCCD_NRCode,PCCD_IsHandle,PCCD_IsOut,PCCD_Tester,PCCD_TestDate,PCCD_TestAdvice,PCCD_HType,PCCD_ERemark,Stat,CreateDate,UpdateDate,DeleteDate FROM PCD_DRecord where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCCD_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCD_DRecord pCD_DRecord = new PCD_DRecord();
            if (dr["PCCD_ID"] != DBNull.Value) pCD_DRecord.PCCD_ID = Convert.ToDecimal(dr["PCCD_ID"]);
            if (dr["PCCD_Code"] != DBNull.Value) pCD_DRecord.PCCD_Code = Convert.ToString(dr["PCCD_Code"]);
            if (dr["PCCD_Type"] != DBNull.Value) pCD_DRecord.PCCD_Type = Convert.ToString(dr["PCCD_Type"]);
            if (dr["PCCD_RCode"] != DBNull.Value) pCD_DRecord.PCCD_RCode = Convert.ToString(dr["PCCD_RCode"]);
            if (dr["PCCD_PRCode"] != DBNull.Value) pCD_DRecord.PCCD_PRCode = Convert.ToString(dr["PCCD_PRCode"]);
            if (dr["PCCD_PPCode"] != DBNull.Value) pCD_DRecord.PCCD_PPCode = Convert.ToString(dr["PCCD_PPCode"]);
            if (dr["PCCD_PTCode"] != DBNull.Value) pCD_DRecord.PCCD_PTCode = Convert.ToString(dr["PCCD_PTCode"]);
            if (dr["PCCD_PTNum"] != DBNull.Value) pCD_DRecord.PCCD_PTNum = Convert.ToDecimal(dr["PCCD_PTNum"]);
            if (dr["PCCD_PNTCode"] != DBNull.Value) pCD_DRecord.PCCD_PNTCode = Convert.ToString(dr["PCCD_PNTCode"]);
            if (dr["PCCD_NCode"] != DBNull.Value) pCD_DRecord.PCCD_NCode = Convert.ToString(dr["PCCD_NCode"]);
            if (dr["PCCD_NTCode"] != DBNull.Value) pCD_DRecord.PCCD_NTCode = Convert.ToString(dr["PCCD_NTCode"]);
            if (dr["PCCD_NTNum"] != DBNull.Value) pCD_DRecord.PCCD_NTNum = Convert.ToDecimal(dr["PCCD_NTNum"]);
            if (dr["PCCD_NPCode"] != DBNull.Value) pCD_DRecord.PCCD_NPCode = Convert.ToString(dr["PCCD_NPCode"]);
            if (dr["PCCD_NRCode"] != DBNull.Value) pCD_DRecord.PCCD_NRCode = Convert.ToString(dr["PCCD_NRCode"]);
            if (dr["PCCD_IsHandle"] != DBNull.Value) pCD_DRecord.PCCD_IsHandle = Convert.ToString(dr["PCCD_IsHandle"]);
            if (dr["PCCD_IsOut"] != DBNull.Value) pCD_DRecord.PCCD_IsOut = Convert.ToInt32(dr["PCCD_IsOut"]);
            if (dr["PCCD_Tester"] != DBNull.Value) pCD_DRecord.PCCD_Tester = Convert.ToString(dr["PCCD_Tester"]);
            if (dr["PCCD_TestDate"] != DBNull.Value) pCD_DRecord.PCCD_TestDate = Convert.ToDateTime(dr["PCCD_TestDate"]);
            if (dr["PCCD_TestAdvice"] != DBNull.Value) pCD_DRecord.PCCD_TestAdvice = Convert.ToString(dr["PCCD_TestAdvice"]);
            if (dr["PCCD_HType"] != DBNull.Value) pCD_DRecord.PCCD_HType = Convert.ToString(dr["PCCD_HType"]);
            if (dr["PCCD_ERemark"] != DBNull.Value) pCD_DRecord.PCCD_ERemark = Convert.ToString(dr["PCCD_ERemark"]);
            if (dr["Stat"] != DBNull.Value) pCD_DRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_DRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_DRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_DRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            ret.Add(pCD_DRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
