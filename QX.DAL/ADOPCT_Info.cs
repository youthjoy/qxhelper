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
   /// 车辆信息
   /// </summary>
   [Serializable]
   public partial class ADOPCT_Info
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加车辆信息 PCT_Info对象(即:一条记录)
      /// </summary>
      public int Add(PCT_Info pCT_Info)
      {
         string sql = "INSERT INTO PCT_Info (PCTI_Code,PCTI_NO,PCTI_TCode,PCTI_BCode,PCTI_BName,PCTI_Type,PCTI_DCode,PCTI_DName,PCTI_Tare,PCTI_Gross,PCTI_VTare,PCTI_BTare,PCTI_Manu,PCTI_FDate,PCTI_BDate,PCTI_Spec,PCTI_CompanyCode,PCTI_Company,PCTI_DepartmentCode,PCTI_Department,PCTI_TAttach,PCTI_Tech,PCTI_iType,PCTI_Status,Stat,CreateDate,UpdateDate,DeleteDate,PCTI_LStatus,PCTI_Addr,PCTI_Address,PCTI_Udef1,PCTI_Udef2,PCTI_Udef3,PCTI_Udef4,PCTI_Udef5) VALUES (@PCTI_Code,@PCTI_NO,@PCTI_TCode,@PCTI_BCode,@PCTI_BName,@PCTI_Type,@PCTI_DCode,@PCTI_DName,@PCTI_Tare,@PCTI_Gross,@PCTI_VTare,@PCTI_BTare,@PCTI_Manu,@PCTI_FDate,@PCTI_BDate,@PCTI_Spec,@PCTI_CompanyCode,@PCTI_Company,@PCTI_DepartmentCode,@PCTI_Department,@PCTI_TAttach,@PCTI_Tech,@PCTI_iType,@PCTI_Status,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCTI_LStatus,@PCTI_Addr,@PCTI_Address,@PCTI_Udef1,@PCTI_Udef2,@PCTI_Udef3,@PCTI_Udef4,@PCTI_Udef5)";
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Code))
         {
            idb.AddParameter("@PCTI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Code", pCT_Info.PCTI_Code);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_NO))
         {
            idb.AddParameter("@PCTI_NO", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_NO", pCT_Info.PCTI_NO);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_TCode))
         {
            idb.AddParameter("@PCTI_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_TCode", pCT_Info.PCTI_TCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_BCode))
         {
            idb.AddParameter("@PCTI_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_BCode", pCT_Info.PCTI_BCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_BName))
         {
            idb.AddParameter("@PCTI_BName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_BName", pCT_Info.PCTI_BName);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Type))
         {
            idb.AddParameter("@PCTI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Type", pCT_Info.PCTI_Type);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_DCode))
         {
            idb.AddParameter("@PCTI_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_DCode", pCT_Info.PCTI_DCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_DName))
         {
            idb.AddParameter("@PCTI_DName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_DName", pCT_Info.PCTI_DName);
         }
         if (pCT_Info.PCTI_Tare == 0)
         {
            idb.AddParameter("@PCTI_Tare", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_Tare", pCT_Info.PCTI_Tare);
         }
         if (pCT_Info.PCTI_Gross == 0)
         {
            idb.AddParameter("@PCTI_Gross", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_Gross", pCT_Info.PCTI_Gross);
         }
         if (pCT_Info.PCTI_VTare == 0)
         {
            idb.AddParameter("@PCTI_VTare", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_VTare", pCT_Info.PCTI_VTare);
         }
         if (pCT_Info.PCTI_BTare == 0)
         {
            idb.AddParameter("@PCTI_BTare", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_BTare", pCT_Info.PCTI_BTare);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Manu))
         {
            idb.AddParameter("@PCTI_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Manu", pCT_Info.PCTI_Manu);
         }
         if (pCT_Info.PCTI_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTI_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_FDate", pCT_Info.PCTI_FDate);
         }
         if (pCT_Info.PCTI_BDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTI_BDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_BDate", pCT_Info.PCTI_BDate);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Spec))
         {
            idb.AddParameter("@PCTI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Spec", pCT_Info.PCTI_Spec);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_CompanyCode))
         {
            idb.AddParameter("@PCTI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_CompanyCode", pCT_Info.PCTI_CompanyCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Company))
         {
            idb.AddParameter("@PCTI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Company", pCT_Info.PCTI_Company);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_DepartmentCode))
         {
            idb.AddParameter("@PCTI_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_DepartmentCode", pCT_Info.PCTI_DepartmentCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Department))
         {
            idb.AddParameter("@PCTI_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Department", pCT_Info.PCTI_Department);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_TAttach))
         {
            idb.AddParameter("@PCTI_TAttach", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_TAttach", pCT_Info.PCTI_TAttach);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Tech))
         {
            idb.AddParameter("@PCTI_Tech", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Tech", pCT_Info.PCTI_Tech);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_iType))
         {
            idb.AddParameter("@PCTI_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_iType", pCT_Info.PCTI_iType);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Status))
         {
            idb.AddParameter("@PCTI_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Status", pCT_Info.PCTI_Status);
         }
         if (pCT_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Info.Stat);
         }
         if (pCT_Info.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Info.CreateDate);
         }
         if (pCT_Info.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Info.UpdateDate);
         }
         if (pCT_Info.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Info.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_LStatus))
         {
            idb.AddParameter("@PCTI_LStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_LStatus", pCT_Info.PCTI_LStatus);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Addr))
         {
            idb.AddParameter("@PCTI_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Addr", pCT_Info.PCTI_Addr);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Address))
         {
            idb.AddParameter("@PCTI_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Address", pCT_Info.PCTI_Address);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef1))
         {
            idb.AddParameter("@PCTI_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef1", pCT_Info.PCTI_Udef1);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef2))
         {
            idb.AddParameter("@PCTI_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef2", pCT_Info.PCTI_Udef2);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef3))
         {
            idb.AddParameter("@PCTI_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef3", pCT_Info.PCTI_Udef3);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef4))
         {
            idb.AddParameter("@PCTI_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef4", pCT_Info.PCTI_Udef4);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef5))
         {
            idb.AddParameter("@PCTI_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef5", pCT_Info.PCTI_Udef5);
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
      /// 添加车辆信息 PCT_Info对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCT_Info pCT_Info)
      {
         string sql = "INSERT INTO PCT_Info (PCTI_Code,PCTI_NO,PCTI_TCode,PCTI_BCode,PCTI_BName,PCTI_Type,PCTI_DCode,PCTI_DName,PCTI_Tare,PCTI_Gross,PCTI_VTare,PCTI_BTare,PCTI_Manu,PCTI_FDate,PCTI_BDate,PCTI_Spec,PCTI_CompanyCode,PCTI_Company,PCTI_DepartmentCode,PCTI_Department,PCTI_TAttach,PCTI_Tech,PCTI_iType,PCTI_Status,Stat,CreateDate,UpdateDate,DeleteDate,PCTI_LStatus,PCTI_Addr,PCTI_Address,PCTI_Udef1,PCTI_Udef2,PCTI_Udef3,PCTI_Udef4,PCTI_Udef5) VALUES (@PCTI_Code,@PCTI_NO,@PCTI_TCode,@PCTI_BCode,@PCTI_BName,@PCTI_Type,@PCTI_DCode,@PCTI_DName,@PCTI_Tare,@PCTI_Gross,@PCTI_VTare,@PCTI_BTare,@PCTI_Manu,@PCTI_FDate,@PCTI_BDate,@PCTI_Spec,@PCTI_CompanyCode,@PCTI_Company,@PCTI_DepartmentCode,@PCTI_Department,@PCTI_TAttach,@PCTI_Tech,@PCTI_iType,@PCTI_Status,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCTI_LStatus,@PCTI_Addr,@PCTI_Address,@PCTI_Udef1,@PCTI_Udef2,@PCTI_Udef3,@PCTI_Udef4,@PCTI_Udef5);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Code))
         {
            idb.AddParameter("@PCTI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Code", pCT_Info.PCTI_Code);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_NO))
         {
            idb.AddParameter("@PCTI_NO", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_NO", pCT_Info.PCTI_NO);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_TCode))
         {
            idb.AddParameter("@PCTI_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_TCode", pCT_Info.PCTI_TCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_BCode))
         {
            idb.AddParameter("@PCTI_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_BCode", pCT_Info.PCTI_BCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_BName))
         {
            idb.AddParameter("@PCTI_BName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_BName", pCT_Info.PCTI_BName);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Type))
         {
            idb.AddParameter("@PCTI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Type", pCT_Info.PCTI_Type);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_DCode))
         {
            idb.AddParameter("@PCTI_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_DCode", pCT_Info.PCTI_DCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_DName))
         {
            idb.AddParameter("@PCTI_DName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_DName", pCT_Info.PCTI_DName);
         }
         if (pCT_Info.PCTI_Tare == 0)
         {
            idb.AddParameter("@PCTI_Tare", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_Tare", pCT_Info.PCTI_Tare);
         }
         if (pCT_Info.PCTI_Gross == 0)
         {
            idb.AddParameter("@PCTI_Gross", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_Gross", pCT_Info.PCTI_Gross);
         }
         if (pCT_Info.PCTI_VTare == 0)
         {
            idb.AddParameter("@PCTI_VTare", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_VTare", pCT_Info.PCTI_VTare);
         }
         if (pCT_Info.PCTI_BTare == 0)
         {
            idb.AddParameter("@PCTI_BTare", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_BTare", pCT_Info.PCTI_BTare);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Manu))
         {
            idb.AddParameter("@PCTI_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Manu", pCT_Info.PCTI_Manu);
         }
         if (pCT_Info.PCTI_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTI_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_FDate", pCT_Info.PCTI_FDate);
         }
         if (pCT_Info.PCTI_BDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTI_BDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_BDate", pCT_Info.PCTI_BDate);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Spec))
         {
            idb.AddParameter("@PCTI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Spec", pCT_Info.PCTI_Spec);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_CompanyCode))
         {
            idb.AddParameter("@PCTI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_CompanyCode", pCT_Info.PCTI_CompanyCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Company))
         {
            idb.AddParameter("@PCTI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Company", pCT_Info.PCTI_Company);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_DepartmentCode))
         {
            idb.AddParameter("@PCTI_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_DepartmentCode", pCT_Info.PCTI_DepartmentCode);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Department))
         {
            idb.AddParameter("@PCTI_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Department", pCT_Info.PCTI_Department);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_TAttach))
         {
            idb.AddParameter("@PCTI_TAttach", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_TAttach", pCT_Info.PCTI_TAttach);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Tech))
         {
            idb.AddParameter("@PCTI_Tech", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Tech", pCT_Info.PCTI_Tech);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_iType))
         {
            idb.AddParameter("@PCTI_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_iType", pCT_Info.PCTI_iType);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Status))
         {
            idb.AddParameter("@PCTI_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Status", pCT_Info.PCTI_Status);
         }
         if (pCT_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Info.Stat);
         }
         if (pCT_Info.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Info.CreateDate);
         }
         if (pCT_Info.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Info.UpdateDate);
         }
         if (pCT_Info.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Info.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_LStatus))
         {
            idb.AddParameter("@PCTI_LStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_LStatus", pCT_Info.PCTI_LStatus);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Addr))
         {
            idb.AddParameter("@PCTI_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Addr", pCT_Info.PCTI_Addr);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Address))
         {
            idb.AddParameter("@PCTI_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Address", pCT_Info.PCTI_Address);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef1))
         {
            idb.AddParameter("@PCTI_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef1", pCT_Info.PCTI_Udef1);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef2))
         {
            idb.AddParameter("@PCTI_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef2", pCT_Info.PCTI_Udef2);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef3))
         {
            idb.AddParameter("@PCTI_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef3", pCT_Info.PCTI_Udef3);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef4))
         {
            idb.AddParameter("@PCTI_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef4", pCT_Info.PCTI_Udef4);
         }
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef5))
         {
            idb.AddParameter("@PCTI_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef5", pCT_Info.PCTI_Udef5);
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
      /// 更新车辆信息 PCT_Info对象(即:一条记录
      /// </summary>
      public int Update(PCT_Info pCT_Info)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCT_Info       SET ");
            if(pCT_Info.PCTI_Code_IsChanged){sbParameter.Append("PCTI_Code=@PCTI_Code, ");}
      if(pCT_Info.PCTI_NO_IsChanged){sbParameter.Append("PCTI_NO=@PCTI_NO, ");}
      if(pCT_Info.PCTI_TCode_IsChanged){sbParameter.Append("PCTI_TCode=@PCTI_TCode, ");}
      if(pCT_Info.PCTI_BCode_IsChanged){sbParameter.Append("PCTI_BCode=@PCTI_BCode, ");}
      if(pCT_Info.PCTI_BName_IsChanged){sbParameter.Append("PCTI_BName=@PCTI_BName, ");}
      if(pCT_Info.PCTI_Type_IsChanged){sbParameter.Append("PCTI_Type=@PCTI_Type, ");}
      if(pCT_Info.PCTI_DCode_IsChanged){sbParameter.Append("PCTI_DCode=@PCTI_DCode, ");}
      if(pCT_Info.PCTI_DName_IsChanged){sbParameter.Append("PCTI_DName=@PCTI_DName, ");}
      if(pCT_Info.PCTI_Tare_IsChanged){sbParameter.Append("PCTI_Tare=@PCTI_Tare, ");}
      if(pCT_Info.PCTI_Gross_IsChanged){sbParameter.Append("PCTI_Gross=@PCTI_Gross, ");}
      if(pCT_Info.PCTI_VTare_IsChanged){sbParameter.Append("PCTI_VTare=@PCTI_VTare, ");}
      if(pCT_Info.PCTI_BTare_IsChanged){sbParameter.Append("PCTI_BTare=@PCTI_BTare, ");}
      if(pCT_Info.PCTI_Manu_IsChanged){sbParameter.Append("PCTI_Manu=@PCTI_Manu, ");}
      if(pCT_Info.PCTI_FDate_IsChanged){sbParameter.Append("PCTI_FDate=@PCTI_FDate, ");}
      if(pCT_Info.PCTI_BDate_IsChanged){sbParameter.Append("PCTI_BDate=@PCTI_BDate, ");}
      if(pCT_Info.PCTI_Spec_IsChanged){sbParameter.Append("PCTI_Spec=@PCTI_Spec, ");}
      if(pCT_Info.PCTI_CompanyCode_IsChanged){sbParameter.Append("PCTI_CompanyCode=@PCTI_CompanyCode, ");}
      if(pCT_Info.PCTI_Company_IsChanged){sbParameter.Append("PCTI_Company=@PCTI_Company, ");}
      if(pCT_Info.PCTI_DepartmentCode_IsChanged){sbParameter.Append("PCTI_DepartmentCode=@PCTI_DepartmentCode, ");}
      if(pCT_Info.PCTI_Department_IsChanged){sbParameter.Append("PCTI_Department=@PCTI_Department, ");}
      if(pCT_Info.PCTI_TAttach_IsChanged){sbParameter.Append("PCTI_TAttach=@PCTI_TAttach, ");}
      if(pCT_Info.PCTI_Tech_IsChanged){sbParameter.Append("PCTI_Tech=@PCTI_Tech, ");}
      if(pCT_Info.PCTI_iType_IsChanged){sbParameter.Append("PCTI_iType=@PCTI_iType, ");}
      if(pCT_Info.PCTI_Status_IsChanged){sbParameter.Append("PCTI_Status=@PCTI_Status, ");}
      if(pCT_Info.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCT_Info.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pCT_Info.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pCT_Info.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pCT_Info.PCTI_LStatus_IsChanged){sbParameter.Append("PCTI_LStatus=@PCTI_LStatus, ");}
      if(pCT_Info.PCTI_Addr_IsChanged){sbParameter.Append("PCTI_Addr=@PCTI_Addr, ");}
      if(pCT_Info.PCTI_Address_IsChanged){sbParameter.Append("PCTI_Address=@PCTI_Address, ");}
      if(pCT_Info.PCTI_Udef1_IsChanged){sbParameter.Append("PCTI_Udef1=@PCTI_Udef1, ");}
      if(pCT_Info.PCTI_Udef2_IsChanged){sbParameter.Append("PCTI_Udef2=@PCTI_Udef2, ");}
      if(pCT_Info.PCTI_Udef3_IsChanged){sbParameter.Append("PCTI_Udef3=@PCTI_Udef3, ");}
      if(pCT_Info.PCTI_Udef4_IsChanged){sbParameter.Append("PCTI_Udef4=@PCTI_Udef4, ");}
      if(pCT_Info.PCTI_Udef5_IsChanged){sbParameter.Append("PCTI_Udef5=@PCTI_Udef5 ");}
          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCTI_ID=@PCTI_ID; " );
      string sql=sb.ToString();
         if(pCT_Info.PCTI_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Code))
         {
            idb.AddParameter("@PCTI_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Code", pCT_Info.PCTI_Code);
         }
          }
         if(pCT_Info.PCTI_NO_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_NO))
         {
            idb.AddParameter("@PCTI_NO", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_NO", pCT_Info.PCTI_NO);
         }
          }
         if(pCT_Info.PCTI_TCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_TCode))
         {
            idb.AddParameter("@PCTI_TCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_TCode", pCT_Info.PCTI_TCode);
         }
          }
         if(pCT_Info.PCTI_BCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_BCode))
         {
            idb.AddParameter("@PCTI_BCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_BCode", pCT_Info.PCTI_BCode);
         }
          }
         if(pCT_Info.PCTI_BName_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_BName))
         {
            idb.AddParameter("@PCTI_BName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_BName", pCT_Info.PCTI_BName);
         }
          }
         if(pCT_Info.PCTI_Type_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Type))
         {
            idb.AddParameter("@PCTI_Type", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Type", pCT_Info.PCTI_Type);
         }
          }
         if(pCT_Info.PCTI_DCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_DCode))
         {
            idb.AddParameter("@PCTI_DCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_DCode", pCT_Info.PCTI_DCode);
         }
          }
         if(pCT_Info.PCTI_DName_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_DName))
         {
            idb.AddParameter("@PCTI_DName", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_DName", pCT_Info.PCTI_DName);
         }
          }
         if(pCT_Info.PCTI_Tare_IsChanged)
         {
         if (pCT_Info.PCTI_Tare == 0)
         {
            idb.AddParameter("@PCTI_Tare", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_Tare", pCT_Info.PCTI_Tare);
         }
          }
         if(pCT_Info.PCTI_Gross_IsChanged)
         {
         if (pCT_Info.PCTI_Gross == 0)
         {
            idb.AddParameter("@PCTI_Gross", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_Gross", pCT_Info.PCTI_Gross);
         }
          }
         if(pCT_Info.PCTI_VTare_IsChanged)
         {
         if (pCT_Info.PCTI_VTare == 0)
         {
            idb.AddParameter("@PCTI_VTare", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_VTare", pCT_Info.PCTI_VTare);
         }
          }
         if(pCT_Info.PCTI_BTare_IsChanged)
         {
         if (pCT_Info.PCTI_BTare == 0)
         {
            idb.AddParameter("@PCTI_BTare", 0);
         }
         else
         {
            idb.AddParameter("@PCTI_BTare", pCT_Info.PCTI_BTare);
         }
          }
         if(pCT_Info.PCTI_Manu_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Manu))
         {
            idb.AddParameter("@PCTI_Manu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Manu", pCT_Info.PCTI_Manu);
         }
          }
         if(pCT_Info.PCTI_FDate_IsChanged)
         {
         if (pCT_Info.PCTI_FDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTI_FDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_FDate", pCT_Info.PCTI_FDate);
         }
          }
         if(pCT_Info.PCTI_BDate_IsChanged)
         {
         if (pCT_Info.PCTI_BDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCTI_BDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_BDate", pCT_Info.PCTI_BDate);
         }
          }
         if(pCT_Info.PCTI_Spec_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Spec))
         {
            idb.AddParameter("@PCTI_Spec", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Spec", pCT_Info.PCTI_Spec);
         }
          }
         if(pCT_Info.PCTI_CompanyCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_CompanyCode))
         {
            idb.AddParameter("@PCTI_CompanyCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_CompanyCode", pCT_Info.PCTI_CompanyCode);
         }
          }
         if(pCT_Info.PCTI_Company_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Company))
         {
            idb.AddParameter("@PCTI_Company", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Company", pCT_Info.PCTI_Company);
         }
          }
         if(pCT_Info.PCTI_DepartmentCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_DepartmentCode))
         {
            idb.AddParameter("@PCTI_DepartmentCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_DepartmentCode", pCT_Info.PCTI_DepartmentCode);
         }
          }
         if(pCT_Info.PCTI_Department_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Department))
         {
            idb.AddParameter("@PCTI_Department", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Department", pCT_Info.PCTI_Department);
         }
          }
         if(pCT_Info.PCTI_TAttach_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_TAttach))
         {
            idb.AddParameter("@PCTI_TAttach", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_TAttach", pCT_Info.PCTI_TAttach);
         }
          }
         if(pCT_Info.PCTI_Tech_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Tech))
         {
            idb.AddParameter("@PCTI_Tech", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Tech", pCT_Info.PCTI_Tech);
         }
          }
         if(pCT_Info.PCTI_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_iType))
         {
            idb.AddParameter("@PCTI_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_iType", pCT_Info.PCTI_iType);
         }
          }
         if(pCT_Info.PCTI_Status_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Status))
         {
            idb.AddParameter("@PCTI_Status", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Status", pCT_Info.PCTI_Status);
         }
          }
         if(pCT_Info.Stat_IsChanged)
         {
         if (pCT_Info.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCT_Info.Stat);
         }
          }
         if(pCT_Info.CreateDate_IsChanged)
         {
         if (pCT_Info.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCT_Info.CreateDate);
         }
          }
         if(pCT_Info.UpdateDate_IsChanged)
         {
         if (pCT_Info.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCT_Info.UpdateDate);
         }
          }
         if(pCT_Info.DeleteDate_IsChanged)
         {
         if (pCT_Info.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCT_Info.DeleteDate);
         }
          }
         if(pCT_Info.PCTI_LStatus_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_LStatus))
         {
            idb.AddParameter("@PCTI_LStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_LStatus", pCT_Info.PCTI_LStatus);
         }
          }
         if(pCT_Info.PCTI_Addr_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Addr))
         {
            idb.AddParameter("@PCTI_Addr", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Addr", pCT_Info.PCTI_Addr);
         }
          }
         if(pCT_Info.PCTI_Address_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Address))
         {
            idb.AddParameter("@PCTI_Address", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Address", pCT_Info.PCTI_Address);
         }
          }
         if(pCT_Info.PCTI_Udef1_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef1))
         {
            idb.AddParameter("@PCTI_Udef1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef1", pCT_Info.PCTI_Udef1);
         }
          }
         if(pCT_Info.PCTI_Udef2_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef2))
         {
            idb.AddParameter("@PCTI_Udef2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef2", pCT_Info.PCTI_Udef2);
         }
          }
         if(pCT_Info.PCTI_Udef3_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef3))
         {
            idb.AddParameter("@PCTI_Udef3", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef3", pCT_Info.PCTI_Udef3);
         }
          }
         if(pCT_Info.PCTI_Udef4_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef4))
         {
            idb.AddParameter("@PCTI_Udef4", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef4", pCT_Info.PCTI_Udef4);
         }
          }
         if(pCT_Info.PCTI_Udef5_IsChanged)
         {
         if (string.IsNullOrEmpty(pCT_Info.PCTI_Udef5))
         {
            idb.AddParameter("@PCTI_Udef5", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCTI_Udef5", pCT_Info.PCTI_Udef5);
         }
          }

         idb.AddParameter("@PCTI_ID", pCT_Info.PCTI_ID);

           
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
      /// 删除车辆信息 PCT_Info对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCTI_ID)
      {
         string sql = "DELETE PCT_Info WHERE 1=1  AND PCTI_ID=@PCTI_ID ";
         idb.AddParameter("@PCTI_ID", pCTI_ID);

           
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
      /// 获取指定的车辆信息 PCT_Info对象(即:一条记录
      /// </summary>
      public PCT_Info GetByKey(decimal pCTI_ID)
      {
         PCT_Info pCT_Info = new PCT_Info();
         string sql = "SELECT  PCTI_ID,PCTI_Code,PCTI_NO,PCTI_TCode,PCTI_BCode,PCTI_BName,PCTI_Type,PCTI_DCode,PCTI_DName,PCTI_Tare,PCTI_Gross,PCTI_VTare,PCTI_BTare,PCTI_Manu,PCTI_FDate,PCTI_BDate,PCTI_Spec,PCTI_CompanyCode,PCTI_Company,PCTI_DepartmentCode,PCTI_Department,PCTI_TAttach,PCTI_Tech,PCTI_iType,PCTI_Status,Stat,CreateDate,UpdateDate,DeleteDate,PCTI_LStatus,PCTI_Addr,PCTI_Address,PCTI_Udef1,PCTI_Udef2,PCTI_Udef3,PCTI_Udef4,PCTI_Udef5 FROM PCT_Info WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCTI_ID=@PCTI_ID ";
         idb.AddParameter("@PCTI_ID", pCTI_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCTI_ID"] != DBNull.Value) pCT_Info.PCTI_ID = Convert.ToDecimal(dr["PCTI_ID"]);
            if (dr["PCTI_Code"] != DBNull.Value) pCT_Info.PCTI_Code = Convert.ToString(dr["PCTI_Code"]);
            if (dr["PCTI_NO"] != DBNull.Value) pCT_Info.PCTI_NO = Convert.ToString(dr["PCTI_NO"]);
            if (dr["PCTI_TCode"] != DBNull.Value) pCT_Info.PCTI_TCode = Convert.ToString(dr["PCTI_TCode"]);
            if (dr["PCTI_BCode"] != DBNull.Value) pCT_Info.PCTI_BCode = Convert.ToString(dr["PCTI_BCode"]);
            if (dr["PCTI_BName"] != DBNull.Value) pCT_Info.PCTI_BName = Convert.ToString(dr["PCTI_BName"]);
            if (dr["PCTI_Type"] != DBNull.Value) pCT_Info.PCTI_Type = Convert.ToString(dr["PCTI_Type"]);
            if (dr["PCTI_DCode"] != DBNull.Value) pCT_Info.PCTI_DCode = Convert.ToString(dr["PCTI_DCode"]);
            if (dr["PCTI_DName"] != DBNull.Value) pCT_Info.PCTI_DName = Convert.ToString(dr["PCTI_DName"]);
            if (dr["PCTI_Tare"] != DBNull.Value) pCT_Info.PCTI_Tare = Convert.ToDecimal(dr["PCTI_Tare"]);
            if (dr["PCTI_Gross"] != DBNull.Value) pCT_Info.PCTI_Gross = Convert.ToDecimal(dr["PCTI_Gross"]);
            if (dr["PCTI_VTare"] != DBNull.Value) pCT_Info.PCTI_VTare = Convert.ToDecimal(dr["PCTI_VTare"]);
            if (dr["PCTI_BTare"] != DBNull.Value) pCT_Info.PCTI_BTare = Convert.ToDecimal(dr["PCTI_BTare"]);
            if (dr["PCTI_Manu"] != DBNull.Value) pCT_Info.PCTI_Manu = Convert.ToString(dr["PCTI_Manu"]);
            if (dr["PCTI_FDate"] != DBNull.Value) pCT_Info.PCTI_FDate = Convert.ToDateTime(dr["PCTI_FDate"]);
            if (dr["PCTI_BDate"] != DBNull.Value) pCT_Info.PCTI_BDate = Convert.ToDateTime(dr["PCTI_BDate"]);
            if (dr["PCTI_Spec"] != DBNull.Value) pCT_Info.PCTI_Spec = Convert.ToString(dr["PCTI_Spec"]);
            if (dr["PCTI_CompanyCode"] != DBNull.Value) pCT_Info.PCTI_CompanyCode = Convert.ToString(dr["PCTI_CompanyCode"]);
            if (dr["PCTI_Company"] != DBNull.Value) pCT_Info.PCTI_Company = Convert.ToString(dr["PCTI_Company"]);
            if (dr["PCTI_DepartmentCode"] != DBNull.Value) pCT_Info.PCTI_DepartmentCode = Convert.ToString(dr["PCTI_DepartmentCode"]);
            if (dr["PCTI_Department"] != DBNull.Value) pCT_Info.PCTI_Department = Convert.ToString(dr["PCTI_Department"]);
            if (dr["PCTI_TAttach"] != DBNull.Value) pCT_Info.PCTI_TAttach = Convert.ToString(dr["PCTI_TAttach"]);
            if (dr["PCTI_Tech"] != DBNull.Value) pCT_Info.PCTI_Tech = Convert.ToString(dr["PCTI_Tech"]);
            if (dr["PCTI_iType"] != DBNull.Value) pCT_Info.PCTI_iType = Convert.ToString(dr["PCTI_iType"]);
            if (dr["PCTI_Status"] != DBNull.Value) pCT_Info.PCTI_Status = Convert.ToString(dr["PCTI_Status"]);
            if (dr["Stat"] != DBNull.Value) pCT_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Info.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Info.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Info.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTI_LStatus"] != DBNull.Value) pCT_Info.PCTI_LStatus = Convert.ToString(dr["PCTI_LStatus"]);
            if (dr["PCTI_Addr"] != DBNull.Value) pCT_Info.PCTI_Addr = Convert.ToString(dr["PCTI_Addr"]);
            if (dr["PCTI_Address"] != DBNull.Value) pCT_Info.PCTI_Address = Convert.ToString(dr["PCTI_Address"]);
            if (dr["PCTI_Udef1"] != DBNull.Value) pCT_Info.PCTI_Udef1 = Convert.ToString(dr["PCTI_Udef1"]);
            if (dr["PCTI_Udef2"] != DBNull.Value) pCT_Info.PCTI_Udef2 = Convert.ToString(dr["PCTI_Udef2"]);
            if (dr["PCTI_Udef3"] != DBNull.Value) pCT_Info.PCTI_Udef3 = Convert.ToString(dr["PCTI_Udef3"]);
            if (dr["PCTI_Udef4"] != DBNull.Value) pCT_Info.PCTI_Udef4 = Convert.ToString(dr["PCTI_Udef4"]);
            if (dr["PCTI_Udef5"] != DBNull.Value) pCT_Info.PCTI_Udef5 = Convert.ToString(dr["PCTI_Udef5"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCT_Info;
      }
      /// <summary>
      /// 获取指定的车辆信息 PCT_Info对象集合
      /// </summary>
      public List<PCT_Info> GetListByWhere(string strCondition)
      {
         List<PCT_Info> ret = new List<PCT_Info>();
         string sql = "SELECT  PCTI_ID,PCTI_Code,PCTI_NO,PCTI_TCode,PCTI_BCode,PCTI_BName,PCTI_Type,PCTI_DCode,PCTI_DName,PCTI_Tare,PCTI_Gross,PCTI_VTare,PCTI_BTare,PCTI_Manu,PCTI_FDate,PCTI_BDate,PCTI_Spec,PCTI_CompanyCode,PCTI_Company,PCTI_DepartmentCode,PCTI_Department,PCTI_TAttach,PCTI_Tech,PCTI_iType,PCTI_Status,Stat,CreateDate,UpdateDate,DeleteDate,PCTI_LStatus,PCTI_Addr,PCTI_Address,PCTI_Udef1,PCTI_Udef2,PCTI_Udef3,PCTI_Udef4,PCTI_Udef5 FROM PCT_Info WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCT_Info pCT_Info = new PCT_Info();
            if (dr["PCTI_ID"] != DBNull.Value) pCT_Info.PCTI_ID = Convert.ToDecimal(dr["PCTI_ID"]);
            if (dr["PCTI_Code"] != DBNull.Value) pCT_Info.PCTI_Code = Convert.ToString(dr["PCTI_Code"]);
            if (dr["PCTI_NO"] != DBNull.Value) pCT_Info.PCTI_NO = Convert.ToString(dr["PCTI_NO"]);
            if (dr["PCTI_TCode"] != DBNull.Value) pCT_Info.PCTI_TCode = Convert.ToString(dr["PCTI_TCode"]);
            if (dr["PCTI_BCode"] != DBNull.Value) pCT_Info.PCTI_BCode = Convert.ToString(dr["PCTI_BCode"]);
            if (dr["PCTI_BName"] != DBNull.Value) pCT_Info.PCTI_BName = Convert.ToString(dr["PCTI_BName"]);
            if (dr["PCTI_Type"] != DBNull.Value) pCT_Info.PCTI_Type = Convert.ToString(dr["PCTI_Type"]);
            if (dr["PCTI_DCode"] != DBNull.Value) pCT_Info.PCTI_DCode = Convert.ToString(dr["PCTI_DCode"]);
            if (dr["PCTI_DName"] != DBNull.Value) pCT_Info.PCTI_DName = Convert.ToString(dr["PCTI_DName"]);
            if (dr["PCTI_Tare"] != DBNull.Value) pCT_Info.PCTI_Tare = Convert.ToDecimal(dr["PCTI_Tare"]);
            if (dr["PCTI_Gross"] != DBNull.Value) pCT_Info.PCTI_Gross = Convert.ToDecimal(dr["PCTI_Gross"]);
            if (dr["PCTI_VTare"] != DBNull.Value) pCT_Info.PCTI_VTare = Convert.ToDecimal(dr["PCTI_VTare"]);
            if (dr["PCTI_BTare"] != DBNull.Value) pCT_Info.PCTI_BTare = Convert.ToDecimal(dr["PCTI_BTare"]);
            if (dr["PCTI_Manu"] != DBNull.Value) pCT_Info.PCTI_Manu = Convert.ToString(dr["PCTI_Manu"]);
            if (dr["PCTI_FDate"] != DBNull.Value) pCT_Info.PCTI_FDate = Convert.ToDateTime(dr["PCTI_FDate"]);
            if (dr["PCTI_BDate"] != DBNull.Value) pCT_Info.PCTI_BDate = Convert.ToDateTime(dr["PCTI_BDate"]);
            if (dr["PCTI_Spec"] != DBNull.Value) pCT_Info.PCTI_Spec = Convert.ToString(dr["PCTI_Spec"]);
            if (dr["PCTI_CompanyCode"] != DBNull.Value) pCT_Info.PCTI_CompanyCode = Convert.ToString(dr["PCTI_CompanyCode"]);
            if (dr["PCTI_Company"] != DBNull.Value) pCT_Info.PCTI_Company = Convert.ToString(dr["PCTI_Company"]);
            if (dr["PCTI_DepartmentCode"] != DBNull.Value) pCT_Info.PCTI_DepartmentCode = Convert.ToString(dr["PCTI_DepartmentCode"]);
            if (dr["PCTI_Department"] != DBNull.Value) pCT_Info.PCTI_Department = Convert.ToString(dr["PCTI_Department"]);
            if (dr["PCTI_TAttach"] != DBNull.Value) pCT_Info.PCTI_TAttach = Convert.ToString(dr["PCTI_TAttach"]);
            if (dr["PCTI_Tech"] != DBNull.Value) pCT_Info.PCTI_Tech = Convert.ToString(dr["PCTI_Tech"]);
            if (dr["PCTI_iType"] != DBNull.Value) pCT_Info.PCTI_iType = Convert.ToString(dr["PCTI_iType"]);
            if (dr["PCTI_Status"] != DBNull.Value) pCT_Info.PCTI_Status = Convert.ToString(dr["PCTI_Status"]);
            if (dr["Stat"] != DBNull.Value) pCT_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Info.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Info.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Info.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTI_LStatus"] != DBNull.Value) pCT_Info.PCTI_LStatus = Convert.ToString(dr["PCTI_LStatus"]);
            if (dr["PCTI_Addr"] != DBNull.Value) pCT_Info.PCTI_Addr = Convert.ToString(dr["PCTI_Addr"]);
            if (dr["PCTI_Address"] != DBNull.Value) pCT_Info.PCTI_Address = Convert.ToString(dr["PCTI_Address"]);
            if (dr["PCTI_Udef1"] != DBNull.Value) pCT_Info.PCTI_Udef1 = Convert.ToString(dr["PCTI_Udef1"]);
            if (dr["PCTI_Udef2"] != DBNull.Value) pCT_Info.PCTI_Udef2 = Convert.ToString(dr["PCTI_Udef2"]);
            if (dr["PCTI_Udef3"] != DBNull.Value) pCT_Info.PCTI_Udef3 = Convert.ToString(dr["PCTI_Udef3"]);
            if (dr["PCTI_Udef4"] != DBNull.Value) pCT_Info.PCTI_Udef4 = Convert.ToString(dr["PCTI_Udef4"]);
            if (dr["PCTI_Udef5"] != DBNull.Value) pCT_Info.PCTI_Udef5 = Convert.ToString(dr["PCTI_Udef5"]);
            ret.Add(pCT_Info);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的车辆信息 PCT_Info对象(即:一条记录
      /// </summary>
      public List<PCT_Info> GetAll()
      {
         List<PCT_Info> ret = new List<PCT_Info>();
         string sql = "SELECT  PCTI_ID,PCTI_Code,PCTI_NO,PCTI_TCode,PCTI_BCode,PCTI_BName,PCTI_Type,PCTI_DCode,PCTI_DName,PCTI_Tare,PCTI_Gross,PCTI_VTare,PCTI_BTare,PCTI_Manu,PCTI_FDate,PCTI_BDate,PCTI_Spec,PCTI_CompanyCode,PCTI_Company,PCTI_DepartmentCode,PCTI_Department,PCTI_TAttach,PCTI_Tech,PCTI_iType,PCTI_Status,Stat,CreateDate,UpdateDate,DeleteDate,PCTI_LStatus,PCTI_Addr,PCTI_Address,PCTI_Udef1,PCTI_Udef2,PCTI_Udef3,PCTI_Udef4,PCTI_Udef5 FROM PCT_Info where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCTI_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCT_Info pCT_Info = new PCT_Info();
            if (dr["PCTI_ID"] != DBNull.Value) pCT_Info.PCTI_ID = Convert.ToDecimal(dr["PCTI_ID"]);
            if (dr["PCTI_Code"] != DBNull.Value) pCT_Info.PCTI_Code = Convert.ToString(dr["PCTI_Code"]);
            if (dr["PCTI_NO"] != DBNull.Value) pCT_Info.PCTI_NO = Convert.ToString(dr["PCTI_NO"]);
            if (dr["PCTI_TCode"] != DBNull.Value) pCT_Info.PCTI_TCode = Convert.ToString(dr["PCTI_TCode"]);
            if (dr["PCTI_BCode"] != DBNull.Value) pCT_Info.PCTI_BCode = Convert.ToString(dr["PCTI_BCode"]);
            if (dr["PCTI_BName"] != DBNull.Value) pCT_Info.PCTI_BName = Convert.ToString(dr["PCTI_BName"]);
            if (dr["PCTI_Type"] != DBNull.Value) pCT_Info.PCTI_Type = Convert.ToString(dr["PCTI_Type"]);
            if (dr["PCTI_DCode"] != DBNull.Value) pCT_Info.PCTI_DCode = Convert.ToString(dr["PCTI_DCode"]);
            if (dr["PCTI_DName"] != DBNull.Value) pCT_Info.PCTI_DName = Convert.ToString(dr["PCTI_DName"]);
            if (dr["PCTI_Tare"] != DBNull.Value) pCT_Info.PCTI_Tare = Convert.ToDecimal(dr["PCTI_Tare"]);
            if (dr["PCTI_Gross"] != DBNull.Value) pCT_Info.PCTI_Gross = Convert.ToDecimal(dr["PCTI_Gross"]);
            if (dr["PCTI_VTare"] != DBNull.Value) pCT_Info.PCTI_VTare = Convert.ToDecimal(dr["PCTI_VTare"]);
            if (dr["PCTI_BTare"] != DBNull.Value) pCT_Info.PCTI_BTare = Convert.ToDecimal(dr["PCTI_BTare"]);
            if (dr["PCTI_Manu"] != DBNull.Value) pCT_Info.PCTI_Manu = Convert.ToString(dr["PCTI_Manu"]);
            if (dr["PCTI_FDate"] != DBNull.Value) pCT_Info.PCTI_FDate = Convert.ToDateTime(dr["PCTI_FDate"]);
            if (dr["PCTI_BDate"] != DBNull.Value) pCT_Info.PCTI_BDate = Convert.ToDateTime(dr["PCTI_BDate"]);
            if (dr["PCTI_Spec"] != DBNull.Value) pCT_Info.PCTI_Spec = Convert.ToString(dr["PCTI_Spec"]);
            if (dr["PCTI_CompanyCode"] != DBNull.Value) pCT_Info.PCTI_CompanyCode = Convert.ToString(dr["PCTI_CompanyCode"]);
            if (dr["PCTI_Company"] != DBNull.Value) pCT_Info.PCTI_Company = Convert.ToString(dr["PCTI_Company"]);
            if (dr["PCTI_DepartmentCode"] != DBNull.Value) pCT_Info.PCTI_DepartmentCode = Convert.ToString(dr["PCTI_DepartmentCode"]);
            if (dr["PCTI_Department"] != DBNull.Value) pCT_Info.PCTI_Department = Convert.ToString(dr["PCTI_Department"]);
            if (dr["PCTI_TAttach"] != DBNull.Value) pCT_Info.PCTI_TAttach = Convert.ToString(dr["PCTI_TAttach"]);
            if (dr["PCTI_Tech"] != DBNull.Value) pCT_Info.PCTI_Tech = Convert.ToString(dr["PCTI_Tech"]);
            if (dr["PCTI_iType"] != DBNull.Value) pCT_Info.PCTI_iType = Convert.ToString(dr["PCTI_iType"]);
            if (dr["PCTI_Status"] != DBNull.Value) pCT_Info.PCTI_Status = Convert.ToString(dr["PCTI_Status"]);
            if (dr["Stat"] != DBNull.Value) pCT_Info.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCT_Info.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCT_Info.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCT_Info.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCTI_LStatus"] != DBNull.Value) pCT_Info.PCTI_LStatus = Convert.ToString(dr["PCTI_LStatus"]);
            if (dr["PCTI_Addr"] != DBNull.Value) pCT_Info.PCTI_Addr = Convert.ToString(dr["PCTI_Addr"]);
            if (dr["PCTI_Address"] != DBNull.Value) pCT_Info.PCTI_Address = Convert.ToString(dr["PCTI_Address"]);
            if (dr["PCTI_Udef1"] != DBNull.Value) pCT_Info.PCTI_Udef1 = Convert.ToString(dr["PCTI_Udef1"]);
            if (dr["PCTI_Udef2"] != DBNull.Value) pCT_Info.PCTI_Udef2 = Convert.ToString(dr["PCTI_Udef2"]);
            if (dr["PCTI_Udef3"] != DBNull.Value) pCT_Info.PCTI_Udef3 = Convert.ToString(dr["PCTI_Udef3"]);
            if (dr["PCTI_Udef4"] != DBNull.Value) pCT_Info.PCTI_Udef4 = Convert.ToString(dr["PCTI_Udef4"]);
            if (dr["PCTI_Udef5"] != DBNull.Value) pCT_Info.PCTI_Udef5 = Convert.ToString(dr["PCTI_Udef5"]);
            ret.Add(pCT_Info);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
