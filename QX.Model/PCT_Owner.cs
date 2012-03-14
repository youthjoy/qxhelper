using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 车辆人员安排
   /// </summary>
   [Serializable]
   public partial class PCT_Owner
   {
      private decimal pCTO_ID;
      private bool pCTO_ID_IsChanged=false;
      public decimal PCTO_ID
      {
         get{ return pCTO_ID; }
         set{ pCTO_ID = value; pCTO_ID_IsChanged=true; }
      }
      public bool PCTO_ID_IsChanged
      {
         get{ return pCTO_ID_IsChanged; }
         set{ pCTO_ID_IsChanged = value; }
      }
      private string pCTO_Code;
      private bool pCTO_Code_IsChanged=false;
      public string PCTO_Code
      {
         get{ return pCTO_Code; }
         set{ pCTO_Code = value; pCTO_Code_IsChanged=true; }
      }
      public bool PCTO_Code_IsChanged
      {
         get{ return pCTO_Code_IsChanged; }
         set{ pCTO_Code_IsChanged = value; }
      }
      private string pCTO_VCode;
      private bool pCTO_VCode_IsChanged=false;
      public string PCTO_VCode
      {
         get{ return pCTO_VCode; }
         set{ pCTO_VCode = value; pCTO_VCode_IsChanged=true; }
      }
      public bool PCTO_VCode_IsChanged
      {
         get{ return pCTO_VCode_IsChanged; }
         set{ pCTO_VCode_IsChanged = value; }
      }
      private string pCTO_VNo;
      private bool pCTO_VNo_IsChanged=false;
      public string PCTO_VNo
      {
         get{ return pCTO_VNo; }
         set{ pCTO_VNo = value; pCTO_VNo_IsChanged=true; }
      }
      public bool PCTO_VNo_IsChanged
      {
         get{ return pCTO_VNo_IsChanged; }
         set{ pCTO_VNo_IsChanged = value; }
      }
      private string pCTO_EVCode;
      private bool pCTO_EVCode_IsChanged=false;
      public string PCTO_EVCode
      {
         get{ return pCTO_EVCode; }
         set{ pCTO_EVCode = value; pCTO_EVCode_IsChanged=true; }
      }
      public bool PCTO_EVCode_IsChanged
      {
         get{ return pCTO_EVCode_IsChanged; }
         set{ pCTO_EVCode_IsChanged = value; }
      }
      private string pCTO_EName;
      private bool pCTO_EName_IsChanged=false;
      public string PCTO_EName
      {
         get{ return pCTO_EName; }
         set{ pCTO_EName = value; pCTO_EName_IsChanged=true; }
      }
      public bool PCTO_EName_IsChanged
      {
         get{ return pCTO_EName_IsChanged; }
         set{ pCTO_EName_IsChanged = value; }
      }
      private string pCTO_Contact;
      private bool pCTO_Contact_IsChanged=false;
      public string PCTO_Contact
      {
         get{ return pCTO_Contact; }
         set{ pCTO_Contact = value; pCTO_Contact_IsChanged=true; }
      }
      public bool PCTO_Contact_IsChanged
      {
         get{ return pCTO_Contact_IsChanged; }
         set{ pCTO_Contact_IsChanged = value; }
      }
      private string pCTO_Batch;
      private bool pCTO_Batch_IsChanged=false;
      public string PCTO_Batch
      {
         get{ return pCTO_Batch; }
         set{ pCTO_Batch = value; pCTO_Batch_IsChanged=true; }
      }
      public bool PCTO_Batch_IsChanged
      {
         get{ return pCTO_Batch_IsChanged; }
         set{ pCTO_Batch_IsChanged = value; }
      }
      private string pCTO_Description;
      private bool pCTO_Description_IsChanged=false;
      public string PCTO_Description
      {
         get{ return pCTO_Description; }
         set{ pCTO_Description = value; pCTO_Description_IsChanged=true; }
      }
      public bool PCTO_Description_IsChanged
      {
         get{ return pCTO_Description_IsChanged; }
         set{ pCTO_Description_IsChanged = value; }
      }
      private DateTime pCTO_BeginDate;
      private bool pCTO_BeginDate_IsChanged=false;
      public DateTime PCTO_BeginDate
      {
         get{ return pCTO_BeginDate; }
         set{ pCTO_BeginDate = value; pCTO_BeginDate_IsChanged=true; }
      }
      public bool PCTO_BeginDate_IsChanged
      {
         get{ return pCTO_BeginDate_IsChanged; }
         set{ pCTO_BeginDate_IsChanged = value; }
      }
      private DateTime pCTO_EndDate;
      private bool pCTO_EndDate_IsChanged=false;
      public DateTime PCTO_EndDate
      {
         get{ return pCTO_EndDate; }
         set{ pCTO_EndDate = value; pCTO_EndDate_IsChanged=true; }
      }
      public bool PCTO_EndDate_IsChanged
      {
         get{ return pCTO_EndDate_IsChanged; }
         set{ pCTO_EndDate_IsChanged = value; }
      }
      private string pCTO_iType;
      private bool pCTO_iType_IsChanged=false;
      public string PCTO_iType
      {
         get{ return pCTO_iType; }
         set{ pCTO_iType = value; pCTO_iType_IsChanged=true; }
      }
      public bool PCTO_iType_IsChanged
      {
         get{ return pCTO_iType_IsChanged; }
         set{ pCTO_iType_IsChanged = value; }
      }
      private string pCTO_Remark;
      private bool pCTO_Remark_IsChanged=false;
      public string PCTO_Remark
      {
         get{ return pCTO_Remark; }
         set{ pCTO_Remark = value; pCTO_Remark_IsChanged=true; }
      }
      public bool PCTO_Remark_IsChanged
      {
         get{ return pCTO_Remark_IsChanged; }
         set{ pCTO_Remark_IsChanged = value; }
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
      private string pCTO_IsDefault;
      private bool pCTO_IsDefault_IsChanged=false;
      public string PCTO_IsDefault
      {
         get{ return pCTO_IsDefault; }
         set{ pCTO_IsDefault = value; pCTO_IsDefault_IsChanged=true; }
      }
      public bool PCTO_IsDefault_IsChanged
      {
         get{ return pCTO_IsDefault_IsChanged; }
         set{ pCTO_IsDefault_IsChanged = value; }
      }
      private string pCTO_TCode;
      private bool pCTO_TCode_IsChanged=false;
      public string PCTO_TCode
      {
         get{ return pCTO_TCode; }
         set{ pCTO_TCode = value; pCTO_TCode_IsChanged=true; }
      }
      public bool PCTO_TCode_IsChanged
      {
         get{ return pCTO_TCode_IsChanged; }
         set{ pCTO_TCode_IsChanged = value; }
      }
   }
}
