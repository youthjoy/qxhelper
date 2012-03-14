using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 请购单
   /// </summary>
   [Serializable]
   public partial class WH_ApplyBuy
   {
      /// <summary>
      /// 库存移动ID
      /// </summary>
      private decimal mVI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_ID_IsChanged=false;
      /// <summary>
      /// 库存移动ID
      /// </summary>
      public decimal MVI_ID
      {
         get{ return mVI_ID; }
         set{ mVI_ID = value; mVI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 库存移动ID
      /// </summary>
      public bool MVI_ID_IsChanged
      {
         get{ return mVI_ID_IsChanged; }
         set{ mVI_ID_IsChanged = value; }
      }
      private string mVI_Code;
      private bool mVI_Code_IsChanged=false;
      public string MVI_Code
      {
         get{ return mVI_Code; }
         set{ mVI_Code = value; mVI_Code_IsChanged=true; }
      }
      public bool MVI_Code_IsChanged
      {
         get{ return mVI_Code_IsChanged; }
         set{ mVI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 主单据编码
      /// </summary>
      private string mVI_RCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_RCode_IsChanged=false;
      /// <summary>
      /// 主单据编码
      /// </summary>
      public string MVI_RCode
      {
         get{ return mVI_RCode; }
         set{ mVI_RCode = value; mVI_RCode_IsChanged=true; }
      }
      /// <summary>
      /// 主单据编码
      /// </summary>
      public bool MVI_RCode_IsChanged
      {
         get{ return mVI_RCode_IsChanged; }
         set{ mVI_RCode_IsChanged = value; }
      }
      /// <summary>
      /// 库存移动类型
      /// </summary>
      private string mVI_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Type_IsChanged=false;
      /// <summary>
      /// 库存移动类型
      /// </summary>
      public string MVI_Type
      {
         get{ return mVI_Type; }
         set{ mVI_Type = value; mVI_Type_IsChanged=true; }
      }
      /// <summary>
      /// 库存移动类型
      /// </summary>
      public bool MVI_Type_IsChanged
      {
         get{ return mVI_Type_IsChanged; }
         set{ mVI_Type_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string mVI_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string MVI_MCode
      {
         get{ return mVI_MCode; }
         set{ mVI_MCode = value; mVI_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool MVI_MCode_IsChanged
      {
         get{ return mVI_MCode_IsChanged; }
         set{ mVI_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      private string mVI_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Spec_IsChanged=false;
      /// <summary>
      /// 规格
      /// </summary>
      public string MVI_Spec
      {
         get{ return mVI_Spec; }
         set{ mVI_Spec = value; mVI_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      public bool MVI_Spec_IsChanged
      {
         get{ return mVI_Spec_IsChanged; }
         set{ mVI_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 供货单位
      /// </summary>
      private string mVI_Sup;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Sup_IsChanged=false;
      /// <summary>
      /// 供货单位
      /// </summary>
      public string MVI_Sup
      {
         get{ return mVI_Sup; }
         set{ mVI_Sup = value; mVI_Sup_IsChanged=true; }
      }
      /// <summary>
      /// 供货单位
      /// </summary>
      public bool MVI_Sup_IsChanged
      {
         get{ return mVI_Sup_IsChanged; }
         set{ mVI_Sup_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int mVI_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Num_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int MVI_Num
      {
         get{ return mVI_Num; }
         set{ mVI_Num = value; mVI_Num_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool MVI_Num_IsChanged
      {
         get{ return mVI_Num_IsChanged; }
         set{ mVI_Num_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string mVI_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string MVI_Unit
      {
         get{ return mVI_Unit; }
         set{ mVI_Unit = value; mVI_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool MVI_Unit_IsChanged
      {
         get{ return mVI_Unit_IsChanged; }
         set{ mVI_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 单位价格
      /// </summary>
      private double mVI_MDPrice;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mVI_MDPrice_IsChanged=false;
      /// <summary>
      /// 单位价格
      /// </summary>
      public double MVI_MDPrice
      {
         get{ return mVI_MDPrice; }
         set{ mVI_MDPrice = value; mVI_MDPrice_IsChanged=true; }
      }
      /// <summary>
      /// 单位价格
      /// </summary>
      public bool MVI_MDPrice_IsChanged
      {
         get{ return mVI_MDPrice_IsChanged; }
         set{ mVI_MDPrice_IsChanged = value; }
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
      /// 日期
      /// </summary>
      private string mV_CustDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mV_CustDate_IsChanged=false;
      /// <summary>
      /// 日期
      /// </summary>
      public string MV_CustDate
      {
         get{ return mV_CustDate; }
         set{ mV_CustDate = value; mV_CustDate_IsChanged=true; }
      }
      /// <summary>
      /// 日期
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
   }
}
