using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 付款
   /// </summary>
   [Serializable]
   public partial class WH_Pay
   {
      /// <summary>
      /// 付款序号
      /// </summary>
      private decimal wHPP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_ID_IsChanged=false;
      /// <summary>
      /// 付款序号
      /// </summary>
      public decimal WHPP_ID
      {
         get{ return wHPP_ID; }
         set{ wHPP_ID = value; wHPP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 付款序号
      /// </summary>
      public bool WHPP_ID_IsChanged
      {
         get{ return wHPP_ID_IsChanged; }
         set{ wHPP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 付款编码
      /// </summary>
      private string wHPP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_Code_IsChanged=false;
      /// <summary>
      /// 付款编码
      /// </summary>
      public string WHPP_Code
      {
         get{ return wHPP_Code; }
         set{ wHPP_Code = value; wHPP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 付款编码
      /// </summary>
      public bool WHPP_Code_IsChanged
      {
         get{ return wHPP_Code_IsChanged; }
         set{ wHPP_Code_IsChanged = value; }
      }
      private string wHPP_Period;
      private bool wHPP_Period_IsChanged=false;
      public string WHPP_Period
      {
         get{ return wHPP_Period; }
         set{ wHPP_Period = value; wHPP_Period_IsChanged=true; }
      }
      public bool WHPP_Period_IsChanged
      {
         get{ return wHPP_Period_IsChanged; }
         set{ wHPP_Period_IsChanged = value; }
      }
      /// <summary>
      /// 付款类型
      /// </summary>
      private string wHPP_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_Type_IsChanged=false;
      /// <summary>
      /// 付款类型
      /// </summary>
      public string WHPP_Type
      {
         get{ return wHPP_Type; }
         set{ wHPP_Type = value; wHPP_Type_IsChanged=true; }
      }
      /// <summary>
      /// 付款类型
      /// </summary>
      public bool WHPP_Type_IsChanged
      {
         get{ return wHPP_Type_IsChanged; }
         set{ wHPP_Type_IsChanged = value; }
      }
      /// <summary>
      /// 付款事由
      /// </summary>
      private string wHPP_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_Reason_IsChanged=false;
      /// <summary>
      /// 付款事由
      /// </summary>
      public string WHPP_Reason
      {
         get{ return wHPP_Reason; }
         set{ wHPP_Reason = value; wHPP_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 付款事由
      /// </summary>
      public bool WHPP_Reason_IsChanged
      {
         get{ return wHPP_Reason_IsChanged; }
         set{ wHPP_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string wHPP_CompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_CompanyCode_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string WHPP_CompanyCode
      {
         get{ return wHPP_CompanyCode; }
         set{ wHPP_CompanyCode = value; wHPP_CompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool WHPP_CompanyCode_IsChanged
      {
         get{ return wHPP_CompanyCode_IsChanged; }
         set{ wHPP_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司名称
      /// </summary>
      private string wHPP_CompanyName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_CompanyName_IsChanged=false;
      /// <summary>
      /// 所属公司名称
      /// </summary>
      public string WHPP_CompanyName
      {
         get{ return wHPP_CompanyName; }
         set{ wHPP_CompanyName = value; wHPP_CompanyName_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司名称
      /// </summary>
      public bool WHPP_CompanyName_IsChanged
      {
         get{ return wHPP_CompanyName_IsChanged; }
         set{ wHPP_CompanyName_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string wHPP_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_SCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string WHPP_SCode
      {
         get{ return wHPP_SCode; }
         set{ wHPP_SCode = value; wHPP_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool WHPP_SCode_IsChanged
      {
         get{ return wHPP_SCode_IsChanged; }
         set{ wHPP_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      private string wHPP_SName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_SName_IsChanged=false;
      /// <summary>
      /// 供应商名称
      /// </summary>
      public string WHPP_SName
      {
         get{ return wHPP_SName; }
         set{ wHPP_SName = value; wHPP_SName_IsChanged=true; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      public bool WHPP_SName_IsChanged
      {
         get{ return wHPP_SName_IsChanged; }
         set{ wHPP_SName_IsChanged = value; }
      }
      /// <summary>
      /// 付款时间
      /// </summary>
      private DateTime wHPP_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_Date_IsChanged=false;
      /// <summary>
      /// 付款时间
      /// </summary>
      public DateTime WHPP_Date
      {
         get{ return wHPP_Date; }
         set{ wHPP_Date = value; wHPP_Date_IsChanged=true; }
      }
      /// <summary>
      /// 付款时间
      /// </summary>
      public bool WHPP_Date_IsChanged
      {
         get{ return wHPP_Date_IsChanged; }
         set{ wHPP_Date_IsChanged = value; }
      }
      /// <summary>
      /// 付款单位名称
      /// </summary>
      private string wHPP_PName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_PName_IsChanged=false;
      /// <summary>
      /// 付款单位名称
      /// </summary>
      public string WHPP_PName
      {
         get{ return wHPP_PName; }
         set{ wHPP_PName = value; wHPP_PName_IsChanged=true; }
      }
      /// <summary>
      /// 付款单位名称
      /// </summary>
      public bool WHPP_PName_IsChanged
      {
         get{ return wHPP_PName_IsChanged; }
         set{ wHPP_PName_IsChanged = value; }
      }
      /// <summary>
      /// 付款方式
      /// </summary>
      private string wHPP_PayMethod;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_PayMethod_IsChanged=false;
      /// <summary>
      /// 付款方式
      /// </summary>
      public string WHPP_PayMethod
      {
         get{ return wHPP_PayMethod; }
         set{ wHPP_PayMethod = value; wHPP_PayMethod_IsChanged=true; }
      }
      /// <summary>
      /// 付款方式
      /// </summary>
      public bool WHPP_PayMethod_IsChanged
      {
         get{ return wHPP_PayMethod_IsChanged; }
         set{ wHPP_PayMethod_IsChanged = value; }
      }
      /// <summary>
      /// 付款金额
      /// </summary>
      private decimal wHPP_Sum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_Sum_IsChanged=false;
      /// <summary>
      /// 付款金额
      /// </summary>
      public decimal WHPP_Sum
      {
         get{ return wHPP_Sum; }
         set{ wHPP_Sum = value; wHPP_Sum_IsChanged=true; }
      }
      /// <summary>
      /// 付款金额
      /// </summary>
      public bool WHPP_Sum_IsChanged
      {
         get{ return wHPP_Sum_IsChanged; }
         set{ wHPP_Sum_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      private string wHPP_RefType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_RefType_IsChanged=false;
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public string WHPP_RefType
      {
         get{ return wHPP_RefType; }
         set{ wHPP_RefType = value; wHPP_RefType_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public bool WHPP_RefType_IsChanged
      {
         get{ return wHPP_RefType_IsChanged; }
         set{ wHPP_RefType_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      private string wHPP_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_RefCode_IsChanged=false;
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public string WHPP_RefCode
      {
         get{ return wHPP_RefCode; }
         set{ wHPP_RefCode = value; wHPP_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public bool WHPP_RefCode_IsChanged
      {
         get{ return wHPP_RefCode_IsChanged; }
         set{ wHPP_RefCode_IsChanged = value; }
      }
      /// <summary>
      /// 财务经手人
      /// </summary>
      private string wHPP_FOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_FOwner_IsChanged=false;
      /// <summary>
      /// 财务经手人
      /// </summary>
      public string WHPP_FOwner
      {
         get{ return wHPP_FOwner; }
         set{ wHPP_FOwner = value; wHPP_FOwner_IsChanged=true; }
      }
      /// <summary>
      /// 财务经手人
      /// </summary>
      public bool WHPP_FOwner_IsChanged
      {
         get{ return wHPP_FOwner_IsChanged; }
         set{ wHPP_FOwner_IsChanged = value; }
      }
      /// <summary>
      /// 采购经手人
      /// </summary>
      private string wHPP_POwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_POwner_IsChanged=false;
      /// <summary>
      /// 采购经手人
      /// </summary>
      public string WHPP_POwner
      {
         get{ return wHPP_POwner; }
         set{ wHPP_POwner = value; wHPP_POwner_IsChanged=true; }
      }
      /// <summary>
      /// 采购经手人
      /// </summary>
      public bool WHPP_POwner_IsChanged
      {
         get{ return wHPP_POwner_IsChanged; }
         set{ wHPP_POwner_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string wHPP_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string WHPP_Bak
      {
         get{ return wHPP_Bak; }
         set{ wHPP_Bak = value; wHPP_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool WHPP_Bak_IsChanged
      {
         get{ return wHPP_Bak_IsChanged; }
         set{ wHPP_Bak_IsChanged = value; }
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
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createDate_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      private DateTime updateDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool updateDate_IsChanged=false;
      /// <summary>
      /// 更新时间
      /// </summary>
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      /// <summary>
      /// 更新时间
      /// </summary>
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      private DateTime deleteDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool deleteDate_IsChanged=false;
      /// <summary>
      /// 删除时间
      /// </summary>
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      /// <summary>
      /// 删除时间
      /// </summary>
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
      /// <summary>
      /// 上月结余
      /// </summary>
      private decimal wHPP_LastMonth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_LastMonth_IsChanged=false;
      /// <summary>
      /// 上月结余
      /// </summary>
      public decimal WHPP_LastMonth
      {
         get{ return wHPP_LastMonth; }
         set{ wHPP_LastMonth = value; wHPP_LastMonth_IsChanged=true; }
      }
      /// <summary>
      /// 上月结余
      /// </summary>
      public bool WHPP_LastMonth_IsChanged
      {
         get{ return wHPP_LastMonth_IsChanged; }
         set{ wHPP_LastMonth_IsChanged = value; }
      }
      /// <summary>
      /// 本月供货
      /// </summary>
      private decimal wHPP_CurMonth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_CurMonth_IsChanged=false;
      /// <summary>
      /// 本月供货
      /// </summary>
      public decimal WHPP_CurMonth
      {
         get{ return wHPP_CurMonth; }
         set{ wHPP_CurMonth = value; wHPP_CurMonth_IsChanged=true; }
      }
      /// <summary>
      /// 本月供货
      /// </summary>
      public bool WHPP_CurMonth_IsChanged
      {
         get{ return wHPP_CurMonth_IsChanged; }
         set{ wHPP_CurMonth_IsChanged = value; }
      }
      /// <summary>
      /// 本月结余
      /// </summary>
      private decimal wHPP_NextMonth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_NextMonth_IsChanged=false;
      /// <summary>
      /// 本月结余
      /// </summary>
      public decimal WHPP_NextMonth
      {
         get{ return wHPP_NextMonth; }
         set{ wHPP_NextMonth = value; wHPP_NextMonth_IsChanged=true; }
      }
      /// <summary>
      /// 本月结余
      /// </summary>
      public bool WHPP_NextMonth_IsChanged
      {
         get{ return wHPP_NextMonth_IsChanged; }
         set{ wHPP_NextMonth_IsChanged = value; }
      }
      /// <summary>
      /// 调整金额
      /// </summary>
      private decimal wHPP_broom;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_broom_IsChanged=false;
      /// <summary>
      /// 调整金额
      /// </summary>
      public decimal WHPP_broom
      {
         get{ return wHPP_broom; }
         set{ wHPP_broom = value; wHPP_broom_IsChanged=true; }
      }
      /// <summary>
      /// 调整金额
      /// </summary>
      public bool WHPP_broom_IsChanged
      {
         get{ return wHPP_broom_IsChanged; }
         set{ wHPP_broom_IsChanged = value; }
      }
      /// <summary>
      /// 本月应付款
      /// </summary>
      private decimal wHPP_CurPay;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_CurPay_IsChanged=false;
      /// <summary>
      /// 本月应付款
      /// </summary>
      public decimal WHPP_CurPay
      {
         get{ return wHPP_CurPay; }
         set{ wHPP_CurPay = value; wHPP_CurPay_IsChanged=true; }
      }
      /// <summary>
      /// 本月应付款
      /// </summary>
      public bool WHPP_CurPay_IsChanged
      {
         get{ return wHPP_CurPay_IsChanged; }
         set{ wHPP_CurPay_IsChanged = value; }
      }
      /// <summary>
      /// 本月计划付款
      /// </summary>
      private decimal wHPP_Plan;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_Plan_IsChanged=false;
      /// <summary>
      /// 本月计划付款
      /// </summary>
      public decimal WHPP_Plan
      {
         get{ return wHPP_Plan; }
         set{ wHPP_Plan = value; wHPP_Plan_IsChanged=true; }
      }
      /// <summary>
      /// 本月计划付款
      /// </summary>
      public bool WHPP_Plan_IsChanged
      {
         get{ return wHPP_Plan_IsChanged; }
         set{ wHPP_Plan_IsChanged = value; }
      }
      /// <summary>
      /// 本月实收款
      /// </summary>
      private decimal wHPP_Recive;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHPP_Recive_IsChanged=false;
      /// <summary>
      /// 本月实收款
      /// </summary>
      public decimal WHPP_Recive
      {
         get{ return wHPP_Recive; }
         set{ wHPP_Recive = value; wHPP_Recive_IsChanged=true; }
      }
      /// <summary>
      /// 本月实收款
      /// </summary>
      public bool WHPP_Recive_IsChanged
      {
         get{ return wHPP_Recive_IsChanged; }
         set{ wHPP_Recive_IsChanged = value; }
      }
      private string wHPP_UDEF1;
      private bool wHPP_UDEF1_IsChanged=false;
      public string WHPP_UDEF1
      {
         get{ return wHPP_UDEF1; }
         set{ wHPP_UDEF1 = value; wHPP_UDEF1_IsChanged=true; }
      }
      public bool WHPP_UDEF1_IsChanged
      {
         get{ return wHPP_UDEF1_IsChanged; }
         set{ wHPP_UDEF1_IsChanged = value; }
      }
      private string wHPP_UDEF2;
      private bool wHPP_UDEF2_IsChanged=false;
      public string WHPP_UDEF2
      {
         get{ return wHPP_UDEF2; }
         set{ wHPP_UDEF2 = value; wHPP_UDEF2_IsChanged=true; }
      }
      public bool WHPP_UDEF2_IsChanged
      {
         get{ return wHPP_UDEF2_IsChanged; }
         set{ wHPP_UDEF2_IsChanged = value; }
      }
      private string wHPP_UDEF3;
      private bool wHPP_UDEF3_IsChanged=false;
      public string WHPP_UDEF3
      {
         get{ return wHPP_UDEF3; }
         set{ wHPP_UDEF3 = value; wHPP_UDEF3_IsChanged=true; }
      }
      public bool WHPP_UDEF3_IsChanged
      {
         get{ return wHPP_UDEF3_IsChanged; }
         set{ wHPP_UDEF3_IsChanged = value; }
      }
      private string wHPP_UDEF4;
      private bool wHPP_UDEF4_IsChanged=false;
      public string WHPP_UDEF4
      {
         get{ return wHPP_UDEF4; }
         set{ wHPP_UDEF4 = value; wHPP_UDEF4_IsChanged=true; }
      }
      public bool WHPP_UDEF4_IsChanged
      {
         get{ return wHPP_UDEF4_IsChanged; }
         set{ wHPP_UDEF4_IsChanged = value; }
      }
      private string wHPP_UDEF5;
      private bool wHPP_UDEF5_IsChanged=false;
      public string WHPP_UDEF5
      {
         get{ return wHPP_UDEF5; }
         set{ wHPP_UDEF5 = value; wHPP_UDEF5_IsChanged=true; }
      }
      public bool WHPP_UDEF5_IsChanged
      {
         get{ return wHPP_UDEF5_IsChanged; }
         set{ wHPP_UDEF5_IsChanged = value; }
      }
      private string wHPP_UDEF6;
      private bool wHPP_UDEF6_IsChanged=false;
      public string WHPP_UDEF6
      {
         get{ return wHPP_UDEF6; }
         set{ wHPP_UDEF6 = value; wHPP_UDEF6_IsChanged=true; }
      }
      public bool WHPP_UDEF6_IsChanged
      {
         get{ return wHPP_UDEF6_IsChanged; }
         set{ wHPP_UDEF6_IsChanged = value; }
      }
      private string wHPP_UDEF7;
      private bool wHPP_UDEF7_IsChanged=false;
      public string WHPP_UDEF7
      {
         get{ return wHPP_UDEF7; }
         set{ wHPP_UDEF7 = value; wHPP_UDEF7_IsChanged=true; }
      }
      public bool WHPP_UDEF7_IsChanged
      {
         get{ return wHPP_UDEF7_IsChanged; }
         set{ wHPP_UDEF7_IsChanged = value; }
      }
      private string wHPP_UDEF8;
      private bool wHPP_UDEF8_IsChanged=false;
      public string WHPP_UDEF8
      {
         get{ return wHPP_UDEF8; }
         set{ wHPP_UDEF8 = value; wHPP_UDEF8_IsChanged=true; }
      }
      public bool WHPP_UDEF8_IsChanged
      {
         get{ return wHPP_UDEF8_IsChanged; }
         set{ wHPP_UDEF8_IsChanged = value; }
      }
      private string wHPP_UDEF9;
      private bool wHPP_UDEF9_IsChanged=false;
      public string WHPP_UDEF9
      {
         get{ return wHPP_UDEF9; }
         set{ wHPP_UDEF9 = value; wHPP_UDEF9_IsChanged=true; }
      }
      public bool WHPP_UDEF9_IsChanged
      {
         get{ return wHPP_UDEF9_IsChanged; }
         set{ wHPP_UDEF9_IsChanged = value; }
      }
      private string wHPP_UDEF10;
      private bool wHPP_UDEF10_IsChanged=false;
      public string WHPP_UDEF10
      {
         get{ return wHPP_UDEF10; }
         set{ wHPP_UDEF10 = value; wHPP_UDEF10_IsChanged=true; }
      }
      public bool WHPP_UDEF10_IsChanged
      {
         get{ return wHPP_UDEF10_IsChanged; }
         set{ wHPP_UDEF10_IsChanged = value; }
      }
      private decimal wHPP_RelSum;
      private bool wHPP_RelSum_IsChanged=false;
      public decimal WHPP_RelSum
      {
         get{ return wHPP_RelSum; }
         set{ wHPP_RelSum = value; wHPP_RelSum_IsChanged=true; }
      }
      public bool WHPP_RelSum_IsChanged
      {
         get{ return wHPP_RelSum_IsChanged; }
         set{ wHPP_RelSum_IsChanged = value; }
      }
      private decimal wHPP_Pay;
      private bool wHPP_Pay_IsChanged=false;
      public decimal WHPP_Pay
      {
         get{ return wHPP_Pay; }
         set{ wHPP_Pay = value; wHPP_Pay_IsChanged=true; }
      }
      public bool WHPP_Pay_IsChanged
      {
         get{ return wHPP_Pay_IsChanged; }
         set{ wHPP_Pay_IsChanged = value; }
      }
      private string auditStat;
      private bool auditStat_IsChanged=false;
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      private string auditCurAudit;
      private bool auditCurAudit_IsChanged=false;
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
      }
   }
}
