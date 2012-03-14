using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 水票/水领用记录
   /// </summary>
   [Serializable]
   public partial class WaterRecipients_Record
   {
      /// <summary>
      /// 领用记录序号
      /// </summary>
      private decimal wR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_ID_IsChanged=false;
      /// <summary>
      /// 领用记录序号
      /// </summary>
      public decimal WR_ID
      {
         get{ return wR_ID; }
         set{ wR_ID = value; wR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 领用记录序号
      /// </summary>
      public bool WR_ID_IsChanged
      {
         get{ return wR_ID_IsChanged; }
         set{ wR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 领用记录编码
      /// </summary>
      private string wR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_Code_IsChanged=false;
      /// <summary>
      /// 领用记录编码
      /// </summary>
      public string WR_Code
      {
         get{ return wR_Code; }
         set{ wR_Code = value; wR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 领用记录编码
      /// </summary>
      public bool WR_Code_IsChanged
      {
         get{ return wR_Code_IsChanged; }
         set{ wR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 领用所属公司
      /// </summary>
      private string wR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_Company_IsChanged=false;
      /// <summary>
      /// 领用所属公司
      /// </summary>
      public string WR_Company
      {
         get{ return wR_Company; }
         set{ wR_Company = value; wR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 领用所属公司
      /// </summary>
      public bool WR_Company_IsChanged
      {
         get{ return wR_Company_IsChanged; }
         set{ wR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 领用所属部门
      /// </summary>
      private string wR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_Dept_IsChanged=false;
      /// <summary>
      /// 领用所属部门
      /// </summary>
      public string WR_Dept
      {
         get{ return wR_Dept; }
         set{ wR_Dept = value; wR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 领用所属部门
      /// </summary>
      public bool WR_Dept_IsChanged
      {
         get{ return wR_Dept_IsChanged; }
         set{ wR_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      private string wR_DutyPerson;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_DutyPerson_IsChanged=false;
      /// <summary>
      /// 责任人
      /// </summary>
      public string WR_DutyPerson
      {
         get{ return wR_DutyPerson; }
         set{ wR_DutyPerson = value; wR_DutyPerson_IsChanged=true; }
      }
      /// <summary>
      /// 责任人
      /// </summary>
      public bool WR_DutyPerson_IsChanged
      {
         get{ return wR_DutyPerson_IsChanged; }
         set{ wR_DutyPerson_IsChanged = value; }
      }
      /// <summary>
      /// 张数
      /// </summary>
      private int wR_Count;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_Count_IsChanged=false;
      /// <summary>
      /// 张数
      /// </summary>
      public int WR_Count
      {
         get{ return wR_Count; }
         set{ wR_Count = value; wR_Count_IsChanged=true; }
      }
      /// <summary>
      /// 张数
      /// </summary>
      public bool WR_Count_IsChanged
      {
         get{ return wR_Count_IsChanged; }
         set{ wR_Count_IsChanged = value; }
      }
      private string wR_EmptyPosition;
      private bool wR_EmptyPosition_IsChanged=false;
      public string WR_EmptyPosition
      {
         get{ return wR_EmptyPosition; }
         set{ wR_EmptyPosition = value; wR_EmptyPosition_IsChanged=true; }
      }
      public bool WR_EmptyPosition_IsChanged
      {
         get{ return wR_EmptyPosition_IsChanged; }
         set{ wR_EmptyPosition_IsChanged = value; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      private decimal wR_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_Price_IsChanged=false;
      /// <summary>
      /// 单价
      /// </summary>
      public decimal WR_Price
      {
         get{ return wR_Price; }
         set{ wR_Price = value; wR_Price_IsChanged=true; }
      }
      /// <summary>
      /// 单价
      /// </summary>
      public bool WR_Price_IsChanged
      {
         get{ return wR_Price_IsChanged; }
         set{ wR_Price_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal wR_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_Cost_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal WR_Cost
      {
         get{ return wR_Cost; }
         set{ wR_Cost = value; wR_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool WR_Cost_IsChanged
      {
         get{ return wR_Cost_IsChanged; }
         set{ wR_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 时间
      /// </summary>
      private DateTime wR_RecipientDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_RecipientDate_IsChanged=false;
      /// <summary>
      /// 时间
      /// </summary>
      public DateTime WR_RecipientDate
      {
         get{ return wR_RecipientDate; }
         set{ wR_RecipientDate = value; wR_RecipientDate_IsChanged=true; }
      }
      /// <summary>
      /// 时间
      /// </summary>
      public bool WR_RecipientDate_IsChanged
      {
         get{ return wR_RecipientDate_IsChanged; }
         set{ wR_RecipientDate_IsChanged = value; }
      }
      /// <summary>
      /// 摘要
      /// </summary>
      private string wR_Abstract;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_Abstract_IsChanged=false;
      /// <summary>
      /// 摘要
      /// </summary>
      public string WR_Abstract
      {
         get{ return wR_Abstract; }
         set{ wR_Abstract = value; wR_Abstract_IsChanged=true; }
      }
      /// <summary>
      /// 摘要
      /// </summary>
      public bool WR_Abstract_IsChanged
      {
         get{ return wR_Abstract_IsChanged; }
         set{ wR_Abstract_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string wR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string WR_Remark
      {
         get{ return wR_Remark; }
         set{ wR_Remark = value; wR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool WR_Remark_IsChanged
      {
         get{ return wR_Remark_IsChanged; }
         set{ wR_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 是否还桶
      /// </summary>
      private string wR_IsReturn;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_IsReturn_IsChanged=false;
      /// <summary>
      /// 是否还桶
      /// </summary>
      public string WR_IsReturn
      {
         get{ return wR_IsReturn; }
         set{ wR_IsReturn = value; wR_IsReturn_IsChanged=true; }
      }
      /// <summary>
      /// 是否还桶
      /// </summary>
      public bool WR_IsReturn_IsChanged
      {
         get{ return wR_IsReturn_IsChanged; }
         set{ wR_IsReturn_IsChanged = value; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      private string wR_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wR_iType_IsChanged=false;
      /// <summary>
      /// 内部类别
      /// </summary>
      public string WR_iType
      {
         get{ return wR_iType; }
         set{ wR_iType = value; wR_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部类别
      /// </summary>
      public bool WR_iType_IsChanged
      {
         get{ return wR_iType_IsChanged; }
         set{ wR_iType_IsChanged = value; }
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
