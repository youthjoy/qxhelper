using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 物料盘存表
   /// </summary>
   [Serializable]
   public partial class WH_CheckList
   {
      /// <summary>
      /// 盘存序号
      /// </summary>
      private decimal cL_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_ID_IsChanged=false;
      /// <summary>
      /// 盘存序号
      /// </summary>
      public decimal CL_ID
      {
         get{ return cL_ID; }
         set{ cL_ID = value; cL_ID_IsChanged=true; }
      }
      /// <summary>
      /// 盘存序号
      /// </summary>
      public bool CL_ID_IsChanged
      {
         get{ return cL_ID_IsChanged; }
         set{ cL_ID_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string cL_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string CL_MCode
      {
         get{ return cL_MCode; }
         set{ cL_MCode = value; cL_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool CL_MCode_IsChanged
      {
         get{ return cL_MCode_IsChanged; }
         set{ cL_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string cL_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string CL_MName
      {
         get{ return cL_MName; }
         set{ cL_MName = value; cL_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool CL_MName_IsChanged
      {
         get{ return cL_MName_IsChanged; }
         set{ cL_MName_IsChanged = value; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      private string cL_MSpec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_MSpec_IsChanged=false;
      /// <summary>
      /// 规格
      /// </summary>
      public string CL_MSpec
      {
         get{ return cL_MSpec; }
         set{ cL_MSpec = value; cL_MSpec_IsChanged=true; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      public bool CL_MSpec_IsChanged
      {
         get{ return cL_MSpec_IsChanged; }
         set{ cL_MSpec_IsChanged = value; }
      }
      /// <summary>
      /// 盘存月份
      /// </summary>
      private string cL_Month;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_Month_IsChanged=false;
      /// <summary>
      /// 盘存月份
      /// </summary>
      public string CL_Month
      {
         get{ return cL_Month; }
         set{ cL_Month = value; cL_Month_IsChanged=true; }
      }
      /// <summary>
      /// 盘存月份
      /// </summary>
      public bool CL_Month_IsChanged
      {
         get{ return cL_Month_IsChanged; }
         set{ cL_Month_IsChanged = value; }
      }
      /// <summary>
      /// 上月结余
      /// </summary>
      private string cL_Last;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_Last_IsChanged=false;
      /// <summary>
      /// 上月结余
      /// </summary>
      public string CL_Last
      {
         get{ return cL_Last; }
         set{ cL_Last = value; cL_Last_IsChanged=true; }
      }
      /// <summary>
      /// 上月结余
      /// </summary>
      public bool CL_Last_IsChanged
      {
         get{ return cL_Last_IsChanged; }
         set{ cL_Last_IsChanged = value; }
      }
      /// <summary>
      /// 本月进货
      /// </summary>
      private string cL_In;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_In_IsChanged=false;
      /// <summary>
      /// 本月进货
      /// </summary>
      public string CL_In
      {
         get{ return cL_In; }
         set{ cL_In = value; cL_In_IsChanged=true; }
      }
      /// <summary>
      /// 本月进货
      /// </summary>
      public bool CL_In_IsChanged
      {
         get{ return cL_In_IsChanged; }
         set{ cL_In_IsChanged = value; }
      }
      /// <summary>
      /// 本月出货
      /// </summary>
      private string cL_Out;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_Out_IsChanged=false;
      /// <summary>
      /// 本月出货
      /// </summary>
      public string CL_Out
      {
         get{ return cL_Out; }
         set{ cL_Out = value; cL_Out_IsChanged=true; }
      }
      /// <summary>
      /// 本月出货
      /// </summary>
      public bool CL_Out_IsChanged
      {
         get{ return cL_Out_IsChanged; }
         set{ cL_Out_IsChanged = value; }
      }
      /// <summary>
      /// 本月帐存
      /// </summary>
      private string cL_Current;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_Current_IsChanged=false;
      /// <summary>
      /// 本月帐存
      /// </summary>
      public string CL_Current
      {
         get{ return cL_Current; }
         set{ cL_Current = value; cL_Current_IsChanged=true; }
      }
      /// <summary>
      /// 本月帐存
      /// </summary>
      public bool CL_Current_IsChanged
      {
         get{ return cL_Current_IsChanged; }
         set{ cL_Current_IsChanged = value; }
      }
      /// <summary>
      /// 本月盘存
      /// </summary>
      private string cL_CIn;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_CIn_IsChanged=false;
      /// <summary>
      /// 本月盘存
      /// </summary>
      public string CL_CIn
      {
         get{ return cL_CIn; }
         set{ cL_CIn = value; cL_CIn_IsChanged=true; }
      }
      /// <summary>
      /// 本月盘存
      /// </summary>
      public bool CL_CIn_IsChanged
      {
         get{ return cL_CIn_IsChanged; }
         set{ cL_CIn_IsChanged = value; }
      }
      /// <summary>
      /// 盈亏
      /// </summary>
      private string cL_Mid;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_Mid_IsChanged=false;
      /// <summary>
      /// 盈亏
      /// </summary>
      public string CL_Mid
      {
         get{ return cL_Mid; }
         set{ cL_Mid = value; cL_Mid_IsChanged=true; }
      }
      /// <summary>
      /// 盈亏
      /// </summary>
      public bool CL_Mid_IsChanged
      {
         get{ return cL_Mid_IsChanged; }
         set{ cL_Mid_IsChanged = value; }
      }
      /// <summary>
      /// 调整后消耗
      /// </summary>
      private string cL_LOut;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_LOut_IsChanged=false;
      /// <summary>
      /// 调整后消耗
      /// </summary>
      public string CL_LOut
      {
         get{ return cL_LOut; }
         set{ cL_LOut = value; cL_LOut_IsChanged=true; }
      }
      /// <summary>
      /// 调整后消耗
      /// </summary>
      public bool CL_LOut_IsChanged
      {
         get{ return cL_LOut_IsChanged; }
         set{ cL_LOut_IsChanged = value; }
      }
      /// <summary>
      /// 盘点时间
      /// </summary>
      private DateTime cL_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_Date_IsChanged=false;
      /// <summary>
      /// 盘点时间
      /// </summary>
      public DateTime CL_Date
      {
         get{ return cL_Date; }
         set{ cL_Date = value; cL_Date_IsChanged=true; }
      }
      /// <summary>
      /// 盘点时间
      /// </summary>
      public bool CL_Date_IsChanged
      {
         get{ return cL_Date_IsChanged; }
         set{ cL_Date_IsChanged = value; }
      }
      /// <summary>
      /// 盘点人1
      /// </summary>
      private string cL_Stuff1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_Stuff1_IsChanged=false;
      /// <summary>
      /// 盘点人1
      /// </summary>
      public string CL_Stuff1
      {
         get{ return cL_Stuff1; }
         set{ cL_Stuff1 = value; cL_Stuff1_IsChanged=true; }
      }
      /// <summary>
      /// 盘点人1
      /// </summary>
      public bool CL_Stuff1_IsChanged
      {
         get{ return cL_Stuff1_IsChanged; }
         set{ cL_Stuff1_IsChanged = value; }
      }
      /// <summary>
      /// 盘点人2
      /// </summary>
      private string cL_Stuff2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_Stuff2_IsChanged=false;
      /// <summary>
      /// 盘点人2
      /// </summary>
      public string CL_Stuff2
      {
         get{ return cL_Stuff2; }
         set{ cL_Stuff2 = value; cL_Stuff2_IsChanged=true; }
      }
      /// <summary>
      /// 盘点人2
      /// </summary>
      public bool CL_Stuff2_IsChanged
      {
         get{ return cL_Stuff2_IsChanged; }
         set{ cL_Stuff2_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string cL_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cL_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string CL_Bak
      {
         get{ return cL_Bak; }
         set{ cL_Bak = value; cL_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool CL_Bak_IsChanged
      {
         get{ return cL_Bak_IsChanged; }
         set{ cL_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 创建人
      /// </summary>
      private string creator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool creator_IsChanged=false;
      /// <summary>
      /// 创建人
      /// </summary>
      public string Creator
      {
         get{ return creator; }
         set{ creator = value; creator_IsChanged=true; }
      }
      /// <summary>
      /// 创建人
      /// </summary>
      public bool Creator_IsChanged
      {
         get{ return creator_IsChanged; }
         set{ creator_IsChanged = value; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      private DateTime createTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool createTime_IsChanged=false;
      /// <summary>
      /// 创建时间
      /// </summary>
      public DateTime CreateTime
      {
         get{ return createTime; }
         set{ createTime = value; createTime_IsChanged=true; }
      }
      /// <summary>
      /// 创建时间
      /// </summary>
      public bool CreateTime_IsChanged
      {
         get{ return createTime_IsChanged; }
         set{ createTime_IsChanged = value; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      private string verifyStuff;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyStuff_IsChanged=false;
      /// <summary>
      /// 审核人
      /// </summary>
      public string VerifyStuff
      {
         get{ return verifyStuff; }
         set{ verifyStuff = value; verifyStuff_IsChanged=true; }
      }
      /// <summary>
      /// 审核人
      /// </summary>
      public bool VerifyStuff_IsChanged
      {
         get{ return verifyStuff_IsChanged; }
         set{ verifyStuff_IsChanged = value; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      private DateTime verifyDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyDate_IsChanged=false;
      /// <summary>
      /// 审核时间
      /// </summary>
      public DateTime VerifyDate
      {
         get{ return verifyDate; }
         set{ verifyDate = value; verifyDate_IsChanged=true; }
      }
      /// <summary>
      /// 审核时间
      /// </summary>
      public bool VerifyDate_IsChanged
      {
         get{ return verifyDate_IsChanged; }
         set{ verifyDate_IsChanged = value; }
      }
      /// <summary>
      /// 合同评审阶段
      /// </summary>
      private string verifyStep;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyStep_IsChanged=false;
      /// <summary>
      /// 合同评审阶段
      /// </summary>
      public string VerifyStep
      {
         get{ return verifyStep; }
         set{ verifyStep = value; verifyStep_IsChanged=true; }
      }
      /// <summary>
      /// 合同评审阶段
      /// </summary>
      public bool VerifyStep_IsChanged
      {
         get{ return verifyStep_IsChanged; }
         set{ verifyStep_IsChanged = value; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      private string verifyStat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool verifyStat_IsChanged=false;
      /// <summary>
      /// 审核状态
      /// </summary>
      public string VerifyStat
      {
         get{ return verifyStat; }
         set{ verifyStat = value; verifyStat_IsChanged=true; }
      }
      /// <summary>
      /// 审核状态
      /// </summary>
      public bool VerifyStat_IsChanged
      {
         get{ return verifyStat_IsChanged; }
         set{ verifyStat_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
   }
}
