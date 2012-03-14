using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 车辆调度表
   /// </summary>
   [Serializable]
   public partial class PCT_Schedule
   {
      /// <summary>
      /// 车辆调度ID
      /// </summary>
      private decimal pCTS_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_ID_IsChanged=false;
      /// <summary>
      /// 车辆调度ID
      /// </summary>
      public decimal PCTS_ID
      {
         get{ return pCTS_ID; }
         set{ pCTS_ID = value; pCTS_ID_IsChanged=true; }
      }
      /// <summary>
      /// 车辆调度ID
      /// </summary>
      public bool PCTS_ID_IsChanged
      {
         get{ return pCTS_ID_IsChanged; }
         set{ pCTS_ID_IsChanged = value; }
      }
      /// <summary>
      /// 车辆调度调度编码
      /// </summary>
      private string pCTS_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_Code_IsChanged=false;
      /// <summary>
      /// 车辆调度调度编码
      /// </summary>
      public string PCTS_Code
      {
         get{ return pCTS_Code; }
         set{ pCTS_Code = value; pCTS_Code_IsChanged=true; }
      }
      /// <summary>
      /// 车辆调度调度编码
      /// </summary>
      public bool PCTS_Code_IsChanged
      {
         get{ return pCTS_Code_IsChanged; }
         set{ pCTS_Code_IsChanged = value; }
      }
      /// <summary>
      /// 车辆编码
      /// </summary>
      private string pCTS_ICode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_ICode_IsChanged=false;
      /// <summary>
      /// 车辆编码
      /// </summary>
      public string PCTS_ICode
      {
         get{ return pCTS_ICode; }
         set{ pCTS_ICode = value; pCTS_ICode_IsChanged=true; }
      }
      /// <summary>
      /// 车辆编码
      /// </summary>
      public bool PCTS_ICode_IsChanged
      {
         get{ return pCTS_ICode_IsChanged; }
         set{ pCTS_ICode_IsChanged = value; }
      }
      /// <summary>
      /// 车号
      /// </summary>
      private string pCTS_NO;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_NO_IsChanged=false;
      /// <summary>
      /// 车号
      /// </summary>
      public string PCTS_NO
      {
         get{ return pCTS_NO; }
         set{ pCTS_NO = value; pCTS_NO_IsChanged=true; }
      }
      /// <summary>
      /// 车号
      /// </summary>
      public bool PCTS_NO_IsChanged
      {
         get{ return pCTS_NO_IsChanged; }
         set{ pCTS_NO_IsChanged = value; }
      }
      /// <summary>
      /// 车牌
      /// </summary>
      private string pCTS_INO;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_INO_IsChanged=false;
      /// <summary>
      /// 车牌
      /// </summary>
      public string PCTS_INO
      {
         get{ return pCTS_INO; }
         set{ pCTS_INO = value; pCTS_INO_IsChanged=true; }
      }
      /// <summary>
      /// 车牌
      /// </summary>
      public bool PCTS_INO_IsChanged
      {
         get{ return pCTS_INO_IsChanged; }
         set{ pCTS_INO_IsChanged = value; }
      }
      /// <summary>
      /// 驾驶员
      /// </summary>
      private string pCTS_Driver;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_Driver_IsChanged=false;
      /// <summary>
      /// 驾驶员
      /// </summary>
      public string PCTS_Driver
      {
         get{ return pCTS_Driver; }
         set{ pCTS_Driver = value; pCTS_Driver_IsChanged=true; }
      }
      /// <summary>
      /// 驾驶员
      /// </summary>
      public bool PCTS_Driver_IsChanged
      {
         get{ return pCTS_Driver_IsChanged; }
         set{ pCTS_Driver_IsChanged = value; }
      }
      /// <summary>
      /// 目标地
      /// </summary>
      private string pCTS_Aim;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_Aim_IsChanged=false;
      /// <summary>
      /// 目标地
      /// </summary>
      public string PCTS_Aim
      {
         get{ return pCTS_Aim; }
         set{ pCTS_Aim = value; pCTS_Aim_IsChanged=true; }
      }
      /// <summary>
      /// 目标地
      /// </summary>
      public bool PCTS_Aim_IsChanged
      {
         get{ return pCTS_Aim_IsChanged; }
         set{ pCTS_Aim_IsChanged = value; }
      }
      /// <summary>
      /// 目的地类型
      /// </summary>
      private string pCTS_AType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_AType_IsChanged=false;
      /// <summary>
      /// 目的地类型
      /// </summary>
      public string PCTS_AType
      {
         get{ return pCTS_AType; }
         set{ pCTS_AType = value; pCTS_AType_IsChanged=true; }
      }
      /// <summary>
      /// 目的地类型
      /// </summary>
      public bool PCTS_AType_IsChanged
      {
         get{ return pCTS_AType_IsChanged; }
         set{ pCTS_AType_IsChanged = value; }
      }
      /// <summary>
      /// 调度类型
      /// </summary>
      private string pCTS_SType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_SType_IsChanged=false;
      /// <summary>
      /// 调度类型
      /// </summary>
      public string PCTS_SType
      {
         get{ return pCTS_SType; }
         set{ pCTS_SType = value; pCTS_SType_IsChanged=true; }
      }
      /// <summary>
      /// 调度类型
      /// </summary>
      public bool PCTS_SType_IsChanged
      {
         get{ return pCTS_SType_IsChanged; }
         set{ pCTS_SType_IsChanged = value; }
      }
      /// <summary>
      /// 调度时间
      /// </summary>
      private DateTime pCTS_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_Date_IsChanged=false;
      /// <summary>
      /// 调度时间
      /// </summary>
      public DateTime PCTS_Date
      {
         get{ return pCTS_Date; }
         set{ pCTS_Date = value; pCTS_Date_IsChanged=true; }
      }
      /// <summary>
      /// 调度时间
      /// </summary>
      public bool PCTS_Date_IsChanged
      {
         get{ return pCTS_Date_IsChanged; }
         set{ pCTS_Date_IsChanged = value; }
      }
      /// <summary>
      /// 调度员
      /// </summary>
      private string pCTS_Emp;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_Emp_IsChanged=false;
      /// <summary>
      /// 调度员
      /// </summary>
      public string PCTS_Emp
      {
         get{ return pCTS_Emp; }
         set{ pCTS_Emp = value; pCTS_Emp_IsChanged=true; }
      }
      /// <summary>
      /// 调度员
      /// </summary>
      public bool PCTS_Emp_IsChanged
      {
         get{ return pCTS_Emp_IsChanged; }
         set{ pCTS_Emp_IsChanged = value; }
      }
      /// <summary>
      /// 到达时间
      /// </summary>
      private DateTime pCTS_ADate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCTS_ADate_IsChanged=false;
      /// <summary>
      /// 到达时间
      /// </summary>
      public DateTime PCTS_ADate
      {
         get{ return pCTS_ADate; }
         set{ pCTS_ADate = value; pCTS_ADate_IsChanged=true; }
      }
      /// <summary>
      /// 到达时间
      /// </summary>
      public bool PCTS_ADate_IsChanged
      {
         get{ return pCTS_ADate_IsChanged; }
         set{ pCTS_ADate_IsChanged = value; }
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
      private string pCTS_Stat;
      private bool pCTS_Stat_IsChanged=false;
      public string PCTS_Stat
      {
         get{ return pCTS_Stat; }
         set{ pCTS_Stat = value; pCTS_Stat_IsChanged=true; }
      }
      public bool PCTS_Stat_IsChanged
      {
         get{ return pCTS_Stat_IsChanged; }
         set{ pCTS_Stat_IsChanged = value; }
      }
      private string pCTS_TankerStat;
      private bool pCTS_TankerStat_IsChanged=false;
      public string PCTS_TankerStat
      {
         get{ return pCTS_TankerStat; }
         set{ pCTS_TankerStat = value; pCTS_TankerStat_IsChanged=true; }
      }
      public bool PCTS_TankerStat_IsChanged
      {
         get{ return pCTS_TankerStat_IsChanged; }
         set{ pCTS_TankerStat_IsChanged = value; }
      }
      private string pCTS_Udef1;
      private bool pCTS_Udef1_IsChanged=false;
      public string PCTS_Udef1
      {
         get{ return pCTS_Udef1; }
         set{ pCTS_Udef1 = value; pCTS_Udef1_IsChanged=true; }
      }
      public bool PCTS_Udef1_IsChanged
      {
         get{ return pCTS_Udef1_IsChanged; }
         set{ pCTS_Udef1_IsChanged = value; }
      }
      private string pCTS_Udef2;
      private bool pCTS_Udef2_IsChanged=false;
      public string PCTS_Udef2
      {
         get{ return pCTS_Udef2; }
         set{ pCTS_Udef2 = value; pCTS_Udef2_IsChanged=true; }
      }
      public bool PCTS_Udef2_IsChanged
      {
         get{ return pCTS_Udef2_IsChanged; }
         set{ pCTS_Udef2_IsChanged = value; }
      }
      private string pCTS_Udef3;
      private bool pCTS_Udef3_IsChanged=false;
      public string PCTS_Udef3
      {
         get{ return pCTS_Udef3; }
         set{ pCTS_Udef3 = value; pCTS_Udef3_IsChanged=true; }
      }
      public bool PCTS_Udef3_IsChanged
      {
         get{ return pCTS_Udef3_IsChanged; }
         set{ pCTS_Udef3_IsChanged = value; }
      }
      private string pCTS_Udef4;
      private bool pCTS_Udef4_IsChanged=false;
      public string PCTS_Udef4
      {
         get{ return pCTS_Udef4; }
         set{ pCTS_Udef4 = value; pCTS_Udef4_IsChanged=true; }
      }
      public bool PCTS_Udef4_IsChanged
      {
         get{ return pCTS_Udef4_IsChanged; }
         set{ pCTS_Udef4_IsChanged = value; }
      }
      private string pCTS_Udef5;
      private bool pCTS_Udef5_IsChanged=false;
      public string PCTS_Udef5
      {
         get{ return pCTS_Udef5; }
         set{ pCTS_Udef5 = value; pCTS_Udef5_IsChanged=true; }
      }
      public bool PCTS_Udef5_IsChanged
      {
         get{ return pCTS_Udef5_IsChanged; }
         set{ pCTS_Udef5_IsChanged = value; }
      }
   }
}
