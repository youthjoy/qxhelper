using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 客户结算单
   /// </summary>
   [Serializable]
   public partial class SD_Banlance
   {
      /// <summary>
      /// 结算记录序号
      /// </summary>
      private decimal sDB_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_ID_IsChanged=false;
      /// <summary>
      /// 结算记录序号
      /// </summary>
      public decimal SDB_ID
      {
         get{ return sDB_ID; }
         set{ sDB_ID = value; sDB_ID_IsChanged=true; }
      }
      /// <summary>
      /// 结算记录序号
      /// </summary>
      public bool SDB_ID_IsChanged
      {
         get{ return sDB_ID_IsChanged; }
         set{ sDB_ID_IsChanged = value; }
      }
      /// <summary>
      /// 结算单编码
      /// </summary>
      private string sDB_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_Code_IsChanged=false;
      /// <summary>
      /// 结算单编码
      /// </summary>
      public string SDB_Code
      {
         get{ return sDB_Code; }
         set{ sDB_Code = value; sDB_Code_IsChanged=true; }
      }
      /// <summary>
      /// 结算单编码
      /// </summary>
      public bool SDB_Code_IsChanged
      {
         get{ return sDB_Code_IsChanged; }
         set{ sDB_Code_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string sDB_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string SDB_CCode
      {
         get{ return sDB_CCode; }
         set{ sDB_CCode = value; sDB_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool SDB_CCode_IsChanged
      {
         get{ return sDB_CCode_IsChanged; }
         set{ sDB_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      private string sDB_CName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_CName_IsChanged=false;
      /// <summary>
      /// 客户名称
      /// </summary>
      public string SDB_CName
      {
         get{ return sDB_CName; }
         set{ sDB_CName = value; sDB_CName_IsChanged=true; }
      }
      /// <summary>
      /// 客户名称
      /// </summary>
      public bool SDB_CName_IsChanged
      {
         get{ return sDB_CName_IsChanged; }
         set{ sDB_CName_IsChanged = value; }
      }
      /// <summary>
      /// 结算时间
      /// </summary>
      private DateTime sDB_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_Date_IsChanged=false;
      /// <summary>
      /// 结算时间
      /// </summary>
      public DateTime SDB_Date
      {
         get{ return sDB_Date; }
         set{ sDB_Date = value; sDB_Date_IsChanged=true; }
      }
      /// <summary>
      /// 结算时间
      /// </summary>
      public bool SDB_Date_IsChanged
      {
         get{ return sDB_Date_IsChanged; }
         set{ sDB_Date_IsChanged = value; }
      }
      /// <summary>
      /// 客户负责人
      /// </summary>
      private string sDB_COwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_COwner_IsChanged=false;
      /// <summary>
      /// 客户负责人
      /// </summary>
      public string SDB_COwner
      {
         get{ return sDB_COwner; }
         set{ sDB_COwner = value; sDB_COwner_IsChanged=true; }
      }
      /// <summary>
      /// 客户负责人
      /// </summary>
      public bool SDB_COwner_IsChanged
      {
         get{ return sDB_COwner_IsChanged; }
         set{ sDB_COwner_IsChanged = value; }
      }
      /// <summary>
      /// 客户经办人
      /// </summary>
      private string sDB_CManager;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_CManager_IsChanged=false;
      /// <summary>
      /// 客户经办人
      /// </summary>
      public string SDB_CManager
      {
         get{ return sDB_CManager; }
         set{ sDB_CManager = value; sDB_CManager_IsChanged=true; }
      }
      /// <summary>
      /// 客户经办人
      /// </summary>
      public bool SDB_CManager_IsChanged
      {
         get{ return sDB_CManager_IsChanged; }
         set{ sDB_CManager_IsChanged = value; }
      }
      /// <summary>
      /// 销售负责人
      /// </summary>
      private string sDB_SOwner;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_SOwner_IsChanged=false;
      /// <summary>
      /// 销售负责人
      /// </summary>
      public string SDB_SOwner
      {
         get{ return sDB_SOwner; }
         set{ sDB_SOwner = value; sDB_SOwner_IsChanged=true; }
      }
      /// <summary>
      /// 销售负责人
      /// </summary>
      public bool SDB_SOwner_IsChanged
      {
         get{ return sDB_SOwner_IsChanged; }
         set{ sDB_SOwner_IsChanged = value; }
      }
      /// <summary>
      /// 销售经办人
      /// </summary>
      private string sDB_SManager;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_SManager_IsChanged=false;
      /// <summary>
      /// 销售经办人
      /// </summary>
      public string SDB_SManager
      {
         get{ return sDB_SManager; }
         set{ sDB_SManager = value; sDB_SManager_IsChanged=true; }
      }
      /// <summary>
      /// 销售经办人
      /// </summary>
      public bool SDB_SManager_IsChanged
      {
         get{ return sDB_SManager_IsChanged; }
         set{ sDB_SManager_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDBI_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDBI_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDBI_Bak
      {
         get{ return sDBI_Bak; }
         set{ sDBI_Bak = value; sDBI_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDBI_Bak_IsChanged
      {
         get{ return sDBI_Bak_IsChanged; }
         set{ sDBI_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 账期
      /// </summary>
      private string sDB_Period;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_Period_IsChanged=false;
      /// <summary>
      /// 账期
      /// </summary>
      public string SDB_Period
      {
         get{ return sDB_Period; }
         set{ sDB_Period = value; sDB_Period_IsChanged=true; }
      }
      /// <summary>
      /// 账期
      /// </summary>
      public bool SDB_Period_IsChanged
      {
         get{ return sDB_Period_IsChanged; }
         set{ sDB_Period_IsChanged = value; }
      }
      /// <summary>
      /// 上月结余
      /// </summary>
      private decimal sDB_Last;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_Last_IsChanged=false;
      /// <summary>
      /// 上月结余
      /// </summary>
      public decimal SDB_Last
      {
         get{ return sDB_Last; }
         set{ sDB_Last = value; sDB_Last_IsChanged=true; }
      }
      /// <summary>
      /// 上月结余
      /// </summary>
      public bool SDB_Last_IsChanged
      {
         get{ return sDB_Last_IsChanged; }
         set{ sDB_Last_IsChanged = value; }
      }
      /// <summary>
      /// 本月供货
      /// </summary>
      private decimal sDB_Current;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_Current_IsChanged=false;
      /// <summary>
      /// 本月供货
      /// </summary>
      public decimal SDB_Current
      {
         get{ return sDB_Current; }
         set{ sDB_Current = value; sDB_Current_IsChanged=true; }
      }
      /// <summary>
      /// 本月供货
      /// </summary>
      public bool SDB_Current_IsChanged
      {
         get{ return sDB_Current_IsChanged; }
         set{ sDB_Current_IsChanged = value; }
      }
      private decimal sDB_CurRecevie;
      private bool sDB_CurRecevie_IsChanged=false;
      public decimal SDB_CurRecevie
      {
         get{ return sDB_CurRecevie; }
         set{ sDB_CurRecevie = value; sDB_CurRecevie_IsChanged=true; }
      }
      public bool SDB_CurRecevie_IsChanged
      {
         get{ return sDB_CurRecevie_IsChanged; }
         set{ sDB_CurRecevie_IsChanged = value; }
      }
      /// <summary>
      /// 本月结余
      /// </summary>
      private decimal sDB_Left;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_Left_IsChanged=false;
      /// <summary>
      /// 本月结余
      /// </summary>
      public decimal SDB_Left
      {
         get{ return sDB_Left; }
         set{ sDB_Left = value; sDB_Left_IsChanged=true; }
      }
      /// <summary>
      /// 本月结余
      /// </summary>
      public bool SDB_Left_IsChanged
      {
         get{ return sDB_Left_IsChanged; }
         set{ sDB_Left_IsChanged = value; }
      }
      /// <summary>
      /// 结算单据类型
      /// </summary>
      private string sDB_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDB_iType_IsChanged=false;
      /// <summary>
      /// 结算单据类型
      /// </summary>
      public string SDB_iType
      {
         get{ return sDB_iType; }
         set{ sDB_iType = value; sDB_iType_IsChanged=true; }
      }
      /// <summary>
      /// 结算单据类型
      /// </summary>
      public bool SDB_iType_IsChanged
      {
         get{ return sDB_iType_IsChanged; }
         set{ sDB_iType_IsChanged = value; }
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
      private string sDB_Status;
      private bool sDB_Status_IsChanged=false;
      public string SDB_Status
      {
         get{ return sDB_Status; }
         set{ sDB_Status = value; sDB_Status_IsChanged=true; }
      }
      public bool SDB_Status_IsChanged
      {
         get{ return sDB_Status_IsChanged; }
         set{ sDB_Status_IsChanged = value; }
      }
      private string sDB_Attach;
      private bool sDB_Attach_IsChanged=false;
      public string SDB_Attach
      {
         get{ return sDB_Attach; }
         set{ sDB_Attach = value; sDB_Attach_IsChanged=true; }
      }
      public bool SDB_Attach_IsChanged
      {
         get{ return sDB_Attach_IsChanged; }
         set{ sDB_Attach_IsChanged = value; }
      }
      private decimal sDB_broom;
      private bool sDB_broom_IsChanged=false;
      public decimal SDB_broom
      {
         get{ return sDB_broom; }
         set{ sDB_broom = value; sDB_broom_IsChanged=true; }
      }
      public bool SDB_broom_IsChanged
      {
         get{ return sDB_broom_IsChanged; }
         set{ sDB_broom_IsChanged = value; }
      }
   }
}
