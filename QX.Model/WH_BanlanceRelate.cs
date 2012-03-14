using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 结算单关联表
   /// </summary>
   [Serializable]
   public partial class WH_BanlanceRelate
   {
      /// <summary>
      /// 序列号
      /// </summary>
      private decimal wHR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_ID_IsChanged=false;
      /// <summary>
      /// 序列号
      /// </summary>
      public decimal WHR_ID
      {
         get{ return wHR_ID; }
         set{ wHR_ID = value; wHR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 序列号
      /// </summary>
      public bool WHR_ID_IsChanged
      {
         get{ return wHR_ID_IsChanged; }
         set{ wHR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 编码
      /// </summary>
      private string wHR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_Code_IsChanged=false;
      /// <summary>
      /// 编码
      /// </summary>
      public string WHR_Code
      {
         get{ return wHR_Code; }
         set{ wHR_Code = value; wHR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 编码
      /// </summary>
      public bool WHR_Code_IsChanged
      {
         get{ return wHR_Code_IsChanged; }
         set{ wHR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 帐期
      /// </summary>
      private string wHR_Period;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_Period_IsChanged=false;
      /// <summary>
      /// 帐期
      /// </summary>
      public string WHR_Period
      {
         get{ return wHR_Period; }
         set{ wHR_Period = value; wHR_Period_IsChanged=true; }
      }
      /// <summary>
      /// 帐期
      /// </summary>
      public bool WHR_Period_IsChanged
      {
         get{ return wHR_Period_IsChanged; }
         set{ wHR_Period_IsChanged = value; }
      }
      /// <summary>
      /// 结算单编码
      /// </summary>
      private string wHR_BCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_BCode_IsChanged=false;
      /// <summary>
      /// 结算单编码
      /// </summary>
      public string WHR_BCode
      {
         get{ return wHR_BCode; }
         set{ wHR_BCode = value; wHR_BCode_IsChanged=true; }
      }
      /// <summary>
      /// 结算单编码
      /// </summary>
      public bool WHR_BCode_IsChanged
      {
         get{ return wHR_BCode_IsChanged; }
         set{ wHR_BCode_IsChanged = value; }
      }
      /// <summary>
      /// 结算单类型
      /// </summary>
      private string wHR_BType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_BType_IsChanged=false;
      /// <summary>
      /// 结算单类型
      /// </summary>
      public string WHR_BType
      {
         get{ return wHR_BType; }
         set{ wHR_BType = value; wHR_BType_IsChanged=true; }
      }
      /// <summary>
      /// 结算单类型
      /// </summary>
      public bool WHR_BType_IsChanged
      {
         get{ return wHR_BType_IsChanged; }
         set{ wHR_BType_IsChanged = value; }
      }
      /// <summary>
      /// 结算单金额
      /// </summary>
      private decimal wHR_BCurMonth;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_BCurMonth_IsChanged=false;
      /// <summary>
      /// 结算单金额
      /// </summary>
      public decimal WHR_BCurMonth
      {
         get{ return wHR_BCurMonth; }
         set{ wHR_BCurMonth = value; wHR_BCurMonth_IsChanged=true; }
      }
      /// <summary>
      /// 结算单金额
      /// </summary>
      public bool WHR_BCurMonth_IsChanged
      {
         get{ return wHR_BCurMonth_IsChanged; }
         set{ wHR_BCurMonth_IsChanged = value; }
      }
      /// <summary>
      /// 关联类型
      /// </summary>
      private string wHR_RefType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_RefType_IsChanged=false;
      /// <summary>
      /// 关联类型
      /// </summary>
      public string WHR_RefType
      {
         get{ return wHR_RefType; }
         set{ wHR_RefType = value; wHR_RefType_IsChanged=true; }
      }
      /// <summary>
      /// 关联类型
      /// </summary>
      public bool WHR_RefType_IsChanged
      {
         get{ return wHR_RefType_IsChanged; }
         set{ wHR_RefType_IsChanged = value; }
      }
      /// <summary>
      /// 关联单据
      /// </summary>
      private string wHR_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_RefCode_IsChanged=false;
      /// <summary>
      /// 关联单据
      /// </summary>
      public string WHR_RefCode
      {
         get{ return wHR_RefCode; }
         set{ wHR_RefCode = value; wHR_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 关联单据
      /// </summary>
      public bool WHR_RefCode_IsChanged
      {
         get{ return wHR_RefCode_IsChanged; }
         set{ wHR_RefCode_IsChanged = value; }
      }
      /// <summary>
      /// 单据金额
      /// </summary>
      private decimal wHR_RefDMoney;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_RefDMoney_IsChanged=false;
      /// <summary>
      /// 单据金额
      /// </summary>
      public decimal WHR_RefDMoney
      {
         get{ return wHR_RefDMoney; }
         set{ wHR_RefDMoney = value; wHR_RefDMoney_IsChanged=true; }
      }
      /// <summary>
      /// 单据金额
      /// </summary>
      public bool WHR_RefDMoney_IsChanged
      {
         get{ return wHR_RefDMoney_IsChanged; }
         set{ wHR_RefDMoney_IsChanged = value; }
      }
      /// <summary>
      /// 核销金额
      /// </summary>
      private decimal wHR_RefRMoney;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_RefRMoney_IsChanged=false;
      /// <summary>
      /// 核销金额
      /// </summary>
      public decimal WHR_RefRMoney
      {
         get{ return wHR_RefRMoney; }
         set{ wHR_RefRMoney = value; wHR_RefRMoney_IsChanged=true; }
      }
      /// <summary>
      /// 核销金额
      /// </summary>
      public bool WHR_RefRMoney_IsChanged
      {
         get{ return wHR_RefRMoney_IsChanged; }
         set{ wHR_RefRMoney_IsChanged = value; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      private string wHR_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_Operator_IsChanged=false;
      /// <summary>
      /// 操作人
      /// </summary>
      public string WHR_Operator
      {
         get{ return wHR_Operator; }
         set{ wHR_Operator = value; wHR_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      public bool WHR_Operator_IsChanged
      {
         get{ return wHR_Operator_IsChanged; }
         set{ wHR_Operator_IsChanged = value; }
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
      private string wHR_UDEF1;
      private bool wHR_UDEF1_IsChanged=false;
      public string WHR_UDEF1
      {
         get{ return wHR_UDEF1; }
         set{ wHR_UDEF1 = value; wHR_UDEF1_IsChanged=true; }
      }
      public bool WHR_UDEF1_IsChanged
      {
         get{ return wHR_UDEF1_IsChanged; }
         set{ wHR_UDEF1_IsChanged = value; }
      }
      private string wHR_UDEF2;
      private bool wHR_UDEF2_IsChanged=false;
      public string WHR_UDEF2
      {
         get{ return wHR_UDEF2; }
         set{ wHR_UDEF2 = value; wHR_UDEF2_IsChanged=true; }
      }
      public bool WHR_UDEF2_IsChanged
      {
         get{ return wHR_UDEF2_IsChanged; }
         set{ wHR_UDEF2_IsChanged = value; }
      }
      private string wHR_UDEF3;
      private bool wHR_UDEF3_IsChanged=false;
      public string WHR_UDEF3
      {
         get{ return wHR_UDEF3; }
         set{ wHR_UDEF3 = value; wHR_UDEF3_IsChanged=true; }
      }
      public bool WHR_UDEF3_IsChanged
      {
         get{ return wHR_UDEF3_IsChanged; }
         set{ wHR_UDEF3_IsChanged = value; }
      }
      private string wHR_UDEF4;
      private bool wHR_UDEF4_IsChanged=false;
      public string WHR_UDEF4
      {
         get{ return wHR_UDEF4; }
         set{ wHR_UDEF4 = value; wHR_UDEF4_IsChanged=true; }
      }
      public bool WHR_UDEF4_IsChanged
      {
         get{ return wHR_UDEF4_IsChanged; }
         set{ wHR_UDEF4_IsChanged = value; }
      }
      private string wHR_UDEF5;
      private bool wHR_UDEF5_IsChanged=false;
      public string WHR_UDEF5
      {
         get{ return wHR_UDEF5; }
         set{ wHR_UDEF5 = value; wHR_UDEF5_IsChanged=true; }
      }
      public bool WHR_UDEF5_IsChanged
      {
         get{ return wHR_UDEF5_IsChanged; }
         set{ wHR_UDEF5_IsChanged = value; }
      }
      private string wHR_UDEF6;
      private bool wHR_UDEF6_IsChanged=false;
      public string WHR_UDEF6
      {
         get{ return wHR_UDEF6; }
         set{ wHR_UDEF6 = value; wHR_UDEF6_IsChanged=true; }
      }
      public bool WHR_UDEF6_IsChanged
      {
         get{ return wHR_UDEF6_IsChanged; }
         set{ wHR_UDEF6_IsChanged = value; }
      }
      private string wHR_UDEF7;
      private bool wHR_UDEF7_IsChanged=false;
      public string WHR_UDEF7
      {
         get{ return wHR_UDEF7; }
         set{ wHR_UDEF7 = value; wHR_UDEF7_IsChanged=true; }
      }
      public bool WHR_UDEF7_IsChanged
      {
         get{ return wHR_UDEF7_IsChanged; }
         set{ wHR_UDEF7_IsChanged = value; }
      }
      private string wHR_UDEF8;
      private bool wHR_UDEF8_IsChanged=false;
      public string WHR_UDEF8
      {
         get{ return wHR_UDEF8; }
         set{ wHR_UDEF8 = value; wHR_UDEF8_IsChanged=true; }
      }
      public bool WHR_UDEF8_IsChanged
      {
         get{ return wHR_UDEF8_IsChanged; }
         set{ wHR_UDEF8_IsChanged = value; }
      }
      private string wHR_UDEF9;
      private bool wHR_UDEF9_IsChanged=false;
      public string WHR_UDEF9
      {
         get{ return wHR_UDEF9; }
         set{ wHR_UDEF9 = value; wHR_UDEF9_IsChanged=true; }
      }
      public bool WHR_UDEF9_IsChanged
      {
         get{ return wHR_UDEF9_IsChanged; }
         set{ wHR_UDEF9_IsChanged = value; }
      }
      private string wHR_UDEF10;
      private bool wHR_UDEF10_IsChanged=false;
      public string WHR_UDEF10
      {
         get{ return wHR_UDEF10; }
         set{ wHR_UDEF10 = value; wHR_UDEF10_IsChanged=true; }
      }
      public bool WHR_UDEF10_IsChanged
      {
         get{ return wHR_UDEF10_IsChanged; }
         set{ wHR_UDEF10_IsChanged = value; }
      }
   }
}
