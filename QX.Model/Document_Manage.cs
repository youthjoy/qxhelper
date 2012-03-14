using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 档案基本信息
   /// </summary>
   [Serializable]
   public partial class Document_Manage
   {
      /// <summary>
      /// 档案信息ID
      /// </summary>
      private decimal dM_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_ID_IsChanged=false;
      /// <summary>
      /// 档案信息ID
      /// </summary>
      public decimal DM_ID
      {
         get{ return dM_ID; }
         set{ dM_ID = value; dM_ID_IsChanged=true; }
      }
      /// <summary>
      /// 档案信息ID
      /// </summary>
      public bool DM_ID_IsChanged
      {
         get{ return dM_ID_IsChanged; }
         set{ dM_ID_IsChanged = value; }
      }
      /// <summary>
      /// 档案信息编码
      /// </summary>
      private string dM_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Code_IsChanged=false;
      /// <summary>
      /// 档案信息编码
      /// </summary>
      public string DM_Code
      {
         get{ return dM_Code; }
         set{ dM_Code = value; dM_Code_IsChanged=true; }
      }
      /// <summary>
      /// 档案信息编码
      /// </summary>
      public bool DM_Code_IsChanged
      {
         get{ return dM_Code_IsChanged; }
         set{ dM_Code_IsChanged = value; }
      }
      /// <summary>
      /// 文件名称
      /// </summary>
      private string dM_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Name_IsChanged=false;
      /// <summary>
      /// 文件名称
      /// </summary>
      public string DM_Name
      {
         get{ return dM_Name; }
         set{ dM_Name = value; dM_Name_IsChanged=true; }
      }
      /// <summary>
      /// 文件名称
      /// </summary>
      public bool DM_Name_IsChanged
      {
         get{ return dM_Name_IsChanged; }
         set{ dM_Name_IsChanged = value; }
      }
      /// <summary>
      /// 内置类型
      /// </summary>
      private string dM_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_iType_IsChanged=false;
      /// <summary>
      /// 内置类型
      /// </summary>
      public string DM_iType
      {
         get{ return dM_iType; }
         set{ dM_iType = value; dM_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内置类型
      /// </summary>
      public bool DM_iType_IsChanged
      {
         get{ return dM_iType_IsChanged; }
         set{ dM_iType_IsChanged = value; }
      }
      /// <summary>
      /// 档案信息分类
      /// </summary>
      private string dM_Category;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Category_IsChanged=false;
      /// <summary>
      /// 档案信息分类
      /// </summary>
      public string DM_Category
      {
         get{ return dM_Category; }
         set{ dM_Category = value; dM_Category_IsChanged=true; }
      }
      /// <summary>
      /// 档案信息分类
      /// </summary>
      public bool DM_Category_IsChanged
      {
         get{ return dM_Category_IsChanged; }
         set{ dM_Category_IsChanged = value; }
      }
      /// <summary>
      /// 档案文号
      /// </summary>
      private string dM_FileNumber;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_FileNumber_IsChanged=false;
      /// <summary>
      /// 档案文号
      /// </summary>
      public string DM_FileNumber
      {
         get{ return dM_FileNumber; }
         set{ dM_FileNumber = value; dM_FileNumber_IsChanged=true; }
      }
      /// <summary>
      /// 档案文号
      /// </summary>
      public bool DM_FileNumber_IsChanged
      {
         get{ return dM_FileNumber_IsChanged; }
         set{ dM_FileNumber_IsChanged = value; }
      }
      /// <summary>
      /// 档案份数
      /// </summary>
      private int dM_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Num_IsChanged=false;
      /// <summary>
      /// 档案份数
      /// </summary>
      public int DM_Num
      {
         get{ return dM_Num; }
         set{ dM_Num = value; dM_Num_IsChanged=true; }
      }
      /// <summary>
      /// 档案份数
      /// </summary>
      public bool DM_Num_IsChanged
      {
         get{ return dM_Num_IsChanged; }
         set{ dM_Num_IsChanged = value; }
      }
      /// <summary>
      /// 在册份数
      /// </summary>
      private int dM_InNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_InNum_IsChanged=false;
      /// <summary>
      /// 在册份数
      /// </summary>
      public int DM_InNum
      {
         get{ return dM_InNum; }
         set{ dM_InNum = value; dM_InNum_IsChanged=true; }
      }
      /// <summary>
      /// 在册份数
      /// </summary>
      public bool DM_InNum_IsChanged
      {
         get{ return dM_InNum_IsChanged; }
         set{ dM_InNum_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string dM_AttachCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_AttachCompany_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string DM_AttachCompany
      {
         get{ return dM_AttachCompany; }
         set{ dM_AttachCompany = value; dM_AttachCompany_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool DM_AttachCompany_IsChanged
      {
         get{ return dM_AttachCompany_IsChanged; }
         set{ dM_AttachCompany_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string dM_AttachDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_AttachDept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string DM_AttachDept
      {
         get{ return dM_AttachDept; }
         set{ dM_AttachDept = value; dM_AttachDept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool DM_AttachDept_IsChanged
      {
         get{ return dM_AttachDept_IsChanged; }
         set{ dM_AttachDept_IsChanged = value; }
      }
      /// <summary>
      /// 档案类别
      /// </summary>
      private string dM_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Type_IsChanged=false;
      /// <summary>
      /// 档案类别
      /// </summary>
      public string DM_Type
      {
         get{ return dM_Type; }
         set{ dM_Type = value; dM_Type_IsChanged=true; }
      }
      /// <summary>
      /// 档案类别
      /// </summary>
      public bool DM_Type_IsChanged
      {
         get{ return dM_Type_IsChanged; }
         set{ dM_Type_IsChanged = value; }
      }
      /// <summary>
      /// 签发人
      /// </summary>
      private string dM_Issuer;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Issuer_IsChanged=false;
      /// <summary>
      /// 签发人
      /// </summary>
      public string DM_Issuer
      {
         get{ return dM_Issuer; }
         set{ dM_Issuer = value; dM_Issuer_IsChanged=true; }
      }
      /// <summary>
      /// 签发人
      /// </summary>
      public bool DM_Issuer_IsChanged
      {
         get{ return dM_Issuer_IsChanged; }
         set{ dM_Issuer_IsChanged = value; }
      }
      /// <summary>
      /// 经办人
      /// </summary>
      private string dM_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Operator_IsChanged=false;
      /// <summary>
      /// 经办人
      /// </summary>
      public string DM_Operator
      {
         get{ return dM_Operator; }
         set{ dM_Operator = value; dM_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 经办人
      /// </summary>
      public bool DM_Operator_IsChanged
      {
         get{ return dM_Operator_IsChanged; }
         set{ dM_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 存档时间
      /// </summary>
      private DateTime dM_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Date_IsChanged=false;
      /// <summary>
      /// 存档时间
      /// </summary>
      public DateTime DM_Date
      {
         get{ return dM_Date; }
         set{ dM_Date = value; dM_Date_IsChanged=true; }
      }
      /// <summary>
      /// 存档时间
      /// </summary>
      public bool DM_Date_IsChanged
      {
         get{ return dM_Date_IsChanged; }
         set{ dM_Date_IsChanged = value; }
      }
      /// <summary>
      /// 转档时间
      /// </summary>
      private DateTime dM_ConversionDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_ConversionDate_IsChanged=false;
      /// <summary>
      /// 转档时间
      /// </summary>
      public DateTime DM_ConversionDate
      {
         get{ return dM_ConversionDate; }
         set{ dM_ConversionDate = value; dM_ConversionDate_IsChanged=true; }
      }
      /// <summary>
      /// 转档时间
      /// </summary>
      public bool DM_ConversionDate_IsChanged
      {
         get{ return dM_ConversionDate_IsChanged; }
         set{ dM_ConversionDate_IsChanged = value; }
      }
      /// <summary>
      /// 页码
      /// </summary>
      private int dM_PageNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_PageNum_IsChanged=false;
      /// <summary>
      /// 页码
      /// </summary>
      public int DM_PageNum
      {
         get{ return dM_PageNum; }
         set{ dM_PageNum = value; dM_PageNum_IsChanged=true; }
      }
      /// <summary>
      /// 页码
      /// </summary>
      public bool DM_PageNum_IsChanged
      {
         get{ return dM_PageNum_IsChanged; }
         set{ dM_PageNum_IsChanged = value; }
      }
      /// <summary>
      /// 保密等级
      /// </summary>
      private string dM_SecretLevel;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_SecretLevel_IsChanged=false;
      /// <summary>
      /// 保密等级
      /// </summary>
      public string DM_SecretLevel
      {
         get{ return dM_SecretLevel; }
         set{ dM_SecretLevel = value; dM_SecretLevel_IsChanged=true; }
      }
      /// <summary>
      /// 保密等级
      /// </summary>
      public bool DM_SecretLevel_IsChanged
      {
         get{ return dM_SecretLevel_IsChanged; }
         set{ dM_SecretLevel_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string dM_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string DM_Remark
      {
         get{ return dM_Remark; }
         set{ dM_Remark = value; dM_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool DM_Remark_IsChanged
      {
         get{ return dM_Remark_IsChanged; }
         set{ dM_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 主要内容
      /// </summary>
      private string dM_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Content_IsChanged=false;
      /// <summary>
      /// 主要内容
      /// </summary>
      public string DM_Content
      {
         get{ return dM_Content; }
         set{ dM_Content = value; dM_Content_IsChanged=true; }
      }
      /// <summary>
      /// 主要内容
      /// </summary>
      public bool DM_Content_IsChanged
      {
         get{ return dM_Content_IsChanged; }
         set{ dM_Content_IsChanged = value; }
      }
      /// <summary>
      /// 保存部门
      /// </summary>
      private string dM_HoldingDept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_HoldingDept_IsChanged=false;
      /// <summary>
      /// 保存部门
      /// </summary>
      public string DM_HoldingDept
      {
         get{ return dM_HoldingDept; }
         set{ dM_HoldingDept = value; dM_HoldingDept_IsChanged=true; }
      }
      /// <summary>
      /// 保存部门
      /// </summary>
      public bool DM_HoldingDept_IsChanged
      {
         get{ return dM_HoldingDept_IsChanged; }
         set{ dM_HoldingDept_IsChanged = value; }
      }
      /// <summary>
      /// 保存人
      /// </summary>
      private string dM_HoldingPerson;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_HoldingPerson_IsChanged=false;
      /// <summary>
      /// 保存人
      /// </summary>
      public string DM_HoldingPerson
      {
         get{ return dM_HoldingPerson; }
         set{ dM_HoldingPerson = value; dM_HoldingPerson_IsChanged=true; }
      }
      /// <summary>
      /// 保存人
      /// </summary>
      public bool DM_HoldingPerson_IsChanged
      {
         get{ return dM_HoldingPerson_IsChanged; }
         set{ dM_HoldingPerson_IsChanged = value; }
      }
      /// <summary>
      /// 保存位置
      /// </summary>
      private string dM_Position;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Position_IsChanged=false;
      /// <summary>
      /// 保存位置
      /// </summary>
      public string DM_Position
      {
         get{ return dM_Position; }
         set{ dM_Position = value; dM_Position_IsChanged=true; }
      }
      /// <summary>
      /// 保存位置
      /// </summary>
      public bool DM_Position_IsChanged
      {
         get{ return dM_Position_IsChanged; }
         set{ dM_Position_IsChanged = value; }
      }
      /// <summary>
      /// 档案状态
      /// </summary>
      private string dM_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_Stat_IsChanged=false;
      /// <summary>
      /// 档案状态
      /// </summary>
      public string DM_Stat
      {
         get{ return dM_Stat; }
         set{ dM_Stat = value; dM_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 档案状态
      /// </summary>
      public bool DM_Stat_IsChanged
      {
         get{ return dM_Stat_IsChanged; }
         set{ dM_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 是否已下发
      /// </summary>
      private string dM_IsIssued;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool dM_IsIssued_IsChanged=false;
      /// <summary>
      /// 是否已下发
      /// </summary>
      public string DM_IsIssued
      {
         get{ return dM_IsIssued; }
         set{ dM_IsIssued = value; dM_IsIssued_IsChanged=true; }
      }
      /// <summary>
      /// 是否已下发
      /// </summary>
      public bool DM_IsIssued_IsChanged
      {
         get{ return dM_IsIssued_IsChanged; }
         set{ dM_IsIssued_IsChanged = value; }
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
