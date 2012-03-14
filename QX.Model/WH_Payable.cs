using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 应付单
   /// </summary>
   [Serializable]
   public partial class WH_Payable
   {
      /// <summary>
      /// 应付单序号
      /// </summary>
      private decimal wHP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHP_ID_IsChanged=false;
      /// <summary>
      /// 应付单序号
      /// </summary>
      public decimal WHP_ID
      {
         get{ return wHP_ID; }
         set{ wHP_ID = value; wHP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 应付单序号
      /// </summary>
      public bool WHP_ID_IsChanged
      {
         get{ return wHP_ID_IsChanged; }
         set{ wHP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 应付单编码
      /// </summary>
      private string wHP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHP_Code_IsChanged=false;
      /// <summary>
      /// 应付单编码
      /// </summary>
      public string WHP_Code
      {
         get{ return wHP_Code; }
         set{ wHP_Code = value; wHP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 应付单编码
      /// </summary>
      public bool WHP_Code_IsChanged
      {
         get{ return wHP_Code_IsChanged; }
         set{ wHP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string wHP_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHP_SCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string WHP_SCode
      {
         get{ return wHP_SCode; }
         set{ wHP_SCode = value; wHP_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool WHP_SCode_IsChanged
      {
         get{ return wHP_SCode_IsChanged; }
         set{ wHP_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      private string wHP_SName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHP_SName_IsChanged=false;
      /// <summary>
      /// 供应商名称
      /// </summary>
      public string WHP_SName
      {
         get{ return wHP_SName; }
         set{ wHP_SName = value; wHP_SName_IsChanged=true; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      public bool WHP_SName_IsChanged
      {
         get{ return wHP_SName_IsChanged; }
         set{ wHP_SName_IsChanged = value; }
      }
      /// <summary>
      /// 帐期
      /// </summary>
      private string wHP_Period;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHP_Period_IsChanged=false;
      /// <summary>
      /// 帐期
      /// </summary>
      public string WHP_Period
      {
         get{ return wHP_Period; }
         set{ wHP_Period = value; wHP_Period_IsChanged=true; }
      }
      /// <summary>
      /// 帐期
      /// </summary>
      public bool WHP_Period_IsChanged
      {
         get{ return wHP_Period_IsChanged; }
         set{ wHP_Period_IsChanged = value; }
      }
      /// <summary>
      /// 上月应付结余
      /// </summary>
      private decimal wHP_LSum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHP_LSum_IsChanged=false;
      /// <summary>
      /// 上月应付结余
      /// </summary>
      public decimal WHP_LSum
      {
         get{ return wHP_LSum; }
         set{ wHP_LSum = value; wHP_LSum_IsChanged=true; }
      }
      /// <summary>
      /// 上月应付结余
      /// </summary>
      public bool WHP_LSum_IsChanged
      {
         get{ return wHP_LSum_IsChanged; }
         set{ wHP_LSum_IsChanged = value; }
      }
      /// <summary>
      /// 本月结算
      /// </summary>
      private decimal wHP_CSum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHP_CSum_IsChanged=false;
      /// <summary>
      /// 本月结算
      /// </summary>
      public decimal WHP_CSum
      {
         get{ return wHP_CSum; }
         set{ wHP_CSum = value; wHP_CSum_IsChanged=true; }
      }
      /// <summary>
      /// 本月结算
      /// </summary>
      public bool WHP_CSum_IsChanged
      {
         get{ return wHP_CSum_IsChanged; }
         set{ wHP_CSum_IsChanged = value; }
      }
      private decimal wHP_CLeft;
      private bool wHP_CLeft_IsChanged=false;
      public decimal WHP_CLeft
      {
         get{ return wHP_CLeft; }
         set{ wHP_CLeft = value; wHP_CLeft_IsChanged=true; }
      }
      public bool WHP_CLeft_IsChanged
      {
         get{ return wHP_CLeft_IsChanged; }
         set{ wHP_CLeft_IsChanged = value; }
      }
      private int wHP_IsDone;
      private bool wHP_IsDone_IsChanged=false;
      public int WHP_IsDone
      {
         get{ return wHP_IsDone; }
         set{ wHP_IsDone = value; wHP_IsDone_IsChanged=true; }
      }
      public bool WHP_IsDone_IsChanged
      {
         get{ return wHP_IsDone_IsChanged; }
         set{ wHP_IsDone_IsChanged = value; }
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
      private DateTime wHP_IsDate;
      private bool wHP_IsDate_IsChanged=false;
      public DateTime WHP_IsDate
      {
         get{ return wHP_IsDate; }
         set{ wHP_IsDate = value; wHP_IsDate_IsChanged=true; }
      }
      public bool WHP_IsDate_IsChanged
      {
         get{ return wHP_IsDate_IsChanged; }
         set{ wHP_IsDate_IsChanged = value; }
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
      private string wHP_UCompany;
      private bool wHP_UCompany_IsChanged=false;
      public string WHP_UCompany
      {
         get{ return wHP_UCompany; }
         set{ wHP_UCompany = value; wHP_UCompany_IsChanged=true; }
      }
      public bool WHP_UCompany_IsChanged
      {
         get{ return wHP_UCompany_IsChanged; }
         set{ wHP_UCompany_IsChanged = value; }
      }
      private string wHP_UCompanyCode;
      private bool wHP_UCompanyCode_IsChanged=false;
      public string WHP_UCompanyCode
      {
         get{ return wHP_UCompanyCode; }
         set{ wHP_UCompanyCode = value; wHP_UCompanyCode_IsChanged=true; }
      }
      public bool WHP_UCompanyCode_IsChanged
      {
         get{ return wHP_UCompanyCode_IsChanged; }
         set{ wHP_UCompanyCode_IsChanged = value; }
      }
      private decimal wHP_broom;
      private bool wHP_broom_IsChanged=false;
      public decimal WHP_broom
      {
         get{ return wHP_broom; }
         set{ wHP_broom = value; wHP_broom_IsChanged=true; }
      }
      public bool WHP_broom_IsChanged
      {
         get{ return wHP_broom_IsChanged; }
         set{ wHP_broom_IsChanged = value; }
      }
   }
}
