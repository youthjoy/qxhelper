using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 合同主数据
   /// </summary>
   [Serializable]
   public partial class WH_Contract
   {
      /// <summary>
      /// 合同序号
      /// </summary>
      private decimal contract_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_ID_IsChanged=false;
      /// <summary>
      /// 合同序号
      /// </summary>
      public decimal Contract_ID
      {
         get{ return contract_ID; }
         set{ contract_ID = value; contract_ID_IsChanged=true; }
      }
      /// <summary>
      /// 合同序号
      /// </summary>
      public bool Contract_ID_IsChanged
      {
         get{ return contract_ID_IsChanged; }
         set{ contract_ID_IsChanged = value; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      private string contract_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Code_IsChanged=false;
      /// <summary>
      /// 合同编码
      /// </summary>
      public string Contract_Code
      {
         get{ return contract_Code; }
         set{ contract_Code = value; contract_Code_IsChanged=true; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      public bool Contract_Code_IsChanged
      {
         get{ return contract_Code_IsChanged; }
         set{ contract_Code_IsChanged = value; }
      }
      /// <summary>
      /// 合同名称
      /// </summary>
      private string contract_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Name_IsChanged=false;
      /// <summary>
      /// 合同名称
      /// </summary>
      public string Contract_Name
      {
         get{ return contract_Name; }
         set{ contract_Name = value; contract_Name_IsChanged=true; }
      }
      /// <summary>
      /// 合同名称
      /// </summary>
      public bool Contract_Name_IsChanged
      {
         get{ return contract_Name_IsChanged; }
         set{ contract_Name_IsChanged = value; }
      }
      /// <summary>
      /// 合同类型
      /// </summary>
      private string contract_Func;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Func_IsChanged=false;
      /// <summary>
      /// 合同类型
      /// </summary>
      public string Contract_Func
      {
         get{ return contract_Func; }
         set{ contract_Func = value; contract_Func_IsChanged=true; }
      }
      /// <summary>
      /// 合同类型
      /// </summary>
      public bool Contract_Func_IsChanged
      {
         get{ return contract_Func_IsChanged; }
         set{ contract_Func_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string contract_CustCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_CustCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string Contract_CustCode
      {
         get{ return contract_CustCode; }
         set{ contract_CustCode = value; contract_CustCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool Contract_CustCode_IsChanged
      {
         get{ return contract_CustCode_IsChanged; }
         set{ contract_CustCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      private string contract_CustName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_CustName_IsChanged=false;
      /// <summary>
      /// 客户名称
      /// </summary>
      public string Contract_CustName
      {
         get{ return contract_CustName; }
         set{ contract_CustName = value; contract_CustName_IsChanged=true; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      public bool Contract_CustName_IsChanged
      {
         get{ return contract_CustName_IsChanged; }
         set{ contract_CustName_IsChanged = value; }
      }
      /// <summary>
      /// 签约形式
      /// </summary>
      private string contract_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Type_IsChanged=false;
      /// <summary>
      /// 签约形式
      /// </summary>
      public string Contract_Type
      {
         get{ return contract_Type; }
         set{ contract_Type = value; contract_Type_IsChanged=true; }
      }
      /// <summary>
      /// 签约形式
      /// </summary>
      public bool Contract_Type_IsChanged
      {
         get{ return contract_Type_IsChanged; }
         set{ contract_Type_IsChanged = value; }
      }
      /// <summary>
      /// 合同摘要
      /// </summary>
      private string contract_Abs;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool contract_Abs_IsChanged=false;
      /// <summary>
      /// 合同摘要
      /// </summary>
      public string Contract_Abs
      {
         get{ return contract_Abs; }
         set{ contract_Abs = value; contract_Abs_IsChanged=true; }
      }
      /// <summary>
      /// 合同摘要
      /// </summary>
      public bool Contract_Abs_IsChanged
      {
         get{ return contract_Abs_IsChanged; }
         set{ contract_Abs_IsChanged = value; }
      }
      private DateTime contract_Start;
      private bool contract_Start_IsChanged=false;
      public DateTime Contract_Start
      {
         get{ return contract_Start; }
         set{ contract_Start = value; contract_Start_IsChanged=true; }
      }
      public bool Contract_Start_IsChanged
      {
         get{ return contract_Start_IsChanged; }
         set{ contract_Start_IsChanged = value; }
      }
      private DateTime contract_End;
      private bool contract_End_IsChanged=false;
      public DateTime Contract_End
      {
         get{ return contract_End; }
         set{ contract_End = value; contract_End_IsChanged=true; }
      }
      public bool Contract_End_IsChanged
      {
         get{ return contract_End_IsChanged; }
         set{ contract_End_IsChanged = value; }
      }
      private decimal contract_Sum;
      private bool contract_Sum_IsChanged=false;
      public decimal Contract_Sum
      {
         get{ return contract_Sum; }
         set{ contract_Sum = value; contract_Sum_IsChanged=true; }
      }
      public bool Contract_Sum_IsChanged
      {
         get{ return contract_Sum_IsChanged; }
         set{ contract_Sum_IsChanged = value; }
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
      private string contract_RefType;
      private bool contract_RefType_IsChanged=false;
      public string Contract_RefType
      {
         get{ return contract_RefType; }
         set{ contract_RefType = value; contract_RefType_IsChanged=true; }
      }
      public bool Contract_RefType_IsChanged
      {
         get{ return contract_RefType_IsChanged; }
         set{ contract_RefType_IsChanged = value; }
      }
      private string contract_RefCode;
      private bool contract_RefCode_IsChanged=false;
      public string Contract_RefCode
      {
         get{ return contract_RefCode; }
         set{ contract_RefCode = value; contract_RefCode_IsChanged=true; }
      }
      public bool Contract_RefCode_IsChanged
      {
         get{ return contract_RefCode_IsChanged; }
         set{ contract_RefCode_IsChanged = value; }
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
