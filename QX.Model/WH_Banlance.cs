using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 结算单
   /// </summary>
   [Serializable]
   public partial class WH_Banlance
   {
      /// <summary>
      /// 结算单序号
      /// </summary>
      private decimal wHB_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_ID_IsChanged=false;
      /// <summary>
      /// 结算单序号
      /// </summary>
      public decimal WHB_ID
      {
         get{ return wHB_ID; }
         set{ wHB_ID = value; wHB_ID_IsChanged=true; }
      }
      /// <summary>
      /// 结算单序号
      /// </summary>
      public bool WHB_ID_IsChanged
      {
         get{ return wHB_ID_IsChanged; }
         set{ wHB_ID_IsChanged = value; }
      }
      /// <summary>
      /// 账期
      /// </summary>
      private string wHB_Period;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_Period_IsChanged=false;
      /// <summary>
      /// 账期
      /// </summary>
      public string WHB_Period
      {
         get{ return wHB_Period; }
         set{ wHB_Period = value; wHB_Period_IsChanged=true; }
      }
      /// <summary>
      /// 账期
      /// </summary>
      public bool WHB_Period_IsChanged
      {
         get{ return wHB_Period_IsChanged; }
         set{ wHB_Period_IsChanged = value; }
      }
      /// <summary>
      /// 结算单据类型
      /// </summary>
      private string wHB_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_iType_IsChanged=false;
      /// <summary>
      /// 结算单据类型
      /// </summary>
      public string WHB_iType
      {
         get{ return wHB_iType; }
         set{ wHB_iType = value; wHB_iType_IsChanged=true; }
      }
      /// <summary>
      /// 结算单据类型
      /// </summary>
      public bool WHB_iType_IsChanged
      {
         get{ return wHB_iType_IsChanged; }
         set{ wHB_iType_IsChanged = value; }
      }
      /// <summary>
      /// 结算单编码
      /// </summary>
      private string wHB_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_Code_IsChanged=false;
      /// <summary>
      /// 结算单编码
      /// </summary>
      public string WHB_Code
      {
         get{ return wHB_Code; }
         set{ wHB_Code = value; wHB_Code_IsChanged=true; }
      }
      /// <summary>
      /// 结算单编码
      /// </summary>
      public bool WHB_Code_IsChanged
      {
         get{ return wHB_Code_IsChanged; }
         set{ wHB_Code_IsChanged = value; }
      }
      private string wHB_UCompany;
      private bool wHB_UCompany_IsChanged=false;
      public string WHB_UCompany
      {
         get{ return wHB_UCompany; }
         set{ wHB_UCompany = value; wHB_UCompany_IsChanged=true; }
      }
      public bool WHB_UCompany_IsChanged
      {
         get{ return wHB_UCompany_IsChanged; }
         set{ wHB_UCompany_IsChanged = value; }
      }
      private string wHB_UCompanyCode;
      private bool wHB_UCompanyCode_IsChanged=false;
      public string WHB_UCompanyCode
      {
         get{ return wHB_UCompanyCode; }
         set{ wHB_UCompanyCode = value; wHB_UCompanyCode_IsChanged=true; }
      }
      public bool WHB_UCompanyCode_IsChanged
      {
         get{ return wHB_UCompanyCode_IsChanged; }
         set{ wHB_UCompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string wHB_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_SCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string WHB_SCode
      {
         get{ return wHB_SCode; }
         set{ wHB_SCode = value; wHB_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool WHB_SCode_IsChanged
      {
         get{ return wHB_SCode_IsChanged; }
         set{ wHB_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      private string wHB_SName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_SName_IsChanged=false;
      /// <summary>
      /// 供应商名称
      /// </summary>
      public string WHB_SName
      {
         get{ return wHB_SName; }
         set{ wHB_SName = value; wHB_SName_IsChanged=true; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      public bool WHB_SName_IsChanged
      {
         get{ return wHB_SName_IsChanged; }
         set{ wHB_SName_IsChanged = value; }
      }
      /// <summary>
      /// 上月结余
      /// </summary>
      private decimal wHB_LastMonth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_LastMonth_IsChanged=false;
      /// <summary>
      /// 上月结余
      /// </summary>
      public decimal WHB_LastMonth
      {
         get{ return wHB_LastMonth; }
         set{ wHB_LastMonth = value; wHB_LastMonth_IsChanged=true; }
      }
      /// <summary>
      /// 上月结余
      /// </summary>
      public bool WHB_LastMonth_IsChanged
      {
         get{ return wHB_LastMonth_IsChanged; }
         set{ wHB_LastMonth_IsChanged = value; }
      }
      /// <summary>
      /// 本月供货
      /// </summary>
      private decimal wHB_CurMonth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_CurMonth_IsChanged=false;
      /// <summary>
      /// 本月供货
      /// </summary>
      public decimal WHB_CurMonth
      {
         get{ return wHB_CurMonth; }
         set{ wHB_CurMonth = value; wHB_CurMonth_IsChanged=true; }
      }
      /// <summary>
      /// 本月供货
      /// </summary>
      public bool WHB_CurMonth_IsChanged
      {
         get{ return wHB_CurMonth_IsChanged; }
         set{ wHB_CurMonth_IsChanged = value; }
      }
      private decimal wHB_CurPay;
      private bool wHB_CurPay_IsChanged=false;
      public decimal WHB_CurPay
      {
         get{ return wHB_CurPay; }
         set{ wHB_CurPay = value; wHB_CurPay_IsChanged=true; }
      }
      public bool WHB_CurPay_IsChanged
      {
         get{ return wHB_CurPay_IsChanged; }
         set{ wHB_CurPay_IsChanged = value; }
      }
      private decimal wHB_CurLeft;
      private bool wHB_CurLeft_IsChanged=false;
      public decimal WHB_CurLeft
      {
         get{ return wHB_CurLeft; }
         set{ wHB_CurLeft = value; wHB_CurLeft_IsChanged=true; }
      }
      public bool WHB_CurLeft_IsChanged
      {
         get{ return wHB_CurLeft_IsChanged; }
         set{ wHB_CurLeft_IsChanged = value; }
      }
      private decimal wHB_Plan;
      private bool wHB_Plan_IsChanged=false;
      public decimal WHB_Plan
      {
         get{ return wHB_Plan; }
         set{ wHB_Plan = value; wHB_Plan_IsChanged=true; }
      }
      public bool WHB_Plan_IsChanged
      {
         get{ return wHB_Plan_IsChanged; }
         set{ wHB_Plan_IsChanged = value; }
      }
      /// <summary>
      /// 本月结余
      /// </summary>
      private decimal wHB_NextMonth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_NextMonth_IsChanged=false;
      /// <summary>
      /// 本月结余
      /// </summary>
      public decimal WHB_NextMonth
      {
         get{ return wHB_NextMonth; }
         set{ wHB_NextMonth = value; wHB_NextMonth_IsChanged=true; }
      }
      /// <summary>
      /// 本月结余
      /// </summary>
      public bool WHB_NextMonth_IsChanged
      {
         get{ return wHB_NextMonth_IsChanged; }
         set{ wHB_NextMonth_IsChanged = value; }
      }
      private decimal wHB_broom;
      private bool wHB_broom_IsChanged=false;
      public decimal WHB_broom
      {
         get{ return wHB_broom; }
         set{ wHB_broom = value; wHB_broom_IsChanged=true; }
      }
      public bool WHB_broom_IsChanged
      {
         get{ return wHB_broom_IsChanged; }
         set{ wHB_broom_IsChanged = value; }
      }
      private decimal wHB_Recive;
      private bool wHB_Recive_IsChanged=false;
      public decimal WHB_Recive
      {
         get{ return wHB_Recive; }
         set{ wHB_Recive = value; wHB_Recive_IsChanged=true; }
      }
      public bool WHB_Recive_IsChanged
      {
         get{ return wHB_Recive_IsChanged; }
         set{ wHB_Recive_IsChanged = value; }
      }
      /// <summary>
      /// 结算日期
      /// </summary>
      private DateTime wHB_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHB_Date_IsChanged=false;
      /// <summary>
      /// 结算日期
      /// </summary>
      public DateTime WHB_Date
      {
         get{ return wHB_Date; }
         set{ wHB_Date = value; wHB_Date_IsChanged=true; }
      }
      /// <summary>
      /// 结算日期
      /// </summary>
      public bool WHB_Date_IsChanged
      {
         get{ return wHB_Date_IsChanged; }
         set{ wHB_Date_IsChanged = value; }
      }
      private string wHB_Status;
      private bool wHB_Status_IsChanged=false;
      public string WHB_Status
      {
         get{ return wHB_Status; }
         set{ wHB_Status = value; wHB_Status_IsChanged=true; }
      }
      public bool WHB_Status_IsChanged
      {
         get{ return wHB_Status_IsChanged; }
         set{ wHB_Status_IsChanged = value; }
      }
      private string wHB_UDEF1;
      private bool wHB_UDEF1_IsChanged=false;
      public string WHB_UDEF1
      {
         get{ return wHB_UDEF1; }
         set{ wHB_UDEF1 = value; wHB_UDEF1_IsChanged=true; }
      }
      public bool WHB_UDEF1_IsChanged
      {
         get{ return wHB_UDEF1_IsChanged; }
         set{ wHB_UDEF1_IsChanged = value; }
      }
      private string wHB_UDEF2;
      private bool wHB_UDEF2_IsChanged=false;
      public string WHB_UDEF2
      {
         get{ return wHB_UDEF2; }
         set{ wHB_UDEF2 = value; wHB_UDEF2_IsChanged=true; }
      }
      public bool WHB_UDEF2_IsChanged
      {
         get{ return wHB_UDEF2_IsChanged; }
         set{ wHB_UDEF2_IsChanged = value; }
      }
      private string wHB_UDEF3;
      private bool wHB_UDEF3_IsChanged=false;
      public string WHB_UDEF3
      {
         get{ return wHB_UDEF3; }
         set{ wHB_UDEF3 = value; wHB_UDEF3_IsChanged=true; }
      }
      public bool WHB_UDEF3_IsChanged
      {
         get{ return wHB_UDEF3_IsChanged; }
         set{ wHB_UDEF3_IsChanged = value; }
      }
      private string wHB_UDEF4;
      private bool wHB_UDEF4_IsChanged=false;
      public string WHB_UDEF4
      {
         get{ return wHB_UDEF4; }
         set{ wHB_UDEF4 = value; wHB_UDEF4_IsChanged=true; }
      }
      public bool WHB_UDEF4_IsChanged
      {
         get{ return wHB_UDEF4_IsChanged; }
         set{ wHB_UDEF4_IsChanged = value; }
      }
      private string wHB_UDEF5;
      private bool wHB_UDEF5_IsChanged=false;
      public string WHB_UDEF5
      {
         get{ return wHB_UDEF5; }
         set{ wHB_UDEF5 = value; wHB_UDEF5_IsChanged=true; }
      }
      public bool WHB_UDEF5_IsChanged
      {
         get{ return wHB_UDEF5_IsChanged; }
         set{ wHB_UDEF5_IsChanged = value; }
      }
      private string wHB_UDEF6;
      private bool wHB_UDEF6_IsChanged=false;
      public string WHB_UDEF6
      {
         get{ return wHB_UDEF6; }
         set{ wHB_UDEF6 = value; wHB_UDEF6_IsChanged=true; }
      }
      public bool WHB_UDEF6_IsChanged
      {
         get{ return wHB_UDEF6_IsChanged; }
         set{ wHB_UDEF6_IsChanged = value; }
      }
      private string wHB_UDEF7;
      private bool wHB_UDEF7_IsChanged=false;
      public string WHB_UDEF7
      {
         get{ return wHB_UDEF7; }
         set{ wHB_UDEF7 = value; wHB_UDEF7_IsChanged=true; }
      }
      public bool WHB_UDEF7_IsChanged
      {
         get{ return wHB_UDEF7_IsChanged; }
         set{ wHB_UDEF7_IsChanged = value; }
      }
      private string wHB_UDEF8;
      private bool wHB_UDEF8_IsChanged=false;
      public string WHB_UDEF8
      {
         get{ return wHB_UDEF8; }
         set{ wHB_UDEF8 = value; wHB_UDEF8_IsChanged=true; }
      }
      public bool WHB_UDEF8_IsChanged
      {
         get{ return wHB_UDEF8_IsChanged; }
         set{ wHB_UDEF8_IsChanged = value; }
      }
      private string wHB_UDEF9;
      private bool wHB_UDEF9_IsChanged=false;
      public string WHB_UDEF9
      {
         get{ return wHB_UDEF9; }
         set{ wHB_UDEF9 = value; wHB_UDEF9_IsChanged=true; }
      }
      public bool WHB_UDEF9_IsChanged
      {
         get{ return wHB_UDEF9_IsChanged; }
         set{ wHB_UDEF9_IsChanged = value; }
      }
      private string wHB_UDEF10;
      private bool wHB_UDEF10_IsChanged=false;
      public string WHB_UDEF10
      {
         get{ return wHB_UDEF10; }
         set{ wHB_UDEF10 = value; wHB_UDEF10_IsChanged=true; }
      }
      public bool WHB_UDEF10_IsChanged
      {
         get{ return wHB_UDEF10_IsChanged; }
         set{ wHB_UDEF10_IsChanged = value; }
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
      private decimal wHB_Invoice;
      private bool wHB_Invoice_IsChanged=false;
      public decimal WHB_Invoice
      {
         get{ return wHB_Invoice; }
         set{ wHB_Invoice = value; wHB_Invoice_IsChanged=true; }
      }
      public bool WHB_Invoice_IsChanged
      {
         get{ return wHB_Invoice_IsChanged; }
         set{ wHB_Invoice_IsChanged = value; }
      }
      private decimal wHB_Pay;
      private bool wHB_Pay_IsChanged=false;
      public decimal WHB_Pay
      {
         get{ return wHB_Pay; }
         set{ wHB_Pay = value; wHB_Pay_IsChanged=true; }
      }
      public bool WHB_Pay_IsChanged
      {
         get{ return wHB_Pay_IsChanged; }
         set{ wHB_Pay_IsChanged = value; }
      }
      private decimal wHB_RInvoice;
      private bool wHB_RInvoice_IsChanged=false;
      public decimal WHB_RInvoice
      {
         get{ return wHB_RInvoice; }
         set{ wHB_RInvoice = value; wHB_RInvoice_IsChanged=true; }
      }
      public bool WHB_RInvoice_IsChanged
      {
         get{ return wHB_RInvoice_IsChanged; }
         set{ wHB_RInvoice_IsChanged = value; }
      }
      private decimal wHB_RPay;
      private bool wHB_RPay_IsChanged=false;
      public decimal WHB_RPay
      {
         get{ return wHB_RPay; }
         set{ wHB_RPay = value; wHB_RPay_IsChanged=true; }
      }
      public bool WHB_RPay_IsChanged
      {
         get{ return wHB_RPay_IsChanged; }
         set{ wHB_RPay_IsChanged = value; }
      }
      private decimal wHB_NumLast;
      private bool wHB_NumLast_IsChanged=false;
      public decimal WHB_NumLast
      {
         get{ return wHB_NumLast; }
         set{ wHB_NumLast = value; wHB_NumLast_IsChanged=true; }
      }
      public bool WHB_NumLast_IsChanged
      {
         get{ return wHB_NumLast_IsChanged; }
         set{ wHB_NumLast_IsChanged = value; }
      }
      private decimal wHB_NumCur;
      private bool wHB_NumCur_IsChanged=false;
      public decimal WHB_NumCur
      {
         get{ return wHB_NumCur; }
         set{ wHB_NumCur = value; wHB_NumCur_IsChanged=true; }
      }
      public bool WHB_NumCur_IsChanged
      {
         get{ return wHB_NumCur_IsChanged; }
         set{ wHB_NumCur_IsChanged = value; }
      }
      private decimal wHB_NumReturn;
      private bool wHB_NumReturn_IsChanged=false;
      public decimal WHB_NumReturn
      {
         get{ return wHB_NumReturn; }
         set{ wHB_NumReturn = value; wHB_NumReturn_IsChanged=true; }
      }
      public bool WHB_NumReturn_IsChanged
      {
         get{ return wHB_NumReturn_IsChanged; }
         set{ wHB_NumReturn_IsChanged = value; }
      }
      private decimal wHB_NumReal;
      private bool wHB_NumReal_IsChanged=false;
      public decimal WHB_NumReal
      {
         get{ return wHB_NumReal; }
         set{ wHB_NumReal = value; wHB_NumReal_IsChanged=true; }
      }
      public bool WHB_NumReal_IsChanged
      {
         get{ return wHB_NumReal_IsChanged; }
         set{ wHB_NumReal_IsChanged = value; }
      }
   }
}
