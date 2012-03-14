using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class PCD_Expception
   {
      private decimal pCDE_ID;
      private bool pCDE_ID_IsChanged=false;
      public decimal PCDE_ID
      {
         get{ return pCDE_ID; }
         set{ pCDE_ID = value; pCDE_ID_IsChanged=true; }
      }
      public bool PCDE_ID_IsChanged
      {
         get{ return pCDE_ID_IsChanged; }
         set{ pCDE_ID_IsChanged = value; }
      }
      private string pCDE_Code;
      private bool pCDE_Code_IsChanged=false;
      public string PCDE_Code
      {
         get{ return pCDE_Code; }
         set{ pCDE_Code = value; pCDE_Code_IsChanged=true; }
      }
      public bool PCDE_Code_IsChanged
      {
         get{ return pCDE_Code_IsChanged; }
         set{ pCDE_Code_IsChanged = value; }
      }
      /// <summary>
      /// 异常关键字
      /// </summary>
      private string pCDE_Key;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Key_IsChanged=false;
      /// <summary>
      /// 异常关键字
      /// </summary>
      public string PCDE_Key
      {
         get{ return pCDE_Key; }
         set{ pCDE_Key = value; pCDE_Key_IsChanged=true; }
      }
      /// <summary>
      /// 异常关键字
      /// </summary>
      public bool PCDE_Key_IsChanged
      {
         get{ return pCDE_Key_IsChanged; }
         set{ pCDE_Key_IsChanged = value; }
      }
      /// <summary>
      /// 异常模块编码
      /// </summary>
      private string pCDE_Module;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Module_IsChanged=false;
      /// <summary>
      /// 异常模块编码
      /// </summary>
      public string PCDE_Module
      {
         get{ return pCDE_Module; }
         set{ pCDE_Module = value; pCDE_Module_IsChanged=true; }
      }
      /// <summary>
      /// 异常模块编码
      /// </summary>
      public bool PCDE_Module_IsChanged
      {
         get{ return pCDE_Module_IsChanged; }
         set{ pCDE_Module_IsChanged = value; }
      }
      /// <summary>
      /// 异常记录类型
      /// </summary>
      private string pCDE_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Type_IsChanged=false;
      /// <summary>
      /// 异常记录类型
      /// </summary>
      public string PCDE_Type
      {
         get{ return pCDE_Type; }
         set{ pCDE_Type = value; pCDE_Type_IsChanged=true; }
      }
      /// <summary>
      /// 异常记录类型
      /// </summary>
      public bool PCDE_Type_IsChanged
      {
         get{ return pCDE_Type_IsChanged; }
         set{ pCDE_Type_IsChanged = value; }
      }
      /// <summary>
      /// 异常记录内部类型
      /// </summary>
      private string pCDE_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_iType_IsChanged=false;
      /// <summary>
      /// 异常记录内部类型
      /// </summary>
      public string PCDE_iType
      {
         get{ return pCDE_iType; }
         set{ pCDE_iType = value; pCDE_iType_IsChanged=true; }
      }
      /// <summary>
      /// 异常记录内部类型
      /// </summary>
      public bool PCDE_iType_IsChanged
      {
         get{ return pCDE_iType_IsChanged; }
         set{ pCDE_iType_IsChanged = value; }
      }
      /// <summary>
      /// 异常记录时间
      /// </summary>
      private string pCDE_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Date_IsChanged=false;
      /// <summary>
      /// 异常记录时间
      /// </summary>
      public string PCDE_Date
      {
         get{ return pCDE_Date; }
         set{ pCDE_Date = value; pCDE_Date_IsChanged=true; }
      }
      /// <summary>
      /// 异常记录时间
      /// </summary>
      public bool PCDE_Date_IsChanged
      {
         get{ return pCDE_Date_IsChanged; }
         set{ pCDE_Date_IsChanged = value; }
      }
      /// <summary>
      /// 异常记录内容
      /// </summary>
      private string pCDE_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Content_IsChanged=false;
      /// <summary>
      /// 异常记录内容
      /// </summary>
      public string PCDE_Content
      {
         get{ return pCDE_Content; }
         set{ pCDE_Content = value; pCDE_Content_IsChanged=true; }
      }
      /// <summary>
      /// 异常记录内容
      /// </summary>
      public bool PCDE_Content_IsChanged
      {
         get{ return pCDE_Content_IsChanged; }
         set{ pCDE_Content_IsChanged = value; }
      }
      /// <summary>
      /// 异常所属公司
      /// </summary>
      private string pCDE_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Company_IsChanged=false;
      /// <summary>
      /// 异常所属公司
      /// </summary>
      public string PCDE_Company
      {
         get{ return pCDE_Company; }
         set{ pCDE_Company = value; pCDE_Company_IsChanged=true; }
      }
      /// <summary>
      /// 异常所属公司
      /// </summary>
      public bool PCDE_Company_IsChanged
      {
         get{ return pCDE_Company_IsChanged; }
         set{ pCDE_Company_IsChanged = value; }
      }
      /// <summary>
      /// 异常所属生产线
      /// </summary>
      private string pCDE_PLine;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_PLine_IsChanged=false;
      /// <summary>
      /// 异常所属生产线
      /// </summary>
      public string PCDE_PLine
      {
         get{ return pCDE_PLine; }
         set{ pCDE_PLine = value; pCDE_PLine_IsChanged=true; }
      }
      /// <summary>
      /// 异常所属生产线
      /// </summary>
      public bool PCDE_PLine_IsChanged
      {
         get{ return pCDE_PLine_IsChanged; }
         set{ pCDE_PLine_IsChanged = value; }
      }
      /// <summary>
      /// 异常对象
      /// </summary>
      private string pCDE_Object;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Object_IsChanged=false;
      /// <summary>
      /// 异常对象
      /// </summary>
      public string PCDE_Object
      {
         get{ return pCDE_Object; }
         set{ pCDE_Object = value; pCDE_Object_IsChanged=true; }
      }
      /// <summary>
      /// 异常对象
      /// </summary>
      public bool PCDE_Object_IsChanged
      {
         get{ return pCDE_Object_IsChanged; }
         set{ pCDE_Object_IsChanged = value; }
      }
      /// <summary>
      /// 小票号
      /// </summary>
      private string pCDE_Ticket;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Ticket_IsChanged=false;
      /// <summary>
      /// 小票号
      /// </summary>
      public string PCDE_Ticket
      {
         get{ return pCDE_Ticket; }
         set{ pCDE_Ticket = value; pCDE_Ticket_IsChanged=true; }
      }
      /// <summary>
      /// 小票号
      /// </summary>
      public bool PCDE_Ticket_IsChanged
      {
         get{ return pCDE_Ticket_IsChanged; }
         set{ pCDE_Ticket_IsChanged = value; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      private string pCDE_BOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_BOwner_IsChanged=false;
      /// <summary>
      /// 业务负责人
      /// </summary>
      public string PCDE_BOwner
      {
         get{ return pCDE_BOwner; }
         set{ pCDE_BOwner = value; pCDE_BOwner_IsChanged=true; }
      }
      /// <summary>
      /// 业务负责人
      /// </summary>
      public bool PCDE_BOwner_IsChanged
      {
         get{ return pCDE_BOwner_IsChanged; }
         set{ pCDE_BOwner_IsChanged = value; }
      }
      /// <summary>
      /// 记录人
      /// </summary>
      private string pCDE_Recordor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Recordor_IsChanged=false;
      /// <summary>
      /// 记录人
      /// </summary>
      public string PCDE_Recordor
      {
         get{ return pCDE_Recordor; }
         set{ pCDE_Recordor = value; pCDE_Recordor_IsChanged=true; }
      }
      /// <summary>
      /// 记录人
      /// </summary>
      public bool PCDE_Recordor_IsChanged
      {
         get{ return pCDE_Recordor_IsChanged; }
         set{ pCDE_Recordor_IsChanged = value; }
      }
      /// <summary>
      /// 异常处理方式
      /// </summary>
      private string pCDE_Handle;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Handle_IsChanged=false;
      /// <summary>
      /// 异常处理方式
      /// </summary>
      public string PCDE_Handle
      {
         get{ return pCDE_Handle; }
         set{ pCDE_Handle = value; pCDE_Handle_IsChanged=true; }
      }
      /// <summary>
      /// 异常处理方式
      /// </summary>
      public bool PCDE_Handle_IsChanged
      {
         get{ return pCDE_Handle_IsChanged; }
         set{ pCDE_Handle_IsChanged = value; }
      }
      /// <summary>
      /// 异常处理类型
      /// </summary>
      private string pCDE_HType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_HType_IsChanged=false;
      /// <summary>
      /// 异常处理类型
      /// </summary>
      public string PCDE_HType
      {
         get{ return pCDE_HType; }
         set{ pCDE_HType = value; pCDE_HType_IsChanged=true; }
      }
      /// <summary>
      /// 异常处理类型
      /// </summary>
      public bool PCDE_HType_IsChanged
      {
         get{ return pCDE_HType_IsChanged; }
         set{ pCDE_HType_IsChanged = value; }
      }
      /// <summary>
      /// 异常处理意见
      /// </summary>
      private string pCDE_HAdvice;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_HAdvice_IsChanged=false;
      /// <summary>
      /// 异常处理意见
      /// </summary>
      public string PCDE_HAdvice
      {
         get{ return pCDE_HAdvice; }
         set{ pCDE_HAdvice = value; pCDE_HAdvice_IsChanged=true; }
      }
      /// <summary>
      /// 异常处理意见
      /// </summary>
      public bool PCDE_HAdvice_IsChanged
      {
         get{ return pCDE_HAdvice_IsChanged; }
         set{ pCDE_HAdvice_IsChanged = value; }
      }
      /// <summary>
      /// 客户负责人
      /// </summary>
      private string pCDE_COwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_COwner_IsChanged=false;
      /// <summary>
      /// 客户负责人
      /// </summary>
      public string PCDE_COwner
      {
         get{ return pCDE_COwner; }
         set{ pCDE_COwner = value; pCDE_COwner_IsChanged=true; }
      }
      /// <summary>
      /// 客户负责人
      /// </summary>
      public bool PCDE_COwner_IsChanged
      {
         get{ return pCDE_COwner_IsChanged; }
         set{ pCDE_COwner_IsChanged = value; }
      }
      /// <summary>
      /// 客户赔偿金额
      /// </summary>
      private decimal pCDE_Pay;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_Pay_IsChanged=false;
      /// <summary>
      /// 客户赔偿金额
      /// </summary>
      public decimal PCDE_Pay
      {
         get{ return pCDE_Pay; }
         set{ pCDE_Pay = value; pCDE_Pay_IsChanged=true; }
      }
      /// <summary>
      /// 客户赔偿金额
      /// </summary>
      public bool PCDE_Pay_IsChanged
      {
         get{ return pCDE_Pay_IsChanged; }
         set{ pCDE_Pay_IsChanged = value; }
      }
      /// <summary>
      /// 内部处罚金额
      /// </summary>
      private decimal pCDE_IPay;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCDE_IPay_IsChanged=false;
      /// <summary>
      /// 内部处罚金额
      /// </summary>
      public decimal PCDE_IPay
      {
         get{ return pCDE_IPay; }
         set{ pCDE_IPay = value; pCDE_IPay_IsChanged=true; }
      }
      /// <summary>
      /// 内部处罚金额
      /// </summary>
      public bool PCDE_IPay_IsChanged
      {
         get{ return pCDE_IPay_IsChanged; }
         set{ pCDE_IPay_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string auditStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string AuditStat
      {
         get{ return auditStat; }
         set{ auditStat = value; auditStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool AuditStat_IsChanged
      {
         get{ return auditStat_IsChanged; }
         set{ auditStat_IsChanged = value; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      private string auditCurAudit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool auditCurAudit_IsChanged=false;
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public string AuditCurAudit
      {
         get{ return auditCurAudit; }
         set{ auditCurAudit = value; auditCurAudit_IsChanged=true; }
      }
      /// <summary>
      /// 当前审核节点
      /// </summary>
      public bool AuditCurAudit_IsChanged
      {
         get{ return auditCurAudit_IsChanged; }
         set{ auditCurAudit_IsChanged = value; }
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
   }
}
