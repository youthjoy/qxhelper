using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 收款
   /// </summary>
   [Serializable]
   public partial class SD_Receive
   {
      /// <summary>
      /// 收款序号
      /// </summary>
      private decimal sDPR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_ID_IsChanged=false;
      /// <summary>
      /// 收款序号
      /// </summary>
      public decimal SDPR_ID
      {
         get{ return sDPR_ID; }
         set{ sDPR_ID = value; sDPR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 收款序号
      /// </summary>
      public bool SDPR_ID_IsChanged
      {
         get{ return sDPR_ID_IsChanged; }
         set{ sDPR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 收款编码
      /// </summary>
      private string sDPR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_Code_IsChanged=false;
      /// <summary>
      /// 收款编码
      /// </summary>
      public string SDPR_Code
      {
         get{ return sDPR_Code; }
         set{ sDPR_Code = value; sDPR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 收款编码
      /// </summary>
      public bool SDPR_Code_IsChanged
      {
         get{ return sDPR_Code_IsChanged; }
         set{ sDPR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string sDPR_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string SDPR_CCode
      {
         get{ return sDPR_CCode; }
         set{ sDPR_CCode = value; sDPR_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool SDPR_CCode_IsChanged
      {
         get{ return sDPR_CCode_IsChanged; }
         set{ sDPR_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      private string sDPR_CName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_CName_IsChanged=false;
      /// <summary>
      /// 客户名称
      /// </summary>
      public string SDPR_CName
      {
         get{ return sDPR_CName; }
         set{ sDPR_CName = value; sDPR_CName_IsChanged=true; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      public bool SDPR_CName_IsChanged
      {
         get{ return sDPR_CName_IsChanged; }
         set{ sDPR_CName_IsChanged = value; }
      }
      /// <summary>
      /// 收款时间
      /// </summary>
      private DateTime sDPR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_Date_IsChanged=false;
      /// <summary>
      /// 收款时间
      /// </summary>
      public DateTime SDPR_Date
      {
         get{ return sDPR_Date; }
         set{ sDPR_Date = value; sDPR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 收款时间
      /// </summary>
      public bool SDPR_Date_IsChanged
      {
         get{ return sDPR_Date_IsChanged; }
         set{ sDPR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 收款经手人
      /// </summary>
      private string sDPR_SOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_SOwner_IsChanged=false;
      /// <summary>
      /// 收款经手人
      /// </summary>
      public string SDPR_SOwner
      {
         get{ return sDPR_SOwner; }
         set{ sDPR_SOwner = value; sDPR_SOwner_IsChanged=true; }
      }
      /// <summary>
      /// 收款经手人
      /// </summary>
      public bool SDPR_SOwner_IsChanged
      {
         get{ return sDPR_SOwner_IsChanged; }
         set{ sDPR_SOwner_IsChanged = value; }
      }
      /// <summary>
      /// 收款方式
      /// </summary>
      private string sDPR_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_Type_IsChanged=false;
      /// <summary>
      /// 收款方式
      /// </summary>
      public string SDPR_Type
      {
         get{ return sDPR_Type; }
         set{ sDPR_Type = value; sDPR_Type_IsChanged=true; }
      }
      /// <summary>
      /// 收款方式
      /// </summary>
      public bool SDPR_Type_IsChanged
      {
         get{ return sDPR_Type_IsChanged; }
         set{ sDPR_Type_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal sDPR_Sum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_Sum_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal SDPR_Sum
      {
         get{ return sDPR_Sum; }
         set{ sDPR_Sum = value; sDPR_Sum_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool SDPR_Sum_IsChanged
      {
         get{ return sDPR_Sum_IsChanged; }
         set{ sDPR_Sum_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      private string sDPR_RefType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_RefType_IsChanged=false;
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public string SDPR_RefType
      {
         get{ return sDPR_RefType; }
         set{ sDPR_RefType = value; sDPR_RefType_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据类型
      /// </summary>
      public bool SDPR_RefType_IsChanged
      {
         get{ return sDPR_RefType_IsChanged; }
         set{ sDPR_RefType_IsChanged = value; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      private string sDPR_RefCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_RefCode_IsChanged=false;
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public string SDPR_RefCode
      {
         get{ return sDPR_RefCode; }
         set{ sDPR_RefCode = value; sDPR_RefCode_IsChanged=true; }
      }
      /// <summary>
      /// 参考单据编码
      /// </summary>
      public bool SDPR_RefCode_IsChanged
      {
         get{ return sDPR_RefCode_IsChanged; }
         set{ sDPR_RefCode_IsChanged = value; }
      }
      /// <summary>
      /// 财务经手人
      /// </summary>
      private string sDPR_FOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_FOwner_IsChanged=false;
      /// <summary>
      /// 财务经手人
      /// </summary>
      public string SDPR_FOwner
      {
         get{ return sDPR_FOwner; }
         set{ sDPR_FOwner = value; sDPR_FOwner_IsChanged=true; }
      }
      /// <summary>
      /// 财务经手人
      /// </summary>
      public bool SDPR_FOwner_IsChanged
      {
         get{ return sDPR_FOwner_IsChanged; }
         set{ sDPR_FOwner_IsChanged = value; }
      }
      /// <summary>
      /// 财务经手时间
      /// </summary>
      private DateTime sDPR_FDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_FDate_IsChanged=false;
      /// <summary>
      /// 财务经手时间
      /// </summary>
      public DateTime SDPR_FDate
      {
         get{ return sDPR_FDate; }
         set{ sDPR_FDate = value; sDPR_FDate_IsChanged=true; }
      }
      /// <summary>
      /// 财务经手时间
      /// </summary>
      public bool SDPR_FDate_IsChanged
      {
         get{ return sDPR_FDate_IsChanged; }
         set{ sDPR_FDate_IsChanged = value; }
      }
      /// <summary>
      /// 收款类型
      /// </summary>
      private string sDPR_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_iType_IsChanged=false;
      /// <summary>
      /// 收款类型
      /// </summary>
      public string SDPR_iType
      {
         get{ return sDPR_iType; }
         set{ sDPR_iType = value; sDPR_iType_IsChanged=true; }
      }
      /// <summary>
      /// 收款类型
      /// </summary>
      public bool SDPR_iType_IsChanged
      {
         get{ return sDPR_iType_IsChanged; }
         set{ sDPR_iType_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDPR_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDPR_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDPR_Bak
      {
         get{ return sDPR_Bak; }
         set{ sDPR_Bak = value; sDPR_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDPR_Bak_IsChanged
      {
         get{ return sDPR_Bak_IsChanged; }
         set{ sDPR_Bak_IsChanged = value; }
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
      private decimal sDPR_Done;
      private bool sDPR_Done_IsChanged=false;
      public decimal SDPR_Done
      {
         get{ return sDPR_Done; }
         set{ sDPR_Done = value; sDPR_Done_IsChanged=true; }
      }
      public bool SDPR_Done_IsChanged
      {
         get{ return sDPR_Done_IsChanged; }
         set{ sDPR_Done_IsChanged = value; }
      }
      private decimal sDPR_LeftDone;
      private bool sDPR_LeftDone_IsChanged=false;
      public decimal SDPR_LeftDone
      {
         get{ return sDPR_LeftDone; }
         set{ sDPR_LeftDone = value; sDPR_LeftDone_IsChanged=true; }
      }
      public bool SDPR_LeftDone_IsChanged
      {
         get{ return sDPR_LeftDone_IsChanged; }
         set{ sDPR_LeftDone_IsChanged = value; }
      }
      private string sDPR_CompanyCode;
      private bool sDPR_CompanyCode_IsChanged=false;
      public string SDPR_CompanyCode
      {
         get{ return sDPR_CompanyCode; }
         set{ sDPR_CompanyCode = value; sDPR_CompanyCode_IsChanged=true; }
      }
      public bool SDPR_CompanyCode_IsChanged
      {
         get{ return sDPR_CompanyCode_IsChanged; }
         set{ sDPR_CompanyCode_IsChanged = value; }
      }
      private string sDPR_Company;
      private bool sDPR_Company_IsChanged=false;
      public string SDPR_Company
      {
         get{ return sDPR_Company; }
         set{ sDPR_Company = value; sDPR_Company_IsChanged=true; }
      }
      public bool SDPR_Company_IsChanged
      {
         get{ return sDPR_Company_IsChanged; }
         set{ sDPR_Company_IsChanged = value; }
      }
      private decimal sDPR_broom;
      private bool sDPR_broom_IsChanged=false;
      public decimal SDPR_broom
      {
         get{ return sDPR_broom; }
         set{ sDPR_broom = value; sDPR_broom_IsChanged=true; }
      }
      public bool SDPR_broom_IsChanged
      {
         get{ return sDPR_broom_IsChanged; }
         set{ sDPR_broom_IsChanged = value; }
      }
   }
}
