using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 计划准备记录
   /// </summary>
   [Serializable]
   public partial class PC_PStatus
   {
      private decimal pCPS_ID;
      private bool pCPS_ID_IsChanged=false;
      public decimal PCPS_ID
      {
         get{ return pCPS_ID; }
         set{ pCPS_ID = value; pCPS_ID_IsChanged=true; }
      }
      public bool PCPS_ID_IsChanged
      {
         get{ return pCPS_ID_IsChanged; }
         set{ pCPS_ID_IsChanged = value; }
      }
      private string pCPS_Code;
      private bool pCPS_Code_IsChanged=false;
      public string PCPS_Code
      {
         get{ return pCPS_Code; }
         set{ pCPS_Code = value; pCPS_Code_IsChanged=true; }
      }
      public bool PCPS_Code_IsChanged
      {
         get{ return pCPS_Code_IsChanged; }
         set{ pCPS_Code_IsChanged = value; }
      }
      private string pCPS_PlanCode;
      private bool pCPS_PlanCode_IsChanged=false;
      public string PCPS_PlanCode
      {
         get{ return pCPS_PlanCode; }
         set{ pCPS_PlanCode = value; pCPS_PlanCode_IsChanged=true; }
      }
      public bool PCPS_PlanCode_IsChanged
      {
         get{ return pCPS_PlanCode_IsChanged; }
         set{ pCPS_PlanCode_IsChanged = value; }
      }
      private string pCPS_SType;
      private bool pCPS_SType_IsChanged=false;
      public string PCPS_SType
      {
         get{ return pCPS_SType; }
         set{ pCPS_SType = value; pCPS_SType_IsChanged=true; }
      }
      public bool PCPS_SType_IsChanged
      {
         get{ return pCPS_SType_IsChanged; }
         set{ pCPS_SType_IsChanged = value; }
      }
      private decimal pCPS_SVal;
      private bool pCPS_SVal_IsChanged=false;
      public decimal PCPS_SVal
      {
         get{ return pCPS_SVal; }
         set{ pCPS_SVal = value; pCPS_SVal_IsChanged=true; }
      }
      public bool PCPS_SVal_IsChanged
      {
         get{ return pCPS_SVal_IsChanged; }
         set{ pCPS_SVal_IsChanged = value; }
      }
      private DateTime pCPS_RDate;
      private bool pCPS_RDate_IsChanged=false;
      public DateTime PCPS_RDate
      {
         get{ return pCPS_RDate; }
         set{ pCPS_RDate = value; pCPS_RDate_IsChanged=true; }
      }
      public bool PCPS_RDate_IsChanged
      {
         get{ return pCPS_RDate_IsChanged; }
         set{ pCPS_RDate_IsChanged = value; }
      }
      private string pCPS_ROperator;
      private bool pCPS_ROperator_IsChanged=false;
      public string PCPS_ROperator
      {
         get{ return pCPS_ROperator; }
         set{ pCPS_ROperator = value; pCPS_ROperator_IsChanged=true; }
      }
      public bool PCPS_ROperator_IsChanged
      {
         get{ return pCPS_ROperator_IsChanged; }
         set{ pCPS_ROperator_IsChanged = value; }
      }
      private string pCPS_Remark;
      private bool pCPS_Remark_IsChanged=false;
      public string PCPS_Remark
      {
         get{ return pCPS_Remark; }
         set{ pCPS_Remark = value; pCPS_Remark_IsChanged=true; }
      }
      public bool PCPS_Remark_IsChanged
      {
         get{ return pCPS_Remark_IsChanged; }
         set{ pCPS_Remark_IsChanged = value; }
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
