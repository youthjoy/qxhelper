using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 客户发票
   /// </summary>
   [Serializable]
   public partial class SD_Invoice
   {
      /// <summary>
      /// 开票通知记录序号
      /// </summary>
      private decimal sDCI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_ID_IsChanged=false;
      /// <summary>
      /// 开票通知记录序号
      /// </summary>
      public decimal SDCI_ID
      {
         get{ return sDCI_ID; }
         set{ sDCI_ID = value; sDCI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 开票通知记录序号
      /// </summary>
      public bool SDCI_ID_IsChanged
      {
         get{ return sDCI_ID_IsChanged; }
         set{ sDCI_ID_IsChanged = value; }
      }
      /// <summary>
      /// 开票通知记录编码
      /// </summary>
      private string sDCI_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_Code_IsChanged=false;
      /// <summary>
      /// 开票通知记录编码
      /// </summary>
      public string SDCI_Code
      {
         get{ return sDCI_Code; }
         set{ sDCI_Code = value; sDCI_Code_IsChanged=true; }
      }
      /// <summary>
      /// 开票通知记录编码
      /// </summary>
      public bool SDCI_Code_IsChanged
      {
         get{ return sDCI_Code_IsChanged; }
         set{ sDCI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 开票类别
      /// </summary>
      private string sDCI_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_Type_IsChanged=false;
      /// <summary>
      /// 开票类别
      /// </summary>
      public string SDCI_Type
      {
         get{ return sDCI_Type; }
         set{ sDCI_Type = value; sDCI_Type_IsChanged=true; }
      }
      /// <summary>
      /// 开票类别
      /// </summary>
      public bool SDCI_Type_IsChanged
      {
         get{ return sDCI_Type_IsChanged; }
         set{ sDCI_Type_IsChanged = value; }
      }
      /// <summary>
      /// 开票时间
      /// </summary>
      private DateTime sDCI_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_Date_IsChanged=false;
      /// <summary>
      /// 开票时间
      /// </summary>
      public DateTime SDCI_Date
      {
         get{ return sDCI_Date; }
         set{ sDCI_Date = value; sDCI_Date_IsChanged=true; }
      }
      /// <summary>
      /// 开票时间
      /// </summary>
      public bool SDCI_Date_IsChanged
      {
         get{ return sDCI_Date_IsChanged; }
         set{ sDCI_Date_IsChanged = value; }
      }
      /// <summary>
      /// 开票单位
      /// </summary>
      private string sDCI_IName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_IName_IsChanged=false;
      /// <summary>
      /// 开票单位
      /// </summary>
      public string SDCI_IName
      {
         get{ return sDCI_IName; }
         set{ sDCI_IName = value; sDCI_IName_IsChanged=true; }
      }
      /// <summary>
      /// 开票单位
      /// </summary>
      public bool SDCI_IName_IsChanged
      {
         get{ return sDCI_IName_IsChanged; }
         set{ sDCI_IName_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string sDCI_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string SDCI_CCode
      {
         get{ return sDCI_CCode; }
         set{ sDCI_CCode = value; sDCI_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool SDCI_CCode_IsChanged
      {
         get{ return sDCI_CCode_IsChanged; }
         set{ sDCI_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      private string sDCI_CName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_CName_IsChanged=false;
      /// <summary>
      /// 客户名称
      /// </summary>
      public string SDCI_CName
      {
         get{ return sDCI_CName; }
         set{ sDCI_CName = value; sDCI_CName_IsChanged=true; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      public bool SDCI_CName_IsChanged
      {
         get{ return sDCI_CName_IsChanged; }
         set{ sDCI_CName_IsChanged = value; }
      }
      /// <summary>
      /// 税号
      /// </summary>
      private string sDCI_TaxNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_TaxNo_IsChanged=false;
      /// <summary>
      /// 税号
      /// </summary>
      public string SDCI_TaxNo
      {
         get{ return sDCI_TaxNo; }
         set{ sDCI_TaxNo = value; sDCI_TaxNo_IsChanged=true; }
      }
      /// <summary>
      /// 税号
      /// </summary>
      public bool SDCI_TaxNo_IsChanged
      {
         get{ return sDCI_TaxNo_IsChanged; }
         set{ sDCI_TaxNo_IsChanged = value; }
      }
      /// <summary>
      /// 销售经办人
      /// </summary>
      private string sDCI_SOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_SOwner_IsChanged=false;
      /// <summary>
      /// 销售经办人
      /// </summary>
      public string SDCI_SOwner
      {
         get{ return sDCI_SOwner; }
         set{ sDCI_SOwner = value; sDCI_SOwner_IsChanged=true; }
      }
      /// <summary>
      /// 销售经办人
      /// </summary>
      public bool SDCI_SOwner_IsChanged
      {
         get{ return sDCI_SOwner_IsChanged; }
         set{ sDCI_SOwner_IsChanged = value; }
      }
      /// <summary>
      /// 财务开票人
      /// </summary>
      private string sDCI_FOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_FOwner_IsChanged=false;
      /// <summary>
      /// 财务开票人
      /// </summary>
      public string SDCI_FOwner
      {
         get{ return sDCI_FOwner; }
         set{ sDCI_FOwner = value; sDCI_FOwner_IsChanged=true; }
      }
      /// <summary>
      /// 财务开票人
      /// </summary>
      public bool SDCI_FOwner_IsChanged
      {
         get{ return sDCI_FOwner_IsChanged; }
         set{ sDCI_FOwner_IsChanged = value; }
      }
      /// <summary>
      /// 是否开票
      /// </summary>
      private string sDCI_IsInvoice;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_IsInvoice_IsChanged=false;
      /// <summary>
      /// 是否开票
      /// </summary>
      public string SDCI_IsInvoice
      {
         get{ return sDCI_IsInvoice; }
         set{ sDCI_IsInvoice = value; sDCI_IsInvoice_IsChanged=true; }
      }
      /// <summary>
      /// 是否开票
      /// </summary>
      public bool SDCI_IsInvoice_IsChanged
      {
         get{ return sDCI_IsInvoice_IsChanged; }
         set{ sDCI_IsInvoice_IsChanged = value; }
      }
      /// <summary>
      /// 关联合同编码
      /// </summary>
      private string sDCI_RefContract;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_RefContract_IsChanged=false;
      /// <summary>
      /// 关联合同编码
      /// </summary>
      public string SDCI_RefContract
      {
         get{ return sDCI_RefContract; }
         set{ sDCI_RefContract = value; sDCI_RefContract_IsChanged=true; }
      }
      /// <summary>
      /// 关联合同编码
      /// </summary>
      public bool SDCI_RefContract_IsChanged
      {
         get{ return sDCI_RefContract_IsChanged; }
         set{ sDCI_RefContract_IsChanged = value; }
      }
      /// <summary>
      /// 开票金额
      /// </summary>
      private decimal sDCI_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_Num_IsChanged=false;
      /// <summary>
      /// 开票金额
      /// </summary>
      public decimal SDCI_Num
      {
         get{ return sDCI_Num; }
         set{ sDCI_Num = value; sDCI_Num_IsChanged=true; }
      }
      /// <summary>
      /// 开票金额
      /// </summary>
      public bool SDCI_Num_IsChanged
      {
         get{ return sDCI_Num_IsChanged; }
         set{ sDCI_Num_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDCI_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDCI_Bak
      {
         get{ return sDCI_Bak; }
         set{ sDCI_Bak = value; sDCI_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDCI_Bak_IsChanged
      {
         get{ return sDCI_Bak_IsChanged; }
         set{ sDCI_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      private string sDCI_RefType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_RefType_IsChanged=false;
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public string SDCI_RefType
      {
         get{ return sDCI_RefType; }
         set{ sDCI_RefType = value; sDCI_RefType_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public bool SDCI_RefType_IsChanged
      {
         get{ return sDCI_RefType_IsChanged; }
         set{ sDCI_RefType_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      private string sDCI_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_RefCode_IsChanged=false;
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public string SDCI_RefCode
      {
         get{ return sDCI_RefCode; }
         set{ sDCI_RefCode = value; sDCI_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public bool SDCI_RefCode_IsChanged
      {
         get{ return sDCI_RefCode_IsChanged; }
         set{ sDCI_RefCode_IsChanged = value; }
      }
      /// <summary>
      /// 开票状态
      /// </summary>
      private string sDCI_Status;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDCI_Status_IsChanged=false;
      /// <summary>
      /// 开票状态
      /// </summary>
      public string SDCI_Status
      {
         get{ return sDCI_Status; }
         set{ sDCI_Status = value; sDCI_Status_IsChanged=true; }
      }
      /// <summary>
      /// 开票状态
      /// </summary>
      public bool SDCI_Status_IsChanged
      {
         get{ return sDCI_Status_IsChanged; }
         set{ sDCI_Status_IsChanged = value; }
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
      private string sDCI_Company;
      private bool sDCI_Company_IsChanged=false;
      public string SDCI_Company
      {
         get{ return sDCI_Company; }
         set{ sDCI_Company = value; sDCI_Company_IsChanged=true; }
      }
      public bool SDCI_Company_IsChanged
      {
         get{ return sDCI_Company_IsChanged; }
         set{ sDCI_Company_IsChanged = value; }
      }
      private string sDCI_CompanyCode;
      private bool sDCI_CompanyCode_IsChanged=false;
      public string SDCI_CompanyCode
      {
         get{ return sDCI_CompanyCode; }
         set{ sDCI_CompanyCode = value; sDCI_CompanyCode_IsChanged=true; }
      }
      public bool SDCI_CompanyCode_IsChanged
      {
         get{ return sDCI_CompanyCode_IsChanged; }
         set{ sDCI_CompanyCode_IsChanged = value; }
      }
   }
}
