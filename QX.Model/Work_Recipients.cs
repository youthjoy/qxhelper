using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 工作服领用记录
   /// </summary>
   [Serializable]
   public partial class Work_Recipients
   {
      /// <summary>
      /// 领用记录序号
      /// </summary>
      private decimal wRecipients_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_ID_IsChanged=false;
      /// <summary>
      /// 领用记录序号
      /// </summary>
      public decimal WRecipients_ID
      {
         get{ return wRecipients_ID; }
         set{ wRecipients_ID = value; wRecipients_ID_IsChanged=true; }
      }
      /// <summary>
      /// 领用记录序号
      /// </summary>
      public bool WRecipients_ID_IsChanged
      {
         get{ return wRecipients_ID_IsChanged; }
         set{ wRecipients_ID_IsChanged = value; }
      }
      /// <summary>
      /// 领用记录编码
      /// </summary>
      private string wRecipients_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Code_IsChanged=false;
      /// <summary>
      /// 领用记录编码
      /// </summary>
      public string WRecipients_Code
      {
         get{ return wRecipients_Code; }
         set{ wRecipients_Code = value; wRecipients_Code_IsChanged=true; }
      }
      /// <summary>
      /// 领用记录编码
      /// </summary>
      public bool WRecipients_Code_IsChanged
      {
         get{ return wRecipients_Code_IsChanged; }
         set{ wRecipients_Code_IsChanged = value; }
      }
      /// <summary>
      /// 发放时间
      /// </summary>
      private DateTime wRecipients_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Date_IsChanged=false;
      /// <summary>
      /// 发放时间
      /// </summary>
      public DateTime WRecipients_Date
      {
         get{ return wRecipients_Date; }
         set{ wRecipients_Date = value; wRecipients_Date_IsChanged=true; }
      }
      /// <summary>
      /// 发放时间
      /// </summary>
      public bool WRecipients_Date_IsChanged
      {
         get{ return wRecipients_Date_IsChanged; }
         set{ wRecipients_Date_IsChanged = value; }
      }
      /// <summary>
      /// 职务
      /// </summary>
      private string wRecipients_Duty;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Duty_IsChanged=false;
      /// <summary>
      /// 职务
      /// </summary>
      public string WRecipients_Duty
      {
         get{ return wRecipients_Duty; }
         set{ wRecipients_Duty = value; wRecipients_Duty_IsChanged=true; }
      }
      /// <summary>
      /// 职务
      /// </summary>
      public bool WRecipients_Duty_IsChanged
      {
         get{ return wRecipients_Duty_IsChanged; }
         set{ wRecipients_Duty_IsChanged = value; }
      }
      /// <summary>
      /// 姓名
      /// </summary>
      private string wRecipients_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Name_IsChanged=false;
      /// <summary>
      /// 姓名
      /// </summary>
      public string WRecipients_Name
      {
         get{ return wRecipients_Name; }
         set{ wRecipients_Name = value; wRecipients_Name_IsChanged=true; }
      }
      /// <summary>
      /// 姓名
      /// </summary>
      public bool WRecipients_Name_IsChanged
      {
         get{ return wRecipients_Name_IsChanged; }
         set{ wRecipients_Name_IsChanged = value; }
      }
      /// <summary>
      /// 性别
      /// </summary>
      private string wRecipients_Gender;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Gender_IsChanged=false;
      /// <summary>
      /// 性别
      /// </summary>
      public string WRecipients_Gender
      {
         get{ return wRecipients_Gender; }
         set{ wRecipients_Gender = value; wRecipients_Gender_IsChanged=true; }
      }
      /// <summary>
      /// 性别
      /// </summary>
      public bool WRecipients_Gender_IsChanged
      {
         get{ return wRecipients_Gender_IsChanged; }
         set{ wRecipients_Gender_IsChanged = value; }
      }
      /// <summary>
      /// 型号
      /// </summary>
      private string wRecipients_Model;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Model_IsChanged=false;
      /// <summary>
      /// 型号
      /// </summary>
      public string WRecipients_Model
      {
         get{ return wRecipients_Model; }
         set{ wRecipients_Model = value; wRecipients_Model_IsChanged=true; }
      }
      /// <summary>
      /// 型号
      /// </summary>
      public bool WRecipients_Model_IsChanged
      {
         get{ return wRecipients_Model_IsChanged; }
         set{ wRecipients_Model_IsChanged = value; }
      }
      /// <summary>
      /// 套数
      /// </summary>
      private int wRecipients_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Num_IsChanged=false;
      /// <summary>
      /// 套数
      /// </summary>
      public int WRecipients_Num
      {
         get{ return wRecipients_Num; }
         set{ wRecipients_Num = value; wRecipients_Num_IsChanged=true; }
      }
      /// <summary>
      /// 套数
      /// </summary>
      public bool WRecipients_Num_IsChanged
      {
         get{ return wRecipients_Num_IsChanged; }
         set{ wRecipients_Num_IsChanged = value; }
      }
      /// <summary>
      /// 领用人所属公司
      /// </summary>
      private string wRecipients_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Company_IsChanged=false;
      /// <summary>
      /// 领用人所属公司
      /// </summary>
      public string WRecipients_Company
      {
         get{ return wRecipients_Company; }
         set{ wRecipients_Company = value; wRecipients_Company_IsChanged=true; }
      }
      /// <summary>
      /// 领用人所属公司
      /// </summary>
      public bool WRecipients_Company_IsChanged
      {
         get{ return wRecipients_Company_IsChanged; }
         set{ wRecipients_Company_IsChanged = value; }
      }
      /// <summary>
      /// 领用人所属部门
      /// </summary>
      private string wRecipients_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Dept_IsChanged=false;
      /// <summary>
      /// 领用人所属部门
      /// </summary>
      public string WRecipients_Dept
      {
         get{ return wRecipients_Dept; }
         set{ wRecipients_Dept = value; wRecipients_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 领用人所属部门
      /// </summary>
      public bool WRecipients_Dept_IsChanged
      {
         get{ return wRecipients_Dept_IsChanged; }
         set{ wRecipients_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      private string wRecipients_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Operator_IsChanged=false;
      /// <summary>
      /// 操作人
      /// </summary>
      public string WRecipients_Operator
      {
         get{ return wRecipients_Operator; }
         set{ wRecipients_Operator = value; wRecipients_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      public bool WRecipients_Operator_IsChanged
      {
         get{ return wRecipients_Operator_IsChanged; }
         set{ wRecipients_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string wRecipients_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wRecipients_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string WRecipients_Remark
      {
         get{ return wRecipients_Remark; }
         set{ wRecipients_Remark = value; wRecipients_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool WRecipients_Remark_IsChanged
      {
         get{ return wRecipients_Remark_IsChanged; }
         set{ wRecipients_Remark_IsChanged = value; }
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
