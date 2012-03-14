using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 采购计划中间汇总表
   /// </summary>
   [Serializable]
   public partial class STA_MMPP_DayCount
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
      /// 部门
      /// </summary>
      private string pP_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_Dept_IsChanged=false;
      /// <summary>
      /// 部门
      /// </summary>
      public string PP_Dept
      {
         get{ return pP_Dept; }
         set{ pP_Dept = value; pP_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 部门
      /// </summary>
      public bool PP_Dept_IsChanged
      {
         get{ return pP_Dept_IsChanged; }
         set{ pP_Dept_IsChanged = value; }
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
      /// 公司
      /// </summary>
      private string pP_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_Company_IsChanged=false;
      /// <summary>
      /// 公司
      /// </summary>
      public string PP_Company
      {
         get{ return pP_Company; }
         set{ pP_Company = value; pP_Company_IsChanged=true; }
      }
      /// <summary>
      /// 公司
      /// </summary>
      public bool PP_Company_IsChanged
      {
         get{ return pP_Company_IsChanged; }
         set{ pP_Company_IsChanged = value; }
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
      /// 计划次数
      /// </summary>
      private int pP_PCount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_PCount_IsChanged=false;
      /// <summary>
      /// 计划次数
      /// </summary>
      public int PP_PCount
      {
         get{ return pP_PCount; }
         set{ pP_PCount = value; pP_PCount_IsChanged=true; }
      }
      /// <summary>
      /// 计划次数
      /// </summary>
      public bool PP_PCount_IsChanged
      {
         get{ return pP_PCount_IsChanged; }
         set{ pP_PCount_IsChanged = value; }
      }
      /// <summary>
      /// 领用次数
      /// </summary>
      private int pP_UCount;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_UCount_IsChanged=false;
      /// <summary>
      /// 领用次数
      /// </summary>
      public int PP_UCount
      {
         get{ return pP_UCount; }
         set{ pP_UCount = value; pP_UCount_IsChanged=true; }
      }
      /// <summary>
      /// 领用次数
      /// </summary>
      public bool PP_UCount_IsChanged
      {
         get{ return pP_UCount_IsChanged; }
         set{ pP_UCount_IsChanged = value; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      private string pP_RType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_RType_IsChanged=false;
      /// <summary>
      /// 单据类型
      /// </summary>
      public string PP_RType
      {
         get{ return pP_RType; }
         set{ pP_RType = value; pP_RType_IsChanged=true; }
      }
      /// <summary>
      /// 单据类型
      /// </summary>
      public bool PP_RType_IsChanged
      {
         get{ return pP_RType_IsChanged; }
         set{ pP_RType_IsChanged = value; }
      }
      /// <summary>
      /// 内部类型
      /// </summary>
      private string pP_iType;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool pP_iType_IsChanged=false;
      /// <summary>
      /// 内部类型
      /// </summary>
      public string PP_iType
      {
         get{ return pP_iType; }
         set{ pP_iType = value; pP_iType_IsChanged=true; }
      }
      /// <summary>
      /// 内部类型
      /// </summary>
      public bool PP_iType_IsChanged
      {
         get{ return pP_iType_IsChanged; }
         set{ pP_iType_IsChanged = value; }
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
