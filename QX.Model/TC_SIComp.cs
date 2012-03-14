using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 标准配合比细目信息
   /// </summary>
   [Serializable]
   public partial class TC_SIComp
   {
      private decimal tCSI_ID;
      private bool tCSI_ID_IsChanged=false;
      public decimal TCSI_ID
      {
         get{ return tCSI_ID; }
         set{ tCSI_ID = value; tCSI_ID_IsChanged=true; }
      }
      public bool TCSI_ID_IsChanged
      {
         get{ return tCSI_ID_IsChanged; }
         set{ tCSI_ID_IsChanged = value; }
      }
      private string tCSI_Code;
      private bool tCSI_Code_IsChanged=false;
      public string TCSI_Code
      {
         get{ return tCSI_Code; }
         set{ tCSI_Code = value; tCSI_Code_IsChanged=true; }
      }
      public bool TCSI_Code_IsChanged
      {
         get{ return tCSI_Code_IsChanged; }
         set{ tCSI_Code_IsChanged = value; }
      }
      /// <summary>
      /// 配合比编号
      /// </summary>
      private string tCSI_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCSI_SCode_IsChanged=false;
      /// <summary>
      /// 配合比编号
      /// </summary>
      public string TCSI_SCode
      {
         get{ return tCSI_SCode; }
         set{ tCSI_SCode = value; tCSI_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 配合比编号
      /// </summary>
      public bool TCSI_SCode_IsChanged
      {
         get{ return tCSI_SCode_IsChanged; }
         set{ tCSI_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料类别编码
      /// </summary>
      private string tCSI_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCSI_MCode_IsChanged=false;
      /// <summary>
      /// 物料类别编码
      /// </summary>
      public string TCSI_MCode
      {
         get{ return tCSI_MCode; }
         set{ tCSI_MCode = value; tCSI_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料类别编码
      /// </summary>
      public bool TCSI_MCode_IsChanged
      {
         get{ return tCSI_MCode_IsChanged; }
         set{ tCSI_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 重量
      /// </summary>
      private decimal tCSI_Weight;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCSI_Weight_IsChanged=false;
      /// <summary>
      /// 重量
      /// </summary>
      public decimal TCSI_Weight
      {
         get{ return tCSI_Weight; }
         set{ tCSI_Weight = value; tCSI_Weight_IsChanged=true; }
      }
      /// <summary>
      /// 重量
      /// </summary>
      public bool TCSI_Weight_IsChanged
      {
         get{ return tCSI_Weight_IsChanged; }
         set{ tCSI_Weight_IsChanged = value; }
      }
      /// <summary>
      /// 序号
      /// </summary>
      private int tCSI_Order;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCSI_Order_IsChanged=false;
      /// <summary>
      /// 序号
      /// </summary>
      public int TCSI_Order
      {
         get{ return tCSI_Order; }
         set{ tCSI_Order = value; tCSI_Order_IsChanged=true; }
      }
      /// <summary>
      /// 序号
      /// </summary>
      public bool TCSI_Order_IsChanged
      {
         get{ return tCSI_Order_IsChanged; }
         set{ tCSI_Order_IsChanged = value; }
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
