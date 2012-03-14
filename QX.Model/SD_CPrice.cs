using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 销售合同价格
   /// </summary>
   [Serializable]
   public partial class SD_CPrice
   {
      /// <summary>
      /// 合同关联价格序号
      /// </summary>
      private decimal sDP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_ID_IsChanged=false;
      /// <summary>
      /// 合同关联价格序号
      /// </summary>
      public decimal SDP_ID
      {
         get{ return sDP_ID; }
         set{ sDP_ID = value; sDP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 合同关联价格序号
      /// </summary>
      public bool SDP_ID_IsChanged
      {
         get{ return sDP_ID_IsChanged; }
         set{ sDP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 合同关联价格编码
      /// </summary>
      private string sDP_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_Code_IsChanged=false;
      /// <summary>
      /// 合同关联价格编码
      /// </summary>
      public string SDP_Code
      {
         get{ return sDP_Code; }
         set{ sDP_Code = value; sDP_Code_IsChanged=true; }
      }
      /// <summary>
      /// 合同关联价格编码
      /// </summary>
      public bool SDP_Code_IsChanged
      {
         get{ return sDP_Code_IsChanged; }
         set{ sDP_Code_IsChanged = value; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      private string sDP_SCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_SCode_IsChanged=false;
      /// <summary>
      /// 合同编码
      /// </summary>
      public string SDP_SCode
      {
         get{ return sDP_SCode; }
         set{ sDP_SCode = value; sDP_SCode_IsChanged=true; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      public bool SDP_SCode_IsChanged
      {
         get{ return sDP_SCode_IsChanged; }
         set{ sDP_SCode_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string sDP_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_CCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string SDP_CCode
      {
         get{ return sDP_CCode; }
         set{ sDP_CCode = value; sDP_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool SDP_CCode_IsChanged
      {
         get{ return sDP_CCode_IsChanged; }
         set{ sDP_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 产品类别
      /// </summary>
      private string sDP_Category;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_Category_IsChanged=false;
      /// <summary>
      /// 产品类别
      /// </summary>
      public string SDP_Category
      {
         get{ return sDP_Category; }
         set{ sDP_Category = value; sDP_Category_IsChanged=true; }
      }
      /// <summary>
      /// 产品类别
      /// </summary>
      public bool SDP_Category_IsChanged
      {
         get{ return sDP_Category_IsChanged; }
         set{ sDP_Category_IsChanged = value; }
      }
      /// <summary>
      /// 产品名称
      /// </summary>
      private string sDP_ProName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_ProName_IsChanged=false;
      /// <summary>
      /// 产品名称
      /// </summary>
      public string SDP_ProName
      {
         get{ return sDP_ProName; }
         set{ sDP_ProName = value; sDP_ProName_IsChanged=true; }
      }
      /// <summary>
      /// 产品名称
      /// </summary>
      public bool SDP_ProName_IsChanged
      {
         get{ return sDP_ProName_IsChanged; }
         set{ sDP_ProName_IsChanged = value; }
      }
      /// <summary>
      /// 产品编码
      /// </summary>
      private string sDP_ProCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_ProCode_IsChanged=false;
      /// <summary>
      /// 产品编码
      /// </summary>
      public string SDP_ProCode
      {
         get{ return sDP_ProCode; }
         set{ sDP_ProCode = value; sDP_ProCode_IsChanged=true; }
      }
      /// <summary>
      /// 产品编码
      /// </summary>
      public bool SDP_ProCode_IsChanged
      {
         get{ return sDP_ProCode_IsChanged; }
         set{ sDP_ProCode_IsChanged = value; }
      }
      /// <summary>
      /// 执行开始时间
      /// </summary>
      private DateTime sDP_Start;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_Start_IsChanged=false;
      /// <summary>
      /// 执行开始时间
      /// </summary>
      public DateTime SDP_Start
      {
         get{ return sDP_Start; }
         set{ sDP_Start = value; sDP_Start_IsChanged=true; }
      }
      /// <summary>
      /// 执行开始时间
      /// </summary>
      public bool SDP_Start_IsChanged
      {
         get{ return sDP_Start_IsChanged; }
         set{ sDP_Start_IsChanged = value; }
      }
      /// <summary>
      /// 执行结束时间
      /// </summary>
      private DateTime sDP_End;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_End_IsChanged=false;
      /// <summary>
      /// 执行结束时间
      /// </summary>
      public DateTime SDP_End
      {
         get{ return sDP_End; }
         set{ sDP_End = value; sDP_End_IsChanged=true; }
      }
      /// <summary>
      /// 执行结束时间
      /// </summary>
      public bool SDP_End_IsChanged
      {
         get{ return sDP_End_IsChanged; }
         set{ sDP_End_IsChanged = value; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      private decimal sDP_Price;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_Price_IsChanged=false;
      /// <summary>
      /// 价格
      /// </summary>
      public decimal SDP_Price
      {
         get{ return sDP_Price; }
         set{ sDP_Price = value; sDP_Price_IsChanged=true; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      public bool SDP_Price_IsChanged
      {
         get{ return sDP_Price_IsChanged; }
         set{ sDP_Price_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string sDP_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string SDP_Remark
      {
         get{ return sDP_Remark; }
         set{ sDP_Remark = value; sDP_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool SDP_Remark_IsChanged
      {
         get{ return sDP_Remark_IsChanged; }
         set{ sDP_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string sDP_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string SDP_Unit
      {
         get{ return sDP_Unit; }
         set{ sDP_Unit = value; sDP_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool SDP_Unit_IsChanged
      {
         get{ return sDP_Unit_IsChanged; }
         set{ sDP_Unit_IsChanged = value; }
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
      /// <summary>
      /// 强度等级
      /// </summary>
      private string sDP_Level;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool sDP_Level_IsChanged=false;
      /// <summary>
      /// 强度等级
      /// </summary>
      public string SDP_Level
      {
         get{ return sDP_Level; }
         set{ sDP_Level = value; sDP_Level_IsChanged=true; }
      }
      /// <summary>
      /// 强度等级
      /// </summary>
      public bool SDP_Level_IsChanged
      {
         get{ return sDP_Level_IsChanged; }
         set{ sDP_Level_IsChanged = value; }
      }
      private string sDP_UDEF1;
      private bool sDP_UDEF1_IsChanged=false;
      public string SDP_UDEF1
      {
         get{ return sDP_UDEF1; }
         set{ sDP_UDEF1 = value; sDP_UDEF1_IsChanged=true; }
      }
      public bool SDP_UDEF1_IsChanged
      {
         get{ return sDP_UDEF1_IsChanged; }
         set{ sDP_UDEF1_IsChanged = value; }
      }
      private string sDP_UDEF2;
      private bool sDP_UDEF2_IsChanged=false;
      public string SDP_UDEF2
      {
         get{ return sDP_UDEF2; }
         set{ sDP_UDEF2 = value; sDP_UDEF2_IsChanged=true; }
      }
      public bool SDP_UDEF2_IsChanged
      {
         get{ return sDP_UDEF2_IsChanged; }
         set{ sDP_UDEF2_IsChanged = value; }
      }
      private string sDP_UDEF3;
      private bool sDP_UDEF3_IsChanged=false;
      public string SDP_UDEF3
      {
         get{ return sDP_UDEF3; }
         set{ sDP_UDEF3 = value; sDP_UDEF3_IsChanged=true; }
      }
      public bool SDP_UDEF3_IsChanged
      {
         get{ return sDP_UDEF3_IsChanged; }
         set{ sDP_UDEF3_IsChanged = value; }
      }
      private string sDP_UDEF4;
      private bool sDP_UDEF4_IsChanged=false;
      public string SDP_UDEF4
      {
         get{ return sDP_UDEF4; }
         set{ sDP_UDEF4 = value; sDP_UDEF4_IsChanged=true; }
      }
      public bool SDP_UDEF4_IsChanged
      {
         get{ return sDP_UDEF4_IsChanged; }
         set{ sDP_UDEF4_IsChanged = value; }
      }
      private string sDP_UDEF5;
      private bool sDP_UDEF5_IsChanged=false;
      public string SDP_UDEF5
      {
         get{ return sDP_UDEF5; }
         set{ sDP_UDEF5 = value; sDP_UDEF5_IsChanged=true; }
      }
      public bool SDP_UDEF5_IsChanged
      {
         get{ return sDP_UDEF5_IsChanged; }
         set{ sDP_UDEF5_IsChanged = value; }
      }
      private string sDP_UDEF6;
      private bool sDP_UDEF6_IsChanged=false;
      public string SDP_UDEF6
      {
         get{ return sDP_UDEF6; }
         set{ sDP_UDEF6 = value; sDP_UDEF6_IsChanged=true; }
      }
      public bool SDP_UDEF6_IsChanged
      {
         get{ return sDP_UDEF6_IsChanged; }
         set{ sDP_UDEF6_IsChanged = value; }
      }
      private string sDP_UDEF7;
      private bool sDP_UDEF7_IsChanged=false;
      public string SDP_UDEF7
      {
         get{ return sDP_UDEF7; }
         set{ sDP_UDEF7 = value; sDP_UDEF7_IsChanged=true; }
      }
      public bool SDP_UDEF7_IsChanged
      {
         get{ return sDP_UDEF7_IsChanged; }
         set{ sDP_UDEF7_IsChanged = value; }
      }
      private string sDP_UDEF8;
      private bool sDP_UDEF8_IsChanged=false;
      public string SDP_UDEF8
      {
         get{ return sDP_UDEF8; }
         set{ sDP_UDEF8 = value; sDP_UDEF8_IsChanged=true; }
      }
      public bool SDP_UDEF8_IsChanged
      {
         get{ return sDP_UDEF8_IsChanged; }
         set{ sDP_UDEF8_IsChanged = value; }
      }
      private string sDP_UDEF9;
      private bool sDP_UDEF9_IsChanged=false;
      public string SDP_UDEF9
      {
         get{ return sDP_UDEF9; }
         set{ sDP_UDEF9 = value; sDP_UDEF9_IsChanged=true; }
      }
      public bool SDP_UDEF9_IsChanged
      {
         get{ return sDP_UDEF9_IsChanged; }
         set{ sDP_UDEF9_IsChanged = value; }
      }
      private string sDP_UDEF10;
      private bool sDP_UDEF10_IsChanged=false;
      public string SDP_UDEF10
      {
         get{ return sDP_UDEF10; }
         set{ sDP_UDEF10 = value; sDP_UDEF10_IsChanged=true; }
      }
      public bool SDP_UDEF10_IsChanged
      {
         get{ return sDP_UDEF10_IsChanged; }
         set{ sDP_UDEF10_IsChanged = value; }
      }
   }
}
