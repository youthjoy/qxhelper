using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 计量信息
   /// </summary>
   [Serializable]
   public partial class Measure_Details
   {
      /// <summary>
      /// 计量信息序号
      /// </summary>
      private decimal measure_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool measure_ID_IsChanged=false;
      /// <summary>
      /// 计量信息序号
      /// </summary>
      public decimal Measure_ID
      {
         get{ return measure_ID; }
         set{ measure_ID = value; measure_ID_IsChanged=true; }
      }
      /// <summary>
      /// 计量信息序号
      /// </summary>
      public bool Measure_ID_IsChanged
      {
         get{ return measure_ID_IsChanged; }
         set{ measure_ID_IsChanged = value; }
      }
      /// <summary>
      /// 计量信息编码
      /// </summary>
      private string measure_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool measure_Code_IsChanged=false;
      /// <summary>
      /// 计量信息编码
      /// </summary>
      public string Measure_Code
      {
         get{ return measure_Code; }
         set{ measure_Code = value; measure_Code_IsChanged=true; }
      }
      /// <summary>
      /// 计量信息编码
      /// </summary>
      public bool Measure_Code_IsChanged
      {
         get{ return measure_Code_IsChanged; }
         set{ measure_Code_IsChanged = value; }
      }
      /// <summary>
      /// 地磅计量信息编码
      /// </summary>
      private string measure_LoadometerCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool measure_LoadometerCode_IsChanged=false;
      /// <summary>
      /// 地磅计量信息编码
      /// </summary>
      public string Measure_LoadometerCode
      {
         get{ return measure_LoadometerCode; }
         set{ measure_LoadometerCode = value; measure_LoadometerCode_IsChanged=true; }
      }
      /// <summary>
      /// 地磅计量信息编码
      /// </summary>
      public bool Measure_LoadometerCode_IsChanged
      {
         get{ return measure_LoadometerCode_IsChanged; }
         set{ measure_LoadometerCode_IsChanged = value; }
      }
      /// <summary>
      /// 计量项目名称
      /// </summary>
      private string measure_ItemName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool measure_ItemName_IsChanged=false;
      /// <summary>
      /// 计量项目名称
      /// </summary>
      public string Measure_ItemName
      {
         get{ return measure_ItemName; }
         set{ measure_ItemName = value; measure_ItemName_IsChanged=true; }
      }
      /// <summary>
      /// 计量项目名称
      /// </summary>
      public bool Measure_ItemName_IsChanged
      {
         get{ return measure_ItemName_IsChanged; }
         set{ measure_ItemName_IsChanged = value; }
      }
      /// <summary>
      /// 计量项目
      /// </summary>
      private string measure_Item;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool measure_Item_IsChanged=false;
      /// <summary>
      /// 计量项目
      /// </summary>
      public string Measure_Item
      {
         get{ return measure_Item; }
         set{ measure_Item = value; measure_Item_IsChanged=true; }
      }
      /// <summary>
      /// 计量项目
      /// </summary>
      public bool Measure_Item_IsChanged
      {
         get{ return measure_Item_IsChanged; }
         set{ measure_Item_IsChanged = value; }
      }
      /// <summary>
      /// 计量结果
      /// </summary>
      private float measure_Result;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool measure_Result_IsChanged=false;
      /// <summary>
      /// 计量结果
      /// </summary>
      public float Measure_Result
      {
         get{ return measure_Result; }
         set{ measure_Result = value; measure_Result_IsChanged=true; }
      }
      /// <summary>
      /// 计量结果
      /// </summary>
      public bool Measure_Result_IsChanged
      {
         get{ return measure_Result_IsChanged; }
         set{ measure_Result_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string measure_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool measure_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Measure_Remark
      {
         get{ return measure_Remark; }
         set{ measure_Remark = value; measure_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Measure_Remark_IsChanged
      {
         get{ return measure_Remark_IsChanged; }
         set{ measure_Remark_IsChanged = value; }
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
