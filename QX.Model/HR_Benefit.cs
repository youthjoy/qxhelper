using System;
using System.Data;
using System.ComponentModel.DataAnnotations;

namespace QX.Model
{
   /// <summary>
   /// 员工福利情况
   /// </summary>
   [Serializable]
   public partial class HR_Benefit
   {
      /// <summary>
      /// 福利序号
      /// </summary>
      private decimal hRB_ID;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_ID_IsChanged=false;
      /// <summary>
      /// 福利序号
      /// </summary>
      public decimal HRB_ID
      {
         get{ return hRB_ID; }
         set{ hRB_ID = value; hRB_ID_IsChanged=true; }
      }
      /// <summary>
      /// 福利序号
      /// </summary>
      public bool HRB_ID_IsChanged
      {
         get{ return hRB_ID_IsChanged; }
         set{ hRB_ID_IsChanged = value; }
      }
      /// <summary>
      /// 员工福利编码
      /// </summary>
      private string hRB_Code;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_Code_IsChanged=false;
      /// <summary>
      /// 员工福利编码
      /// </summary>
      public string HRB_Code
      {
         get{ return hRB_Code; }
         set{ hRB_Code = value; hRB_Code_IsChanged=true; }
      }
      /// <summary>
      /// 员工福利编码
      /// </summary>
      public bool HRB_Code_IsChanged
      {
         get{ return hRB_Code_IsChanged; }
         set{ hRB_Code_IsChanged = value; }
      }
      /// <summary>
      /// 员工名称
      /// </summary>
      private string hRB_EName;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_EName_IsChanged=false;
      /// <summary>
      /// 员工名称
      /// </summary>
      public string HRB_EName
      {
         get{ return hRB_EName; }
         set{ hRB_EName = value; hRB_EName_IsChanged=true; }
      }
      /// <summary>
      /// 员工名称
      /// </summary>
      public bool HRB_EName_IsChanged
      {
         get{ return hRB_EName_IsChanged; }
         set{ hRB_EName_IsChanged = value; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      private string hRB_ECode;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_ECode_IsChanged=false;
      /// <summary>
      /// 员工编码
      /// </summary>
      public string HRB_ECode
      {
         get{ return hRB_ECode; }
         set{ hRB_ECode = value; hRB_ECode_IsChanged=true; }
      }
      /// <summary>
      /// 员工编码
      /// </summary>
      public bool HRB_ECode_IsChanged
      {
         get{ return hRB_ECode_IsChanged; }
         set{ hRB_ECode_IsChanged = value; }
      }
      /// <summary>
      /// 福利关键字
      /// </summary>
      private string hRB_Key;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_Key_IsChanged=false;
      /// <summary>
      /// 福利关键字
      /// </summary>
      public string HRB_Key
      {
         get{ return hRB_Key; }
         set{ hRB_Key = value; hRB_Key_IsChanged=true; }
      }
      /// <summary>
      /// 福利关键字
      /// </summary>
      public bool HRB_Key_IsChanged
      {
         get{ return hRB_Key_IsChanged; }
         set{ hRB_Key_IsChanged = value; }
      }
      /// <summary>
      /// 福利名称
      /// </summary>
      private string hRB_Name;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_Name_IsChanged=false;
      /// <summary>
      /// 福利名称
      /// </summary>
      public string HRB_Name
      {
         get{ return hRB_Name; }
         set{ hRB_Name = value; hRB_Name_IsChanged=true; }
      }
      /// <summary>
      /// 福利名称
      /// </summary>
      public bool HRB_Name_IsChanged
      {
         get{ return hRB_Name_IsChanged; }
         set{ hRB_Name_IsChanged = value; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      private double hRB_Sum;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_Sum_IsChanged=false;
      /// <summary>
      /// 金额
      /// </summary>
      public double HRB_Sum
      {
         get{ return hRB_Sum; }
         set{ hRB_Sum = value; hRB_Sum_IsChanged=true; }
      }
      /// <summary>
      /// 金额
      /// </summary>
      public bool HRB_Sum_IsChanged
      {
         get{ return hRB_Sum_IsChanged; }
         set{ hRB_Sum_IsChanged = value; }
      }
      /// <summary>
      /// 是否办理
      /// </summary>
      private string hRB_IsDone;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_IsDone_IsChanged=false;
      /// <summary>
      /// 是否办理
      /// </summary>
      public string HRB_IsDone
      {
         get{ return hRB_IsDone; }
         set{ hRB_IsDone = value; hRB_IsDone_IsChanged=true; }
      }
      /// <summary>
      /// 是否办理
      /// </summary>
      public bool HRB_IsDone_IsChanged
      {
         get{ return hRB_IsDone_IsChanged; }
         set{ hRB_IsDone_IsChanged = value; }
      }
      /// <summary>
      /// 办理时间
      /// </summary>
      private DateTime hRB_Date;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_Date_IsChanged=false;
      /// <summary>
      /// 办理时间
      /// </summary>
      public DateTime HRB_Date
      {
         get{ return hRB_Date; }
         set{ hRB_Date = value; hRB_Date_IsChanged=true; }
      }
      /// <summary>
      /// 办理时间
      /// </summary>
      public bool HRB_Date_IsChanged
      {
         get{ return hRB_Date_IsChanged; }
         set{ hRB_Date_IsChanged = value; }
      }
      /// <summary>
      /// 下一次办理时间
      /// </summary>
      private DateTime hRB_NextDate;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_NextDate_IsChanged=false;
      /// <summary>
      /// 下一次办理时间
      /// </summary>
      public DateTime HRB_NextDate
      {
         get{ return hRB_NextDate; }
         set{ hRB_NextDate = value; hRB_NextDate_IsChanged=true; }
      }
      /// <summary>
      /// 下一次办理时间
      /// </summary>
      public bool HRB_NextDate_IsChanged
      {
         get{ return hRB_NextDate_IsChanged; }
         set{ hRB_NextDate_IsChanged = value; }
      }
      /// <summary>
      /// 备注1
      /// </summary>
      private string hRB_Bak1;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_Bak1_IsChanged=false;
      /// <summary>
      /// 备注1
      /// </summary>
      public string HRB_Bak1
      {
         get{ return hRB_Bak1; }
         set{ hRB_Bak1 = value; hRB_Bak1_IsChanged=true; }
      }
      /// <summary>
      /// 备注1
      /// </summary>
      public bool HRB_Bak1_IsChanged
      {
         get{ return hRB_Bak1_IsChanged; }
         set{ hRB_Bak1_IsChanged = value; }
      }
      /// <summary>
      /// 备注2
      /// </summary>
      private string hRB_Bak2;
      /// <summary>
      /// 改变标识
      /// </summary>
      private bool hRB_Bak2_IsChanged=false;
      /// <summary>
      /// 备注2
      /// </summary>
      public string HRB_Bak2
      {
         get{ return hRB_Bak2; }
         set{ hRB_Bak2 = value; hRB_Bak2_IsChanged=true; }
      }
      /// <summary>
      /// 备注2
      /// </summary>
      public bool HRB_Bak2_IsChanged
      {
         get{ return hRB_Bak2_IsChanged; }
         set{ hRB_Bak2_IsChanged = value; }
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
