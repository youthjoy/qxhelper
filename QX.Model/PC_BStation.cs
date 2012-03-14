using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 搅拌站信息
   /// </summary>
   [Serializable]
   public partial class PC_BStation
   {
      private decimal pCBS_ID;
      private bool pCBS_ID_IsChanged=false;
      public decimal PCBS_ID
      {
         get{ return pCBS_ID; }
         set{ pCBS_ID = value; pCBS_ID_IsChanged=true; }
      }
      public bool PCBS_ID_IsChanged
      {
         get{ return pCBS_ID_IsChanged; }
         set{ pCBS_ID_IsChanged = value; }
      }
      private string pCBS_Code;
      private bool pCBS_Code_IsChanged=false;
      public string PCBS_Code
      {
         get{ return pCBS_Code; }
         set{ pCBS_Code = value; pCBS_Code_IsChanged=true; }
      }
      public bool PCBS_Code_IsChanged
      {
         get{ return pCBS_Code_IsChanged; }
         set{ pCBS_Code_IsChanged = value; }
      }
      private string pCBS_Name;
      private bool pCBS_Name_IsChanged=false;
      public string PCBS_Name
      {
         get{ return pCBS_Name; }
         set{ pCBS_Name = value; pCBS_Name_IsChanged=true; }
      }
      public bool PCBS_Name_IsChanged
      {
         get{ return pCBS_Name_IsChanged; }
         set{ pCBS_Name_IsChanged = value; }
      }
      private string pCBS_Addr;
      private bool pCBS_Addr_IsChanged=false;
      public string PCBS_Addr
      {
         get{ return pCBS_Addr; }
         set{ pCBS_Addr = value; pCBS_Addr_IsChanged=true; }
      }
      public bool PCBS_Addr_IsChanged
      {
         get{ return pCBS_Addr_IsChanged; }
         set{ pCBS_Addr_IsChanged = value; }
      }
      private DateTime pCBS_Start;
      private bool pCBS_Start_IsChanged=false;
      public DateTime PCBS_Start
      {
         get{ return pCBS_Start; }
         set{ pCBS_Start = value; pCBS_Start_IsChanged=true; }
      }
      public bool PCBS_Start_IsChanged
      {
         get{ return pCBS_Start_IsChanged; }
         set{ pCBS_Start_IsChanged = value; }
      }
      private string pCBS_Status;
      private bool pCBS_Status_IsChanged=false;
      public string PCBS_Status
      {
         get{ return pCBS_Status; }
         set{ pCBS_Status = value; pCBS_Status_IsChanged=true; }
      }
      public bool PCBS_Status_IsChanged
      {
         get{ return pCBS_Status_IsChanged; }
         set{ pCBS_Status_IsChanged = value; }
      }
      private string pCBS_Bak;
      private bool pCBS_Bak_IsChanged=false;
      public string PCBS_Bak
      {
         get{ return pCBS_Bak; }
         set{ pCBS_Bak = value; pCBS_Bak_IsChanged=true; }
      }
      public bool PCBS_Bak_IsChanged
      {
         get{ return pCBS_Bak_IsChanged; }
         set{ pCBS_Bak_IsChanged = value; }
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
      private DateTime createDate;
      private bool createDate_IsChanged=false;
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      private DateTime updateDate;
      private bool updateDate_IsChanged=false;
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      private DateTime deleteDate;
      private bool deleteDate_IsChanged=false;
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
   }
}
