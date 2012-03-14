using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 结算单物料明细
   /// </summary>
   [Serializable]
   public partial class WH_BItem
   {
      /// <summary>
      /// 结算单明细序号
      /// </summary>
      private decimal sBI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sBI_ID_IsChanged=false;
      /// <summary>
      /// 结算单明细序号
      /// </summary>
      public decimal SBI_ID
      {
         get{ return sBI_ID; }
         set{ sBI_ID = value; sBI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 结算单明细序号
      /// </summary>
      public bool SBI_ID_IsChanged
      {
         get{ return sBI_ID_IsChanged; }
         set{ sBI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string sBI_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sBI_SCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string SBI_SCode
      {
         get{ return sBI_SCode; }
         set{ sBI_SCode = value; sBI_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool SBI_SCode_IsChanged
      {
         get{ return sBI_SCode_IsChanged; }
         set{ sBI_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string sBI_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sBI_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string SBI_MCode
      {
         get{ return sBI_MCode; }
         set{ sBI_MCode = value; sBI_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool SBI_MCode_IsChanged
      {
         get{ return sBI_MCode_IsChanged; }
         set{ sBI_MCode_IsChanged = value; }
      }
      private string sBI_Period;
      private bool sBI_Period_IsChanged=false;
      public string SBI_Period
      {
         get{ return sBI_Period; }
         set{ sBI_Period = value; sBI_Period_IsChanged=true; }
      }
      public bool SBI_Period_IsChanged
      {
         get{ return sBI_Period_IsChanged; }
         set{ sBI_Period_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string sBI_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sBI_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string SBI_MName
      {
         get{ return sBI_MName; }
         set{ sBI_MName = value; sBI_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool SBI_MName_IsChanged
      {
         get{ return sBI_MName_IsChanged; }
         set{ sBI_MName_IsChanged = value; }
      }
      /// <summary>
      /// 物料规格
      /// </summary>
      private string sBI_MSpec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sBI_MSpec_IsChanged=false;
      /// <summary>
      /// 物料规格
      /// </summary>
      public string SBI_MSpec
      {
         get{ return sBI_MSpec; }
         set{ sBI_MSpec = value; sBI_MSpec_IsChanged=true; }
      }
      /// <summary>
      /// 物料规格
      /// </summary>
      public bool SBI_MSpec_IsChanged
      {
         get{ return sBI_MSpec_IsChanged; }
         set{ sBI_MSpec_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal sBI_Sum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sBI_Sum_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal SBI_Sum
      {
         get{ return sBI_Sum; }
         set{ sBI_Sum = value; sBI_Sum_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool SBI_Sum_IsChanged
      {
         get{ return sBI_Sum_IsChanged; }
         set{ sBI_Sum_IsChanged = value; }
      }
      /// <summary>
      /// 本月消耗
      /// </summary>
      private decimal sBI_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sBI_Num_IsChanged=false;
      /// <summary>
      /// 本月消耗
      /// </summary>
      public decimal SBI_Num
      {
         get{ return sBI_Num; }
         set{ sBI_Num = value; sBI_Num_IsChanged=true; }
      }
      /// <summary>
      /// 本月消耗
      /// </summary>
      public bool SBI_Num_IsChanged
      {
         get{ return sBI_Num_IsChanged; }
         set{ sBI_Num_IsChanged = value; }
      }
      private decimal sBI_RNum;
      private bool sBI_RNum_IsChanged=false;
      public decimal SBI_RNum
      {
         get{ return sBI_RNum; }
         set{ sBI_RNum = value; sBI_RNum_IsChanged=true; }
      }
      public bool SBI_RNum_IsChanged
      {
         get{ return sBI_RNum_IsChanged; }
         set{ sBI_RNum_IsChanged = value; }
      }
      private decimal sBI_RSum;
      private bool sBI_RSum_IsChanged=false;
      public decimal SBI_RSum
      {
         get{ return sBI_RSum; }
         set{ sBI_RSum = value; sBI_RSum_IsChanged=true; }
      }
      public bool SBI_RSum_IsChanged
      {
         get{ return sBI_RSum_IsChanged; }
         set{ sBI_RSum_IsChanged = value; }
      }
      /// <summary>
      /// 本月结存
      /// </summary>
      private string sBI_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sBI_Unit_IsChanged=false;
      /// <summary>
      /// 本月结存
      /// </summary>
      public string SBI_Unit
      {
         get{ return sBI_Unit; }
         set{ sBI_Unit = value; sBI_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 本月结存
      /// </summary>
      public bool SBI_Unit_IsChanged
      {
         get{ return sBI_Unit_IsChanged; }
         set{ sBI_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private string sBI_WHBCode;
      private bool sBI_WHBCode_IsChanged=false;
      public string SBI_WHBCode
      {
         get{ return sBI_WHBCode; }
         set{ sBI_WHBCode = value; sBI_WHBCode_IsChanged=true; }
      }
      public bool SBI_WHBCode_IsChanged
      {
         get{ return sBI_WHBCode_IsChanged; }
         set{ sBI_WHBCode_IsChanged = value; }
      }
      private DateTime createDate;
      private bool createDate_IsChanged=false;
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      private DateTime updateDate;
      private bool updateDate_IsChanged=false;
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      private DateTime deleteDate;
      private bool deleteDate_IsChanged=false;
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
      private decimal sBI_Tranfee;
      private bool sBI_Tranfee_IsChanged=false;
      public decimal SBI_Tranfee
      {
         get{ return sBI_Tranfee; }
         set{ sBI_Tranfee = value; sBI_Tranfee_IsChanged=true; }
      }
      public bool SBI_Tranfee_IsChanged
      {
         get{ return sBI_Tranfee_IsChanged; }
         set{ sBI_Tranfee_IsChanged = value; }
      }
      private string sBI_CompanyName;
      private bool sBI_CompanyName_IsChanged=false;
      public string SBI_CompanyName
      {
         get{ return sBI_CompanyName; }
         set{ sBI_CompanyName = value; sBI_CompanyName_IsChanged=true; }
      }
      public bool SBI_CompanyName_IsChanged
      {
         get{ return sBI_CompanyName_IsChanged; }
         set{ sBI_CompanyName_IsChanged = value; }
      }
      private string sBI_Company;
      private bool sBI_Company_IsChanged=false;
      public string SBI_Company
      {
         get{ return sBI_Company; }
         set{ sBI_Company = value; sBI_Company_IsChanged=true; }
      }
      public bool SBI_Company_IsChanged
      {
         get{ return sBI_Company_IsChanged; }
         set{ sBI_Company_IsChanged = value; }
      }
   }
}
