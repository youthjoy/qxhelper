using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 员工财务信息
   /// </summary>
   [Serializable]
   public partial class HR_In
   {
      /// <summary>
      /// 异动序号
      /// </summary>
      private decimal hM_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_ID_IsChanged=false;
      /// <summary>
      /// 异动序号
      /// </summary>
      public decimal HM_ID
      {
         get{ return hM_ID; }
         set{ hM_ID = value; hM_ID_IsChanged=true; }
      }
      /// <summary>
      /// 异动序号
      /// </summary>
      public bool HM_ID_IsChanged
      {
         get{ return hM_ID_IsChanged; }
         set{ hM_ID_IsChanged = value; }
      }
      /// <summary>
      /// 财务信息编码
      /// </summary>
      private string hM_InCode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_InCode_IsChanged=false;
      /// <summary>
      /// 财务信息编码
      /// </summary>
      public string HM_InCode
      {
         get{ return hM_InCode; }
         set{ hM_InCode = value; hM_InCode_IsChanged=true; }
      }
      /// <summary>
      /// 财务信息编码
      /// </summary>
      public bool HM_InCode_IsChanged
      {
         get{ return hM_InCode_IsChanged; }
         set{ hM_InCode_IsChanged = value; }
      }
      /// <summary>
      /// 异动类型
      /// </summary>
      private string hM_Type;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_Type_IsChanged=false;
      /// <summary>
      /// 异动类型
      /// </summary>
      public string HM_Type
      {
         get{ return hM_Type; }
         set{ hM_Type = value; hM_Type_IsChanged=true; }
      }
      /// <summary>
      /// 异动类型
      /// </summary>
      public bool HM_Type_IsChanged
      {
         get{ return hM_Type_IsChanged; }
         set{ hM_Type_IsChanged = value; }
      }
      /// <summary>
      /// 员工名称
      /// </summary>
      private string hM_EName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_EName_IsChanged=false;
      /// <summary>
      /// 员工名称
      /// </summary>
      public string HM_EName
      {
         get{ return hM_EName; }
         set{ hM_EName = value; hM_EName_IsChanged=true; }
      }
      /// <summary>
      /// 员工名称
      /// </summary>
      public bool HM_EName_IsChanged
      {
         get{ return hM_EName_IsChanged; }
         set{ hM_EName_IsChanged = value; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      private string hM_ECode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_ECode_IsChanged=false;
      /// <summary>
      /// 员工编码
      /// </summary>
      public string HM_ECode
      {
         get{ return hM_ECode; }
         set{ hM_ECode = value; hM_ECode_IsChanged=true; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      public bool HM_ECode_IsChanged
      {
         get{ return hM_ECode_IsChanged; }
         set{ hM_ECode_IsChanged = value; }
      }
      /// <summary>
      /// 原职位
      /// </summary>
      private string hM_OTitle;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_OTitle_IsChanged=false;
      /// <summary>
      /// 原职位
      /// </summary>
      public string HM_OTitle
      {
         get{ return hM_OTitle; }
         set{ hM_OTitle = value; hM_OTitle_IsChanged=true; }
      }
      /// <summary>
      /// 原职位
      /// </summary>
      public bool HM_OTitle_IsChanged
      {
         get{ return hM_OTitle_IsChanged; }
         set{ hM_OTitle_IsChanged = value; }
      }
      /// <summary>
      /// 原工资
      /// </summary>
      private double hM_OSalary;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_OSalary_IsChanged=false;
      /// <summary>
      /// 原工资
      /// </summary>
      public double HM_OSalary
      {
         get{ return hM_OSalary; }
         set{ hM_OSalary = value; hM_OSalary_IsChanged=true; }
      }
      /// <summary>
      /// 原工资
      /// </summary>
      public bool HM_OSalary_IsChanged
      {
         get{ return hM_OSalary_IsChanged; }
         set{ hM_OSalary_IsChanged = value; }
      }
      /// <summary>
      /// 现职位
      /// </summary>
      private string hM_CTitle;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_CTitle_IsChanged=false;
      /// <summary>
      /// 现职位
      /// </summary>
      public string HM_CTitle
      {
         get{ return hM_CTitle; }
         set{ hM_CTitle = value; hM_CTitle_IsChanged=true; }
      }
      /// <summary>
      /// 现职位
      /// </summary>
      public bool HM_CTitle_IsChanged
      {
         get{ return hM_CTitle_IsChanged; }
         set{ hM_CTitle_IsChanged = value; }
      }
      /// <summary>
      /// 现工资
      /// </summary>
      private double hM_CSalary;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_CSalary_IsChanged=false;
      /// <summary>
      /// 现工资
      /// </summary>
      public double HM_CSalary
      {
         get{ return hM_CSalary; }
         set{ hM_CSalary = value; hM_CSalary_IsChanged=true; }
      }
      /// <summary>
      /// 现工资
      /// </summary>
      public bool HM_CSalary_IsChanged
      {
         get{ return hM_CSalary_IsChanged; }
         set{ hM_CSalary_IsChanged = value; }
      }
      /// <summary>
      /// 说明
      /// </summary>
      private string hM_Content;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_Content_IsChanged=false;
      /// <summary>
      /// 说明
      /// </summary>
      public string HM_Content
      {
         get{ return hM_Content; }
         set{ hM_Content = value; hM_Content_IsChanged=true; }
      }
      /// <summary>
      /// 说明
      /// </summary>
      public bool HM_Content_IsChanged
      {
         get{ return hM_Content_IsChanged; }
         set{ hM_Content_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string hM_Bak;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hM_Bak_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string HM_Bak
      {
         get{ return hM_Bak; }
         set{ hM_Bak = value; hM_Bak_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool HM_Bak_IsChanged
      {
         get{ return hM_Bak_IsChanged; }
         set{ hM_Bak_IsChanged = value; }
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
