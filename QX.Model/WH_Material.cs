using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 物料主数据
   /// </summary>
   [Serializable]
   public partial class WH_Material
   {
      /// <summary>
      /// 物料序号
      /// </summary>
      private decimal mD_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_ID_IsChanged=false;
      /// <summary>
      /// 物料序号
      /// </summary>
      public decimal MD_ID
      {
         get{ return mD_ID; }
         set{ mD_ID = value; mD_ID_IsChanged=true; }
      }
      /// <summary>
      /// 物料序号
      /// </summary>
      public bool MD_ID_IsChanged
      {
         get{ return mD_ID_IsChanged; }
         set{ mD_ID_IsChanged = value; }
      }
      /// <summary>
      /// 物料编号
      /// </summary>
      private string mD_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_MCode_IsChanged=false;
      /// <summary>
      /// 物料编号
      /// </summary>
      public string MD_MCode
      {
         get{ return mD_MCode; }
         set{ mD_MCode = value; mD_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编号
      /// </summary>
      public bool MD_MCode_IsChanged
      {
         get{ return mD_MCode_IsChanged; }
         set{ mD_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string mD_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_Name_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string MD_Name
      {
         get{ return mD_Name; }
         set{ mD_Name = value; mD_Name_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool MD_Name_IsChanged
      {
         get{ return mD_Name_IsChanged; }
         set{ mD_Name_IsChanged = value; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      private string mD_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_Spec_IsChanged=false;
      /// <summary>
      /// 规格
      /// </summary>
      public string MD_Spec
      {
         get{ return mD_Spec; }
         set{ mD_Spec = value; mD_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      public bool MD_Spec_IsChanged
      {
         get{ return mD_Spec_IsChanged; }
         set{ mD_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 条形码
      /// </summary>
      private string mD_Barcode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_Barcode_IsChanged=false;
      /// <summary>
      /// 条形码
      /// </summary>
      public string MD_Barcode
      {
         get{ return mD_Barcode; }
         set{ mD_Barcode = value; mD_Barcode_IsChanged=true; }
      }
      /// <summary>
      /// 条形码
      /// </summary>
      public bool MD_Barcode_IsChanged
      {
         get{ return mD_Barcode_IsChanged; }
         set{ mD_Barcode_IsChanged = value; }
      }
      /// <summary>
      /// 物料组
      /// </summary>
      private string mD_Group;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_Group_IsChanged=false;
      /// <summary>
      /// 物料组
      /// </summary>
      public string MD_Group
      {
         get{ return mD_Group; }
         set{ mD_Group = value; mD_Group_IsChanged=true; }
      }
      /// <summary>
      /// 物料组
      /// </summary>
      public bool MD_Group_IsChanged
      {
         get{ return mD_Group_IsChanged; }
         set{ mD_Group_IsChanged = value; }
      }
      private string mD_Group_Temp;
      private bool mD_Group_Temp_IsChanged=false;
      public string MD_Group_Temp
      {
         get{ return mD_Group_Temp; }
         set{ mD_Group_Temp = value; mD_Group_Temp_IsChanged=true; }
      }
      public bool MD_Group_Temp_IsChanged
      {
         get{ return mD_Group_Temp_IsChanged; }
         set{ mD_Group_Temp_IsChanged = value; }
      }
      /// <summary>
      /// 物料类型
      /// </summary>
      private string mD_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_iType_IsChanged=false;
      /// <summary>
      /// 物料类型
      /// </summary>
      public string MD_iType
      {
         get{ return mD_iType; }
         set{ mD_iType = value; mD_iType_IsChanged=true; }
      }
      /// <summary>
      /// 物料类型
      /// </summary>
      public bool MD_iType_IsChanged
      {
         get{ return mD_iType_IsChanged; }
         set{ mD_iType_IsChanged = value; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      private decimal mD_PriceList;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_PriceList_IsChanged=false;
      /// <summary>
      /// 价格
      /// </summary>
      public decimal MD_PriceList
      {
         get{ return mD_PriceList; }
         set{ mD_PriceList = value; mD_PriceList_IsChanged=true; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      public bool MD_PriceList_IsChanged
      {
         get{ return mD_PriceList_IsChanged; }
         set{ mD_PriceList_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string mD_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string MD_Unit
      {
         get{ return mD_Unit; }
         set{ mD_Unit = value; mD_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool MD_Unit_IsChanged
      {
         get{ return mD_Unit_IsChanged; }
         set{ mD_Unit_IsChanged = value; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      private decimal mD_Num;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_Num_IsChanged=false;
      /// <summary>
      /// 数量
      /// </summary>
      public decimal MD_Num
      {
         get{ return mD_Num; }
         set{ mD_Num = value; mD_Num_IsChanged=true; }
      }
      /// <summary>
      /// 数量
      /// </summary>
      public bool MD_Num_IsChanged
      {
         get{ return mD_Num_IsChanged; }
         set{ mD_Num_IsChanged = value; }
      }
      /// <summary>
      /// 库存最大值
      /// </summary>
      private decimal mD_LNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_LNum_IsChanged=false;
      /// <summary>
      /// 库存最大值
      /// </summary>
      public decimal MD_LNum
      {
         get{ return mD_LNum; }
         set{ mD_LNum = value; mD_LNum_IsChanged=true; }
      }
      /// <summary>
      /// 库存最大值
      /// </summary>
      public bool MD_LNum_IsChanged
      {
         get{ return mD_LNum_IsChanged; }
         set{ mD_LNum_IsChanged = value; }
      }
      /// <summary>
      /// 库存最小值
      /// </summary>
      private decimal mD_TNum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_TNum_IsChanged=false;
      /// <summary>
      /// 库存最小值
      /// </summary>
      public decimal MD_TNum
      {
         get{ return mD_TNum; }
         set{ mD_TNum = value; mD_TNum_IsChanged=true; }
      }
      /// <summary>
      /// 库存最小值
      /// </summary>
      public bool MD_TNum_IsChanged
      {
         get{ return mD_TNum_IsChanged; }
         set{ mD_TNum_IsChanged = value; }
      }
      /// <summary>
      /// 制造厂商
      /// </summary>
      private string mD_Factory;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_Factory_IsChanged=false;
      /// <summary>
      /// 制造厂商
      /// </summary>
      public string MD_Factory
      {
         get{ return mD_Factory; }
         set{ mD_Factory = value; mD_Factory_IsChanged=true; }
      }
      /// <summary>
      /// 制造厂商
      /// </summary>
      public bool MD_Factory_IsChanged
      {
         get{ return mD_Factory_IsChanged; }
         set{ mD_Factory_IsChanged = value; }
      }
      /// <summary>
      /// 存货度量单位
      /// </summary>
      private string mD_Units;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_Units_IsChanged=false;
      /// <summary>
      /// 存货度量单位
      /// </summary>
      public string MD_Units
      {
         get{ return mD_Units; }
         set{ mD_Units = value; mD_Units_IsChanged=true; }
      }
      /// <summary>
      /// 存货度量单位
      /// </summary>
      public bool MD_Units_IsChanged
      {
         get{ return mD_Units_IsChanged; }
         set{ mD_Units_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string mD_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string MD_Bak
      {
         get{ return mD_Bak; }
         set{ mD_Bak = value; mD_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool MD_Bak_IsChanged
      {
         get{ return mD_Bak_IsChanged; }
         set{ mD_Bak_IsChanged = value; }
      }
      private string mD_DWName;
      private bool mD_DWName_IsChanged=false;
      public string MD_DWName
      {
         get{ return mD_DWName; }
         set{ mD_DWName = value; mD_DWName_IsChanged=true; }
      }
      public bool MD_DWName_IsChanged
      {
         get{ return mD_DWName_IsChanged; }
         set{ mD_DWName_IsChanged = value; }
      }
      private string mD_DWCode;
      private bool mD_DWCode_IsChanged=false;
      public string MD_DWCode
      {
         get{ return mD_DWCode; }
         set{ mD_DWCode = value; mD_DWCode_IsChanged=true; }
      }
      public bool MD_DWCode_IsChanged
      {
         get{ return mD_DWCode_IsChanged; }
         set{ mD_DWCode_IsChanged = value; }
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
      private string mD_UDEF1;
      private bool mD_UDEF1_IsChanged=false;
      public string MD_UDEF1
      {
         get{ return mD_UDEF1; }
         set{ mD_UDEF1 = value; mD_UDEF1_IsChanged=true; }
      }
      public bool MD_UDEF1_IsChanged
      {
         get{ return mD_UDEF1_IsChanged; }
         set{ mD_UDEF1_IsChanged = value; }
      }
      private string mD_UDEF2;
      private bool mD_UDEF2_IsChanged=false;
      public string MD_UDEF2
      {
         get{ return mD_UDEF2; }
         set{ mD_UDEF2 = value; mD_UDEF2_IsChanged=true; }
      }
      public bool MD_UDEF2_IsChanged
      {
         get{ return mD_UDEF2_IsChanged; }
         set{ mD_UDEF2_IsChanged = value; }
      }
      private string mD_UDEF3;
      private bool mD_UDEF3_IsChanged=false;
      public string MD_UDEF3
      {
         get{ return mD_UDEF3; }
         set{ mD_UDEF3 = value; mD_UDEF3_IsChanged=true; }
      }
      public bool MD_UDEF3_IsChanged
      {
         get{ return mD_UDEF3_IsChanged; }
         set{ mD_UDEF3_IsChanged = value; }
      }
      private string mD_UDEF4;
      private bool mD_UDEF4_IsChanged=false;
      public string MD_UDEF4
      {
         get{ return mD_UDEF4; }
         set{ mD_UDEF4 = value; mD_UDEF4_IsChanged=true; }
      }
      public bool MD_UDEF4_IsChanged
      {
         get{ return mD_UDEF4_IsChanged; }
         set{ mD_UDEF4_IsChanged = value; }
      }
      private string mD_UDEF5;
      private bool mD_UDEF5_IsChanged=false;
      public string MD_UDEF5
      {
         get{ return mD_UDEF5; }
         set{ mD_UDEF5 = value; mD_UDEF5_IsChanged=true; }
      }
      public bool MD_UDEF5_IsChanged
      {
         get{ return mD_UDEF5_IsChanged; }
         set{ mD_UDEF5_IsChanged = value; }
      }
      /// <summary>
      /// 技术参数
      /// </summary>
      private string mD_TechCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_TechCode_IsChanged=false;
      /// <summary>
      /// 技术参数
      /// </summary>
      public string MD_TechCode
      {
         get{ return mD_TechCode; }
         set{ mD_TechCode = value; mD_TechCode_IsChanged=true; }
      }
      /// <summary>
      /// 技术参数
      /// </summary>
      public bool MD_TechCode_IsChanged
      {
         get{ return mD_TechCode_IsChanged; }
         set{ mD_TechCode_IsChanged = value; }
      }
   }
}
