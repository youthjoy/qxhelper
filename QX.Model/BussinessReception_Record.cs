using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 常规业务招待信息
   /// </summary>
   [Serializable]
   public partial class BussinessReception_Record
   {
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
      /// 业务招待信息ID
      /// </summary>
      private decimal bR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_ID_IsChanged=false;
      /// <summary>
      /// 业务招待信息ID
      /// </summary>
      public decimal BR_ID
      {
         get{ return bR_ID; }
         set{ bR_ID = value; bR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 业务招待信息ID
      /// </summary>
      public bool BR_ID_IsChanged
      {
         get{ return bR_ID_IsChanged; }
         set{ bR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 业务招待编码
      /// </summary>
      private string bR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Code_IsChanged=false;
      /// <summary>
      /// 业务招待编码
      /// </summary>
      public string BR_Code
      {
         get{ return bR_Code; }
         set{ bR_Code = value; bR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 业务招待编码
      /// </summary>
      public bool BR_Code_IsChanged
      {
         get{ return bR_Code_IsChanged; }
         set{ bR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 业务招待类型
      /// </summary>
      private string bR_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Type_IsChanged=false;
      /// <summary>
      /// 业务招待类型
      /// </summary>
      public string BR_Type
      {
         get{ return bR_Type; }
         set{ bR_Type = value; bR_Type_IsChanged=true; }
      }
      /// <summary>
      /// 业务招待类型
      /// </summary>
      public bool BR_Type_IsChanged
      {
         get{ return bR_Type_IsChanged; }
         set{ bR_Type_IsChanged = value; }
      }
      /// <summary>
      /// 招待时间
      /// </summary>
      private DateTime bR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Date_IsChanged=false;
      /// <summary>
      /// 招待时间
      /// </summary>
      public DateTime BR_Date
      {
         get{ return bR_Date; }
         set{ bR_Date = value; bR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 招待时间
      /// </summary>
      public bool BR_Date_IsChanged
      {
         get{ return bR_Date_IsChanged; }
         set{ bR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 招待地点
      /// </summary>
      private string bR_Position;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Position_IsChanged=false;
      /// <summary>
      /// 招待地点
      /// </summary>
      public string BR_Position
      {
         get{ return bR_Position; }
         set{ bR_Position = value; bR_Position_IsChanged=true; }
      }
      /// <summary>
      /// 招待地点
      /// </summary>
      public bool BR_Position_IsChanged
      {
         get{ return bR_Position_IsChanged; }
         set{ bR_Position_IsChanged = value; }
      }
      /// <summary>
      /// 招待内容
      /// </summary>
      private string bR_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Content_IsChanged=false;
      /// <summary>
      /// 招待内容
      /// </summary>
      public string BR_Content
      {
         get{ return bR_Content; }
         set{ bR_Content = value; bR_Content_IsChanged=true; }
      }
      /// <summary>
      /// 招待内容
      /// </summary>
      public bool BR_Content_IsChanged
      {
         get{ return bR_Content_IsChanged; }
         set{ bR_Content_IsChanged = value; }
      }
      /// <summary>
      /// 招待单位
      /// </summary>
      private string bR_ObjectiveCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_ObjectiveCompany_IsChanged=false;
      /// <summary>
      /// 招待单位
      /// </summary>
      public string BR_ObjectiveCompany
      {
         get{ return bR_ObjectiveCompany; }
         set{ bR_ObjectiveCompany = value; bR_ObjectiveCompany_IsChanged=true; }
      }
      /// <summary>
      /// 招待单位
      /// </summary>
      public bool BR_ObjectiveCompany_IsChanged
      {
         get{ return bR_ObjectiveCompany_IsChanged; }
         set{ bR_ObjectiveCompany_IsChanged = value; }
      }
      /// <summary>
      /// 招待人员
      /// </summary>
      private string bR_ObjectivePerson;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_ObjectivePerson_IsChanged=false;
      /// <summary>
      /// 招待人员
      /// </summary>
      public string BR_ObjectivePerson
      {
         get{ return bR_ObjectivePerson; }
         set{ bR_ObjectivePerson = value; bR_ObjectivePerson_IsChanged=true; }
      }
      /// <summary>
      /// 招待人员
      /// </summary>
      public bool BR_ObjectivePerson_IsChanged
      {
         get{ return bR_ObjectivePerson_IsChanged; }
         set{ bR_ObjectivePerson_IsChanged = value; }
      }
      /// <summary>
      /// 人数
      /// </summary>
      private int bR_PersonNumber;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_PersonNumber_IsChanged=false;
      /// <summary>
      /// 人数
      /// </summary>
      public int BR_PersonNumber
      {
         get{ return bR_PersonNumber; }
         set{ bR_PersonNumber = value; bR_PersonNumber_IsChanged=true; }
      }
      /// <summary>
      /// 人数
      /// </summary>
      public bool BR_PersonNumber_IsChanged
      {
         get{ return bR_PersonNumber_IsChanged; }
         set{ bR_PersonNumber_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal bR_Amount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Amount_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal BR_Amount
      {
         get{ return bR_Amount; }
         set{ bR_Amount = value; bR_Amount_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool BR_Amount_IsChanged
      {
         get{ return bR_Amount_IsChanged; }
         set{ bR_Amount_IsChanged = value; }
      }
      /// <summary>
      /// 招待事由
      /// </summary>
      private string bR_Reason;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Reason_IsChanged=false;
      /// <summary>
      /// 招待事由
      /// </summary>
      public string BR_Reason
      {
         get{ return bR_Reason; }
         set{ bR_Reason = value; bR_Reason_IsChanged=true; }
      }
      /// <summary>
      /// 招待事由
      /// </summary>
      public bool BR_Reason_IsChanged
      {
         get{ return bR_Reason_IsChanged; }
         set{ bR_Reason_IsChanged = value; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      private string bR_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Operator_IsChanged=false;
      /// <summary>
      /// 经手人
      /// </summary>
      public string BR_Operator
      {
         get{ return bR_Operator; }
         set{ bR_Operator = value; bR_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 经手人
      /// </summary>
      public bool BR_Operator_IsChanged
      {
         get{ return bR_Operator_IsChanged; }
         set{ bR_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 制单人
      /// </summary>
      private string bR_Creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Creator_IsChanged=false;
      /// <summary>
      /// 制单人
      /// </summary>
      public string BR_Creator
      {
         get{ return bR_Creator; }
         set{ bR_Creator = value; bR_Creator_IsChanged=true; }
      }
      /// <summary>
      /// 制单人
      /// </summary>
      public bool BR_Creator_IsChanged
      {
         get{ return bR_Creator_IsChanged; }
         set{ bR_Creator_IsChanged = value; }
      }
      /// <summary>
      /// 制单时间
      /// </summary>
      private DateTime bR_CreateDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_CreateDate_IsChanged=false;
      /// <summary>
      /// 制单时间
      /// </summary>
      public DateTime BR_CreateDate
      {
         get{ return bR_CreateDate; }
         set{ bR_CreateDate = value; bR_CreateDate_IsChanged=true; }
      }
      /// <summary>
      /// 制单时间
      /// </summary>
      public bool BR_CreateDate_IsChanged
      {
         get{ return bR_CreateDate_IsChanged; }
         set{ bR_CreateDate_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string bR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string BR_Company
      {
         get{ return bR_Company; }
         set{ bR_Company = value; bR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool BR_Company_IsChanged
      {
         get{ return bR_Company_IsChanged; }
         set{ bR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string bR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool bR_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string BR_Dept
      {
         get{ return bR_Dept; }
         set{ bR_Dept = value; bR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool BR_Dept_IsChanged
      {
         get{ return bR_Dept_IsChanged; }
         set{ bR_Dept_IsChanged = value; }
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
