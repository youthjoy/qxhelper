using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class TC_RTemplate
   {
      private decimal tCRT_ID;
      private bool tCRT_ID_IsChanged=false;
      public decimal TCRT_ID
      {
         get{ return tCRT_ID; }
         set{ tCRT_ID = value; tCRT_ID_IsChanged=true; }
      }
      public bool TCRT_ID_IsChanged
      {
         get{ return tCRT_ID_IsChanged; }
         set{ tCRT_ID_IsChanged = value; }
      }
      /// <summary>
      /// 检测模板编码
      /// </summary>
      private string tCRT_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRT_Code_IsChanged=false;
      /// <summary>
      /// 检测模板编码
      /// </summary>
      public string TCRT_Code
      {
         get{ return tCRT_Code; }
         set{ tCRT_Code = value; tCRT_Code_IsChanged=true; }
      }
      /// <summary>
      /// 检测模板编码
      /// </summary>
      public bool TCRT_Code_IsChanged
      {
         get{ return tCRT_Code_IsChanged; }
         set{ tCRT_Code_IsChanged = value; }
      }
      /// <summary>
      /// 检测模板名称
      /// </summary>
      private string tCRT_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRT_Name_IsChanged=false;
      /// <summary>
      /// 检测模板名称
      /// </summary>
      public string TCRT_Name
      {
         get{ return tCRT_Name; }
         set{ tCRT_Name = value; tCRT_Name_IsChanged=true; }
      }
      /// <summary>
      /// 检测模板名称
      /// </summary>
      public bool TCRT_Name_IsChanged
      {
         get{ return tCRT_Name_IsChanged; }
         set{ tCRT_Name_IsChanged = value; }
      }
      /// <summary>
      /// 检测模板类型
      /// </summary>
      private string tCRT_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRT_Type_IsChanged=false;
      /// <summary>
      /// 检测模板类型
      /// </summary>
      public string TCRT_Type
      {
         get{ return tCRT_Type; }
         set{ tCRT_Type = value; tCRT_Type_IsChanged=true; }
      }
      /// <summary>
      /// 检测模板类型
      /// </summary>
      public bool TCRT_Type_IsChanged
      {
         get{ return tCRT_Type_IsChanged; }
         set{ tCRT_Type_IsChanged = value; }
      }
      /// <summary>
      /// 检测模板状态
      /// </summary>
      private string tCRT_Stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRT_Stat_IsChanged=false;
      /// <summary>
      /// 检测模板状态
      /// </summary>
      public string TCRT_Stat
      {
         get{ return tCRT_Stat; }
         set{ tCRT_Stat = value; tCRT_Stat_IsChanged=true; }
      }
      /// <summary>
      /// 检测模板状态
      /// </summary>
      public bool TCRT_Stat_IsChanged
      {
         get{ return tCRT_Stat_IsChanged; }
         set{ tCRT_Stat_IsChanged = value; }
      }
      /// <summary>
      /// 检测模板内部类型
      /// </summary>
      private string tCRT_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRT_iType_IsChanged=false;
      /// <summary>
      /// 检测模板内部类型
      /// </summary>
      public string TCRT_iType
      {
         get{ return tCRT_iType; }
         set{ tCRT_iType = value; tCRT_iType_IsChanged=true; }
      }
      /// <summary>
      /// 检测模板内部类型
      /// </summary>
      public bool TCRT_iType_IsChanged
      {
         get{ return tCRT_iType_IsChanged; }
         set{ tCRT_iType_IsChanged = value; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      private string tCRT_Operator;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRT_Operator_IsChanged=false;
      /// <summary>
      /// 操作人
      /// </summary>
      public string TCRT_Operator
      {
         get{ return tCRT_Operator; }
         set{ tCRT_Operator = value; tCRT_Operator_IsChanged=true; }
      }
      /// <summary>
      /// 操作人
      /// </summary>
      public bool TCRT_Operator_IsChanged
      {
         get{ return tCRT_Operator_IsChanged; }
         set{ tCRT_Operator_IsChanged = value; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      private DateTime tCRT_OpDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRT_OpDate_IsChanged=false;
      /// <summary>
      /// 操作时间
      /// </summary>
      public DateTime TCRT_OpDate
      {
         get{ return tCRT_OpDate; }
         set{ tCRT_OpDate = value; tCRT_OpDate_IsChanged=true; }
      }
      /// <summary>
      /// 操作时间
      /// </summary>
      public bool TCRT_OpDate_IsChanged
      {
         get{ return tCRT_OpDate_IsChanged; }
         set{ tCRT_OpDate_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string tCRT_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool tCRT_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string TCRT_Remark
      {
         get{ return tCRT_Remark; }
         set{ tCRT_Remark = value; tCRT_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool TCRT_Remark_IsChanged
      {
         get{ return tCRT_Remark_IsChanged; }
         set{ tCRT_Remark_IsChanged = value; }
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
