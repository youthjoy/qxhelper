using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   [Serializable]
   public partial class TC_Equ
   {
      private decimal tCE_ID;
      private bool tCE_ID_IsChanged=false;
      public decimal TCE_ID
      {
         get{ return tCE_ID; }
         set{ tCE_ID = value; tCE_ID_IsChanged=true; }
      }
      public bool TCE_ID_IsChanged
      {
         get{ return tCE_ID_IsChanged; }
         set{ tCE_ID_IsChanged = value; }
      }
      private string tCE_Code;
      private bool tCE_Code_IsChanged=false;
      public string TCE_Code
      {
         get{ return tCE_Code; }
         set{ tCE_Code = value; tCE_Code_IsChanged=true; }
      }
      public bool TCE_Code_IsChanged
      {
         get{ return tCE_Code_IsChanged; }
         set{ tCE_Code_IsChanged = value; }
      }
      private string tCE_ECode;
      private bool tCE_ECode_IsChanged=false;
      public string TCE_ECode
      {
         get{ return tCE_ECode; }
         set{ tCE_ECode = value; tCE_ECode_IsChanged=true; }
      }
      public bool TCE_ECode_IsChanged
      {
         get{ return tCE_ECode_IsChanged; }
         set{ tCE_ECode_IsChanged = value; }
      }
      private string tCE_Spec;
      private bool tCE_Spec_IsChanged=false;
      public string TCE_Spec
      {
         get{ return tCE_Spec; }
         set{ tCE_Spec = value; tCE_Spec_IsChanged=true; }
      }
      public bool TCE_Spec_IsChanged
      {
         get{ return tCE_Spec_IsChanged; }
         set{ tCE_Spec_IsChanged = value; }
      }
      private string tCE_Date;
      private bool tCE_Date_IsChanged=false;
      public string TCE_Date
      {
         get{ return tCE_Date; }
         set{ tCE_Date = value; tCE_Date_IsChanged=true; }
      }
      public bool TCE_Date_IsChanged
      {
         get{ return tCE_Date_IsChanged; }
         set{ tCE_Date_IsChanged = value; }
      }
      private string tCE_Checker;
      private bool tCE_Checker_IsChanged=false;
      public string TCE_Checker
      {
         get{ return tCE_Checker; }
         set{ tCE_Checker = value; tCE_Checker_IsChanged=true; }
      }
      public bool TCE_Checker_IsChanged
      {
         get{ return tCE_Checker_IsChanged; }
         set{ tCE_Checker_IsChanged = value; }
      }
      private DateTime tCE_CheckDate;
      private bool tCE_CheckDate_IsChanged=false;
      public DateTime TCE_CheckDate
      {
         get{ return tCE_CheckDate; }
         set{ tCE_CheckDate = value; tCE_CheckDate_IsChanged=true; }
      }
      public bool TCE_CheckDate_IsChanged
      {
         get{ return tCE_CheckDate_IsChanged; }
         set{ tCE_CheckDate_IsChanged = value; }
      }
      private string tCE_Operator;
      private bool tCE_Operator_IsChanged=false;
      public string TCE_Operator
      {
         get{ return tCE_Operator; }
         set{ tCE_Operator = value; tCE_Operator_IsChanged=true; }
      }
      public bool TCE_Operator_IsChanged
      {
         get{ return tCE_Operator_IsChanged; }
         set{ tCE_Operator_IsChanged = value; }
      }
      private DateTime tCE_OpDate;
      private bool tCE_OpDate_IsChanged=false;
      public DateTime TCE_OpDate
      {
         get{ return tCE_OpDate; }
         set{ tCE_OpDate = value; tCE_OpDate_IsChanged=true; }
      }
      public bool TCE_OpDate_IsChanged
      {
         get{ return tCE_OpDate_IsChanged; }
         set{ tCE_OpDate_IsChanged = value; }
      }
      private string tCE_Company;
      private bool tCE_Company_IsChanged=false;
      public string TCE_Company
      {
         get{ return tCE_Company; }
         set{ tCE_Company = value; tCE_Company_IsChanged=true; }
      }
      public bool TCE_Company_IsChanged
      {
         get{ return tCE_Company_IsChanged; }
         set{ tCE_Company_IsChanged = value; }
      }
      private string tCE_Dept;
      private bool tCE_Dept_IsChanged=false;
      public string TCE_Dept
      {
         get{ return tCE_Dept; }
         set{ tCE_Dept = value; tCE_Dept_IsChanged=true; }
      }
      public bool TCE_Dept_IsChanged
      {
         get{ return tCE_Dept_IsChanged; }
         set{ tCE_Dept_IsChanged = value; }
      }
      private string tCE_Description;
      private bool tCE_Description_IsChanged=false;
      public string TCE_Description
      {
         get{ return tCE_Description; }
         set{ tCE_Description = value; tCE_Description_IsChanged=true; }
      }
      public bool TCE_Description_IsChanged
      {
         get{ return tCE_Description_IsChanged; }
         set{ tCE_Description_IsChanged = value; }
      }
      private string tCE_Remark;
      private bool tCE_Remark_IsChanged=false;
      public string TCE_Remark
      {
         get{ return tCE_Remark; }
         set{ tCE_Remark = value; tCE_Remark_IsChanged=true; }
      }
      public bool TCE_Remark_IsChanged
      {
         get{ return tCE_Remark_IsChanged; }
         set{ tCE_Remark_IsChanged = value; }
      }
      private string tCE_UDef1;
      private bool tCE_UDef1_IsChanged=false;
      public string TCE_UDef1
      {
         get{ return tCE_UDef1; }
         set{ tCE_UDef1 = value; tCE_UDef1_IsChanged=true; }
      }
      public bool TCE_UDef1_IsChanged
      {
         get{ return tCE_UDef1_IsChanged; }
         set{ tCE_UDef1_IsChanged = value; }
      }
      private string tCE_UDef2;
      private bool tCE_UDef2_IsChanged=false;
      public string TCE_UDef2
      {
         get{ return tCE_UDef2; }
         set{ tCE_UDef2 = value; tCE_UDef2_IsChanged=true; }
      }
      public bool TCE_UDef2_IsChanged
      {
         get{ return tCE_UDef2_IsChanged; }
         set{ tCE_UDef2_IsChanged = value; }
      }
      private string tCE_UDef3;
      private bool tCE_UDef3_IsChanged=false;
      public string TCE_UDef3
      {
         get{ return tCE_UDef3; }
         set{ tCE_UDef3 = value; tCE_UDef3_IsChanged=true; }
      }
      public bool TCE_UDef3_IsChanged
      {
         get{ return tCE_UDef3_IsChanged; }
         set{ tCE_UDef3_IsChanged = value; }
      }
      private string tCE_UDef4;
      private bool tCE_UDef4_IsChanged=false;
      public string TCE_UDef4
      {
         get{ return tCE_UDef4; }
         set{ tCE_UDef4 = value; tCE_UDef4_IsChanged=true; }
      }
      public bool TCE_UDef4_IsChanged
      {
         get{ return tCE_UDef4_IsChanged; }
         set{ tCE_UDef4_IsChanged = value; }
      }
      private string tCE_UDef5;
      private bool tCE_UDef5_IsChanged=false;
      public string TCE_UDef5
      {
         get{ return tCE_UDef5; }
         set{ tCE_UDef5 = value; tCE_UDef5_IsChanged=true; }
      }
      public bool TCE_UDef5_IsChanged
      {
         get{ return tCE_UDef5_IsChanged; }
         set{ tCE_UDef5_IsChanged = value; }
      }
      private string tCE_UDef6;
      private bool tCE_UDef6_IsChanged=false;
      public string TCE_UDef6
      {
         get{ return tCE_UDef6; }
         set{ tCE_UDef6 = value; tCE_UDef6_IsChanged=true; }
      }
      public bool TCE_UDef6_IsChanged
      {
         get{ return tCE_UDef6_IsChanged; }
         set{ tCE_UDef6_IsChanged = value; }
      }
      private string tCE_TCode;
      private bool tCE_TCode_IsChanged=false;
      public string TCE_TCode
      {
         get{ return tCE_TCode; }
         set{ tCE_TCode = value; tCE_TCode_IsChanged=true; }
      }
      public bool TCE_TCode_IsChanged
      {
         get{ return tCE_TCode_IsChanged; }
         set{ tCE_TCode_IsChanged = value; }
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
      private DateTime createDate;
      private bool createDate_IsChanged=false;
      public DateTime CreateDate
      {
         get{ return createDate; }
         set{ createDate = value; createDate_IsChanged=true; }
      }
      public bool CreateDate_IsChanged
      {
         get{ return createDate_IsChanged; }
         set{ createDate_IsChanged = value; }
      }
      private DateTime updateDate;
      private bool updateDate_IsChanged=false;
      public DateTime UpdateDate
      {
         get{ return updateDate; }
         set{ updateDate = value; updateDate_IsChanged=true; }
      }
      public bool UpdateDate_IsChanged
      {
         get{ return updateDate_IsChanged; }
         set{ updateDate_IsChanged = value; }
      }
      private DateTime deleteDate;
      private bool deleteDate_IsChanged=false;
      public DateTime DeleteDate
      {
         get{ return deleteDate; }
         set{ deleteDate = value; deleteDate_IsChanged=true; }
      }
      public bool DeleteDate_IsChanged
      {
         get{ return deleteDate_IsChanged; }
         set{ deleteDate_IsChanged = value; }
      }
   }
}
