using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 客户回访
   /// </summary>
   [Serializable]
   public partial class Customer_Visit
   {
      private decimal cV_ID;
      private bool cV_ID_IsChanged=false;
      public decimal CV_ID
      {
         get{ return cV_ID; }
         set{ cV_ID = value; cV_ID_IsChanged=true; }
      }
      public bool CV_ID_IsChanged
      {
         get{ return cV_ID_IsChanged; }
         set{ cV_ID_IsChanged = value; }
      }
      private string cV_Code;
      private bool cV_Code_IsChanged=false;
      public string CV_Code
      {
         get{ return cV_Code; }
         set{ cV_Code = value; cV_Code_IsChanged=true; }
      }
      public bool CV_Code_IsChanged
      {
         get{ return cV_Code_IsChanged; }
         set{ cV_Code_IsChanged = value; }
      }
      private string cV_PJCode;
      private bool cV_PJCode_IsChanged=false;
      public string CV_PJCode
      {
         get{ return cV_PJCode; }
         set{ cV_PJCode = value; cV_PJCode_IsChanged=true; }
      }
      public bool CV_PJCode_IsChanged
      {
         get{ return cV_PJCode_IsChanged; }
         set{ cV_PJCode_IsChanged = value; }
      }
      private string cV_PJName;
      private bool cV_PJName_IsChanged=false;
      public string CV_PJName
      {
         get{ return cV_PJName; }
         set{ cV_PJName = value; cV_PJName_IsChanged=true; }
      }
      public bool CV_PJName_IsChanged
      {
         get{ return cV_PJName_IsChanged; }
         set{ cV_PJName_IsChanged = value; }
      }
      private string cV_PJType;
      private bool cV_PJType_IsChanged=false;
      public string CV_PJType
      {
         get{ return cV_PJType; }
         set{ cV_PJType = value; cV_PJType_IsChanged=true; }
      }
      public bool CV_PJType_IsChanged
      {
         get{ return cV_PJType_IsChanged; }
         set{ cV_PJType_IsChanged = value; }
      }
      private string cV_CCode;
      private bool cV_CCode_IsChanged=false;
      public string CV_CCode
      {
         get{ return cV_CCode; }
         set{ cV_CCode = value; cV_CCode_IsChanged=true; }
      }
      public bool CV_CCode_IsChanged
      {
         get{ return cV_CCode_IsChanged; }
         set{ cV_CCode_IsChanged = value; }
      }
      private string cV_CName;
      private bool cV_CName_IsChanged=false;
      public string CV_CName
      {
         get{ return cV_CName; }
         set{ cV_CName = value; cV_CName_IsChanged=true; }
      }
      public bool CV_CName_IsChanged
      {
         get{ return cV_CName_IsChanged; }
         set{ cV_CName_IsChanged = value; }
      }
      private string cV_Place;
      private bool cV_Place_IsChanged=false;
      public string CV_Place
      {
         get{ return cV_Place; }
         set{ cV_Place = value; cV_Place_IsChanged=true; }
      }
      public bool CV_Place_IsChanged
      {
         get{ return cV_Place_IsChanged; }
         set{ cV_Place_IsChanged = value; }
      }
      private string cV_Level;
      private bool cV_Level_IsChanged=false;
      public string CV_Level
      {
         get{ return cV_Level; }
         set{ cV_Level = value; cV_Level_IsChanged=true; }
      }
      public bool CV_Level_IsChanged
      {
         get{ return cV_Level_IsChanged; }
         set{ cV_Level_IsChanged = value; }
      }
      private string cV_Count;
      private bool cV_Count_IsChanged=false;
      public string CV_Count
      {
         get{ return cV_Count; }
         set{ cV_Count = value; cV_Count_IsChanged=true; }
      }
      public bool CV_Count_IsChanged
      {
         get{ return cV_Count_IsChanged; }
         set{ cV_Count_IsChanged = value; }
      }
      private DateTime cV_SupDate;
      private bool cV_SupDate_IsChanged=false;
      public DateTime CV_SupDate
      {
         get{ return cV_SupDate; }
         set{ cV_SupDate = value; cV_SupDate_IsChanged=true; }
      }
      public bool CV_SupDate_IsChanged
      {
         get{ return cV_SupDate_IsChanged; }
         set{ cV_SupDate_IsChanged = value; }
      }
      private string cV_CustAdvice;
      private bool cV_CustAdvice_IsChanged=false;
      public string CV_CustAdvice
      {
         get{ return cV_CustAdvice; }
         set{ cV_CustAdvice = value; cV_CustAdvice_IsChanged=true; }
      }
      public bool CV_CustAdvice_IsChanged
      {
         get{ return cV_CustAdvice_IsChanged; }
         set{ cV_CustAdvice_IsChanged = value; }
      }
      private string cV_Remark;
      private bool cV_Remark_IsChanged=false;
      public string CV_Remark
      {
         get{ return cV_Remark; }
         set{ cV_Remark = value; cV_Remark_IsChanged=true; }
      }
      public bool CV_Remark_IsChanged
      {
         get{ return cV_Remark_IsChanged; }
         set{ cV_Remark_IsChanged = value; }
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
   }
}
