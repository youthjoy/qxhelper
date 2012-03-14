using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 档案借阅记录
   /// </summary>
   [Serializable]
   public partial class Document_Lending
   {
      /// <summary>
      /// 档案借阅ID
      /// </summary>
      private decimal dL_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_ID_IsChanged=false;
      /// <summary>
      /// 档案借阅ID
      /// </summary>
      public decimal DL_ID
      {
         get{ return dL_ID; }
         set{ dL_ID = value; dL_ID_IsChanged=true; }
      }
      /// <summary>
      /// 档案借阅ID
      /// </summary>
      public bool DL_ID_IsChanged
      {
         get{ return dL_ID_IsChanged; }
         set{ dL_ID_IsChanged = value; }
      }
      /// <summary>
      /// 档案借阅编码
      /// </summary>
      private string dL_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_Code_IsChanged=false;
      /// <summary>
      /// 档案借阅编码
      /// </summary>
      public string DL_Code
      {
         get{ return dL_Code; }
         set{ dL_Code = value; dL_Code_IsChanged=true; }
      }
      /// <summary>
      /// 档案借阅编码
      /// </summary>
      public bool DL_Code_IsChanged
      {
         get{ return dL_Code_IsChanged; }
         set{ dL_Code_IsChanged = value; }
      }
      /// <summary>
      /// 档案编码
      /// </summary>
      private string dL_DocumentCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_DocumentCode_IsChanged=false;
      /// <summary>
      /// 档案编码
      /// </summary>
      public string DL_DocumentCode
      {
         get{ return dL_DocumentCode; }
         set{ dL_DocumentCode = value; dL_DocumentCode_IsChanged=true; }
      }
      /// <summary>
      /// 档案编码
      /// </summary>
      public bool DL_DocumentCode_IsChanged
      {
         get{ return dL_DocumentCode_IsChanged; }
         set{ dL_DocumentCode_IsChanged = value; }
      }
      /// <summary>
      /// 档案文件名称
      /// </summary>
      private string dL_DocumentName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_DocumentName_IsChanged=false;
      /// <summary>
      /// 档案文件名称
      /// </summary>
      public string DL_DocumentName
      {
         get{ return dL_DocumentName; }
         set{ dL_DocumentName = value; dL_DocumentName_IsChanged=true; }
      }
      /// <summary>
      /// 档案文件名称
      /// </summary>
      public bool DL_DocumentName_IsChanged
      {
         get{ return dL_DocumentName_IsChanged; }
         set{ dL_DocumentName_IsChanged = value; }
      }
      /// <summary>
      /// 档案文号
      /// </summary>
      private string dL_FileCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_FileCode_IsChanged=false;
      /// <summary>
      /// 档案文号
      /// </summary>
      public string DL_FileCode
      {
         get{ return dL_FileCode; }
         set{ dL_FileCode = value; dL_FileCode_IsChanged=true; }
      }
      /// <summary>
      /// 档案文号
      /// </summary>
      public bool DL_FileCode_IsChanged
      {
         get{ return dL_FileCode_IsChanged; }
         set{ dL_FileCode_IsChanged = value; }
      }
      /// <summary>
      /// ISBN
      /// </summary>
      private string dL_ISBN;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_ISBN_IsChanged=false;
      /// <summary>
      /// ISBN
      /// </summary>
      public string DL_ISBN
      {
         get{ return dL_ISBN; }
         set{ dL_ISBN = value; dL_ISBN_IsChanged=true; }
      }
      /// <summary>
      /// ISBN
      /// </summary>
      public bool DL_ISBN_IsChanged
      {
         get{ return dL_ISBN_IsChanged; }
         set{ dL_ISBN_IsChanged = value; }
      }
      /// <summary>
      /// 借阅类型
      /// </summary>
      private string dL_LendingType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_LendingType_IsChanged=false;
      /// <summary>
      /// 借阅类型
      /// </summary>
      public string DL_LendingType
      {
         get{ return dL_LendingType; }
         set{ dL_LendingType = value; dL_LendingType_IsChanged=true; }
      }
      /// <summary>
      /// 借阅类型
      /// </summary>
      public bool DL_LendingType_IsChanged
      {
         get{ return dL_LendingType_IsChanged; }
         set{ dL_LendingType_IsChanged = value; }
      }
      /// <summary>
      /// 归还类型
      /// </summary>
      private string dL_ReturnType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_ReturnType_IsChanged=false;
      /// <summary>
      /// 归还类型
      /// </summary>
      public string DL_ReturnType
      {
         get{ return dL_ReturnType; }
         set{ dL_ReturnType = value; dL_ReturnType_IsChanged=true; }
      }
      /// <summary>
      /// 归还类型
      /// </summary>
      public bool DL_ReturnType_IsChanged
      {
         get{ return dL_ReturnType_IsChanged; }
         set{ dL_ReturnType_IsChanged = value; }
      }
      /// <summary>
      /// 借阅份数
      /// </summary>
      private int dL_LendingNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_LendingNum_IsChanged=false;
      /// <summary>
      /// 借阅份数
      /// </summary>
      public int DL_LendingNum
      {
         get{ return dL_LendingNum; }
         set{ dL_LendingNum = value; dL_LendingNum_IsChanged=true; }
      }
      /// <summary>
      /// 借阅份数
      /// </summary>
      public bool DL_LendingNum_IsChanged
      {
         get{ return dL_LendingNum_IsChanged; }
         set{ dL_LendingNum_IsChanged = value; }
      }
      /// <summary>
      /// 借阅人公司
      /// </summary>
      private string dL_LendorCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_LendorCompany_IsChanged=false;
      /// <summary>
      /// 借阅人公司
      /// </summary>
      public string DL_LendorCompany
      {
         get{ return dL_LendorCompany; }
         set{ dL_LendorCompany = value; dL_LendorCompany_IsChanged=true; }
      }
      /// <summary>
      /// 借阅人公司
      /// </summary>
      public bool DL_LendorCompany_IsChanged
      {
         get{ return dL_LendorCompany_IsChanged; }
         set{ dL_LendorCompany_IsChanged = value; }
      }
      /// <summary>
      /// 借阅人部门
      /// </summary>
      private string dL_LendorDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_LendorDept_IsChanged=false;
      /// <summary>
      /// 借阅人部门
      /// </summary>
      public string DL_LendorDept
      {
         get{ return dL_LendorDept; }
         set{ dL_LendorDept = value; dL_LendorDept_IsChanged=true; }
      }
      /// <summary>
      /// 借阅人部门
      /// </summary>
      public bool DL_LendorDept_IsChanged
      {
         get{ return dL_LendorDept_IsChanged; }
         set{ dL_LendorDept_IsChanged = value; }
      }
      /// <summary>
      /// 借阅人
      /// </summary>
      private string dL_Person;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_Person_IsChanged=false;
      /// <summary>
      /// 借阅人
      /// </summary>
      public string DL_Person
      {
         get{ return dL_Person; }
         set{ dL_Person = value; dL_Person_IsChanged=true; }
      }
      /// <summary>
      /// 借阅人
      /// </summary>
      public bool DL_Person_IsChanged
      {
         get{ return dL_Person_IsChanged; }
         set{ dL_Person_IsChanged = value; }
      }
      /// <summary>
      /// 借阅时间
      /// </summary>
      private DateTime dL_LendingDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_LendingDate_IsChanged=false;
      /// <summary>
      /// 借阅时间
      /// </summary>
      public DateTime DL_LendingDate
      {
         get{ return dL_LendingDate; }
         set{ dL_LendingDate = value; dL_LendingDate_IsChanged=true; }
      }
      /// <summary>
      /// 借阅时间
      /// </summary>
      public bool DL_LendingDate_IsChanged
      {
         get{ return dL_LendingDate_IsChanged; }
         set{ dL_LendingDate_IsChanged = value; }
      }
      /// <summary>
      /// 借阅经手人
      /// </summary>
      private string dL_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_Operator_IsChanged=false;
      /// <summary>
      /// 借阅经手人
      /// </summary>
      public string DL_Operator
      {
         get{ return dL_Operator; }
         set{ dL_Operator = value; dL_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 借阅经手人
      /// </summary>
      public bool DL_Operator_IsChanged
      {
         get{ return dL_Operator_IsChanged; }
         set{ dL_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 借阅事由
      /// </summary>
      private string dL_LendingReason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_LendingReason_IsChanged=false;
      /// <summary>
      /// 借阅事由
      /// </summary>
      public string DL_LendingReason
      {
         get{ return dL_LendingReason; }
         set{ dL_LendingReason = value; dL_LendingReason_IsChanged=true; }
      }
      /// <summary>
      /// 借阅事由
      /// </summary>
      public bool DL_LendingReason_IsChanged
      {
         get{ return dL_LendingReason_IsChanged; }
         set{ dL_LendingReason_IsChanged = value; }
      }
      /// <summary>
      /// 借阅批准人
      /// </summary>
      private string dL_Authorizor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_Authorizor_IsChanged=false;
      /// <summary>
      /// 借阅批准人
      /// </summary>
      public string DL_Authorizor
      {
         get{ return dL_Authorizor; }
         set{ dL_Authorizor = value; dL_Authorizor_IsChanged=true; }
      }
      /// <summary>
      /// 借阅批准人
      /// </summary>
      public bool DL_Authorizor_IsChanged
      {
         get{ return dL_Authorizor_IsChanged; }
         set{ dL_Authorizor_IsChanged = value; }
      }
      /// <summary>
      /// 归还份数
      /// </summary>
      private int dL_ReturnNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_ReturnNum_IsChanged=false;
      /// <summary>
      /// 归还份数
      /// </summary>
      public int DL_ReturnNum
      {
         get{ return dL_ReturnNum; }
         set{ dL_ReturnNum = value; dL_ReturnNum_IsChanged=true; }
      }
      /// <summary>
      /// 归还份数
      /// </summary>
      public bool DL_ReturnNum_IsChanged
      {
         get{ return dL_ReturnNum_IsChanged; }
         set{ dL_ReturnNum_IsChanged = value; }
      }
      /// <summary>
      /// 归还时间
      /// </summary>
      private DateTime dL_ReturnDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_ReturnDate_IsChanged=false;
      /// <summary>
      /// 归还时间
      /// </summary>
      public DateTime DL_ReturnDate
      {
         get{ return dL_ReturnDate; }
         set{ dL_ReturnDate = value; dL_ReturnDate_IsChanged=true; }
      }
      /// <summary>
      /// 归还时间
      /// </summary>
      public bool DL_ReturnDate_IsChanged
      {
         get{ return dL_ReturnDate_IsChanged; }
         set{ dL_ReturnDate_IsChanged = value; }
      }
      /// <summary>
      /// 归还经手人
      /// </summary>
      private string dL_ReturnOperator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_ReturnOperator_IsChanged=false;
      /// <summary>
      /// 归还经手人
      /// </summary>
      public string DL_ReturnOperator
      {
         get{ return dL_ReturnOperator; }
         set{ dL_ReturnOperator = value; dL_ReturnOperator_IsChanged=true; }
      }
      /// <summary>
      /// 归还经手人
      /// </summary>
      public bool DL_ReturnOperator_IsChanged
      {
         get{ return dL_ReturnOperator_IsChanged; }
         set{ dL_ReturnOperator_IsChanged = value; }
      }
      /// <summary>
      /// 归还备注
      /// </summary>
      private string dL_ReturnRemark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_ReturnRemark_IsChanged=false;
      /// <summary>
      /// 归还备注
      /// </summary>
      public string DL_ReturnRemark
      {
         get{ return dL_ReturnRemark; }
         set{ dL_ReturnRemark = value; dL_ReturnRemark_IsChanged=true; }
      }
      /// <summary>
      /// 归还备注
      /// </summary>
      public bool DL_ReturnRemark_IsChanged
      {
         get{ return dL_ReturnRemark_IsChanged; }
         set{ dL_ReturnRemark_IsChanged = value; }
      }
      /// <summary>
      /// 借阅状态
      /// </summary>
      private string dL_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_Stat_IsChanged=false;
      /// <summary>
      /// 借阅状态
      /// </summary>
      public string DL_Stat
      {
         get{ return dL_Stat; }
         set{ dL_Stat = value; dL_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 借阅状态
      /// </summary>
      public bool DL_Stat_IsChanged
      {
         get{ return dL_Stat_IsChanged; }
         set{ dL_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string dL_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dL_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string DL_Remark
      {
         get{ return dL_Remark; }
         set{ dL_Remark = value; dL_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool DL_Remark_IsChanged
      {
         get{ return dL_Remark_IsChanged; }
         set{ dL_Remark_IsChanged = value; }
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
