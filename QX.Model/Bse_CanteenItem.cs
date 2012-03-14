using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Bse_CanteenItem
   {
      /// <summary>
      /// 食堂基本信息序号
      /// </summary>
      private decimal canteenItem_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool canteenItem_ID_IsChanged=false;
      /// <summary>
      /// 食堂基本信息序号
      /// </summary>
      public decimal CanteenItem_ID
      {
         get{ return canteenItem_ID; }
         set{ canteenItem_ID = value; canteenItem_ID_IsChanged=true; }
      }
      /// <summary>
      /// 食堂基本信息序号
      /// </summary>
      public bool CanteenItem_ID_IsChanged
      {
         get{ return canteenItem_ID_IsChanged; }
         set{ canteenItem_ID_IsChanged = value; }
      }
      /// <summary>
      /// 食堂基本信息编码
      /// </summary>
      private string canteenItem_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool canteenItem_Code_IsChanged=false;
      /// <summary>
      /// 食堂基本信息编码
      /// </summary>
      public string CanteenItem_Code
      {
         get{ return canteenItem_Code; }
         set{ canteenItem_Code = value; canteenItem_Code_IsChanged=true; }
      }
      /// <summary>
      /// 食堂基本信息编码
      /// </summary>
      public bool CanteenItem_Code_IsChanged
      {
         get{ return canteenItem_Code_IsChanged; }
         set{ canteenItem_Code_IsChanged = value; }
      }
      /// <summary>
      /// 食堂名称
      /// </summary>
      private string canteenItem_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool canteenItem_Name_IsChanged=false;
      /// <summary>
      /// 食堂名称
      /// </summary>
      public string CanteenItem_Name
      {
         get{ return canteenItem_Name; }
         set{ canteenItem_Name = value; canteenItem_Name_IsChanged=true; }
      }
      /// <summary>
      /// 食堂名称
      /// </summary>
      public bool CanteenItem_Name_IsChanged
      {
         get{ return canteenItem_Name_IsChanged; }
         set{ canteenItem_Name_IsChanged = value; }
      }
      /// <summary>
      /// 食堂类型
      /// </summary>
      private string canteenItem_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool canteenItem_Type_IsChanged=false;
      /// <summary>
      /// 食堂类型
      /// </summary>
      public string CanteenItem_Type
      {
         get{ return canteenItem_Type; }
         set{ canteenItem_Type = value; canteenItem_Type_IsChanged=true; }
      }
      /// <summary>
      /// 食堂类型
      /// </summary>
      public bool CanteenItem_Type_IsChanged
      {
         get{ return canteenItem_Type_IsChanged; }
         set{ canteenItem_Type_IsChanged = value; }
      }
      /// <summary>
      /// 食堂地址
      /// </summary>
      private string canteenItem_Address;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool canteenItem_Address_IsChanged=false;
      /// <summary>
      /// 食堂地址
      /// </summary>
      public string CanteenItem_Address
      {
         get{ return canteenItem_Address; }
         set{ canteenItem_Address = value; canteenItem_Address_IsChanged=true; }
      }
      /// <summary>
      /// 食堂地址
      /// </summary>
      public bool CanteenItem_Address_IsChanged
      {
         get{ return canteenItem_Address_IsChanged; }
         set{ canteenItem_Address_IsChanged = value; }
      }
      /// <summary>
      /// 外包单位
      /// </summary>
      private string canteenItem_Contractor;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool canteenItem_Contractor_IsChanged=false;
      /// <summary>
      /// 外包单位
      /// </summary>
      public string CanteenItem_Contractor
      {
         get{ return canteenItem_Contractor; }
         set{ canteenItem_Contractor = value; canteenItem_Contractor_IsChanged=true; }
      }
      /// <summary>
      /// 外包单位
      /// </summary>
      public bool CanteenItem_Contractor_IsChanged
      {
         get{ return canteenItem_Contractor_IsChanged; }
         set{ canteenItem_Contractor_IsChanged = value; }
      }
      /// <summary>
      /// 外包单位负责人
      /// </summary>
      private string canteenItem_Charger;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool canteenItem_Charger_IsChanged=false;
      /// <summary>
      /// 外包单位负责人
      /// </summary>
      public string CanteenItem_Charger
      {
         get{ return canteenItem_Charger; }
         set{ canteenItem_Charger = value; canteenItem_Charger_IsChanged=true; }
      }
      /// <summary>
      /// 外包单位负责人
      /// </summary>
      public bool CanteenItem_Charger_IsChanged
      {
         get{ return canteenItem_Charger_IsChanged; }
         set{ canteenItem_Charger_IsChanged = value; }
      }
      /// <summary>
      /// 外包负责人联系方式
      /// </summary>
      private string canteenItem_ChargerContact;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool canteenItem_ChargerContact_IsChanged=false;
      /// <summary>
      /// 外包负责人联系方式
      /// </summary>
      public string CanteenItem_ChargerContact
      {
         get{ return canteenItem_ChargerContact; }
         set{ canteenItem_ChargerContact = value; canteenItem_ChargerContact_IsChanged=true; }
      }
      /// <summary>
      /// 外包负责人联系方式
      /// </summary>
      public bool CanteenItem_ChargerContact_IsChanged
      {
         get{ return canteenItem_ChargerContact_IsChanged; }
         set{ canteenItem_ChargerContact_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string canteenItem_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool canteenItem_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string CanteenItem_Remark
      {
         get{ return canteenItem_Remark; }
         set{ canteenItem_Remark = value; canteenItem_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool CanteenItem_Remark_IsChanged
      {
         get{ return canteenItem_Remark_IsChanged; }
         set{ canteenItem_Remark_IsChanged = value; }
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
      private string canteenItem_Company;
      private bool canteenItem_Company_IsChanged=false;
      public string CanteenItem_Company
      {
         get{ return canteenItem_Company; }
         set{ canteenItem_Company = value; canteenItem_Company_IsChanged=true; }
      }
      public bool CanteenItem_Company_IsChanged
      {
         get{ return canteenItem_Company_IsChanged; }
         set{ canteenItem_Company_IsChanged = value; }
      }
      private string canteenItem_Department;
      private bool canteenItem_Department_IsChanged=false;
      public string CanteenItem_Department
      {
         get{ return canteenItem_Department; }
         set{ canteenItem_Department = value; canteenItem_Department_IsChanged=true; }
      }
      public bool CanteenItem_Department_IsChanged
      {
         get{ return canteenItem_Department_IsChanged; }
         set{ canteenItem_Department_IsChanged = value; }
      }
      private DateTime canteenItem_Start;
      private bool canteenItem_Start_IsChanged=false;
      public DateTime CanteenItem_Start
      {
         get{ return canteenItem_Start; }
         set{ canteenItem_Start = value; canteenItem_Start_IsChanged=true; }
      }
      public bool CanteenItem_Start_IsChanged
      {
         get{ return canteenItem_Start_IsChanged; }
         set{ canteenItem_Start_IsChanged = value; }
      }
      private DateTime canteenItem_End;
      private bool canteenItem_End_IsChanged=false;
      public DateTime CanteenItem_End
      {
         get{ return canteenItem_End; }
         set{ canteenItem_End = value; canteenItem_End_IsChanged=true; }
      }
      public bool CanteenItem_End_IsChanged
      {
         get{ return canteenItem_End_IsChanged; }
         set{ canteenItem_End_IsChanged = value; }
      }
   }
}
