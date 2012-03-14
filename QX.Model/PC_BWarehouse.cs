using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 生产线关联仓库
   /// </summary>
   [Serializable]
   public partial class PC_BWarehouse
   {
      private decimal pCBW_ID;
      private bool pCBW_ID_IsChanged=false;
      public decimal PCBW_ID
      {
         get{ return pCBW_ID; }
         set{ pCBW_ID = value; pCBW_ID_IsChanged=true; }
      }
      public bool PCBW_ID_IsChanged
      {
         get{ return pCBW_ID_IsChanged; }
         set{ pCBW_ID_IsChanged = value; }
      }
      private string pCBW_Code;
      private bool pCBW_Code_IsChanged=false;
      public string PCBW_Code
      {
         get{ return pCBW_Code; }
         set{ pCBW_Code = value; pCBW_Code_IsChanged=true; }
      }
      public bool PCBW_Code_IsChanged
      {
         get{ return pCBW_Code_IsChanged; }
         set{ pCBW_Code_IsChanged = value; }
      }
      private string pCBW_LCode;
      private bool pCBW_LCode_IsChanged=false;
      public string PCBW_LCode
      {
         get{ return pCBW_LCode; }
         set{ pCBW_LCode = value; pCBW_LCode_IsChanged=true; }
      }
      public bool PCBW_LCode_IsChanged
      {
         get{ return pCBW_LCode_IsChanged; }
         set{ pCBW_LCode_IsChanged = value; }
      }
      private string pCBW_RefWCode;
      private bool pCBW_RefWCode_IsChanged=false;
      public string PCBW_RefWCode
      {
         get{ return pCBW_RefWCode; }
         set{ pCBW_RefWCode = value; pCBW_RefWCode_IsChanged=true; }
      }
      public bool PCBW_RefWCode_IsChanged
      {
         get{ return pCBW_RefWCode_IsChanged; }
         set{ pCBW_RefWCode_IsChanged = value; }
      }
      /// <summary>
      /// 生产仓号
      /// </summary>
      private string pCBW_WNo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCBW_WNo_IsChanged=false;
      /// <summary>
      /// 生产仓号
      /// </summary>
      public string PCBW_WNo
      {
         get{ return pCBW_WNo; }
         set{ pCBW_WNo = value; pCBW_WNo_IsChanged=true; }
      }
      /// <summary>
      /// 生产仓号
      /// </summary>
      public bool PCBW_WNo_IsChanged
      {
         get{ return pCBW_WNo_IsChanged; }
         set{ pCBW_WNo_IsChanged = value; }
      }
      /// <summary>
      /// 材料编码
      /// </summary>
      private string pCBW_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCBW_MCode_IsChanged=false;
      /// <summary>
      /// 材料编码
      /// </summary>
      public string PCBW_MCode
      {
         get{ return pCBW_MCode; }
         set{ pCBW_MCode = value; pCBW_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 材料编码
      /// </summary>
      public bool PCBW_MCode_IsChanged
      {
         get{ return pCBW_MCode_IsChanged; }
         set{ pCBW_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 材料名称
      /// </summary>
      private string pCBW_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCBW_MName_IsChanged=false;
      /// <summary>
      /// 材料名称
      /// </summary>
      public string PCBW_MName
      {
         get{ return pCBW_MName; }
         set{ pCBW_MName = value; pCBW_MName_IsChanged=true; }
      }
      /// <summary>
      /// 材料名称
      /// </summary>
      public bool PCBW_MName_IsChanged
      {
         get{ return pCBW_MName_IsChanged; }
         set{ pCBW_MName_IsChanged = value; }
      }
      /// <summary>
      /// 含水率
      /// </summary>
      private string pCBW_Contain;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCBW_Contain_IsChanged=false;
      /// <summary>
      /// 含水率
      /// </summary>
      public string PCBW_Contain
      {
         get{ return pCBW_Contain; }
         set{ pCBW_Contain = value; pCBW_Contain_IsChanged=true; }
      }
      /// <summary>
      /// 含水率
      /// </summary>
      public bool PCBW_Contain_IsChanged
      {
         get{ return pCBW_Contain_IsChanged; }
         set{ pCBW_Contain_IsChanged = value; }
      }
      /// <summary>
      /// 次序
      /// </summary>
      private int pCBW_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCBW_Order_IsChanged=false;
      /// <summary>
      /// 次序
      /// </summary>
      public int PCBW_Order
      {
         get{ return pCBW_Order; }
         set{ pCBW_Order = value; pCBW_Order_IsChanged=true; }
      }
      /// <summary>
      /// 次序
      /// </summary>
      public bool PCBW_Order_IsChanged
      {
         get{ return pCBW_Order_IsChanged; }
         set{ pCBW_Order_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string pCBW_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCBW_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string PCBW_Bak
      {
         get{ return pCBW_Bak; }
         set{ pCBW_Bak = value; pCBW_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool PCBW_Bak_IsChanged
      {
         get{ return pCBW_Bak_IsChanged; }
         set{ pCBW_Bak_IsChanged = value; }
      }
      /// <summary>
      /// 材料种类编码
      /// </summary>
      private string pCBW_TCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCBW_TCode_IsChanged=false;
      /// <summary>
      /// 材料种类编码
      /// </summary>
      public string PCBW_TCode
      {
         get{ return pCBW_TCode; }
         set{ pCBW_TCode = value; pCBW_TCode_IsChanged=true; }
      }
      /// <summary>
      /// 材料种类编码
      /// </summary>
      public bool PCBW_TCode_IsChanged
      {
         get{ return pCBW_TCode_IsChanged; }
         set{ pCBW_TCode_IsChanged = value; }
      }
      /// <summary>
      /// 材料种类名称
      /// </summary>
      private string pCBW_TName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pCBW_TName_IsChanged=false;
      /// <summary>
      /// 材料种类名称
      /// </summary>
      public string PCBW_TName
      {
         get{ return pCBW_TName; }
         set{ pCBW_TName = value; pCBW_TName_IsChanged=true; }
      }
      /// <summary>
      /// 材料种类名称
      /// </summary>
      public bool PCBW_TName_IsChanged
      {
         get{ return pCBW_TName_IsChanged; }
         set{ pCBW_TName_IsChanged = value; }
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
