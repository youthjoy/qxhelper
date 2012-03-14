using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 混凝土信息
   /// </summary>
   [Serializable]
   public partial class PC_Concrete
   {
      private decimal pCC_ID;
      private bool pCC_ID_IsChanged=false;
      public decimal PCC_ID
      {
         get{ return pCC_ID; }
         set{ pCC_ID = value; pCC_ID_IsChanged=true; }
      }
      public bool PCC_ID_IsChanged
      {
         get{ return pCC_ID_IsChanged; }
         set{ pCC_ID_IsChanged = value; }
      }
      /// <summary>
      /// 混凝土编码
      /// </summary>
      private string pCC_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_Code_IsChanged=false;
      /// <summary>
      /// 混凝土编码
      /// </summary>
      public string PCC_Code
      {
         get{ return pCC_Code; }
         set{ pCC_Code = value; pCC_Code_IsChanged=true; }
      }
      /// <summary>
      /// 混凝土编码
      /// </summary>
      public bool PCC_Code_IsChanged
      {
         get{ return pCC_Code_IsChanged; }
         set{ pCC_Code_IsChanged = value; }
      }
      /// <summary>
      /// 混凝土名称
      /// </summary>
      private string pCC_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_Name_IsChanged=false;
      /// <summary>
      /// 混凝土名称
      /// </summary>
      public string PCC_Name
      {
         get{ return pCC_Name; }
         set{ pCC_Name = value; pCC_Name_IsChanged=true; }
      }
      /// <summary>
      /// 混凝土名称
      /// </summary>
      public bool PCC_Name_IsChanged
      {
         get{ return pCC_Name_IsChanged; }
         set{ pCC_Name_IsChanged = value; }
      }
      /// <summary>
      /// 混凝土等级
      /// </summary>
      private string pCC_Level;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_Level_IsChanged=false;
      /// <summary>
      /// 混凝土等级
      /// </summary>
      public string PCC_Level
      {
         get{ return pCC_Level; }
         set{ pCC_Level = value; pCC_Level_IsChanged=true; }
      }
      /// <summary>
      /// 混凝土等级
      /// </summary>
      public bool PCC_Level_IsChanged
      {
         get{ return pCC_Level_IsChanged; }
         set{ pCC_Level_IsChanged = value; }
      }
      /// <summary>
      /// 抗渗等级
      /// </summary>
      private string pCC_SLev;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_SLev_IsChanged=false;
      /// <summary>
      /// 抗渗等级
      /// </summary>
      public string PCC_SLev
      {
         get{ return pCC_SLev; }
         set{ pCC_SLev = value; pCC_SLev_IsChanged=true; }
      }
      /// <summary>
      /// 抗渗等级
      /// </summary>
      public bool PCC_SLev_IsChanged
      {
         get{ return pCC_SLev_IsChanged; }
         set{ pCC_SLev_IsChanged = value; }
      }
      /// <summary>
      /// 抗折等级
      /// </summary>
      private string pCC_ZLev;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_ZLev_IsChanged=false;
      /// <summary>
      /// 抗折等级
      /// </summary>
      public string PCC_ZLev
      {
         get{ return pCC_ZLev; }
         set{ pCC_ZLev = value; pCC_ZLev_IsChanged=true; }
      }
      /// <summary>
      /// 抗折等级
      /// </summary>
      public bool PCC_ZLev_IsChanged
      {
         get{ return pCC_ZLev_IsChanged; }
         set{ pCC_ZLev_IsChanged = value; }
      }
      /// <summary>
      /// 特殊材料1
      /// </summary>
      private string pCC_Spec1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_Spec1_IsChanged=false;
      /// <summary>
      /// 特殊材料1
      /// </summary>
      public string PCC_Spec1
      {
         get{ return pCC_Spec1; }
         set{ pCC_Spec1 = value; pCC_Spec1_IsChanged=true; }
      }
      /// <summary>
      /// 特殊材料1
      /// </summary>
      public bool PCC_Spec1_IsChanged
      {
         get{ return pCC_Spec1_IsChanged; }
         set{ pCC_Spec1_IsChanged = value; }
      }
      /// <summary>
      /// 特殊材料2
      /// </summary>
      private string pCC_Spec2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_Spec2_IsChanged=false;
      /// <summary>
      /// 特殊材料2
      /// </summary>
      public string PCC_Spec2
      {
         get{ return pCC_Spec2; }
         set{ pCC_Spec2 = value; pCC_Spec2_IsChanged=true; }
      }
      /// <summary>
      /// 特殊材料2
      /// </summary>
      public bool PCC_Spec2_IsChanged
      {
         get{ return pCC_Spec2_IsChanged; }
         set{ pCC_Spec2_IsChanged = value; }
      }
      /// <summary>
      /// 搅拌时间
      /// </summary>
      private int pCC_Minutes;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_Minutes_IsChanged=false;
      /// <summary>
      /// 搅拌时间
      /// </summary>
      public int PCC_Minutes
      {
         get{ return pCC_Minutes; }
         set{ pCC_Minutes = value; pCC_Minutes_IsChanged=true; }
      }
      /// <summary>
      /// 搅拌时间
      /// </summary>
      public bool PCC_Minutes_IsChanged
      {
         get{ return pCC_Minutes_IsChanged; }
         set{ pCC_Minutes_IsChanged = value; }
      }
      /// <summary>
      /// 加水上限
      /// </summary>
      private int pCC_High;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_High_IsChanged=false;
      /// <summary>
      /// 加水上限
      /// </summary>
      public int PCC_High
      {
         get{ return pCC_High; }
         set{ pCC_High = value; pCC_High_IsChanged=true; }
      }
      /// <summary>
      /// 加水上限
      /// </summary>
      public bool PCC_High_IsChanged
      {
         get{ return pCC_High_IsChanged; }
         set{ pCC_High_IsChanged = value; }
      }
      /// <summary>
      /// 加水下限
      /// </summary>
      private int pCC_Low;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_Low_IsChanged=false;
      /// <summary>
      /// 加水下限
      /// </summary>
      public int PCC_Low
      {
         get{ return pCC_Low; }
         set{ pCC_Low = value; pCC_Low_IsChanged=true; }
      }
      /// <summary>
      /// 加水下限
      /// </summary>
      public bool PCC_Low_IsChanged
      {
         get{ return pCC_Low_IsChanged; }
         set{ pCC_Low_IsChanged = value; }
      }
      /// <summary>
      /// 修订时间
      /// </summary>
      private DateTime pCC_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_Date_IsChanged=false;
      /// <summary>
      /// 修订时间
      /// </summary>
      public DateTime PCC_Date
      {
         get{ return pCC_Date; }
         set{ pCC_Date = value; pCC_Date_IsChanged=true; }
      }
      /// <summary>
      /// 修订时间
      /// </summary>
      public bool PCC_Date_IsChanged
      {
         get{ return pCC_Date_IsChanged; }
         set{ pCC_Date_IsChanged = value; }
      }
      /// <summary>
      /// 参考价格
      /// </summary>
      private decimal pCC_RefPrice;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_RefPrice_IsChanged=false;
      /// <summary>
      /// 参考价格
      /// </summary>
      public decimal PCC_RefPrice
      {
         get{ return pCC_RefPrice; }
         set{ pCC_RefPrice = value; pCC_RefPrice_IsChanged=true; }
      }
      /// <summary>
      /// 参考价格
      /// </summary>
      public bool PCC_RefPrice_IsChanged
      {
         get{ return pCC_RefPrice_IsChanged; }
         set{ pCC_RefPrice_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string pCC_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCC_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string PCC_Bak
      {
         get{ return pCC_Bak; }
         set{ pCC_Bak = value; pCC_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool PCC_Bak_IsChanged
      {
         get{ return pCC_Bak_IsChanged; }
         set{ pCC_Bak_IsChanged = value; }
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
