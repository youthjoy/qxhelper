using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 食堂物资记录
   /// </summary>
   [Serializable]
   public partial class CanteenItem_Record
   {
      /// <summary>
      /// 食堂物资序号
      /// </summary>
      private decimal cIR_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cIR_ID_IsChanged=false;
      /// <summary>
      /// 食堂物资序号
      /// </summary>
      public decimal CIR_ID
      {
         get{ return cIR_ID; }
         set{ cIR_ID = value; cIR_ID_IsChanged=true; }
      }
      /// <summary>
      /// 食堂物资序号
      /// </summary>
      public bool CIR_ID_IsChanged
      {
         get{ return cIR_ID_IsChanged; }
         set{ cIR_ID_IsChanged = value; }
      }
      /// <summary>
      /// 食堂物资编码
      /// </summary>
      private string cIR_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cIR_Code_IsChanged=false;
      /// <summary>
      /// 食堂物资编码
      /// </summary>
      public string CIR_Code
      {
         get{ return cIR_Code; }
         set{ cIR_Code = value; cIR_Code_IsChanged=true; }
      }
      /// <summary>
      /// 食堂物资编码
      /// </summary>
      public bool CIR_Code_IsChanged
      {
         get{ return cIR_Code_IsChanged; }
         set{ cIR_Code_IsChanged = value; }
      }
      /// <summary>
      /// 物资名称
      /// </summary>
      private string cIR_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cIR_Name_IsChanged=false;
      /// <summary>
      /// 物资名称
      /// </summary>
      public string CIR_Name
      {
         get{ return cIR_Name; }
         set{ cIR_Name = value; cIR_Name_IsChanged=true; }
      }
      /// <summary>
      /// 物资名称
      /// </summary>
      public bool CIR_Name_IsChanged
      {
         get{ return cIR_Name_IsChanged; }
         set{ cIR_Name_IsChanged = value; }
      }
      /// <summary>
      /// 品牌型号
      /// </summary>
      private string cIR_Model;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cIR_Model_IsChanged=false;
      /// <summary>
      /// 品牌型号
      /// </summary>
      public string CIR_Model
      {
         get{ return cIR_Model; }
         set{ cIR_Model = value; cIR_Model_IsChanged=true; }
      }
      /// <summary>
      /// 品牌型号
      /// </summary>
      public bool CIR_Model_IsChanged
      {
         get{ return cIR_Model_IsChanged; }
         set{ cIR_Model_IsChanged = value; }
      }
      private string cIR_CanteenItemCode;
      private bool cIR_CanteenItemCode_IsChanged=false;
      public string CIR_CanteenItemCode
      {
         get{ return cIR_CanteenItemCode; }
         set{ cIR_CanteenItemCode = value; cIR_CanteenItemCode_IsChanged=true; }
      }
      public bool CIR_CanteenItemCode_IsChanged
      {
         get{ return cIR_CanteenItemCode_IsChanged; }
         set{ cIR_CanteenItemCode_IsChanged = value; }
      }
      /// <summary>
      /// 购买日期
      /// </summary>
      private DateTime cIR_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cIR_Date_IsChanged=false;
      /// <summary>
      /// 购买日期
      /// </summary>
      public DateTime CIR_Date
      {
         get{ return cIR_Date; }
         set{ cIR_Date = value; cIR_Date_IsChanged=true; }
      }
      /// <summary>
      /// 购买日期
      /// </summary>
      public bool CIR_Date_IsChanged
      {
         get{ return cIR_Date_IsChanged; }
         set{ cIR_Date_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private decimal cIR_Money;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cIR_Money_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public decimal CIR_Money
      {
         get{ return cIR_Money; }
         set{ cIR_Money = value; cIR_Money_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool CIR_Money_IsChanged
      {
         get{ return cIR_Money_IsChanged; }
         set{ cIR_Money_IsChanged = value; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      private string cIR_Remark;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cIR_Remark_IsChanged=false;
      /// <summary>
      /// 备注
      /// </summary>
      public string CIR_Remark
      {
         get{ return cIR_Remark; }
         set{ cIR_Remark = value; cIR_Remark_IsChanged=true; }
      }
      /// <summary>
      /// 备注
      /// </summary>
      public bool CIR_Remark_IsChanged
      {
         get{ return cIR_Remark_IsChanged; }
         set{ cIR_Remark_IsChanged = value; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      private string cIR_Company;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cIR_Company_IsChanged=false;
      /// <summary>
      /// 所属公司
      /// </summary>
      public string CIR_Company
      {
         get{ return cIR_Company; }
         set{ cIR_Company = value; cIR_Company_IsChanged=true; }
      }
      /// <summary>
      /// 所属公司
      /// </summary>
      public bool CIR_Company_IsChanged
      {
         get{ return cIR_Company_IsChanged; }
         set{ cIR_Company_IsChanged = value; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      private string cIR_Dept;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool cIR_Dept_IsChanged=false;
      /// <summary>
      /// 所属部门
      /// </summary>
      public string CIR_Dept
      {
         get{ return cIR_Dept; }
         set{ cIR_Dept = value; cIR_Dept_IsChanged=true; }
      }
      /// <summary>
      /// 所属部门
      /// </summary>
      public bool CIR_Dept_IsChanged
      {
         get{ return cIR_Dept_IsChanged; }
         set{ cIR_Dept_IsChanged = value; }
      }
      private decimal cIR_Num;
      private bool cIR_Num_IsChanged=false;
      public decimal CIR_Num
      {
         get{ return cIR_Num; }
         set{ cIR_Num = value; cIR_Num_IsChanged=true; }
      }
      public bool CIR_Num_IsChanged
      {
         get{ return cIR_Num_IsChanged; }
         set{ cIR_Num_IsChanged = value; }
      }
      private decimal cIR_Price;
      private bool cIR_Price_IsChanged=false;
      public decimal CIR_Price
      {
         get{ return cIR_Price; }
         set{ cIR_Price = value; cIR_Price_IsChanged=true; }
      }
      public bool CIR_Price_IsChanged
      {
         get{ return cIR_Price_IsChanged; }
         set{ cIR_Price_IsChanged = value; }
      }
      private string cIR_Unit;
      private bool cIR_Unit_IsChanged=false;
      public string CIR_Unit
      {
         get{ return cIR_Unit; }
         set{ cIR_Unit = value; cIR_Unit_IsChanged=true; }
      }
      public bool CIR_Unit_IsChanged
      {
         get{ return cIR_Unit_IsChanged; }
         set{ cIR_Unit_IsChanged = value; }
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
