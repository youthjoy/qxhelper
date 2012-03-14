using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class GPSRecord
   {
      private decimal record_ID;
      private bool record_ID_IsChanged=false;
      public decimal Record_ID
      {
         get{ return record_ID; }
         set{ record_ID = value; record_ID_IsChanged=true; }
      }
      public bool Record_ID_IsChanged
      {
         get{ return record_ID_IsChanged; }
         set{ record_ID_IsChanged = value; }
      }
      private string license_Plate;
      private bool license_Plate_IsChanged=false;
      public string License_Plate
      {
         get{ return license_Plate; }
         set{ license_Plate = value; license_Plate_IsChanged=true; }
      }
      public bool License_Plate_IsChanged
      {
         get{ return license_Plate_IsChanged; }
         set{ license_Plate_IsChanged = value; }
      }
      private string terminal_ID;
      private bool terminal_ID_IsChanged=false;
      public string Terminal_ID
      {
         get{ return terminal_ID; }
         set{ terminal_ID = value; terminal_ID_IsChanged=true; }
      }
      public bool Terminal_ID_IsChanged
      {
         get{ return terminal_ID_IsChanged; }
         set{ terminal_ID_IsChanged = value; }
      }
      private int plateColor;
      private bool plateColor_IsChanged=false;
      public int PlateColor
      {
         get{ return plateColor; }
         set{ plateColor = value; plateColor_IsChanged=true; }
      }
      public bool PlateColor_IsChanged
      {
         get{ return plateColor_IsChanged; }
         set{ plateColor_IsChanged = value; }
      }
      private int dataType;
      private bool dataType_IsChanged=false;
      public int DataType
      {
         get{ return dataType; }
         set{ dataType = value; dataType_IsChanged=true; }
      }
      public bool DataType_IsChanged
      {
         get{ return dataType_IsChanged; }
         set{ dataType_IsChanged = value; }
      }
      private DateTime gPSTime;
      private bool gPSTime_IsChanged=false;
      public DateTime GPSTime
      {
         get{ return gPSTime; }
         set{ gPSTime = value; gPSTime_IsChanged=true; }
      }
      public bool GPSTime_IsChanged
      {
         get{ return gPSTime_IsChanged; }
         set{ gPSTime_IsChanged = value; }
      }
      private decimal longitude;
      private bool longitude_IsChanged=false;
      public decimal Longitude
      {
         get{ return longitude; }
         set{ longitude = value; longitude_IsChanged=true; }
      }
      public bool Longitude_IsChanged
      {
         get{ return longitude_IsChanged; }
         set{ longitude_IsChanged = value; }
      }
      private decimal latitude;
      private bool latitude_IsChanged=false;
      public decimal Latitude
      {
         get{ return latitude; }
         set{ latitude = value; latitude_IsChanged=true; }
      }
      public bool Latitude_IsChanged
      {
         get{ return latitude_IsChanged; }
         set{ latitude_IsChanged = value; }
      }
      private int gPSFlag;
      private bool gPSFlag_IsChanged=false;
      public int GPSFlag
      {
         get{ return gPSFlag; }
         set{ gPSFlag = value; gPSFlag_IsChanged=true; }
      }
      public bool GPSFlag_IsChanged
      {
         get{ return gPSFlag_IsChanged; }
         set{ gPSFlag_IsChanged = value; }
      }
      private int speed;
      private bool speed_IsChanged=false;
      public int Speed
      {
         get{ return speed; }
         set{ speed = value; speed_IsChanged=true; }
      }
      public bool Speed_IsChanged
      {
         get{ return speed_IsChanged; }
         set{ speed_IsChanged = value; }
      }
      private int direction;
      private bool direction_IsChanged=false;
      public int Direction
      {
         get{ return direction; }
         set{ direction = value; direction_IsChanged=true; }
      }
      public bool Direction_IsChanged
      {
         get{ return direction_IsChanged; }
         set{ direction_IsChanged = value; }
      }
      private int comm_Type;
      private bool comm_Type_IsChanged=false;
      public int Comm_Type
      {
         get{ return comm_Type; }
         set{ comm_Type = value; comm_Type_IsChanged=true; }
      }
      public bool Comm_Type_IsChanged
      {
         get{ return comm_Type_IsChanged; }
         set{ comm_Type_IsChanged = value; }
      }
      private int mDTStatus;
      private bool mDTStatus_IsChanged=false;
      public int MDTStatus
      {
         get{ return mDTStatus; }
         set{ mDTStatus = value; mDTStatus_IsChanged=true; }
      }
      public bool MDTStatus_IsChanged
      {
         get{ return mDTStatus_IsChanged; }
         set{ mDTStatus_IsChanged = value; }
      }
      private int mDTAlarm;
      private bool mDTAlarm_IsChanged=false;
      public int MDTAlarm
      {
         get{ return mDTAlarm; }
         set{ mDTAlarm = value; mDTAlarm_IsChanged=true; }
      }
      public bool MDTAlarm_IsChanged
      {
         get{ return mDTAlarm_IsChanged; }
         set{ mDTAlarm_IsChanged = value; }
      }
      private int data_Length;
      private bool data_Length_IsChanged=false;
      public int Data_Length
      {
         get{ return data_Length; }
         set{ data_Length = value; data_Length_IsChanged=true; }
      }
      public bool Data_Length_IsChanged
      {
         get{ return data_Length_IsChanged; }
         set{ data_Length_IsChanged = value; }
      }
      private string dataContend;
      private bool dataContend_IsChanged=false;
      public string DataContend
      {
         get{ return dataContend; }
         set{ dataContend = value; dataContend_IsChanged=true; }
      }
      public bool DataContend_IsChanged
      {
         get{ return dataContend_IsChanged; }
         set{ dataContend_IsChanged = value; }
      }
      private int stat;
      private bool stat_IsChanged=false;
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
      private DateTime createTime;
      private bool createTime_IsChanged=false;
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
      }
   }
}
