using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 采购计划物料按天汇总表
   /// </summary>
   [Serializable]
   public partial class STA_MMPP_MDayCount
   {
      /// <summary>
      /// 序列号
      /// </summary>
      private decimal pP_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_ID_IsChanged=false;
      /// <summary>
      /// 序列号
      /// </summary>
      public decimal PP_ID
      {
         get{ return pP_ID; }
         set{ pP_ID = value; pP_ID_IsChanged=true; }
      }
      /// <summary>
      /// 序列号
      /// </summary>
      public bool PP_ID_IsChanged
      {
         get{ return pP_ID_IsChanged; }
         set{ pP_ID_IsChanged = value; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      private string pP_DeptCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_DeptCode_IsChanged=false;
      /// <summary>
      /// 部门编码
      /// </summary>
      public string PP_DeptCode
      {
         get{ return pP_DeptCode; }
         set{ pP_DeptCode = value; pP_DeptCode_IsChanged=true; }
      }
      /// <summary>
      /// 部门编码
      /// </summary>
      public bool PP_DeptCode_IsChanged
      {
         get{ return pP_DeptCode_IsChanged; }
         set{ pP_DeptCode_IsChanged = value; }
      }
      /// <summary>
      /// 部门名称
      /// </summary>
      private string pP_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_Dept_IsChanged=false;
      /// <summary>
      /// 部门名称
      /// </summary>
      public string PP_Dept
      {
         get{ return pP_Dept; }
         set{ pP_Dept = value; pP_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 部门名称
      /// </summary>
      public bool PP_Dept_IsChanged
      {
         get{ return pP_Dept_IsChanged; }
         set{ pP_Dept_IsChanged = value; }
      }
      /// <summary>
      /// 公司编码
      /// </summary>
      private string pP_CompanyCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_CompanyCode_IsChanged=false;
      /// <summary>
      /// 公司编码
      /// </summary>
      public string PP_CompanyCode
      {
         get{ return pP_CompanyCode; }
         set{ pP_CompanyCode = value; pP_CompanyCode_IsChanged=true; }
      }
      /// <summary>
      /// 公司编码
      /// </summary>
      public bool PP_CompanyCode_IsChanged
      {
         get{ return pP_CompanyCode_IsChanged; }
         set{ pP_CompanyCode_IsChanged = value; }
      }
      /// <summary>
      /// 公司名称
      /// </summary>
      private string pP_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_Company_IsChanged=false;
      /// <summary>
      /// 公司名称
      /// </summary>
      public string PP_Company
      {
         get{ return pP_Company; }
         set{ pP_Company = value; pP_Company_IsChanged=true; }
      }
      /// <summary>
      /// 公司名称
      /// </summary>
      public bool PP_Company_IsChanged
      {
         get{ return pP_Company_IsChanged; }
         set{ pP_Company_IsChanged = value; }
      }
      /// <summary>
      /// 日期
      /// </summary>
      private DateTime pP_DateTime;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_DateTime_IsChanged=false;
      /// <summary>
      /// 日期
      /// </summary>
      public DateTime PP_DateTime
      {
         get{ return pP_DateTime; }
         set{ pP_DateTime = value; pP_DateTime_IsChanged=true; }
      }
      /// <summary>
      /// 日期
      /// </summary>
      public bool PP_DateTime_IsChanged
      {
         get{ return pP_DateTime_IsChanged; }
         set{ pP_DateTime_IsChanged = value; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      private string pP_MCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_MCode_IsChanged=false;
      /// <summary>
      /// 物料编码
      /// </summary>
      public string PP_MCode
      {
         get{ return pP_MCode; }
         set{ pP_MCode = value; pP_MCode_IsChanged=true; }
      }
      /// <summary>
      /// 物料编码
      /// </summary>
      public bool PP_MCode_IsChanged
      {
         get{ return pP_MCode_IsChanged; }
         set{ pP_MCode_IsChanged = value; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      private string pP_MName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_MName_IsChanged=false;
      /// <summary>
      /// 物料名称
      /// </summary>
      public string PP_MName
      {
         get{ return pP_MName; }
         set{ pP_MName = value; pP_MName_IsChanged=true; }
      }
      /// <summary>
      /// 物料名称
      /// </summary>
      public bool PP_MName_IsChanged
      {
         get{ return pP_MName_IsChanged; }
         set{ pP_MName_IsChanged = value; }
      }
      /// <summary>
      /// 物料规格
      /// </summary>
      private string pP_Spec;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_Spec_IsChanged=false;
      /// <summary>
      /// 物料规格
      /// </summary>
      public string PP_Spec
      {
         get{ return pP_Spec; }
         set{ pP_Spec = value; pP_Spec_IsChanged=true; }
      }
      /// <summary>
      /// 物料规格
      /// </summary>
      public bool PP_Spec_IsChanged
      {
         get{ return pP_Spec_IsChanged; }
         set{ pP_Spec_IsChanged = value; }
      }
      /// <summary>
      /// 当天计划数量
      /// </summary>
      private int pP_PlanCount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_PlanCount_IsChanged=false;
      /// <summary>
      /// 当天计划数量
      /// </summary>
      public int PP_PlanCount
      {
         get{ return pP_PlanCount; }
         set{ pP_PlanCount = value; pP_PlanCount_IsChanged=true; }
      }
      /// <summary>
      /// 当天计划数量
      /// </summary>
      public bool PP_PlanCount_IsChanged
      {
         get{ return pP_PlanCount_IsChanged; }
         set{ pP_PlanCount_IsChanged = value; }
      }
      /// <summary>
      /// 当天领用数量
      /// </summary>
      private int pP_ROCount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_ROCount_IsChanged=false;
      /// <summary>
      /// 当天领用数量
      /// </summary>
      public int PP_ROCount
      {
         get{ return pP_ROCount; }
         set{ pP_ROCount = value; pP_ROCount_IsChanged=true; }
      }
      /// <summary>
      /// 当天领用数量
      /// </summary>
      public bool PP_ROCount_IsChanged
      {
         get{ return pP_ROCount_IsChanged; }
         set{ pP_ROCount_IsChanged = value; }
      }
      private int stat;
      private bool stat_IsChanged=false;
      public int Stat
      {
         get{ return stat; }
         set{ stat = value; stat_IsChanged=true; }
      }
      public bool Stat_IsChanged
      {
         get{ return stat_IsChanged; }
         set{ stat_IsChanged = value; }
      }
   }
}
