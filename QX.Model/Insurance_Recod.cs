using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 保险卡领用登记
   /// </summary>
   [Serializable]
   public partial class Insurance_Recod
   {
      /// <summary>
      /// 领用记录序号
      /// </summary>
      private decimal iRecord_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_ID_IsChanged=false;
      /// <summary>
      /// 领用记录序号
      /// </summary>
      public decimal IRecord_ID
      {
         get{ return iRecord_ID; }
         set{ iRecord_ID = value; iRecord_ID_IsChanged=true; }
      }
      /// <summary>
      /// 领用记录序号
      /// </summary>
      public bool IRecord_ID_IsChanged
      {
         get{ return iRecord_ID_IsChanged; }
         set{ iRecord_ID_IsChanged = value; }
      }
      /// <summary>
      /// 领用记录编码
      /// </summary>
      private string iRecord_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_Code_IsChanged=false;
      /// <summary>
      /// 领用记录编码
      /// </summary>
      public string IRecord_Code
      {
         get{ return iRecord_Code; }
         set{ iRecord_Code = value; iRecord_Code_IsChanged=true; }
      }
      /// <summary>
      /// 领用记录编码
      /// </summary>
      public bool IRecord_Code_IsChanged
      {
         get{ return iRecord_Code_IsChanged; }
         set{ iRecord_Code_IsChanged = value; }
      }
      /// <summary>
      /// 领用车号
      /// </summary>
      private string iRecord_VehiclesNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_VehiclesNo_IsChanged=false;
      /// <summary>
      /// 领用车号
      /// </summary>
      public string IRecord_VehiclesNo
      {
         get{ return iRecord_VehiclesNo; }
         set{ iRecord_VehiclesNo = value; iRecord_VehiclesNo_IsChanged=true; }
      }
      /// <summary>
      /// 领用车号
      /// </summary>
      public bool IRecord_VehiclesNo_IsChanged
      {
         get{ return iRecord_VehiclesNo_IsChanged; }
         set{ iRecord_VehiclesNo_IsChanged = value; }
      }
      /// <summary>
      /// 领用车辆编码
      /// </summary>
      private string iRecord_VehiclesCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_VehiclesCode_IsChanged=false;
      /// <summary>
      /// 领用车辆编码
      /// </summary>
      public string IRecord_VehiclesCode
      {
         get{ return iRecord_VehiclesCode; }
         set{ iRecord_VehiclesCode = value; iRecord_VehiclesCode_IsChanged=true; }
      }
      /// <summary>
      /// 领用车辆编码
      /// </summary>
      public bool IRecord_VehiclesCode_IsChanged
      {
         get{ return iRecord_VehiclesCode_IsChanged; }
         set{ iRecord_VehiclesCode_IsChanged = value; }
      }
      /// <summary>
      /// 保险卡号
      /// </summary>
      private string iRecord_Card;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_Card_IsChanged=false;
      /// <summary>
      /// 保险卡号
      /// </summary>
      public string IRecord_Card
      {
         get{ return iRecord_Card; }
         set{ iRecord_Card = value; iRecord_Card_IsChanged=true; }
      }
      /// <summary>
      /// 保险卡号
      /// </summary>
      public bool IRecord_Card_IsChanged
      {
         get{ return iRecord_Card_IsChanged; }
         set{ iRecord_Card_IsChanged = value; }
      }
      /// <summary>
      /// 保险公司
      /// </summary>
      private string iRecord_InsuranceCompany;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_InsuranceCompany_IsChanged=false;
      /// <summary>
      /// 保险公司
      /// </summary>
      public string IRecord_InsuranceCompany
      {
         get{ return iRecord_InsuranceCompany; }
         set{ iRecord_InsuranceCompany = value; iRecord_InsuranceCompany_IsChanged=true; }
      }
      /// <summary>
      /// 保险公司
      /// </summary>
      public bool IRecord_InsuranceCompany_IsChanged
      {
         get{ return iRecord_InsuranceCompany_IsChanged; }
         set{ iRecord_InsuranceCompany_IsChanged = value; }
      }
      /// <summary>
      /// 保险期限
      /// </summary>
      private float iRecord_Period;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_Period_IsChanged=false;
      /// <summary>
      /// 保险期限
      /// </summary>
      public float IRecord_Period
      {
         get{ return iRecord_Period; }
         set{ iRecord_Period = value; iRecord_Period_IsChanged=true; }
      }
      /// <summary>
      /// 保险期限
      /// </summary>
      public bool IRecord_Period_IsChanged
      {
         get{ return iRecord_Period_IsChanged; }
         set{ iRecord_Period_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string iRecord_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string IRecord_Unit
      {
         get{ return iRecord_Unit; }
         set{ iRecord_Unit = value; iRecord_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool IRecord_Unit_IsChanged
      {
         get{ return iRecord_Unit_IsChanged; }
         set{ iRecord_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 领取人
      /// </summary>
      private string iRecord_User;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_User_IsChanged=false;
      /// <summary>
      /// 领取人
      /// </summary>
      public string IRecord_User
      {
         get{ return iRecord_User; }
         set{ iRecord_User = value; iRecord_User_IsChanged=true; }
      }
      /// <summary>
      /// 领取人
      /// </summary>
      public bool IRecord_User_IsChanged
      {
         get{ return iRecord_User_IsChanged; }
         set{ iRecord_User_IsChanged = value; }
      }
      /// <summary>
      /// 领取时间
      /// </summary>
      private DateTime iRecord_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_Date_IsChanged=false;
      /// <summary>
      /// 领取时间
      /// </summary>
      public DateTime IRecord_Date
      {
         get{ return iRecord_Date; }
         set{ iRecord_Date = value; iRecord_Date_IsChanged=true; }
      }
      /// <summary>
      /// 领取时间
      /// </summary>
      public bool IRecord_Date_IsChanged
      {
         get{ return iRecord_Date_IsChanged; }
         set{ iRecord_Date_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string iRecord_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool iRecord_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string IRecord_Remark
      {
         get{ return iRecord_Remark; }
         set{ iRecord_Remark = value; iRecord_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool IRecord_Remark_IsChanged
      {
         get{ return iRecord_Remark_IsChanged; }
         set{ iRecord_Remark_IsChanged = value; }
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
