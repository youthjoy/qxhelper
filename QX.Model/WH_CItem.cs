using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 合同细目信息
   /// </summary>
   [Serializable]
   public partial class WH_CItem
   {
      /// <summary>
      /// 合同明细序号
      /// </summary>
      private decimal wHCI_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHCI_ID_IsChanged=false;
      /// <summary>
      /// 合同明细序号
      /// </summary>
      public decimal WHCI_ID
      {
         get{ return wHCI_ID; }
         set{ wHCI_ID = value; wHCI_ID_IsChanged=true; }
      }
      /// <summary>
      /// 合同明细序号
      /// </summary>
      public bool WHCI_ID_IsChanged
      {
         get{ return wHCI_ID_IsChanged; }
         set{ wHCI_ID_IsChanged = value; }
      }
      private string wHCI_CCode;
      private bool wHCI_CCode_IsChanged=false;
      public string WHCI_CCode
      {
         get{ return wHCI_CCode; }
         set{ wHCI_CCode = value; wHCI_CCode_IsChanged=true; }
      }
      public bool WHCI_CCode_IsChanged
      {
         get{ return wHCI_CCode_IsChanged; }
         set{ wHCI_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string wHCI_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHCI_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string WHCI_MCode
      {
         get{ return wHCI_MCode; }
         set{ wHCI_MCode = value; wHCI_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool WHCI_MCode_IsChanged
      {
         get{ return wHCI_MCode_IsChanged; }
         set{ wHCI_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private int wHCI_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHCI_Num_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public int WHCI_Num
      {
         get{ return wHCI_Num; }
         set{ wHCI_Num = value; wHCI_Num_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool WHCI_Num_IsChanged
      {
         get{ return wHCI_Num_IsChanged; }
         set{ wHCI_Num_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string wHCI_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHCI_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string WHCI_Unit
      {
         get{ return wHCI_Unit; }
         set{ wHCI_Unit = value; wHCI_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool WHCI_Unit_IsChanged
      {
         get{ return wHCI_Unit_IsChanged; }
         set{ wHCI_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 生产厂商
      /// </summary>
      private string wHCI_Manu;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHCI_Manu_IsChanged=false;
      /// <summary>
      /// 生产厂商
      /// </summary>
      public string WHCI_Manu
      {
         get{ return wHCI_Manu; }
         set{ wHCI_Manu = value; wHCI_Manu_IsChanged=true; }
      }
      /// <summary>
      /// 生产厂商
      /// </summary>
      public bool WHCI_Manu_IsChanged
      {
         get{ return wHCI_Manu_IsChanged; }
         set{ wHCI_Manu_IsChanged = value; }
      }
      /// <summary>
      /// 生产时间
      /// </summary>
      private DateTime wHCI_MDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHCI_MDate_IsChanged=false;
      /// <summary>
      /// 生产时间
      /// </summary>
      public DateTime WHCI_MDate
      {
         get{ return wHCI_MDate; }
         set{ wHCI_MDate = value; wHCI_MDate_IsChanged=true; }
      }
      /// <summary>
      /// 生产时间
      /// </summary>
      public bool WHCI_MDate_IsChanged
      {
         get{ return wHCI_MDate_IsChanged; }
         set{ wHCI_MDate_IsChanged = value; }
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
