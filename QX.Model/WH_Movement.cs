using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 物料移动单据
   /// </summary>
   [Serializable]
   public partial class WH_Movement
   {
      /// <summary>
      /// 库存移动主ID
      /// </summary>
      private decimal mV_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_ID_IsChanged=false;
      /// <summary>
      /// 库存移动主ID
      /// </summary>
      public decimal MV_ID
      {
         get{ return mV_ID; }
         set{ mV_ID = value; mV_ID_IsChanged=true; }
      }
      /// <summary>
      /// 库存移动主ID
      /// </summary>
      public bool MV_ID_IsChanged
      {
         get{ return mV_ID_IsChanged; }
         set{ mV_ID_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string mV_RecordCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_RecordCode_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string MV_RecordCode
      {
         get{ return mV_RecordCode; }
         set{ mV_RecordCode = value; mV_RecordCode_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool MV_RecordCode_IsChanged
      {
         get{ return mV_RecordCode_IsChanged; }
         set{ mV_RecordCode_IsChanged = value; }
      }
      /// <summary>
      /// 库存移动类型
      /// </summary>
      private string mV_MType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_MType_IsChanged=false;
      /// <summary>
      /// 库存移动类型
      /// </summary>
      public string MV_MType
      {
         get{ return mV_MType; }
         set{ mV_MType = value; mV_MType_IsChanged=true; }
      }
      /// <summary>
      /// 库存移动类型
      /// </summary>
      public bool MV_MType_IsChanged
      {
         get{ return mV_MType_IsChanged; }
         set{ mV_MType_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      private string mV_RefKey;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_RefKey_IsChanged=false;
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public string MV_RefKey
      {
         get{ return mV_RefKey; }
         set{ mV_RefKey = value; mV_RefKey_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public bool MV_RefKey_IsChanged
      {
         get{ return mV_RefKey_IsChanged; }
         set{ mV_RefKey_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      private string mV_RefRecord;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_RefRecord_IsChanged=false;
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public string MV_RefRecord
      {
         get{ return mV_RefRecord; }
         set{ mV_RefRecord = value; mV_RefRecord_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public bool MV_RefRecord_IsChanged
      {
         get{ return mV_RefRecord_IsChanged; }
         set{ mV_RefRecord_IsChanged = value; }
      }
      /// <summary>
      /// 创建人
      /// </summary>
      private string creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool creator_IsChanged=false;
      /// <summary>
      /// 创建人
      /// </summary>
      public string Creator
      {
         get{ return creator; }
         set{ creator = value; creator_IsChanged=true; }
      }
      /// <summary>
      /// 创建人
      /// </summary>
      public bool Creator_IsChanged
      {
         get{ return creator_IsChanged; }
         set{ creator_IsChanged = value; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createTime_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
      }
      /// <summary>
      /// 更新人
      /// </summary>
      private string uPTStuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool uPTStuff_IsChanged=false;
      /// <summary>
      /// 更新人
      /// </summary>
      public string UPTStuff
      {
         get{ return uPTStuff; }
         set{ uPTStuff = value; uPTStuff_IsChanged=true; }
      }
      /// <summary>
      /// 更新人
      /// </summary>
      public bool UPTStuff_IsChanged
      {
         get{ return uPTStuff_IsChanged; }
         set{ uPTStuff_IsChanged = value; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      private DateTime uPTDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool uPTDate_IsChanged=false;
      /// <summary>
      /// 更新时间
      /// </summary>
      public DateTime UPTDate
      {
         get{ return uPTDate; }
         set{ uPTDate = value; uPTDate_IsChanged=true; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      public bool UPTDate_IsChanged
      {
         get{ return uPTDate_IsChanged; }
         set{ uPTDate_IsChanged = value; }
      }
      /// <summary>
      /// 删除人
      /// </summary>
      private string dELStuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dELStuff_IsChanged=false;
      /// <summary>
      /// 删除人
      /// </summary>
      public string DELStuff
      {
         get{ return dELStuff; }
         set{ dELStuff = value; dELStuff_IsChanged=true; }
      }
      /// <summary>
      /// 删除人
      /// </summary>
      public bool DELStuff_IsChanged
      {
         get{ return dELStuff_IsChanged; }
         set{ dELStuff_IsChanged = value; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      private DateTime dELDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dELDate_IsChanged=false;
      /// <summary>
      /// 删除时间
      /// </summary>
      public DateTime DELDate
      {
         get{ return dELDate; }
         set{ dELDate = value; dELDate_IsChanged=true; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      public bool DELDate_IsChanged
      {
         get{ return dELDate_IsChanged; }
         set{ dELDate_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string mV_CustCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_CustCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string MV_CustCode
      {
         get{ return mV_CustCode; }
         set{ mV_CustCode = value; mV_CustCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool MV_CustCode_IsChanged
      {
         get{ return mV_CustCode_IsChanged; }
         set{ mV_CustCode_IsChanged = value; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      private string mV_CustName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_CustName_IsChanged=false;
      /// <summary>
      /// 供应商名称
      /// </summary>
      public string MV_CustName
      {
         get{ return mV_CustName; }
         set{ mV_CustName = value; mV_CustName_IsChanged=true; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      public bool MV_CustName_IsChanged
      {
         get{ return mV_CustName_IsChanged; }
         set{ mV_CustName_IsChanged = value; }
      }
      /// <summary>
      /// 供应商参考编码
      /// </summary>
      private string mV_CustRef;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_CustRef_IsChanged=false;
      /// <summary>
      /// 供应商参考编码
      /// </summary>
      public string MV_CustRef
      {
         get{ return mV_CustRef; }
         set{ mV_CustRef = value; mV_CustRef_IsChanged=true; }
      }
      /// <summary>
      /// 供应商参考编码
      /// </summary>
      public bool MV_CustRef_IsChanged
      {
         get{ return mV_CustRef_IsChanged; }
         set{ mV_CustRef_IsChanged = value; }
      }
      /// <summary>
      /// 交货日期
      /// </summary>
      private DateTime mV_CustDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_CustDate_IsChanged=false;
      /// <summary>
      /// 交货日期
      /// </summary>
      public DateTime MV_CustDate
      {
         get{ return mV_CustDate; }
         set{ mV_CustDate = value; mV_CustDate_IsChanged=true; }
      }
      /// <summary>
      /// 交货日期
      /// </summary>
      public bool MV_CustDate_IsChanged
      {
         get{ return mV_CustDate_IsChanged; }
         set{ mV_CustDate_IsChanged = value; }
      }
      /// <summary>
      /// 审核阶段
      /// </summary>
      private string mV_VerifyStep;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_VerifyStep_IsChanged=false;
      /// <summary>
      /// 审核阶段
      /// </summary>
      public string MV_VerifyStep
      {
         get{ return mV_VerifyStep; }
         set{ mV_VerifyStep = value; mV_VerifyStep_IsChanged=true; }
      }
      /// <summary>
      /// 审核阶段
      /// </summary>
      public bool MV_VerifyStep_IsChanged
      {
         get{ return mV_VerifyStep_IsChanged; }
         set{ mV_VerifyStep_IsChanged = value; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      private string mV_VerifyStuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_VerifyStuff_IsChanged=false;
      /// <summary>
      /// 审核人
      /// </summary>
      public string MV_VerifyStuff
      {
         get{ return mV_VerifyStuff; }
         set{ mV_VerifyStuff = value; mV_VerifyStuff_IsChanged=true; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      public bool MV_VerifyStuff_IsChanged
      {
         get{ return mV_VerifyStuff_IsChanged; }
         set{ mV_VerifyStuff_IsChanged = value; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      private DateTime mV_VerifyDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_VerifyDate_IsChanged=false;
      /// <summary>
      /// 审核时间
      /// </summary>
      public DateTime MV_VerifyDate
      {
         get{ return mV_VerifyDate; }
         set{ mV_VerifyDate = value; mV_VerifyDate_IsChanged=true; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      public bool MV_VerifyDate_IsChanged
      {
         get{ return mV_VerifyDate_IsChanged; }
         set{ mV_VerifyDate_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string mV_VerifyStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_VerifyStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string MV_VerifyStat
      {
         get{ return mV_VerifyStat; }
         set{ mV_VerifyStat = value; mV_VerifyStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool MV_VerifyStat_IsChanged
      {
         get{ return mV_VerifyStat_IsChanged; }
         set{ mV_VerifyStat_IsChanged = value; }
      }
      /// <summary>
      /// 供货合同编码
      /// </summary>
      private string mV_ContractNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_ContractNo_IsChanged=false;
      /// <summary>
      /// 供货合同编码
      /// </summary>
      public string MV_ContractNo
      {
         get{ return mV_ContractNo; }
         set{ mV_ContractNo = value; mV_ContractNo_IsChanged=true; }
      }
      /// <summary>
      /// 供货合同编码
      /// </summary>
      public bool MV_ContractNo_IsChanged
      {
         get{ return mV_ContractNo_IsChanged; }
         set{ mV_ContractNo_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private string mV_ReciveStaus;
      private bool mV_ReciveStaus_IsChanged=false;
      public string MV_ReciveStaus
      {
         get{ return mV_ReciveStaus; }
         set{ mV_ReciveStaus = value; mV_ReciveStaus_IsChanged=true; }
      }
      public bool MV_ReciveStaus_IsChanged
      {
         get{ return mV_ReciveStaus_IsChanged; }
         set{ mV_ReciveStaus_IsChanged = value; }
      }
   }
}
