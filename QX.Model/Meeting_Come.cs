using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class Meeting_Come
   {
      private decimal meetingCome_ID;
      private bool meetingCome_ID_IsChanged=false;
      public decimal MeetingCome_ID
      {
         get{ return meetingCome_ID; }
         set{ meetingCome_ID = value; meetingCome_ID_IsChanged=true; }
      }
      public bool MeetingCome_ID_IsChanged
      {
         get{ return meetingCome_ID_IsChanged; }
         set{ meetingCome_ID_IsChanged = value; }
      }
      private string meetingCome_Code;
      private bool meetingCome_Code_IsChanged=false;
      public string MeetingCome_Code
      {
         get{ return meetingCome_Code; }
         set{ meetingCome_Code = value; meetingCome_Code_IsChanged=true; }
      }
      public bool MeetingCome_Code_IsChanged
      {
         get{ return meetingCome_Code_IsChanged; }
         set{ meetingCome_Code_IsChanged = value; }
      }
      private string meetingCome_MeetCode;
      private bool meetingCome_MeetCode_IsChanged=false;
      public string MeetingCome_MeetCode
      {
         get{ return meetingCome_MeetCode; }
         set{ meetingCome_MeetCode = value; meetingCome_MeetCode_IsChanged=true; }
      }
      public bool MeetingCome_MeetCode_IsChanged
      {
         get{ return meetingCome_MeetCode_IsChanged; }
         set{ meetingCome_MeetCode_IsChanged = value; }
      }
      private string meetingCome_User;
      private bool meetingCome_User_IsChanged=false;
      public string MeetingCome_User
      {
         get{ return meetingCome_User; }
         set{ meetingCome_User = value; meetingCome_User_IsChanged=true; }
      }
      public bool MeetingCome_User_IsChanged
      {
         get{ return meetingCome_User_IsChanged; }
         set{ meetingCome_User_IsChanged = value; }
      }
      private string meetingCome_Remark;
      private bool meetingCome_Remark_IsChanged=false;
      public string MeetingCome_Remark
      {
         get{ return meetingCome_Remark; }
         set{ meetingCome_Remark = value; meetingCome_Remark_IsChanged=true; }
      }
      public bool MeetingCome_Remark_IsChanged
      {
         get{ return meetingCome_Remark_IsChanged; }
         set{ meetingCome_Remark_IsChanged = value; }
      }
      private DateTime meetingCome_Date;
      private bool meetingCome_Date_IsChanged=false;
      public DateTime MeetingCome_Date
      {
         get{ return meetingCome_Date; }
         set{ meetingCome_Date = value; meetingCome_Date_IsChanged=true; }
      }
      public bool MeetingCome_Date_IsChanged
      {
         get{ return meetingCome_Date_IsChanged; }
         set{ meetingCome_Date_IsChanged = value; }
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
