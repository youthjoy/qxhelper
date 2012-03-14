using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 仓库信息
   /// </summary>
   [Serializable]
   public partial class WH_Warehouse
   {
      /// <summary>
      /// 仓库信息序号
      /// </summary>
      private decimal warehouse_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_ID_IsChanged=false;
      /// <summary>
      /// 仓库信息序号
      /// </summary>
      public decimal Warehouse_ID
      {
         get{ return warehouse_ID; }
         set{ warehouse_ID = value; warehouse_ID_IsChanged=true; }
      }
      /// <summary>
      /// 仓库信息序号
      /// </summary>
      public bool Warehouse_ID_IsChanged
      {
         get{ return warehouse_ID_IsChanged; }
         set{ warehouse_ID_IsChanged = value; }
      }
      /// <summary>
      /// 仓库信息编码
      /// </summary>
      private string warehouse_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_Code_IsChanged=false;
      /// <summary>
      /// 仓库信息编码
      /// </summary>
      public string Warehouse_Code
      {
         get{ return warehouse_Code; }
         set{ warehouse_Code = value; warehouse_Code_IsChanged=true; }
      }
      /// <summary>
      /// 仓库信息编码
      /// </summary>
      public bool Warehouse_Code_IsChanged
      {
         get{ return warehouse_Code_IsChanged; }
         set{ warehouse_Code_IsChanged = value; }
      }
      /// <summary>
      /// 仓库名称
      /// </summary>
      private string warehouse_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_Name_IsChanged=false;
      /// <summary>
      /// 仓库名称
      /// </summary>
      public string Warehouse_Name
      {
         get{ return warehouse_Name; }
         set{ warehouse_Name = value; warehouse_Name_IsChanged=true; }
      }
      /// <summary>
      /// 仓库名称
      /// </summary>
      public bool Warehouse_Name_IsChanged
      {
         get{ return warehouse_Name_IsChanged; }
         set{ warehouse_Name_IsChanged = value; }
      }
      /// <summary>
      /// 仓号
      /// </summary>
      private int warehouse_No;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_No_IsChanged=false;
      /// <summary>
      /// 仓号
      /// </summary>
      public int Warehouse_No
      {
         get{ return warehouse_No; }
         set{ warehouse_No = value; warehouse_No_IsChanged=true; }
      }
      /// <summary>
      /// 仓号
      /// </summary>
      public bool Warehouse_No_IsChanged
      {
         get{ return warehouse_No_IsChanged; }
         set{ warehouse_No_IsChanged = value; }
      }
      /// <summary>
      /// 仓库情况描述
      /// </summary>
      private string warehouse_Intro;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_Intro_IsChanged=false;
      /// <summary>
      /// 仓库情况描述
      /// </summary>
      public string Warehouse_Intro
      {
         get{ return warehouse_Intro; }
         set{ warehouse_Intro = value; warehouse_Intro_IsChanged=true; }
      }
      /// <summary>
      /// 仓库情况描述
      /// </summary>
      public bool Warehouse_Intro_IsChanged
      {
         get{ return warehouse_Intro_IsChanged; }
         set{ warehouse_Intro_IsChanged = value; }
      }
      /// <summary>
      /// 仓库用途
      /// </summary>
      private string warehouse_Usage;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_Usage_IsChanged=false;
      /// <summary>
      /// 仓库用途
      /// </summary>
      public string Warehouse_Usage
      {
         get{ return warehouse_Usage; }
         set{ warehouse_Usage = value; warehouse_Usage_IsChanged=true; }
      }
      /// <summary>
      /// 仓库用途
      /// </summary>
      public bool Warehouse_Usage_IsChanged
      {
         get{ return warehouse_Usage_IsChanged; }
         set{ warehouse_Usage_IsChanged = value; }
      }
      /// <summary>
      /// 仓库详细地址
      /// </summary>
      private string warehouse_Addr;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_Addr_IsChanged=false;
      /// <summary>
      /// 仓库详细地址
      /// </summary>
      public string Warehouse_Addr
      {
         get{ return warehouse_Addr; }
         set{ warehouse_Addr = value; warehouse_Addr_IsChanged=true; }
      }
      /// <summary>
      /// 仓库详细地址
      /// </summary>
      public bool Warehouse_Addr_IsChanged
      {
         get{ return warehouse_Addr_IsChanged; }
         set{ warehouse_Addr_IsChanged = value; }
      }
      /// <summary>
      /// 上级仓库编码
      /// </summary>
      private string warehouse_PCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_PCode_IsChanged=false;
      /// <summary>
      /// 上级仓库编码
      /// </summary>
      public string Warehouse_PCode
      {
         get{ return warehouse_PCode; }
         set{ warehouse_PCode = value; warehouse_PCode_IsChanged=true; }
      }
      /// <summary>
      /// 上级仓库编码
      /// </summary>
      public bool Warehouse_PCode_IsChanged
      {
         get{ return warehouse_PCode_IsChanged; }
         set{ warehouse_PCode_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string warehouse_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string Warehouse_Company
      {
         get{ return warehouse_Company; }
         set{ warehouse_Company = value; warehouse_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool Warehouse_Company_IsChanged
      {
         get{ return warehouse_Company_IsChanged; }
         set{ warehouse_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string warehouse_CompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_CompanyCode_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string Warehouse_CompanyCode
      {
         get{ return warehouse_CompanyCode; }
         set{ warehouse_CompanyCode = value; warehouse_CompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool Warehouse_CompanyCode_IsChanged
      {
         get{ return warehouse_CompanyCode_IsChanged; }
         set{ warehouse_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string warehouse_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool warehouse_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string Warehouse_Remark
      {
         get{ return warehouse_Remark; }
         set{ warehouse_Remark = value; warehouse_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool Warehouse_Remark_IsChanged
      {
         get{ return warehouse_Remark_IsChanged; }
         set{ warehouse_Remark_IsChanged = value; }
      }
      private string warehouse_Type;
      private bool warehouse_Type_IsChanged=false;
      public string Warehouse_Type
      {
         get{ return warehouse_Type; }
         set{ warehouse_Type = value; warehouse_Type_IsChanged=true; }
      }
      public bool Warehouse_Type_IsChanged
      {
         get{ return warehouse_Type_IsChanged; }
         set{ warehouse_Type_IsChanged = value; }
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
      private string warehouse_Root;
      private bool warehouse_Root_IsChanged=false;
      public string Warehouse_Root
      {
         get{ return warehouse_Root; }
         set{ warehouse_Root = value; warehouse_Root_IsChanged=true; }
      }
      public bool Warehouse_Root_IsChanged
      {
         get{ return warehouse_Root_IsChanged; }
         set{ warehouse_Root_IsChanged = value; }
      }
      private string warehouse_RootName;
      private bool warehouse_RootName_IsChanged=false;
      public string Warehouse_RootName
      {
         get{ return warehouse_RootName; }
         set{ warehouse_RootName = value; warehouse_RootName_IsChanged=true; }
      }
      public bool Warehouse_RootName_IsChanged
      {
         get{ return warehouse_RootName_IsChanged; }
         set{ warehouse_RootName_IsChanged = value; }
      }
      private string warehouse_UDEF1;
      private bool warehouse_UDEF1_IsChanged=false;
      public string Warehouse_UDEF1
      {
         get{ return warehouse_UDEF1; }
         set{ warehouse_UDEF1 = value; warehouse_UDEF1_IsChanged=true; }
      }
      public bool Warehouse_UDEF1_IsChanged
      {
         get{ return warehouse_UDEF1_IsChanged; }
         set{ warehouse_UDEF1_IsChanged = value; }
      }
      private string warehouse_UDEF2;
      private bool warehouse_UDEF2_IsChanged=false;
      public string Warehouse_UDEF2
      {
         get{ return warehouse_UDEF2; }
         set{ warehouse_UDEF2 = value; warehouse_UDEF2_IsChanged=true; }
      }
      public bool Warehouse_UDEF2_IsChanged
      {
         get{ return warehouse_UDEF2_IsChanged; }
         set{ warehouse_UDEF2_IsChanged = value; }
      }
      private string warehouse_UDEF3;
      private bool warehouse_UDEF3_IsChanged=false;
      public string Warehouse_UDEF3
      {
         get{ return warehouse_UDEF3; }
         set{ warehouse_UDEF3 = value; warehouse_UDEF3_IsChanged=true; }
      }
      public bool Warehouse_UDEF3_IsChanged
      {
         get{ return warehouse_UDEF3_IsChanged; }
         set{ warehouse_UDEF3_IsChanged = value; }
      }
      private string warehouse_UDEF4;
      private bool warehouse_UDEF4_IsChanged=false;
      public string Warehouse_UDEF4
      {
         get{ return warehouse_UDEF4; }
         set{ warehouse_UDEF4 = value; warehouse_UDEF4_IsChanged=true; }
      }
      public bool Warehouse_UDEF4_IsChanged
      {
         get{ return warehouse_UDEF4_IsChanged; }
         set{ warehouse_UDEF4_IsChanged = value; }
      }
      private string warehouse_UDEF5;
      private bool warehouse_UDEF5_IsChanged=false;
      public string Warehouse_UDEF5
      {
         get{ return warehouse_UDEF5; }
         set{ warehouse_UDEF5 = value; warehouse_UDEF5_IsChanged=true; }
      }
      public bool Warehouse_UDEF5_IsChanged
      {
         get{ return warehouse_UDEF5_IsChanged; }
         set{ warehouse_UDEF5_IsChanged = value; }
      }
      private string warehouse_UDEF6;
      private bool warehouse_UDEF6_IsChanged=false;
      public string Warehouse_UDEF6
      {
         get{ return warehouse_UDEF6; }
         set{ warehouse_UDEF6 = value; warehouse_UDEF6_IsChanged=true; }
      }
      public bool Warehouse_UDEF6_IsChanged
      {
         get{ return warehouse_UDEF6_IsChanged; }
         set{ warehouse_UDEF6_IsChanged = value; }
      }
      private string warehouse_UDEF7;
      private bool warehouse_UDEF7_IsChanged=false;
      public string Warehouse_UDEF7
      {
         get{ return warehouse_UDEF7; }
         set{ warehouse_UDEF7 = value; warehouse_UDEF7_IsChanged=true; }
      }
      public bool Warehouse_UDEF7_IsChanged
      {
         get{ return warehouse_UDEF7_IsChanged; }
         set{ warehouse_UDEF7_IsChanged = value; }
      }
      private string warehouse_UDEF8;
      private bool warehouse_UDEF8_IsChanged=false;
      public string Warehouse_UDEF8
      {
         get{ return warehouse_UDEF8; }
         set{ warehouse_UDEF8 = value; warehouse_UDEF8_IsChanged=true; }
      }
      public bool Warehouse_UDEF8_IsChanged
      {
         get{ return warehouse_UDEF8_IsChanged; }
         set{ warehouse_UDEF8_IsChanged = value; }
      }
      private string warehouse_UDEF9;
      private bool warehouse_UDEF9_IsChanged=false;
      public string Warehouse_UDEF9
      {
         get{ return warehouse_UDEF9; }
         set{ warehouse_UDEF9 = value; warehouse_UDEF9_IsChanged=true; }
      }
      public bool Warehouse_UDEF9_IsChanged
      {
         get{ return warehouse_UDEF9_IsChanged; }
         set{ warehouse_UDEF9_IsChanged = value; }
      }
      private string warehouse_UDEF10;
      private bool warehouse_UDEF10_IsChanged=false;
      public string Warehouse_UDEF10
      {
         get{ return warehouse_UDEF10; }
         set{ warehouse_UDEF10 = value; warehouse_UDEF10_IsChanged=true; }
      }
      public bool Warehouse_UDEF10_IsChanged
      {
         get{ return warehouse_UDEF10_IsChanged; }
         set{ warehouse_UDEF10_IsChanged = value; }
      }
   }
}
