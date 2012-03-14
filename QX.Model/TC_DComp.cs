using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 生产配比下达信息
   /// </summary>
   [Serializable]
   public partial class TC_DComp
   {
      private decimal tCD_ID;
      private bool tCD_ID_IsChanged=false;
      public decimal TCD_ID
      {
         get{ return tCD_ID; }
         set{ tCD_ID = value; tCD_ID_IsChanged=true; }
      }
      public bool TCD_ID_IsChanged
      {
         get{ return tCD_ID_IsChanged; }
         set{ tCD_ID_IsChanged = value; }
      }
      private string tCD_Code;
      private bool tCD_Code_IsChanged=false;
      public string TCD_Code
      {
         get{ return tCD_Code; }
         set{ tCD_Code = value; tCD_Code_IsChanged=true; }
      }
      public bool TCD_Code_IsChanged
      {
         get{ return tCD_Code_IsChanged; }
         set{ tCD_Code_IsChanged = value; }
      }
      private string tCD_PCode;
      private bool tCD_PCode_IsChanged=false;
      public string TCD_PCode
      {
         get{ return tCD_PCode; }
         set{ tCD_PCode = value; tCD_PCode_IsChanged=true; }
      }
      public bool TCD_PCode_IsChanged
      {
         get{ return tCD_PCode_IsChanged; }
         set{ tCD_PCode_IsChanged = value; }
      }
      private string tCD_PLine;
      private bool tCD_PLine_IsChanged=false;
      public string TCD_PLine
      {
         get{ return tCD_PLine; }
         set{ tCD_PLine = value; tCD_PLine_IsChanged=true; }
      }
      public bool TCD_PLine_IsChanged
      {
         get{ return tCD_PLine_IsChanged; }
         set{ tCD_PLine_IsChanged = value; }
      }
      private string tCD_PPlan;
      private bool tCD_PPlan_IsChanged=false;
      public string TCD_PPlan
      {
         get{ return tCD_PPlan; }
         set{ tCD_PPlan = value; tCD_PPlan_IsChanged=true; }
      }
      public bool TCD_PPlan_IsChanged
      {
         get{ return tCD_PPlan_IsChanged; }
         set{ tCD_PPlan_IsChanged = value; }
      }
      private string tCD_Remark;
      private bool tCD_Remark_IsChanged=false;
      public string TCD_Remark
      {
         get{ return tCD_Remark; }
         set{ tCD_Remark = value; tCD_Remark_IsChanged=true; }
      }
      public bool TCD_Remark_IsChanged
      {
         get{ return tCD_Remark_IsChanged; }
         set{ tCD_Remark_IsChanged = value; }
      }
      private string tCD_UDef1;
      private bool tCD_UDef1_IsChanged=false;
      public string TCD_UDef1
      {
         get{ return tCD_UDef1; }
         set{ tCD_UDef1 = value; tCD_UDef1_IsChanged=true; }
      }
      public bool TCD_UDef1_IsChanged
      {
         get{ return tCD_UDef1_IsChanged; }
         set{ tCD_UDef1_IsChanged = value; }
      }
      private string tCD_UDef2;
      private bool tCD_UDef2_IsChanged=false;
      public string TCD_UDef2
      {
         get{ return tCD_UDef2; }
         set{ tCD_UDef2 = value; tCD_UDef2_IsChanged=true; }
      }
      public bool TCD_UDef2_IsChanged
      {
         get{ return tCD_UDef2_IsChanged; }
         set{ tCD_UDef2_IsChanged = value; }
      }
      private string tCD_UDef3;
      private bool tCD_UDef3_IsChanged=false;
      public string TCD_UDef3
      {
         get{ return tCD_UDef3; }
         set{ tCD_UDef3 = value; tCD_UDef3_IsChanged=true; }
      }
      public bool TCD_UDef3_IsChanged
      {
         get{ return tCD_UDef3_IsChanged; }
         set{ tCD_UDef3_IsChanged = value; }
      }
      private string tCD_UDef4;
      private bool tCD_UDef4_IsChanged=false;
      public string TCD_UDef4
      {
         get{ return tCD_UDef4; }
         set{ tCD_UDef4 = value; tCD_UDef4_IsChanged=true; }
      }
      public bool TCD_UDef4_IsChanged
      {
         get{ return tCD_UDef4_IsChanged; }
         set{ tCD_UDef4_IsChanged = value; }
      }
      private string tCD_UDef5;
      private bool tCD_UDef5_IsChanged=false;
      public string TCD_UDef5
      {
         get{ return tCD_UDef5; }
         set{ tCD_UDef5 = value; tCD_UDef5_IsChanged=true; }
      }
      public bool TCD_UDef5_IsChanged
      {
         get{ return tCD_UDef5_IsChanged; }
         set{ tCD_UDef5_IsChanged = value; }
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
