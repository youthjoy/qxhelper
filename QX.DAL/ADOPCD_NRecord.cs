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
   /// 发货记录
   /// </summary>
   [Serializable]
   public partial class ADOPCD_NRecord
   {
      public IDBOperator idb =  DBOperator.GetInstance();
      /// <summary>
      /// 添加发货记录 PCD_NRecord对象(即:一条记录)
      /// </summary>
      public int Add(PCD_NRecord pCD_NRecord)
      {
         string sql = "INSERT INTO PCD_NRecord (PCDN_Code,PCDN_CCode,PCDN_PRCode,PCDN_PCode,PCDN_PDCode,PCDN_PSCode,PCDN_Part,PCDN_Slump,PCDN_Spec1,PCDN_Spec2,PCDN_TType,PCDN_TEqu,PCDN_SOwner,PCDN_SDate,PCDN_TBSta,PCDN_TBLine,PCDN_OOwner,PCDN_ODate,PCDN_ForeMan,PCDN_PPLimit,PCDN_DIType,PCDN_DINum,PCDN_PNum,PCDN_PCNum,PCDN_PTOrd,PCDN_PCDrv,PCDN_Comp,PCDN_PCCode,PCDN_PCNo,PCDN_DDate,PCDN_RDate,PCDN_JBegin,PCDN_JEnd,PCDN_LDate,PCDN_BDate,PCDN_PPNum,PCDN_TDNum,PCDN_TTNum,PCDN_RTNum,PCDN_CTNum,PCDN_RRNum,PCDN_MoreNum,PCDN_PRNum,PCDN_BStatus,PCDN_TRNum,PCDN_TBNum,PCDN_TBBak,PCDN_Stat,PCDN_iType,Stat,CreateDate,UpdateDate,DeleteDate,PCDN_SourceCode) VALUES (@PCDN_Code,@PCDN_CCode,@PCDN_PRCode,@PCDN_PCode,@PCDN_PDCode,@PCDN_PSCode,@PCDN_Part,@PCDN_Slump,@PCDN_Spec1,@PCDN_Spec2,@PCDN_TType,@PCDN_TEqu,@PCDN_SOwner,@PCDN_SDate,@PCDN_TBSta,@PCDN_TBLine,@PCDN_OOwner,@PCDN_ODate,@PCDN_ForeMan,@PCDN_PPLimit,@PCDN_DIType,@PCDN_DINum,@PCDN_PNum,@PCDN_PCNum,@PCDN_PTOrd,@PCDN_PCDrv,@PCDN_Comp,@PCDN_PCCode,@PCDN_PCNo,@PCDN_DDate,@PCDN_RDate,@PCDN_JBegin,@PCDN_JEnd,@PCDN_LDate,@PCDN_BDate,@PCDN_PPNum,@PCDN_TDNum,@PCDN_TTNum,@PCDN_RTNum,@PCDN_CTNum,@PCDN_RRNum,@PCDN_MoreNum,@PCDN_PRNum,@PCDN_BStatus,@PCDN_TRNum,@PCDN_TBNum,@PCDN_TBBak,@PCDN_Stat,@PCDN_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCDN_SourceCode)";
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Code))
         {
            idb.AddParameter("@PCDN_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Code", pCD_NRecord.PCDN_Code);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_CCode))
         {
            idb.AddParameter("@PCDN_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_CCode", pCD_NRecord.PCDN_CCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PRCode))
         {
            idb.AddParameter("@PCDN_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PRCode", pCD_NRecord.PCDN_PRCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCode))
         {
            idb.AddParameter("@PCDN_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCode", pCD_NRecord.PCDN_PCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PDCode))
         {
            idb.AddParameter("@PCDN_PDCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PDCode", pCD_NRecord.PCDN_PDCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PSCode))
         {
            idb.AddParameter("@PCDN_PSCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PSCode", pCD_NRecord.PCDN_PSCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Part))
         {
            idb.AddParameter("@PCDN_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Part", pCD_NRecord.PCDN_Part);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Slump))
         {
            idb.AddParameter("@PCDN_Slump", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Slump", pCD_NRecord.PCDN_Slump);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Spec1))
         {
            idb.AddParameter("@PCDN_Spec1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Spec1", pCD_NRecord.PCDN_Spec1);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Spec2))
         {
            idb.AddParameter("@PCDN_Spec2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Spec2", pCD_NRecord.PCDN_Spec2);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TType))
         {
            idb.AddParameter("@PCDN_TType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TType", pCD_NRecord.PCDN_TType);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TEqu))
         {
            idb.AddParameter("@PCDN_TEqu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TEqu", pCD_NRecord.PCDN_TEqu);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_SOwner))
         {
            idb.AddParameter("@PCDN_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_SOwner", pCD_NRecord.PCDN_SOwner);
         }
         if (pCD_NRecord.PCDN_SDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_SDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_SDate", pCD_NRecord.PCDN_SDate);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TBSta))
         {
            idb.AddParameter("@PCDN_TBSta", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TBSta", pCD_NRecord.PCDN_TBSta);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TBLine))
         {
            idb.AddParameter("@PCDN_TBLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TBLine", pCD_NRecord.PCDN_TBLine);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_OOwner))
         {
            idb.AddParameter("@PCDN_OOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_OOwner", pCD_NRecord.PCDN_OOwner);
         }
         if (pCD_NRecord.PCDN_ODate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_ODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_ODate", pCD_NRecord.PCDN_ODate);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_ForeMan))
         {
            idb.AddParameter("@PCDN_ForeMan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_ForeMan", pCD_NRecord.PCDN_ForeMan);
         }
         if (pCD_NRecord.PCDN_PPLimit == 0)
         {
            idb.AddParameter("@PCDN_PPLimit", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PPLimit", pCD_NRecord.PCDN_PPLimit);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_DIType))
         {
            idb.AddParameter("@PCDN_DIType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_DIType", pCD_NRecord.PCDN_DIType);
         }
         if (pCD_NRecord.PCDN_DINum == 0)
         {
            idb.AddParameter("@PCDN_DINum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_DINum", pCD_NRecord.PCDN_DINum);
         }
         if (pCD_NRecord.PCDN_PNum == 0)
         {
            idb.AddParameter("@PCDN_PNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PNum", pCD_NRecord.PCDN_PNum);
         }
         if (pCD_NRecord.PCDN_PCNum == 0)
         {
            idb.AddParameter("@PCDN_PCNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PCNum", pCD_NRecord.PCDN_PCNum);
         }
         if (pCD_NRecord.PCDN_PTOrd == 0)
         {
            idb.AddParameter("@PCDN_PTOrd", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PTOrd", pCD_NRecord.PCDN_PTOrd);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCDrv))
         {
            idb.AddParameter("@PCDN_PCDrv", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCDrv", pCD_NRecord.PCDN_PCDrv);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Comp))
         {
            idb.AddParameter("@PCDN_Comp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Comp", pCD_NRecord.PCDN_Comp);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCCode))
         {
            idb.AddParameter("@PCDN_PCCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCCode", pCD_NRecord.PCDN_PCCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCNo))
         {
            idb.AddParameter("@PCDN_PCNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCNo", pCD_NRecord.PCDN_PCNo);
         }
         if (pCD_NRecord.PCDN_DDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_DDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_DDate", pCD_NRecord.PCDN_DDate);
         }
         if (pCD_NRecord.PCDN_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_RDate", pCD_NRecord.PCDN_RDate);
         }
         if (pCD_NRecord.PCDN_JBegin == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_JBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_JBegin", pCD_NRecord.PCDN_JBegin);
         }
         if (pCD_NRecord.PCDN_JEnd == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_JEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_JEnd", pCD_NRecord.PCDN_JEnd);
         }
         if (pCD_NRecord.PCDN_LDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_LDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_LDate", pCD_NRecord.PCDN_LDate);
         }
         if (pCD_NRecord.PCDN_BDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_BDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_BDate", pCD_NRecord.PCDN_BDate);
         }
         if (pCD_NRecord.PCDN_PPNum == 0)
         {
            idb.AddParameter("@PCDN_PPNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PPNum", pCD_NRecord.PCDN_PPNum);
         }
         if (pCD_NRecord.PCDN_TDNum == 0)
         {
            idb.AddParameter("@PCDN_TDNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TDNum", pCD_NRecord.PCDN_TDNum);
         }
         if (pCD_NRecord.PCDN_TTNum == 0)
         {
            idb.AddParameter("@PCDN_TTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TTNum", pCD_NRecord.PCDN_TTNum);
         }
         if (pCD_NRecord.PCDN_RTNum == 0)
         {
            idb.AddParameter("@PCDN_RTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_RTNum", pCD_NRecord.PCDN_RTNum);
         }
         if (pCD_NRecord.PCDN_CTNum == 0)
         {
            idb.AddParameter("@PCDN_CTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_CTNum", pCD_NRecord.PCDN_CTNum);
         }
         if (pCD_NRecord.PCDN_RRNum == 0)
         {
            idb.AddParameter("@PCDN_RRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_RRNum", pCD_NRecord.PCDN_RRNum);
         }
         if (pCD_NRecord.PCDN_MoreNum == 0)
         {
            idb.AddParameter("@PCDN_MoreNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_MoreNum", pCD_NRecord.PCDN_MoreNum);
         }
         if (pCD_NRecord.PCDN_PRNum == 0)
         {
            idb.AddParameter("@PCDN_PRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PRNum", pCD_NRecord.PCDN_PRNum);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_BStatus))
         {
            idb.AddParameter("@PCDN_BStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_BStatus", pCD_NRecord.PCDN_BStatus);
         }
         if (pCD_NRecord.PCDN_TRNum == 0)
         {
            idb.AddParameter("@PCDN_TRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TRNum", pCD_NRecord.PCDN_TRNum);
         }
         if (pCD_NRecord.PCDN_TBNum == 0)
         {
            idb.AddParameter("@PCDN_TBNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TBNum", pCD_NRecord.PCDN_TBNum);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TBBak))
         {
            idb.AddParameter("@PCDN_TBBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TBBak", pCD_NRecord.PCDN_TBBak);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Stat))
         {
            idb.AddParameter("@PCDN_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Stat", pCD_NRecord.PCDN_Stat);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_iType))
         {
            idb.AddParameter("@PCDN_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_iType", pCD_NRecord.PCDN_iType);
         }
         if (pCD_NRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_NRecord.Stat);
         }
         if (pCD_NRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_NRecord.CreateDate);
         }
         if (pCD_NRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_NRecord.UpdateDate);
         }
         if (pCD_NRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_NRecord.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_SourceCode))
         {
            idb.AddParameter("@PCDN_SourceCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_SourceCode", pCD_NRecord.PCDN_SourceCode);
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
      /// 添加发货记录 PCD_NRecord对象(即:一条记录)
      /// </summary>
      public object AddWithReturn(PCD_NRecord pCD_NRecord)
      {
         string sql = "INSERT INTO PCD_NRecord (PCDN_Code,PCDN_CCode,PCDN_PRCode,PCDN_PCode,PCDN_PDCode,PCDN_PSCode,PCDN_Part,PCDN_Slump,PCDN_Spec1,PCDN_Spec2,PCDN_TType,PCDN_TEqu,PCDN_SOwner,PCDN_SDate,PCDN_TBSta,PCDN_TBLine,PCDN_OOwner,PCDN_ODate,PCDN_ForeMan,PCDN_PPLimit,PCDN_DIType,PCDN_DINum,PCDN_PNum,PCDN_PCNum,PCDN_PTOrd,PCDN_PCDrv,PCDN_Comp,PCDN_PCCode,PCDN_PCNo,PCDN_DDate,PCDN_RDate,PCDN_JBegin,PCDN_JEnd,PCDN_LDate,PCDN_BDate,PCDN_PPNum,PCDN_TDNum,PCDN_TTNum,PCDN_RTNum,PCDN_CTNum,PCDN_RRNum,PCDN_MoreNum,PCDN_PRNum,PCDN_BStatus,PCDN_TRNum,PCDN_TBNum,PCDN_TBBak,PCDN_Stat,PCDN_iType,Stat,CreateDate,UpdateDate,DeleteDate,PCDN_SourceCode) VALUES (@PCDN_Code,@PCDN_CCode,@PCDN_PRCode,@PCDN_PCode,@PCDN_PDCode,@PCDN_PSCode,@PCDN_Part,@PCDN_Slump,@PCDN_Spec1,@PCDN_Spec2,@PCDN_TType,@PCDN_TEqu,@PCDN_SOwner,@PCDN_SDate,@PCDN_TBSta,@PCDN_TBLine,@PCDN_OOwner,@PCDN_ODate,@PCDN_ForeMan,@PCDN_PPLimit,@PCDN_DIType,@PCDN_DINum,@PCDN_PNum,@PCDN_PCNum,@PCDN_PTOrd,@PCDN_PCDrv,@PCDN_Comp,@PCDN_PCCode,@PCDN_PCNo,@PCDN_DDate,@PCDN_RDate,@PCDN_JBegin,@PCDN_JEnd,@PCDN_LDate,@PCDN_BDate,@PCDN_PPNum,@PCDN_TDNum,@PCDN_TTNum,@PCDN_RTNum,@PCDN_CTNum,@PCDN_RRNum,@PCDN_MoreNum,@PCDN_PRNum,@PCDN_BStatus,@PCDN_TRNum,@PCDN_TBNum,@PCDN_TBBak,@PCDN_Stat,@PCDN_iType,@Stat,@CreateDate,@UpdateDate,@DeleteDate,@PCDN_SourceCode);SELECT @@IDENTITY AS ReturnID;";
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Code))
         {
            idb.AddParameter("@PCDN_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Code", pCD_NRecord.PCDN_Code);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_CCode))
         {
            idb.AddParameter("@PCDN_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_CCode", pCD_NRecord.PCDN_CCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PRCode))
         {
            idb.AddParameter("@PCDN_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PRCode", pCD_NRecord.PCDN_PRCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCode))
         {
            idb.AddParameter("@PCDN_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCode", pCD_NRecord.PCDN_PCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PDCode))
         {
            idb.AddParameter("@PCDN_PDCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PDCode", pCD_NRecord.PCDN_PDCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PSCode))
         {
            idb.AddParameter("@PCDN_PSCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PSCode", pCD_NRecord.PCDN_PSCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Part))
         {
            idb.AddParameter("@PCDN_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Part", pCD_NRecord.PCDN_Part);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Slump))
         {
            idb.AddParameter("@PCDN_Slump", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Slump", pCD_NRecord.PCDN_Slump);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Spec1))
         {
            idb.AddParameter("@PCDN_Spec1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Spec1", pCD_NRecord.PCDN_Spec1);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Spec2))
         {
            idb.AddParameter("@PCDN_Spec2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Spec2", pCD_NRecord.PCDN_Spec2);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TType))
         {
            idb.AddParameter("@PCDN_TType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TType", pCD_NRecord.PCDN_TType);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TEqu))
         {
            idb.AddParameter("@PCDN_TEqu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TEqu", pCD_NRecord.PCDN_TEqu);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_SOwner))
         {
            idb.AddParameter("@PCDN_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_SOwner", pCD_NRecord.PCDN_SOwner);
         }
         if (pCD_NRecord.PCDN_SDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_SDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_SDate", pCD_NRecord.PCDN_SDate);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TBSta))
         {
            idb.AddParameter("@PCDN_TBSta", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TBSta", pCD_NRecord.PCDN_TBSta);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TBLine))
         {
            idb.AddParameter("@PCDN_TBLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TBLine", pCD_NRecord.PCDN_TBLine);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_OOwner))
         {
            idb.AddParameter("@PCDN_OOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_OOwner", pCD_NRecord.PCDN_OOwner);
         }
         if (pCD_NRecord.PCDN_ODate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_ODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_ODate", pCD_NRecord.PCDN_ODate);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_ForeMan))
         {
            idb.AddParameter("@PCDN_ForeMan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_ForeMan", pCD_NRecord.PCDN_ForeMan);
         }
         if (pCD_NRecord.PCDN_PPLimit == 0)
         {
            idb.AddParameter("@PCDN_PPLimit", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PPLimit", pCD_NRecord.PCDN_PPLimit);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_DIType))
         {
            idb.AddParameter("@PCDN_DIType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_DIType", pCD_NRecord.PCDN_DIType);
         }
         if (pCD_NRecord.PCDN_DINum == 0)
         {
            idb.AddParameter("@PCDN_DINum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_DINum", pCD_NRecord.PCDN_DINum);
         }
         if (pCD_NRecord.PCDN_PNum == 0)
         {
            idb.AddParameter("@PCDN_PNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PNum", pCD_NRecord.PCDN_PNum);
         }
         if (pCD_NRecord.PCDN_PCNum == 0)
         {
            idb.AddParameter("@PCDN_PCNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PCNum", pCD_NRecord.PCDN_PCNum);
         }
         if (pCD_NRecord.PCDN_PTOrd == 0)
         {
            idb.AddParameter("@PCDN_PTOrd", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PTOrd", pCD_NRecord.PCDN_PTOrd);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCDrv))
         {
            idb.AddParameter("@PCDN_PCDrv", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCDrv", pCD_NRecord.PCDN_PCDrv);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Comp))
         {
            idb.AddParameter("@PCDN_Comp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Comp", pCD_NRecord.PCDN_Comp);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCCode))
         {
            idb.AddParameter("@PCDN_PCCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCCode", pCD_NRecord.PCDN_PCCode);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCNo))
         {
            idb.AddParameter("@PCDN_PCNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCNo", pCD_NRecord.PCDN_PCNo);
         }
         if (pCD_NRecord.PCDN_DDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_DDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_DDate", pCD_NRecord.PCDN_DDate);
         }
         if (pCD_NRecord.PCDN_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_RDate", pCD_NRecord.PCDN_RDate);
         }
         if (pCD_NRecord.PCDN_JBegin == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_JBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_JBegin", pCD_NRecord.PCDN_JBegin);
         }
         if (pCD_NRecord.PCDN_JEnd == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_JEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_JEnd", pCD_NRecord.PCDN_JEnd);
         }
         if (pCD_NRecord.PCDN_LDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_LDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_LDate", pCD_NRecord.PCDN_LDate);
         }
         if (pCD_NRecord.PCDN_BDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_BDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_BDate", pCD_NRecord.PCDN_BDate);
         }
         if (pCD_NRecord.PCDN_PPNum == 0)
         {
            idb.AddParameter("@PCDN_PPNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PPNum", pCD_NRecord.PCDN_PPNum);
         }
         if (pCD_NRecord.PCDN_TDNum == 0)
         {
            idb.AddParameter("@PCDN_TDNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TDNum", pCD_NRecord.PCDN_TDNum);
         }
         if (pCD_NRecord.PCDN_TTNum == 0)
         {
            idb.AddParameter("@PCDN_TTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TTNum", pCD_NRecord.PCDN_TTNum);
         }
         if (pCD_NRecord.PCDN_RTNum == 0)
         {
            idb.AddParameter("@PCDN_RTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_RTNum", pCD_NRecord.PCDN_RTNum);
         }
         if (pCD_NRecord.PCDN_CTNum == 0)
         {
            idb.AddParameter("@PCDN_CTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_CTNum", pCD_NRecord.PCDN_CTNum);
         }
         if (pCD_NRecord.PCDN_RRNum == 0)
         {
            idb.AddParameter("@PCDN_RRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_RRNum", pCD_NRecord.PCDN_RRNum);
         }
         if (pCD_NRecord.PCDN_MoreNum == 0)
         {
            idb.AddParameter("@PCDN_MoreNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_MoreNum", pCD_NRecord.PCDN_MoreNum);
         }
         if (pCD_NRecord.PCDN_PRNum == 0)
         {
            idb.AddParameter("@PCDN_PRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PRNum", pCD_NRecord.PCDN_PRNum);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_BStatus))
         {
            idb.AddParameter("@PCDN_BStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_BStatus", pCD_NRecord.PCDN_BStatus);
         }
         if (pCD_NRecord.PCDN_TRNum == 0)
         {
            idb.AddParameter("@PCDN_TRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TRNum", pCD_NRecord.PCDN_TRNum);
         }
         if (pCD_NRecord.PCDN_TBNum == 0)
         {
            idb.AddParameter("@PCDN_TBNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TBNum", pCD_NRecord.PCDN_TBNum);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TBBak))
         {
            idb.AddParameter("@PCDN_TBBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TBBak", pCD_NRecord.PCDN_TBBak);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Stat))
         {
            idb.AddParameter("@PCDN_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Stat", pCD_NRecord.PCDN_Stat);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_iType))
         {
            idb.AddParameter("@PCDN_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_iType", pCD_NRecord.PCDN_iType);
         }
         if (pCD_NRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_NRecord.Stat);
         }
         if (pCD_NRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_NRecord.CreateDate);
         }
         if (pCD_NRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_NRecord.UpdateDate);
         }
         if (pCD_NRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_NRecord.DeleteDate);
         }
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_SourceCode))
         {
            idb.AddParameter("@PCDN_SourceCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_SourceCode", pCD_NRecord.PCDN_SourceCode);
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
      /// 更新发货记录 PCD_NRecord对象(即:一条记录
      /// </summary>
      public int Update(PCD_NRecord pCD_NRecord)
      {
         
         StringBuilder sbParameter=new StringBuilder();
      StringBuilder sb=new StringBuilder();
      sb.Append(@"UPDATE       PCD_NRecord       SET ");
            if(pCD_NRecord.PCDN_Code_IsChanged){sbParameter.Append("PCDN_Code=@PCDN_Code, ");}
      if(pCD_NRecord.PCDN_CCode_IsChanged){sbParameter.Append("PCDN_CCode=@PCDN_CCode, ");}
      if(pCD_NRecord.PCDN_PRCode_IsChanged){sbParameter.Append("PCDN_PRCode=@PCDN_PRCode, ");}
      if(pCD_NRecord.PCDN_PCode_IsChanged){sbParameter.Append("PCDN_PCode=@PCDN_PCode, ");}
      if(pCD_NRecord.PCDN_PDCode_IsChanged){sbParameter.Append("PCDN_PDCode=@PCDN_PDCode, ");}
      if(pCD_NRecord.PCDN_PSCode_IsChanged){sbParameter.Append("PCDN_PSCode=@PCDN_PSCode, ");}
      if(pCD_NRecord.PCDN_Part_IsChanged){sbParameter.Append("PCDN_Part=@PCDN_Part, ");}
      if(pCD_NRecord.PCDN_Slump_IsChanged){sbParameter.Append("PCDN_Slump=@PCDN_Slump, ");}
      if(pCD_NRecord.PCDN_Spec1_IsChanged){sbParameter.Append("PCDN_Spec1=@PCDN_Spec1, ");}
      if(pCD_NRecord.PCDN_Spec2_IsChanged){sbParameter.Append("PCDN_Spec2=@PCDN_Spec2, ");}
      if(pCD_NRecord.PCDN_TType_IsChanged){sbParameter.Append("PCDN_TType=@PCDN_TType, ");}
      if(pCD_NRecord.PCDN_TEqu_IsChanged){sbParameter.Append("PCDN_TEqu=@PCDN_TEqu, ");}
      if(pCD_NRecord.PCDN_SOwner_IsChanged){sbParameter.Append("PCDN_SOwner=@PCDN_SOwner, ");}
      if(pCD_NRecord.PCDN_SDate_IsChanged){sbParameter.Append("PCDN_SDate=@PCDN_SDate, ");}
      if(pCD_NRecord.PCDN_TBSta_IsChanged){sbParameter.Append("PCDN_TBSta=@PCDN_TBSta, ");}
      if(pCD_NRecord.PCDN_TBLine_IsChanged){sbParameter.Append("PCDN_TBLine=@PCDN_TBLine, ");}
      if(pCD_NRecord.PCDN_OOwner_IsChanged){sbParameter.Append("PCDN_OOwner=@PCDN_OOwner, ");}
      if(pCD_NRecord.PCDN_ODate_IsChanged){sbParameter.Append("PCDN_ODate=@PCDN_ODate, ");}
      if(pCD_NRecord.PCDN_ForeMan_IsChanged){sbParameter.Append("PCDN_ForeMan=@PCDN_ForeMan, ");}
      if(pCD_NRecord.PCDN_PPLimit_IsChanged){sbParameter.Append("PCDN_PPLimit=@PCDN_PPLimit, ");}
      if(pCD_NRecord.PCDN_DIType_IsChanged){sbParameter.Append("PCDN_DIType=@PCDN_DIType, ");}
      if(pCD_NRecord.PCDN_DINum_IsChanged){sbParameter.Append("PCDN_DINum=@PCDN_DINum, ");}
      if(pCD_NRecord.PCDN_PNum_IsChanged){sbParameter.Append("PCDN_PNum=@PCDN_PNum, ");}
      if(pCD_NRecord.PCDN_PCNum_IsChanged){sbParameter.Append("PCDN_PCNum=@PCDN_PCNum, ");}
      if(pCD_NRecord.PCDN_PTOrd_IsChanged){sbParameter.Append("PCDN_PTOrd=@PCDN_PTOrd, ");}
      if(pCD_NRecord.PCDN_PCDrv_IsChanged){sbParameter.Append("PCDN_PCDrv=@PCDN_PCDrv, ");}
      if(pCD_NRecord.PCDN_Comp_IsChanged){sbParameter.Append("PCDN_Comp=@PCDN_Comp, ");}
      if(pCD_NRecord.PCDN_PCCode_IsChanged){sbParameter.Append("PCDN_PCCode=@PCDN_PCCode, ");}
      if(pCD_NRecord.PCDN_PCNo_IsChanged){sbParameter.Append("PCDN_PCNo=@PCDN_PCNo, ");}
      if(pCD_NRecord.PCDN_DDate_IsChanged){sbParameter.Append("PCDN_DDate=@PCDN_DDate, ");}
      if(pCD_NRecord.PCDN_RDate_IsChanged){sbParameter.Append("PCDN_RDate=@PCDN_RDate, ");}
      if(pCD_NRecord.PCDN_JBegin_IsChanged){sbParameter.Append("PCDN_JBegin=@PCDN_JBegin, ");}
      if(pCD_NRecord.PCDN_JEnd_IsChanged){sbParameter.Append("PCDN_JEnd=@PCDN_JEnd, ");}
      if(pCD_NRecord.PCDN_LDate_IsChanged){sbParameter.Append("PCDN_LDate=@PCDN_LDate, ");}
      if(pCD_NRecord.PCDN_BDate_IsChanged){sbParameter.Append("PCDN_BDate=@PCDN_BDate, ");}
      if(pCD_NRecord.PCDN_PPNum_IsChanged){sbParameter.Append("PCDN_PPNum=@PCDN_PPNum, ");}
      if(pCD_NRecord.PCDN_TDNum_IsChanged){sbParameter.Append("PCDN_TDNum=@PCDN_TDNum, ");}
      if(pCD_NRecord.PCDN_TTNum_IsChanged){sbParameter.Append("PCDN_TTNum=@PCDN_TTNum, ");}
      if(pCD_NRecord.PCDN_RTNum_IsChanged){sbParameter.Append("PCDN_RTNum=@PCDN_RTNum, ");}
      if(pCD_NRecord.PCDN_CTNum_IsChanged){sbParameter.Append("PCDN_CTNum=@PCDN_CTNum, ");}
      if(pCD_NRecord.PCDN_RRNum_IsChanged){sbParameter.Append("PCDN_RRNum=@PCDN_RRNum, ");}
      if(pCD_NRecord.PCDN_MoreNum_IsChanged){sbParameter.Append("PCDN_MoreNum=@PCDN_MoreNum, ");}
      if(pCD_NRecord.PCDN_PRNum_IsChanged){sbParameter.Append("PCDN_PRNum=@PCDN_PRNum, ");}
      if(pCD_NRecord.PCDN_BStatus_IsChanged){sbParameter.Append("PCDN_BStatus=@PCDN_BStatus, ");}
      if(pCD_NRecord.PCDN_TRNum_IsChanged){sbParameter.Append("PCDN_TRNum=@PCDN_TRNum, ");}
      if(pCD_NRecord.PCDN_TBNum_IsChanged){sbParameter.Append("PCDN_TBNum=@PCDN_TBNum, ");}
      if(pCD_NRecord.PCDN_TBBak_IsChanged){sbParameter.Append("PCDN_TBBak=@PCDN_TBBak, ");}
      if(pCD_NRecord.PCDN_Stat_IsChanged){sbParameter.Append("PCDN_Stat=@PCDN_Stat, ");}
      if(pCD_NRecord.PCDN_iType_IsChanged){sbParameter.Append("PCDN_iType=@PCDN_iType, ");}
      if(pCD_NRecord.Stat_IsChanged){sbParameter.Append("Stat=@Stat, ");}
      if(pCD_NRecord.CreateDate_IsChanged){sbParameter.Append("CreateDate=@CreateDate, ");}
      if(pCD_NRecord.UpdateDate_IsChanged){sbParameter.Append("UpdateDate=@UpdateDate, ");}
      if(pCD_NRecord.DeleteDate_IsChanged){sbParameter.Append("DeleteDate=@DeleteDate, ");}
      if(pCD_NRecord.PCDN_SourceCode_IsChanged){sbParameter.Append("PCDN_SourceCode=@PCDN_SourceCode ");}          sb.Append(sbParameter.ToString().Trim().TrimEnd(',')); 
      sb.Append(      " WHERE 1=1 AND ((Stat is null) or (Stat=0))   and PCDN_ID=@PCDN_ID; " );
      string sql=sb.ToString();
         if(pCD_NRecord.PCDN_Code_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Code))
         {
            idb.AddParameter("@PCDN_Code", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Code", pCD_NRecord.PCDN_Code);
         }
          }
         if(pCD_NRecord.PCDN_CCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_CCode))
         {
            idb.AddParameter("@PCDN_CCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_CCode", pCD_NRecord.PCDN_CCode);
         }
          }
         if(pCD_NRecord.PCDN_PRCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PRCode))
         {
            idb.AddParameter("@PCDN_PRCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PRCode", pCD_NRecord.PCDN_PRCode);
         }
          }
         if(pCD_NRecord.PCDN_PCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCode))
         {
            idb.AddParameter("@PCDN_PCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCode", pCD_NRecord.PCDN_PCode);
         }
          }
         if(pCD_NRecord.PCDN_PDCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PDCode))
         {
            idb.AddParameter("@PCDN_PDCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PDCode", pCD_NRecord.PCDN_PDCode);
         }
          }
         if(pCD_NRecord.PCDN_PSCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PSCode))
         {
            idb.AddParameter("@PCDN_PSCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PSCode", pCD_NRecord.PCDN_PSCode);
         }
          }
         if(pCD_NRecord.PCDN_Part_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Part))
         {
            idb.AddParameter("@PCDN_Part", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Part", pCD_NRecord.PCDN_Part);
         }
          }
         if(pCD_NRecord.PCDN_Slump_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Slump))
         {
            idb.AddParameter("@PCDN_Slump", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Slump", pCD_NRecord.PCDN_Slump);
         }
          }
         if(pCD_NRecord.PCDN_Spec1_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Spec1))
         {
            idb.AddParameter("@PCDN_Spec1", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Spec1", pCD_NRecord.PCDN_Spec1);
         }
          }
         if(pCD_NRecord.PCDN_Spec2_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Spec2))
         {
            idb.AddParameter("@PCDN_Spec2", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Spec2", pCD_NRecord.PCDN_Spec2);
         }
          }
         if(pCD_NRecord.PCDN_TType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TType))
         {
            idb.AddParameter("@PCDN_TType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TType", pCD_NRecord.PCDN_TType);
         }
          }
         if(pCD_NRecord.PCDN_TEqu_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TEqu))
         {
            idb.AddParameter("@PCDN_TEqu", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TEqu", pCD_NRecord.PCDN_TEqu);
         }
          }
         if(pCD_NRecord.PCDN_SOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_SOwner))
         {
            idb.AddParameter("@PCDN_SOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_SOwner", pCD_NRecord.PCDN_SOwner);
         }
          }
         if(pCD_NRecord.PCDN_SDate_IsChanged)
         {
         if (pCD_NRecord.PCDN_SDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_SDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_SDate", pCD_NRecord.PCDN_SDate);
         }
          }
         if(pCD_NRecord.PCDN_TBSta_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TBSta))
         {
            idb.AddParameter("@PCDN_TBSta", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TBSta", pCD_NRecord.PCDN_TBSta);
         }
          }
         if(pCD_NRecord.PCDN_TBLine_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TBLine))
         {
            idb.AddParameter("@PCDN_TBLine", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TBLine", pCD_NRecord.PCDN_TBLine);
         }
          }
         if(pCD_NRecord.PCDN_OOwner_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_OOwner))
         {
            idb.AddParameter("@PCDN_OOwner", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_OOwner", pCD_NRecord.PCDN_OOwner);
         }
          }
         if(pCD_NRecord.PCDN_ODate_IsChanged)
         {
         if (pCD_NRecord.PCDN_ODate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_ODate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_ODate", pCD_NRecord.PCDN_ODate);
         }
          }
         if(pCD_NRecord.PCDN_ForeMan_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_ForeMan))
         {
            idb.AddParameter("@PCDN_ForeMan", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_ForeMan", pCD_NRecord.PCDN_ForeMan);
         }
          }
         if(pCD_NRecord.PCDN_PPLimit_IsChanged)
         {
         if (pCD_NRecord.PCDN_PPLimit == 0)
         {
            idb.AddParameter("@PCDN_PPLimit", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PPLimit", pCD_NRecord.PCDN_PPLimit);
         }
          }
         if(pCD_NRecord.PCDN_DIType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_DIType))
         {
            idb.AddParameter("@PCDN_DIType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_DIType", pCD_NRecord.PCDN_DIType);
         }
          }
         if(pCD_NRecord.PCDN_DINum_IsChanged)
         {
         if (pCD_NRecord.PCDN_DINum == 0)
         {
            idb.AddParameter("@PCDN_DINum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_DINum", pCD_NRecord.PCDN_DINum);
         }
          }
         if(pCD_NRecord.PCDN_PNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_PNum == 0)
         {
            idb.AddParameter("@PCDN_PNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PNum", pCD_NRecord.PCDN_PNum);
         }
          }
         if(pCD_NRecord.PCDN_PCNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_PCNum == 0)
         {
            idb.AddParameter("@PCDN_PCNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PCNum", pCD_NRecord.PCDN_PCNum);
         }
          }
         if(pCD_NRecord.PCDN_PTOrd_IsChanged)
         {
         if (pCD_NRecord.PCDN_PTOrd == 0)
         {
            idb.AddParameter("@PCDN_PTOrd", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PTOrd", pCD_NRecord.PCDN_PTOrd);
         }
          }
         if(pCD_NRecord.PCDN_PCDrv_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCDrv))
         {
            idb.AddParameter("@PCDN_PCDrv", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCDrv", pCD_NRecord.PCDN_PCDrv);
         }
          }
         if(pCD_NRecord.PCDN_Comp_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Comp))
         {
            idb.AddParameter("@PCDN_Comp", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Comp", pCD_NRecord.PCDN_Comp);
         }
          }
         if(pCD_NRecord.PCDN_PCCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCCode))
         {
            idb.AddParameter("@PCDN_PCCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCCode", pCD_NRecord.PCDN_PCCode);
         }
          }
         if(pCD_NRecord.PCDN_PCNo_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_PCNo))
         {
            idb.AddParameter("@PCDN_PCNo", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_PCNo", pCD_NRecord.PCDN_PCNo);
         }
          }
         if(pCD_NRecord.PCDN_DDate_IsChanged)
         {
         if (pCD_NRecord.PCDN_DDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_DDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_DDate", pCD_NRecord.PCDN_DDate);
         }
          }
         if(pCD_NRecord.PCDN_RDate_IsChanged)
         {
         if (pCD_NRecord.PCDN_RDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_RDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_RDate", pCD_NRecord.PCDN_RDate);
         }
          }
         if(pCD_NRecord.PCDN_JBegin_IsChanged)
         {
         if (pCD_NRecord.PCDN_JBegin == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_JBegin", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_JBegin", pCD_NRecord.PCDN_JBegin);
         }
          }
         if(pCD_NRecord.PCDN_JEnd_IsChanged)
         {
         if (pCD_NRecord.PCDN_JEnd == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_JEnd", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_JEnd", pCD_NRecord.PCDN_JEnd);
         }
          }
         if(pCD_NRecord.PCDN_LDate_IsChanged)
         {
         if (pCD_NRecord.PCDN_LDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_LDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_LDate", pCD_NRecord.PCDN_LDate);
         }
          }
         if(pCD_NRecord.PCDN_BDate_IsChanged)
         {
         if (pCD_NRecord.PCDN_BDate == DateTime.MinValue)
         {
            idb.AddParameter("@PCDN_BDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_BDate", pCD_NRecord.PCDN_BDate);
         }
          }
         if(pCD_NRecord.PCDN_PPNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_PPNum == 0)
         {
            idb.AddParameter("@PCDN_PPNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PPNum", pCD_NRecord.PCDN_PPNum);
         }
          }
         if(pCD_NRecord.PCDN_TDNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_TDNum == 0)
         {
            idb.AddParameter("@PCDN_TDNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TDNum", pCD_NRecord.PCDN_TDNum);
         }
          }
         if(pCD_NRecord.PCDN_TTNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_TTNum == 0)
         {
            idb.AddParameter("@PCDN_TTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TTNum", pCD_NRecord.PCDN_TTNum);
         }
          }
         if(pCD_NRecord.PCDN_RTNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_RTNum == 0)
         {
            idb.AddParameter("@PCDN_RTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_RTNum", pCD_NRecord.PCDN_RTNum);
         }
          }
         if(pCD_NRecord.PCDN_CTNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_CTNum == 0)
         {
            idb.AddParameter("@PCDN_CTNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_CTNum", pCD_NRecord.PCDN_CTNum);
         }
          }
         if(pCD_NRecord.PCDN_RRNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_RRNum == 0)
         {
            idb.AddParameter("@PCDN_RRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_RRNum", pCD_NRecord.PCDN_RRNum);
         }
          }
         if(pCD_NRecord.PCDN_MoreNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_MoreNum == 0)
         {
            idb.AddParameter("@PCDN_MoreNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_MoreNum", pCD_NRecord.PCDN_MoreNum);
         }
          }
         if(pCD_NRecord.PCDN_PRNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_PRNum == 0)
         {
            idb.AddParameter("@PCDN_PRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_PRNum", pCD_NRecord.PCDN_PRNum);
         }
          }
         if(pCD_NRecord.PCDN_BStatus_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_BStatus))
         {
            idb.AddParameter("@PCDN_BStatus", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_BStatus", pCD_NRecord.PCDN_BStatus);
         }
          }
         if(pCD_NRecord.PCDN_TRNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_TRNum == 0)
         {
            idb.AddParameter("@PCDN_TRNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TRNum", pCD_NRecord.PCDN_TRNum);
         }
          }
         if(pCD_NRecord.PCDN_TBNum_IsChanged)
         {
         if (pCD_NRecord.PCDN_TBNum == 0)
         {
            idb.AddParameter("@PCDN_TBNum", 0);
         }
         else
         {
            idb.AddParameter("@PCDN_TBNum", pCD_NRecord.PCDN_TBNum);
         }
          }
         if(pCD_NRecord.PCDN_TBBak_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_TBBak))
         {
            idb.AddParameter("@PCDN_TBBak", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_TBBak", pCD_NRecord.PCDN_TBBak);
         }
          }
         if(pCD_NRecord.PCDN_Stat_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_Stat))
         {
            idb.AddParameter("@PCDN_Stat", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_Stat", pCD_NRecord.PCDN_Stat);
         }
          }
         if(pCD_NRecord.PCDN_iType_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_iType))
         {
            idb.AddParameter("@PCDN_iType", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_iType", pCD_NRecord.PCDN_iType);
         }
          }
         if(pCD_NRecord.Stat_IsChanged)
         {
         if (pCD_NRecord.Stat == 0)
         {
            idb.AddParameter("@Stat", 0);
         }
         else
         {
            idb.AddParameter("@Stat", pCD_NRecord.Stat);
         }
          }
         if(pCD_NRecord.CreateDate_IsChanged)
         {
         if (pCD_NRecord.CreateDate == DateTime.MinValue)
         {
            idb.AddParameter("@CreateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@CreateDate", pCD_NRecord.CreateDate);
         }
          }
         if(pCD_NRecord.UpdateDate_IsChanged)
         {
         if (pCD_NRecord.UpdateDate == DateTime.MinValue)
         {
            idb.AddParameter("@UpdateDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@UpdateDate", pCD_NRecord.UpdateDate);
         }
          }
         if(pCD_NRecord.DeleteDate_IsChanged)
         {
         if (pCD_NRecord.DeleteDate == DateTime.MinValue)
         {
            idb.AddParameter("@DeleteDate", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@DeleteDate", pCD_NRecord.DeleteDate);
         }
          }
         if(pCD_NRecord.PCDN_SourceCode_IsChanged)
         {
         if (string.IsNullOrEmpty(pCD_NRecord.PCDN_SourceCode))
         {
            idb.AddParameter("@PCDN_SourceCode", DBNull.Value);
         }
         else
         {
            idb.AddParameter("@PCDN_SourceCode", pCD_NRecord.PCDN_SourceCode);
         }
          }

         idb.AddParameter("@PCDN_ID", pCD_NRecord.PCDN_ID);

           
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
      /// 删除发货记录 PCD_NRecord对象(即:一条记录
      /// </summary>
      public int Delete(decimal pCDN_ID)
      {
         string sql = "DELETE PCD_NRecord WHERE 1=1  AND PCDN_ID=@PCDN_ID ";
         idb.AddParameter("@PCDN_ID", pCDN_ID);

           
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
      /// 获取指定的发货记录 PCD_NRecord对象(即:一条记录
      /// </summary>
      public PCD_NRecord GetByKey(decimal pCDN_ID)
      {
         PCD_NRecord pCD_NRecord = new PCD_NRecord();
         string sql = "SELECT  PCDN_ID,PCDN_Code,PCDN_CCode,PCDN_PRCode,PCDN_PCode,PCDN_PDCode,PCDN_PSCode,PCDN_Part,PCDN_Slump,PCDN_Spec1,PCDN_Spec2,PCDN_TType,PCDN_TEqu,PCDN_SOwner,PCDN_SDate,PCDN_TBSta,PCDN_TBLine,PCDN_OOwner,PCDN_ODate,PCDN_ForeMan,PCDN_PPLimit,PCDN_DIType,PCDN_DINum,PCDN_PNum,PCDN_PCNum,PCDN_PTOrd,PCDN_PCDrv,PCDN_Comp,PCDN_PCCode,PCDN_PCNo,PCDN_DDate,PCDN_RDate,PCDN_JBegin,PCDN_JEnd,PCDN_LDate,PCDN_BDate,PCDN_PPNum,PCDN_TDNum,PCDN_TTNum,PCDN_RTNum,PCDN_CTNum,PCDN_RRNum,PCDN_MoreNum,PCDN_PRNum,PCDN_BStatus,PCDN_TRNum,PCDN_TBNum,PCDN_TBBak,PCDN_Stat,PCDN_iType,Stat,CreateDate,UpdateDate,DeleteDate,PCDN_SourceCode FROM PCD_NRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) )  AND PCDN_ID=@PCDN_ID ";
         idb.AddParameter("@PCDN_ID", pCDN_ID);

          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            if (dr["PCDN_ID"] != DBNull.Value) pCD_NRecord.PCDN_ID = Convert.ToDecimal(dr["PCDN_ID"]);
            if (dr["PCDN_Code"] != DBNull.Value) pCD_NRecord.PCDN_Code = Convert.ToString(dr["PCDN_Code"]);
            if (dr["PCDN_CCode"] != DBNull.Value) pCD_NRecord.PCDN_CCode = Convert.ToString(dr["PCDN_CCode"]);
            if (dr["PCDN_PRCode"] != DBNull.Value) pCD_NRecord.PCDN_PRCode = Convert.ToString(dr["PCDN_PRCode"]);
            if (dr["PCDN_PCode"] != DBNull.Value) pCD_NRecord.PCDN_PCode = Convert.ToString(dr["PCDN_PCode"]);
            if (dr["PCDN_PDCode"] != DBNull.Value) pCD_NRecord.PCDN_PDCode = Convert.ToString(dr["PCDN_PDCode"]);
            if (dr["PCDN_PSCode"] != DBNull.Value) pCD_NRecord.PCDN_PSCode = Convert.ToString(dr["PCDN_PSCode"]);
            if (dr["PCDN_Part"] != DBNull.Value) pCD_NRecord.PCDN_Part = Convert.ToString(dr["PCDN_Part"]);
            if (dr["PCDN_Slump"] != DBNull.Value) pCD_NRecord.PCDN_Slump = Convert.ToString(dr["PCDN_Slump"]);
            if (dr["PCDN_Spec1"] != DBNull.Value) pCD_NRecord.PCDN_Spec1 = Convert.ToString(dr["PCDN_Spec1"]);
            if (dr["PCDN_Spec2"] != DBNull.Value) pCD_NRecord.PCDN_Spec2 = Convert.ToString(dr["PCDN_Spec2"]);
            if (dr["PCDN_TType"] != DBNull.Value) pCD_NRecord.PCDN_TType = Convert.ToString(dr["PCDN_TType"]);
            if (dr["PCDN_TEqu"] != DBNull.Value) pCD_NRecord.PCDN_TEqu = Convert.ToString(dr["PCDN_TEqu"]);
            if (dr["PCDN_SOwner"] != DBNull.Value) pCD_NRecord.PCDN_SOwner = Convert.ToString(dr["PCDN_SOwner"]);
            if (dr["PCDN_SDate"] != DBNull.Value) pCD_NRecord.PCDN_SDate = Convert.ToDateTime(dr["PCDN_SDate"]);
            if (dr["PCDN_TBSta"] != DBNull.Value) pCD_NRecord.PCDN_TBSta = Convert.ToString(dr["PCDN_TBSta"]);
            if (dr["PCDN_TBLine"] != DBNull.Value) pCD_NRecord.PCDN_TBLine = Convert.ToString(dr["PCDN_TBLine"]);
            if (dr["PCDN_OOwner"] != DBNull.Value) pCD_NRecord.PCDN_OOwner = Convert.ToString(dr["PCDN_OOwner"]);
            if (dr["PCDN_ODate"] != DBNull.Value) pCD_NRecord.PCDN_ODate = Convert.ToDateTime(dr["PCDN_ODate"]);
            if (dr["PCDN_ForeMan"] != DBNull.Value) pCD_NRecord.PCDN_ForeMan = Convert.ToString(dr["PCDN_ForeMan"]);
            if (dr["PCDN_PPLimit"] != DBNull.Value) pCD_NRecord.PCDN_PPLimit = Convert.ToDecimal(dr["PCDN_PPLimit"]);
            if (dr["PCDN_DIType"] != DBNull.Value) pCD_NRecord.PCDN_DIType = Convert.ToString(dr["PCDN_DIType"]);
            if (dr["PCDN_DINum"] != DBNull.Value) pCD_NRecord.PCDN_DINum = Convert.ToDecimal(dr["PCDN_DINum"]);
            if (dr["PCDN_PNum"] != DBNull.Value) pCD_NRecord.PCDN_PNum = Convert.ToDecimal(dr["PCDN_PNum"]);
            if (dr["PCDN_PCNum"] != DBNull.Value) pCD_NRecord.PCDN_PCNum = Convert.ToDecimal(dr["PCDN_PCNum"]);
            if (dr["PCDN_PTOrd"] != DBNull.Value) pCD_NRecord.PCDN_PTOrd = Convert.ToInt32(dr["PCDN_PTOrd"]);
            if (dr["PCDN_PCDrv"] != DBNull.Value) pCD_NRecord.PCDN_PCDrv = Convert.ToString(dr["PCDN_PCDrv"]);
            if (dr["PCDN_Comp"] != DBNull.Value) pCD_NRecord.PCDN_Comp = Convert.ToString(dr["PCDN_Comp"]);
            if (dr["PCDN_PCCode"] != DBNull.Value) pCD_NRecord.PCDN_PCCode = Convert.ToString(dr["PCDN_PCCode"]);
            if (dr["PCDN_PCNo"] != DBNull.Value) pCD_NRecord.PCDN_PCNo = Convert.ToString(dr["PCDN_PCNo"]);
            if (dr["PCDN_DDate"] != DBNull.Value) pCD_NRecord.PCDN_DDate = Convert.ToDateTime(dr["PCDN_DDate"]);
            if (dr["PCDN_RDate"] != DBNull.Value) pCD_NRecord.PCDN_RDate = Convert.ToDateTime(dr["PCDN_RDate"]);
            if (dr["PCDN_JBegin"] != DBNull.Value) pCD_NRecord.PCDN_JBegin = Convert.ToDateTime(dr["PCDN_JBegin"]);
            if (dr["PCDN_JEnd"] != DBNull.Value) pCD_NRecord.PCDN_JEnd = Convert.ToDateTime(dr["PCDN_JEnd"]);
            if (dr["PCDN_LDate"] != DBNull.Value) pCD_NRecord.PCDN_LDate = Convert.ToDateTime(dr["PCDN_LDate"]);
            if (dr["PCDN_BDate"] != DBNull.Value) pCD_NRecord.PCDN_BDate = Convert.ToDateTime(dr["PCDN_BDate"]);
            if (dr["PCDN_PPNum"] != DBNull.Value) pCD_NRecord.PCDN_PPNum = Convert.ToDecimal(dr["PCDN_PPNum"]);
            if (dr["PCDN_TDNum"] != DBNull.Value) pCD_NRecord.PCDN_TDNum = Convert.ToDecimal(dr["PCDN_TDNum"]);
            if (dr["PCDN_TTNum"] != DBNull.Value) pCD_NRecord.PCDN_TTNum = Convert.ToInt32(dr["PCDN_TTNum"]);
            if (dr["PCDN_RTNum"] != DBNull.Value) pCD_NRecord.PCDN_RTNum = Convert.ToDecimal(dr["PCDN_RTNum"]);
            if (dr["PCDN_CTNum"] != DBNull.Value) pCD_NRecord.PCDN_CTNum = Convert.ToDecimal(dr["PCDN_CTNum"]);
            if (dr["PCDN_RRNum"] != DBNull.Value) pCD_NRecord.PCDN_RRNum = Convert.ToDecimal(dr["PCDN_RRNum"]);
            if (dr["PCDN_MoreNum"] != DBNull.Value) pCD_NRecord.PCDN_MoreNum = Convert.ToDecimal(dr["PCDN_MoreNum"]);
            if (dr["PCDN_PRNum"] != DBNull.Value) pCD_NRecord.PCDN_PRNum = Convert.ToDecimal(dr["PCDN_PRNum"]);
            if (dr["PCDN_BStatus"] != DBNull.Value) pCD_NRecord.PCDN_BStatus = Convert.ToString(dr["PCDN_BStatus"]);
            if (dr["PCDN_TRNum"] != DBNull.Value) pCD_NRecord.PCDN_TRNum = Convert.ToDecimal(dr["PCDN_TRNum"]);
            if (dr["PCDN_TBNum"] != DBNull.Value) pCD_NRecord.PCDN_TBNum = Convert.ToDecimal(dr["PCDN_TBNum"]);
            if (dr["PCDN_TBBak"] != DBNull.Value) pCD_NRecord.PCDN_TBBak = Convert.ToString(dr["PCDN_TBBak"]);
            if (dr["PCDN_Stat"] != DBNull.Value) pCD_NRecord.PCDN_Stat = Convert.ToString(dr["PCDN_Stat"]);
            if (dr["PCDN_iType"] != DBNull.Value) pCD_NRecord.PCDN_iType = Convert.ToString(dr["PCDN_iType"]);
            if (dr["Stat"] != DBNull.Value) pCD_NRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_NRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_NRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_NRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCDN_SourceCode"] != DBNull.Value) pCD_NRecord.PCDN_SourceCode = Convert.ToString(dr["PCDN_SourceCode"]);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return pCD_NRecord;
      }
      /// <summary>
      /// 获取指定的发货记录 PCD_NRecord对象集合
      /// </summary>
      public List<PCD_NRecord> GetListByWhere(string strCondition)
      {
         List<PCD_NRecord> ret = new List<PCD_NRecord>();
         string sql = "SELECT  PCDN_ID,PCDN_Code,PCDN_CCode,PCDN_PRCode,PCDN_PCode,PCDN_PDCode,PCDN_PSCode,PCDN_Part,PCDN_Slump,PCDN_Spec1,PCDN_Spec2,PCDN_TType,PCDN_TEqu,PCDN_SOwner,PCDN_SDate,PCDN_TBSta,PCDN_TBLine,PCDN_OOwner,PCDN_ODate,PCDN_ForeMan,PCDN_PPLimit,PCDN_DIType,PCDN_DINum,PCDN_PNum,PCDN_PCNum,PCDN_PTOrd,PCDN_PCDrv,PCDN_Comp,PCDN_PCCode,PCDN_PCNo,PCDN_DDate,PCDN_RDate,PCDN_JBegin,PCDN_JEnd,PCDN_LDate,PCDN_BDate,PCDN_PPNum,PCDN_TDNum,PCDN_TTNum,PCDN_RTNum,PCDN_CTNum,PCDN_RRNum,PCDN_MoreNum,PCDN_PRNum,PCDN_BStatus,PCDN_TRNum,PCDN_TBNum,PCDN_TBBak,PCDN_Stat,PCDN_iType,Stat,CreateDate,UpdateDate,DeleteDate,PCDN_SourceCode FROM PCD_NRecord WHERE 1=1 AND ((Stat is null) or (Stat=0) ) ";
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
            PCD_NRecord pCD_NRecord = new PCD_NRecord();
            if (dr["PCDN_ID"] != DBNull.Value) pCD_NRecord.PCDN_ID = Convert.ToDecimal(dr["PCDN_ID"]);
            if (dr["PCDN_Code"] != DBNull.Value) pCD_NRecord.PCDN_Code = Convert.ToString(dr["PCDN_Code"]);
            if (dr["PCDN_CCode"] != DBNull.Value) pCD_NRecord.PCDN_CCode = Convert.ToString(dr["PCDN_CCode"]);
            if (dr["PCDN_PRCode"] != DBNull.Value) pCD_NRecord.PCDN_PRCode = Convert.ToString(dr["PCDN_PRCode"]);
            if (dr["PCDN_PCode"] != DBNull.Value) pCD_NRecord.PCDN_PCode = Convert.ToString(dr["PCDN_PCode"]);
            if (dr["PCDN_PDCode"] != DBNull.Value) pCD_NRecord.PCDN_PDCode = Convert.ToString(dr["PCDN_PDCode"]);
            if (dr["PCDN_PSCode"] != DBNull.Value) pCD_NRecord.PCDN_PSCode = Convert.ToString(dr["PCDN_PSCode"]);
            if (dr["PCDN_Part"] != DBNull.Value) pCD_NRecord.PCDN_Part = Convert.ToString(dr["PCDN_Part"]);
            if (dr["PCDN_Slump"] != DBNull.Value) pCD_NRecord.PCDN_Slump = Convert.ToString(dr["PCDN_Slump"]);
            if (dr["PCDN_Spec1"] != DBNull.Value) pCD_NRecord.PCDN_Spec1 = Convert.ToString(dr["PCDN_Spec1"]);
            if (dr["PCDN_Spec2"] != DBNull.Value) pCD_NRecord.PCDN_Spec2 = Convert.ToString(dr["PCDN_Spec2"]);
            if (dr["PCDN_TType"] != DBNull.Value) pCD_NRecord.PCDN_TType = Convert.ToString(dr["PCDN_TType"]);
            if (dr["PCDN_TEqu"] != DBNull.Value) pCD_NRecord.PCDN_TEqu = Convert.ToString(dr["PCDN_TEqu"]);
            if (dr["PCDN_SOwner"] != DBNull.Value) pCD_NRecord.PCDN_SOwner = Convert.ToString(dr["PCDN_SOwner"]);
            if (dr["PCDN_SDate"] != DBNull.Value) pCD_NRecord.PCDN_SDate = Convert.ToDateTime(dr["PCDN_SDate"]);
            if (dr["PCDN_TBSta"] != DBNull.Value) pCD_NRecord.PCDN_TBSta = Convert.ToString(dr["PCDN_TBSta"]);
            if (dr["PCDN_TBLine"] != DBNull.Value) pCD_NRecord.PCDN_TBLine = Convert.ToString(dr["PCDN_TBLine"]);
            if (dr["PCDN_OOwner"] != DBNull.Value) pCD_NRecord.PCDN_OOwner = Convert.ToString(dr["PCDN_OOwner"]);
            if (dr["PCDN_ODate"] != DBNull.Value) pCD_NRecord.PCDN_ODate = Convert.ToDateTime(dr["PCDN_ODate"]);
            if (dr["PCDN_ForeMan"] != DBNull.Value) pCD_NRecord.PCDN_ForeMan = Convert.ToString(dr["PCDN_ForeMan"]);
            if (dr["PCDN_PPLimit"] != DBNull.Value) pCD_NRecord.PCDN_PPLimit = Convert.ToDecimal(dr["PCDN_PPLimit"]);
            if (dr["PCDN_DIType"] != DBNull.Value) pCD_NRecord.PCDN_DIType = Convert.ToString(dr["PCDN_DIType"]);
            if (dr["PCDN_DINum"] != DBNull.Value) pCD_NRecord.PCDN_DINum = Convert.ToDecimal(dr["PCDN_DINum"]);
            if (dr["PCDN_PNum"] != DBNull.Value) pCD_NRecord.PCDN_PNum = Convert.ToDecimal(dr["PCDN_PNum"]);
            if (dr["PCDN_PCNum"] != DBNull.Value) pCD_NRecord.PCDN_PCNum = Convert.ToDecimal(dr["PCDN_PCNum"]);
            if (dr["PCDN_PTOrd"] != DBNull.Value) pCD_NRecord.PCDN_PTOrd = Convert.ToInt32(dr["PCDN_PTOrd"]);
            if (dr["PCDN_PCDrv"] != DBNull.Value) pCD_NRecord.PCDN_PCDrv = Convert.ToString(dr["PCDN_PCDrv"]);
            if (dr["PCDN_Comp"] != DBNull.Value) pCD_NRecord.PCDN_Comp = Convert.ToString(dr["PCDN_Comp"]);
            if (dr["PCDN_PCCode"] != DBNull.Value) pCD_NRecord.PCDN_PCCode = Convert.ToString(dr["PCDN_PCCode"]);
            if (dr["PCDN_PCNo"] != DBNull.Value) pCD_NRecord.PCDN_PCNo = Convert.ToString(dr["PCDN_PCNo"]);
            if (dr["PCDN_DDate"] != DBNull.Value) pCD_NRecord.PCDN_DDate = Convert.ToDateTime(dr["PCDN_DDate"]);
            if (dr["PCDN_RDate"] != DBNull.Value) pCD_NRecord.PCDN_RDate = Convert.ToDateTime(dr["PCDN_RDate"]);
            if (dr["PCDN_JBegin"] != DBNull.Value) pCD_NRecord.PCDN_JBegin = Convert.ToDateTime(dr["PCDN_JBegin"]);
            if (dr["PCDN_JEnd"] != DBNull.Value) pCD_NRecord.PCDN_JEnd = Convert.ToDateTime(dr["PCDN_JEnd"]);
            if (dr["PCDN_LDate"] != DBNull.Value) pCD_NRecord.PCDN_LDate = Convert.ToDateTime(dr["PCDN_LDate"]);
            if (dr["PCDN_BDate"] != DBNull.Value) pCD_NRecord.PCDN_BDate = Convert.ToDateTime(dr["PCDN_BDate"]);
            if (dr["PCDN_PPNum"] != DBNull.Value) pCD_NRecord.PCDN_PPNum = Convert.ToDecimal(dr["PCDN_PPNum"]);
            if (dr["PCDN_TDNum"] != DBNull.Value) pCD_NRecord.PCDN_TDNum = Convert.ToDecimal(dr["PCDN_TDNum"]);
            if (dr["PCDN_TTNum"] != DBNull.Value) pCD_NRecord.PCDN_TTNum = Convert.ToInt32(dr["PCDN_TTNum"]);
            if (dr["PCDN_RTNum"] != DBNull.Value) pCD_NRecord.PCDN_RTNum = Convert.ToDecimal(dr["PCDN_RTNum"]);
            if (dr["PCDN_CTNum"] != DBNull.Value) pCD_NRecord.PCDN_CTNum = Convert.ToDecimal(dr["PCDN_CTNum"]);
            if (dr["PCDN_RRNum"] != DBNull.Value) pCD_NRecord.PCDN_RRNum = Convert.ToDecimal(dr["PCDN_RRNum"]);
            if (dr["PCDN_MoreNum"] != DBNull.Value) pCD_NRecord.PCDN_MoreNum = Convert.ToDecimal(dr["PCDN_MoreNum"]);
            if (dr["PCDN_PRNum"] != DBNull.Value) pCD_NRecord.PCDN_PRNum = Convert.ToDecimal(dr["PCDN_PRNum"]);
            if (dr["PCDN_BStatus"] != DBNull.Value) pCD_NRecord.PCDN_BStatus = Convert.ToString(dr["PCDN_BStatus"]);
            if (dr["PCDN_TRNum"] != DBNull.Value) pCD_NRecord.PCDN_TRNum = Convert.ToDecimal(dr["PCDN_TRNum"]);
            if (dr["PCDN_TBNum"] != DBNull.Value) pCD_NRecord.PCDN_TBNum = Convert.ToDecimal(dr["PCDN_TBNum"]);
            if (dr["PCDN_TBBak"] != DBNull.Value) pCD_NRecord.PCDN_TBBak = Convert.ToString(dr["PCDN_TBBak"]);
            if (dr["PCDN_Stat"] != DBNull.Value) pCD_NRecord.PCDN_Stat = Convert.ToString(dr["PCDN_Stat"]);
            if (dr["PCDN_iType"] != DBNull.Value) pCD_NRecord.PCDN_iType = Convert.ToString(dr["PCDN_iType"]);
            if (dr["Stat"] != DBNull.Value) pCD_NRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_NRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_NRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_NRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCDN_SourceCode"] != DBNull.Value) pCD_NRecord.PCDN_SourceCode = Convert.ToString(dr["PCDN_SourceCode"]);
            ret.Add(pCD_NRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally { if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   }  
         return ret;
      }
      /// <summary>
      /// 获取所有的发货记录 PCD_NRecord对象(即:一条记录
      /// </summary>
      public List<PCD_NRecord> GetAll()
      {
         List<PCD_NRecord> ret = new List<PCD_NRecord>();
         string sql = "SELECT  PCDN_ID,PCDN_Code,PCDN_CCode,PCDN_PRCode,PCDN_PCode,PCDN_PDCode,PCDN_PSCode,PCDN_Part,PCDN_Slump,PCDN_Spec1,PCDN_Spec2,PCDN_TType,PCDN_TEqu,PCDN_SOwner,PCDN_SDate,PCDN_TBSta,PCDN_TBLine,PCDN_OOwner,PCDN_ODate,PCDN_ForeMan,PCDN_PPLimit,PCDN_DIType,PCDN_DINum,PCDN_PNum,PCDN_PCNum,PCDN_PTOrd,PCDN_PCDrv,PCDN_Comp,PCDN_PCCode,PCDN_PCNo,PCDN_DDate,PCDN_RDate,PCDN_JBegin,PCDN_JEnd,PCDN_LDate,PCDN_BDate,PCDN_PPNum,PCDN_TDNum,PCDN_TTNum,PCDN_RTNum,PCDN_CTNum,PCDN_RRNum,PCDN_MoreNum,PCDN_PRNum,PCDN_BStatus,PCDN_TRNum,PCDN_TBNum,PCDN_TBBak,PCDN_Stat,PCDN_iType,Stat,CreateDate,UpdateDate,DeleteDate,PCDN_SourceCode FROM PCD_NRecord where 1=1 AND ((Stat is null) or (Stat=0) ) order by PCDN_ID desc ";
          SqlDataReader dr=null;  
           try {  
          dr=(SqlDataReader)idb.ReturnReader(sql);
         while(dr.Read())
         {
            PCD_NRecord pCD_NRecord = new PCD_NRecord();
            if (dr["PCDN_ID"] != DBNull.Value) pCD_NRecord.PCDN_ID = Convert.ToDecimal(dr["PCDN_ID"]);
            if (dr["PCDN_Code"] != DBNull.Value) pCD_NRecord.PCDN_Code = Convert.ToString(dr["PCDN_Code"]);
            if (dr["PCDN_CCode"] != DBNull.Value) pCD_NRecord.PCDN_CCode = Convert.ToString(dr["PCDN_CCode"]);
            if (dr["PCDN_PRCode"] != DBNull.Value) pCD_NRecord.PCDN_PRCode = Convert.ToString(dr["PCDN_PRCode"]);
            if (dr["PCDN_PCode"] != DBNull.Value) pCD_NRecord.PCDN_PCode = Convert.ToString(dr["PCDN_PCode"]);
            if (dr["PCDN_PDCode"] != DBNull.Value) pCD_NRecord.PCDN_PDCode = Convert.ToString(dr["PCDN_PDCode"]);
            if (dr["PCDN_PSCode"] != DBNull.Value) pCD_NRecord.PCDN_PSCode = Convert.ToString(dr["PCDN_PSCode"]);
            if (dr["PCDN_Part"] != DBNull.Value) pCD_NRecord.PCDN_Part = Convert.ToString(dr["PCDN_Part"]);
            if (dr["PCDN_Slump"] != DBNull.Value) pCD_NRecord.PCDN_Slump = Convert.ToString(dr["PCDN_Slump"]);
            if (dr["PCDN_Spec1"] != DBNull.Value) pCD_NRecord.PCDN_Spec1 = Convert.ToString(dr["PCDN_Spec1"]);
            if (dr["PCDN_Spec2"] != DBNull.Value) pCD_NRecord.PCDN_Spec2 = Convert.ToString(dr["PCDN_Spec2"]);
            if (dr["PCDN_TType"] != DBNull.Value) pCD_NRecord.PCDN_TType = Convert.ToString(dr["PCDN_TType"]);
            if (dr["PCDN_TEqu"] != DBNull.Value) pCD_NRecord.PCDN_TEqu = Convert.ToString(dr["PCDN_TEqu"]);
            if (dr["PCDN_SOwner"] != DBNull.Value) pCD_NRecord.PCDN_SOwner = Convert.ToString(dr["PCDN_SOwner"]);
            if (dr["PCDN_SDate"] != DBNull.Value) pCD_NRecord.PCDN_SDate = Convert.ToDateTime(dr["PCDN_SDate"]);
            if (dr["PCDN_TBSta"] != DBNull.Value) pCD_NRecord.PCDN_TBSta = Convert.ToString(dr["PCDN_TBSta"]);
            if (dr["PCDN_TBLine"] != DBNull.Value) pCD_NRecord.PCDN_TBLine = Convert.ToString(dr["PCDN_TBLine"]);
            if (dr["PCDN_OOwner"] != DBNull.Value) pCD_NRecord.PCDN_OOwner = Convert.ToString(dr["PCDN_OOwner"]);
            if (dr["PCDN_ODate"] != DBNull.Value) pCD_NRecord.PCDN_ODate = Convert.ToDateTime(dr["PCDN_ODate"]);
            if (dr["PCDN_ForeMan"] != DBNull.Value) pCD_NRecord.PCDN_ForeMan = Convert.ToString(dr["PCDN_ForeMan"]);
            if (dr["PCDN_PPLimit"] != DBNull.Value) pCD_NRecord.PCDN_PPLimit = Convert.ToDecimal(dr["PCDN_PPLimit"]);
            if (dr["PCDN_DIType"] != DBNull.Value) pCD_NRecord.PCDN_DIType = Convert.ToString(dr["PCDN_DIType"]);
            if (dr["PCDN_DINum"] != DBNull.Value) pCD_NRecord.PCDN_DINum = Convert.ToDecimal(dr["PCDN_DINum"]);
            if (dr["PCDN_PNum"] != DBNull.Value) pCD_NRecord.PCDN_PNum = Convert.ToDecimal(dr["PCDN_PNum"]);
            if (dr["PCDN_PCNum"] != DBNull.Value) pCD_NRecord.PCDN_PCNum = Convert.ToDecimal(dr["PCDN_PCNum"]);
            if (dr["PCDN_PTOrd"] != DBNull.Value) pCD_NRecord.PCDN_PTOrd = Convert.ToInt32(dr["PCDN_PTOrd"]);
            if (dr["PCDN_PCDrv"] != DBNull.Value) pCD_NRecord.PCDN_PCDrv = Convert.ToString(dr["PCDN_PCDrv"]);
            if (dr["PCDN_Comp"] != DBNull.Value) pCD_NRecord.PCDN_Comp = Convert.ToString(dr["PCDN_Comp"]);
            if (dr["PCDN_PCCode"] != DBNull.Value) pCD_NRecord.PCDN_PCCode = Convert.ToString(dr["PCDN_PCCode"]);
            if (dr["PCDN_PCNo"] != DBNull.Value) pCD_NRecord.PCDN_PCNo = Convert.ToString(dr["PCDN_PCNo"]);
            if (dr["PCDN_DDate"] != DBNull.Value) pCD_NRecord.PCDN_DDate = Convert.ToDateTime(dr["PCDN_DDate"]);
            if (dr["PCDN_RDate"] != DBNull.Value) pCD_NRecord.PCDN_RDate = Convert.ToDateTime(dr["PCDN_RDate"]);
            if (dr["PCDN_JBegin"] != DBNull.Value) pCD_NRecord.PCDN_JBegin = Convert.ToDateTime(dr["PCDN_JBegin"]);
            if (dr["PCDN_JEnd"] != DBNull.Value) pCD_NRecord.PCDN_JEnd = Convert.ToDateTime(dr["PCDN_JEnd"]);
            if (dr["PCDN_LDate"] != DBNull.Value) pCD_NRecord.PCDN_LDate = Convert.ToDateTime(dr["PCDN_LDate"]);
            if (dr["PCDN_BDate"] != DBNull.Value) pCD_NRecord.PCDN_BDate = Convert.ToDateTime(dr["PCDN_BDate"]);
            if (dr["PCDN_PPNum"] != DBNull.Value) pCD_NRecord.PCDN_PPNum = Convert.ToDecimal(dr["PCDN_PPNum"]);
            if (dr["PCDN_TDNum"] != DBNull.Value) pCD_NRecord.PCDN_TDNum = Convert.ToDecimal(dr["PCDN_TDNum"]);
            if (dr["PCDN_TTNum"] != DBNull.Value) pCD_NRecord.PCDN_TTNum = Convert.ToInt32(dr["PCDN_TTNum"]);
            if (dr["PCDN_RTNum"] != DBNull.Value) pCD_NRecord.PCDN_RTNum = Convert.ToDecimal(dr["PCDN_RTNum"]);
            if (dr["PCDN_CTNum"] != DBNull.Value) pCD_NRecord.PCDN_CTNum = Convert.ToDecimal(dr["PCDN_CTNum"]);
            if (dr["PCDN_RRNum"] != DBNull.Value) pCD_NRecord.PCDN_RRNum = Convert.ToDecimal(dr["PCDN_RRNum"]);
            if (dr["PCDN_MoreNum"] != DBNull.Value) pCD_NRecord.PCDN_MoreNum = Convert.ToDecimal(dr["PCDN_MoreNum"]);
            if (dr["PCDN_PRNum"] != DBNull.Value) pCD_NRecord.PCDN_PRNum = Convert.ToDecimal(dr["PCDN_PRNum"]);
            if (dr["PCDN_BStatus"] != DBNull.Value) pCD_NRecord.PCDN_BStatus = Convert.ToString(dr["PCDN_BStatus"]);
            if (dr["PCDN_TRNum"] != DBNull.Value) pCD_NRecord.PCDN_TRNum = Convert.ToDecimal(dr["PCDN_TRNum"]);
            if (dr["PCDN_TBNum"] != DBNull.Value) pCD_NRecord.PCDN_TBNum = Convert.ToDecimal(dr["PCDN_TBNum"]);
            if (dr["PCDN_TBBak"] != DBNull.Value) pCD_NRecord.PCDN_TBBak = Convert.ToString(dr["PCDN_TBBak"]);
            if (dr["PCDN_Stat"] != DBNull.Value) pCD_NRecord.PCDN_Stat = Convert.ToString(dr["PCDN_Stat"]);
            if (dr["PCDN_iType"] != DBNull.Value) pCD_NRecord.PCDN_iType = Convert.ToString(dr["PCDN_iType"]);
            if (dr["Stat"] != DBNull.Value) pCD_NRecord.Stat = Convert.ToInt32(dr["Stat"]);
            if (dr["CreateDate"] != DBNull.Value) pCD_NRecord.CreateDate = Convert.ToDateTime(dr["CreateDate"]);
            if (dr["UpdateDate"] != DBNull.Value) pCD_NRecord.UpdateDate = Convert.ToDateTime(dr["UpdateDate"]);
            if (dr["DeleteDate"] != DBNull.Value) pCD_NRecord.DeleteDate = Convert.ToDateTime(dr["DeleteDate"]);
            if (dr["PCDN_SourceCode"] != DBNull.Value) pCD_NRecord.PCDN_SourceCode = Convert.ToString(dr["PCDN_SourceCode"]);
            ret.Add(pCD_NRecord);
         }
          }catch (System.Exception ex){ throw ex; }  finally {  if (dr != null) { dr.Close(); } if (idb.GetConnection() != null && idb.GetConnection().State == ConnectionState.Open) { idb.GetConnection().Close(); }   } 
         return ret;
      }
   }
}
