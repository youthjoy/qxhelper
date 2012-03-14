using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 文件下发记录
   /// </summary>
   [Serializable]
   public partial class Document_IssueRecord
   {
      /// <summary>
      /// 档案下发ID
      /// </summary>
      private decimal dIR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_ID_IsChanged=false;
      /// <summary>
      /// 档案下发ID
      /// </summary>
      public decimal DIR_ID
      {
         get{ return dIR_ID; }
         set{ dIR_ID = value; dIR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 档案下发ID
      /// </summary>
      public bool DIR_ID_IsChanged
      {
         get{ return dIR_ID_IsChanged; }
         set{ dIR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 档案编码
      /// </summary>
      private string dIR_DocumentCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_DocumentCode_IsChanged=false;
      /// <summary>
      /// 档案编码
      /// </summary>
      public string DIR_DocumentCode
      {
         get{ return dIR_DocumentCode; }
         set{ dIR_DocumentCode = value; dIR_DocumentCode_IsChanged=true; }
      }
      /// <summary>
      /// 档案编码
      /// </summary>
      public bool DIR_DocumentCode_IsChanged
      {
         get{ return dIR_DocumentCode_IsChanged; }
         set{ dIR_DocumentCode_IsChanged = value; }
      }
      /// <summary>
      /// 档案名称
      /// </summary>
      private string dIR_DocumentName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_DocumentName_IsChanged=false;
      /// <summary>
      /// 档案名称
      /// </summary>
      public string DIR_DocumentName
      {
         get{ return dIR_DocumentName; }
         set{ dIR_DocumentName = value; dIR_DocumentName_IsChanged=true; }
      }
      /// <summary>
      /// 档案名称
      /// </summary>
      public bool DIR_DocumentName_IsChanged
      {
         get{ return dIR_DocumentName_IsChanged; }
         set{ dIR_DocumentName_IsChanged = value; }
      }
      /// <summary>
      /// 档案下发编码
      /// </summary>
      private string dIR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_Code_IsChanged=false;
      /// <summary>
      /// 档案下发编码
      /// </summary>
      public string DIR_Code
      {
         get{ return dIR_Code; }
         set{ dIR_Code = value; dIR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 档案下发编码
      /// </summary>
      public bool DIR_Code_IsChanged
      {
         get{ return dIR_Code_IsChanged; }
         set{ dIR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 档案下发时间
      /// </summary>
      private DateTime dIR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_Date_IsChanged=false;
      /// <summary>
      /// 档案下发时间
      /// </summary>
      public DateTime DIR_Date
      {
         get{ return dIR_Date; }
         set{ dIR_Date = value; dIR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 档案下发时间
      /// </summary>
      public bool DIR_Date_IsChanged
      {
         get{ return dIR_Date_IsChanged; }
         set{ dIR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 档案文号
      /// </summary>
      private string dIR_FileCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_FileCode_IsChanged=false;
      /// <summary>
      /// 档案文号
      /// </summary>
      public string DIR_FileCode
      {
         get{ return dIR_FileCode; }
         set{ dIR_FileCode = value; dIR_FileCode_IsChanged=true; }
      }
      /// <summary>
      /// 档案文号
      /// </summary>
      public bool DIR_FileCode_IsChanged
      {
         get{ return dIR_FileCode_IsChanged; }
         set{ dIR_FileCode_IsChanged = value; }
      }
      /// <summary>
      /// 档案下发对象
      /// </summary>
      private string dIR_IssueObject;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_IssueObject_IsChanged=false;
      /// <summary>
      /// 档案下发对象
      /// </summary>
      public string DIR_IssueObject
      {
         get{ return dIR_IssueObject; }
         set{ dIR_IssueObject = value; dIR_IssueObject_IsChanged=true; }
      }
      /// <summary>
      /// 档案下发对象
      /// </summary>
      public bool DIR_IssueObject_IsChanged
      {
         get{ return dIR_IssueObject_IsChanged; }
         set{ dIR_IssueObject_IsChanged = value; }
      }
      /// <summary>
      /// 档案下发对象类型
      /// </summary>
      private string dIR_IssueObjectType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_IssueObjectType_IsChanged=false;
      /// <summary>
      /// 档案下发对象类型
      /// </summary>
      public string DIR_IssueObjectType
      {
         get{ return dIR_IssueObjectType; }
         set{ dIR_IssueObjectType = value; dIR_IssueObjectType_IsChanged=true; }
      }
      /// <summary>
      /// 档案下发对象类型
      /// </summary>
      public bool DIR_IssueObjectType_IsChanged
      {
         get{ return dIR_IssueObjectType_IsChanged; }
         set{ dIR_IssueObjectType_IsChanged = value; }
      }
      /// <summary>
      /// 下发经手人
      /// </summary>
      private string dIR_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_Operator_IsChanged=false;
      /// <summary>
      /// 下发经手人
      /// </summary>
      public string DIR_Operator
      {
         get{ return dIR_Operator; }
         set{ dIR_Operator = value; dIR_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 下发经手人
      /// </summary>
      public bool DIR_Operator_IsChanged
      {
         get{ return dIR_Operator_IsChanged; }
         set{ dIR_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 档案内容
      /// </summary>
      private string dIR_DocmentContent;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_DocmentContent_IsChanged=false;
      /// <summary>
      /// 档案内容
      /// </summary>
      public string DIR_DocmentContent
      {
         get{ return dIR_DocmentContent; }
         set{ dIR_DocmentContent = value; dIR_DocmentContent_IsChanged=true; }
      }
      /// <summary>
      /// 档案内容
      /// </summary>
      public bool DIR_DocmentContent_IsChanged
      {
         get{ return dIR_DocmentContent_IsChanged; }
         set{ dIR_DocmentContent_IsChanged = value; }
      }
      /// <summary>
      /// 附件
      /// </summary>
      private string dIR_Attachment;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dIR_Attachment_IsChanged=false;
      /// <summary>
      /// 附件
      /// </summary>
      public string DIR_Attachment
      {
         get{ return dIR_Attachment; }
         set{ dIR_Attachment = value; dIR_Attachment_IsChanged=true; }
      }
      /// <summary>
      /// 附件
      /// </summary>
      public bool DIR_Attachment_IsChanged
      {
         get{ return dIR_Attachment_IsChanged; }
         set{ dIR_Attachment_IsChanged = value; }
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
   }
}
