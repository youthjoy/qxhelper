using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 设备信息
   /// </summary>
   [Serializable]
   public partial class Equ_Information
   {
      /// <summary>
      /// 设备序号
      /// </summary>
      private decimal equInfo_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_ID_IsChanged=false;
      /// <summary>
      /// 设备序号
      /// </summary>
      public decimal EquInfo_ID
      {
         get{ return equInfo_ID; }
         set{ equInfo_ID = value; equInfo_ID_IsChanged=true; }
      }
      /// <summary>
      /// 设备序号
      /// </summary>
      public bool EquInfo_ID_IsChanged
      {
         get{ return equInfo_ID_IsChanged; }
         set{ equInfo_ID_IsChanged = value; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      private string equInfo_SupCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_SupCode_IsChanged=false;
      /// <summary>
      /// 供应商编码
      /// </summary>
      public string EquInfo_SupCode
      {
         get{ return equInfo_SupCode; }
         set{ equInfo_SupCode = value; equInfo_SupCode_IsChanged=true; }
      }
      /// <summary>
      /// 供应商编码
      /// </summary>
      public bool EquInfo_SupCode_IsChanged
      {
         get{ return equInfo_SupCode_IsChanged; }
         set{ equInfo_SupCode_IsChanged = value; }
      }
      /// <summary>
      /// 设备编码
      /// </summary>
      private string equInfo_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_Code_IsChanged=false;
      /// <summary>
      /// 设备编码
      /// </summary>
      public string EquInfo_Code
      {
         get{ return equInfo_Code; }
         set{ equInfo_Code = value; equInfo_Code_IsChanged=true; }
      }
      /// <summary>
      /// 设备编码
      /// </summary>
      public bool EquInfo_Code_IsChanged
      {
         get{ return equInfo_Code_IsChanged; }
         set{ equInfo_Code_IsChanged = value; }
      }
      /// <summary>
      /// 设备名称
      /// </summary>
      private string equInfo_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_Name_IsChanged=false;
      /// <summary>
      /// 设备名称
      /// </summary>
      public string EquInfo_Name
      {
         get{ return equInfo_Name; }
         set{ equInfo_Name = value; equInfo_Name_IsChanged=true; }
      }
      /// <summary>
      /// 设备名称
      /// </summary>
      public bool EquInfo_Name_IsChanged
      {
         get{ return equInfo_Name_IsChanged; }
         set{ equInfo_Name_IsChanged = value; }
      }
      /// <summary>
      /// 厂内编码
      /// </summary>
      private string equInfo_ICode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_ICode_IsChanged=false;
      /// <summary>
      /// 厂内编码
      /// </summary>
      public string EquInfo_ICode
      {
         get{ return equInfo_ICode; }
         set{ equInfo_ICode = value; equInfo_ICode_IsChanged=true; }
      }
      /// <summary>
      /// 厂内编码
      /// </summary>
      public bool EquInfo_ICode_IsChanged
      {
         get{ return equInfo_ICode_IsChanged; }
         set{ equInfo_ICode_IsChanged = value; }
      }
      /// <summary>
      /// 条形码
      /// </summary>
      private string equInfo_TCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_TCode_IsChanged=false;
      /// <summary>
      /// 条形码
      /// </summary>
      public string EquInfo_TCode
      {
         get{ return equInfo_TCode; }
         set{ equInfo_TCode = value; equInfo_TCode_IsChanged=true; }
      }
      /// <summary>
      /// 条形码
      /// </summary>
      public bool EquInfo_TCode_IsChanged
      {
         get{ return equInfo_TCode_IsChanged; }
         set{ equInfo_TCode_IsChanged = value; }
      }
      /// <summary>
      /// 型号
      /// </summary>
      private string equInfo_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_Spec_IsChanged=false;
      /// <summary>
      /// 型号
      /// </summary>
      public string EquInfo_Spec
      {
         get{ return equInfo_Spec; }
         set{ equInfo_Spec = value; equInfo_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 型号
      /// </summary>
      public bool EquInfo_Spec_IsChanged
      {
         get{ return equInfo_Spec_IsChanged; }
         set{ equInfo_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 生产厂家
      /// </summary>
      private string equInfo_Manu;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_Manu_IsChanged=false;
      /// <summary>
      /// 生产厂家
      /// </summary>
      public string EquInfo_Manu
      {
         get{ return equInfo_Manu; }
         set{ equInfo_Manu = value; equInfo_Manu_IsChanged=true; }
      }
      /// <summary>
      /// 生产厂家
      /// </summary>
      public bool EquInfo_Manu_IsChanged
      {
         get{ return equInfo_Manu_IsChanged; }
         set{ equInfo_Manu_IsChanged = value; }
      }
      /// <summary>
      /// 使用部门编码
      /// </summary>
      private string equInfo_DeptCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_DeptCode_IsChanged=false;
      /// <summary>
      /// 使用部门编码
      /// </summary>
      public string EquInfo_DeptCode
      {
         get{ return equInfo_DeptCode; }
         set{ equInfo_DeptCode = value; equInfo_DeptCode_IsChanged=true; }
      }
      /// <summary>
      /// 使用部门编码
      /// </summary>
      public bool EquInfo_DeptCode_IsChanged
      {
         get{ return equInfo_DeptCode_IsChanged; }
         set{ equInfo_DeptCode_IsChanged = value; }
      }
      /// <summary>
      /// 使用部门名称
      /// </summary>
      private string equInfo_DeptName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_DeptName_IsChanged=false;
      /// <summary>
      /// 使用部门名称
      /// </summary>
      public string EquInfo_DeptName
      {
         get{ return equInfo_DeptName; }
         set{ equInfo_DeptName = value; equInfo_DeptName_IsChanged=true; }
      }
      /// <summary>
      /// 使用部门名称
      /// </summary>
      public bool EquInfo_DeptName_IsChanged
      {
         get{ return equInfo_DeptName_IsChanged; }
         set{ equInfo_DeptName_IsChanged = value; }
      }
      /// <summary>
      /// 随主机附件
      /// </summary>
      private string equInfo_PartInfo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_PartInfo_IsChanged=false;
      /// <summary>
      /// 随主机附件
      /// </summary>
      public string EquInfo_PartInfo
      {
         get{ return equInfo_PartInfo; }
         set{ equInfo_PartInfo = value; equInfo_PartInfo_IsChanged=true; }
      }
      /// <summary>
      /// 随主机附件
      /// </summary>
      public bool EquInfo_PartInfo_IsChanged
      {
         get{ return equInfo_PartInfo_IsChanged; }
         set{ equInfo_PartInfo_IsChanged = value; }
      }
      /// <summary>
      /// 随机技术资料
      /// </summary>
      private string equInfo_TechInfo;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_TechInfo_IsChanged=false;
      /// <summary>
      /// 随机技术资料
      /// </summary>
      public string EquInfo_TechInfo
      {
         get{ return equInfo_TechInfo; }
         set{ equInfo_TechInfo = value; equInfo_TechInfo_IsChanged=true; }
      }
      /// <summary>
      /// 随机技术资料
      /// </summary>
      public bool EquInfo_TechInfo_IsChanged
      {
         get{ return equInfo_TechInfo_IsChanged; }
         set{ equInfo_TechInfo_IsChanged = value; }
      }
      /// <summary>
      /// 主要技术参数
      /// </summary>
      private string equInfo_TechVar;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_TechVar_IsChanged=false;
      /// <summary>
      /// 主要技术参数
      /// </summary>
      public string EquInfo_TechVar
      {
         get{ return equInfo_TechVar; }
         set{ equInfo_TechVar = value; equInfo_TechVar_IsChanged=true; }
      }
      /// <summary>
      /// 主要技术参数
      /// </summary>
      public bool EquInfo_TechVar_IsChanged
      {
         get{ return equInfo_TechVar_IsChanged; }
         set{ equInfo_TechVar_IsChanged = value; }
      }
      /// <summary>
      /// 放置地点
      /// </summary>
      private string equInfo_Addr;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_Addr_IsChanged=false;
      /// <summary>
      /// 放置地点
      /// </summary>
      public string EquInfo_Addr
      {
         get{ return equInfo_Addr; }
         set{ equInfo_Addr = value; equInfo_Addr_IsChanged=true; }
      }
      /// <summary>
      /// 放置地点
      /// </summary>
      public bool EquInfo_Addr_IsChanged
      {
         get{ return equInfo_Addr_IsChanged; }
         set{ equInfo_Addr_IsChanged = value; }
      }
      /// <summary>
      /// 设备类别
      /// </summary>
      private string equInfo_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_Type_IsChanged=false;
      /// <summary>
      /// 设备类别
      /// </summary>
      public string EquInfo_Type
      {
         get{ return equInfo_Type; }
         set{ equInfo_Type = value; equInfo_Type_IsChanged=true; }
      }
      /// <summary>
      /// 设备类别
      /// </summary>
      public bool EquInfo_Type_IsChanged
      {
         get{ return equInfo_Type_IsChanged; }
         set{ equInfo_Type_IsChanged = value; }
      }
      /// <summary>
      /// 合同编号
      /// </summary>
      private string equInfo_CCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_CCode_IsChanged=false;
      /// <summary>
      /// 合同编号
      /// </summary>
      public string EquInfo_CCode
      {
         get{ return equInfo_CCode; }
         set{ equInfo_CCode = value; equInfo_CCode_IsChanged=true; }
      }
      /// <summary>
      /// 合同编号
      /// </summary>
      public bool EquInfo_CCode_IsChanged
      {
         get{ return equInfo_CCode_IsChanged; }
         set{ equInfo_CCode_IsChanged = value; }
      }
      /// <summary>
      /// 购买成本
      /// </summary>
      private double equInfo_Cost;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_Cost_IsChanged=false;
      /// <summary>
      /// 购买成本
      /// </summary>
      public double EquInfo_Cost
      {
         get{ return equInfo_Cost; }
         set{ equInfo_Cost = value; equInfo_Cost_IsChanged=true; }
      }
      /// <summary>
      /// 购买成本
      /// </summary>
      public bool EquInfo_Cost_IsChanged
      {
         get{ return equInfo_Cost_IsChanged; }
         set{ equInfo_Cost_IsChanged = value; }
      }
      /// <summary>
      /// 折旧状态
      /// </summary>
      private string equInfo_IsFix;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool equInfo_IsFix_IsChanged=false;
      /// <summary>
      /// 折旧状态
      /// </summary>
      public string EquInfo_IsFix
      {
         get{ return equInfo_IsFix; }
         set{ equInfo_IsFix = value; equInfo_IsFix_IsChanged=true; }
      }
      /// <summary>
      /// 折旧状态
      /// </summary>
      public bool EquInfo_IsFix_IsChanged
      {
         get{ return equInfo_IsFix_IsChanged; }
         set{ equInfo_IsFix_IsChanged = value; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      private int stat;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool stat_IsChanged=false;
      /// <summary>
      /// 数据状态
      /// </summary>
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      /// <summary>
      /// 数据状态
      /// </summary>
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
   }
}
