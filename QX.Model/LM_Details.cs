using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 计量信息
   /// </summary>
   [Serializable]
   public partial class LM_Details
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
      private string lMD_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lMD_Code_IsChanged=false;
      /// <summary>
      /// 计量信息编码
      /// </summary>
      public string LMD_Code
      {
         get{ return lMD_Code; }
         set{ lMD_Code = value; lMD_Code_IsChanged=true; }
      }
      /// <summary>
      /// 计量信息编码
      /// </summary>
      public bool LMD_Code_IsChanged
      {
         get{ return lMD_Code_IsChanged; }
         set{ lMD_Code_IsChanged = value; }
      }
      /// <summary>
      /// 地磅计量信息编码
      /// </summary>
      private string lMD_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lMD_MCode_IsChanged=false;
      /// <summary>
      /// 地磅计量信息编码
      /// </summary>
      public string LMD_MCode
      {
         get{ return lMD_MCode; }
         set{ lMD_MCode = value; lMD_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 地磅计量信息编码
      /// </summary>
      public bool LMD_MCode_IsChanged
      {
         get{ return lMD_MCode_IsChanged; }
         set{ lMD_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 计量项目名称
      /// </summary>
      private string lMD_ItemName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lMD_ItemName_IsChanged=false;
      /// <summary>
      /// 计量项目名称
      /// </summary>
      public string LMD_ItemName
      {
         get{ return lMD_ItemName; }
         set{ lMD_ItemName = value; lMD_ItemName_IsChanged=true; }
      }
      /// <summary>
      /// 计量项目名称
      /// </summary>
      public bool LMD_ItemName_IsChanged
      {
         get{ return lMD_ItemName_IsChanged; }
         set{ lMD_ItemName_IsChanged = value; }
      }
      /// <summary>
      /// 计量项目
      /// </summary>
      private string lMD_Item;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lMD_Item_IsChanged=false;
      /// <summary>
      /// 计量项目
      /// </summary>
      public string LMD_Item
      {
         get{ return lMD_Item; }
         set{ lMD_Item = value; lMD_Item_IsChanged=true; }
      }
      /// <summary>
      /// 计量项目
      /// </summary>
      public bool LMD_Item_IsChanged
      {
         get{ return lMD_Item_IsChanged; }
         set{ lMD_Item_IsChanged = value; }
      }
      /// <summary>
      /// 计量结果
      /// </summary>
      private float lMD_Result;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lMD_Result_IsChanged=false;
      /// <summary>
      /// 计量结果
      /// </summary>
      public float LMD_Result
      {
         get{ return lMD_Result; }
         set{ lMD_Result = value; lMD_Result_IsChanged=true; }
      }
      /// <summary>
      /// 计量结果
      /// </summary>
      public bool LMD_Result_IsChanged
      {
         get{ return lMD_Result_IsChanged; }
         set{ lMD_Result_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string lMD_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool lMD_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string LMD_Remark
      {
         get{ return lMD_Remark; }
         set{ lMD_Remark = value; lMD_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool LMD_Remark_IsChanged
      {
         get{ return lMD_Remark_IsChanged; }
         set{ lMD_Remark_IsChanged = value; }
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
