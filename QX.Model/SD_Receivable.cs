using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 应收账款
   /// </summary>
   [Serializable]
   public partial class SD_Receivable
   {
      /// <summary>
      /// 应收序号
      /// </summary>
      private decimal sDR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_ID_IsChanged=false;
      /// <summary>
      /// 应收序号
      /// </summary>
      public decimal SDR_ID
      {
         get{ return sDR_ID; }
         set{ sDR_ID = value; sDR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 应收序号
      /// </summary>
      public bool SDR_ID_IsChanged
      {
         get{ return sDR_ID_IsChanged; }
         set{ sDR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 应收编码
      /// </summary>
      private string sDR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_Code_IsChanged=false;
      /// <summary>
      /// 应收编码
      /// </summary>
      public string SDR_Code
      {
         get{ return sDR_Code; }
         set{ sDR_Code = value; sDR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 应收编码
      /// </summary>
      public bool SDR_Code_IsChanged
      {
         get{ return sDR_Code_IsChanged; }
         set{ sDR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string sDR_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string SDR_CCode
      {
         get{ return sDR_CCode; }
         set{ sDR_CCode = value; sDR_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool SDR_CCode_IsChanged
      {
         get{ return sDR_CCode_IsChanged; }
         set{ sDR_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      private string sDR_CName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_CName_IsChanged=false;
      /// <summary>
      /// 客户名称
      /// </summary>
      public string SDR_CName
      {
         get{ return sDR_CName; }
         set{ sDR_CName = value; sDR_CName_IsChanged=true; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      public bool SDR_CName_IsChanged
      {
         get{ return sDR_CName_IsChanged; }
         set{ sDR_CName_IsChanged = value; }
      }
      /// <summary>
      /// 账期
      /// </summary>
      private string sDR_Period;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_Period_IsChanged=false;
      /// <summary>
      /// 账期
      /// </summary>
      public string SDR_Period
      {
         get{ return sDR_Period; }
         set{ sDR_Period = value; sDR_Period_IsChanged=true; }
      }
      /// <summary>
      /// 账期
      /// </summary>
      public bool SDR_Period_IsChanged
      {
         get{ return sDR_Period_IsChanged; }
         set{ sDR_Period_IsChanged = value; }
      }
      /// <summary>
      /// 上月应收结余
      /// </summary>
      private decimal sDR_Last;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_Last_IsChanged=false;
      /// <summary>
      /// 上月应收结余
      /// </summary>
      public decimal SDR_Last
      {
         get{ return sDR_Last; }
         set{ sDR_Last = value; sDR_Last_IsChanged=true; }
      }
      /// <summary>
      /// 上月应收结余
      /// </summary>
      public bool SDR_Last_IsChanged
      {
         get{ return sDR_Last_IsChanged; }
         set{ sDR_Last_IsChanged = value; }
      }
      /// <summary>
      /// 本月应收
      /// </summary>
      private decimal sDR_Current;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_Current_IsChanged=false;
      /// <summary>
      /// 本月应收
      /// </summary>
      public decimal SDR_Current
      {
         get{ return sDR_Current; }
         set{ sDR_Current = value; sDR_Current_IsChanged=true; }
      }
      /// <summary>
      /// 本月应收
      /// </summary>
      public bool SDR_Current_IsChanged
      {
         get{ return sDR_Current_IsChanged; }
         set{ sDR_Current_IsChanged = value; }
      }
      /// <summary>
      /// 本月应收结余
      /// </summary>
      private decimal sDR_Left;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_Left_IsChanged=false;
      /// <summary>
      /// 本月应收结余
      /// </summary>
      public decimal SDR_Left
      {
         get{ return sDR_Left; }
         set{ sDR_Left = value; sDR_Left_IsChanged=true; }
      }
      /// <summary>
      /// 本月应收结余
      /// </summary>
      public bool SDR_Left_IsChanged
      {
         get{ return sDR_Left_IsChanged; }
         set{ sDR_Left_IsChanged = value; }
      }
      /// <summary>
      /// 是否已收款
      /// </summary>
      private int sDR_IsDone;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_IsDone_IsChanged=false;
      /// <summary>
      /// 是否已收款
      /// </summary>
      public int SDR_IsDone
      {
         get{ return sDR_IsDone; }
         set{ sDR_IsDone = value; sDR_IsDone_IsChanged=true; }
      }
      /// <summary>
      /// 是否已收款
      /// </summary>
      public bool SDR_IsDone_IsChanged
      {
         get{ return sDR_IsDone_IsChanged; }
         set{ sDR_IsDone_IsChanged = value; }
      }
      /// <summary>
      /// 本月实际收款
      /// </summary>
      private decimal sDR_Done;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_Done_IsChanged=false;
      /// <summary>
      /// 本月实际收款
      /// </summary>
      public decimal SDR_Done
      {
         get{ return sDR_Done; }
         set{ sDR_Done = value; sDR_Done_IsChanged=true; }
      }
      /// <summary>
      /// 本月实际收款
      /// </summary>
      public bool SDR_Done_IsChanged
      {
         get{ return sDR_Done_IsChanged; }
         set{ sDR_Done_IsChanged = value; }
      }
      /// <summary>
      /// 本月剩余收款
      /// </summary>
      private decimal sDR_LeftDone;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_LeftDone_IsChanged=false;
      /// <summary>
      /// 本月剩余收款
      /// </summary>
      public decimal SDR_LeftDone
      {
         get{ return sDR_LeftDone; }
         set{ sDR_LeftDone = value; sDR_LeftDone_IsChanged=true; }
      }
      /// <summary>
      /// 本月剩余收款
      /// </summary>
      public bool SDR_LeftDone_IsChanged
      {
         get{ return sDR_LeftDone_IsChanged; }
         set{ sDR_LeftDone_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDR_Remark
      {
         get{ return sDR_Remark; }
         set{ sDR_Remark = value; sDR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDR_Remark_IsChanged
      {
         get{ return sDR_Remark_IsChanged; }
         set{ sDR_Remark_IsChanged = value; }
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
      /// 收款日期
      /// </summary>
      private DateTime sDR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDR_Date_IsChanged=false;
      /// <summary>
      /// 收款日期
      /// </summary>
      public DateTime SDR_Date
      {
         get{ return sDR_Date; }
         set{ sDR_Date = value; sDR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 收款日期
      /// </summary>
      public bool SDR_Date_IsChanged
      {
         get{ return sDR_Date_IsChanged; }
         set{ sDR_Date_IsChanged = value; }
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
      private string sDR_CompanyCode;
      private bool sDR_CompanyCode_IsChanged=false;
      public string SDR_CompanyCode
      {
         get{ return sDR_CompanyCode; }
         set{ sDR_CompanyCode = value; sDR_CompanyCode_IsChanged=true; }
      }
      public bool SDR_CompanyCode_IsChanged
      {
         get{ return sDR_CompanyCode_IsChanged; }
         set{ sDR_CompanyCode_IsChanged = value; }
      }
      private string sDR_Company;
      private bool sDR_Company_IsChanged=false;
      public string SDR_Company
      {
         get{ return sDR_Company; }
         set{ sDR_Company = value; sDR_Company_IsChanged=true; }
      }
      public bool SDR_Company_IsChanged
      {
         get{ return sDR_Company_IsChanged; }
         set{ sDR_Company_IsChanged = value; }
      }
      private decimal sDR_broom;
      private bool sDR_broom_IsChanged=false;
      public decimal SDR_broom
      {
         get{ return sDR_broom; }
         set{ sDR_broom = value; sDR_broom_IsChanged=true; }
      }
      public bool SDR_broom_IsChanged
      {
         get{ return sDR_broom_IsChanged; }
         set{ sDR_broom_IsChanged = value; }
      }
   }
}
