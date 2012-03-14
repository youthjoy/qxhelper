using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 车辆事件表
   /// </summary>
   [Serializable]
   public partial class PCT_Event
   {
      private decimal pCTE_ID;
      private bool pCTE_ID_IsChanged=false;
      public decimal PCTE_ID
      {
         get{ return pCTE_ID; }
         set{ pCTE_ID = value; pCTE_ID_IsChanged=true; }
      }
      public bool PCTE_ID_IsChanged
      {
         get{ return pCTE_ID_IsChanged; }
         set{ pCTE_ID_IsChanged = value; }
      }
      private string pCTE_Code;
      private bool pCTE_Code_IsChanged=false;
      public string PCTE_Code
      {
         get{ return pCTE_Code; }
         set{ pCTE_Code = value; pCTE_Code_IsChanged=true; }
      }
      public bool PCTE_Code_IsChanged
      {
         get{ return pCTE_Code_IsChanged; }
         set{ pCTE_Code_IsChanged = value; }
      }
      private string pCTE_CCode;
      private bool pCTE_CCode_IsChanged=false;
      public string PCTE_CCode
      {
         get{ return pCTE_CCode; }
         set{ pCTE_CCode = value; pCTE_CCode_IsChanged=true; }
      }
      public bool PCTE_CCode_IsChanged
      {
         get{ return pCTE_CCode_IsChanged; }
         set{ pCTE_CCode_IsChanged = value; }
      }
      private string pCTE_CNo;
      private bool pCTE_CNo_IsChanged=false;
      public string PCTE_CNo
      {
         get{ return pCTE_CNo; }
         set{ pCTE_CNo = value; pCTE_CNo_IsChanged=true; }
      }
      public bool PCTE_CNo_IsChanged
      {
         get{ return pCTE_CNo_IsChanged; }
         set{ pCTE_CNo_IsChanged = value; }
      }
      private string pCTE_Description;
      private bool pCTE_Description_IsChanged=false;
      public string PCTE_Description
      {
         get{ return pCTE_Description; }
         set{ pCTE_Description = value; pCTE_Description_IsChanged=true; }
      }
      public bool PCTE_Description_IsChanged
      {
         get{ return pCTE_Description_IsChanged; }
         set{ pCTE_Description_IsChanged = value; }
      }
      private DateTime pCTE_BeginDate;
      private bool pCTE_BeginDate_IsChanged=false;
      public DateTime PCTE_BeginDate
      {
         get{ return pCTE_BeginDate; }
         set{ pCTE_BeginDate = value; pCTE_BeginDate_IsChanged=true; }
      }
      public bool PCTE_BeginDate_IsChanged
      {
         get{ return pCTE_BeginDate_IsChanged; }
         set{ pCTE_BeginDate_IsChanged = value; }
      }
      private DateTime pCTE_EndDate;
      private bool pCTE_EndDate_IsChanged=false;
      public DateTime PCTE_EndDate
      {
         get{ return pCTE_EndDate; }
         set{ pCTE_EndDate = value; pCTE_EndDate_IsChanged=true; }
      }
      public bool PCTE_EndDate_IsChanged
      {
         get{ return pCTE_EndDate_IsChanged; }
         set{ pCTE_EndDate_IsChanged = value; }
      }
      private string pCTE_EventType;
      private bool pCTE_EventType_IsChanged=false;
      public string PCTE_EventType
      {
         get{ return pCTE_EventType; }
         set{ pCTE_EventType = value; pCTE_EventType_IsChanged=true; }
      }
      public bool PCTE_EventType_IsChanged
      {
         get{ return pCTE_EventType_IsChanged; }
         set{ pCTE_EventType_IsChanged = value; }
      }
      private string pCTE_DCode;
      private bool pCTE_DCode_IsChanged=false;
      public string PCTE_DCode
      {
         get{ return pCTE_DCode; }
         set{ pCTE_DCode = value; pCTE_DCode_IsChanged=true; }
      }
      public bool PCTE_DCode_IsChanged
      {
         get{ return pCTE_DCode_IsChanged; }
         set{ pCTE_DCode_IsChanged = value; }
      }
      private string pCTE_Join;
      private bool pCTE_Join_IsChanged=false;
      public string PCTE_Join
      {
         get{ return pCTE_Join; }
         set{ pCTE_Join = value; pCTE_Join_IsChanged=true; }
      }
      public bool PCTE_Join_IsChanged
      {
         get{ return pCTE_Join_IsChanged; }
         set{ pCTE_Join_IsChanged = value; }
      }
      private decimal pCTE_Cost;
      private bool pCTE_Cost_IsChanged=false;
      public decimal PCTE_Cost
      {
         get{ return pCTE_Cost; }
         set{ pCTE_Cost = value; pCTE_Cost_IsChanged=true; }
      }
      public bool PCTE_Cost_IsChanged
      {
         get{ return pCTE_Cost_IsChanged; }
         set{ pCTE_Cost_IsChanged = value; }
      }
      private float pCTE_Before;
      private bool pCTE_Before_IsChanged=false;
      public float PCTE_Before
      {
         get{ return pCTE_Before; }
         set{ pCTE_Before = value; pCTE_Before_IsChanged=true; }
      }
      public bool PCTE_Before_IsChanged
      {
         get{ return pCTE_Before_IsChanged; }
         set{ pCTE_Before_IsChanged = value; }
      }
      private float pCTE_After;
      private bool pCTE_After_IsChanged=false;
      public float PCTE_After
      {
         get{ return pCTE_After; }
         set{ pCTE_After = value; pCTE_After_IsChanged=true; }
      }
      public bool PCTE_After_IsChanged
      {
         get{ return pCTE_After_IsChanged; }
         set{ pCTE_After_IsChanged = value; }
      }
      private string pCTE_Address;
      private bool pCTE_Address_IsChanged=false;
      public string PCTE_Address
      {
         get{ return pCTE_Address; }
         set{ pCTE_Address = value; pCTE_Address_IsChanged=true; }
      }
      public bool PCTE_Address_IsChanged
      {
         get{ return pCTE_Address_IsChanged; }
         set{ pCTE_Address_IsChanged = value; }
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
      private string pCTE_iType;
      private bool pCTE_iType_IsChanged=false;
      public string PCTE_iType
      {
         get{ return pCTE_iType; }
         set{ pCTE_iType = value; pCTE_iType_IsChanged=true; }
      }
      public bool PCTE_iType_IsChanged
      {
         get{ return pCTE_iType_IsChanged; }
         set{ pCTE_iType_IsChanged = value; }
      }
      private string pCTE_TCode;
      private bool pCTE_TCode_IsChanged=false;
      public string PCTE_TCode
      {
         get{ return pCTE_TCode; }
         set{ pCTE_TCode = value; pCTE_TCode_IsChanged=true; }
      }
      public bool PCTE_TCode_IsChanged
      {
         get{ return pCTE_TCode_IsChanged; }
         set{ pCTE_TCode_IsChanged = value; }
      }
      private string pCTE_Udef2;
      private bool pCTE_Udef2_IsChanged=false;
      public string PCTE_Udef2
      {
         get{ return pCTE_Udef2; }
         set{ pCTE_Udef2 = value; pCTE_Udef2_IsChanged=true; }
      }
      public bool PCTE_Udef2_IsChanged
      {
         get{ return pCTE_Udef2_IsChanged; }
         set{ pCTE_Udef2_IsChanged = value; }
      }
      private string pCTE_Udef3;
      private bool pCTE_Udef3_IsChanged=false;
      public string PCTE_Udef3
      {
         get{ return pCTE_Udef3; }
         set{ pCTE_Udef3 = value; pCTE_Udef3_IsChanged=true; }
      }
      public bool PCTE_Udef3_IsChanged
      {
         get{ return pCTE_Udef3_IsChanged; }
         set{ pCTE_Udef3_IsChanged = value; }
      }
      private string pCTE_Udef4;
      private bool pCTE_Udef4_IsChanged=false;
      public string PCTE_Udef4
      {
         get{ return pCTE_Udef4; }
         set{ pCTE_Udef4 = value; pCTE_Udef4_IsChanged=true; }
      }
      public bool PCTE_Udef4_IsChanged
      {
         get{ return pCTE_Udef4_IsChanged; }
         set{ pCTE_Udef4_IsChanged = value; }
      }
      private string pCTE_Udef5;
      private bool pCTE_Udef5_IsChanged=false;
      public string PCTE_Udef5
      {
         get{ return pCTE_Udef5; }
         set{ pCTE_Udef5 = value; pCTE_Udef5_IsChanged=true; }
      }
      public bool PCTE_Udef5_IsChanged
      {
         get{ return pCTE_Udef5_IsChanged; }
         set{ pCTE_Udef5_IsChanged = value; }
      }
   }
}
