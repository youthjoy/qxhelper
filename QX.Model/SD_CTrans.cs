using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class SD_CTrans
   {
      /// <summary>
      /// 合同关联运距记录序号
      /// </summary>
      private decimal sDT_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDT_ID_IsChanged=false;
      /// <summary>
      /// 合同关联运距记录序号
      /// </summary>
      public decimal SDT_ID
      {
         get{ return sDT_ID; }
         set{ sDT_ID = value; sDT_ID_IsChanged=true; }
      }
      /// <summary>
      /// 合同关联运距记录序号
      /// </summary>
      public bool SDT_ID_IsChanged
      {
         get{ return sDT_ID_IsChanged; }
         set{ sDT_ID_IsChanged = value; }
      }
      private string sDT_PCode;
      private bool sDT_PCode_IsChanged=false;
      public string SDT_PCode
      {
         get{ return sDT_PCode; }
         set{ sDT_PCode = value; sDT_PCode_IsChanged=true; }
      }
      public bool SDT_PCode_IsChanged
      {
         get{ return sDT_PCode_IsChanged; }
         set{ sDT_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 合同关联运距记录编码
      /// </summary>
      private string sDT_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDT_Code_IsChanged=false;
      /// <summary>
      /// 合同关联运距记录编码
      /// </summary>
      public string SDT_Code
      {
         get{ return sDT_Code; }
         set{ sDT_Code = value; sDT_Code_IsChanged=true; }
      }
      /// <summary>
      /// 合同关联运距记录编码
      /// </summary>
      public bool SDT_Code_IsChanged
      {
         get{ return sDT_Code_IsChanged; }
         set{ sDT_Code_IsChanged = value; }
      }
      private string sDT_DName;
      private bool sDT_DName_IsChanged=false;
      public string SDT_DName
      {
         get{ return sDT_DName; }
         set{ sDT_DName = value; sDT_DName_IsChanged=true; }
      }
      public bool SDT_DName_IsChanged
      {
         get{ return sDT_DName_IsChanged; }
         set{ sDT_DName_IsChanged = value; }
      }
      /// <summary>
      /// 搅拌站编码
      /// </summary>
      private string sDT_DCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDT_DCode_IsChanged=false;
      /// <summary>
      /// 搅拌站编码
      /// </summary>
      public string SDT_DCode
      {
         get{ return sDT_DCode; }
         set{ sDT_DCode = value; sDT_DCode_IsChanged=true; }
      }
      /// <summary>
      /// 搅拌站编码
      /// </summary>
      public bool SDT_DCode_IsChanged
      {
         get{ return sDT_DCode_IsChanged; }
         set{ sDT_DCode_IsChanged = value; }
      }
      /// <summary>
      /// 测算人
      /// </summary>
      private string sDT_Owner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDT_Owner_IsChanged=false;
      /// <summary>
      /// 测算人
      /// </summary>
      public string SDT_Owner
      {
         get{ return sDT_Owner; }
         set{ sDT_Owner = value; sDT_Owner_IsChanged=true; }
      }
      /// <summary>
      /// 测算人
      /// </summary>
      public bool SDT_Owner_IsChanged
      {
         get{ return sDT_Owner_IsChanged; }
         set{ sDT_Owner_IsChanged = value; }
      }
      /// <summary>
      /// 运距
      /// </summary>
      private string sDT_Distance;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDT_Distance_IsChanged=false;
      /// <summary>
      /// 运距
      /// </summary>
      public string SDT_Distance
      {
         get{ return sDT_Distance; }
         set{ sDT_Distance = value; sDT_Distance_IsChanged=true; }
      }
      /// <summary>
      /// 运距
      /// </summary>
      public bool SDT_Distance_IsChanged
      {
         get{ return sDT_Distance_IsChanged; }
         set{ sDT_Distance_IsChanged = value; }
      }
      /// <summary>
      /// 路线编码
      /// </summary>
      private string sDT_RoadCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDT_RoadCode_IsChanged=false;
      /// <summary>
      /// 路线编码
      /// </summary>
      public string SDT_RoadCode
      {
         get{ return sDT_RoadCode; }
         set{ sDT_RoadCode = value; sDT_RoadCode_IsChanged=true; }
      }
      /// <summary>
      /// 路线编码
      /// </summary>
      public bool SDT_RoadCode_IsChanged
      {
         get{ return sDT_RoadCode_IsChanged; }
         set{ sDT_RoadCode_IsChanged = value; }
      }
      /// <summary>
      /// 运距校验值
      /// </summary>
      private decimal sDT_CheckValue;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDT_CheckValue_IsChanged=false;
      /// <summary>
      /// 运距校验值
      /// </summary>
      public decimal SDT_CheckValue
      {
         get{ return sDT_CheckValue; }
         set{ sDT_CheckValue = value; sDT_CheckValue_IsChanged=true; }
      }
      /// <summary>
      /// 运距校验值
      /// </summary>
      public bool SDT_CheckValue_IsChanged
      {
         get{ return sDT_CheckValue_IsChanged; }
         set{ sDT_CheckValue_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string sDT_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDT_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string SDT_Unit
      {
         get{ return sDT_Unit; }
         set{ sDT_Unit = value; sDT_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool SDT_Unit_IsChanged
      {
         get{ return sDT_Unit_IsChanged; }
         set{ sDT_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDT_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDT_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDT_Bak
      {
         get{ return sDT_Bak; }
         set{ sDT_Bak = value; sDT_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDT_Bak_IsChanged
      {
         get{ return sDT_Bak_IsChanged; }
         set{ sDT_Bak_IsChanged = value; }
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
      private string sDT_CarNo;
      private bool sDT_CarNo_IsChanged=false;
      public string SDT_CarNo
      {
         get{ return sDT_CarNo; }
         set{ sDT_CarNo = value; sDT_CarNo_IsChanged=true; }
      }
      public bool SDT_CarNo_IsChanged
      {
         get{ return sDT_CarNo_IsChanged; }
         set{ sDT_CarNo_IsChanged = value; }
      }
      private DateTime sDT_StartTime;
      private bool sDT_StartTime_IsChanged=false;
      public DateTime SDT_StartTime
      {
         get{ return sDT_StartTime; }
         set{ sDT_StartTime = value; sDT_StartTime_IsChanged=true; }
      }
      public bool SDT_StartTime_IsChanged
      {
         get{ return sDT_StartTime_IsChanged; }
         set{ sDT_StartTime_IsChanged = value; }
      }
      private DateTime sDT_EndTime;
      private bool sDT_EndTime_IsChanged=false;
      public DateTime SDT_EndTime
      {
         get{ return sDT_EndTime; }
         set{ sDT_EndTime = value; sDT_EndTime_IsChanged=true; }
      }
      public bool SDT_EndTime_IsChanged
      {
         get{ return sDT_EndTime_IsChanged; }
         set{ sDT_EndTime_IsChanged = value; }
      }
      private decimal sDT_Pop;
      private bool sDT_Pop_IsChanged=false;
      public decimal SDT_Pop
      {
         get{ return sDT_Pop; }
         set{ sDT_Pop = value; sDT_Pop_IsChanged=true; }
      }
      public bool SDT_Pop_IsChanged
      {
         get{ return sDT_Pop_IsChanged; }
         set{ sDT_Pop_IsChanged = value; }
      }
      private decimal sDT_Lng;
      private bool sDT_Lng_IsChanged=false;
      public decimal SDT_Lng
      {
         get{ return sDT_Lng; }
         set{ sDT_Lng = value; sDT_Lng_IsChanged=true; }
      }
      public bool SDT_Lng_IsChanged
      {
         get{ return sDT_Lng_IsChanged; }
         set{ sDT_Lng_IsChanged = value; }
      }
      private decimal sDT_Lat;
      private bool sDT_Lat_IsChanged=false;
      public decimal SDT_Lat
      {
         get{ return sDT_Lat; }
         set{ sDT_Lat = value; sDT_Lat_IsChanged=true; }
      }
      public bool SDT_Lat_IsChanged
      {
         get{ return sDT_Lat_IsChanged; }
         set{ sDT_Lat_IsChanged = value; }
      }
   }
}
