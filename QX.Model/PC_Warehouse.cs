using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 原料仓库
   /// </summary>
   [Serializable]
   public partial class PC_Warehouse
   {
      private decimal pCW_ID;
      private bool pCW_ID_IsChanged=false;
      public decimal PCW_ID
      {
         get{ return pCW_ID; }
         set{ pCW_ID = value; pCW_ID_IsChanged=true; }
      }
      public bool PCW_ID_IsChanged
      {
         get{ return pCW_ID_IsChanged; }
         set{ pCW_ID_IsChanged = value; }
      }
      /// <summary>
      /// 仓库编码
      /// </summary>
      private string pCW_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCW_Code_IsChanged=false;
      /// <summary>
      /// 仓库编码
      /// </summary>
      public string PCW_Code
      {
         get{ return pCW_Code; }
         set{ pCW_Code = value; pCW_Code_IsChanged=true; }
      }
      /// <summary>
      /// 仓库编码
      /// </summary>
      public bool PCW_Code_IsChanged
      {
         get{ return pCW_Code_IsChanged; }
         set{ pCW_Code_IsChanged = value; }
      }
      /// <summary>
      /// 仓号
      /// </summary>
      private string pCW_No;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCW_No_IsChanged=false;
      /// <summary>
      /// 仓号
      /// </summary>
      public string PCW_No
      {
         get{ return pCW_No; }
         set{ pCW_No = value; pCW_No_IsChanged=true; }
      }
      /// <summary>
      /// 仓号
      /// </summary>
      public bool PCW_No_IsChanged
      {
         get{ return pCW_No_IsChanged; }
         set{ pCW_No_IsChanged = value; }
      }
      /// <summary>
      /// 仓库名称
      /// </summary>
      private string pCW_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCW_Name_IsChanged=false;
      /// <summary>
      /// 仓库名称
      /// </summary>
      public string PCW_Name
      {
         get{ return pCW_Name; }
         set{ pCW_Name = value; pCW_Name_IsChanged=true; }
      }
      /// <summary>
      /// 仓库名称
      /// </summary>
      public bool PCW_Name_IsChanged
      {
         get{ return pCW_Name_IsChanged; }
         set{ pCW_Name_IsChanged = value; }
      }
      private string pCW_Unit;
      private bool pCW_Unit_IsChanged=false;
      public string PCW_Unit
      {
         get{ return pCW_Unit; }
         set{ pCW_Unit = value; pCW_Unit_IsChanged=true; }
      }
      public bool PCW_Unit_IsChanged
      {
         get{ return pCW_Unit_IsChanged; }
         set{ pCW_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string pCW_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCW_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string PCW_MCode
      {
         get{ return pCW_MCode; }
         set{ pCW_MCode = value; pCW_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool PCW_MCode_IsChanged
      {
         get{ return pCW_MCode_IsChanged; }
         set{ pCW_MCode_IsChanged = value; }
      }
      private string pCW_MName;
      private bool pCW_MName_IsChanged=false;
      public string PCW_MName
      {
         get{ return pCW_MName; }
         set{ pCW_MName = value; pCW_MName_IsChanged=true; }
      }
      public bool PCW_MName_IsChanged
      {
         get{ return pCW_MName_IsChanged; }
         set{ pCW_MName_IsChanged = value; }
      }
      private string pCW_MGroup;
      private bool pCW_MGroup_IsChanged=false;
      public string PCW_MGroup
      {
         get{ return pCW_MGroup; }
         set{ pCW_MGroup = value; pCW_MGroup_IsChanged=true; }
      }
      public bool PCW_MGroup_IsChanged
      {
         get{ return pCW_MGroup_IsChanged; }
         set{ pCW_MGroup_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private decimal pCW_MNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCW_MNum_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public decimal PCW_MNum
      {
         get{ return pCW_MNum; }
         set{ pCW_MNum = value; pCW_MNum_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool PCW_MNum_IsChanged
      {
         get{ return pCW_MNum_IsChanged; }
         set{ pCW_MNum_IsChanged = value; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      private decimal pCW_MPrice;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCW_MPrice_IsChanged=false;
      /// <summary>
      /// 价格
      /// </summary>
      public decimal PCW_MPrice
      {
         get{ return pCW_MPrice; }
         set{ pCW_MPrice = value; pCW_MPrice_IsChanged=true; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      public bool PCW_MPrice_IsChanged
      {
         get{ return pCW_MPrice_IsChanged; }
         set{ pCW_MPrice_IsChanged = value; }
      }
      private string pCW_iType;
      private bool pCW_iType_IsChanged=false;
      public string PCW_iType
      {
         get{ return pCW_iType; }
         set{ pCW_iType = value; pCW_iType_IsChanged=true; }
      }
      public bool PCW_iType_IsChanged
      {
         get{ return pCW_iType_IsChanged; }
         set{ pCW_iType_IsChanged = value; }
      }
      private string pCW_Station;
      private bool pCW_Station_IsChanged=false;
      public string PCW_Station
      {
         get{ return pCW_Station; }
         set{ pCW_Station = value; pCW_Station_IsChanged=true; }
      }
      public bool PCW_Station_IsChanged
      {
         get{ return pCW_Station_IsChanged; }
         set{ pCW_Station_IsChanged = value; }
      }
      private string pCW_Remark;
      private bool pCW_Remark_IsChanged=false;
      public string PCW_Remark
      {
         get{ return pCW_Remark; }
         set{ pCW_Remark = value; pCW_Remark_IsChanged=true; }
      }
      public bool PCW_Remark_IsChanged
      {
         get{ return pCW_Remark_IsChanged; }
         set{ pCW_Remark_IsChanged = value; }
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
