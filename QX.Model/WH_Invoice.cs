using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 供应商发票信息
   /// </summary>
   [Serializable]
   public partial class WH_Invoice
   {
      /// <summary>
      /// 发票序号
      /// </summary>
      private decimal wHI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_ID_IsChanged=false;
      /// <summary>
      /// 发票序号
      /// </summary>
      public decimal WHI_ID
      {
         get{ return wHI_ID; }
         set{ wHI_ID = value; wHI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 发票序号
      /// </summary>
      public bool WHI_ID_IsChanged
      {
         get{ return wHI_ID_IsChanged; }
         set{ wHI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 发票编码
      /// </summary>
      private string wHI_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_Code_IsChanged=false;
      /// <summary>
      /// 发票编码
      /// </summary>
      public string WHI_Code
      {
         get{ return wHI_Code; }
         set{ wHI_Code = value; wHI_Code_IsChanged=true; }
      }
      /// <summary>
      /// 发票编码
      /// </summary>
      public bool WHI_Code_IsChanged
      {
         get{ return wHI_Code_IsChanged; }
         set{ wHI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string wHI_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_SCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string WHI_SCode
      {
         get{ return wHI_SCode; }
         set{ wHI_SCode = value; wHI_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool WHI_SCode_IsChanged
      {
         get{ return wHI_SCode_IsChanged; }
         set{ wHI_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      private string wHI_SName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_SName_IsChanged=false;
      /// <summary>
      /// 供应商名称
      /// </summary>
      public string WHI_SName
      {
         get{ return wHI_SName; }
         set{ wHI_SName = value; wHI_SName_IsChanged=true; }
      }
      /// <summary>
      /// 供应商名称
      /// </summary>
      public bool WHI_SName_IsChanged
      {
         get{ return wHI_SName_IsChanged; }
         set{ wHI_SName_IsChanged = value; }
      }
      /// <summary>
      /// 发票名称
      /// </summary>
      private string wHI_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_Name_IsChanged=false;
      /// <summary>
      /// 发票名称
      /// </summary>
      public string WHI_Name
      {
         get{ return wHI_Name; }
         set{ wHI_Name = value; wHI_Name_IsChanged=true; }
      }
      /// <summary>
      /// 发票名称
      /// </summary>
      public bool WHI_Name_IsChanged
      {
         get{ return wHI_Name_IsChanged; }
         set{ wHI_Name_IsChanged = value; }
      }
      /// <summary>
      /// 发票金额
      /// </summary>
      private double wHI_Sum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_Sum_IsChanged=false;
      /// <summary>
      /// 发票金额
      /// </summary>
      public double WHI_Sum
      {
         get{ return wHI_Sum; }
         set{ wHI_Sum = value; wHI_Sum_IsChanged=true; }
      }
      /// <summary>
      /// 发票金额
      /// </summary>
      public bool WHI_Sum_IsChanged
      {
         get{ return wHI_Sum_IsChanged; }
         set{ wHI_Sum_IsChanged = value; }
      }
      /// <summary>
      /// 发票编号
      /// </summary>
      private string wHI_Number;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_Number_IsChanged=false;
      /// <summary>
      /// 发票编号
      /// </summary>
      public string WHI_Number
      {
         get{ return wHI_Number; }
         set{ wHI_Number = value; wHI_Number_IsChanged=true; }
      }
      /// <summary>
      /// 发票编号
      /// </summary>
      public bool WHI_Number_IsChanged
      {
         get{ return wHI_Number_IsChanged; }
         set{ wHI_Number_IsChanged = value; }
      }
      /// <summary>
      /// 开票日期
      /// </summary>
      private DateTime wHI_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_Date_IsChanged=false;
      /// <summary>
      /// 开票日期
      /// </summary>
      public DateTime WHI_Date
      {
         get{ return wHI_Date; }
         set{ wHI_Date = value; wHI_Date_IsChanged=true; }
      }
      /// <summary>
      /// 开票日期
      /// </summary>
      public bool WHI_Date_IsChanged
      {
         get{ return wHI_Date_IsChanged; }
         set{ wHI_Date_IsChanged = value; }
      }
      /// <summary>
      /// 采购经手人
      /// </summary>
      private string wHI_ProcMan;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_ProcMan_IsChanged=false;
      /// <summary>
      /// 采购经手人
      /// </summary>
      public string WHI_ProcMan
      {
         get{ return wHI_ProcMan; }
         set{ wHI_ProcMan = value; wHI_ProcMan_IsChanged=true; }
      }
      /// <summary>
      /// 采购经手人
      /// </summary>
      public bool WHI_ProcMan_IsChanged
      {
         get{ return wHI_ProcMan_IsChanged; }
         set{ wHI_ProcMan_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string wHI_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string WHI_Bak
      {
         get{ return wHI_Bak; }
         set{ wHI_Bak = value; wHI_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool WHI_Bak_IsChanged
      {
         get{ return wHI_Bak_IsChanged; }
         set{ wHI_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      private string wHI_CType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_CType_IsChanged=false;
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public string WHI_CType
      {
         get{ return wHI_CType; }
         set{ wHI_CType = value; wHI_CType_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public bool WHI_CType_IsChanged
      {
         get{ return wHI_CType_IsChanged; }
         set{ wHI_CType_IsChanged = value; }
      }
      /// <summary>
      /// 关联结算单据
      /// </summary>
      private string wHI_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_CCode_IsChanged=false;
      /// <summary>
      /// 关联结算单据
      /// </summary>
      public string WHI_CCode
      {
         get{ return wHI_CCode; }
         set{ wHI_CCode = value; wHI_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 关联结算单据
      /// </summary>
      public bool WHI_CCode_IsChanged
      {
         get{ return wHI_CCode_IsChanged; }
         set{ wHI_CCode_IsChanged = value; }
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
      /// 支付状态
      /// </summary>
      private string wHI_PayStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_PayStat_IsChanged=false;
      /// <summary>
      /// 支付状态
      /// </summary>
      public string WHI_PayStat
      {
         get{ return wHI_PayStat; }
         set{ wHI_PayStat = value; wHI_PayStat_IsChanged=true; }
      }
      /// <summary>
      /// 支付状态
      /// </summary>
      public bool WHI_PayStat_IsChanged
      {
         get{ return wHI_PayStat_IsChanged; }
         set{ wHI_PayStat_IsChanged = value; }
      }
      /// <summary>
      /// 付款单编码
      /// </summary>
      private string wHI_PayCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_PayCode_IsChanged=false;
      /// <summary>
      /// 付款单编码
      /// </summary>
      public string WHI_PayCode
      {
         get{ return wHI_PayCode; }
         set{ wHI_PayCode = value; wHI_PayCode_IsChanged=true; }
      }
      /// <summary>
      /// 付款单编码
      /// </summary>
      public bool WHI_PayCode_IsChanged
      {
         get{ return wHI_PayCode_IsChanged; }
         set{ wHI_PayCode_IsChanged = value; }
      }
      /// <summary>
      /// 供应商经手人
      /// </summary>
      private string wHI_SProcMan;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHI_SProcMan_IsChanged=false;
      /// <summary>
      /// 供应商经手人
      /// </summary>
      public string WHI_SProcMan
      {
         get{ return wHI_SProcMan; }
         set{ wHI_SProcMan = value; wHI_SProcMan_IsChanged=true; }
      }
      /// <summary>
      /// 供应商经手人
      /// </summary>
      public bool WHI_SProcMan_IsChanged
      {
         get{ return wHI_SProcMan_IsChanged; }
         set{ wHI_SProcMan_IsChanged = value; }
      }
      private string wHI_Company;
      private bool wHI_Company_IsChanged=false;
      public string WHI_Company
      {
         get{ return wHI_Company; }
         set{ wHI_Company = value; wHI_Company_IsChanged=true; }
      }
      public bool WHI_Company_IsChanged
      {
         get{ return wHI_Company_IsChanged; }
         set{ wHI_Company_IsChanged = value; }
      }
      private string wHI_CompanyCode;
      private bool wHI_CompanyCode_IsChanged=false;
      public string WHI_CompanyCode
      {
         get{ return wHI_CompanyCode; }
         set{ wHI_CompanyCode = value; wHI_CompanyCode_IsChanged=true; }
      }
      public bool WHI_CompanyCode_IsChanged
      {
         get{ return wHI_CompanyCode_IsChanged; }
         set{ wHI_CompanyCode_IsChanged = value; }
      }
      private decimal wHI_Pay;
      private bool wHI_Pay_IsChanged=false;
      public decimal WHI_Pay
      {
         get{ return wHI_Pay; }
         set{ wHI_Pay = value; wHI_Pay_IsChanged=true; }
      }
      public bool WHI_Pay_IsChanged
      {
         get{ return wHI_Pay_IsChanged; }
         set{ wHI_Pay_IsChanged = value; }
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
      private decimal wHI_RelSum;
      private bool wHI_RelSum_IsChanged=false;
      public decimal WHI_RelSum
      {
         get{ return wHI_RelSum; }
         set{ wHI_RelSum = value; wHI_RelSum_IsChanged=true; }
      }
      public bool WHI_RelSum_IsChanged
      {
         get{ return wHI_RelSum_IsChanged; }
         set{ wHI_RelSum_IsChanged = value; }
      }
   }
}
