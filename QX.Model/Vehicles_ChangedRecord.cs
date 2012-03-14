using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 后勤车辆交接记录
   /// </summary>
   [Serializable]
   public partial class Vehicles_ChangedRecord
   {
      /// <summary>
      /// 交接记录序号
      /// </summary>
      private decimal vCRecord_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_ID_IsChanged=false;
      /// <summary>
      /// 交接记录序号
      /// </summary>
      public decimal VCRecord_ID
      {
         get{ return vCRecord_ID; }
         set{ vCRecord_ID = value; vCRecord_ID_IsChanged=true; }
      }
      /// <summary>
      /// 交接记录序号
      /// </summary>
      public bool VCRecord_ID_IsChanged
      {
         get{ return vCRecord_ID_IsChanged; }
         set{ vCRecord_ID_IsChanged = value; }
      }
      /// <summary>
      /// 交接记录编码
      /// </summary>
      private string vCRecord_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_Code_IsChanged=false;
      /// <summary>
      /// 交接记录编码
      /// </summary>
      public string VCRecord_Code
      {
         get{ return vCRecord_Code; }
         set{ vCRecord_Code = value; vCRecord_Code_IsChanged=true; }
      }
      /// <summary>
      /// 交接记录编码
      /// </summary>
      public bool VCRecord_Code_IsChanged
      {
         get{ return vCRecord_Code_IsChanged; }
         set{ vCRecord_Code_IsChanged = value; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      private string vCRecord_VehiclesNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_VehiclesNo_IsChanged=false;
      /// <summary>
      /// 车牌号
      /// </summary>
      public string VCRecord_VehiclesNo
      {
         get{ return vCRecord_VehiclesNo; }
         set{ vCRecord_VehiclesNo = value; vCRecord_VehiclesNo_IsChanged=true; }
      }
      /// <summary>
      /// 车牌号
      /// </summary>
      public bool VCRecord_VehiclesNo_IsChanged
      {
         get{ return vCRecord_VehiclesNo_IsChanged; }
         set{ vCRecord_VehiclesNo_IsChanged = value; }
      }
      /// <summary>
      /// 车辆编码
      /// </summary>
      private string vCRecord_VehiclesCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_VehiclesCode_IsChanged=false;
      /// <summary>
      /// 车辆编码
      /// </summary>
      public string VCRecord_VehiclesCode
      {
         get{ return vCRecord_VehiclesCode; }
         set{ vCRecord_VehiclesCode = value; vCRecord_VehiclesCode_IsChanged=true; }
      }
      /// <summary>
      /// 车辆编码
      /// </summary>
      public bool VCRecord_VehiclesCode_IsChanged
      {
         get{ return vCRecord_VehiclesCode_IsChanged; }
         set{ vCRecord_VehiclesCode_IsChanged = value; }
      }
      /// <summary>
      /// 交接时间
      /// </summary>
      private DateTime vCRecord_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_Date_IsChanged=false;
      /// <summary>
      /// 交接时间
      /// </summary>
      public DateTime VCRecord_Date
      {
         get{ return vCRecord_Date; }
         set{ vCRecord_Date = value; vCRecord_Date_IsChanged=true; }
      }
      /// <summary>
      /// 交接时间
      /// </summary>
      public bool VCRecord_Date_IsChanged
      {
         get{ return vCRecord_Date_IsChanged; }
         set{ vCRecord_Date_IsChanged = value; }
      }
      /// <summary>
      /// 检查部位
      /// </summary>
      private string vCRecord_CheckPosition;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_CheckPosition_IsChanged=false;
      /// <summary>
      /// 检查部位
      /// </summary>
      public string VCRecord_CheckPosition
      {
         get{ return vCRecord_CheckPosition; }
         set{ vCRecord_CheckPosition = value; vCRecord_CheckPosition_IsChanged=true; }
      }
      /// <summary>
      /// 检查部位
      /// </summary>
      public bool VCRecord_CheckPosition_IsChanged
      {
         get{ return vCRecord_CheckPosition_IsChanged; }
         set{ vCRecord_CheckPosition_IsChanged = value; }
      }
      /// <summary>
      /// 不合格部位
      /// </summary>
      private string vCRecord_WrongPosition;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_WrongPosition_IsChanged=false;
      /// <summary>
      /// 不合格部位
      /// </summary>
      public string VCRecord_WrongPosition
      {
         get{ return vCRecord_WrongPosition; }
         set{ vCRecord_WrongPosition = value; vCRecord_WrongPosition_IsChanged=true; }
      }
      /// <summary>
      /// 不合格部位
      /// </summary>
      public bool VCRecord_WrongPosition_IsChanged
      {
         get{ return vCRecord_WrongPosition_IsChanged; }
         set{ vCRecord_WrongPosition_IsChanged = value; }
      }
      /// <summary>
      /// 处理办法
      /// </summary>
      private string vCRecord_HandleMethod;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_HandleMethod_IsChanged=false;
      /// <summary>
      /// 处理办法
      /// </summary>
      public string VCRecord_HandleMethod
      {
         get{ return vCRecord_HandleMethod; }
         set{ vCRecord_HandleMethod = value; vCRecord_HandleMethod_IsChanged=true; }
      }
      /// <summary>
      /// 处理办法
      /// </summary>
      public bool VCRecord_HandleMethod_IsChanged
      {
         get{ return vCRecord_HandleMethod_IsChanged; }
         set{ vCRecord_HandleMethod_IsChanged = value; }
      }
      /// <summary>
      /// 交车人
      /// </summary>
      private string vCRecord_Changer;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_Changer_IsChanged=false;
      /// <summary>
      /// 交车人
      /// </summary>
      public string VCRecord_Changer
      {
         get{ return vCRecord_Changer; }
         set{ vCRecord_Changer = value; vCRecord_Changer_IsChanged=true; }
      }
      /// <summary>
      /// 交车人
      /// </summary>
      public bool VCRecord_Changer_IsChanged
      {
         get{ return vCRecord_Changer_IsChanged; }
         set{ vCRecord_Changer_IsChanged = value; }
      }
      /// <summary>
      /// 接车人
      /// </summary>
      private string vCRecord_Receiver;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_Receiver_IsChanged=false;
      /// <summary>
      /// 接车人
      /// </summary>
      public string VCRecord_Receiver
      {
         get{ return vCRecord_Receiver; }
         set{ vCRecord_Receiver = value; vCRecord_Receiver_IsChanged=true; }
      }
      /// <summary>
      /// 接车人
      /// </summary>
      public bool VCRecord_Receiver_IsChanged
      {
         get{ return vCRecord_Receiver_IsChanged; }
         set{ vCRecord_Receiver_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string vCRecord_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string VCRecord_Remark
      {
         get{ return vCRecord_Remark; }
         set{ vCRecord_Remark = value; vCRecord_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool VCRecord_Remark_IsChanged
      {
         get{ return vCRecord_Remark_IsChanged; }
         set{ vCRecord_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string vCRecord_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_Company_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string VCRecord_Company
      {
         get{ return vCRecord_Company; }
         set{ vCRecord_Company = value; vCRecord_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool VCRecord_Company_IsChanged
      {
         get{ return vCRecord_Company_IsChanged; }
         set{ vCRecord_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string vCRecord_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool vCRecord_Dept_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string VCRecord_Dept
      {
         get{ return vCRecord_Dept; }
         set{ vCRecord_Dept = value; vCRecord_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool VCRecord_Dept_IsChanged
      {
         get{ return vCRecord_Dept_IsChanged; }
         set{ vCRecord_Dept_IsChanged = value; }
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
      private string vCRecord_itype;
      private bool vCRecord_itype_IsChanged=false;
      public string VCRecord_itype
      {
         get{ return vCRecord_itype; }
         set{ vCRecord_itype = value; vCRecord_itype_IsChanged=true; }
      }
      public bool VCRecord_itype_IsChanged
      {
         get{ return vCRecord_itype_IsChanged; }
         set{ vCRecord_itype_IsChanged = value; }
      }
   }
}
