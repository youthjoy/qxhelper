using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 食堂贴补记录
   /// </summary>
   [Serializable]
   public partial class CanteenHelp_Record
   {
      /// <summary>
      /// 贴补记录序号
      /// </summary>
      private decimal cHR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_ID_IsChanged=false;
      /// <summary>
      /// 贴补记录序号
      /// </summary>
      public decimal CHR_ID
      {
         get{ return cHR_ID; }
         set{ cHR_ID = value; cHR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 贴补记录序号
      /// </summary>
      public bool CHR_ID_IsChanged
      {
         get{ return cHR_ID_IsChanged; }
         set{ cHR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 贴补记录编码
      /// </summary>
      private string cHR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_Code_IsChanged=false;
      /// <summary>
      /// 贴补记录编码
      /// </summary>
      public string CHR_Code
      {
         get{ return cHR_Code; }
         set{ cHR_Code = value; cHR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 贴补记录编码
      /// </summary>
      public bool CHR_Code_IsChanged
      {
         get{ return cHR_Code_IsChanged; }
         set{ cHR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 食堂编码
      /// </summary>
      private string cHR_CanteenItemCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_CanteenItemCode_IsChanged=false;
      /// <summary>
      /// 食堂编码
      /// </summary>
      public string CHR_CanteenItemCode
      {
         get{ return cHR_CanteenItemCode; }
         set{ cHR_CanteenItemCode = value; cHR_CanteenItemCode_IsChanged=true; }
      }
      /// <summary>
      /// 食堂编码
      /// </summary>
      public bool CHR_CanteenItemCode_IsChanged
      {
         get{ return cHR_CanteenItemCode_IsChanged; }
         set{ cHR_CanteenItemCode_IsChanged = value; }
      }
      /// <summary>
      /// 贴补记录项目
      /// </summary>
      private string cHR_Item;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_Item_IsChanged=false;
      /// <summary>
      /// 贴补记录项目
      /// </summary>
      public string CHR_Item
      {
         get{ return cHR_Item; }
         set{ cHR_Item = value; cHR_Item_IsChanged=true; }
      }
      /// <summary>
      /// 贴补记录项目
      /// </summary>
      public bool CHR_Item_IsChanged
      {
         get{ return cHR_Item_IsChanged; }
         set{ cHR_Item_IsChanged = value; }
      }
      /// <summary>
      /// 贴补标准
      /// </summary>
      private string cHR_Standard;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_Standard_IsChanged=false;
      /// <summary>
      /// 贴补标准
      /// </summary>
      public string CHR_Standard
      {
         get{ return cHR_Standard; }
         set{ cHR_Standard = value; cHR_Standard_IsChanged=true; }
      }
      /// <summary>
      /// 贴补标准
      /// </summary>
      public bool CHR_Standard_IsChanged
      {
         get{ return cHR_Standard_IsChanged; }
         set{ cHR_Standard_IsChanged = value; }
      }
      /// <summary>
      /// 贴补金额
      /// </summary>
      private decimal cHR_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_Cost_IsChanged=false;
      /// <summary>
      /// 贴补金额
      /// </summary>
      public decimal CHR_Cost
      {
         get{ return cHR_Cost; }
         set{ cHR_Cost = value; cHR_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 贴补金额
      /// </summary>
      public bool CHR_Cost_IsChanged
      {
         get{ return cHR_Cost_IsChanged; }
         set{ cHR_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 补贴时间
      /// </summary>
      private DateTime cHR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_Date_IsChanged=false;
      /// <summary>
      /// 补贴时间
      /// </summary>
      public DateTime CHR_Date
      {
         get{ return cHR_Date; }
         set{ cHR_Date = value; cHR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 补贴时间
      /// </summary>
      public bool CHR_Date_IsChanged
      {
         get{ return cHR_Date_IsChanged; }
         set{ cHR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 补贴周期
      /// </summary>
      private string cHR_Period;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_Period_IsChanged=false;
      /// <summary>
      /// 补贴周期
      /// </summary>
      public string CHR_Period
      {
         get{ return cHR_Period; }
         set{ cHR_Period = value; cHR_Period_IsChanged=true; }
      }
      /// <summary>
      /// 补贴周期
      /// </summary>
      public bool CHR_Period_IsChanged
      {
         get{ return cHR_Period_IsChanged; }
         set{ cHR_Period_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string cHR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string CHR_Company
      {
         get{ return cHR_Company; }
         set{ cHR_Company = value; cHR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool CHR_Company_IsChanged
      {
         get{ return cHR_Company_IsChanged; }
         set{ cHR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string cHR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string CHR_Dept
      {
         get{ return cHR_Dept; }
         set{ cHR_Dept = value; cHR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool CHR_Dept_IsChanged
      {
         get{ return cHR_Dept_IsChanged; }
         set{ cHR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string cHR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cHR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string CHR_Remark
      {
         get{ return cHR_Remark; }
         set{ cHR_Remark = value; cHR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool CHR_Remark_IsChanged
      {
         get{ return cHR_Remark_IsChanged; }
         set{ cHR_Remark_IsChanged = value; }
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
