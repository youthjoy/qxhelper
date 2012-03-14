using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 甲供记录
   /// </summary>
   [Serializable]
   public partial class WHR_PartyARecord
   {
      /// <summary>
      /// 物料序号
      /// </summary>
      private decimal wHR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_ID_IsChanged=false;
      /// <summary>
      /// 物料序号
      /// </summary>
      public decimal WHR_ID
      {
         get{ return wHR_ID; }
         set{ wHR_ID = value; wHR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 物料序号
      /// </summary>
      public bool WHR_ID_IsChanged
      {
         get{ return wHR_ID_IsChanged; }
         set{ wHR_ID_IsChanged = value; }
      }
      private string wHR_Code;
      private bool wHR_Code_IsChanged=false;
      public string WHR_Code
      {
         get{ return wHR_Code; }
         set{ wHR_Code = value; wHR_Code_IsChanged=true; }
      }
      public bool WHR_Code_IsChanged
      {
         get{ return wHR_Code_IsChanged; }
         set{ wHR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 物料编号
      /// </summary>
      private string wHR_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_MCode_IsChanged=false;
      /// <summary>
      /// 物料编号
      /// </summary>
      public string WHR_MCode
      {
         get{ return wHR_MCode; }
         set{ wHR_MCode = value; wHR_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编号
      /// </summary>
      public bool WHR_MCode_IsChanged
      {
         get{ return wHR_MCode_IsChanged; }
         set{ wHR_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string wHR_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_Name_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string WHR_Name
      {
         get{ return wHR_Name; }
         set{ wHR_Name = value; wHR_Name_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool WHR_Name_IsChanged
      {
         get{ return wHR_Name_IsChanged; }
         set{ wHR_Name_IsChanged = value; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      private string wHR_CustCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_CustCode_IsChanged=false;
      /// <summary>
      /// 客户编码
      /// </summary>
      public string WHR_CustCode
      {
         get{ return wHR_CustCode; }
         set{ wHR_CustCode = value; wHR_CustCode_IsChanged=true; }
      }
      /// <summary>
      /// 客户编码
      /// </summary>
      public bool WHR_CustCode_IsChanged
      {
         get{ return wHR_CustCode_IsChanged; }
         set{ wHR_CustCode_IsChanged = value; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      private string wHR_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_CCode_IsChanged=false;
      /// <summary>
      /// 合同编码
      /// </summary>
      public string WHR_CCode
      {
         get{ return wHR_CCode; }
         set{ wHR_CCode = value; wHR_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 合同编码
      /// </summary>
      public bool WHR_CCode_IsChanged
      {
         get{ return wHR_CCode_IsChanged; }
         set{ wHR_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      private string wHR_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_PCode_IsChanged=false;
      /// <summary>
      /// 工程编码
      /// </summary>
      public string WHR_PCode
      {
         get{ return wHR_PCode; }
         set{ wHR_PCode = value; wHR_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 工程编码
      /// </summary>
      public bool WHR_PCode_IsChanged
      {
         get{ return wHR_PCode_IsChanged; }
         set{ wHR_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      private string wHR_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_Spec_IsChanged=false;
      /// <summary>
      /// 规格
      /// </summary>
      public string WHR_Spec
      {
         get{ return wHR_Spec; }
         set{ wHR_Spec = value; wHR_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 规格
      /// </summary>
      public bool WHR_Spec_IsChanged
      {
         get{ return wHR_Spec_IsChanged; }
         set{ wHR_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 物料组
      /// </summary>
      private string wHR_Group;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_Group_IsChanged=false;
      /// <summary>
      /// 物料组
      /// </summary>
      public string WHR_Group
      {
         get{ return wHR_Group; }
         set{ wHR_Group = value; wHR_Group_IsChanged=true; }
      }
      /// <summary>
      /// 物料组
      /// </summary>
      public bool WHR_Group_IsChanged
      {
         get{ return wHR_Group_IsChanged; }
         set{ wHR_Group_IsChanged = value; }
      }
      private string wHR_GroupCode;
      private bool wHR_GroupCode_IsChanged=false;
      public string WHR_GroupCode
      {
         get{ return wHR_GroupCode; }
         set{ wHR_GroupCode = value; wHR_GroupCode_IsChanged=true; }
      }
      public bool WHR_GroupCode_IsChanged
      {
         get{ return wHR_GroupCode_IsChanged; }
         set{ wHR_GroupCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料类型
      /// </summary>
      private string wHR_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_iType_IsChanged=false;
      /// <summary>
      /// 物料类型
      /// </summary>
      public string WHR_iType
      {
         get{ return wHR_iType; }
         set{ wHR_iType = value; wHR_iType_IsChanged=true; }
      }
      /// <summary>
      /// 物料类型
      /// </summary>
      public bool WHR_iType_IsChanged
      {
         get{ return wHR_iType_IsChanged; }
         set{ wHR_iType_IsChanged = value; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      private decimal wHR_PriceList;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_PriceList_IsChanged=false;
      /// <summary>
      /// 价格
      /// </summary>
      public decimal WHR_PriceList
      {
         get{ return wHR_PriceList; }
         set{ wHR_PriceList = value; wHR_PriceList_IsChanged=true; }
      }
      /// <summary>
      /// 价格
      /// </summary>
      public bool WHR_PriceList_IsChanged
      {
         get{ return wHR_PriceList_IsChanged; }
         set{ wHR_PriceList_IsChanged = value; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      private string wHR_Unit;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_Unit_IsChanged=false;
      /// <summary>
      /// 单位
      /// </summary>
      public string WHR_Unit
      {
         get{ return wHR_Unit; }
         set{ wHR_Unit = value; wHR_Unit_IsChanged=true; }
      }
      /// <summary>
      /// 单位
      /// </summary>
      public bool WHR_Unit_IsChanged
      {
         get{ return wHR_Unit_IsChanged; }
         set{ wHR_Unit_IsChanged = value; }
      }
      private string wHR_Units;
      private bool wHR_Units_IsChanged=false;
      public string WHR_Units
      {
         get{ return wHR_Units; }
         set{ wHR_Units = value; wHR_Units_IsChanged=true; }
      }
      public bool WHR_Units_IsChanged
      {
         get{ return wHR_Units_IsChanged; }
         set{ wHR_Units_IsChanged = value; }
      }
      /// <summary>
      /// 制造厂商
      /// </summary>
      private string wHR_Factory;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool wHR_Factory_IsChanged=false;
      /// <summary>
      /// 制造厂商
      /// </summary>
      public string WHR_Factory
      {
         get{ return wHR_Factory; }
         set{ wHR_Factory = value; wHR_Factory_IsChanged=true; }
      }
      /// <summary>
      /// 制造厂商
      /// </summary>
      public bool WHR_Factory_IsChanged
      {
         get{ return wHR_Factory_IsChanged; }
         set{ wHR_Factory_IsChanged = value; }
      }
      /// <summary>
      /// 默认仓库
      /// </summary>
      private string mD_DWCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool mD_DWCode_IsChanged=false;
      /// <summary>
      /// 默认仓库
      /// </summary>
      public string MD_DWCode
      {
         get{ return mD_DWCode; }
         set{ mD_DWCode = value; mD_DWCode_IsChanged=true; }
      }
      /// <summary>
      /// 默认仓库
      /// </summary>
      public bool MD_DWCode_IsChanged
      {
         get{ return mD_DWCode_IsChanged; }
         set{ mD_DWCode_IsChanged = value; }
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
      /// 模块编码
      /// </summary>
      private string module_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool module_Code_IsChanged=false;
      /// <summary>
      /// 模块编码
      /// </summary>
      public string Module_Code
      {
         get{ return module_Code; }
         set{ module_Code = value; module_Code_IsChanged=true; }
      }
      /// <summary>
      /// 模块编码
      /// </summary>
      public bool Module_Code_IsChanged
      {
         get{ return module_Code_IsChanged; }
         set{ module_Code_IsChanged = value; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      private string record_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool record_ID_IsChanged=false;
      /// <summary>
      /// 单据编码
      /// </summary>
      public string Record_ID
      {
         get{ return record_ID; }
         set{ record_ID = value; record_ID_IsChanged=true; }
      }
      /// <summary>
      /// 单据编码
      /// </summary>
      public bool Record_ID_IsChanged
      {
         get{ return record_ID_IsChanged; }
         set{ record_ID_IsChanged = value; }
      }
   }
}
